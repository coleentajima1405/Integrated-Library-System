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
    public partial class BorrowersForm : Form
    {
        // Form para sa pamamahala ng mga borrowers (mga miyembro):
        // nagpapakita ng listahan, paghahanap, pagdagdag, pag-edit at pag-delete.
        public BorrowersForm()
        {
            InitializeComponent();
            this.button2.Click += Button2_Click; // Add
            this.button3.Click += Button3_Click; // Edit
            this.button4.Click += Button4_Click; // Delete
            this.button1.Click += Button1_Click; // Search
            RefreshGrid();
        }

        private void RefreshGrid(List<Integrated_Library_System.Models.Borrower> list = null)
        {
            var repo = Data.LibraryRepository.Instance;
            var data = list ?? repo.Borrowers.ToList();
            dgvBorrowers.DataSource = null;
            dgvBorrowers.DataSource = data;
            label1.Text = $"{data.Count} borrower(s) found";

            // Fix column headers to be more readable (e.g., BorrowerId -> Borrower Id)
            try
            {
                foreach (DataGridViewColumn col in dgvBorrowers.Columns)
                {
                    var prop = string.IsNullOrEmpty(col.DataPropertyName) ? col.Name : col.DataPropertyName;
                    if (string.IsNullOrEmpty(prop)) continue;
                    // insert space before capital letters (simple PascalCase split)
                    var header = System.Text.RegularExpressions.Regex.Replace(prop, "([a-z])([A-Z])", "$1 $2");
                    col.HeaderText = header;
                }
            }
            catch { }
        }

        // Tagalog: Hanapin ang borrowers batay sa keyword sa textbox.
        private void Button1_Click(object sender, EventArgs e)
        {
            var repo = Data.LibraryRepository.Instance;
            var keyword = textBox1.Text.Trim();
            var results = repo.SearchBorrowers(keyword);
            RefreshGrid(results);
        }

        // Tagalog: Buksan ang Add dialog para magdagdag ng bagong borrower.
        // Pagkatapos mag-save, i-reindex ang IDs upang manatiling sunod-sunod.
        private void Button2_Click(object sender, EventArgs e)
        {
            var repo = Data.LibraryRepository.Instance;
            using (var f = new AddEditBorrowerForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                if (f.ShowDialog(this) == DialogResult.OK && f.Borrower != null)
                {
                    // assign id as max existing id + 1 to avoid duplicates
                    var nextId = repo.Borrowers.Any() ? repo.Borrowers.Max(b => b.BorrowerId) + 1 : 1;
                    f.Borrower.BorrowerId = nextId;
                    f.Borrower.MembershipDate = DateTime.Now;
                    repo.Borrowers.Add(f.Borrower);
                    // ensure IDs remain consistent and update loans mapping if needed
                    repo.ReindexBorrowers();
                    RefreshGrid();
                }
            }
        }

        // Tagalog: Buksan ang Edit dialog para sa napiling borrower at i-save ang mga pagbabago.
        private void Button3_Click(object sender, EventArgs e)
        {
            var repo = Data.LibraryRepository.Instance;
            var selected = dgvBorrowers.CurrentRow?.DataBoundItem as Integrated_Library_System.Models.Borrower;
            if (selected == null)
            {
                MessageBox.Show("Please select a borrower to edit.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var copy = new Integrated_Library_System.Models.Borrower
            {
                BorrowerId = selected.BorrowerId,
                Name = selected.Name,
                Email = selected.Email,
                Phone = selected.Phone,
                MembershipDate = selected.MembershipDate
            };

            using (var f = new AddEditBorrowerForm())
            {
                f.StartPosition = FormStartPosition.CenterParent;
                f.InitializeWithBorrower(copy);
                if (f.ShowDialog(this) == DialogResult.OK && f.Borrower != null)
                {
                    var orig = repo.Borrowers.FirstOrDefault(b => b.BorrowerId == f.Borrower.BorrowerId);
                    if (orig != null)
                    {
                        orig.Name = f.Borrower.Name;
                        orig.Email = f.Borrower.Email;
                        orig.Phone = f.Borrower.Phone;
                        orig.MembershipDate = f.Borrower.MembershipDate;
                    }

                    Data.DataStore.SaveBorrowers(repo.Borrowers);
                    RefreshGrid();
                }
            }
        }

        // Tagalog: Tanggalin ang napiling borrower pagkatapos ng double confirmation,
        // pagkatapos i-reindex ang mga IDs at i-update ang loans.
        private void Button4_Click(object sender, EventArgs e)
        {
            var repo = Data.LibraryRepository.Instance;
            var selected = dgvBorrowers.CurrentRow?.DataBoundItem as Integrated_Library_System.Models.Borrower;
            if (selected == null)
            {
                MessageBox.Show("Please select a borrower to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete '{selected.Name}'?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;
            var final = MessageBox.Show("Are you sure SURE?", "Confirm delete (final)", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (final != DialogResult.Yes) return;

            repo.Borrowers.RemoveAll(b => b.BorrowerId == selected.BorrowerId);
            // resequence borrower IDs and update loans to keep associations
            repo.ReindexBorrowers();
            RefreshGrid();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvBorrowers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
