using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DFD
{
    public partial class HoSoHocSinh : Form
    {
        public HoSoHocSinh()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthScreen;
            this.Height = heightScreen;
        }
        public bool IsNumber(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsDigit(a[i]) == false)
                    return false;
            }
            return true;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void picXoa_Click(object sender, EventArgs e)
        {

        }

        private void TxtMaHocSinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuuVaoDanhSach_Click(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            int dtp = dtpNgaySinh.Value.Year;
            if (IsNumber(txtMaHocSinh.Text) == false || (txtMaHocSinh.Text.Length != 4))
                MessageBox.Show("Mã học sinh phải là 4 con số!!");
            else if (txtHoTenHocSinh.Text.Length < 5)
                MessageBox.Show("Họ và tên phải dài hơn 4 kí tự!!", "Thông báo");
            else if ((year - dtp) < 14 || (year - dtp) > 20)
                MessageBox.Show("Tuổi phải từ 15 -> 19 tuổi!!", "Thông báo");
            else if (cboGioiTinh.Text.Length == 0)
                MessageBox.Show("Vui lòng chọn giới tính!!", "Thông báo");
            else if (txtDiaChi.Text.Length < 10)
                MessageBox.Show("Địa Chỉ phải dài hơn 10 kí tự!!");
            else if (cboDanToc.Text.Length == 0)
                MessageBox.Show("Vui lòng chọn dân tộc!!", "Thông báo");
            else if (cboTonGiao.Text.Length == 0)
                MessageBox.Show("Vui lòng chọn tôn giáo!!", "Thông báo");
            else if (txtDiaChi.Text.Length < 8)
                MessageBox.Show("Địa chỉ phải dài hơn 7 kí tự!!!");
            else if (txtHoTenCha.Text.Length < 5)
                MessageBox.Show("Họ tên cha phải lớn hơn 4 kí tự!!");
            else if (txtNgheNghiepCha.Text.Length < 5)
                MessageBox.Show("Nghề nghiệp cha phải lớn hơn 4 kí tự!!");
            else if (txtHoTenMe.Text.Length < 5)
                MessageBox.Show("Họ tên mẹ phải lớn hơn 4 kí tự!!");
            else if (txtNgheNghiepMe.Text.Length < 5)
                MessageBox.Show("Nghề nghiệp mẹ phải lớn hơn 4 kí tự!!");
            else if (cboNamHoc.Text.Length == 0)
                MessageBox.Show("Vui lòng chọn năm học");
            else MessageBox.Show("Thêm thành công!", "Thông báo");
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnXoaNamHoc_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.Text.Length == 0)
                MessageBox.Show("Vui lòng chọn năm học muốn xóa!!");
            else
            {
                cboNamHoc.Items.RemoveAt(cboNamHoc.SelectedIndex);
                MessageBox.Show("Xóa thành công!!");
            }
        }

        private void btnThemNamHoc_Click(object sender, EventArgs e)
        {
            if (IsNumber(txtThemNamHoc.Text) == false || (txtThemNamHoc.Text.Length != 4))
                MessageBox.Show("Năm học muốn thêm phải là 4 con số!!");
            else if (txtThemNamHoc.Text.Length != 0)
            { 
                cboNamHoc.Items.Add(txtThemNamHoc.Text);
                MessageBox.Show("Thêm thành công!!");
            }
        }
    }
}
