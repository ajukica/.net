//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class RacunArtikli
    {
        public int ID { get; set; }
        public int RacunID { get; set; }
        public int ArtikliID { get; set; }
        public int Kolicina { get; set; }
    
        public virtual Artikli Artikli { get; set; }
        public virtual Racun Racun { get; set; }
    }
}
