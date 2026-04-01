using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Library_System.DTO
{
    public class LoanDisplay
    {
        public int LoanId { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string BorrowerName { get; set; }
        public DateTime DateBorrowed { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? DateReturned { get; set; }
        public string Status { get; set; }
    }
}