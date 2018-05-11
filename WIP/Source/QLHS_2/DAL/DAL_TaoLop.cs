using System;
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
            SqlDataAdapter da = new SqlDataAdapter("select HOCSINH.mahs, HOCSINH.hoten hs from hocsinh where mahs not in ( select mahs from chitietlop)", _conn);
            DataTable dtDanhSachLop = new DataTable();
            da.Fill(dtDanhSachLop);
            return dtDanhSachLop;
        }
        public DataTable getDanhSachLopCoSan(string NamHoc, string Lop)
        {
                SqlDataAdapter da = new SqlDataAdapter("select mahs, hoten from hocsinh where mahs  in  (select mahs from chitietlop)", _conn);
                DataTable dtDanhSachLopCoSan = new DataTable();
                da.Fill(dtDanhSachLopCoSan);
            return dtDanhSachLopCoSan;
        }
        public DataTable LopHoc()
        {
            SqlDataAdapter dr = new SqlDataAdapter("select malop, tenlop from Lophoc", _conn);
            DataTable dtLopHoc = new DataTable();
            dr.Fill(dtLopHoc);
            return dtLopHoc;
            

        }
    }
}
