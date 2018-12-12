using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class MonHocBUS
    {
        public static List<MonHocDTO> LayDanhSachTatCaMonHoc()
        {
            return MonHocDAO.LayDanhSachTatCaMonHoc();
        }

        public static List<MonHocDTO> LayDanhSachTatCaMonHocConApDung()
        {
            return MonHocDAO.LayDanhSachTatCaMonHocConApDung();
        }

        //public static bool KiemTraMonHocTonTai(MonHocDTO monhocDTO)
        //{
        //    if (MonHocDAO.KiemTraMonHocTonTai(monhocDTO.MaMonHoc) == 0)
        //    {
        //        if (NganhDAO.KiemTraNganhConHieuLuc(monhocDTO.MaNganh) == 0 && HeDaoTaoDAO.KiemTraHeConHieuLuc(monhocDTO.MaHe) == 0)
        //            return MonHocDAO.ThemMonHoc(monhocDTO);
        //        else
        //            return false;
        //    }
        //    else
        //        return false;
        //}

        //public static bool CapNhatMonHoc(MonHocDTO monhocDTO)
        //{
        //    if (NganhDAO.KiemTraNganhConHieuLuc(monhocDTO.MaNganh) == 0 && HeDaoTaoDAO.KiemTraHeConHieuLuc(monhocDTO.MaHe) == 0)
        //        return MonHocDAO.CapNhatMonHoc(monhocDTO);
        //    else
        //        return false;
        //}

        public static List<MonHocDTO> LayDSMonHocTheoNganh(int maNganh)
        {
            return MonHocDAO.LayDSMonHocTheoNganh(maNganh);
        }

        public static bool ThemMonHoc(MonHocDTO monhocDTO)
        {
            return MonHocDAO.ThemMonHoc(monhocDTO);
        }

        public static bool CapNhatMonHoc(MonHocDTO monhocDTO)
        {
            return MonHocDAO.CapNhatMonHoc(monhocDTO);
        }

        public static bool XoaMonHoc(string maMon)
        {
            return MonHocDAO.XoaMonHoc(maMon);
        }

        public static List<MonHocDTO> TimKiemMonHoc(string tenmon, string nganh, string he)
        {
            return MonHocDAO.TimKiemMonHoc(tenmon, nganh, he);
        }

    }
}
