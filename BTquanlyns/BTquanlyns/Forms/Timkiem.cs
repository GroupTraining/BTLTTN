using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTquanlyns.Forms
{
    public partial class Timkiem : Form
    {
        public Timkiem()
        {
            InitializeComponent();
            QuanlynsDataContext db4 = new QuanlynsDataContext();

            dataGridView1.DataSource = from u in db4.NhanViens
                                       from t in db4.PhongBans
                                       from v in db4.PhanCongs
                                       from z in db4.DuAns
                                       where u.MaNV == v.MaNV
                                       where v.MaDA == z.MaDA
                                       where u.MaPB == t.MaPB
                                       select new
                                       {
                                           MaNV = u.MaNV,
                                           HoTen = u.HoTen,
                                           NS = u.NS,
                                           GT = u.GT,
                                           TenPB = t.TenPB,
                                           TenDA = z.TenDA
                                       };
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManv.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            txtHoten.Text = dataGridView1.CurrentRow.Cells["Hoten"].Value.ToString();
            txtNs.Text = dataGridView1.CurrentRow.Cells["NS"].Value.ToString();
            txtPb.Text = dataGridView1.CurrentRow.Cells["TenPB"].Value.ToString();
            txtGt.Text = dataGridView1.CurrentRow.Cells["GT"].Value.ToString();
            txtDa.Text = dataGridView1.CurrentRow.Cells["TenDA"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanlynsDataContext db3 = new QuanlynsDataContext();

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
                                           TenPB = t.TenPB,
                                           TenDA = z.TenDA
                                       } into timkiemNV
                                       where timkiemNV.MaNV.Contains(txtThongtin.Text)
                                       || timkiemNV.HoTen.Contains(txtThongtin.Text)
                                       || timkiemNV.TenPB.Contains(txtThongtin.Text)
                                       || timkiemNV.TenDA.Contains(txtThongtin.Text)
                                       select timkiemNV;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanlynsDataContext db5 = new QuanlynsDataContext();

            dataGridView1.DataSource = from u in db5.NhanViens
                                       from t in db5.PhongBans
                                       from v in db5.PhanCongs
                                       from z in db5.DuAns
                                       where u.MaNV == v.MaNV
                                       where v.MaDA == z.MaDA
                                       where u.MaPB == t.MaPB
                                       select new
                                       {
                                           MaNV = u.MaNV,
                                           HoTen = u.HoTen,
                                           NS = u.NS,
                                           GT = u.GT,
                                           TenPB = t.TenPB,
                                           TenDA = z.TenDA
                                       };
        }
    }
}
