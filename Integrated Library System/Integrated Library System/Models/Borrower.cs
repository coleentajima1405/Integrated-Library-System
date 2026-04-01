using System;

namespace Integrated_Library_System.Models
{
    [Serializable]
    public class Borrower
    {
        // Modelo para sa borrower/miyembro ng librarya.
        // Naglalaman ng ID, pangalan, contact at petsa ng pagiging miyembro.
        public int BorrowerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime MembershipDate { get; set; }
    }
}