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
using System.Data.SqlClient;

namespace GUI
{
    public partial class GUI_NHAPDIEM : Form
    {
        BUS_NHAPDIEM bu = new BUS_NHAPDIEM();
        public GUI_NHAPDIEM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataRow row in bu.getBangDiemHK1().Rows)
            {
                lvBangDiem.Items.Add(row["MAHS"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["HOTEN"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KTM1"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KTM2"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KTM3"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KTM4"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KTM5"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KT15P1"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KT15P2"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KT15P3"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KT15P4"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KT15P5"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KT15P6"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KT1T1"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KT1T2"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KT1T3"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KT1T4"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KT1T5"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["KT1T6"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["DIEMTHI"].ToString());
                lvBangDiem.Items[i].SubItems.Add(row["DIEMTB"].ToString());
                i++;
            }

            foreach (ListViewItem items in lvBangDiem.SelectedItems)
            {
                MaHS.Text = items.SubItems[1].Text;
                HoTen.Text = items.SubItems[2].Text;
            }

            if (Khoi.Text == "10")
            {
                Lop.DataSource = bu.getMaLop10();
                Lop.DisplayMember = "MALOP";
            }

            if (Khoi.Text == "11")
            {
                Lop.DataSource = bu.getMaLop11();
                Lop.DisplayMember = "MALOP";
            }

            if (Khoi.Text == "12")
            {
                Lop.DataSource = bu.getMaLop12();
                Lop.DisplayMember = "MALOP";
            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Sodiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thật sự muốn thoát hay không?", "Thông Báo!!", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hocky1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TiepTheo_Click(object sender, EventArgs e)
        {
            QuayLai.Enabled = false;
            Thoat.Enabled = false;
            lblThongBao.Visible = true;
            if (Khoi.Text == "")
            {
                lblThongBao.Text = "Vui lòng chọn khối!";
                lblThongBao.Visible = true;
            }
            else if (Lop.Text == "")
            {
                lblThongBao.Text = "Vui lòng chọn lớp!";
                lblThongBao.Visible = true;
            }
            else if (Mon.Text == "")
            {
                lblThongBao.Text = "Vui lòng chọn môn!";
                lblThongBao.Visible = true;
            }
            else if (hocky1.Enabled == false && hocky2.Enabled == false)
            {
                lblThongBao.Text = "Vui lòng chọn học kỳ!";
            }
            else if (LoaiDiem.Text == "")
            {
                lblThongBao.Text = "Vui lòng chọn loại điểm!";
                lblThongBao.Visible = true;
            }
            else if (IsNumber(Sodiem.Text) == false || Sodiem.Text.Length > 1)
            {
                if (Sodiem.Text != "10")
                {
                    lblThongBao.Text = "Điểm phải là 1 số từ 0 đến 10";
                    lblThongBao.Visible = true;
                }
            }
            


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Khoi.Text == "")
            {
                lblThongBao.Text = "Vui lòng chọn khối!";
                lblThongBao.Visible = true;
            }
        }
    }
}
