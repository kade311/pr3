namespace FIT.WinForms
{
    partial class frmPocetna
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
            lblKonekcijaInfo = new Label();
            btnIzvjestaj = new Button();
            btnDrzave = new Button();
            btnPretraga = new Button();
            btnIspit = new Button();
            btnDule = new Button();
            SuspendLayout();
            // 
            // lblKonekcijaInfo
            // 
            lblKonekcijaInfo.AutoSize = true;
            lblKonekcijaInfo.Font = new Font("Segoe UI", 15F);
            lblKonekcijaInfo.Location = new Point(114, 96);
            lblKonekcijaInfo.Name = "lblKonekcijaInfo";
            lblKonekcijaInfo.Size = new Size(0, 35);
            lblKonekcijaInfo.TabIndex = 0;
            // 
            // btnIzvjestaj
            // 
            btnIzvjestaj.Location = new Point(158, 153);
            btnIzvjestaj.Margin = new Padding(3, 4, 3, 4);
            btnIzvjestaj.Name = "btnIzvjestaj";
            btnIzvjestaj.Size = new Size(207, 31);
            btnIzvjestaj.TabIndex = 1;
            btnIzvjestaj.Text = "Izvještaj";
            btnIzvjestaj.UseVisualStyleBackColor = true;
            btnIzvjestaj.Click += btnIzvjestaj_Click;
            // 
            // btnDrzave
            // 
            btnDrzave.Location = new Point(158, 201);
            btnDrzave.Margin = new Padding(3, 4, 3, 4);
            btnDrzave.Name = "btnDrzave";
            btnDrzave.Size = new Size(207, 31);
            btnDrzave.TabIndex = 1;
            btnDrzave.Text = "Drzave";
            btnDrzave.UseVisualStyleBackColor = true;
            btnDrzave.Click += btnDrzave_Click;
            // 
            // btnPretraga
            // 
            btnPretraga.Location = new Point(20, 177);
            btnPretraga.Name = "btnPretraga";
            btnPretraga.Size = new Size(94, 29);
            btnPretraga.TabIndex = 2;
            btnPretraga.Text = "Pretraga";
            btnPretraga.UseVisualStyleBackColor = true;
            btnPretraga.Click += btnPretraga_Click;
            // 
            // btnIspit
            // 
            btnIspit.Location = new Point(408, 177);
            btnIspit.Name = "btnIspit";
            btnIspit.Size = new Size(94, 29);
            btnIspit.TabIndex = 3;
            btnIspit.Text = "Ispit(feb24)";
            btnIspit.UseVisualStyleBackColor = true;
            btnIspit.Click += btnIspit_Click;
            // 
            // btnDule
            // 
            btnDule.Location = new Point(408, 142);
            btnDule.Name = "btnDule";
            btnDule.Size = new Size(94, 29);
            btnDule.TabIndex = 4;
            btnDule.Text = "Dule(jul24)";
            btnDule.UseVisualStyleBackColor = true;
            btnDule.Click += btnDule_Click;
            // 
            // frmPocetna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 245);
            Controls.Add(btnDule);
            Controls.Add(btnIspit);
            Controls.Add(btnPretraga);
            Controls.Add(btnDrzave);
            Controls.Add(btnIzvjestaj);
            Controls.Add(lblKonekcijaInfo);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPocetna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Template 2023/24";
            Load += frmPocetna_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKonekcijaInfo;
        private Button btnIzvjestaj;
        private Button btnDrzave;
        private Button btnPretraga;
        private Button btnIspit;
        private Button btnDule;
    }
}