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
    
    public partial class doanbuaan
    {
        public int id { get; set; }
        public int iddoan { get; set; }
        public int idbuaan { get; set; }
        public System.DateTime ngay { get; set; }
        public double sotien { get; set; }
    
        public virtual chiphibuaan chiphibuaan { get; set; }
        public virtual doandulich doandulich { get; set; }
    }
}
