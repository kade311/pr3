using FIT.Data.Jan24;
using FIT.Infrastructure;
using Microsoft.Reporting.WinForms;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Drzave kliknutaDrzava;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(Drzave kliknutaDrzava)
        {
            InitializeComponent();
            this.kliknutaDrzava = kliknutaDrzava;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            

            if (kliknutaDrzava != null)
            {
                var podaciGradovi = db.Gradovi.Where(x => x.DrzavaId == kliknutaDrzava.Id).ToList();
                var rpc = new ReportParameterCollection();
                var brojGradova = podaciGradovi.Count().ToString();
                
                rpc.Add(new ReportParameter("brojGradova", brojGradova));
                reportViewer1.LocalReport.SetParameters(rpc);

                var tabela = new DataSet1.DataTable1DataTable();

                for (int i = 0; i < podaciGradovi.Count; i++)
                {
                    var status = podaciGradovi[i].Status == 1 ? "DA" : "NE";

                    var Red = tabela.NewDataTable1Row();
                    Red.Rb = $"{i+1}".ToString();
                    Red.Grad = podaciGradovi[i].Naziv;
                    Red.Drzava = kliknutaDrzava.Naziv;
                    Red.Status = status;
                    tabela.Rows.Add( Red );
                }
                var rds = new ReportDataSource()
                {
                    Name = "DataSet1",
                    Value = tabela
                };
                
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("No country selected.");
            }

            
        }
    }
}
