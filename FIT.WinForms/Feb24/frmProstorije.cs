using FIT.Data.Feb24;
using FIT.Infrastructure;
using FIT.WinForms.Izvjestaji;
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
    public partial class frmProstorije : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Prostorije> podaciProstorije = new List<Prostorije>();
        public frmProstorije()
        {
            InitializeComponent();
            UcitajProstorije();
            //dgvProstorije.AutoGenerateColumns = false;

        }

        private void UcitajProstorije()
        {
            podaciProstorije = db.Prostorije.ToList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Logo", typeof(Image));
            dt.Columns.Add("Naziv");
            dt.Columns.Add("Oznaka");
            dt.Columns.Add("Kapacitet");
            dt.Columns.Add("BrPredmeta");

            for (int i = 0; i < podaciProstorije.Count; i++)
            {
                var red = dt.NewRow();
                var podatakProstorija = podaciProstorije[i];

                red["Logo"] = Helpers.Ekstenzije.ToImage(podatakProstorija.Logo);
                red["Naziv"] = podatakProstorija.Naziv;
                red["Oznaka"] = podatakProstorija.Oznaka;
                red["Kapacitet"] = podatakProstorija.Kapacitet;
                red["BrPredmeta"] = db.Nastava.Count(x => x.ProstorijaId == podatakProstorija.Id);

                dt.Rows.Add(red);
            }
            dgvProstorije.DataSource = dt;
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            var NovaForma = new frmNovaProstorija();
            if (NovaForma.ShowDialog() == DialogResult.OK)
            {
                UcitajProstorije();
            }
        }

        private void dgvProstorije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvProstorije.Columns[e.ColumnIndex].Name == "Nastava")
            {
                Prostorije kliknutaProstorija = podaciProstorije[e.RowIndex];
                var NovaForma = new frmNastava(kliknutaProstorija);
                if (NovaForma.ShowDialog() == DialogResult.OK)
                {
                    UcitajProstorije();
                }

            }
            else if (dgvProstorije.Columns[e.ColumnIndex].Name == "Prisustvo")
            {
                Prostorije kliknutaProstorija = podaciProstorije[e.RowIndex];
                var NovaForma = new frmPrisustvo(kliknutaProstorija);
                if (NovaForma.ShowDialog() == DialogResult.OK)
                {
                    UcitajProstorije();
                }
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvProstorije.SelectedRows.Count > 0)
            {
                var red = dgvProstorije.SelectedRows[0];
                var prostorija = red.Cells["Naziv"].Value.ToString();
                var kliknutaProstorija = podaciProstorije.FirstOrDefault(x=>x.Naziv==prostorija);

                if(kliknutaProstorija != null)
                {
                    var report = new frmIzvjestajFeb24(kliknutaProstorija);
                    report.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nevalidan odabir prostorije");
                }
            }
            else
            {
                MessageBox.Show("Nevalidan odabir prostorije");
            }
        }
    }
}
