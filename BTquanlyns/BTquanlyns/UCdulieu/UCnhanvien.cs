using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTquanlyns.UCdulieu
{
    public partial class UCnhanvien : UserControl
    {
        public UCnhanvien()
        {
            InitializeComponent();

            QuanlynsDataContext db1 = new QuanlynsDataContext();

            dataGridView1.DataSource = from u in db1.NhanViens
                                       from t in db1.PhongBans
                                       from v in db1.PhanCongs
                                       from z in db1.DuAns
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
