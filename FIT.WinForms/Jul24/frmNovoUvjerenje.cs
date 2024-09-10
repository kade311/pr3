using FIT.Data;
using FIT.Data.Jul24;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.Jul24
{
    public partial class frmNovoUvjerenje : Form
    {
        private Student kliknutiStudent;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovoUvjerenje()
        {
            InitializeComponent();
        }

        public frmNovoUvjerenje(Student kliknutiStudent)
        {
            this.kliknutiStudent = kliknutiStudent;
            InitializeComponent();
            cmbVrsta.SelectedIndex = 0;
        }

        private void pbUplatnica_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbUplatnica.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (jeValidno())
            {
                var uvjerenje = new StudentiUvjerenja()
                {
                    StudentId = kliknutiStudent.Id,
                    Vrijeme = DateTime.Now,
                    Vrsta = cmbVrsta.SelectedItem.ToString(),
                    Svrha = txtSvrha.Text == "" ? "Svrha nije unesena" : txtSvrha.Text,
                    Uplatnica = Helpers.Ekstenzije.ToByteArray(pbUplatnica.Image),
                    Printano = 0
                };
                db.StudentiUvjerenja.Add(uvjerenje);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool jeValidno()
        {
            return Helpers.Validator.ProvjeriUnos(pbUplatnica, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtSvrha, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(cmbVrsta, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}
