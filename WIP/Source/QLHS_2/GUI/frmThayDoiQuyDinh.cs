using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;


namespace GUI
{
    public partial class frmThayDoiQuyDinh : Form
    {
        BUS_ThayDoiQuyDinh busQuyDinh = new BUS_ThayDoiQuyDinh();
        DTO_ThayDoiQuyDinh dtoQuyDinh = new DTO_ThayDoiQuyDinh();


        /// <summary>
        /// khai báo biến chung
        /// tuoimax, tuoimin,..... (các thuộc tính của dtoQuyDinh
        /// </summary>
        /// 
        int tuoimax, tuoimin, siso, diemdat, diemmax, diemmin, slmon;
       

        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void frmThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            HienThiQuyDinh();
        }

        public void HienThiQuyDinh()
        {
            dgvQuyDinh.DataSource = busQuyDinh.getQuyDinh();
            dtoQuyDinh._TuoiMax = int.Parse(dgvQuyDinh[0, 0].Value.ToString());
            dtoQuyDinh._TuoiMin = int.Parse(dgvQuyDinh[1, 0].Value.ToString());
            dtoQuyDinh._SiSo = int.Parse(dgvQuyDinh[2, 0].Value.ToString());
            dtoQuyDinh._DiemDat = int.Parse(dgvQuyDinh[3, 0].Value.ToString());
            dtoQuyDinh._DiemMax = int.Parse(dgvQuyDinh[4,0].Value.ToString());
            dtoQuyDinh._DiemMin = int.Parse(dgvQuyDinh[5, 0].Value.ToString());
            dtoQuyDinh._SLMon = int.Parse(dgvQuyDinh[6, 0].Value.ToString());
            nudTuoiMax.Value = dtoQuyDinh._TuoiMax;
            nudTuoiMin.Value = dtoQuyDinh._TuoiMin;
            nudSiSo.Value = dtoQuyDinh._SiSo;
            nudDiemDat.Value = dtoQuyDinh._DiemDat;
            nudDiemMax.Value = dtoQuyDinh._DiemMax;
            nudDiemMin.Value = dtoQuyDinh._DiemMin;
            nudSLMon.Value = dtoQuyDinh._SLMon;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dtoQuyDinh._TuoiMax = Convert.ToInt32(Math.Round(nudTuoiMax.Value, 0));
            dtoQuyDinh._TuoiMin = Convert.ToInt32(Math.Round(nudTuoiMin.Value, 0));
            dtoQuyDinh._SiSo = Convert.ToInt32(Math.Round(nudSiSo.Value, 0));
            dtoQuyDinh._DiemDat = Convert.ToInt32(Math.Round(nudDiemDat.Value, 0));
            dtoQuyDinh._DiemMax = Convert.ToInt32(Math.Round(nudDiemMax.Value, 0));
            dtoQuyDinh._DiemMin = Convert.ToInt32(Math.Round(nudDiemMin.Value, 0));
            dtoQuyDinh._SLMon = Convert.ToInt32(Math.Round(nudSLMon.Value, 0));
            busQuyDinh.AddQuyDinh(dtoQuyDinh);
            HienThiQuyDinh();

        }

     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nudTuoiMax_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
