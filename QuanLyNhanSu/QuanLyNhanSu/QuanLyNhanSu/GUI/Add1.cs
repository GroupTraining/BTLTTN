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
    public partial class Add1 : Form
    {
        TaiKhoanBUS tkb = new TaiKhoanBUS();
        public Add1()
        {
            InitializeComponent();
            dataGridViewX1.DataSource = tkb.getData();
        }
        QLTaiKhoanDataContext tks = new QLTaiKhoanDataContext();
        private void btn_add_Click(object sender, EventArgs e)
        {
            QLTaiKhoanDataContext tk = new QLTaiKhoanDataContext();

            NhanVien NV = new NhanVien();
            PhanCong pc = new PhanCong();

            NV.MaNV = txtMaNV.Text;
            pc.MaNV = txtMaNV.Text;
            pc.MaDA = txtDuAn.Text;
            NV.HoTen = txtHoTen.Text;
            NV.Luong = Convert.ToInt32(txtLuong.Text);
            NV.MaNGS = txtMaNGS.Text;
            NV.MaPB = txtMaPB.Text;
            if (rabtn_nam.Checked == true)
            {
                NV.GT = false;
            }
            if (rabtn_nu.Checked == true)
            {
                NV.GT = true;
            }
            NV.NS = Convert.ToDateTime(txtNS.Text);
            tks.PhanCongs.InsertOnSubmit(pc);
            tks.NhanViens.InsertOnSubmit(NV);
            tks.SubmitChanges();


            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtNS.Text = "";
            txtLuong.Text = "";
            txtMaNGS.Text = "";
            txtMaPB.Text = "";
            dataGridViewX1.DataSource = tkb.getData();
            dataGridViewX1.Refresh();
            MessageBox.Show("Đã thêm thành công");
        }
    }
}
