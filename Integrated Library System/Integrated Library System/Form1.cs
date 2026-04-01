using Integrated_Library_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrated_Library_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDashboard();
            btnBooks.Click += (s, e) => OpenChild(new BooksForm());
            btnBorrowers.Click += (s, e) => OpenChild(new BorrowersForm());
            btnLoans.Click += (s, e) => OpenChild(new LoansForm());
            // auto-refresh dashboard every 30 seconds
            var timer = new Timer();
            timer.Interval = 30000; // 30s
            timer.Tick += (s, e) => LoadDashboard();
            timer.Start();
        }

        private void LoadDashboard()
        {
            var repo = Data.LibraryRepository.Instance;

            // Books
            var totalBooks = repo.Books?.Count ?? 0;
            // format with thousands separator
            label4.Text = totalBooks.ToString("N0");

            // Borrowers
            var totalBorrowers = repo.Borrowers?.Count ?? 0;
            label5.Text = totalBorrowers.ToString("N0");

            // Loans: total, active, returned, overdue
            var totalLoans = repo.Loans?.Count ?? 0;
            label11.Text = totalLoans.ToString("N0");

            var activeLoans = repo.Loans?.Count(l => string.Equals(l.Status, "Borrowed", StringComparison.OrdinalIgnoreCase)) ?? 0;
            label6.Text = activeLoans.ToString("N0");

            var returnedLoans = repo.Loans?.Count(l => string.Equals(l.Status, "Returned", StringComparison.OrdinalIgnoreCase)) ?? 0;
            label10.Text = returnedLoans.ToString("N0");

            var overdueLoans = repo.Loans?.Count(l => string.Equals(l.Status, "Borrowed", StringComparison.OrdinalIgnoreCase) && l.DueDate.Date < DateTime.Now.Date) ?? 0;
            label7.Text = overdueLoans.ToString("N0");

            // visual warning: palitan ang kulay ng panel kapag may overdue
            try
            {
                if (overdueLoans > 0)
                    panel5.BackColor = System.Drawing.Color.DarkRed;
                else
                    panel5.BackColor = System.Drawing.Color.Firebrick;
            }
            catch { }

            // Copies
            var totalCopies = repo.Books?.Sum(b => b.TotalCopies) ?? 0;
            label8.Text = totalCopies.ToString("N0");

            var availableCopies = repo.Books?.Sum(b => b.AvailableCopies) ?? 0;
            label9.Text = availableCopies.ToString("N0");
        }

        private void OpenChild(Form form)
        {
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            LoadDashboard();
        }
    }
}