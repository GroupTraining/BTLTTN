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
    public partial class UCphongban : UserControl
    {
        public UCphongban()
        {
            InitializeComponent();

            QuanlynsDataContext db = new QuanlynsDataContext();

            dataGridView1.DataSource = db.PhongBans.Select(p => p);
        }
    }
}
