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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = widthScreen;
            this.Height = heightScreen;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            
        }
        public bool IsNumber(string a)
        {
            for(int i=0; i<a.Length; i++)
            {
                if (char.IsDigit(a[i]) == false)
                    return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year; 
            int dtp = dtpNTNS.Value.Year;
            if (IsNumber(txtMaHS.Text) == false || (txtMaHS.Text.Length != 4))
                MessageBox.Show("Mã học sinh phải là 4 con số!!");
            else if (txtHoTen.Text.Length < 5)
                MessageBox.Show("Họ và tên phải dài hơn 4 kí tự!!", "Thông báo");
            else if (cbxGioiTinh.Text.Length == 0)
                MessageBox.Show("Vui lòng chọn giới tính!!", "Thông báo");
            else if ((year - dtp) < 14 || (year - dtp) > 20)
                MessageBox.Show("Tuổi phải từ 15 -> 19 tuổi!!", "Thông báo");
            else if (cboDanToc.Text.Length == 0)
                MessageBox.Show("Vui lòng chọn dân tộc!!", "Thông báo");
            else if (cboDanToc.Text.Length == 0)
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
            else if (IsNumber(txtNamHoc.Text) == false || (txtNamHoc.Text.Length != 4))
                MessageBox.Show("Năm học muốn thêm phải là 4 con số!!");
            else MessageBox.Show("Thêm thành công!", "Thông báo");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?" ,"Thông Báo", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNamHoc.Text.Length != 0)
                cboNamHoc.Items.Add(txtNamHoc.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.Text.Length != 0)
            cboNamHoc.Items.RemoveAt(cboNamHoc.SelectedIndex);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbxDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNgheNghiepMe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNamHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dtpNTNS_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboXuatNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
