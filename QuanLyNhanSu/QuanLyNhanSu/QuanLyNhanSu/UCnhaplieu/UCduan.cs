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
    public partial class UCduan : UserControl
    {
        public UCduan()
        {
            InitializeComponent();

            QLTaiKhoanDataContext db2 = new QLTaiKhoanDataContext();

            dataGridView1.DataSource = from x in db2.DuAns
                                       from y in db2.PhongBans
                                       where x.MaPB == y.MaPB
                                       select new
                                       {
                                           TenDA = x.TenDA,
                                           DiaDiem = x.DiaDiem,
                                           TenPB = y.TenPB
                                       };
        }
    }
}
