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
    public partial class Tour_Form : Form
    {
        public Tour_Form()
        {
            InitializeComponent();
        }

        //xóa dòng trong datagrid
        private void xoa(object sender, EventArgs args)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                if (dataGridView1.RowCount <= 1)
                    button5.Enabled = false;
            }
            catch { }
        }

        //làm mới form
        private void clear()
        {
            TourBIZ tb = new TourBIZ();
            textBox1.Text = (tb.getcurrentid() + 1).ToString();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            numericUpDown1.Value = 0;
            richTextBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox4.DataSource = null;
            panel1.Enabled = true;
            panel2.Enabled = false;
            dataGridView1.Rows.Clear();
        }

        //load combobox
        private void loadcombobox()
        {
            //combobox diem den, diem di
            TinhThanhBIZ ttb = new TinhThanhBIZ();
            List<string> tinhdiemdi = ttb.danhsachtinh();
            List<string> tinhdiemden = ttb.danhsachtinh();
            comboBox1.DataSource = tinhdiemdi;
            comboBox2.DataSource = tinhdiemden;
            //combobox loai tour
            LoaiTourBIZ ltb = new LoaiTourBIZ();
            List<string> loaitour = ltb.danhsachloaitour();
            comboBox3.DataSource = loaitour;
        }
        private void Tour_Form_Load(object sender, EventArgs e)
        {
            TourBIZ tb = new TourBIZ();
            loadcombobox();
            textBox1.Text = (tb.getcurrentid() + 1).ToString();
            panel2.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox2.SelectedItem)
            {
                MessageBox.Show("Điểm đến không được trùng với điểm đi");
            }
            else
            {
                if (numericUpDown1.Value.ToString() == "")
                {
                    numericUpDown1.Value = 0;
                }
                if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null || numericUpDown1.Value == 0 || richTextBox1.Text == "")
                {
                    MessageBox.Show("Chưa điền đầy đủ thông tin");
                }
                else
                {
                    panel1.Enabled = false;
                    panel2.Enabled = true;
                    button5.Enabled = false;
                    textBox2.Text = comboBox2.SelectedItem.ToString();
                    textBox3.Text = textBox1.Text;
                    //combobox địa điểm tham quan
                    DiaDiemBIZ ddb = new DiaDiemBIZ();
                    TinhThanhBIZ ttb = new TinhThanhBIZ();
                    List<string> diadiemtheotinh = ddb.listdiadiemtheotinh(ttb.laymatinh(comboBox2.SelectedItem.ToString()));
                    comboBox4.DataSource = diadiemtheotinh;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Chưa có địa điểm tham quan");
            }
            else
            {
                if (dataGridView1.RowCount > 1)
                {
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[2].Value.ToString() == comboBox4.SelectedItem.ToString())
                        {
                            MessageBox.Show("Đã thêm địa điểm này trước đó");
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        dataGridView1.Rows.Add(dataGridView1.RowCount, textBox1.Text, comboBox4.SelectedItem.ToString());
                    }
                    else
                    { }
                }
                else
                {
                    dataGridView1.Rows.Add(dataGridView1.RowCount, textBox1.Text, comboBox4.SelectedItem.ToString());
                    button5.Enabled = true;
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    //Tao menu ngu canh
                    ContextMenuStrip menu = new ContextMenuStrip();
                    menu.Items.Add("Xóa", null, new EventHandler(xoa));
                    //Di chuyen den dong hien hanh
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    //hien thi menu
                    Point pt = dataGridView1.PointToClient(Control.MousePosition);
                    menu.Show(dataGridView1, pt.X, pt.Y);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TinhThanhBIZ ttb = new TinhThanhBIZ();
            LoaiTourBIZ ltb = new LoaiTourBIZ();
            DiaDiemBIZ ddb = new DiaDiemBIZ();
            TourBIZ tb = new TourBIZ();
            tour tour = new tour();
            tour.tentour = comboBox1.SelectedItem.ToString() + " - " + comboBox2.SelectedItem.ToString();
            tour.diemden = ttb.laymatinh(comboBox2.SelectedItem.ToString());
            tour.diemdi = ttb.laymatinh(comboBox1.SelectedItem.ToString());
            tour.dacdiem = richTextBox1.Text;
            tour.giatour = Double.Parse(numericUpDown1.Value.ToString());
            tour.idtour = ltb.layidloaitour(comboBox3.SelectedItem.ToString());
            tour.ngaytao = DateTime.Now;
            tour.ngaycapnhat = tour.ngaytao;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                ctthamquan ct = new ctthamquan();
                ct.idtour = Int32.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                ct.iddiadiem = ddb.layiddiadiem(dataGridView1.Rows[i].Cells[2].Value.ToString());
                tour.ctthamquans.Add(ct);
            }
            bool check = tb.add(tour);
            if (check)
            {
                lichsugiatour ls = new lichsugiatour();
                LichSuGiaTourBIZ lsgtb = new LichSuGiaTourBIZ();
                ls.idtour = tour.id;
                ls.giatour = tour.giatour;
                ls.ngaybatdau = tour.ngaycapnhat;
                ls.ngayketthuc = null;
                lsgtb.add(ls);
                MessageBox.Show("Thêm tour thành công");
                clear();
            }
            else
            {
                MessageBox.Show("Thêm tour thất bại");
                clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DanhSachTour_Form form = new DanhSachTour_Form();
            form.Show();
        }
    }
}
