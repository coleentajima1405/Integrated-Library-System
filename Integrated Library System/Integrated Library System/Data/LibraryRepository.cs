using System;
using System.Collections.Generic;
using System.Linq;
using Integrated_Library_System.Models;
using Integrated_Library_System.DTO;

namespace Integrated_Library_System.Data
{
    public class LibraryRepository
    {
        // Repository na nagsisilbing in-memory store para sa buong app.
        // Ginagamit ito bilang singleton para madaling ma-access ng mga form at service.
        // Naglo-load ng data mula sa DataStore at nagse-save kapag may pagbabago.
         ///singleton pattern
        private static LibraryRepository _instance;
        public static LibraryRepository Instance => _instance ?? (_instance = new LibraryRepository());
        public List<Book> Books { get; private set; }
        public List<Borrower> Borrowers { get; private set; }
        public List<Loan> Loans { get; private set; }

        private LibraryRepository()
        {
            Books = DataStore.LoadBooks();
            Borrowers = DataStore.LoadBorrower();
            Loans = DataStore.LoadLoans();
        }

        /// <summary>
        /// Re-index borrower IDs to be sequential (1..N) and update any loans that reference borrowers.
        /// This preserves associations by mapping old IDs to new IDs.
        /// </summary>
        public void ReindexBorrowers()
        {
            // nire-resequence ang mga BorrowerId para maging 1..N,
            // at ina-update ang bawat Loan upang tumutok sa bagong BorrowerId.
            // create mapping from old id to new id based on current ordering by BorrowerId
            var ordered = Borrowers.OrderBy(b => b.BorrowerId).ToList();
            var map = new Dictionary<int, int>();
            for (int i = 0; i < ordered.Count; i++)
            {
                var old = ordered[i].BorrowerId;
                var neu = i + 1;
                map[old] = neu;
                ordered[i].BorrowerId = neu;
            }

            // update Loans to point to new borrower IDs
            foreach (var loan in Loans)
            {
                if (map.TryGetValue(loan.BorrowerId, out int newId))
                {
                    loan.BorrowerId = newId;
                }
            }

            // replace Borrowers list with ordered (now resequenced)
            Borrowers = ordered;

            Data.DataStore.SaveBorrowers(Borrowers);
            Data.DataStore.SaveLoans(Loans);
        }

        // Borrower helpers
        public List<Borrower> SearchBorrowers(string keyword)
        {
            var q = Borrowers.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var term = keyword.Trim();
                q = q.Where(b => (!string.IsNullOrEmpty(b.Name) && b.Name.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                                 || (!string.IsNullOrEmpty(b.Email) && b.Email.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                                 || (!string.IsNullOrEmpty(b.Phone) && b.Phone.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0));
            }
            return q.ToList();
        }

        // Loan helpers
        // Lumilikha ng bagong loan kung may available copy ang libro.
        // Binabawasan ang AvailableCopies ng libro at sine-save ang Loans at Books.
        public (bool ok, string message) CreateLoan(int bookId, int borrowerId, int days)
        {
            var book = Books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null) return (false, "Book not found");
            if (book.AvailableCopies <= 0) return (false, "No available copies");

            var borrower = Borrowers.FirstOrDefault(b => b.BorrowerId == borrowerId);
            if (borrower == null) return (false, "Borrower not found");

            var nextId = Loans.Any() ? Loans.Max(l => l.LoanId) + 1 : 1;
            var loan = new Loan
            {
                LoanId = nextId,
                BookId = bookId,
                BorrowerId = borrowerId,
                DateBorrowed = DateTime.Now,
                DueDate = DateTime.Now.AddDays(days),
                DateReturned = null,
                Status = "Borrowed"
            };

            Loans.Add(loan);
            book.AvailableCopies = Math.Max(0, book.AvailableCopies - 1);

            Data.DataStore.SaveLoans(Loans);
            Data.DataStore.SaveBooks(Books);
            return (true, "Loan created");
        }

        // Ire-record ang pagbabalik ng libro. Sineset ang DateReturned at
        // ina-update ang Book.AvailableCopies at sine-save ang mga pagbabago.
        public (bool ok, string message) ReturnLoan(int loanId)
        {
            var loan = Loans.FirstOrDefault(l => l.LoanId == loanId);
            if (loan == null) return (false, "Loan not found");
            if (loan.Status == "Returned") return (false, "Loan already returned");

            loan.DateReturned = DateTime.Now;
            loan.Status = "Returned";

            var book = Books.FirstOrDefault(b => b.BookId == loan.BookId);
            if (book != null)
            {
                book.AvailableCopies += 1;
            }

            Data.DataStore.SaveLoans(Loans);
            Data.DataStore.SaveBooks(Books);
            return (true, "Loan returned");
        }

        public void DeleteLoan(int loanId)
        {
            Loans.RemoveAll(l => l.LoanId == loanId);
            Data.DataStore.SaveLoans(Loans);
        }

        // Search helper used by UI
        public List<Book> SearchBooks(string genre, string keyword)
        {
            var q = Books.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(genre) && !genre.Equals("All Genres", StringComparison.OrdinalIgnoreCase))
            {
                q = q.Where(b => string.Equals(b.Genre ?? string.Empty, genre, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var term = keyword.Trim();
                q = q.Where(b => (!string.IsNullOrEmpty(b.Title) && b.Title.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                                 || (!string.IsNullOrEmpty(b.Author) && b.Author.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                                 || (!string.IsNullOrEmpty(b.ISBN) && b.ISBN.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0));
            }

            return q.ToList();
        }
    }
}
