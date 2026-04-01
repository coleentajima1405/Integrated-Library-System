namespace Integrated_Library_System.Forms
{
    partial class LoansForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoansForm));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(26, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "📖   Borrow Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "✔  Return Book";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.Font = new System.Drawing.Font("Poppins Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(14, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 82);
            this.button4.TabIndex = 34;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Poppins Medium", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(14, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 82);
            this.button3.TabIndex = 33;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 7.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 408);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(739, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 21);
            this.button1.TabIndex = 30;
            this.button1.Text = " ⌕   Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(161, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(572, 21);
            this.textBox1.TabIndex = 29;
            // 
            // dgvLoans
            // 
            this.dgvLoans.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.GridColor = System.Drawing.Color.Maroon;
            this.dgvLoans.Location = new System.Drawing.Point(151, 49);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.Size = new System.Drawing.Size(771, 408);
            this.dgvLoans.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(891, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Gegola DEMO", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 54);
            this.label2.TabIndex = 39;
            this.label2.Text = "I.L.S";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(28, 342);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 96);
            this.pictureBox6.TabIndex = 40;
            this.pictureBox6.TabStop = false;
            // 
            // LoansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvLoans);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoansForm";
            this.Text = "LoansForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}