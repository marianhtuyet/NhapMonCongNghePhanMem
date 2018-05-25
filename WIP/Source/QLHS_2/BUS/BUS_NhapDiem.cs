using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace BUS
{
   public class BUS_NhapDiem
    {
       DAL_NhapDiem da = new DAL_NhapDiem();
        public DataTable getBangDiem(int manh,  int MaHocKy, int MaLop, int Mon, string CotDiem)
        {
            return da.getBangDiem(manh, MaHocKy, MaLop, Mon, CotDiem);
        }

       
        public void CapNhatDiem()
        {
            CapNhatDiem();
        }
    
    }
}
