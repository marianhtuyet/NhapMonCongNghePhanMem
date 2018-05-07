using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhapDiemVaHanhKiem
{
    public partial class frmNhapDiemVaHanhKiem : Form
    {
        public frmNhapDiemVaHanhKiem()
        {
            InitializeComponent();
        }

        private void nhậpĐiểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void nhậpĐiểmToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmNhapDiem f1 = new frmNhapDiem();
            f1.MdiParent = this;
            f1.Show();
        }

        private void nhậpHạnhKiểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNhapHanhKiem f2 = new frmNhapHanhKiem();
            f2.MdiParent = this;
            f2.Show();
        }
    }
}
