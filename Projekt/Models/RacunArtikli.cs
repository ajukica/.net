using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt.Models
{
    public class RacunArtikli
    {
        public int ID { get; set; }
        public int RacunID { get; set; }
        public int ArtikliID { get; set; }
        public int Kolicina { get; set; }

    }
}