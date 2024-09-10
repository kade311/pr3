using FIT.Data.Feb24;
using FIT.Infrastructure;
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

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestajFeb24 : Form
    {
        private Prostorije kliknutaProstorija;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmIzvjestajFeb24()
        {
            InitializeComponent();
        }

        public frmIzvjestajFeb24(Prostorije kliknutaProstorija)
        {
            this.kliknutaProstorija = kliknutaProstorija;
            InitializeComponent();
        }

        private void frmIzvjestajFeb24_Load(object sender, EventArgs e)
        {
            if (kliknutaProstorija != null)
            {
                //var podaciNastava = db.Nastava.Where(x=>x.ProstorijaId==kliknutaProstorija.Id).ToList();
                var podaciPrisustvo = db.Prisustvo.Where(x=>x.NastavaId==db.Nastava.FirstOrDefault(x => x.ProstorijaId == kliknutaProstorija.Id).Id).ToList();
                var brojNastava = podaciPrisustvo.Count();
                var nazivProstorije = kliknutaProstorija.Naziv;
                var rpc = new ReportParameterCollection();
                rpc.Add(new ReportParameter("brojStudenata",brojNastava.ToString()));
                rpc.Add(new ReportParameter("nazivProstorije", nazivProstorije));

                //MessageBox.Show($"{podaciPrisustvo.Count()}");

                var tabela = new DataSet2.DataTable1DataTable();

                for (int i = 0; i < podaciPrisustvo.Count(); i++)
                {
                    var red = tabela.NewDataTable1Row();

                    //var student = db.Studenti.FirstOrDefault(x => x.Id == db.Prisustvo.FirstOrDefault(s => s.NastavaId == podaciNastava[i].Id).StudentId);
                    var student = db.Studenti.FirstOrDefault(x => x.Id == podaciPrisustvo[i].StudentId);
                    
                    red.Rb = $"{i+1}".ToString();
                    red.Predmet = db.Predmeti.FirstOrDefault(x => x.Id == db.Nastava.FirstOrDefault(s=>s.ProstorijaId==kliknutaProstorija.Id).PredmetId).Naziv;
                    red.Vrijeme = db.Nastava.FirstOrDefault(s => s.ProstorijaId == kliknutaProstorija.Id).Vrijeme;
                    red.BrojIndeksa = student.Indeks;
                    red.ImePrezime = student.Ime + " " + student.Prezime;

                    tabela.Rows.Add(red);
                }

                var rds = new ReportDataSource()
                {
                    Name = "DataSet2",
                    Value = tabela
                };

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Nevalidna prostorija");
            }
        }
    }
}
