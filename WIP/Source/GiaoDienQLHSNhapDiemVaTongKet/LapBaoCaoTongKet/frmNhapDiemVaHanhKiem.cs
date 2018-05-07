using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS2
{
    public partial class frmNhapDiemVaHanhKiem : Form
    {
        public frmNhapDiemVaHanhKiem()
        {
            InitializeComponent();
        }

        private void nhậpĐiểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNhapDiem f1 = new frmNhapDiem();
            f1.MdiParent = this;
            f1.Show();
        }
    }
}
