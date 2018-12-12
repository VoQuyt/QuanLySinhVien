using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHocDTO
    {
        int _maLop;
        string _tenLop;
        string _maMon;
        DateTime _ngayBatDau;
        DateTime _ngayKetThuc;
        int _siSo;
        string _MaGV;

        public int MaLop
        {
            get
            {
                return _maLop;
            }

            set
            {
                _maLop = value;
            }
        }

        public string TenLop
        {
            get
            {
                return _tenLop;
            }

            set
            {
                _tenLop = value;
            }
        }

        public DateTime NgayBatDau
        {
            get
            {
                return _ngayBatDau;
            }

            set
            {
                _ngayBatDau = value;
            }
        }

        public DateTime NgayKetThuc
        {
            get
            {
                return _ngayKetThuc;
            }

            set
            {
                _ngayKetThuc = value;
            }
        }

        public int SiSo
        {
            get
            {
                return _siSo;
            }

            set
            {
                _siSo = value;
            }
        }

        public string MaMon
        {
            get
            {
                return _maMon;
            }

            set
            {
                _maMon = value;
            }
        }

        public string MaGV
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
    }
}
