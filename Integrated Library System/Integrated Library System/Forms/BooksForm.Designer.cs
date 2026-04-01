namespace Integrated_Library_System.Forms
{
    partial class BooksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(990, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cboGenre
            // 
            this.cboGenre.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.ItemHeight = 16;
            this.cboGenre.Items.AddRange(new object[] {
            "All Genres",
            "Fiction",
            "Non-Fiction",
            "Science",
            "History",
            "Technology",
            "Mathematics",
            "Literature",
            "Philosophy",
            "Biography",
            "Other"});
            this.cboGenre.Location = new System.Drawing.Point(171, 14);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(321, 24);
            this.cboGenre.TabIndex = 3;
            this.cboGenre.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(498, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 24);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(797, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 21);
            this.button1.TabIndex = 5;
            this.button1.Text = " ⌕   Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 399);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Font = new System.Drawing.Font("Poppins Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 82);
            this.button2.TabIndex = 7;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Brown;
            this.lblCount.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(16, 339);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(46, 19);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "count";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Poppins Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 82);
            this.button3.TabIndex = 11;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.Font = new System.Drawing.Font("Poppins Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 82);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Brown;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "✚ Add Book";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(37, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "✎ Edit Book";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(45, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "🗑 Delete";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.GridColor = System.Drawing.Color.DarkRed;
            this.dgvBooks.Location = new System.Drawing.Point(156, 51);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(832, 399);
            this.dgvBooks.TabIndex = 16;
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Gegola DEMO", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 51);
            this.label1.TabIndex = 17;
            this.label1.Text = "I.L.S";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(37, 361);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(92, 73);
            this.pictureBox6.TabIndex = 34;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 441);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BooksForm";
            this.Text = "BooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}