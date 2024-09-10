using FIT.Data.Jan24;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using FIT.WinForms.Izvjestaji;
using FIT.WinForms.Jan24;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace FIT.WinForms.Dule_savic
{
    public partial class frmDrzave : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Drzave> podaciDrzave = new List<Drzave>();
        public frmDrzave()
        {
            InitializeComponent();

            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(Timer_Tick);
            t.Start();

            UcitajDrzave();
        }

        private void UcitajDrzave()
        {
            podaciDrzave = db.Drzave.ToList();
            DataTable dt = new DataTable();

            dt.Columns.Add("Zastava", typeof(Image));
            dt.Columns.Add("Drzava");
            dt.Columns.Add("BrojGradova");
            dt.Columns.Add("Aktivna", typeof(bool));

            for (int i = 0; i < podaciDrzave.Count; i++)
            {
                var red = dt.NewRow();
                var podatakDrzava = podaciDrzave[i];

                List<Gradovi> podaciGradovi = new List<Gradovi>();
                podaciGradovi = db.Gradovi.ToList();

                var brojGradova = podaciGradovi.Count(x => x.DrzavaId == podatakDrzava.Id);
                var slika = Helpers.Ekstenzije.ToImage(podatakDrzava.Zastava);

                red["Zastava"] = slika;
                red["Drzava"] = podatakDrzava.Naziv;
                red["BrojGradova"] = brojGradova;
                red["Aktivna"] = podatakDrzava.Status;

                dt.Rows.Add(red);
            }
            dgvDrzave.DataSource = dt;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            lblVrijeme.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var Novaforma = new frmNovaDrzava();
            if (Novaforma.ShowDialog() == DialogResult.OK)
            {
                UcitajDrzave();
            }

        }

        private void dgvDrzave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn kolona = dgvDrzave.Columns[e.ColumnIndex];
            if (kolona is DataGridViewButtonColumn)
            {
                var kliknutaDrzava = podaciDrzave[e.RowIndex];
                var NovaForma = new frmGradovi(kliknutaDrzava);
                if (NovaForma.ShowDialog(this) == DialogResult.OK)
                {
                    UcitajDrzave();
                }
            }

        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {

            if (dgvDrzave.SelectedRows.Count > 0)
            {
                var red = dgvDrzave.SelectedRows[0];
                var drzava = red.Cells["Drzava"].Value.ToString();
                var kliknutaDrzava = podaciDrzave.FirstOrDefault(x=>x.Naziv==drzava);

                if (kliknutaDrzava != null)
                {
                    var podaciGradovi = db.Gradovi.Where(x => x.DrzavaId == kliknutaDrzava.Id).ToList();
                    var report = new frmIzvjestaji(kliknutaDrzava);
                    report.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selected country data is invalid.");
                }
            }
            else
            {
                MessageBox.Show("Please select a country.");
            }
        }
    }

}
