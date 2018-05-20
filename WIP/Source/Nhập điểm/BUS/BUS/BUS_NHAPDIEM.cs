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
    public class BUS_NHAPDIEM
    {
        NHAPDIEM da = new NHAPDIEM();
        public void TinhDiemTB(BANGDIEM BD)
        {
            int dem = 0;
            float tong = 0;
            if (BD.KTM1 != null)
            {
                dem += 1;
                tong += BD._KTM1;
                if (BD.KTM2 != null)
                {
                    dem += 1;
                    tong += BD._KTM2;
                    if (BD.KTM3 != null)
                    {
                        dem += 1;
                        tong += BD._KTM3;
                        if (BD.KTM4 != null)
                        {
                            dem += 1;
                            tong += BD._KTM4;
                            if (BD.KTM5 != null)
                            {
                                dem += 1;
                                tong += BD._KTM5;
                            }
                        }
                    }
                }
            }

            float MTB;
            MTB = tong / dem;
            tong = MTB;
            if (tong != 0)
                dem = 1;
            if (BD.KT15P1 != null)
            {
                dem += 1;
                tong += BD._KT15P1;
            }
            if (BD.KT15P2 != null)
            {
                dem += 1;
                tong += BD._KT15P2;
            }
            if (BD.KT15P3 != null)
            {
                dem += 1;
                tong += BD._KT15P3;
            }
            if (BD.KT15P4 != null)
            {
                dem += 1;
                tong += BD._KT15P4;
            }
            if (BD.KT15P5 != null)
            {
                dem += 1;
                tong += BD._KT15P5;
            }
            if (BD.KT15P6 != null)
            {
                dem += 1;
                tong += BD._KT15P6;
            }
            if (BD.KT1T1 != null)
            {
                dem += 2;
                tong += BD._KT1T1*2;
            }
            if (BD.KT1T2 != null)
            {
                dem += 2;
                tong += BD._KT1T2*2;
            }
            if (BD.KT1T3 != null)
            {
                dem += 2;
                tong += BD._KT1T3*2;
            }
            if (BD.KT1T4 != null)
            {
                dem += 2;
                tong += BD._KT1T4*2;
            }
            if (BD.KT1T5 != null)
            {
                dem += 2;
                tong += BD._KT1T5*2;
            }
            if (BD.KT1T6 != null)
            {
                dem += 2;
                tong += BD._KT1T6*2;
            }
            if (BD.DIEMTHI != null)
            {
                dem += 2;
                tong += BD._DIEMTHI*3;
            }
            BD._DIEMTB = tong / dem;
        }
        public DataTable getBangDiem(String MaLop, String MaHocKy, String Mon)
        {
            return da.getBangDiem(MaLop, MaHocKy, Mon);
        }

        public DataTable getMaLop(String maKhoi)
        {
            return da.getMaLop(maKhoi);

        }
    }
}
