using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        int _ID;
        string _TenTaiKhoan;
        string _MatKhau;
        int _PhanQuyen;
        bool _TrangThai;


        public string TenTaiKhoan
        {
            get
            {
                return _TenTaiKhoan;
            }

            set
            {
                _TenTaiKhoan = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return _MatKhau;
            }

            set
            {
                _MatKhau = value;
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

        public int PhanQuyen
        {
            get
            {
                return _PhanQuyen;
            }

            set
            {
                _PhanQuyen = value;
            }
        }
    }
}
