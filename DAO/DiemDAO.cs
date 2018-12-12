using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class DiemDAO
    {
        public static List<DiemDTO> ReadData(SqlCommand command)
        {
            List<DiemDTO> result = new List<DiemDTO>();
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DiemDTO diem = new DiemDTO();
                    diem.MaLop = reader.GetString(0);
                    diem.TenSV = reader.GetString(1);
                    diem.MaSV = reader.GetString(2);
                    diem.DiemChuyenCan = reader.GetDouble(3);
                    diem.DiemTBKT = reader.GetDouble(4);
                    diem.DiemThi = reader.GetDouble(5);
                    result.Add(diem);
                }
            }
            command.Connection.Close();
            return result;
        }

        public static List<DiemDTO> Readdata(SqlCommand command)
        {
            List<DiemDTO> result = new List<DiemDTO>();
            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DiemDTO diem = new DiemDTO();
                    diem.MaLop = reader.GetString(0);
                    //diem.MaSV = reader.GetString(1);
                    diem.DiemChuyenCan = reader.GetDouble(1);
                    diem.DiemTBKT = reader.GetDouble(2);
                    diem.DiemThi = reader.GetDouble(3);
                    result.Add(diem);
                }
            }
            command.Connection.Close();
            return result;
        }

        public static int KiemTraThemSinhVienVaoDSDiem(DiemDTO diemDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT CAST((SELECT COUNT(*) FROM tblDiemHocTap WHERE MaSV = @MaSV and MaLop = @MaLop) AS int)", connection);
            command.Parameters.Add("@MaSV", System.Data.SqlDbType.NVarChar, 255, "MaSV").Value = diemDTO.MaSV;
            command.Parameters.Add("@MaLop", System.Data.SqlDbType.NVarChar, 255, "MaLop").Value = diemDTO.MaLop;
            return (int)command.ExecuteScalar();
            connection.Close();
        }

        public static bool ThemSinhVienVaoDSDiem(DiemDTO diemDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO tblDiemHocTap(MaLop, MaSV, DiemChuyenCan, DiemTBKT, DiemThi) VALUES(@MaLop, @MaSV, @DiemChuyenCan, @DiemTBKT, @DiemThi)", connection);
            command.Parameters.Add("@MaLop", System.Data.SqlDbType.NVarChar, 255, "MaLop").Value = diemDTO.MaLop;
            command.Parameters.Add("@MaSV", System.Data.SqlDbType.NVarChar, 255, "MaSV").Value = diemDTO.MaSV;
            command.Parameters.Add("@DiemChuyenCan", System.Data.SqlDbType.Float, 0, "DiemChuyenCan").Value = diemDTO.DiemChuyenCan;
            command.Parameters.Add("@DiemTBKT", System.Data.SqlDbType.Float, 0, "DiemTBKT").Value = diemDTO.DiemTBKT;
            command.Parameters.Add("@DiemThi", System.Data.SqlDbType.Float, 0, "MaLop").Value = diemDTO.DiemThi;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }

        public static List<DiemDTO> LayDanhSachDiem()
        {
            List<DiemDTO> result = new List<DiemDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string query = "select tblLopHoc.TenLop, tblSinhVien.Ho, tblSinhVien.Ten ,tblDiemHocTap.DiemChuyenCan,tblDiemHocTap.DiemTBKT,tblDiemHocTap.DiemThi from tblDiemHocTap, tblLopHoc, tblSinhVien where tblSinhVien.MaSV = tblDiemHocTap.MaSV and tblLopHoc.MaLop = tblDiemHocTap.MaLop";
            SqlCommand command = new SqlCommand(query, connection);
            result = ReadData(command);
            return result;
        }

        public static List<DiemDTO> LayDanhSachDiemSVTheoLop(string malop)
        {
            List<DiemDTO> result = new List<DiemDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string query = "select lh.TenLop,sv.Ho, sv.Ten,dht.DiemChuyenCan,dht.DiemTBKT,dht.DiemThi from tblDiemHocTap dht, tblLopHoc lh, tblSinhVien sv where dht.MaSV = sv.MaSV and dht.MaLop = lh.MaLop and lh.MaLop = @MaLop";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@MaLop", System.Data.SqlDbType.NVarChar, 255, "MaLop").Value = malop;
            result = ReadData(command);
            return result;
        }

        public static List<DiemDTO> LayDanhSachDiemTheoSV(string maSV)
        {
            List<DiemDTO> result = new List<DiemDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string query = "select tblMonHoc.TenMonHoc, tblDiemHocTap.DiemChuyenCan, tblDiemHocTap.DiemTBKT, tblDiemHocTap.DiemThi from tblDiemHocTap, tblLopHoc, tblSinhVien, tblMonHoc where tblDiemHocTap.MaSV = tblSinhVien.MaSV and tblDiemHocTap.MaLop = tblLopHoc.MaLop and tblLopHoc.MaMonHoc = tblMonHoc.MaMonHoc and tblSinhVien.MaSV = @MaSV and tblSinhVien.MaNganh = tblMonHoc.MaNganh and CONVERT(int, ASCII(REVERSE(tblSinhVien.MaHe))) <= CONVERT(int, ASCII(REVERSE(tblMonHoc.MaHe)))";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@MaSV", System.Data.SqlDbType.NVarChar, 255, "MaSV").Value = maSV;
            result = Readdata(command);
            return result;
        }

        public static bool CapNhatDiem(DiemDTO diemDTO)
        {
            SqlConnection connection = DataProvider.GetConnection();
            SqlCommand command = new SqlCommand("UPDATE [dbQuanLySinhVien].[dbo].[tblDiemHocTap] SET [DiemChuyenCan] = @DiemChuyenCan, [DiemTBKT] = @DiemTBKT ,[DiemThi] = @DiemThi, [DiemTongKet] = @DiemTong  WHERE [MaSV]= @MaSV and [MaLop] = @MaLop", connection);
            command.Parameters.Add("@MaLop", System.Data.SqlDbType.NVarChar, 255, "MaLop").Value = diemDTO.MaLop;
            command.Parameters.Add("@MaSV", System.Data.SqlDbType.NVarChar, 255, "MaSV").Value = diemDTO.MaSV;
            command.Parameters.Add("@DiemChuyenCan", System.Data.SqlDbType.Float, 0, "DiemChuyenCan").Value =diemDTO.DiemChuyenCan;
            command.Parameters.Add("@DiemTBKT", System.Data.SqlDbType.Float, 0, "DiemTBKT").Value = diemDTO.DiemTBKT;
            command.Parameters.Add("@DiemThi", System.Data.SqlDbType.Float, 0, "DiemThi").Value = diemDTO.DiemThi;
            command.Parameters.Add("@DiemTong", System.Data.SqlDbType.Float, 0, "DiemTong").Value = diemDTO.DiemTong;
            connection.Open();
            return command.ExecuteNonQuery() > 0;
            connection.Close();
        }

        public static List<DiemDTO> LayDanhSachLop()
        {
            List<DiemDTO> result = new List<DiemDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string query = "select * from tblDiemHocTap";
            SqlCommand command = new SqlCommand(query, connection);
            result = ReadData(command);
            return result;
        }

        public static List<DiemDTO> Timkiemsinhvien(string TenSV, string Nganh, string He)
        {
            List<DiemDTO> result = new List<DiemDTO>();
            SqlConnection connection = DataProvider.GetConnection();
            string Query;
            Query = "select lh.TenLop ,sv.Ho, sv.Ten,dht.DiemChuyenCan,dht.DiemTBKT,dht.DiemThi from tblDiemHocTap dht, tblLopHoc lh, tblSinhVien sv where dht.MaSV = sv.MaSV and dht.MaLop = lh.MaLop and sv.MaSV = dht.MaSV ";
            if (TenSV != "")
                Query = Query + " and sv.Ten like N'%'+@Ten+'%' ";
            if (Nganh != "0")
                Query = Query + " and sv.MaNganh like N'%'+@MaNganh+'%' ";
            if (He != "0")
                Query = Query + " and sv.MaHe like N'%'+@MaHe+'%' ";
            SqlCommand command = new SqlCommand(Query, connection);
            if (TenSV != null || TenSV != "")
                command.Parameters.Add("@Ten", System.Data.SqlDbType.NVarChar, 255, "Ten").Value = TenSV;
            if (Nganh != "0")
                command.Parameters.Add("@MaNganh ", System.Data.SqlDbType.NVarChar, 255, "MaNganh").Value = Nganh;
            if (He != "0")
                command.Parameters.Add("@MaHe", System.Data.SqlDbType.NVarChar, 255, "MaHe").Value = He;
            result = ReadData(command);
            return result;
        }
    }
}
