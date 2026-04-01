using System;

namespace Integrated_Library_System.Models
{
    [Serializable]
    public class Book
    {
        // Modelo para sa libro. Ang klase na ito ay ginagamit para mag-imbak ng
        // impormasyon tungkol sa bawat libro sa librarya.
        // (Properties: BookId, Title, Author, Genre, Year, ISBN, TotalCopies, AvailableCopies)

        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
    }
}