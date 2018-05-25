using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Configuration;
using System.Windows.Forms;

namespace DAL
{
  public  class DAL_NhapDiem: DAL_DBConnect
    {
        public SqlCommandBuilder sqlComd;

       


        public DataTable getBangDiem(int manh,  int MaHocKy, int MaLop, int mamh, string cotdiem)
        {
            DataTable dt = new DataTable();
            try
            {
                
                string sql = "select HOCSINH.mahs, HOCSINH.HOTEN, BANGDIEM."+ cotdiem +"   from BANGDIEM , HOCSINH   where HOCSINH.MAHS = BANGDIEM.MAHS and MALOP = " + MaLop + " and MAHK = " + MaHocKy + " and MAMH= " + mamh ;
                MessageBox.Show(sql);
                SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
                
                da.Fill(dt);
              
                //_conn.Open();
                //SqlCommand cmd = new SqlCommand(sql, _conn);
                ////cmd.CommandType = CommandType.Text;
                //cmd.ExecuteNonQuery();
                //_conn.Close();
                //da.Fill(dtBangDiem);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lấy cơ sở dữ liệu mã lớp");
            }
            return dt;

        }


        //public void CapNhatDiem()
        //{
        //    try
        //    {
        //        _conn.Open();
        //        sqlComd = new SqlCommandBuilder(da);
        //        da.Update(dtBangDiem);
        //    }
        //    catch (Exception ex)
        //    {

        //    }


        }

    }

