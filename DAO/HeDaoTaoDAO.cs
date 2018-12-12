using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public static class HeDaoTaoDAO
    {
        public static List<HeDaoTaoDTO> LayDanhSachTatCaHe()
        {
            List<HeDaoTaoDTO> result = new List<HeDaoTaoDTO>();

            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM tblHeDaoTao", connection);

            result = ReadData(command);
            return result;
        }

        public static List<HeDaoTaoDTO> LayDanhSachHe()
        {
            List<HeDaoTaoDTO> result = new List<HeDaoTaoDTO>();

            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM tblHeDaoTao WHERE tblHeDaoTao.TrangThai = 1", connection);

            result = ReadData(command);
            return result;
        }

        static List<HeDaoTaoDTO> ReadData(SqlCommand command)
        {
            List<HeDaoTaoDTO> result = new List<HeDaoTaoDTO>();
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    HeDaoTaoDTO he = new HeDaoTaoDTO();
                    he.MaHe = reader.GetInt32(0);
                    he.TenHe = reader.GetString(1);
                    he.TrangThai = reader.GetBoolean(2);
                    result.Add(he);
                }
            }
            command.Connection.Close();
            return result;
        }

        public static bool ThemHeDaoTao(HeDaoTaoDTO hedaotaoDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO tblHeDaoTao(TenHe, TrangThai) VALUES(@TenHe, @TrangThai)", connection);
            command.Parameters.Add("@TenHe", System.Data.SqlDbType.NVarChar, 255, "TenHe").Value = hedaotaoDTO.TenHe;
            command.Parameters.Add("@TrangThai", System.Data.SqlDbType.Bit, 0, "TrangThai").Value = hedaotaoDTO.TrangThai;
            //command.Parameters.Add("@MaHe", System.Data.SqlDbType.NVarChar, 255, "MaHe").Value = hedaotaoDTO.MaHe;

            connection.Open();
            //if (command.ExecuteNonQuery() > 0)
            //{
            //    command = new SqlCommand("SELECT CAST(@@IDENTITY AS int)", connection);
            //   result = (int)command.ExecuteScalar();
            //}
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }


        //public static int KiemTraHeDaTonTai(string maHe)
        //{
        //    SqlConnection connection = DataProvider.GetConnection();
        //    connection.Open();
        //    SqlCommand command = new SqlCommand("SELECT CAST((SELECT COUNT(*) from tblHeDaoTao where tblHeDaoTao.MaHe = @MaHe) as int)", connection);
        //    command.Parameters.Add("@MaHe", System.Data.SqlDbType.NVarChar, 255, "MaHe").Value = maHe;
        //    return (int)command.ExecuteScalar();
        //    connection.Close();
        //}

        public static int KiemTraHeConHieuLuc(string maHe)
        {
            SqlConnection connection = DataProvider.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT CAST((SELECT COUNT(*) from tblHeDaoTao where tblHeDaoTao.MaHe = @MaHe and tblHeDaoTao.TrangThai = @TrangThai) as int)", connection);
            command.Parameters.Add("@MaHe", System.Data.SqlDbType.Int, 0, "MaHe").Value = maHe;
            command.Parameters.Add("@TrangThai", System.Data.SqlDbType.Bit, 1, "TrangThai").Value = false;
            return (int)command.ExecuteScalar();
            connection.Close();
        }

        public static bool CapNhatHeDaoTao(HeDaoTaoDTO hedaotaoDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "UPDATE [dbQuanLySinhVien].[dbo].[tblHeDaoTao] SET [TenHe] = @TenHe, [TrangThai] = @TrangThai WHERE [MaHe]= @MaHe";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@TenHe", System.Data.SqlDbType.NVarChar, 255, "TenHe").Value = hedaotaoDTO.TenHe;
            command.Parameters.Add("@TrangThai", System.Data.SqlDbType.Bit, 0, "TrangThai").Value = hedaotaoDTO.TrangThai;
            command.Parameters.Add("@MaHe", System.Data.SqlDbType.Int, 0, "MaHe").Value = hedaotaoDTO.MaHe;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }

        public static bool XoaHeDaoTao(int maHe)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "UPDATE [dbQuanLySinhVien].[dbo].[tblHeDaoTao] SET [TrangThai] = @TrangThai WHERE [MaHe]= @MaHe";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@MaHe", System.Data.SqlDbType.Int, 0, "MaHe").Value = maHe;
            command.Parameters.Add("@TrangThai", System.Data.SqlDbType.Bit, 0, "TrangThai").Value = false;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }
    }
}
