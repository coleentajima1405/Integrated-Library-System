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
    public partial class AddEditBorrowerForm : Form
    {
        // Form na ginagamit para mag-add o mag-edit ng Borrower.
        // Nag-validate ng basic fields at ibinabalik ang Borrower object sa caller.
        public Integrated_Library_System.Models.Borrower Borrower { get; private set; }

        private bool _isEdit = false;
        public AddEditBorrowerForm()
        {
            InitializeComponent();
            InitializeForm(null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        internal void InitializeWithBorrower(Integrated_Library_System.Models.Borrower borrower)
        {
            InitializeForm(borrower);
        }

        private void InitializeForm(Integrated_Library_System.Models.Borrower borrower)
        {
            // Tagalog: I-set up ang form fields kapag nag-e-edit o nag-a-add.
            // Kung may borrower object, ilalagay ang values sa mga textbox.
            this.StartPosition = FormStartPosition.CenterParent;
            if (borrower != null)
            {
                _isEdit = true;
                Borrower = borrower;
                textBox1.Text = Borrower.Name;
                textBox2.Text = Borrower.Email;
                textBox3.Text = Borrower.Phone;
                this.Text = "Edit Borrower";
            }
            else
            {
                _isEdit = false;
                this.Text = "Add Borrower";
            }

            // wire buttons
            button1.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Tagalog: Save handler. Nagva-validate muna ng Name at saka binabalik ang
            // Borrower object sa caller sa pamamagitan ng DialogResult = OK.
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Borrower == null) Borrower = new Integrated_Library_System.Models.Borrower();
            Borrower.Name = textBox1.Text.Trim();
            Borrower.Email = textBox2.Text.Trim();
            Borrower.Phone = textBox3.Text.Trim();
            if (!_isEdit)
                Borrower.MembershipDate = DateTime.Now;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
