﻿namespace FIT.WinForms.Jul24
{
    partial class frmStudentInfo
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
            pbSlika = new PictureBox();
            lblIme = new Label();
            lblProsjek = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(302, 275);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lblIme
            // 
            lblIme.AutoSize = true;
            lblIme.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblIme.Location = new Point(52, 331);
            lblIme.Name = "lblIme";
            lblIme.Size = new Size(91, 38);
            lblIme.TabIndex = 1;
            lblIme.Text = "label1";
            // 
            // lblProsjek
            // 
            lblProsjek.AutoSize = true;
            lblProsjek.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblProsjek.Location = new Point(109, 394);
            lblProsjek.Name = "lblProsjek";
            lblProsjek.Size = new Size(65, 28);
            lblProsjek.TabIndex = 1;
            lblProsjek.Text = "label1";
            // 
            // frmStudentInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 450);
            Controls.Add(lblProsjek);
            Controls.Add(lblIme);
            Controls.Add(pbSlika);
            Name = "frmStudentInfo";
            Text = "frmStudentInfo";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label lblIme;
        private Label lblProsjek;
    }
}