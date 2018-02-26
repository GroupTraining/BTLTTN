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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Moveform
        Boolean flag;
        int x, y;
        private void frm_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }
        private void frm_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;

        }
        private void frm_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }
        #endregion

        TaiKhoanBUS tkb = new TaiKhoanBUS();
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if(tkb.check_login(txt_username.Text,txt_password.Text) == true)
            {
                this.Hide();
                GUI.Main main = new GUI.Main();
                main.Show();
            }else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
        }
    }
}
