using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.Feb24
{
    public class Nastava
    {
        public int Id { get; set; }
        public int ProstorijaId { get; set; }
        public int PredmetId { get; set; }
        public string Vrijeme { get; set; }
        public string Dan { get; set; }
        public string Oznaka { get; set; }
    }
}
