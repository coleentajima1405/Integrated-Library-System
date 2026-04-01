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
    public partial class BorrowBookForm : Form
    {
        // Form para gumawa ng bagong loan (pag-hiram):
        // Pinipili dito ang libro (na may available copies), borrower, at duration.
        // Kapag nag-confirm, tatawagin ang repository upang mag-create ng loan at
        // babawasan ang available copies ng libro.
        public BorrowBookForm()
        {
            InitializeComponent();
            LoadData();
            button1.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            button2.Click += Button2_Click;
        }

        private void LoadData()
        {
            var repo = Data.LibraryRepository.Instance;
            // books with available copies
            var books = repo.Books.Where(b => b.AvailableCopies > 0).ToList();
            comboBox1.DataSource = books;
            comboBox1.DisplayMember = "Title";
            comboBox1.ValueMember = "BookId";

            var borrowers = repo.Borrowers.ToList();
            comboBox2.DataSource = borrowers;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "BorrowerId";

            // durations
            comboBox3.Items.Clear();
            comboBox3.Items.AddRange(new object[] { "7", "14", "21", "28" });
            comboBox3.SelectedIndex = 1; // default 14 days
        }

        // Tagalog: Handler kapag kinumpirma ang paghiram.
        // Tinitiyak na may napiling libro at borrower, kinukuha ang duration, at
        // tinatawag ang repository.CreateLoan para i-record ang loan.
        private void Button2_Click(object sender, EventArgs e)
        {
            var repo = Data.LibraryRepository.Instance;
            var book = comboBox1.SelectedItem as Integrated_Library_System.Models.Book;
            var borrower = comboBox2.SelectedItem as Integrated_Library_System.Models.Borrower;
            if (book == null)
            {
                MessageBox.Show("Please select a book.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (borrower == null)
            {
                MessageBox.Show("Please select a borrower.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(comboBox3.SelectedItem?.ToString() ?? "14", out int days)) days = 14;

            var (ok, message) = repo.CreateLoan(book.BookId, borrower.BorrowerId, days);
            if (!ok)
            {
                MessageBox.Show(message, "Borrow", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Book borrowed successfully.", "Borrow", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
