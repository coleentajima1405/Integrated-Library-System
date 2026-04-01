using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrated_Library_System.DTO
{
    public class LibraryStats
    {
        public int TotalBooks { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
        public int TotalBorrowers { get; set; }
        public int ActiveLoans { get; set; }
        public int OverdueLoans { get; set; }
        public int ReturnedLoans { get; set; }
        public int TotalLoans { get; set; }
        public double AvgCopiesPerBook { get; set; }
    }
}