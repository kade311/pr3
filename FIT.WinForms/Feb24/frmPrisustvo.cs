using FIT.Data;
using FIT.Data.Feb24;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.Feb24
{
    public partial class frmPrisustvo : Form
    {
        private Prostorije kliknutaProstorija;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmPrisustvo()
        {
            InitializeComponent();
        }

        public frmPrisustvo(Prostorije kliknutaProstorija)
        {
            InitializeComponent();
            this.kliknutaProstorija = kliknutaProstorija;
            UcitajCmb();
            UcitajPrisustva();
            lblProstorija.Text = kliknutaProstorija.Naziv + " - " + kliknutaProstorija.Oznaka;
        }

        private void UcitajCmb()
        {
            cmbNastava.DataSource = db.Nastava.Where(x => x.ProstorijaId == kliknutaProstorija.Id).ToList();
            cmbNastava.DisplayMember = "Oznaka";
            cmbNastava.ValueMember = "Id";

            cmbStudent.DataSource = db.Studenti.ToList();
            cmbStudent.DisplayMember = "IndeksImePrezime";
            cmbStudent.ValueMember = "Id";

        }

        private void UcitajPrisustva()
        {
            //var podaciPrisustvo = db.Prisustvo.Where(x => x.NastavaId == db.Nastava.FirstOrDefault(n => n.ProstorijaId == kliknutaProstorija.Id).Id).ToList();

            var nastavaFilter = cmbNastava.SelectedValue is int ? (int)cmbNastava.SelectedValue : -1;
            var studentFilter = cmbStudent.SelectedValue is int ? (int)cmbStudent.SelectedValue : -1;

            var podaciPrisustvo = db.Prisustvo.Where(x => x.NastavaId == nastavaFilter && x.StudentId == studentFilter).ToList();

            lblKapacitet.Text = podaciPrisustvo.Count.ToString() + "/" + kliknutaProstorija.Kapacitet;


            DataTable dt = new DataTable();

            dt.Columns.Add("Oznaka");
            dt.Columns.Add("Student");

            for (int i = 0; i < podaciPrisustvo.Count; i++)
            {
                var podatakPrisustvo = podaciPrisustvo[i];
                var red = dt.NewRow();

                red["Oznaka"] = db.Nastava.FirstOrDefault(x => x.Id == podatakPrisustvo.NastavaId).Oznaka;
                red["Student"] = db.Studenti.FirstOrDefault(x => x.Id == podaciPrisustvo[i].StudentId);

                dt.Rows.Add(red);
            }
            dgvPrisustvo.DataSource = dt;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (jeValidno())
            {
                var NovoPrisustvo = new Prisustvo()
                {
                    NastavaId = (int)cmbNastava.SelectedValue,
                    StudentId = (int)cmbStudent.SelectedValue
                };
                db.Prisustvo.Add(NovoPrisustvo);
                db.SaveChanges();
                DialogResult = DialogResult.OK;
                UcitajPrisustva();
                //MessageBox.Show($"{cmbNastava.SelectedValue} - {cmbStudent.SelectedIndex} eloel");
            }
        }

        private bool jeValidno()
        {
            return Helpers.Validator.ProvjeriUnos(cmbNastava, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(cmbStudent, err, Kljucevi.ReqiredValue);
        }

        private void cmbNastava_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPrisustva();
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPrisustva();

        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            var oznaka = cmbNastava.SelectedItem;
            var student = cmbStudent.SelectedItem;
            var brojZahtjeva = txtBrojZapisa.Text == "" ? 0 : int.Parse(txtBrojZapisa.Text);
            Thread t = new Thread(() => GenerisiPrisustva(oznaka,student,brojZahtjeva));
            t.Start();
            UcitajPrisustva();
        }

        private void GenerisiPrisustva(object oznaka, object student, int brojZahtjeva)
        {
            string Tekst = "";
            if (jeValidno())
            {
                if (brojZahtjeva > 0)
                {
                    for (int i = 0; i < brojZahtjeva; i++)
                    {
                        var NovoPrisustvo = new Prisustvo()
                        {
                            NastavaId = (int)cmbNastava.SelectedValue,
                            StudentId = (int)cmbStudent.SelectedValue
                        };
                        db.Prisustvo.Add(NovoPrisustvo);
                        db.SaveChanges();
                        Tekst += $"{DateTime.Now} -> {student} za {oznaka}";
                    }
                    Action action = () =>
                    {
                        txtInfo.Text = Tekst;
                        UcitajPrisustva();
                    };
                    BeginInvoke(action);
                }
                else
                {
                    MessageBox.Show("Molimo unesite validan broj zahtjeva");
                }
            }
            
        }
    }
}
