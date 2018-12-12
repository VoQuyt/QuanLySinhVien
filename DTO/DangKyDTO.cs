using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangKyDTO
    {
        string _MaLop;
        string _TenSV;
        string _MaSV;
        DateTime _NgayDangKi;
        bool _TrangThai;

        public string MaLop
        {
            get
            {
                return _MaLop;
            }

            set
            {
                _MaLop = value;
            }
        }

        public string MaSV
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

        public DateTime NgayDangKi
        {
            get
            {
                return _NgayDangKi;
            }

            set
            {
                _NgayDangKi = value;
            }
        }

        public bool TrangThai
        {
            get
            {
                return _TrangThai;
            }

            set
            {
                _TrangThai = value;
            }
        }

        public string TenSV
        {
            get
            {
                return _TenSV;
            }

            set
            {
                _TenSV = value;
            }
        }
    }
}
