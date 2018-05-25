using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BangDiem
    {
       
            public int _MAHS;
            public int _MALOP;
            public int _MAHK;
            public int _MAMONHOC;
            public int _MANAMHOC;
            public float _Mieng;
            public float _Diem15P1;
            public float _Diem15P2;
            public float _Diem15P3;
            public float _Diem1T1;
            public float _Diem1T2;
            public float _Diem1T3;
            public float _DIEMTHI;
            public float _DIEMTB;

            public int MAHS
            {
                get
                {
                    return _MAHS;
                }

                set
                {
                    _MAHS = value;
                }
            }

            public int MALOP
            {
                get
                {
                    return _MALOP;
                }

                set
                {
                    _MALOP = value;
                }
            }

            public int MAHK
            {
                get
                {
                    return _MAHK;
                }

                set
                {
                    _MAHK = value;
                }
            }

            public int MAMONHOC
            {
                get
                {
                    return _MAMONHOC;
                }

                set
                {
                    _MAMONHOC = value;
                }
            }

            public int MANAMHOC
            {
                get
                {
                    return _MANAMHOC;
                }

                set
                {
                    _MANAMHOC = value;
                }
            }

            public float KTM1
            {
                get
                {
                    return _Mieng;
                }

                set
                {
                    _Mieng = value;
                }
            }

   
            public float Diem15P1
            {
                get
                {
                    return _Diem15P1;
                }

                set
                {
                    _Diem15P1 = value;
                }
            }

            public float Diem15P2
            {
                get
                {
                    return _Diem15P2;
                }

                set
                {
                    _Diem15P2 = value;
                }
            }

            public float Diem15P3
            {
                get
                {
                    return _Diem15P3;
                }

                set
                {
                    _Diem15P3 = value;
                }
            }
        

            public float Diem1T1
            {
                get
                {
                    return _Diem1T1;
                }

                set
                {
                    _Diem1T1 = value;
                }
            }

            public float Diem1T2
        {
                get
                {
                    return _Diem1T2;
                }

                set
                {
                _Diem1T2 = value;
                }
            }

            public float Diem1T3
        {
                get
                {
                    return _Diem1T3;
                }

                set
                {
                _Diem1T3 = value;
                }
            }
            public float DIEMTB
            {
                get
                {
                    return _DIEMTB;
                }

                set
                {
                    _DIEMTB = value;
                }
            }

            public float DIEMTHI
            {
                get
                {
                    return _DIEMTHI;
                }

                set
                {
                    _DIEMTHI = value;
                }
            }
            public DTO_BangDiem(int mahs, int malop, int mahk, int namhoc, int monhoc, int diemtb, int mieng, int kt15p1, int kt15p2, int kt15p3, int kt1t1, int kt1t2, int kt1t3, int diemthi)
            {
                this.MAHS = mahs;
                this.MALOP = malop;
                this.MAHK = mahk;
                this.MANAMHOC = namhoc;
                this.MAMONHOC = monhoc;
                this.DIEMTB = diemtb;
                this.KTM1 = mieng;
                this.Diem15P1 = kt15p1;
                this.Diem15P2 = kt15p2;
                this.Diem15P3 = kt15p3;
                this.Diem1T1 = kt1t1;
                this.Diem1T2 = kt1t2;
                this.Diem1T3 = kt1t3;
                this.DIEMTHI = diemthi;
            }
        }
    
}
