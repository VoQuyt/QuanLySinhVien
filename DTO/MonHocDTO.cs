using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonHocDTO
    {
        int _MaMonHoc;
        string _TenMonHoc;
        int _SoTinChi;
        bool _TrangThai;
        string _MaNganh;
        string _MaHe;

        public int MaMonHoc
        {
            get
            {
                return _MaMonHoc;
            }

            set
            {
                _MaMonHoc = value;
            }
        }

        public string TenMonHoc
        {
            get
            {
                return _TenMonHoc;
            }

            set
            {
                _TenMonHoc = value;
            }
        }

        public int SoTinChi
        {
            get
            {
                return _SoTinChi;
            }

            set
            {
                _SoTinChi = value;
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
    }
}
