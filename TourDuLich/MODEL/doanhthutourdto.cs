using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class doanhthutourdto
    {
        [System.ComponentModel.DisplayName("Mã tour")]
        public int matour { get; set; }
        [System.ComponentModel.DisplayName("Tên tour")]
        public string tentour { get; set; }
        [System.ComponentModel.DisplayName("Giá tour")]
        public double giatour { get; set; }
        [System.ComponentModel.DisplayName("Tổng thu")]
        public double tienve { get; set; }
        [System.ComponentModel.DisplayName("Ngày tạo")]
        public Nullable<System.DateTime> ngaytao { get; set; }

        public doanhthutourdto(doandulich entity)
        {
            matour = entity.idtour;
            tentour = entity.tour.tentour;
            giatour = entity.tongtientour;
            tienve = entity.tienve;
            ngaytao = entity.ngaytao;
        }
    }
}
