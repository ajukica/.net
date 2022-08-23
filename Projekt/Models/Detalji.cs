using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt.Models
{
    public class Detalji
    {
       

        public int RacunID { get; set; }
        public string Kategorija { get; set; }      
        public string Naziv { get; set; }
        public string Kupac { get; set; }
        public string Zaposlenik { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
    }
}