using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public static class NganhBUS
    {
        public static List<NganhDTO> LayDanhSachNganh()
        {
            return NganhDAO.LayDanhSachNganh();
        }

        public static List<NganhDTO> LayDanhSachTatCaNganh()
        {
            return NganhDAO.LayDanhSachTatCaNganh();
        }

        //public static bool KiemTraNganhTonTai(NganhDTO nganhDTO)
        //{
        //    if (NganhDAO.KiemTraNganhTonTai(nganhDTO.MaNganh) == 0)
        //        return NganhDAO.ThemNganh(nganhDTO);
        //    else
        //        return false;
        //}

        public static bool ThemNganh(NganhDTO nganhDTO)
        {
            return NganhDAO.ThemNganh(nganhDTO);
        }

        public static bool CapNhatNganh(NganhDTO nganhDTO)
        {
            return NganhDAO.CapNhatNganh(nganhDTO);
        }

        public static bool XoaNganh(int maNganh)
        {
            return NganhDAO.XoaNganh(maNganh);
        }
    }
}
