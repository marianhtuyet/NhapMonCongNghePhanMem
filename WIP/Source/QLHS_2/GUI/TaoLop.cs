using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class TaoLop : Form
    {

        BUS_TaoLop busTaoLop = new BUS_TaoLop();
        BUS_TaoLop busLopCoSan = new BUS_TaoLop();
        public TaoLop()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiDanhSachLop();
        }
        public void HienThiDanhSachLop()
        {
            string NamHoc = cboNamHoc.Text;
            string LopHoc = cboLop.Text;
            DSLopCoSan.DataSource = busLopCoSan.getLopHocCoSan(NamHoc, LopHoc);
             
        }
            private void Form1_Load(object sender, EventArgs e)
        {
            HSChuaCoLop.DataSource = busTaoLop.getLopHoc();//phần bên trái
            HienThiDanhSachLop();
                


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboLop.DisplayMember = 
            cboLop.ValueMember = 
        }*/
    }
}
