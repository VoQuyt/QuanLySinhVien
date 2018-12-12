using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TinhTrangDTO
    {
        int _ID;
        string _TinhTrang;

        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
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
