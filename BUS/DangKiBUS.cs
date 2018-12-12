using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class DangKiBUS
    {
        public static List<DangKyDTO> LayDanhSachDangKi()
        {
            return DangKiDAO.LayDanhSachDangKi();
        }

        public static List<DangKyDTO> Timkiemsinhvien(string TenSV, string Nganh, string He)
        {
            return DangKiDAO.Timkiemsinhvien(TenSV, Nganh, He);
        }

        public static List<DangKyDTO> LayDanhSachSVDangKiTheoLop(string maLop)
        {
            return DangKiDAO.LayDanhSachSVDangKiTheoLop(maLop);
        }

        public static bool KiemTraSinhVienDangKi(DangKyDTO dangkiDTO)
        {
            if (DangKiDAO.KiemTraSinhVienDangKi(dangkiDTO) == 0)
                return DangKiDAO.ThemSinhVienDangKi(dangkiDTO);
            else
                return false;
        }

        public static bool CapNhatThongTinDangKi(DangKyDTO dangkiDTO)
        {
            return DangKiDAO.CapNhatThongTinDangKi(dangkiDTO);
        }

        public static bool Xoa(string malop, string masv)
        {
             return DangKiDAO.Xoa(malop, masv);
        }

        public static bool KiemTraSinhVienDongTien(DangKyDTO dangkiDTO)
        {
            if (DangKiDAO.KiemTraSinhVienDongTien(dangkiDTO))
                return true;
            else
                return false;
        }

    }
}
