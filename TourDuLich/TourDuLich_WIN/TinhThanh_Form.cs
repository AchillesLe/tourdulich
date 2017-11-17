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
    public partial class TinhThanh_Form : Form
    {
        public TinhThanh_Form()
        {
            InitializeComponent();
        }

        private void TinhThanh_Form_Load(object sender, EventArgs e)
        {
            TinhThanhBIZ ttb = new TinhThanhBIZ();
            textBox1.Enabled = false;
            textBox1.Text = (ttb.getcurrentid() + 1).ToString();
            dataGridView1.DataSource = ttb.list();
            tablewidth();
        }

        private void clearform()
        {
            TinhThanhBIZ ttb = new TinhThanhBIZ();
            textBox2.Clear();
            textBox1.Text = (ttb.getcurrentid() + 1).ToString();
            this.ActiveControl = textBox2;
            textBox2.SelectAll();
        }

        private void tablewidth()
        {
            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 170;
        }

        public void ViewErrors(Dictionary<string, string> Dictionary)
        {
            errorProvider1.Clear();
            foreach (var entry in Dictionary)
            {
                switch (entry.Key)
                {
                    case "TENTINH":
                        errorProvider1.SetError(textBox2, entry.Value);
                        break;
                    default:
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            TinhThanhBIZ ttb = new TinhThanhBIZ();
            tinh entity = new tinh();
            entity.id = Int32.Parse(textBox1.Text);
            entity.tentinh = textBox2.Text.ToUpper();
            if (ttb.find(entity.tentinh))
            {
                bool check = ttb.add(entity);
                if (check)
                {
                    MessageBox.Show("Thêm Thành Công");
                    dataGridView1.DataSource = ttb.list();
                    clearform();
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại");
                    ViewErrors(ttb.validatedictionary);
                }
            }
            else
            {
                MessageBox.Show("Đã tồn tại loại hình du lịch trong CSDL");
                this.ActiveControl = textBox2;
                textBox2.SelectAll();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
