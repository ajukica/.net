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
    
    public partial class Racun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Racun()
        {
            this.RacunArtiklis = new HashSet<RacunArtikli>();
        }
    
        public int RacunID { get; set; }
        public int KupacID { get; set; }
        public int ZaposlenikID { get; set; }
        public int Brojracuna { get; set; }
    
        public virtual Kupac Kupac { get; set; }
        public virtual Zaposlenik Zaposlenik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RacunArtikli> RacunArtiklis { get; set; }
    }
}