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
    
    public partial class doandulich
    {
        public doandulich()
        {
            this.doanbuaans = new HashSet<doanbuaan>();
            this.doanchiphikhacs = new HashSet<doanchiphikhac>();
            this.doankhachhangs = new HashSet<doankhachhang>();
            this.doankhachsans = new HashSet<doankhachsan>();
            this.doannhanviens = new HashSet<doannhanvien>();
            this.doanphuongtiens = new HashSet<doanphuongtien>();
        }
    
        public int id { get; set; }
        public int idtour { get; set; }
        public string tendoan { get; set; }
        public System.DateTime ngaykhoihanh { get; set; }
        public System.DateTime ngayketthuc { get; set; }
        public double tongtienkhachsan { get; set; }
        public double tongtienan { get; set; }
        public double tongtienphuongtien { get; set; }
        public double tongtienchiphikhac { get; set; }
        public double tongtientour { get; set; }
        public double tongtiendoan { get; set; }
        public System.DateTime ngaytao { get; set; }
    
        public virtual ICollection<doanbuaan> doanbuaans { get; set; }
        public virtual ICollection<doanchiphikhac> doanchiphikhacs { get; set; }
        public virtual tour tour { get; set; }
        public virtual ICollection<doankhachhang> doankhachhangs { get; set; }
        public virtual ICollection<doankhachsan> doankhachsans { get; set; }
        public virtual ICollection<doannhanvien> doannhanviens { get; set; }
        public virtual ICollection<doanphuongtien> doanphuongtiens { get; set; }
    }
}
