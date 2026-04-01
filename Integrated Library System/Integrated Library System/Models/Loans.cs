using System;

namespace Integrated_Library_System.Models
{
    [Serializable]
    public class Loan
    {
        // Modelo para sa loan (paghiram).
        // Nagre-record kung aling libro ang hiniram, sino ang borrower,
        // kailan hiniram, due date, kung kailan naibalik, at ang status.
        public int LoanId { get; set; }
        public int BookId { get; set; }
        public int BorrowerId { get; set; }
        public DateTime DateBorrowed { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? DateReturned { get; set; }
        public string Status { get; set; }
    }
}