using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HeDaoTaoDTO
    {
        int _MaHe;
        string _TenHe;
        bool _trangThai;

        public int MaHe
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

        public string TenHe
        {
            get
            {
                return _TenHe;
            }

            set
            {
                _TenHe = value;
            }
        }

        public bool TrangThai
        {
            get
            {
                return _trangThai;
            }

            set
            {
                _trangThai = value;
            }
        }
    }
}
