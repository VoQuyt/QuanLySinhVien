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
    public static class HeDaoTaoBUS
    {
        public static List<HeDaoTaoDTO> LayDanhSachTatCaHe()
        {
            return HeDaoTaoDAO.LayDanhSachTatCaHe();
        }

        public static List<HeDaoTaoDTO> LayDanhSachHe()
        {
            return HeDaoTaoDAO.LayDanhSachHe();
        }

        //public static bool KiemTraHeDaTonTai(HeDaoTaoDTO hedaotaoDTO)
        //{
        //    if (HeDaoTaoDAO.KiemTraHeDaTonTai(hedaotaoDTO.MaHe) == 0)
        //    {
        //        return HeDaoTaoDAO.ThemHeDaoTao(hedaotaoDTO);
        //    }
        //    else
        //        return false;
        //}

        public static bool ThemHeDaoTao(HeDaoTaoDTO hedaotaoDTO)
        {
            return HeDaoTaoDAO.ThemHeDaoTao(hedaotaoDTO);
        }

        public static bool CapNhatHeDaoTao(HeDaoTaoDTO hedaotaoDTO)
        {
            return HeDaoTaoDAO.CapNhatHeDaoTao(hedaotaoDTO);
        }

        public static bool XoaHeDaoTao(int maHe)
        {
            return HeDaoTaoDAO.XoaHeDaoTao(maHe);
        }
    }
}
