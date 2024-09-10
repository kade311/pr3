namespace FIT.WinForms.Feb24
{
    partial class frmNovaProstorija
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pbLogo = new PictureBox();
            txtNaziv = new TextBox();
            label2 = new Label();
            txtOznaka = new TextBox();
            btnDodaj = new Button();
            label3 = new Label();
            txtKapacitet = new TextBox();
            label4 = new Label();
            err = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Logo:";
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(12, 32);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(195, 194);
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            pbLogo.DoubleClick += pbLogo_DoubleClick;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(213, 55);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(287, 27);
            txtNaziv.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 32);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Naziv:";
            // 
            // txtOznaka
            // 
            txtOznaka.Location = new Point(213, 124);
            txtOznaka.Name = "txtOznaka";
            txtOznaka.Size = new Size(138, 27);
            txtOznaka.TabIndex = 2;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(406, 197);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 101);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 0;
            label3.Text = "Oznaka:";
            // 
            // txtKapacitet
            // 
            txtKapacitet.Location = new Point(362, 124);
            txtKapacitet.Name = "txtKapacitet";
            txtKapacitet.Size = new Size(138, 27);
            txtKapacitet.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 101);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 0;
            label4.Text = "Kapacitet";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmNovaProstorija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 237);
            Controls.Add(btnDodaj);
            Controls.Add(txtKapacitet);
            Controls.Add(txtOznaka);
            Controls.Add(txtNaziv);
            Controls.Add(pbLogo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNovaProstorija";
            Text = "frmNovaProstorija";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbLogo;
        private TextBox txtNaziv;
        private Label label2;
        private TextBox txtOznaka;
        private Button btnDodaj;
        private Label label3;
        private TextBox txtKapacitet;
        private Label label4;
        private ErrorProvider err;
        private OpenFileDialog openFileDialog1;
    }
}