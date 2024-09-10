using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.Jan24
{
    public class Drzave
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Status { get; set; }
        public byte[] Zastava { get; set; }
    }
}
