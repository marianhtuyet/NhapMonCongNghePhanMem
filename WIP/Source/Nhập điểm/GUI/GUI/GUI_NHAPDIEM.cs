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
            String hk = null;
            if (hocky1.Enabled)
                hk = "1";
            else if (hocky2.Enabled)
                hk = "2";

            dgvNhapDiem.DataSource = bu.getBangDiem(Lop.Text, hk, Mon.Text);
            
        }

        private void Khoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Khoi.Text)
            {
                case "":
                    DialogResult dlr = MessageBox.Show("Vui lòng chọn khối!", "Thông Báo!!", MessageBoxButtons.YesNo);
                    break;
                default:
                    Lop.DataSource = bu.getMaLop(Khoi.Text);
                    Lop.DisplayMember = "MALOP";
                    String hk = null;
                    if (hocky1.Enabled)
                        hk = "1";
                    else if (hocky2.Enabled)
                        hk = "2";
                    dgvNhapDiem.DataSource = bu.getBangDiem(Khoi.Text, hk, Mon.Text);
                    break;
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

        private void hocky2_CheckedChanged(object sender, EventArgs e)
        {
            String hk = null;
            if (hocky1.Enabled)
                hk = "1";
            else if (hocky2.Enabled)
                hk = "2";
            dgvNhapDiem.DataSource = bu.getBangDiem(Khoi.Text, hk, Mon.Text);
        }


        private void label3_Click(object sender, EventArgs e)
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
            String hk = null;
            if (hocky1.Enabled)
                hk = "1";
            else if (hocky2.Enabled)
                hk = "2";
            dgvNhapDiem.DataSource = bu.getBangDiem(Khoi.Text, hk, Mon.Text);
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            Thoat.Enabled = false;
        }

        private void Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            String hk = null;
            if (hocky1.Enabled)
                hk = "1";
            else if (hocky2.Enabled)
                hk = "2";
            dgvNhapDiem.DataSource = bu.getBangDiem(Khoi.Text, hk, Mon.Text);
        }

        private void Mon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
