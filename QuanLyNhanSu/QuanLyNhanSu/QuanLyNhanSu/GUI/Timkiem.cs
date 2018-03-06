using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace QuanLyNhanSu.GUI
{
    public partial class Timkiem : Form
    {
        TaiKhoanBUS tkb = new TaiKhoanBUS();
        public Timkiem()
        {
            InitializeComponent();      
            dataGridView1.DataSource = tkb.getData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManv.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            txtHoten.Text = dataGridView1.CurrentRow.Cells["Hoten"].Value.ToString();
            txtNs.Text = dataGridView1.CurrentRow.Cells["NS"].Value.ToString();
            txtPb.Text = dataGridView1.CurrentRow.Cells["TenPB"].Value.ToString();
            if(dataGridView1.CurrentRow.Cells["GT"].Value.ToString() == "False")
            {
                txtGt.Text = "Nam";
            }else
            {
                txtGt.Text = "Nữ";
            }
           
            txtDa.Text = dataGridView1.CurrentRow.Cells["TenDA"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLTaiKhoanDataContext db3 = new QLTaiKhoanDataContext();

            dataGridView1.DataSource = tkb.Search(txtThongtin.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLTaiKhoanDataContext db5 = new QLTaiKhoanDataContext();

            dataGridView1.DataSource = tkb.getData();
        }
    }
}
