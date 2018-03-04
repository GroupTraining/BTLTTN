using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.UCnhaplieu;

namespace QuanLyNhanSu.GUI
{
    public partial class Tracuu : Form
    {
        public Tracuu()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();

            main.ShowDialog();
        }

        private void Timkiem_Load(object sender, EventArgs e)
        {
            UCimage ucnen = new UCimage();
            ucnen.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucnen);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            UCphongban ucpb = new UCphongban();
            ucpb.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucpb);
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            UCnhanvien ucnv = new UCnhanvien();
            ucnv.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucnv);
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            UCduan ucda = new UCduan();
            ucda.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucda);
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            Timkiem tk = new Timkiem();

            tk.ShowDialog();
        }
    }
}
