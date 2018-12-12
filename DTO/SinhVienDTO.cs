using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVienDTO
    {
        int _MaSV;
        string _Ho;
        string _Ten;
        bool _GioiTinh;
        string _NoiSinh;
        DateTime _NgaySinh;
        string _MaNganh;
        string _MaHe;
        string _TinhTrang;
        int _NienKhoa;

        public int MaSV
        {
            get
            {
                return _MaSV;
            }

            set
            {
                _MaSV = value;
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

        public int NienKhoa
        {
            get
            {
                return _NienKhoa;
            }

            set
            {
                _NienKhoa = value;
            }
        }

        public string MaNganh
        {
            get
            {
                return _MaNganh;
            }

            set
            {
                _MaNganh = value;
            }
        }

        public string MaHe
        {
            get
            {
                return _MaHe;
            }

            set
            {
                _MaHe = value;
            }
        }

        public string TinhTrang
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
    }
}
