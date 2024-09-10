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
    public partial class frmUvjerenja : Form
    {
        private Student kliknutiStudent;
        DLWMSDbContext db = new DLWMSDbContext();
        List<StudentiUvjerenja> podaciUvjerenje = new List<StudentiUvjerenja>();
        public frmUvjerenja()
        {
            InitializeComponent();
        }

        public frmUvjerenja(Student kliknutiStudent)
        {
            InitializeComponent();
            this.kliknutiStudent = kliknutiStudent;
            UcitajUvjerenja();

        }

        private void UcitajUvjerenja()
        {
            dgvUvjerenja.AutoGenerateColumns = false;

            podaciUvjerenje = db.StudentiUvjerenja.Where(x => x.StudentId == kliknutiStudent.Id).ToList();
            dgvUvjerenja.DataSource = podaciUvjerenje;
            this.Text = "Broj uvjerenja za odabranog studenta: " + podaciUvjerenje.Count.ToString();
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            var forma = new frmNovoUvjerenje(kliknutiStudent);
            if (forma.ShowDialog() == DialogResult.OK)
            {
                UcitajUvjerenja();
            }
        }

        private void dgvUvjerenja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUvjerenja.Columns[e.ColumnIndex].Name == "Brisi")
            {
                DialogResult odabir = MessageBox.Show("Zelite li obrisati uvjerenje?", "Upo zorenje!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (odabir == DialogResult.Yes)
                {
                    var kliknutoUvjerenje = podaciUvjerenje[e.RowIndex];
                    db.StudentiUvjerenja.Remove(kliknutoUvjerenje);
                    db.SaveChanges();
                    UcitajUvjerenja();
                }
                else if (odabir == DialogResult.No)
                {
                    MessageBox.Show("Hehe mala posalica gej sam");
                }

            }
            else if (dgvUvjerenja.Columns[e.ColumnIndex].Name == "Printaj")
            {

            }
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            if (jeValidno())
            {
                var vrsta = cmbVrsta.Text;
                var svrha = txtSvrha.Text;
                var brojZahtjeva = int.Parse(txtBrojZahtjeva.Text);
                Thread thread = new Thread(() => GenerisiThread(vrsta, svrha, brojZahtjeva));
                thread.Start();
                UcitajUvjerenja() ;
            }
        }

        private void GenerisiThread(string vrsta, string svrha, int brojZahtjeva)
        {
            string Tekst = "";
            for (int i = 0;i<brojZahtjeva;i++)
            {
                var uvjerenje = new StudentiUvjerenja()
                {
                    StudentId = kliknutiStudent.Id,
                    Vrijeme = DateTime.Now,
                    Vrsta = cmbVrsta.SelectedItem.ToString(),
                    Svrha = txtSvrha.Text == "" ? "Svrha nije unesena" : txtSvrha.Text,
                    Uplatnica = podaciUvjerenje[0].Uplatnica,
                    Printano = 0
                };
                db.StudentiUvjerenja.Add(uvjerenje);
                db.SaveChanges();
                Tekst += $"{DateTime.Now.ToString("HH:mm:ss")} -> {vrsta} studentu {kliknutiStudent.ToString()} u svrhu {svrha} {Environment.NewLine}";
            }
            Action action = () =>
            {
                txtInfo.Text = Tekst;
                UcitajUvjerenja();
            };
            BeginInvoke(action);
        }

        private bool jeValidno()
        {
            return Helpers.Validator.ProvjeriUnos(cmbVrsta, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtSvrha, errorProvider1, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtBrojZahtjeva, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}
