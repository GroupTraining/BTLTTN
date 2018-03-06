using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void menu_view_Click(object sender, EventArgs e)
        {
            GUI.Timkiem tk = new GUI.Timkiem();
            tk.ShowDialog();
            pan_menu.Visible = false;
        }

        private void menu_opt_Click(object sender, EventArgs e)
        {
            pan_menu.Visible = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GUI.Add1 ad = new GUI.Add1();
            ad.Show();
        }

        private void menu_hethong_Click(object sender, EventArgs e)
        {
            pan_menu.Visible = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            GUI.Edit edit = new GUI.Edit();
            edit.Show();
        }
    }
}
