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
    public partial class frmPretraga : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> podaciStudent = new List<Student>();
        public frmPretraga()
        {
            InitializeComponent();
            UcitajDrzaveCmb();
            UcitajStudente();
        }

        public void UcitajGradoveCmb(Drzave drzava)
        {
            
            var grad = db.Gradovi.ToList();
            cmbGrad.DataSource = grad.Where(x => x.DrzavaId == drzava.Id).ToList();
            cmbGrad.DisplayMember = "Naziv";
        }

        public void UcitajDrzaveCmb()
        {
            cmbDrzava.DataSource = db.Drzave.ToList();
            cmbDrzava.DisplayMember = "Naziv";
            var drzava = cmbDrzava.SelectedItem as Drzave;
            UcitajGradoveCmb(drzava);
        }

        private void UcitajStudente()
        {
            
            podaciStudent = db.Studenti.ToList();
            UcitajPodatke(podaciStudent);
        }

        private void cmbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drzava = cmbDrzava.SelectedItem as Drzave;

            UcitajGradoveCmb(drzava);

            UcitajFiltraciju();
        }

        private void cmbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajFiltraciju();
        }

        private void UcitajFiltraciju()
        {
            var filterGrad = cmbGrad.SelectedItem as Gradovi;

            if (filterGrad != null)
            {
                podaciStudent = db.Studenti.Where(x => x.GradId == filterGrad.Id).ToList();

                if (podaciStudent.Count == 0)
                {
                    MessageBox.Show("Nema nista za prikazat");
                }
                UcitajPodatke(podaciStudent);
            }
        }

        private void UcitajPodatke(List<Student> podaciStudent)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ime");
            dt.Columns.Add("Prezime");
            dt.Columns.Add("Grad");
            dt.Columns.Add("Drzava");
            dt.Columns.Add("Prosjek");
            for (int i = 0; i < podaciStudent.Count; i++)
            {
                DataRow dr = dt.NewRow();
                var podatakStudent = podaciStudent[i];

                List<Drzave> podaciDrzave = db.Drzave.ToList();
                List<Gradovi> podaciGradovi = db.Gradovi.ToList();
                List<PolozeniPredmeti> ocjene = db.PolozeniPredmeti.Where(x => x.StudentId == podatakStudent.Id).ToList();
                var grad = db.Gradovi.FirstOrDefault(x => x.Id == podatakStudent.GradId);
                var drzava = db.Drzave.FirstOrDefault(x => x.Id == grad.DrzavaId);

                dr["Ime"] = podatakStudent.Ime;
                dr["Prezime"] = podatakStudent.Prezime;
                dr["Grad"] = grad.Naziv;
                dr["Drzava"] = drzava.Naziv;
                dr["Prosjek"] = ocjene.Count() == 0 ? 5 : ocjene.Average(x => x.Ocjena);
                dt.Rows.Add(dr);
            }
            dgvPretraga.DataSource = null;
            dgvPretraga.DataSource = dt;
        }
    }
}
