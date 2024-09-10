using FIT.Infrastructure;
using FIT.WinForms.Dule_savic;
using FIT.WinForms.Feb24;
using FIT.WinForms.Izvjestaji;
using FIT.WinForms.Jan24;
using FIT.WinForms.Jul24;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms
{
    public partial class frmPocetna : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            lblKonekcijaInfo.Text = $"Broj studenata u bazi -> {db.Studenti.Count()}";
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            new frmIzvjestaji().Show();
        }

        private void btnDrzave_Click(object sender, EventArgs e)
        {
            new frmDrzave().Show();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            new frmPretraga().Show();
        }

        private void btnIspit_Click(object sender, EventArgs e)
        {
            new frmProstorije().Show();
        }

        private void btnDule_Click(object sender, EventArgs e)
        {
            new frmPretragaJul24().Show();
        }
    }
}
