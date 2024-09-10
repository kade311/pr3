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
    public partial class frmStudentInfo : Form
    {
        private Student kliknutiStudent;
        DLWMSDbContext db = new DLWMSDbContext();
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        public frmStudentInfo(Student kliknutiStudent)
        {
            this.kliknutiStudent = kliknutiStudent;
            InitializeComponent();
            pbSlika.Image = Helpers.Ekstenzije.ToImage(kliknutiStudent.Slika);
            lblIme.Text = kliknutiStudent.Ime + " " + kliknutiStudent.Prezime;
            List<PolozeniPredmeti> ocjene = db.PolozeniPredmeti.Where(x=>x.StudentId== kliknutiStudent.Id).ToList();
            var prosjek = ocjene.Count() == 0 ? "5" : ocjene.Average(x => x.Ocjena).ToString();
            lblProsjek.Text = "Prosjek:" + prosjek;
        }
    }
}
