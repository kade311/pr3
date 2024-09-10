using FIT.Data;
using FIT.Data.Jan24;
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

namespace FIT.WinForms.Jan24
{
    public partial class frmNovaDrzava : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovaDrzava()
        {
            InitializeComponent();
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (jeValidno())
            {
                var NovaDrzava = new Drzave()
                {
                    Naziv = tbNaziv.Text,
                    Zastava = Helpers.Ekstenzije.ToByteArray(pbSlika.Image),
                    Status = cbStatus.Checked ? 1 : 0
                };
                db.Drzave.Add(NovaDrzava);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private bool jeValidno()
        {
            return Helpers.Validator.ProvjeriUnos(pbSlika, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(tbNaziv, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(cbStatus, err, Kljucevi.ReqiredValue);
        }
    }
}
