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
using FIT.Data.Jan24;
using FIT.Data;

namespace FIT.WinForms.Jan24
{
    public partial class frmGradovi : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<Gradovi> podaciGradovi = new List<Gradovi>();
        List<Drzave> podaciDrzave = new List<Drzave>();
        private Drzave kliknutaDrzava;

        public frmGradovi()
        {
            InitializeComponent();

        }

        public frmGradovi(Drzave kliknutaDrzava)
        {
            this.kliknutaDrzava = kliknutaDrzava;
            InitializeComponent();
            UcitajGradove();
            pbSlika.Image = Helpers.Ekstenzije.ToImage(kliknutaDrzava.Zastava);
            lblDrzava.Text = kliknutaDrzava.Naziv;
        }

        private void UcitajGradove()
        {
            podaciGradovi = db.Gradovi.Where(x => x.DrzavaId == kliknutaDrzava.Id).ToList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Grad");
            dt.Columns.Add("Aktivan", typeof(bool));
            for (int i = 0; i < podaciGradovi.Count; i++)
            {
                var red = dt.NewRow();
                var podatakGrad = podaciGradovi[i];

                red["Grad"] = podatakGrad.Naziv;
                red["Aktivan"] = podatakGrad.Status;
                dt.Rows.Add(red);
            }
            dgvGradovi.DataSource = dt;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            if (jeValidno())
            {
                bool dupliGrad = podaciGradovi.Any(x => x.Naziv == txtNoviGrad.Text);
                if (dupliGrad)
                {
                    MessageBox.Show("Grad vec postoji lol", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                var NoviGrad = new Gradovi()
                {
                    Naziv = txtNoviGrad.Text,
                    Status = 1,
                    DrzavaId = kliknutaDrzava.Id
                };
                db.Gradovi.Add(NoviGrad);
                db.SaveChanges();
                UcitajGradove();
            }
        }

        private bool jeValidno()
        {
            return Helpers.Validator.ProvjeriUnos(txtNoviGrad, err, Kljucevi.ReqiredValue);
        }

        private void dgvGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGradovi.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var grad = podaciGradovi[e.RowIndex];
                grad.Status = grad.Status == 1 ? 0 : 1;
                db.Gradovi.Update(podaciGradovi[e.RowIndex]);
                db.SaveChanges();
                UcitajGradove();
            }

        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            var aktivan = cbStatus.Checked;
            var BrojZahtjeva = txtBrojGradova.Text == "" ? 0 : int.Parse(txtBrojGradova.Text);
            //MessageBox.Show(BrojZahtjeva.ToString());
            //MessageBox.Show(aktivan.ToString());
            Thread t = new Thread(() => GenerisiGradove(aktivan,BrojZahtjeva));
            t.Start();
            UcitajGradove();
        }

        private void GenerisiGradove(bool aktivan, int BrojZahtjeva)
        {
            string Tekst = "";
            if (BrojZahtjeva != 0)
            {
                for (int i = 1; i <= BrojZahtjeva; i++)
                {
                    var NoviGrad = new Gradovi()
                    {
                        Naziv = "Grad " + i,
                        Status = aktivan ? 1 : 0,
                        DrzavaId = kliknutaDrzava.Id
                    };
                    db.Gradovi.Add(NoviGrad);
                    db.SaveChanges();
                    Tekst += $"{DateTime.Now} -> dodat grad Grad {i} za drzavu {kliknutaDrzava.Naziv} {Environment.NewLine}";
                }
                Action action = () =>
                {
                    txtInfo.Text = Tekst;
                    UcitajGradove();
                };
                BeginInvoke(action);
            }
            else
            {
                MessageBox.Show("Molimo unesite validan broj gradova");
            }
        }
    }
}
