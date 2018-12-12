using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        public static List<TaiKhoanDTO> LayDanhSachTaiKhoan()
        {
            return TaiKhoanDAO.LayDanhSachTaiKhoan();
        }

        public static bool KiemTraTaiKhoanTonTai(TaiKhoanDTO tenTK)
        {
            if (TaiKhoanDAO.KiemTraTaiKhoanTonTai(tenTK.TenTaiKhoan) == 0)
                return TaiKhoanDAO.ThemTaiKhoan(tenTK);
            else
                return false;
        }

        public static bool KiemTraTrungTenTaiKhoan(string tenTK)
        {
            if (TaiKhoanDAO.KiemTraTaiKhoanTonTai(tenTK) == 1)
                return false;
            else
                return true;
        }

        public static bool KiemTraDangNhap(string taikhoan, string matkhau)
        {
            if (TaiKhoanDAO.KiemTraDangNhap(taikhoan, matkhau) == 1)
                return true;
            else
                return false;
        }

        public static bool CapNhatTaiKhoan(TaiKhoanDTO tenTK)
        {
            return TaiKhoanDAO.CapNhatTaiKhoan(tenTK);
        }

        public static bool XoaTaiKhoan(int ID)
        {
            return TaiKhoanDAO.XoaTaiKhoan(ID);
        }

        public static int CheckQuyenHan(string taiKhoan)
        {
            return TaiKhoanDAO.CheckQuyenTruyCap(taiKhoan);
        }
    }
}
