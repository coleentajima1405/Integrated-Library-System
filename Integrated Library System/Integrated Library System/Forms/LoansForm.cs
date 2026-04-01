using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrated_Library_System.Forms
{
    public partial class LoansForm : Form
    {
        // Form para mag-manage ng loans: makita ang listahan ng mga paghiram,
        // maghanap, mag-return ng libro, at mag-borrow (magbukas ng BorrowBookForm).
        public LoansForm()
        {
            InitializeComponent();
            this.button3.Click += Button3_Click; // Return
            this.button4.Click += Button4_Click; // Borrow
            this.button1.Click += Button1_Click; // Search
            RefreshGrid();
        }

        private void RefreshGrid(List<Integrated_Library_System.Models.Loan> loans = null)
        {
            var repo = Data.LibraryRepository.Instance;
            var list = loans ?? repo.Loans.ToList();

            var rows = list.Select(l => new
            {
                l.LoanId,
                BookTitle = repo.Books.FirstOrDefault(b => b.BookId == l.BookId)?.Title ?? "",
                BorrowerName = repo.Borrowers.FirstOrDefault(b => b.BorrowerId == l.BorrowerId)?.Name ?? "",
                l.DateBorrowed,
                l.DueDate,
                l.DateReturned,
                l.Status
            }).ToList();

            dgvLoans.DataSource = null;
            dgvLoans.DataSource = rows;
            label1.Text = $"{rows.Count} loan(s)";
        }

        // Tagalog: Hanapin ang mga loans batay sa textbox (book title o borrower name).
        private void Button1_Click(object sender, EventArgs e)
        {
            var repo = Data.LibraryRepository.Instance;
            var term = textBox1.Text.Trim();
            var q = repo.Loans.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(term))
            {
                q = q.Where(l => (repo.Books.FirstOrDefault(b => b.BookId == l.BookId)?.Title ?? string.Empty).IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0
                             || (repo.Borrowers.FirstOrDefault(b => b.BorrowerId == l.BorrowerId)?.Name ?? string.Empty).IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0);
            }
            RefreshGrid(q.ToList());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // open borrow dialog
            using (var f = new BorrowBookForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        // Tagalog: Return handler para sa napiling loan. Tatawagin ang repository.ReturnLoan
        // at ia-update ang grid kapag matagumpay.
        private void Button3_Click(object sender, EventArgs e)
        {
            var repo = Data.LibraryRepository.Instance;
            // selected loan
            var row = dgvLoans.CurrentRow?.DataBoundItem;
            if (row == null)
            {
                MessageBox.Show("Please select a loan.", "Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // row is an anonymous type with LoanId property
            var loanIdProp = row.GetType().GetProperty("LoanId");
            if (loanIdProp == null) return;
            var loanId = (int)loanIdProp.GetValue(row);

            var (ok, message) = repo.ReturnLoan(loanId);
            if (!ok)
            {
                MessageBox.Show(message, "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Book returned.", "Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshGrid();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
