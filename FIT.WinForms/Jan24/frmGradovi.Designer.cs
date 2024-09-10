namespace FIT.WinForms.Jan24
{
    partial class frmGradovi
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
            lblDrzava = new Label();
            txtBrojGradova = new TextBox();
            label2 = new Label();
            btnDodaj = new Button();
            dgvGradovi = new DataGridView();
            Grad = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            PromjeniStatus = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            btnGenerisi = new Button();
            cbStatus = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            txtInfo = new TextBox();
            txtNoviGrad = new TextBox();
            err = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(125, 62);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            // 
            // lblDrzava
            // 
            lblDrzava.AutoSize = true;
            lblDrzava.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblDrzava.Location = new Point(143, 29);
            lblDrzava.Name = "lblDrzava";
            lblDrzava.Size = new Size(76, 31);
            lblDrzava.TabIndex = 1;
            lblDrzava.Text = "label1";
            // 
            // txtBrojGradova
            // 
            txtBrojGradova.Location = new Point(110, 20);
            txtBrojGradova.Name = "txtBrojGradova";
            txtBrojGradova.Size = new Size(82, 27);
            txtBrojGradova.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(192, 20);
            label2.TabIndex = 1;
            label2.Text = "Unesite naziv novog grada: ";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(468, 84);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 3;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvGradovi
            // 
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { Grad, Aktivan, PromjeniStatus });
            dgvGradovi.Location = new Point(12, 118);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.RowHeadersWidth = 51;
            dgvGradovi.RowTemplate.Height = 29;
            dgvGradovi.Size = new Size(550, 188);
            dgvGradovi.TabIndex = 4;
            dgvGradovi.CellContentClick += dgvGradovi_CellContentClick;
            // 
            // Grad
            // 
            Grad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Grad.DataPropertyName = "Grad";
            Grad.HeaderText = "Grad";
            Grad.MinimumWidth = 6;
            Grad.Name = "Grad";
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Aktivan";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            // 
            // PromjeniStatus
            // 
            PromjeniStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PromjeniStatus.HeaderText = "";
            PromjeniStatus.MinimumWidth = 6;
            PromjeniStatus.Name = "PromjeniStatus";
            PromjeniStatus.Text = "PromjeniStatus";
            PromjeniStatus.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(cbStatus);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(txtBrojGradova);
            groupBox1.Location = new Point(12, 312);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(550, 222);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(280, 19);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 4;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(198, 22);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(76, 24);
            cbStatus.TabIndex = 3;
            cbStatus.Text = "Aktivni";
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 69);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 1;
            label4.Text = "Info:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 1;
            label3.Text = "Broj gradova:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 92);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(538, 124);
            txtInfo.TabIndex = 2;
            // 
            // txtNoviGrad
            // 
            txtNoviGrad.Location = new Point(204, 84);
            txtNoviGrad.Name = "txtNoviGrad";
            txtNoviGrad.Size = new Size(258, 27);
            txtNoviGrad.TabIndex = 2;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmGradovi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 546);
            Controls.Add(groupBox1);
            Controls.Add(dgvGradovi);
            Controls.Add(btnDodaj);
            Controls.Add(label2);
            Controls.Add(lblDrzava);
            Controls.Add(txtNoviGrad);
            Controls.Add(pbSlika);
            Name = "frmGradovi";
            Text = "frmGradovi";
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Label lblDrzava;
        private TextBox txtBrojGradova;
        private Label label2;
        private Button btnDodaj;
        private DataGridView dgvGradovi;
        private GroupBox groupBox1;
        private Button btnGenerisi;
        private CheckBox cbStatus;
        private Label label4;
        private Label label3;
        private TextBox txtInfo;
        private TextBox txtNoviGrad;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn PromjeniStatus;
        private ErrorProvider err;
        private OpenFileDialog openFileDialog1;
    }
}