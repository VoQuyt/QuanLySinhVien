using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public static class SinhVienDAO
    {

        public static List<TinhTrangDTO> ReadDataTT(SqlCommand command)
        {
            List<TinhTrangDTO> result = new List<TinhTrangDTO>();
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TinhTrangDTO sv = new TinhTrangDTO();
                    sv.ID = (int)reader[0];
                    sv.TinhTrang = reader.GetString(1);
                    result.Add(sv);
                }
            }
            command.Connection.Close();
            return result;
        }


        public static List<TinhTrangDTO> GetListTinhTrang()
        {
            List<TinhTrangDTO> lsSV = new List<TinhTrangDTO>();
            SqlConnection con = DataProvider.GetConnection();
            SqlCommand cmd = new SqlCommand("select * from tblTinhTrang", con);
            lsSV = ReadDataTT(cmd);
            return lsSV;
        }
        ////////////////////////////tình trạng sinh viên////////////////

        public static List<SinhVienDTO> GetListSinhVien()
        {
            List<SinhVienDTO> lsSV = new List<SinhVienDTO>();
            SqlConnection con = DataProvider.GetConnection();
            SqlCommand cmd = new SqlCommand("select tblSinhVien.MaSV, tblSinhVien.Ho, tblSinhVien.Ten, tblSinhVien.GioiTinh, tblSinhVien.NoiSinh, tblSinhVien.NgaySinh, tblNganh.TenNganh, tblHeDaoTao.TenHe, tblTinhTrang.TinhTrang, tblSinhVien.NienKhoa from tblSinhVien, tblHeDaoTao, tblNganh, tblTinhTrang where tblsinhvien.MaHe = tblHeDaoTao.MaHe and  tblSinhVien.MaNganh = tblNganh.MaNganh and tblTinhTrang.Id = tblSinhVien.TinhTrang_Id", con);
            lsSV = ReadData(cmd);
            return lsSV;
        }

        public static List<SinhVienDTO> ReadData(SqlCommand command)
        {
            List<SinhVienDTO> result = new List<SinhVienDTO>();
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    SinhVienDTO sv = new SinhVienDTO();
                    sv.MaSV = (int)reader[0];
                    sv.Ho = reader.GetString(1);
                    sv.Ten = reader.GetString(2);
                    sv.GioiTinh = reader.GetBoolean(3);
                    sv.NoiSinh = reader.GetString(4);
                    sv.NgaySinh = reader.GetDateTime(5);
                    sv.MaNganh = reader.GetString(6);
                    sv.MaHe = reader.GetString(7);
                    sv.TinhTrang = reader.GetString(8);
                    sv.NienKhoa = reader.GetInt32(9);
                    result.Add(sv);
                }
            }
            command.Connection.Close();
            return result;
        }

        public static SinhVienDTO Readdata(SqlCommand command)
        {
            command.Connection.Open();
            SinhVienDTO sv = new SinhVienDTO();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    sv.MaSV = reader.GetInt32(0);
                    sv.Ho = reader.GetString(1);
                    sv.Ten = reader.GetString(2);
                    sv.GioiTinh = reader.GetBoolean(3);
                    sv.NoiSinh = reader.GetString(4);
                    sv.NgaySinh = reader.GetDateTime(5);
                    sv.MaNganh = reader.GetString(6);
                    sv.MaHe = reader.GetString(7);
                    sv.TinhTrang = reader.GetString(8);
                    sv.NienKhoa = reader.GetInt32(9);
                }
            }
            command.Connection.Close();
            return sv;
        }


        public static List<SinhVienDTO> LayDanhSachSinhVien()
        {
            List<SinhVienDTO> result = new List<SinhVienDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("select tblSinhVien.MaSV, tblSinhVien.Ho, tblSinhVien.Ten, tblSinhVien.GioiTinh, tblSinhVien.NoiSinh, tblSinhVien.NgaySinh, tblNganh.TenNganh,tblHeDaoTao.TenHe, tblSinhVien.GhiChu from tblSinhVien, tblHeDaoTao, tblNganh where tblSinhVien.MaHe = tblHeDaoTao.MaHe and tblSinhVien.MaNganh = tblNganh.MaNganh", connection);
            result = ReadData(command);
            return result;
        }

        public static SinhVienDTO LayThongTinSinhVien(string maSV)
        {
            SinhVienDTO result = new SinhVienDTO();
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("select tblSinhVien.MaSV, tblSinhVien.Ho, tblSinhVien.Ten, tblSinhVien.GioiTinh, tblSinhVien.NoiSinh, tblSinhVien.NgaySinh, tblNganh.TenNganh, tblHeDaoTao.TenHe, tblTinhTrang.TinhTrang, tblSinhVien.NienKhoa from tblSinhVien, tblHeDaoTao, tblNganh, tblTinhTrang where tblsinhvien.MaHe = tblHeDaoTao.MaHe and  tblSinhVien.MaNganh = tblNganh.MaNganh and tblTinhTrang.Id = tblSinhVien.TinhTrang_Id and tblSinhVien.MaSV = @MaSV", connection);
            command.Parameters.Add("@MaSV", System.Data.SqlDbType.NVarChar, 255, "MaSV").Value = maSV;
            result = Readdata(command);
            return result;
        }

        public static int KiemTraSinhVienTonTai(string maSV)
        {
            SqlConnection connection = DataProvider.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT CAST((SELECT COUNT(*) FROM tblSinhVien WHERE MaSV = @MaSV) AS int)", connection);
            command.Parameters.Add("@MaSV", System.Data.SqlDbType.NVarChar, 255, "MaSV").Value = maSV;
            return (int)command.ExecuteScalar();
            connection.Close();
        }

        public static bool ThemSinhVien(SinhVienDTO sinhvienDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO tblSinhVien(Ho, Ten, GioiTinh, NoiSinh, NgaySinh, MaNganh, MaHe, TinhTrang_Id, NienKhoa) VALUES(@Ho, @Ten, @GioiTinh, @NoiSinh, @NgaySinh, @MaNganh, @MaHe, @TinhTrang_Id, @NienKhoa)", connection);
            command.Parameters.Add("@Ho", System.Data.SqlDbType.NVarChar, 255, "Ho").Value = sinhvienDTO.Ho;
            command.Parameters.Add("@Ten", System.Data.SqlDbType.NVarChar, 255, "Ten").Value = sinhvienDTO.Ten;
            command.Parameters.Add("@GioiTinh", System.Data.SqlDbType.Bit, 0, "GioiTinh").Value = sinhvienDTO.GioiTinh;
            command.Parameters.Add("@NoiSinh", System.Data.SqlDbType.NVarChar, 255, "NoiSinh").Value = sinhvienDTO.NoiSinh;
            command.Parameters.Add("@NgaySinh", System.Data.SqlDbType.DateTime, 255, "NgaySinh").Value = Convert.ToDateTime(sinhvienDTO.NgaySinh);
            command.Parameters.Add("@MaNganh", System.Data.SqlDbType.Int, 0, "MaNganh").Value = sinhvienDTO.MaNganh;
            command.Parameters.Add("@MaHe", System.Data.SqlDbType.Int, 0, "MaHe").Value = sinhvienDTO.MaHe;
            command.Parameters.Add("@NienKhoa", System.Data.SqlDbType.Int, 0, "NienKhoa").Value =(sinhvienDTO.NienKhoa);
            command.Parameters.Add("@TinhTrang_Id", System.Data.SqlDbType.Int, 0, "TinhTrang_Id").Value = sinhvienDTO.TinhTrang;
            //command.Parameters.Add("@MaSV", System.Data.SqlDbType.Int, 0, "MaSV").Value = sinhvienDTO.MaSV;

            connection.Open();         
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }
         
        public static bool DeleteStudent(string maSV)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "DELETE FROM tblSinhVien WHERE MaSV = @MaSV";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@MaSV", System.Data.SqlDbType.NVarChar, 255, "MaSV").Value = maSV;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }

        public static bool UpdateStudent(SinhVienDTO sinhvienDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "UPDATE [dbQuanLySinhVien].[dbo].[tblSinhVien] SET [Ho] = @Ho, [Ten] = @Ten ,[GioiTinh] = @GioiTinh, [NoiSinh] = @NoiSinh, [NgaySinh] = @NgaySinh, [MaNganh] = @MaNganh, [MaHe] = @MaHe, [TinhTrang_Id] = @TinhTrang, [NienKhoa] = @NienKhoa WHERE [MaSV]= @MaSV";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@Ho", System.Data.SqlDbType.NVarChar, 255, "Ho").Value = sinhvienDTO.Ho;
            command.Parameters.Add("@Ten", System.Data.SqlDbType.NVarChar, 255, "Ten").Value = sinhvienDTO.Ten;
            command.Parameters.Add("@GioiTinh", System.Data.SqlDbType.Bit, 0, "GioiTinh").Value = sinhvienDTO.GioiTinh;
            command.Parameters.Add("@NoiSinh", System.Data.SqlDbType.NVarChar, 255, "NoiSinh").Value = sinhvienDTO.NoiSinh;
            command.Parameters.Add("@NgaySinh", System.Data.SqlDbType.DateTime, 255, "NgaySinh").Value = Convert.ToDateTime(sinhvienDTO.NgaySinh);
            command.Parameters.Add("@MaNganh", System.Data.SqlDbType.Int, 0, "MaNganh").Value = sinhvienDTO.MaNganh;
            command.Parameters.Add("@MaHe", System.Data.SqlDbType.Int, 0, "MaHe").Value = sinhvienDTO.MaHe;
            command.Parameters.Add("@NienKhoa", System.Data.SqlDbType.Int, 0, "NienKhoa").Value = (sinhvienDTO.NienKhoa);
            command.Parameters.Add("@TinhTrang", System.Data.SqlDbType.Int, 0, "TinhTrang").Value = sinhvienDTO.TinhTrang;
            command.Parameters.Add("@MaSV", System.Data.SqlDbType.Int, 0, "MaSV").Value = sinhvienDTO.MaSV;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }

        public static List<SinhVienDTO> Timkiemsinhvien(string ho, string ten, string noisinh, string nganh, string he, string tinhtrang)
        {
            List<SinhVienDTO> result = new List<SinhVienDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string Query;
            Query = "SELECT tblSinhVien.MaSV, tblSinhVien.Ho, tblSinhVien.Ten, tblSinhVien.GioiTinh, tblSinhVien.NoiSinh, tblSinhVien.NgaySinh, tblNganh.TenNganh,tblHeDaoTao.TenHe, tblTinhTrang.TinhTrang, tblSinhVien.NienKhoa FROM tblSinhVien, tblHeDaoTao, tblNganh, tblTinhTrang WHERE tblSinhVien.MaNganh = tblNganh.MaNganh and tblSinhVien.MaHe = tblHeDaoTao.MaHe and tblSinhVien.TinhTrang_Id = tblTinhTrang.Id ";
            if (ho != "")
                Query = Query + " and tblSinhVien.Ho like N'%'+@Ho+'%' ";
            if (ten != "")
                Query = Query + " and tblSinhVien.Ten like N'%'+@Ten+'%' ";
            if (noisinh != "")
                Query = Query + " and tblSinhVien.NoiSinh like N'%'+@NoiSinh+'%' ";
            if (nganh != "0" )
                Query = Query + " and tblSinhVien.MaNganh like N'%'+@MaNganh+'%' ";
            if (he != "0")
                Query = Query + " and tblSinhVien.MaHe like N'%'+@MaHe+'%' ";
            if (tinhtrang != "0")
                Query = Query + " and tblSinhVien.TinhTrang_Id like N'%'+@TinhTrang_Id+'%' ";
            SqlCommand command = new SqlCommand(Query, connection);
            if (ho != null || ho != "")
                command.Parameters.Add("@Ho", System.Data.SqlDbType.NVarChar, 255, "Ho").Value = ho;
            if (ten != null || ten != "")
                command.Parameters.Add("@Ten", System.Data.SqlDbType.NVarChar, 255, "Ten").Value = ten;
            if (noisinh != null || noisinh != "")
                command.Parameters.Add("@NoiSinh ", System.Data.SqlDbType.NVarChar, 255, "NoiSinh").Value = noisinh;
            if (nganh != "0")
                command.Parameters.Add("@MaNganh ", System.Data.SqlDbType.NVarChar, 255, "MaNganh").Value = nganh;
            if (he != "0")
                command.Parameters.Add("@MaHe", System.Data.SqlDbType.NVarChar, 255, "MaHe").Value = he;
            if (tinhtrang != "0")
                command.Parameters.Add("@TinhTrang_Id", System.Data.SqlDbType.NVarChar, 255, "TinhTrang_Id").Value = tinhtrang;
            result = ReadData(command);
            return result;
        }
    }
}
