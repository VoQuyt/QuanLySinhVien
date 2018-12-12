using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVienDTO
    {
        int _MaGV;
        string _Ho;
        string _Ten;
        bool _GioiTinh;
        DateTime _NgaySinh;
        string _NoiSinh;
        string _SDT;
        string _Email;
        string _HocVi;
        bool _TinhTrang;
        string _Nganh;

        public int MaGV
        {
            get
            {
                return _MaGV;
            }

            set
            {
                _MaGV = value;
            }
        }

        public string Ho
        {
            get
            {
                return _Ho;
            }

            set
            {
                _Ho = value;
            }
        }

        public string Ten
        {
            get
            {
                return _Ten;
            }

            set
            {
                _Ten = value;
            }
        }

        public bool GioiTinh
        {
            get
            {
                return _GioiTinh;
            }

            set
            {
                _GioiTinh = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return _NgaySinh;
            }

            set
            {
                _NgaySinh = value;
            }
        }

        public string NoiSinh
        {
            get
            {
                return _NoiSinh;
            }

            set
            {
                _NoiSinh = value;
            }
        }

        public string SDT
        {
            get
            {
                return _SDT;
            }

            set
            {
                _SDT = value;
            }
        }

        public string HocVi
        {
            get
            {
                return _HocVi;
            }

            set
            {
                _HocVi = value;
            }
        }

        public bool TinhTrang
        {
            get
            {
                return _TinhTrang;
            }

            set
            {
                _TinhTrang = value;
            }
        }

        public string Nganh
        {
            get
            {
                return _Nganh;
            }

            set
            {
                _Nganh = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }
    }
}
