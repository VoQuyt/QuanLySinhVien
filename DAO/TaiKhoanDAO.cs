using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        public static List<TaiKhoanDTO> ReadData(SqlCommand command)
        {
            List<TaiKhoanDTO> result = new List<TaiKhoanDTO>();
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TaiKhoanDTO tk = new TaiKhoanDTO();
                    tk.ID = reader.GetInt32(0);
                    tk.TenTaiKhoan = reader.GetString(1);
                    tk.MatKhau = reader.GetString(2);
                    tk.PhanQuyen = reader.GetInt32(3);
                    tk.TrangThai = reader.GetBoolean(4);
                    result.Add(tk);
                }
            }
            command.Connection.Close();
            return result;
        }

        public static List<TaiKhoanDTO> LayDanhSachTaiKhoan()
        {
            List<TaiKhoanDTO> result = new List<TaiKhoanDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string query = "SELECT * FROM tblTaiKhoan";
            SqlCommand command = new SqlCommand(query, connection);
            result = ReadData(command);
            return result;
        }

        public static int CheckQuyenTruyCap(string taikhoan)
        {
            SqlConnection connection = DataProvider.GetConnection();
            connection.Open();
            string query = "SELECT tblTaiKhoan.PhanQuyen FROM tblTaiKhoan where TenTaiKhoan=@tenTaiKhoan";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@tenTaiKhoan", System.Data.SqlDbType.NVarChar, 255, "TenTaiKhoan").Value = taikhoan;
            //command.Parameters.Add("@MatKhau", System.Data.SqlDbType.NVarChar, 255, "MatKhau").Value = matkhau;
            return (int)command.ExecuteScalar();
            connection.Close();
        }

        public static bool ThemTaiKhoan(TaiKhoanDTO tenTK)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "INSERT INTO tblTaiKhoan(TenTaiKhoan, MatKhau, PhanQuyen, TrangThai) VALUES(@tenTaiKhoan, @matKhau, @phanQuyen, @trangThai)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@tenTaiKhoan", System.Data.SqlDbType.NVarChar, 255, "TenTaiKhoan").Value = tenTK.TenTaiKhoan;
            command.Parameters.Add("@matKhau", System.Data.SqlDbType.NVarChar, 255, "MatKhau").Value = tenTK.MatKhau;
            command.Parameters.Add("@phanQuyen", System.Data.SqlDbType.Int, 0, "PhanQuyen").Value = tenTK.PhanQuyen;
            command.Parameters.Add("@trangThai", System.Data.SqlDbType.Bit, 0, "TrangThai").Value = tenTK.TrangThai;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }
        public static int KiemTraTaiKhoanTonTai(string tenTK)
        {
            SqlConnection connection = DataProvider.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT CAST((select count(*) from tblTaiKhoan where TenTaiKhoan=@tenTaiKhoan) AS int)", connection);
            command.Parameters.Add("@tenTaiKhoan", System.Data.SqlDbType.NVarChar, 255, "TenTaiKhoan").Value = tenTK;
            return (int)command.ExecuteScalar();
            connection.Close();
        }
 

        public static bool CapNhatTaiKhoan(TaiKhoanDTO tenTK)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "UPDATE [dbQuanLySinhVien].[dbo].[tblTaiKhoan] SET [MatKhau] = @matKhau,[PhanQuyen]=@phanQuyen,[TrangThai] = @trangThai, [TenTaiKhoan]= @tenTaiKhoan WHERE [Id] = @ID ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@tenTaiKhoan", System.Data.SqlDbType.NVarChar, 255, "TenTaiKhoan").Value = tenTK.TenTaiKhoan;
            command.Parameters.Add("@matKhau", System.Data.SqlDbType.NVarChar, 255, "MatKhau").Value = tenTK.MatKhau;
            command.Parameters.Add("@phanQuyen", System.Data.SqlDbType.Int, 0, "PhanQuyen").Value = tenTK.PhanQuyen;
            command.Parameters.Add("@trangThai", System.Data.SqlDbType.Bit, 0, "TrangThai").Value = tenTK.TrangThai;
            command.Parameters.Add("@ID", System.Data.SqlDbType.Int, 0, "ID").Value = tenTK.ID;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();

        }

        public static bool XoaTaiKhoan(int ID)
        {
            SqlConnection connection = DataProvider.GetConnection();

            string query = "UPDATE [dbQuanLySinhVien].[dbo].[tblTaiKhoan] SET TrangThai=@trangThai  WHERE Id=@ID";
            //string query = "DELETE FROM tblMonHoc WHERE MaMonHoc = @maMonHoc";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@ID", System.Data.SqlDbType.Int, 0, "ID").Value = ID;
            command.Parameters.Add("@trangThai", System.Data.SqlDbType.Bit, 2, "TrangThai").Value = false;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }

        public static int KiemTraDangNhap(string taikhoan, string matkhau)
        {
            SqlConnection connection = DataProvider.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT CAST((select count(*) from tblTaiKhoan where TenTaiKhoan=@tenTaiKhoan and MatKhau = @MatKhau and TrangThai = @TrangThai) AS int)", connection);
            command.Parameters.Add("@tenTaiKhoan", System.Data.SqlDbType.NVarChar, 255, "TenTaiKhoan").Value = taikhoan;
            command.Parameters.Add("@MatKhau", System.Data.SqlDbType.NVarChar, 255, "MatKhau").Value = matkhau;
            command.Parameters.Add("@TrangThai", System.Data.SqlDbType.Bit, 0, "TrangThai").Value = true;
            return (int)command.ExecuteScalar();
            connection.Close();
        }
    }
}
