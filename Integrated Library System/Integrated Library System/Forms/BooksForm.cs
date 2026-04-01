using Integrated_Library_System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Integrated_Library_System.Models;

namespace Integrated_Library_System.Forms
{
    public partial class BooksForm : Form
    {
        // Form para sa pamamahala ng mga libro: nagpapakita ng listahan,
        // nagpapahintulot mag-add, edit, delete at mag-search ng mga libro.
        public BooksForm()
        {
            InitializeComponent();
            cboGenre.SelectedIndex = 0;
            this.button2.Click += Button2_Click;
            this.button3.Click += Button3_Click;
            RefreshGrid();
        }

        private void RefreshGrid(List<Book> books = null)
        {
            var repo = LibraryRepository.Instance;
            var list = books ?? repo.Books.ToList();
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = list;
            lblCount.Text = $"{list.Count} book(s) found";
            // Tagalog: ino-update ang grid at ipinapakita ang bilang ng mga libro
            // Ginagawa din ng grid na mas readable ang column headers kung gusto pa.
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when genre changes, update search results
            Search();
        }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e)
        {
            var repo = LibraryRepository.Instance;
            var selected = dgvBooks.CurrentRow?.DataBoundItem as Book;
            if (selected == null)
            {
                MessageBox.Show("Please select a book to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete '{selected.Title}'?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            var final = MessageBox.Show("Are you sure SURE?", "Confirm delete (final)", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (final != DialogResult.Yes) return;

            repo.Books.RemoveAll(b => b.BookId == selected.BookId);
            Data.DataStore.SaveBooks(repo.Books);
            RefreshGrid();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            var repo = LibraryRepository.Instance;
            using (var f = new AddEditBookForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                if (f.ShowDialog(this) == DialogResult.OK && f.Book != null)
                {
                   
                    var nextId = repo.Books.Any() ? repo.Books.Max(b => b.BookId) + 1 : 1;
                    f.Book.BookId = nextId;
                 
                    f.Book.AvailableCopies = f.Book.TotalCopies;
                    repo.Books.Add(f.Book);
                    // save changes pagkatapos mag-add
                    Data.DataStore.SaveBooks(repo.Books);
                    RefreshGrid();
                }
            }
        }

       
        private void Button3_Click(object sender, EventArgs e)
        {
            var repo = LibraryRepository.Instance;
            var selected = dgvBooks.CurrentRow?.DataBoundItem as Book;
            if (selected == null)
            {
                MessageBox.Show("Please select a book to edit.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

         
            var editing = new Book
            {
                BookId = selected.BookId,
                Title = selected.Title,
                Author = selected.Author,
                Genre = selected.Genre,
                ISBN = selected.ISBN,
                Year = selected.Year,
                TotalCopies = selected.TotalCopies,
                AvailableCopies = selected.AvailableCopies
            };

            using (var f = new AddEditBookForm(editing))
            {
                f.StartPosition = FormStartPosition.CenterParent;
                if (f.ShowDialog(this) == DialogResult.OK && f.Book != null)
                {

                    var orig = repo.Books.FirstOrDefault(b => b.BookId == f.Book.BookId);
                    if (orig != null)
                    {
                        orig.Title = f.Book.Title;
                        orig.Author = f.Book.Author;
                        orig.Genre = f.Book.Genre;
                        orig.ISBN = f.Book.ISBN;
                        orig.Year = f.Book.Year;
                        var diff = f.Book.TotalCopies - orig.TotalCopies;
                        orig.TotalCopies = f.Book.TotalCopies;
                        orig.AvailableCopies = Math.Max(0, orig.AvailableCopies + diff);
                    }

                    Data.DataStore.SaveBooks(repo.Books);
                    RefreshGrid();

                   

                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            var repo = LibraryRepository.Instance;
            var keyword = textBox1.Text.Trim();
            var genre = cboGenre.SelectedItem?.ToString() ?? string.Empty;
            var results = repo.SearchBooks(genre, keyword);
            RefreshGrid(results);
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
