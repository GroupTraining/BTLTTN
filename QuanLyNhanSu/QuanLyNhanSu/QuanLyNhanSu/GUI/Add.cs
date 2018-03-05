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
    public partial class Add : Form
    {
        TaiKhoanBUS tkb = new TaiKhoanBUS();
        public Add()
        {
            InitializeComponent();
        }
        QLTaiKhoanDataContext tks = new QLTaiKhoanDataContext();
        private void Add_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = tkb.getData();            
        }
        private void button1_Click(object sender, EventArgs e)
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
            if(rabtn_nam.Checked == true)
            {
                NV.GT = false;
            }
            if(rabtn_nu.Checked == true)
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
            dgvNhanVien.DataSource = tkb.getData();
            dgvNhanVien.Refresh();
            MessageBox.Show("Đã thêm thành công");
        }
    }
    }
