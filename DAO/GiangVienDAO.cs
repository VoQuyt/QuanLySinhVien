using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class GiangVienDAO
    {
        public static List<GiangVienDTO> ReadData(SqlCommand command)
        {
            List<GiangVienDTO> result = new List<GiangVienDTO>();
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    GiangVienDTO sv = new GiangVienDTO();
                    sv.MaGV = (int)reader[0];
                    sv.Ho = reader.GetString(1);
                    sv.Ten = reader.GetString(2);
                    sv.NgaySinh = reader.GetDateTime(3);
                    sv.GioiTinh = reader.GetBoolean(4);
                    sv.NoiSinh = reader.GetString(5);
                    sv.SDT = reader.GetString(6);
                    sv.Email = reader.GetString(7);
                    sv.HocVi = reader.GetString(8);
                    sv.TinhTrang = reader.GetBoolean(9);
                    sv.Nganh = reader.GetString(10);
                    result.Add(sv);
                }
            }
            command.Connection.Close();
            return result;
        }

        public static List<GiangVienDTO> LayDanhSachGiangVien()
        {
            List<GiangVienDTO> result = new List<GiangVienDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("select tblGiangVien.MaGiangVien, tblGiangVien.HoLot, tblGiangVien.Ten, tblGiangVien.NgaySinh, tblGiangVien.GioiTinh, tblGiangVien.NoiSinh, tblGiangVien.SĐT, tblGiangVien.Email, tblGiangVien.HocVi, tblGiangVien.TinhTrang, tblNganh.TenNganh from tblGiangVien, tblNganh where tblGiangVien.MaNganh = tblNganh.MaNganh", connection);
            result = ReadData(command);
            return result;
        }

        public static List<GiangVienDTO> LayDSGiangVienTheoNganh(int maNganh)
        {
            List<GiangVienDTO> result = new List<GiangVienDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("select tblGiangVien.MaGiangVien, tblGiangVien.HoLot, tblGiangVien.Ten, tblGiangVien.NgaySinh, tblGiangVien.GioiTinh, tblGiangVien.NoiSinh, tblGiangVien.SĐT, tblGiangVien.Email, tblGiangVien.HocVi, tblGiangVien.TinhTrang, tblNganh.TenNganh from tblGiangVien, tblNganh where tblGiangVien.MaNganh = tblNganh.MaNganh and tblGiangVien.TinhTrang = 1 and tblGiangVien.MaNganh = @MaNganh", connection);
            command.Parameters.Add("@MaNganh", System.Data.SqlDbType.Int, 0, "MaNganh").Value = maNganh;
            result = ReadData(command);
            return result;
        }

        public static bool ThemGiangVien(GiangVienDTO giangvienDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO tblGiangVien(HoLot, Ten, NgaySinh, GioiTinh, NoiSinh,SĐT, Email, HocVi, TinhTrang, MaNganh) VALUES(@Ho, @Ten, @NgaySinh, @GioiTinh, @NoiSinh, @SĐT, @Email, @HocVi, @TinhTrang, @MaNganh)", connection);
            command.Parameters.Add("@Ho", System.Data.SqlDbType.NVarChar, 255, "Ho").Value = giangvienDTO.Ho;
            command.Parameters.Add("@Ten", System.Data.SqlDbType.NVarChar, 255, "Ten").Value = giangvienDTO.Ten;
            command.Parameters.Add("@NgaySinh", System.Data.SqlDbType.DateTime, 255, "NgaySinh").Value = Convert.ToDateTime(giangvienDTO.NgaySinh);
            command.Parameters.Add("@GioiTinh", System.Data.SqlDbType.Bit, 0, "GioiTinh").Value = giangvienDTO.GioiTinh;
            command.Parameters.Add("@NoiSinh", System.Data.SqlDbType.NVarChar, 255, "NoiSinh").Value = giangvienDTO.NoiSinh;
            command.Parameters.Add("@SĐT", System.Data.SqlDbType.NVarChar, 255, "SĐT").Value = giangvienDTO.SDT;
            command.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar, 255, "Email").Value = giangvienDTO.Email;
            command.Parameters.Add("@HocVi", System.Data.SqlDbType.NVarChar, 255, "HocVi").Value = giangvienDTO.HocVi;
            command.Parameters.Add("@TinhTrang", System.Data.SqlDbType.Bit, 0, "TinhTrang").Value = giangvienDTO.TinhTrang;
            command.Parameters.Add("@MaNganh", System.Data.SqlDbType.Int, 0, "MaNganh").Value = giangvienDTO.Nganh;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }

        public static bool UpdateGiangVien(GiangVienDTO giangvienDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "UPDATE [dbQuanLySinhVien].[dbo].[tblGiangVien] SET [HoLot] = @Ho, [Ten] = @Ten ,[NgaySinh] = @NgaySinh, [GioiTinh] = @GioiTinh, [NoiSinh] = @NoiSinh ,[SĐT] = @SĐT , [Email] = @Email ,[HocVi] = @HocVi, [TinhTrang] = @TinhTrang, [MaNganh] = @MaNganh WHERE [MaGiangVien]= @MaGiangVien";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@Ho", System.Data.SqlDbType.NVarChar, 255, "Ho").Value = giangvienDTO.Ho;
            command.Parameters.Add("@Ten", System.Data.SqlDbType.NVarChar, 255, "Ten").Value = giangvienDTO.Ten;
            command.Parameters.Add("@NgaySinh", System.Data.SqlDbType.DateTime, 255, "NgaySinh").Value = Convert.ToDateTime(giangvienDTO.NgaySinh);
            command.Parameters.Add("@GioiTinh", System.Data.SqlDbType.Bit, 0, "GioiTinh").Value = giangvienDTO.GioiTinh;
            command.Parameters.Add("@NoiSinh", System.Data.SqlDbType.NVarChar, 255, "NoiSinh").Value = giangvienDTO.NoiSinh;
            command.Parameters.Add("@SĐT", System.Data.SqlDbType.NVarChar, 255, "SĐT").Value = giangvienDTO.SDT;
            command.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar, 255, "Email").Value = giangvienDTO.Email;
            command.Parameters.Add("@HocVi", System.Data.SqlDbType.NVarChar, 255, "HocVi").Value = giangvienDTO.HocVi;
            command.Parameters.Add("@TinhTrang", System.Data.SqlDbType.Bit, 0, "TinhTrang").Value = giangvienDTO.TinhTrang;
            command.Parameters.Add("@MaNganh", System.Data.SqlDbType.Int, 0, "MaNganh").Value = giangvienDTO.Nganh;
            command.Parameters.Add("@MaGiangVien", System.Data.SqlDbType.Int, 0, "MaGiangVien").Value = giangvienDTO.MaGV;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }
    }
}
