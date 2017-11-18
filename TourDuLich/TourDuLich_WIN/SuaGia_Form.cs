using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIZ;
using MODEL;

namespace TourDuLich_WIN
{
    public partial class SuaGia_Form : Form
    {
        public SuaGia_Form(string matour, string giatour)
        {
            InitializeComponent();
            label2.Text = matour;
            label4.Text = giatour;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Double.Parse(label4.Text) >= Double.Parse(numericUpDown1.Value.ToString()))
            {
                DialogResult result = MessageBox.Show("Giá mới thấp hơn hoặc bàng giá cũ, bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    TourBIZ tb = new TourBIZ();
                    tour tour = new tour();
                    tour = tb.laytoursuagia(Int32.Parse(label2.Text));
                    tour.giatour = Double.Parse(numericUpDown1.Value.ToString());
                    tour.ngaycapnhat = DateTime.Now;
                    bool check = tb.update(tour);
                    if (check)
                    {
                        LichSuGiaTourBIZ lsgtb = new LichSuGiaTourBIZ();
                        LichSuGiaTourBIZ lsgtb1 = new LichSuGiaTourBIZ();
                        lichsugiatour ls = new lichsugiatour();
                        ls = lsgtb.find(tour.id);
                        ls.ngayketthuc = tour.ngaycapnhat;
                        lsgtb.update(ls);
                        lichsugiatour ls1 = new lichsugiatour();
                        ls1.idtour = tour.id;
                        ls1.giatour = tour.giatour;
                        ls1.ngaybatdau = tour.ngaycapnhat;
                        ls1.ngayketthuc = null;
                        lsgtb1.add(ls1);
                        MessageBox.Show("Cập nhật giá thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }
                else
                {

                }
            }
            else
            {
                TourBIZ tb = new TourBIZ();
                tour tour = new tour();
                tour = tb.laytoursuagia(Int32.Parse(label2.Text));
                tour.giatour = Double.Parse(numericUpDown1.Value.ToString());
                bool check = tb.update(tour);
                if (check)
                {
                    LichSuGiaTourBIZ lsgtb = new LichSuGiaTourBIZ();
                    LichSuGiaTourBIZ lsgtb1 = new LichSuGiaTourBIZ();
                    lichsugiatour ls = new lichsugiatour();
                    ls = lsgtb.find(tour.id);
                    ls.ngayketthuc = tour.ngaycapnhat;
                    lsgtb.update(ls);
                    lichsugiatour ls1 = new lichsugiatour();
                    ls1.idtour = tour.id;
                    ls1.giatour = tour.giatour;
                    ls1.ngaybatdau = tour.ngaycapnhat;
                    ls1.ngayketthuc = null;
                    lsgtb1.add(ls1);
                    MessageBox.Show("Cập nhật giá thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }
    }
}
