using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiemDTO
    {
        string _MaLop;
        string _TenSV;
        string _MaSV;
        double _DiemChuyenCan;
        double _DiemTBKT;
        double _DiemThi;
        double _DiemTong;

        public double DiemChuyenCan
        {
            get
            {
                return _DiemChuyenCan;
            }

            set
            {
                _DiemChuyenCan = value;
            }
        }

        public double DiemTBKT
        {
            get
            {
                return _DiemTBKT;
            }

            set
            {
                _DiemTBKT = value;
            }
        }

        public double DiemThi
        {
            get
            {
                return _DiemThi;
            }

            set
            {
                _DiemThi = value;
            }
        }

        public double DiemTong
        {
            get
            {
                return _DiemTong;
            }

            set
            {
                _DiemTong = value;
            }
        }

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
