using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class LopHocBUS
    {
        //lấy danh sách tất cả các lớp
        public static List<LopHocDTO> LayDanhSachTatCaLopHoc()
        {
            return LopHocDAO.LayDanhSachTatCaLopHoc();
        }

        //lấy danh sách lớp đang học
        public static List<LopHocDTO> LayDanhSachLopHocDangHoc()
        {
            return LopHocDAO.LayDanhSachLopHocDangHoc();
        }


        //lấy danh sách lớp chưa khai giảng
        public static List<LopHocDTO> LayDanhSachLopHocChuaKhaiGiang()
        {
            return LopHocDAO.LayDanhSachLopHocChuaKhaiGiang();
        }

        //lấy danh sách lớp đã hoàn thành
        public static List<LopHocDTO> LayDanhSachLopHocDaHocXong()
        {
            return LopHocDAO.LayDanhSachLopHocDaHocXong();
        }

        public static List<LopHocDTO> LayDSlopTheoGiangVien(string maGV)
        {
            return LopHocDAO.LayDSlopTheoGiangVien(maGV);
        }
       

        public static List<LopHocDTO> LayDanhSachLopHocTheoSV(string maSV)
        {
            return LopHocDAO.LayDanhSachLopHocTheoSV(maSV);
        }

        //public static bool KiemTraLopTonTai(LopHocDTO lophocDTO)
        //{
        //    if (LopHocDAO.KiemTraLopTonTai(lophocDTO.MaLop) == 0)
        //        return LopHocDAO.ThemLopHoc(lophocDTO);
        //    else
        //        return false;
        //}

        public static bool MoLop(LopHocDTO lophocDTO)
        {
            return LopHocDAO.ThemLopHoc(lophocDTO);
        }

        public static List<LopHocDTO> TimKiemLopHoc(string maMon)
        {
            return LopHocDAO.TimKiemLopHoc(maMon);
        }

        public static List<LopHocDTO> TimLopTheoMaLop(string maLop)
        {
            return LopHocDAO.TimLopTheoMaLop(maLop);
        }

        public static bool CapNhatLopHoc(LopHocDTO lophocDTO)
        {
                return LopHocDAO.CapNhatLopHoc(lophocDTO);    
        }

        public static bool KiemTraLopTrung(LopHocDTO lophocDTO)
        {
            if (LopHocDAO.KiemTraLopTrung(lophocDTO.NgayBatDau, lophocDTO.MaMon) == 0)
                return LopHocDAO.ThemLopHoc(lophocDTO);
            else
                return false;
        }
    }
}
