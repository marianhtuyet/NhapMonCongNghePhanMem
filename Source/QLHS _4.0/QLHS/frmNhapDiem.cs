﻿using System;
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
        /// 
        /// khai báo biến chung
        /// </summary>
       
        
        DTO_BangDiem dtoBangDiem = new DTO_BangDiem();
       
        //mặc định là học kì 1
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

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (hocky1.Checked == false && hocky2.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn học kỳ!!!!");
                return;
            }
            else if (cbCotDiem.Text=="")
            {
                MessageBox.Show("Vui lòng chọn hình thức kiểm tra!!!!");
                return;
            }
            dtoBangDiem.MaLop = Convert.ToInt32(cbLop.SelectedValue.ToString());
            dtoBangDiem.MaMH = Convert.ToInt32(cbMon.SelectedValue.ToString());
            dtoBangDiem.MaNH = Convert.ToInt32(cbNamHoc.SelectedValue.ToString());
            
            if (cbCotDiem.Text == "Điểm Miệng")
            {
                dtoBangDiem.LanKiemTra = 1;
                dtoBangDiem.HeSo = 1;
                dtoBangDiem.HinhThucKiemTra = "Mieng";

            }
            if (cbCotDiem.Text == "Điểm 15 phút lần 1")
            {
                dtoBangDiem.LanKiemTra = 1;
                dtoBangDiem.HeSo = 1;
                dtoBangDiem.HinhThucKiemTra = "Diem15p";
            }
            if (cbCotDiem.Text == "Điểm 15 phút lần 2")
            {
                dtoBangDiem.LanKiemTra = 2;
                dtoBangDiem.HeSo = 1;
                dtoBangDiem.HinhThucKiemTra = "Diem15p";
            }
            if (cbCotDiem.Text == "Điểm 15 phút lần 3")
            {
                dtoBangDiem.LanKiemTra = 3;
                dtoBangDiem.HeSo = 1;
                dtoBangDiem.HinhThucKiemTra = "Diem15p";
            }
            if (cbCotDiem.Text == "1 Tiết lần 1")
            {
                dtoBangDiem.LanKiemTra = 1;
                dtoBangDiem.HeSo = 2;
                dtoBangDiem.HinhThucKiemTra = "Diem1T";
            }
            if (cbCotDiem.Text == "1 Tiết lần 2")
            {
                dtoBangDiem.LanKiemTra = 2;
                dtoBangDiem.HeSo = 2;
                dtoBangDiem.HinhThucKiemTra = "Diem1T";
            }
            if (cbCotDiem.Text == "1 Tiết lần 3")
            {
                dtoBangDiem.LanKiemTra = 3;
                dtoBangDiem.HeSo = 2;
                dtoBangDiem.HinhThucKiemTra = "Diem1T";
            }
            if (cbCotDiem.Text == "Điểm thi")
            {
                dtoBangDiem.LanKiemTra = 1;
                dtoBangDiem.HeSo = 3;
                dtoBangDiem.HinhThucKiemTra = "DiemThi";
            }

            if (hocky2.Checked)
                dtoBangDiem.MaHK = 2;
            else
                dtoBangDiem.MaHK = 1;
            dgvNhapDiem.DataSource = busNhapDiem.getBangDiem(dtoBangDiem);
            btnLuu.Enabled = true;
            dgvNhapDiem.Rows[dtoBangDiem.Dem].Cells[2].ReadOnly = true;
        }

        
        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            HienThiTrongCombobox();
            dgvNhapDiem.Columns[0].ReadOnly = true;
            dgvNhapDiem.Columns[1].ReadOnly = true;
        }
        private bool IsNumber(string a)
        {
            char[] b = a.ToArray();
            for (int i = 0; i < a.Length; i++)
            {
                if(b[i]=='.')
                {

                }
                else if (char.IsDigit(a[i]) == false)
                    return false;
            }
            return true;
        }

 
        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<double> lDiem = new List<double>();
            for (int i=0; i<= dtoBangDiem.Dem - 1; i++)
            {
                if (IsNumber(dgvNhapDiem.Rows[i].Cells[2].Value.ToString())==false)
                {
                    MessageBox.Show("Vui lòng nhập số từ 0 đến 10!!!");
                        return;
                }
                else if (dgvNhapDiem.Rows[i].Cells[2].Value.ToString() == "")
                {
                    MessageBox.Show("Vui lòng nhập điểm đầy đủ!!!");
                    return;
                    i--;
                }
                try
                {
                    dtoBangDiem.Diem = float.Parse(dgvNhapDiem.Rows[i].Cells[2].Value.ToString());
                }
                catch
                { }
                if (dtoBangDiem.Diem <0 || dtoBangDiem.Diem >10)
                {
                    MessageBox.Show("Vui lòng nhập điểm từ 0 đến 10 ");
                    return;
                    i--;
                }
                else
                {
                    try
                    {
                        dtoBangDiem.MaHS = int.Parse(dgvNhapDiem.Rows[i].Cells[0].Value.ToString());
                    }
                    catch
                    {  }
                    busNhapDiem.CapNhatDiem(dtoBangDiem);
                    lDiem.Add(i);
                }                       
            }
            MessageBox.Show("Lưu dữ liệu thành công! ");
        }

        //private void dgvNhapDiem_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        int i = dgvNhapDiem.CurrentRow.Index;
        //        string Diem = dgvNhapDiem.Rows[i].Cells[2].Value.ToString();
        //    }
        //}
    }
}
