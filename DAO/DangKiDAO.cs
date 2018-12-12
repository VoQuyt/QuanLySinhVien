using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class DangKiDAO
    {
        public static List<DangKyDTO> ReadData(SqlCommand command)
        {
            List<DangKyDTO> result = new List<DangKyDTO>();
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DangKyDTO sv = new DangKyDTO();
                    sv.MaLop = reader.GetString(0);
                    sv.TenSV = reader.GetString(1);
                    sv.MaSV = reader.GetString(2);
                    sv.NgayDangKi = reader.GetDateTime(3);
                    sv.TrangThai = reader.GetBoolean(4);
                    result.Add(sv);
                }
            }
            command.Connection.Close();
            return result;
        }

        public static List<DangKyDTO> LayDanhSachDangKi()
        {
            List<DangKyDTO> result = new List<DangKyDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string query = "SELECT tblLopHoc.TenLop, tblSinhVien.Ho, tblSinhVien.Ten, tblDangKy.NgayDangKi, tblDangKy.TrangThai FROM tblDangKy, tblSinhVien, tblLopHoc where tblSinhVien.MaSV = tblDangKy.MaSV and tblLopHoc.MaLop = tblDangKy.MaLop";
            SqlCommand command = new SqlCommand(query, connection);
            result = ReadData(command);
            return result;
        }

        public static int KiemTraSinhVienDangKi(DangKyDTO DangKyDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT CAST((SELECT COUNT(*) FROM tblDangKy WHERE MaSV = @MaSV and MaLop = @MaLop) AS int)", connection);
            command.Parameters.Add("@MaSV", System.Data.SqlDbType.NVarChar, 255, "MaSV").Value = DangKyDTO.MaSV;
            command.Parameters.Add("@MaLop", System.Data.SqlDbType.NVarChar, 255, "MaLop").Value = DangKyDTO.MaLop;
            return (int)command.ExecuteScalar();
            connection.Close();
        }

        public static bool KiemTraSinhVienDongTien(DangKyDTO DangKyDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM tblDangKy WHERE MaSV = @MaSV and MaLop = @MaLop and TrangThai = @TrangThai", connection);
            command.Parameters.Add("@MaSV", System.Data.SqlDbType.NVarChar, 255, "MaSV").Value = DangKyDTO.MaSV;
            command.Parameters.Add("@MaLop", System.Data.SqlDbType.NVarChar, 255, "MaLop").Value = DangKyDTO.MaLop;
            command.Parameters.Add("@TrangThai", System.Data.SqlDbType.Bit, 0, "TrangThai").Value = true;
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }

        public static bool ThemSinhVienDangKi(DangKyDTO DangKyDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO tblDangKy(MaLop, MaSV, NgayDangKi, TrangThai) VALUES(@MaLop, @MaSV, @NgayDangKi, @TrangThai)", connection);
            command.Parameters.Add("@MaLop", System.Data.SqlDbType.NVarChar, 255, "MaLop").Value = DangKyDTO.MaLop;
            command.Parameters.Add("@MaSV", System.Data.SqlDbType.NVarChar, 255, "MaSV").Value = DangKyDTO.MaSV;
            command.Parameters.Add("@NgayDangKi", System.Data.SqlDbType.DateTime, 255, "NgayDangKi").Value = Convert.ToDateTime(DangKyDTO.NgayDangKi);
            command.Parameters.Add("@TrangThai", System.Data.SqlDbType.Bit, 0, "TrangThai").Value = DangKyDTO.TrangThai;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }

        public static bool CapNhatThongTinDangKi(DangKyDTO DangKyDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("UPDATE [dbQuanLySinhVien].[dbo].[tblDangKy] SET [MaLop] = @MaLop , [NgayDangKi] = @NgayDangKi ,[TrangThai] = @TrangThai WHERE [MaSV] = @MaSV ", connection);
            command.Parameters.Add("@MaLop", System.Data.SqlDbType.NVarChar, 255, "MaLop").Value = DangKyDTO.MaLop;
            command.Parameters.Add("@MaSV", System.Data.SqlDbType.NVarChar, 255, "MaSV").Value = DangKyDTO.MaSV;
            command.Parameters.Add("@NgayDangKi", System.Data.SqlDbType.DateTime, 255, "NgayDangKi").Value = Convert.ToDateTime(DangKyDTO.NgayDangKi);
            command.Parameters.Add("@TrangThai", System.Data.SqlDbType.Bit, 0, "TrangThai").Value = DangKyDTO.TrangThai;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }

        public static List<DangKyDTO> LayDanhSachSVDangKiTheoLop(string maLop)
        {
            List<DangKyDTO> result = new List<DangKyDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string query = "SELECT tblLopHoc.TenLop, tblSinhVien.Ho, tblSinhVien.Ten, tblDangKy.NgayDangKi, tblDangKy.TrangThai FROM tblDangKy, tblSinhVien, tblLopHoc where tblSinhVien.MaSV = tblDangKy.MaSV and tblLopHoc.MaLop = tblDangKy.MaLop and tblDangKy.MaLop = @MaLop";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@MaLop ", System.Data.SqlDbType.NVarChar, 255, "MaLop").Value = maLop;
            result = ReadData(command);
            return result;
        }

        public static List<DangKyDTO> Timkiemsinhvien(string ten, string nganh, string he)
        {
            List<DangKyDTO> result = new List<DangKyDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string Query;
            Query = "SELECT tblLopHoc.TenLop , tblSinhVien.Ho, tblSinhVien.Ten, tblDangKy.NgayDangKi, tblDangKy.TrangThai FROM tblSinhVien, tblDangKy,tblLopHoc, tblNganh, tblHeDaoTao WHERE tblSinhVien.MaNganh = tblNganh.MaNganh and tblSinhVien.MaHe = tblHeDaoTao.MaHe and tblDangKy.MaSV = tblSinhVien.MaSV and tblLopHoc.MaLop = tblDangKy.MaLop";
            if (ten != "")
                Query = Query + " and tblSinhVien.Ten like N'%'+@HoTen+'%' ";
            if (nganh != "0")
                Query = Query + " and tblSinhVien.MaNganh like N'%'+@MaNganh+'%' ";
            if (he != "0")
                Query = Query + " and tblSinhVien.MaHe like N'%'+@MaHe+'%' ";
            SqlCommand command = new SqlCommand(Query, connection);
            if (ten != null || ten != "")
                command.Parameters.Add("@HoTen", System.Data.SqlDbType.NVarChar, 255, "HoTen").Value = ten;
            if (nganh != "0")
                command.Parameters.Add("@MaNganh ", System.Data.SqlDbType.NVarChar, 255, "MaNganh").Value = nganh;
            if (he != "0")
                command.Parameters.Add("@MaHe", System.Data.SqlDbType.NVarChar, 255, "MaHe").Value = he;
            result = ReadData(command);
            return result;
        }

        public static bool Xoa(string malop, string masv)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "delete from tblDangKy where tblDangKy.MaSV = @masv and tblDangKy.MaLop = @malop";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@masv", System.Data.SqlDbType.NVarChar, 255, "masv").Value = masv;
            command.Parameters.Add("@malop", System.Data.SqlDbType.NVarChar, 255, "malop").Value = malop;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }
    }
}
