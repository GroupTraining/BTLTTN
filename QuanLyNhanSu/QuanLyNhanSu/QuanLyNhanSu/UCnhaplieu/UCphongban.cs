using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace QuanLyNhanSu.UCnhaplieu
{
    public partial class UCphongban : UserControl
    {
        public UCphongban()
        {
            InitializeComponent();

            QLTaiKhoanDataContext db = new QLTaiKhoanDataContext();

            dataGridView1.DataSource = db.PhongBans.Select(p => p);
        }
    }
}
