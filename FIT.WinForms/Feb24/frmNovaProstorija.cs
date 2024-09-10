using FIT.Data;
using FIT.Data.Feb24;
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

namespace FIT.WinForms.Feb24
{
    public partial class frmNovaProstorija : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovaProstorija()
        {
            InitializeComponent();
        }

        private void pbLogo_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (jeValidno())
            {
                var NovaProstoija = new Prostorije()
                {
                    Logo = Helpers.Ekstenzije.ToByteArray(pbLogo.Image),
                    Naziv = txtNaziv.Text,
                    Oznaka = txtOznaka.Text,
                    Kapacitet = int.Parse(txtKapacitet.Text)
                };
                db.Prostorije.Add(NovaProstoija);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool jeValidno()
        {
            return Helpers.Validator.ProvjeriUnos(pbLogo, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtKapacitet, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtNaziv, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtOznaka, err, Kljucevi.ReqiredValue);
        }
    }
}
