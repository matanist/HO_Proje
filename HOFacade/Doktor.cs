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
    
    public partial class Doktor
    {
        public Doktor()
        {
            this.Randevu = new HashSet<Randevu>();
        }
    
        public int ID { get; set; }
        public string Ad { get; set; }
        public int HastaneID { get; set; }
        public int BransID { get; set; }
    
        public virtual Brans Brans { get; set; }
        public virtual Hastane Hastane { get; set; }
        public virtual ICollection<Randevu> Randevu { get; set; }
    }
}
