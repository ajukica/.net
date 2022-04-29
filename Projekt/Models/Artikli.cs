using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt.Models
{
    public class Artikli
    {
        public int  ArtikliID  { get; set; }
        public string Naziv { get; set; }
        public string Cijena { get; set; }
        public int KategorijaID { get; set; }

    }
}