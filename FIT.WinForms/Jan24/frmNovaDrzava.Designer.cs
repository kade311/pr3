namespace FIT.WinForms.Jan24
{
    partial class frmNovaDrzava
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
            pbSlika = new PictureBox();
            err = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            tbNaziv = new TextBox();
            cbStatus = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            btnSacuvaj = new Button();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 35);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(392, 196);
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            pbSlika.DoubleClick += pbSlika_DoubleClick;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbNaziv
            // 
            tbNaziv.Location = new Point(410, 35);
            tbNaziv.Name = "tbNaziv";
            tbNaziv.Size = new Size(236, 27);
            tbNaziv.TabIndex = 1;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(410, 68);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(80, 24);
            cbStatus.TabIndex = 2;
            cbStatus.Text = "Aktivna";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 3;
            label1.Text = "Slika drzave";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 9);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 3;
            label2.Text = "Naziv drzave";
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(552, 202);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 4;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // frmNovaDrzava
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 256);
            Controls.Add(btnSacuvaj);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbStatus);
            Controls.Add(tbNaziv);
            Controls.Add(pbSlika);
            Name = "frmNovaDrzava";
            Text = "frmNovaDrzava";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private ErrorProvider err;
        private Label label2;
        private Label label1;
        private CheckBox cbStatus;
        private TextBox tbNaziv;
        private OpenFileDialog openFileDialog1;
        private Button btnSacuvaj;
    }
}