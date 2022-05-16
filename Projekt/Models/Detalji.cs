using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt.Models
{
    public class Detalji
    {
        public int RacunID { get; set; }
        public string kategorijaNaziv { get; set; }      
        public string naziv { get; set; }
        public string kupac { get; set; }
        public int zaposlenikid { get; set; }
        public int kolicina { get; set; }
    }
}