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
    public partial class AddEditBookForm : Form
    {
        // The book being added/edited. On OK the caller will read this property.
        public Integrated_Library_System.Models.Book Book { get; private set; }

        // default - add
        public AddEditBookForm()
        {
            InitializeComponent();
            InitializeForm(null);
        }

        // edit
        public AddEditBookForm(Integrated_Library_System.Models.Book book)
        {
            InitializeComponent();
            InitializeForm(book);
        }

        private void InitializeForm(Integrated_Library_System.Models.Book book)
        {
            // center relative to parent by default
            this.StartPosition = FormStartPosition.CenterParent;
            // set dialog title depending on mode
            this.Text = book == null ? "Add Book" : "Edit Book";
            // populate genre choices similar to main form
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "Fiction", "Non-Fiction", "Science", "History", "Technology", "Mathematics", "Literature", "Philosophy", "Biography", "Other" });
            comboBox1.SelectedIndex = 0;

            if (book != null)
            {
                Book = book;
                // populate fields
                textBox1.Text = Book.Title;
                textBox2.Text = Book.Author;
                comboBox1.SelectedItem = Book.Genre ?? comboBox1.Items[0];
                textBox3.Text = Book.ISBN;
                textBox4.Text = Book.Year.ToString();
                textBox5.Text = Book.TotalCopies.ToString();
            }

            // wire buttons
            button1.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Validate required text fields
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Title and Author are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate year
            if (!int.TryParse(textBox4.Text.Trim(), out int year) || year < 1000 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Enter a valid year.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate copies (must be integer >= 1)
            if (!int.TryParse(textBox5.Text.Trim(), out int copies) || copies < 1)
            {
                MessageBox.Show("Total copies must be a number and at least 1.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If editing, ensure new total copies is not less than number currently borrowed
            int originallyTotal = 0;
            int originallyAvailable = 0;
            bool isEdit = (Book != null && Book.BookId != 0);
            if (isEdit)
            {
                originallyTotal = Book.TotalCopies;
                originallyAvailable = Book.AvailableCopies;
                int borrowed = originallyTotal - originallyAvailable;
                if (copies < borrowed)
                {
                    MessageBox.Show($"Total copies cannot be less than number of borrowed copies ({borrowed}).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Create if needed
            if (Book == null) Book = new Integrated_Library_System.Models.Book();

            // assign values
            Book.Title = textBox1.Text.Trim();
            Book.Author = textBox2.Text.Trim();
            Book.Genre = comboBox1.SelectedItem?.ToString();
            Book.ISBN = textBox3.Text.Trim();
            Book.Year = year;

            if (!isEdit)
            {
                Book.TotalCopies = copies;
                Book.AvailableCopies = copies; // when adding, all copies are available
            }
            else
            {
                // editing: keep track of available copies and adjust by diff
                int diff = copies - originallyTotal;
                Book.TotalCopies = copies;
                Book.AvailableCopies = Math.Max(0, originallyAvailable + diff);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
