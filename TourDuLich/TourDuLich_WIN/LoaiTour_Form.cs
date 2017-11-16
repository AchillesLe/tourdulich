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
    public partial class LoaiTour_Form : Form
    {        
        public LoaiTour_Form()
        {
            InitializeComponent();
        }
        private void clearform()
        {
            LoaiTourBIZ ltb = new LoaiTourBIZ();
            textBox2.Clear();
            textBox1.Text = (ltb.getcurrentid() + 1).ToString();
            this.ActiveControl = textBox2;
            textBox2.SelectAll();
        }
        private void tablewidth()
        {
            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 175;
        }
        private void LoaiTour_Form_Load(object sender, EventArgs e)
        {
            LoaiTourBIZ ltb = new LoaiTourBIZ();
            textBox1.Enabled = false;
            textBox1.Text = (ltb.getcurrentid() + 1).ToString();
            dataGridView1.DataSource = ltb.list();
            tablewidth();
        }

        //ADD
        private void button1_Click(object sender, EventArgs e)
        {
            LoaiTourBIZ ltb = new LoaiTourBIZ();
            loaitour entity = new loaitour();
            entity.id = Int32.Parse(textBox1.Text);
            entity.tenloaitour = textBox2.Text.ToUpper();
            if (ltb.find(entity.tenloaitour))
            {
                bool check = ltb.add(entity);
                if (check)
                {
                    MessageBox.Show("Thêm Thành Công");
                    dataGridView1.DataSource = ltb.list();
                    clearform();
                }
                else
                    MessageBox.Show("Thêm Thất Bại");
            }
            else
            {
                MessageBox.Show("Đã tồn tại loại hình du lịch trong CSDL");
                this.ActiveControl = textBox2;
                textBox2.SelectAll();
            }
           
        }

        //private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
        //    textBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();
        //    button2.Enabled = true;
        //    button1.Enabled = false;
        //}

        ////Update
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    LoaiTourBIZ ltb = new LoaiTourBIZ();
        //    loaitour entity = new loaitour();
        //    entity.maloai = Int32.Parse(textBox1.Text);
        //    entity.tenloaitour = textBox2.Text.ToUpper();
        //    if (ltb.find(entity.tenloaitour))
        //    {
        //        bool check = ltb.update(entity);
        //        if (check)
        //        {
        //            MessageBox.Show("Cập nhật thành công");
        //            dataGridView1.DataSource = ltb.list();
        //            clearform();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Cập nhật thất bại");
        //        }
        //    }
        //    else
        //    {
        //        textBox2.Focus();
        //        MessageBox.Show("Đã tồn tại loại hình du lịch trong CSDL");
        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
