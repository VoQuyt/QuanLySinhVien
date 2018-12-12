using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class LopHocDAO
    {
        public static List<LopHocDTO> ReadData(SqlCommand command)
        {
            List<LopHocDTO> result = new List<LopHocDTO>();
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    LopHocDTO lop = new LopHocDTO();
                    lop.MaLop = reader.GetInt32(0);
                    lop.TenLop = reader.GetString(1);
                    lop.NgayBatDau = reader.GetDateTime(2);
                    lop.NgayKetThuc = reader.GetDateTime(3);
                    lop.MaMon = reader.GetString(5);
                    lop.SiSo = reader.GetInt32(4);
                    lop.MaGV = reader.GetString(6);
                    result.Add(lop);
                }
            }
            command.Connection.Close();
            return result;
        }


        //Lấy danh sách tất cả lớp học
        public static List<LopHocDTO> LayDanhSachTatCaLopHoc()
        {
            List<LopHocDTO> result = new List<LopHocDTO>();

            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("SELECT tblLopHoc.MaLop, tblLopHoc.TenLop, tblLopHoc.NgayBatDau, tblLopHoc.NgayKetThuc, tblLopHoc.SiSo, tblMonHoc.TenMonHoc, tblGiangVien.Ten  FROM tblLopHoc, tblMonHoc, tblGiangVien WHERE tblMonHoc.MaMonHoc = tblLopHoc.MaMonHoc and tblGiangVien.MaGiangVien = tblLopHoc.MaGiangVien", connection);
            result = ReadData(command);
            return result;
        }

        //Lấy danh sách lớp học vẩn đang còn học
        public static List<LopHocDTO> LayDanhSachLopHocDangHoc()
        {
            List<LopHocDTO> result = new List<LopHocDTO>();

            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("SELECT tblLopHoc.MaLop, tblLopHoc.TenLop, tblLopHoc.NgayBatDau, tblLopHoc.NgayKetThuc, tblLopHoc.SiSo, tblMonHoc.TenMonHoc, tblGiangVien.Ten FROM tblLopHoc, tblMonHoc, tblGiangVien WHERE tblGiangVien.MaGiangVien = tblLopHoc.MaGiangVien and tblMonHoc.MaMonHoc = tblLopHoc.MaMonHoc and tblLopHoc.NgayBatDau < GETDATE() and tblLopHoc.NgayKetThuc > GETDATE()", connection);
            result = ReadData(command);
            return result;
        }

        public static List<LopHocDTO> LayDanhSachLopHocChuaKhaiGiang()
        {
            List<LopHocDTO> result = new List<LopHocDTO>();

            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("SELECT tblLopHoc.MaLop, tblLopHoc.TenLop, tblLopHoc.NgayBatDau, tblLopHoc.NgayKetThuc, tblLopHoc.SiSo, tblMonHoc.TenMonHoc, tblGiangVien.Ten FROM tblLopHoc, tblMonHoc, tblGiangVien WHERE tblGiangVien.MaGiangVien = tblLopHoc.MaGiangVien and tblMonHoc.MaMonHoc = tblLopHoc.MaMonHoc and tblLopHoc.NgayBatDau > GETDATE()", connection);
            result = ReadData(command);
            return result;
        }

        public static List<LopHocDTO> LayDanhSachLopHocDaHocXong()
        {
            List<LopHocDTO> result = new List<LopHocDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("SELECT tblLopHoc.MaLop, tblLopHoc.TenLop, tblLopHoc.NgayBatDau, tblLopHoc.NgayKetThuc, tblLopHoc.SiSo, tblMonHoc.TenMonHoc, tblGiangVien.Ten FROM tblLopHoc, tblMonHoc, tblGiangVien WHERE tblGiangVien.MaGiangVien = tblLopHoc.MaGiangVien and tblMonHoc.MaMonHoc = tblLopHoc.MaMonHoc and tblLopHoc.NgayKetThuc < GETDATE()", connection);
            result = ReadData(command);
            return result;
        }

        public static List<LopHocDTO> LayDSlopTheoGiangVien(string maGV)
        {
            List<LopHocDTO> result = new List<LopHocDTO>();

            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("SELECT tblLopHoc.MaLop, tblLopHoc.TenLop, tblLopHoc.NgayBatDau, tblLopHoc.NgayKetThuc, tblLopHoc.SiSo, tblMonHoc.TenMonHoc, tblGiangVien.Ten FROM tblLopHoc, tblMonHoc, tblGiangVien WHERE tblGiangVien.MaGiangVien = tblLopHoc.MaGiangVien and tblMonHoc.MaMonHoc = tblLopHoc.MaMonHoc and tblLopHoc.NgayBatDau < GETDATE() and tblLopHoc.NgayKetThuc > GETDATE() and tblLopHoc.MaGiangVien = @MaGiangVien", connection);
            command.Parameters.Add("@MaGiangVien", System.Data.SqlDbType.NVarChar, 255, "MaGiangVien").Value = maGV;
            result = ReadData(command);
            return result;
        }
        

        public static List<LopHocDTO> LayDanhSachLopHocTheoSV(string maSV)
        {
            List<LopHocDTO> result = new List<LopHocDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("select distinct tblLopHoc.MaLop, tblLopHoc.TenLop, tblLopHoc.NgayBatDau, tblLopHoc.NgayKetThuc, tblLopHoc.SiSo, tblMonHoc.TenMonHoc, tblGiangVien.Ten from tblLopHoc, tblMonHoc, tblSinhVien, tblGiangVien where tblGiangVien.MaGiangVien = tblLopHoc.MaGiangVien and tblMonHoc.MaMonHoc = tblLopHoc.MaMonHoc and tblLopHoc.NgayBatDau > GETDATE() and tblMonHoc.MaNganh = tblSinhVien.MaNganh and CONVERT(int, ASCII(REVERSE(tblSinhVien.MaHe))) <= CONVERT(int, ASCII(REVERSE(tblMonHoc.MaHe))) and tblSinhVien.MaSV = @MaSV and tblMonHoc.MaMonHoc NOT IN(SELECT mh.MaMonHoc  FROM tblMonHoc mh INNER JOIN tblLopHoc lh ON mh.MaMonHoc = lh.MaMonHoc INNER JOIN tblDiemHocTap dh ON lh.MaLop = dh.MaLop  INNER JOIN tblSinhVien sv ON dh.MaSV = sv.MaSV WHERE sv.MaSV = @MaSV AND mh.MaNganh = sv.MaNganh and ((dh.DiemChuyenCan * 0.1 + dh.DiemTBKT * 0.4 + dh.DiemThi * 0.5 > 5) or dh.DiemChuyenCan * 0.1 + dh.DiemTBKT * 0.4 + dh.DiemThi * 0.5 = 0) and tblLopHoc.NgayBatDau > GETDATE()) ", connection);
            command.Parameters.Add("@MaSV", System.Data.SqlDbType.NVarChar, 255, "MaSV").Value = maSV;
            result = ReadData(command);
            return result;
        }

        public static bool ThemLopHoc(LopHocDTO lophocDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "INSERT INTO tblLopHoc(TenLop, NgayBatDau, NgayKetThuc, SiSo, MaMonHoc, MaGiangVien) VALUES(@TenLop, @NgayBatDau, @NgayKetThuc, @SiSo, @MaMonHoc, @MaGiangVien)";
            SqlCommand command = new SqlCommand(query, connection);
            //command.Parameters.Add("@MaLop", System.Data.SqlDbType.NVarChar, 255, "MaLop").Value = lophocDTO.MaLop;
            command.Parameters.Add("@TenLop", System.Data.SqlDbType.NVarChar, 255, "TenLop").Value = lophocDTO.TenLop;
            command.Parameters.Add("@NgayBatDau", System.Data.SqlDbType.Date, 50, "NgayBatDau").Value = Convert.ToDateTime(lophocDTO.NgayBatDau);
            command.Parameters.Add("@NgayKetThuc", System.Data.SqlDbType.Date, 50, "NgayKetThuc").Value = Convert.ToDateTime(lophocDTO.NgayKetThuc);
            command.Parameters.Add("@SiSo", System.Data.SqlDbType.Int, 0, "SiSo").Value = lophocDTO.SiSo;
            command.Parameters.Add("@MaMonHoc", System.Data.SqlDbType.Int, 0, "MaMonHoc").Value = lophocDTO.MaMon;
            command.Parameters.Add("@MaGiangVien", System.Data.SqlDbType.Int, 0, "MaGiangVien").Value = lophocDTO.MaGV;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }
        public static int KiemTraLopTonTai(string malop)
        {
            SqlConnection connection = DataProvider.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT CAST((select count(*) from tblLopHoc where MaLop=@MaLop) AS int)", connection);
            command.Parameters.Add("@MaLop", System.Data.SqlDbType.NVarChar, 255, "MaLop").Value = malop;
            return (int)command.ExecuteScalar();
            connection.Close();
        }

        public static List<LopHocDTO> TimLopTheoMaLop(string maLop)
        {
            List<LopHocDTO> result = new List<LopHocDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string Query;
            Query = "SELECT tblLopHoc.MaLop, tblLopHoc.TenLop, tblLopHoc.NgayBatDau, tblLopHoc.NgayKetThuc, tblLopHoc.SiSo, tblMonHoc.TenMonHoc, tblGiangVien.Ten FROM tblLopHoc, tblMonHoc, tblGiangVien WHERE tblMonHoc.MaMonHoc = tblLopHoc.MaMonHoc and tblLopHoc.MaLop = @MaSV and tblGiangVien.MaGiangVien = tblLopHoc.MaGiangVien";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.Add("@MaLop", System.Data.SqlDbType.Int, 0, "MaLop").Value = maLop;
            result = ReadData(command);
            return result;
        }

        public static List<LopHocDTO> TimKiemLopHoc(string maMon)
        {
            List<LopHocDTO> result = new List<LopHocDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string Query;
            Query = "SELECT tblLopHoc.MaLop, tblLopHoc.TenLop, tblLopHoc.NgayBatDau, tblLopHoc.NgayKetThuc, tblLopHoc.SiSo, tblMonHoc.TenMonHoc, tblGiangVien.Ten FROM tblLopHoc, tblMonHoc, tblGiangVien WHERE tblMonHoc.MaMonHoc = tblLopHoc.MaMonHoc and tblMonHoc.MaMonHoc = @MaMon and tblGiangVien.MaGiangVien = tblLopHoc.MaGiangVien";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.Add("@MaMon", System.Data.SqlDbType.Int, 0, "MaMon").Value = maMon;
            result = ReadData(command);
            return result;
        }

        public static int KiemTraLopTrung(DateTime ngaybatdau, string mamon)
        {
            SqlConnection connection = DataProvider.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select CAST((select COUNT(*) from tblLopHoc where tblLopHoc.NgayBatDau <= @NgayBatDau and @NgayBatDau <= tblLopHoc.NgayKetThuc and tblLopHoc.MaMonHoc = @MaMonHoc) as int)", connection);
            command.Parameters.Add("@NgayBatDau", System.Data.SqlDbType.Date, 50, "NgayBatDau").Value = ngaybatdau;
            command.Parameters.Add("@MaMonHoc", System.Data.SqlDbType.NVarChar, 255, "MaMonHoc").Value = mamon;
            return (int)command.ExecuteScalar();
            connection.Close();
        }

        public static bool CapNhatLopHoc(LopHocDTO lophocDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            string query = "UPDATE [dbQuanLySinhVien].[dbo].[tblLopHoc] SET [TenLop] = @TenLop,[NgayBatDau]=@NgayBatDau, [NgayKetThuc] = @NgayKetThuc ,[SiSo] = @SiSo ,[MaMonHoc] = @MaMonHoc, [MaGiangVien] = @MaGiangVien WHERE [MaLop]= @MaLop";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@MaLop", System.Data.SqlDbType.Int, 0, "MaLop").Value = lophocDTO.MaLop;
            command.Parameters.Add("@TenLop", System.Data.SqlDbType.NVarChar, 255, "TenLop").Value = lophocDTO.TenLop;
            command.Parameters.Add("@NgayBatDau", System.Data.SqlDbType.Date, 50, "NgayBatDau").Value = Convert.ToDateTime(lophocDTO.NgayBatDau);
            command.Parameters.Add("@NgayKetThuc", System.Data.SqlDbType.Date, 50, "NgayKetThuc").Value = Convert.ToDateTime(lophocDTO.NgayKetThuc);
            command.Parameters.Add("@SiSo", System.Data.SqlDbType.Int, 5, "SiSo").Value = lophocDTO.SiSo;
            command.Parameters.Add("@MaMonHoc", System.Data.SqlDbType.Int, 0, "MaMonHoc").Value = lophocDTO.MaMon;
            command.Parameters.Add("@MaGiangVien", System.Data.SqlDbType.Int, 0, "MaGiangVien").Value = lophocDTO.MaGV;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();

        }

        //public static bool XoaLopHoc(string maMon)
        //{
        //    SqlConnection connection = DataProvider.GetConnection();

        //    string query = "UPDATE [dbQLSV].[dbo].[tblMonHoc] SET TrangThai=@trangThai  WHERE MaMonHoc=@maMonHoc";
        //    //string query = "DELETE FROM tblMonHoc WHERE MaMonHoc = @maMonHoc";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.Add("@maMonHoc", System.Data.SqlDbType.NVarChar, 255, "MaMonHoc").Value = maMon;
        //    command.Parameters.Add("@trangThai", System.Data.SqlDbType.Bit, 2, "TrangThai").Value = false;
        //    connection.Open();
        //    return command.ExecuteNonQuery() > 0;
        //    connection.Close();
        //}
    }
}
