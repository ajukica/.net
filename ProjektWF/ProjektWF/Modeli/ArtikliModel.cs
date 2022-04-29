using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWF.Modeli
{
    internal class ArtikliModel
    {
        public int ArtikliID { get; set; }
        public string Naziv { get; set; }
        public string Cijena { get; set; }
        public int KategorijaID { get; set; }
    }
}
