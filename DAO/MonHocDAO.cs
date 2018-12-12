using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class MonHocDAO
    {
        public static List<MonHocDTO> ReadData(SqlCommand command)
        {
            List<MonHocDTO> result = new List<MonHocDTO>();
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    MonHocDTO sv = new MonHocDTO();
                    sv.MaMonHoc = reader.GetInt32(0);
                    sv.TenMonHoc = reader.GetString(1);
                    sv.SoTinChi = reader.GetInt32(2);
                    sv.MaNganh = reader.GetString(3);
                    sv.MaHe = reader.GetString(4);
                    sv.TrangThai = reader.GetBoolean(5);
                    result.Add(sv);
                }
            }
            command.Connection.Close();
            return result;
        }

        public static List<MonHocDTO> LayDanhSachTatCaMonHoc()
        {
            List<MonHocDTO> result = new List<MonHocDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string query = "SELECT tblMonHoc.MaMonHoc, tblMonHoc.TenMonHoc, tblMonHoc.SoTinChi, tblNganh.TenNganh, tblHeDaoTao.TenHe, tblMonHoc.TrangThai FROM tblMonHoc, tblNganh, tblHeDaoTao Where tblMonHoc.MaNganh = tblNganh.MaNganh and tblMonHoc.MaHe = tblHeDaoTao.MaHe";
            SqlCommand command = new SqlCommand(query, connection);
            result = ReadData(command);
            return result;
        }

        public static List<MonHocDTO> LayDSMonHocTheoNganh(int maNganh)
        {
            List<MonHocDTO> result = new List<MonHocDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string query = "SELECT tblMonHoc.MaMonHoc, tblMonHoc.TenMonHoc, tblMonHoc.SoTinChi, tblNganh.TenNganh, tblHeDaoTao.TenHe, tblMonHoc.TrangThai FROM tblMonHoc, tblNganh, tblHeDaoTao Where tblMonHoc.MaNganh = tblNganh.MaNganh and tblMonHoc.MaHe = tblHeDaoTao.MaHe and tblMonHoc.MaNganh = @MaNganh";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@MaNganh", System.Data.SqlDbType.Int, 0, "MaNganh").Value = maNganh;
            result = ReadData(command);
            return result;
        }

        public static List<MonHocDTO> LayDanhSachTatCaMonHocConApDung()
        {
            List<MonHocDTO> result = new List<MonHocDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string query = "SELECT tblMonHoc.MaMonHoc, tblMonHoc.TenMonHoc, tblMonHoc.SoTinChi, tblNganh.TenNganh, tblHeDaoTao.TenHe, tblMonHoc.TrangThai FROM tblMonHoc, tblNganh, tblHeDaoTao Where tblMonHoc.MaNganh = tblNganh.MaNganh and tblMonHoc.MaHe = tblHeDaoTao.MaHe and tblMonHoc.TrangThai = 1";
            SqlCommand command = new SqlCommand(query, connection);
            result = ReadData(command);
            return result;
        }

        public static bool ThemMonHoc(MonHocDTO monhocDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "INSERT INTO tblMonHoc(TenMonHoc, SoTinChi, MaNganh, MaHe, TrangThai) VALUES(@tenMonHoc, @soTinChi,@MaNganh, @MaHe, @trangThai)";
            SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.Add("@maMonHoc", System.Data.SqlDbType.Int, 0, "MaMonHoc").Value = monhocDTO.MaMonHoc;
            command.Parameters.Add("@tenMonHoc", System.Data.SqlDbType.NVarChar, 255, "TenMonHoc").Value = monhocDTO.TenMonHoc;
            command.Parameters.Add("@soTinChi", System.Data.SqlDbType.Int, 0, "SoTinChi").Value = Convert.ToInt32(monhocDTO.SoTinChi);
            command.Parameters.Add("@MaNganh", System.Data.SqlDbType.Int, 0, "MaNganh").Value = monhocDTO.MaNganh;
            command.Parameters.Add("@MaHe", System.Data.SqlDbType.Int, 0, "MaHe").Value = monhocDTO.MaHe;
            command.Parameters.Add("@trangThai", System.Data.SqlDbType.Bit, 2, "TrangThai").Value = monhocDTO.TrangThai;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }
        public static int KiemTraMonHocTonTai(string maMon)
        {
            SqlConnection connection = DataProvider.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT CAST((select count(*) from tblMonHoc where MaMonHoc=@maMonHoc) AS int)", connection);
            command.Parameters.Add("@maMonHoc", System.Data.SqlDbType.NVarChar, 255, "MaMonHoc").Value = maMon;
            return (int)command.ExecuteScalar();
            connection.Close();
        }

        public static bool CapNhatMonHoc(MonHocDTO monhocDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "UPDATE [dbQuanLySinhVien].[dbo].[tblMonHoc] SET [TenMonHoc] = @tenMonHoc,[SoTinChi]=@soTinChi,[MaNganh] = @MaNganh, [MaHe] = @MaHe ,[TrangThai] = @trangThai WHERE [MaMonHoc]= @maMonHoc";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@tenMonHoc", System.Data.SqlDbType.NVarChar, 255, "TenMonHoc").Value = monhocDTO.TenMonHoc;
            command.Parameters.Add("@soTinChi", System.Data.SqlDbType.Int, 0, "SoTinChi").Value = Convert.ToInt32(monhocDTO.SoTinChi);
            command.Parameters.Add("@trangThai", System.Data.SqlDbType.Bit, 2, "TrangThai").Value = monhocDTO.TrangThai;
            command.Parameters.Add("@maMonHoc", System.Data.SqlDbType.Int, 0, "MaMonHoc").Value = monhocDTO.MaMonHoc;
            command.Parameters.Add("@MaNganh", System.Data.SqlDbType.Int, 0, "MaNganh").Value = monhocDTO.MaNganh;
            command.Parameters.Add("@MaHe", System.Data.SqlDbType.Int, 0, "MaHe").Value = monhocDTO.MaHe;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();

        }

        public static bool XoaMonHoc(string maMon)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "UPDATE [dbQuanLySinhVien].[dbo].[tblMonHoc] SET TrangThai=@trangThai  WHERE MaMonHoc=@maMonHoc";
            //string query = "DELETE FROM tblMonHoc WHERE MaMonHoc = @maMonHoc";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@maMonHoc", System.Data.SqlDbType.Int, 0, "MaMonHoc").Value = maMon;
            command.Parameters.Add("@trangThai", System.Data.SqlDbType.Bit, 2, "TrangThai").Value = false;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }

        public static List<MonHocDTO> TimKiemMonHoc(string tenmon, string nganh, string he)
        {
            List<MonHocDTO> result = new List<MonHocDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string Query;
            Query = "SELECT tblMonHoc.MaMonHoc, tblMonHoc.TenMonHoc, tblMonHoc.SoTinChi, tblNganh.TenNganh, tblHeDaoTao.TenHe, tblMonHoc.TrangThai FROM tblMonHoc, tblNganh, tblHeDaoTao Where tblMonHoc.MaNganh = tblNganh.MaNganh and tblMonHoc.MaHe = tblHeDaoTao.MaHe ";
            if (tenmon != "")
                Query = Query + " and tblMonHoc.TenMonHoc like N'%'+@TenMonHoc+'%' ";
            if (nganh != "0")
                Query = Query + " and tblMonHoc.MaNganh like N'%'+@MaNganh+'%' ";
            if (he != "0")
                Query = Query + " and tblMonHoc.MaHe like N'%'+@MaHe+'%' ";
            SqlCommand command = new SqlCommand(Query, connection);
            if (tenmon != null || tenmon != "")
                command.Parameters.Add("@TenMonHoc", System.Data.SqlDbType.NVarChar, 255, "TenMonHoc").Value = tenmon;
            if (nganh != "0")
                command.Parameters.Add("@MaNganh ", System.Data.SqlDbType.NVarChar, 255, "MaNganh").Value = nganh;
            if (he != "0")
                command.Parameters.Add("@MaHe", System.Data.SqlDbType.NVarChar, 255, "MaHe").Value = he;
            result = ReadData(command);
            return result;
        }
    }
}
