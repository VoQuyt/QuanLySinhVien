CREATE DATABASE dbQuanLySinhVien;
GO

USE dbQuanLySinhVien;
GO

---CREATE TABLE---
---CREATE TABLE TINH TRANG---
CREATE TABLE tblTinhTrang(
	Id int primary key not null IDENTITY(1,1),
	TinhTrang nvarchar(50)
)
Go	
---CREATE TABLE SINH VIEN --- 
CREATE TABLE tblSinhVien(
	MaSV int PRIMARY KEY NOT NULL IDENTITY(1,1),
	Ho nvarchar(30) NOT NULL,
	Ten nvarchar(30)NOT NULL,
	GioiTinh bit,
	NoiSinh nvarchar(50),
	NgaySinh date,
	MaNganh int,
	MaHe int,
	TinhTrang_Id int,
	NienKhoa int
);

---CREATE TABLE DANG KY---------
CREATE TABLE tblDangKy(
	MaLop int NOT NULL,
	MaSV int NOT NULL,
	NgayDangKi date,
	TrangThai bit,
	Primary key (MaLop, MaSV),
);
GO

---CREATE TABLE MON HOC-------
CREATE TABLE tblMonHoc(
	MaMonHoc int PRIMARY KEY NOT NULL IDENTITY(1,1),
	TenMonHoc nvarchar(50),
	SoTinChi int,
	MaNganh int,
	MaHe int,
	TrangThai bit,
);
GO

----CREATE TABLE LOP HOC --------
CREATE TABLE tblLopHoc(
	MaLop int PRIMARY KEY NOT NULL IDENTITY(1,1),	
	TenLop nvarchar(60),
	NgayBatDau date,
	NgayKetThuc date,
	SiSo int,---SO LUONG SINH VIEN
	MaMonHoc int,
	MaGiangVien int,
);
GO

---CREATE TABLE GIANG VIEN---------
CREATE TABLE tblGiangVien(
	MaGiangVien int PRIMARY KEY NOT NULL IDENTITY(1,1),
	HoLot nvarchar(30),
	Ten nvarchar(30),
	NgaySinh date,
	GioiTinh bit,
    NoiSinh nvarchar(30),
	SĐT varchar(10),
	Email nvarchar(50),
	HocVi nvarchar(30),
	TinhTrang bit,
	MaNganh int
);
GO

----CREATE TABLE DIEM HOC TAP--------
CREATE TABLE tblDiemHocTap(
	MaLop int NOT NULL,
	MaSV int  NOT NULL,
	DiemChuyenCan float,--DIEM CHUYEN CAN
	DiemTBKT float,--DIEM TRUNG BINH KIEM TRA
	DiemThi float,--DIEM THI
	DiemTongKet float,
	Primary key (MaLop,MaSV)
);
GO


---CREATE TABLE NGANH HOC -------------
CREATE TABLE tblNganh(
	MaNganh int PRIMARY KEY NOT NULL IDENTITY(1,1),
	TenNganh nvarchar(50),
	TrangThai bit,
);
GO
 ---CREATE TABLE HE DAO TAO----
 CREATE TABLE tblHeDaoTao(
	MaHe int  PRIMARY KEY NOT NULL IDENTITY(1,1),
	TenHe nvarchar(50),
	TrangThai bit,	
 );
GO
 
 ---CREATE TABLE TAI KHOAN----
 CREATE TABLE tblTaiKhoan(
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TenTaiKhoan varchar(10) ,
	MatKhau varchar(10),
	PhanQuyen int,
	TrangThai bit,	
 );
 GO 
 
--GiaoVien->nganh 
ALTER TABLE tblGiangVien
ADD FOREIGN KEY (MaNganh) 
REFERENCES tblNganh(MaNganh);
GO

--LOP HOC -> GIANG VIEN
ALTER TABLE tblLopHoc
ADD FOREIGN KEY (MaGiangVien) 
REFERENCES tblGiangVien(MaGiangVien);
GO
 
 ---LIEN KET KHOA NGOAI
--SINH VIEN->TINH TRANG
ALTER TABLE tblSinhVien
ADD FOREIGN KEY (TinhTrang_Id) 
REFERENCES tblTinhTrang(Id);
GO

 ---LIEN KET KHOA NGOAI
--SINH VIEN -> NGANH HOC 
ALTER TABLE tblSinhVien
ADD FOREIGN KEY (MaNganh) 
REFERENCES tblNganh(MaNganh);
GO

--SINH VIEN -> HE DAO TAO
ALTER TABLE tblSinhVien
ADD FOREIGN KEY (MaHe) 
REFERENCES tblHeDaoTao(MaHe);
GO

--MON HOC -> NGANH HOC 
ALTER TABLE tblMonHoc
ADD FOREIGN KEY (MaNganh) 
REFERENCES tblNganh(MaNganh);
GO

--MON HOC -> HE DAO TAO 
ALTER TABLE tblMonHoc
ADD FOREIGN KEY (MaHe) 
REFERENCES tblHeDaoTao(MaHe);
GO

--DANG KI -> SINH VIEN
ALTER TABLE tblDangKy
ADD FOREIGN KEY (MaSV) 
REFERENCES tblSinhVien(MaSV);
GO

--DANG KY -> LOP HOC
ALTER TABLE tblDangKy
ADD FOREIGN KEY (MaLop) 
REFERENCES tblLopHoc(MaLop);
GO

--LOP HOC -> MON HOC
ALTER TABLE tblLopHoc
ADD FOREIGN KEY (MaMonHoc) 
REFERENCES tblMonHoc(MaMonHoc); 
GO


--DIEM HOC TAP -> SINH VIEN
ALTER TABLE tblDiemHocTap
ADD FOREIGN KEY (MaSV) 
REFERENCES tblSinhVien(MaSV);
GO

--DIEM HOC TAP -> LOP HOC
ALTER TABLE tblDiemHocTap
ADD FOREIGN KEY (MaLop) 
REFERENCES tblLopHoc(MaLop);
GO

--ALTER TABLE tblGiangVien
--ADD FOREIGN KEY (Nganh) 
--REFERENCES tblNganh(MaNganh);
--GO


