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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

            
        }

        private void báoCáoTổngKếtMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLapBaoCaoTongKetMon f1 = new frmLapBaoCaoTongKetMon();
            f1.MdiParent = this;
            f1.Show();
        }

        private void báoCáoTổngKếtHọcKỳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLapBaoCaoTongKetHocKy f2 = new frmLapBaoCaoTongKetHocKy();
            f2.MdiParent = this;
            f2.Show();
        }
    }
}
