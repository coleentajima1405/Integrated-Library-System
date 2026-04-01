namespace Integrated_Library_System.Forms
{
    partial class BorrowBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBookForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.MistyRose;
            this.comboBox1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Brown;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Book";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.MistyRose;
            this.comboBox2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 95);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(309, 23);
            this.comboBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Borrower";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.MistyRose;
            this.comboBox3.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 158);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(309, 23);
            this.comboBox3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Brown;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Genre";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(172, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "Confirm Borrow";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BorrowBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(338, 242);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Name = "BorrowBookForm";
            this.Text = "BorrowBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}