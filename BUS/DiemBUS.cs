using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class DiemBUS
    {
        public static List<DiemDTO> LayDanhSachDiem()
        {
            return DiemDAO.LayDanhSachDiem();
        }
        public static List<DiemDTO> LayDanhSachLop()
        {
            return DiemDAO.LayDanhSachLop();
        }

        public static List<DiemDTO> LayDanhSachDiemTheoSV(string maSV)
        {
            return DiemDAO.LayDanhSachDiemTheoSV(maSV);
        }

        public static bool KiemtraThemTraSinhVienVaoDSDiem(DiemDTO diemDTO)
        {
            if (DiemDAO.KiemTraThemSinhVienVaoDSDiem(diemDTO) == 0)
                return DiemDAO.ThemSinhVienVaoDSDiem(diemDTO);
            else
                return false;
        }

        public static List<DiemDTO> LayDanhSachDiemSVTheoLop(string malop)
        {
            return DiemDAO.LayDanhSachDiemSVTheoLop(malop);
        }

        public static List<DiemDTO> Timkiemsinhvien(string TenSV, string Nganh, string He)
        {
            return DiemDAO.Timkiemsinhvien(TenSV, Nganh, He);
        }

        public static bool CapNhatDiem(DiemDTO diemDTO)
        {
            return DiemDAO.CapNhatDiem(diemDTO);
        }
    }
}
