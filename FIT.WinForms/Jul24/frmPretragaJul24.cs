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

namespace FIT.WinForms.Jul24
{
    public partial class frmPretragaJul24 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Student> podaciStudent = new List<Student>();
        public frmPretragaJul24()
        {
            InitializeComponent();
            cmbSpol.SelectedIndex = 2;
            //UcitajStudente();
            podaciStudent = db.Studenti.ToList();
            UcitajSve(podaciStudent);
        }
        private void UcitajStudente()
        {
            //podaciStudent = db.Studenti.ToList();

            var spol = cmbSpol.SelectedItem.ToString();
            var datumOd = dtpOd.Value;
            var datumDo = dtpDo.Value;
            if (spol != "Svi")
            {
                podaciStudent = db.Studenti.Where(x => x.Spol == spol && x.DatumRodjenja >= datumOd && x.DatumRodjenja <= datumDo).ToList();

            }
            else
            {
                podaciStudent = db.Studenti.Where(x => x.DatumRodjenja >= datumOd && x.DatumRodjenja <= datumDo).ToList();
            }

            UcitajSve(podaciStudent);
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
        {
            UcitajStudente();
        }
        private void UcitajSve(List<Student> podaciStudent)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("BrojIndeksa");
            dt.Columns.Add("ImePrezime");
            dt.Columns.Add("Prosjek");
            dt.Columns.Add("DatumRodjenja");
            dt.Columns.Add("Aktivan");

            for (int i = 0; i < podaciStudent.Count; i++)
            {
                var red = dt.NewRow();

                List<PolozeniPredmeti> ocjene = db.PolozeniPredmeti.Where(x => x.StudentId == podaciStudent[i].Id).ToList();

                red["BrojIndeksa"] = podaciStudent[i].Indeks;
                red["ImePrezime"] = podaciStudent[i].Ime + podaciStudent[i].Prezime;
                red["Prosjek"] = ocjene.Count() == 0 ? "5" : ocjene.Average(x => x.Ocjena).ToString();
                red["DatumRodjenja"] = podaciStudent[i].DatumRodjenja;
                red["Aktivan"] = podaciStudent[i].Aktivan;

                dt.Rows.Add(red);
            }
            dgvPretraga.DataSource = dt;
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPretraga.Columns[e.ColumnIndex].Name == "Uvjerenja")
            {
                var kliknutiStudent = podaciStudent[e.RowIndex];
                var NovaForma = new frmUvjerenja(kliknutiStudent);
                
                NovaForma.Show();
            }
            else
            {
                var kliknutiStudent = podaciStudent[e.RowIndex];
                var NovaForma = new frmStudentInfo(kliknutiStudent);

                NovaForma.Show();
            }
        }
    }
}
