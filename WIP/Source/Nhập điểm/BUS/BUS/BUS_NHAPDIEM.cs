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
        public DataTable getBangDiemHK1()
        {
            return da.getBangDiemHK1();
        }
        public DataTable getBangDiemHK2()
        {
            return da.getBangDiemHK2();
        }
        public DataTable getMaLop10()
        {
            return da.getMaLop10();
        }
        public DataTable getMaLop11()
        {
            return da.getMaLop11();
        }
        public DataTable getMaLop12()
        {
            return da.getMaLop12();
        }
        public void NhapDiemKTM1(BANGDIEM BD)
        {
            da.NhapDiemKTM1(BD);
        }

        public void NhapDiemKTM2(BANGDIEM BD)
        {
            da.NhapDiemKTM2(BD);
        }

        public void NhapDiemKTM3(BANGDIEM BD)
        {
            da.NhapDiemKTM3(BD);
        }

        public void NhapDiemKTM4(BANGDIEM BD)
        {
            da.NhapDiemKTM4(BD);   
        }

        public void NhapDiemKTM5(BANGDIEM BD)
        {
            da.NhapDiemKTM5(BD);
        }

        public void NhapDiemKT15P1(BANGDIEM BD)
        {
            da.NhapDiemKT15P1(BD);
        }

        public void NhapDiemKT15P2(BANGDIEM BD)
        {
            da.NhapDiemKT15P2(BD);
        }

        public void NhapDiemKT15P3(BANGDIEM BD)
        {
            da.NhapDiemKT15P3(BD);
        }

        public void NhapDiemKT15P4(BANGDIEM BD)
        {
            da.NhapDiemKT15P4(BD);
        }

        public void NhapDiemKT15P5(BANGDIEM BD)
        {
            da.NhapDiemKT15P5(BD);
        }

        public void NhapDiemKT15P6(BANGDIEM BD)
        {
            da.NhapDiemKT15P6(BD);
        }

        public void NhapDiemKT1T1(BANGDIEM BD)
        {
            da.NhapDiemKT1T1(BD);
        }

        public void NhapDiemKT1T2(BANGDIEM BD)
        {
            da.NhapDiemKT1T2(BD);
        }

        public void NhapDiemKT1T3(BANGDIEM BD)
        {
            da.NhapDiemKT1T3(BD);
        }

        public void NhapDiemKT1T4(BANGDIEM BD)
        {
            da.NhapDiemKT1T4(BD);
        }

        public void NhapDiemKT1T5(BANGDIEM BD)
        {
            da.NhapDiemKT1T5(BD);
        }

        public void NhapDiemKT1T6(BANGDIEM BD)
        {
            da.NhapDiemKT1T6(BD);
        }


        public void NhapDiemThi(BANGDIEM BD)
        {
            da.NhapDiemThi(BD);
        }
    }
}
