using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class SinhVienBUS
    {
        public static List<TinhTrangDTO> GetListTinhTrang()
        {
            return SinhVienDAO.GetListTinhTrang();
        }

        public static List<SinhVienDTO> LayDanhSachSinhVien()
        {
            return SinhVienDAO.LayDanhSachSinhVien();
        }

        public static List<SinhVienDTO> GetListSinhVien()
        {
            return SinhVienDAO.GetListSinhVien();
        }

        //public static bool KiemTraSinhVienTonTai(SinhVienDTO sinhvienDTO)
        //{
        //    if (SinhVienDAO.KiemTraSinhVienTonTai(sinhvienDTO.MaSV) == 0)
        //    {
        //        if (NganhDAO.KiemTraNganhConHieuLuc(sinhvienDTO.MaNganh) == 0 && HeDaoTaoDAO.KiemTraHeConHieuLuc(sinhvienDTO.MaHe) == 0)
        //            return SinhVienDAO.ThemSinhVien(sinhvienDTO);
        //        else
        //            return false;
        //    }
        //    else
        //        return false;
        //}

        public static bool ThemSinhVien(SinhVienDTO sinhvienDTO)
        {
            return SinhVienDAO.ThemSinhVien(sinhvienDTO);
        }

        public static bool CapNhatSinhVien(SinhVienDTO sinhvienDTO)
        {
            return SinhVienDAO.UpdateStudent(sinhvienDTO);
        }

        public static bool XoaSinhVien(string maSV)
        {
            return SinhVienDAO.DeleteStudent(maSV);
        }


        public static bool KiemTraSinhVienTonTai(string maSV)
        {
            if (SinhVienDAO.KiemTraSinhVienTonTai(maSV) == 1)
                return true;
            else
                return false;
        }

        public static List<SinhVienDTO> TimKiemSinhVien(string ho, string ten, string noisinh, string nganh, string he, string tinhtrang)
        {
            return SinhVienDAO.Timkiemsinhvien(ho, ten, noisinh, nganh, he, tinhtrang);
        }

        public static SinhVienDTO LayThongTinSinhVien(string maSV)
        {
            return SinhVienDAO.LayThongTinSinhVien(maSV);
        }
    }
}
