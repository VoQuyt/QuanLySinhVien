using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NganhDTO
    {
        int _MaNganh;
        string _TenNganh;
        bool _trangThai;

        public int MaNganh
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

        public string TenNganh
        {
            get
            {
                return _TenNganh;
            }

            set
            {
                _TenNganh = value;
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
