//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tinh
    {
        public tinh()
        {
            this.diadiems = new HashSet<diadiem>();
            this.khachsans = new HashSet<khachsan>();
            this.tinhkes = new HashSet<tinhke>();
            this.tinhkes1 = new HashSet<tinhke>();
            this.tours = new HashSet<tour>();
            this.tours1 = new HashSet<tour>();
        }
    
        public int id { get; set; }
        public string tentinh { get; set; }
    
        public virtual ICollection<diadiem> diadiems { get; set; }
        public virtual ICollection<khachsan> khachsans { get; set; }
        public virtual ICollection<tinhke> tinhkes { get; set; }
        public virtual ICollection<tinhke> tinhkes1 { get; set; }
        public virtual ICollection<tour> tours { get; set; }
        public virtual ICollection<tour> tours1 { get; set; }
    }
}
