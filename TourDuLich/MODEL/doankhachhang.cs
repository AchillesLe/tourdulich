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
    
    public partial class doankhachhang
    {
        public int id { get; set; }
        public int iddoan { get; set; }
        public int idkhachhang { get; set; }
        public double sotien { get; set; }
    
        public virtual doandulich doandulich { get; set; }
        public virtual khachhang khachhang { get; set; }
    }
}
