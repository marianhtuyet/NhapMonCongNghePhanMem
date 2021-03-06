﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_TaoLop : DAL_DBConnect
    {
        /// <summary>
        /// get toan bo hoc sinh chua co lop
        /// </summary>
        /// <returns>danh sach hoc sinh</returns>

        public DataTable getDanhSachLop()
        {
          //  _conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select HOCSINH.mahs, HOCSINH.hoten  from hocsinh where mahs not in ( select mahs from chitietlop)", _conn);
            DataTable dtDanhSachLop = new DataTable();
            da.Fill(dtDanhSachLop);
            //_conn.Close();
            return dtDanhSachLop;
           
        }
        public DataTable getDanhSachLopCoSan(int NamHoc, int Lop)
        {
            //_conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select mahs, hoten from hocsinh where mahs  in  (select mahs from chitietlop where malop = " + Lop + "and manh = " + NamHoc+ ")", _conn);
                DataTable dtDanhSachLopCoSan = new DataTable();
                da.Fill(dtDanhSachLopCoSan);
            //_conn.Close();
            return dtDanhSachLopCoSan;
        }
        public DataTable LopHoc()
        {
          //_conn.Open();
            SqlDataAdapter dr = new SqlDataAdapter("select malop, tenlop from Lophoc", _conn);
            DataTable dtLopHoc = new DataTable();
            dr.Fill(dtLopHoc);
            //_conn.Close();
            return dtLopHoc;
        }
        public void ChuyenLop(int mahs, int malop, int manh)
        {
            try
            {
                string sql = "insert into chitietlop values (" + mahs + ", " + malop + ", " + manh + ")";
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Chuyển lớp không thành công");
            }


        }


    }
}
