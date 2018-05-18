using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Configuration;

namespace DAL
{
    public class NHAPDIEM
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=USER;Initial Catalog=TestNhapDiem;Integrated Security=True");
        }

        public DataTable getBangDiemHK1()
        {
            SqlConnection conn = getConnect();
            SqlDataAdapter da = new SqlDataAdapter("select HSHS.MAHS, HOTEN, KTM1, KTM2, KTM3, KTM4, KTM5, KT15P1, KT15P2, KT15P3, KT15P4, KT15P5, KT15P6, KT1T1, KT1T2, KT1T3, KT1T4, KT1T5, KT1T6, DIEMTHI, DIEMTB  from HSHS, BANGDIEM    where HSHS.MAHS = BANGDIEM.MAHS, MAHK = 1", conn);
            DataTable dtBangDiem = new DataTable();
            da.Fill(dtBangDiem);
            return dtBangDiem;
        }

        public DataTable getBangDiemHK2()
        {
            SqlConnection conn = getConnect();
            SqlDataAdapter da = new SqlDataAdapter("select HSHS.MAHS, HOTEN, KTM1, KTM2, KTM3, KTM4, KTM5, KT15P1, KT15P2, KT15P3, KT15P4, KT15P5, KT15P6, KT1T1, KT1T2, KT1T3, KT1T4, KT1T5, KT1T6, DIEMTHI, DIEMTB  from HSHS, BANGDIEM    where HSHS.MAHS = BANGDIEM.MAHS, MAHK = 2", conn);
            DataTable dtBangDiem = new DataTable();
            da.Fill(dtBangDiem);
            return dtBangDiem;
        }
        public DataTable getmalop()
        {
            SqlConnection conn = getConnect();
            SqlDataAdapter da = new SqlDataAdapter("select MALOP from BANGDIEM ", conn);
            DataTable dtBangDiem = new DataTable();
            da.Fill(dtBangDiem);
            return dtBangDiem;

        }
        public void NhapDiemKTM1(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KTM1 = {1}, DIEMTB = {2}", BD.KTM1, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKTM2(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KTM2 = {1}, DIEMTB = {2}", BD.KTM2, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKTM3(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KTM3 = {1}, DIEMTB = {2}", BD.KTM3, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKTM4(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KTM4 = {1}, DIEMTB = {2}", BD.KTM4, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKTM5(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KTM5 = {1}, DIEMTB = {2}", BD.KTM5, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKT15P1(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KT15P1 = {1}, DIEMTB = {2}", BD.KT15P1, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKT15P2(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KT15P2 = {1}, DIEMTB = {2}", BD.KT15P2, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKT15P3(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KT15P3 = {1}, DIEMTB = {2}", BD.KT15P3, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKT15P4(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KT15P4 = {1}, DIEMTB = {2}", BD.KT15P4, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKT15P5(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KT15P5 = {1}, DIEMTB = {2}", BD.KT15P5, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKT15P6(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KT15P6 = {1}, DIEMTB = {2}", BD.KT15P6, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKT1T1(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KT1T1 = {1}, DIEMTB = {2}", BD.KT1T1, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKT1T2(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KT1T2 = {1}, DIEMTB = {2}", BD.KT1T2, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKT1T3(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KT1T3 = {1}, DIEMTB = {2}", BD.KT1T3, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKT1T4(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KT1T4 = {1}, DIEMTB = {2}", BD.KT1T4, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKT1T5(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KT1T5 = {1}, DIEMTB = {2}", BD.KT1T5, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        public void NhapDiemKT1T6(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET KT1T6 = {1}, DIEMTB = {2}", BD.KT1T6, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }


        public void NhapDiemThi(BANGDIEM BD)
        {
            SqlConnection conn = getConnect();
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE BANGDIEM SET DIEMTHI = {1}, DIEMTB = {2}", BD.DIEMTHI, BD.DIEMTB);
                SqlCommand cmd = new SqlCommand(SQL, conn);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
