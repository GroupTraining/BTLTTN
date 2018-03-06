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
    public partial class Edit : Form
    {
        TaiKhoanBUS tkb = new TaiKhoanBUS();
        public Edit()
        {
            InitializeComponent();
            dataGridView1.DataSource = tkb.getData1();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManv.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            txtHoten.Text = dataGridView1.CurrentRow.Cells["Hoten"].Value.ToString();
            txtNs.Text = dataGridView1.CurrentRow.Cells["NS"].Value.ToString();
            txtPb.Text = dataGridView1.CurrentRow.Cells["MaPB"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["GT"].Value.ToString() == "False")
            {
                txtGt.Text = "Nam";
            }
            else
            {
                txtGt.Text = "Nữ";
            }
            txtDa.Text = dataGridView1.CurrentRow.Cells["MaDA"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//TIm kiem
        {
            QLTaiKhoanDataContext db3 = new QLTaiKhoanDataContext();

            dataGridView1.DataSource = from u in db3.NhanViens
                                       from t in db3.PhongBans
                                       from v in db3.PhanCongs
                                       from z in db3.DuAns
                                       where u.MaNV == v.MaNV
                                       where v.MaDA == z.MaDA
                                       where u.MaPB == t.MaPB
                                       select new
                                       {
                                           MaNV = u.MaNV,
                                           HoTen = u.HoTen,
                                           NS = u.NS,
                                           GT = u.GT,
                                           MaPB = t.MaPB,
                                           MaDA = z.MaDA
                                       } into timkiemNV
                                       where timkiemNV.MaNV.Contains(txtThongtin.Text)
                                       || timkiemNV.HoTen.Contains(txtThongtin.Text)
                                       || timkiemNV.MaPB.Contains(txtThongtin.Text)
                                       || timkiemNV.MaDA.Contains(txtThongtin.Text)
                                       select timkiemNV;
        }

        private void button2_Click(object sender, EventArgs e)//Cap nhat
        {
            TaiKhoanBUS edit = new TaiKhoanBUS();
            edit.Edit(txtManv.Text, txtHoten.Text, txtNs.Text, txtGt.Text, txtPb.Text, txtDa.Text);
            dataGridView1.DataSource = tkb.getData1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              
        }

        private void Timkiem_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//Xóa
        {
            tkb.Delete(txtManv.Text);
            dataGridView1.DataSource = tkb.getData1();
        }
    }
}
