//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HOFacade
{
    using System;
    using System.Collections.Generic;
    
    public partial class Randevu
    {
        public int ID { get; set; }
        public System.DateTime Tarih { get; set; }
        public string HastaAd { get; set; }
        public string HastaTCKimlikNo { get; set; }
        public int HastaneID { get; set; }
        public int BransID { get; set; }
        public int DoktorID { get; set; }
    
        public virtual Brans Brans { get; set; }
        public virtual Doktor Doktor { get; set; }
        public virtual Hastane Hastane { get; set; }
    }
}
