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
    public partial class frmNastava : Form
    {
        private Prostorije kliknutaProstorija;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNastava()
        {
            InitializeComponent();
            
            

        }

        public frmNastava(Prostorije kliknutaProstorija)
        {
            this.kliknutaProstorija = kliknutaProstorija;
            InitializeComponent();
        }

        private void frmNastava_Load(object sender, EventArgs e)
        {
            UcitajNastavu();
            UcitajPredmete();
            cmbDan.SelectedIndex = 0;
            cmbVrijeme.SelectedIndex = 0;
            lblProstorija.Text = kliknutaProstorija.Naziv + " - " + kliknutaProstorija.Oznaka;
        }

        private void UcitajPredmete()
        {
            cmbPredmet.DataSource = db.Predmeti.ToList();
            cmbPredmet.DisplayMember = "Naziv";
            cmbPredmet.ValueMember = "Id";
        }

        private void UcitajNastavu()
        {
            var podaciNastava = db.Nastava.Where(x => x.ProstorijaId == kliknutaProstorija.Id).ToList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Predmet");
            dt.Columns.Add("Dan");
            dt.Columns.Add("Vrijeme");

            for (int i = 0; i < podaciNastava.Count; i++)
            {
                var red = dt.NewRow();
                var singularNastava = podaciNastava[i];
                var podaciPredmet = db.Predmeti.FirstOrDefault(x => x.Id == singularNastava.PredmetId);

                red["Predmet"] = podaciPredmet.Naziv;
                red["Dan"] = singularNastava.Dan;
                red["Vrijeme"] = singularNastava.Vrijeme;

                dt.Rows.Add(red);
            }
            dgvNastava.DataSource = dt;

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (jeValidno())
            {
                var predmet = db.Predmeti.Where(x => x.Id == (int)cmbPredmet.SelectedValue).Select(p => p.Naziv).FirstOrDefault();
                var oznaka = $"{predmet} :: {cmbDan.SelectedItem.ToString()} :: {cmbVrijeme.SelectedItem.ToString()}";
                var NovaNastava = new Nastava()
                {
                    ProstorijaId = kliknutaProstorija.Id,
                    PredmetId = (int)cmbPredmet.SelectedValue,
                    Dan = cmbDan.SelectedItem.ToString(),
                    Vrijeme = cmbVrijeme.SelectedItem.ToString(),
                    Oznaka = oznaka
                };
                db.Nastava.Add(NovaNastava);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
                UcitajNastavu();
            }
        }

        private bool jeValidno()
        {
            return Helpers.Validator.ProvjeriUnos(cmbPredmet, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(cmbDan, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(cmbVrijeme, err, Kljucevi.ReqiredValue);
        }
    }
}
