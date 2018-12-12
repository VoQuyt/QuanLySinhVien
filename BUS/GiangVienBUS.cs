using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class GiangVienBUS
    {
        public static List<GiangVienDTO> LayDanhSachGiangVien()
        {
            return GiangVienDAO.LayDanhSachGiangVien();
        }

        public static List<GiangVienDTO> LayDSGiangVienTheoNganh(int maNganh)
        {
            return GiangVienDAO.LayDSGiangVienTheoNganh(maNganh);
        }


        public static bool ThemGiangVien(GiangVienDTO giangvienDTO)
        {
            return GiangVienDAO.ThemGiangVien(giangvienDTO);
        }

        public static bool UpdateGiangVien(GiangVienDTO giangvienDTO)
        {
            return GiangVienDAO.UpdateGiangVien(giangvienDTO);
        }

    }
}
