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
    public partial class frmNhapDiem : Form
    {
        /// <summary>
        /// lấy danh sách ở combobox
        /// </summary>
        BUS_LopHoc busLopHoc = new BUS_LopHoc();
        BUS_MonHoc busMonHoc = new BUS_MonHoc();
        BUS_NamHoc busNamHoc = new BUS_NamHoc();
        BUS_NhapDiem busNhapDiem = new BUS_NhapDiem();
    
        /// <summary>
        /// khai báo biến chung
        /// </summary>
        string CotDiem;
        int HocKy = 1;//mặc định là học kì 1
        DTO_LopHoc dtoLopHoc = new DTO_LopHoc();
        DTO_NamHoc dtoNamHoc = new DTO_NamHoc();
        DTO_MonHoc dtoMonHoc = new DTO_MonHoc();
        /// <summary>
        /// danh sách biến trong các combobox
        /// </summary>
        /// 
        List<DTO_NamHoc> lNamHoc = new List<DTO_NamHoc>();
        List<DTO_LopHoc> lLopHoc = new List<DTO_LopHoc>();
        List<DTO_MonHoc> lMonHoc = new List<DTO_MonHoc>();



        public frmNhapDiem()
        {
            InitializeComponent();
        }
        void HienThiTrongCombobox()
        {
            lNamHoc = busNamHoc.bgetListNamHoc();
            cbNamHoc.DataSource = lNamHoc;
            cbNamHoc.DisplayMember = "tennh";
            cbNamHoc.ValueMember = "manh";
            lLopHoc = busLopHoc.bgetlistLopHoc();
            cbLop.DataSource = lLopHoc;
            cbLop.DisplayMember = "tenlop";
            cbLop.ValueMember = "malop";
            lMonHoc = busMonHoc.bgetlistMonHoc();
            cbMon.DataSource = lMonHoc;
            cbMon.DisplayMember = "tenmh";
            cbMon.ValueMember = "mamh";
        }
        private void dgvNhapDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Thoat_Click(object sender, EventArgs e)
        {

        }

        private void hocky1_CheckedChanged(object sender, EventArgs e)
        {

        }
       
        private void cbCotDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dtoLopHoc.MaLop = Convert.ToInt32(cbLop.SelectedValue.ToString());
            dtoMonHoc.MaMH = Convert.ToInt32(cbMon.SelectedValue.ToString());
            dtoNamHoc.MaNH = Convert.ToInt32(cbNamHoc.SelectedValue.ToString());
            if (cbCotDiem.Text == "Miệng")
                CotDiem = "DiemMieng";
            if (cbCotDiem.Text == "Điểm 15 phút lần 1")
                CotDiem = "Diem15pl1";
            if (cbCotDiem.Text == "Điểm 15 phút lần 2")
                CotDiem = "Diem15pl2";
            if (cbCotDiem.Text == "Điểm 15 phút lần 3")
                CotDiem = "Diem15pl3";
            if (cbCotDiem.Text == "1 Tiết lần 1")
                CotDiem = "Diem1tl1";
            if (cbCotDiem.Text == "1 Tiết lần 2")
                CotDiem = "Diem1tl2";
            if (cbCotDiem.Text == "1 Tiết lần 3")
                CotDiem = "Diem1tl3";
            if (cbCotDiem.Text == "Điểm thi")
                CotDiem = "Diemhocky";
           
             if (hocky2.Checked)
                HocKy = 2;
            dgvNhapDiem.DataSource = busNhapDiem.getBangDiem(dtoNamHoc.MaNH, HocKy, dtoLopHoc.MaLop, dtoMonHoc.MaMH, CotDiem);

        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            HienThiTrongCombobox();
        }
    }
}
