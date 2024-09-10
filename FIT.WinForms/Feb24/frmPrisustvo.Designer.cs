namespace FIT.WinForms.Feb24
{
    partial class frmPrisustvo
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
            lblProstorija = new Label();
            lblKapacitet = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbNastava = new ComboBox();
            cmbStudent = new ComboBox();
            btnDodaj = new Button();
            dgvPrisustvo = new DataGridView();
            Oznaka = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            gbPrisustvo = new GroupBox();
            txtInfo = new TextBox();
            txtBrojZapisa = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnGenerisi = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPrisustvo).BeginInit();
            gbPrisustvo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // lblProstorija
            // 
            lblProstorija.AutoSize = true;
            lblProstorija.Location = new Point(12, 9);
            lblProstorija.Name = "lblProstorija";
            lblProstorija.Size = new Size(50, 20);
            lblProstorija.TabIndex = 0;
            lblProstorija.Text = "label1";
            // 
            // lblKapacitet
            // 
            lblKapacitet.AutoSize = true;
            lblKapacitet.Location = new Point(678, 9);
            lblKapacitet.Name = "lblKapacitet";
            lblKapacitet.Size = new Size(50, 20);
            lblKapacitet.TabIndex = 0;
            lblKapacitet.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 0;
            label3.Text = "Nastava:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 55);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 0;
            label4.Text = "Student:";
            // 
            // cmbNastava
            // 
            cmbNastava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNastava.FormattingEnabled = true;
            cmbNastava.Location = new Point(12, 78);
            cmbNastava.Name = "cmbNastava";
            cmbNastava.Size = new Size(305, 28);
            cmbNastava.TabIndex = 1;
            cmbNastava.SelectedIndexChanged += cmbNastava_SelectedIndexChanged;
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(323, 78);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(305, 28);
            cmbStudent.TabIndex = 1;
            cmbStudent.SelectedIndexChanged += cmbStudent_SelectedIndexChanged;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(634, 78);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPrisustvo
            // 
            dgvPrisustvo.AllowUserToAddRows = false;
            dgvPrisustvo.AllowUserToDeleteRows = false;
            dgvPrisustvo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrisustvo.Columns.AddRange(new DataGridViewColumn[] { Oznaka, Student });
            dgvPrisustvo.Location = new Point(12, 112);
            dgvPrisustvo.Name = "dgvPrisustvo";
            dgvPrisustvo.ReadOnly = true;
            dgvPrisustvo.RowHeadersWidth = 51;
            dgvPrisustvo.RowTemplate.Height = 29;
            dgvPrisustvo.Size = new Size(716, 181);
            dgvPrisustvo.TabIndex = 3;
            // 
            // Oznaka
            // 
            Oznaka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Oznaka.DataPropertyName = "Oznaka";
            Oznaka.HeaderText = "Oznaka";
            Oznaka.MinimumWidth = 6;
            Oznaka.Name = "Oznaka";
            Oznaka.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // gbPrisustvo
            // 
            gbPrisustvo.Controls.Add(txtInfo);
            gbPrisustvo.Controls.Add(txtBrojZapisa);
            gbPrisustvo.Controls.Add(label6);
            gbPrisustvo.Controls.Add(label5);
            gbPrisustvo.Controls.Add(btnGenerisi);
            gbPrisustvo.Location = new Point(12, 299);
            gbPrisustvo.Name = "gbPrisustvo";
            gbPrisustvo.Size = new Size(716, 198);
            gbPrisustvo.TabIndex = 4;
            gbPrisustvo.TabStop = false;
            gbPrisustvo.Text = "Generator";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(6, 79);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(704, 113);
            txtInfo.TabIndex = 1;
            // 
            // txtBrojZapisa
            // 
            txtBrojZapisa.Location = new Point(82, 20);
            txtBrojZapisa.Name = "txtBrojZapisa";
            txtBrojZapisa.Size = new Size(80, 27);
            txtBrojZapisa.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 56);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 0;
            label6.Text = "Info:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 23);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 0;
            label5.Text = "BrZapisa:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(168, 19);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 2;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPrisustvo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 509);
            Controls.Add(gbPrisustvo);
            Controls.Add(dgvPrisustvo);
            Controls.Add(btnDodaj);
            Controls.Add(cmbStudent);
            Controls.Add(cmbNastava);
            Controls.Add(lblKapacitet);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblProstorija);
            Name = "frmPrisustvo";
            Text = "frmPrisustvo";
            ((System.ComponentModel.ISupportInitialize)dgvPrisustvo).EndInit();
            gbPrisustvo.ResumeLayout(false);
            gbPrisustvo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProstorija;
        private Label lblKapacitet;
        private Label label3;
        private Label label4;
        private ComboBox cmbNastava;
        private ComboBox cmbStudent;
        private Button btnDodaj;
        private DataGridView dgvPrisustvo;
        private GroupBox gbPrisustvo;
        private TextBox txtInfo;
        private TextBox txtBrojZapisa;
        private Label label6;
        private Label label5;
        private Button btnGenerisi;
        private DataGridViewTextBoxColumn Oznaka;
        private DataGridViewTextBoxColumn Student;
        private ErrorProvider err;
    }
}