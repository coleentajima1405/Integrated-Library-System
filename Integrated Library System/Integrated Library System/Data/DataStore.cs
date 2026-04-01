using Integrated_Library_System.Models;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Integrated_Library_System.Data
{
    public static class DataStore
    {
        private static readonly string DataFolder = Path.Combine(Application.StartupPath, "Library Data");
        private static readonly string BooksFile = Path.Combine(DataFolder, "books.dat");
        private static readonly string BorrowersFile = Path.Combine(DataFolder, "borrowers.dat");
        private static readonly string LoansFile = Path.Combine(DataFolder, "loans.dat");

        static DataStore()
        {
            if (!Directory.Exists(DataFolder))
                Directory.CreateDirectory(DataFolder);
        }

        ///serialize
        private static void Save<T>(string path, T data)
        {
            using (var fs = new FileStream(path, FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(fs, data);
            }
        }
        ///deserialize
        private static T Load<T> (string path)
        {
            if (!File.Exists(path))
                return default(T);
            try
            {
                using (var fs = new FileStream(path, FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    return (T)formatter.Deserialize(fs);
                }
            }
            catch { return default(T); }
        }
        //books
        public static void SaveBooks(List<Book> books) => Save(BooksFile, books);

        public static List<Book> LoadBooks() => Load<List<Book>>(BooksFile) ?? new List<Book>();
        //borrowers
        public static void SaveBorrowers(List<Borrower> list) => Save(BorrowersFile, list);

        public static List<Borrower> LoadBorrower() => Load<List<Borrower>>(BorrowersFile) ?? new List<Borrower>();
        /// loan
        public static void SaveLoans(List<Loan> list) => Save(LoansFile, list);

        public static List<Loan> LoadLoans() => Load<List<Loan>>(LoansFile) ?? new List<Loan>();
    }
}

/*
 - DataStore is responsable sa pag-save at pag-load ng lists (Books, Borrowers, Loans)
 - Gumagamit ng BinaryFormatter para i-serialize ang mga list sa mga .dat files sa folder na "Library Data".
 - Kung wala pang file, nagbabalik ng bagong empty list.
 WARNING: BinaryFormatter is obsolete for new projects; acceptable here for simple local storage.
*/
