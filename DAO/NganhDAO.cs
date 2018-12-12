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
    public static class NganhDAO
    {
        public static List<NganhDTO> LayDanhSachTatCaNganh()
        {
            List<NganhDTO> result = new List<NganhDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM tblNganh", connection);
            result = ReadData(command);
            return result;
        }

        public static List<NganhDTO> LayDanhSachNganh()
        {
            List<NganhDTO> result = new List<NganhDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM tblNganh where tblNganh.TrangThai = 1", connection);
            result = ReadData(command);
            return result;
        }

        public static List<NganhDTO> ReadData(SqlCommand command)
        {
            List<NganhDTO> result = new List<NganhDTO>();
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    NganhDTO nganh = new NganhDTO();
                    nganh.MaNganh = reader.GetInt32(0);
                    nganh.TenNganh = reader.GetString(1);
                    nganh.TrangThai = reader.GetBoolean(2);
                    result.Add(nganh);
                }
            }
            command.Connection.Close();
            return result;
        }


        //public static int KiemTraNganhTonTai(string maNganh)
        //{
        //    SqlConnection connection = DataProvider.GetConnection();
        //    connection.Open();
        //    SqlCommand command = new SqlCommand("SELECT CAST((SELECT COUNT(*) from tblNganh where tblNganh.MaNganh = @MaNganh) as int)", connection);
        //    command.Parameters.Add("@MaNganh", System.Data.SqlDbType.Int, 0, "MaNganh").Value = maNganh;
        //    return (int)command.ExecuteScalar();
        //    connection.Close();
        //}

        public static int KiemTraNganhConHieuLuc(int maNganh)
        {
            SqlConnection connection = DataProvider.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT CAST((SELECT COUNT(*) from tblNganh where tblNganh.MaNganh = @MaNganh and tblNganh.TrangThai = @TrangThai) as int)", connection);
            command.Parameters.Add("@MaNganh", System.Data.SqlDbType.Int, 0, "MaNganh").Value = maNganh;
            command.Parameters.Add("@TrangThai", System.Data.SqlDbType.Bit, 2, "TrangThai").Value = false;
            return (int)command.ExecuteScalar();
            connection.Close();
        }

        public static bool ThemNganh(NganhDTO nganhDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO tblNganh(TenNganh, TrangThai) VALUES(@TenNganh, @TrangThai)", connection);
            command.Parameters.Add("@TenNganh", System.Data.SqlDbType.NVarChar, 0, "TenNganh").Value = nganhDTO.TenNganh;
            command.Parameters.Add("@TrangThai", System.Data.SqlDbType.Bit, 2, "TrangThai").Value = nganhDTO.TrangThai;
            //command.Parameters.Add("@MaNganh", System.Data.SqlDbType.NVarChar, 255, "MaNganh").Value = nganhDTO.MaNganh;

            connection.Open();
            //if (command.ExecuteNonQuery() > 0)
            //{
            //    command = new SqlCommand("SELECT CAST(@@IDENTITY AS int)", connection);
            //    result = (int)command.ExecuteScalar();
            //}
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }

        public static bool CapNhatNganh(NganhDTO nganhDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "UPDATE [dbQuanLySinhVien].[dbo].[tblNganh] SET [TenNganh] = @TenNganh, [TrangThai] = @TrangThai WHERE [MaNganh]= @MaNganh";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@TenNganh", System.Data.SqlDbType.NVarChar, 255, "TenNganh").Value = nganhDTO.TenNganh;
            command.Parameters.Add("@TrangThai", System.Data.SqlDbType.Bit, 0, "TrangThai").Value = nganhDTO.TrangThai;
            command.Parameters.Add("@MaNganh", System.Data.SqlDbType.Int, 0, "MaNganh").Value = nganhDTO.MaNganh;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }

        public static bool XoaNganh(int maNganh)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "UPDATE [dbQuanLySinhVien].[dbo].[tblNganh] SET [TrangThai] = @TrangThai WHERE [MaNganh]= @MaNganh";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@MaNganh", System.Data.SqlDbType.Int, 0, "MaNganh").Value = maNganh;
            command.Parameters.Add("@TrangThai", System.Data.SqlDbType.NVarChar, 255, "TrangThai").Value = false;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }
    }
}
