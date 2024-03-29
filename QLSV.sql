--tblTAIKHOAN
insert into tblTaiKhoan(TenTaiKhoan,MatKhau,PhanQuyen,TrangThai) values
('admin','123456',1,1),
('user','123456',2,1)
go
--tblHE
insert into tblHeDaoTao(TenHe, TrangThai) values
(N'Đại học chính quy',1),
(N'Cao đẳng chính quy',1),
(N'Trung cấp chuyên nghiệp',1)
go
--tblNGANH
Insert Into tblNganh(TenNganh,TrangThai) values
(N'Kỹ Thuật Ô Tô',1),
(N'Công Nghệ Thông Tin',1),
(N'Kế Toán Tài Chính',1)
go
---tblTINH TRANG---
Insert Into tblTinhTrang(TinhTrang) values
(N'Đang Học'),
(N'Bảo Lưu'),
(N'Đã Tốt Nghiệp'),
(N'Bị Đuổi Học')
go
--tblMONHOC
insert into tblMonHoc(TenMonHoc,SoTinChi, TrangThai, MaNganh ,MaHe) values
(N'Toán Rời Rạc'	  ,5,1,2,3),
(N'Mạng Máy Tính'	  ,3,1,2,3),
(N'Kỹ Thuật Lập Trình',4,1,2,3),
(N'Hệ Điều Hành'	  ,3,1,2,3),
(N'Cơ Sỡ Dữ Liệu'	  ,5,1,2,1),
(N'Hệ Thống Thông Tin',4,1,2,2),
(N'Trí Tuệ Nhân Tạo'  ,3,1,2,1),

(N'Lý Thuyết ôtô'	   ,3,1,1,3),
(N'Động Cơ Đốt Trong'  ,6,1,1,2),
(N'Kiểm Định Chẩn Đoán',5,1,1,2),
(N'Thiết Kế Ôtô'	   ,5,1,1,1),
(N'Hệ Thống Điều Hòa'  ,3,1,1,3),
(N'Nhiên Liệu Dầu Mỡ'  ,5,1,1,3),
(N'Sửa Chửa Bảo Dưởng' ,5,1,1,3),

(N'Kinh Tế Vĩ Mô'	 ,3,1,3,3),
(N'Kế Toán Tài Chính',6,1,3,3),
(N'Thuế'			 ,5,1,3,2),
(N'Luật Kế Toán'	 ,5,1,3,1),
(N'Nguyên Lý Kế Toán',3,1,3,3),
(N'Kinh Tế Lượng'	 ,5,1,3,3),
(N'Kế Toán Quản Trị' ,5,1,3,3)
go

--tblGIANGVIEN
insert into tblGiangVien(HoLot,Ten,NgaySinh,GioiTinh,NoiSinh,SĐT,Email,HocVi,TinhTrang,MaNganh) values
(N'Nguyễn Quốc'  ,N'Văn'    ,'1977-12-12',0,N'Bình Định' ,'0371234567','nqvan@caothang.edu.vn'        ,N'Tiễn sĩ',1,1),
(N'Nguyễn Văn'   ,N'Vũ'     ,'1988-01-17',0,N'TP HCM'    ,'0330684567','nvvu@caothang.edu.vn'         ,N'Thạc sĩ',1,1),
(N'Nguyễn Văn'   ,N'Thông'  ,'1970-04-30',0,N'Hà Nội'    ,'0362344654','nvthong@caothang.edu.vn'      ,N'Tiễn sĩ',1,1),
(N'Đỗ Đức'       ,N'Tuấn'   ,'1975-06-25',0,N'Tiền Giang','0979034560','doductuan26@gmail.com'        ,N'Tiễn sĩ',1,1),
(N'Hồ Văn'       ,N'Thới'   ,'1990-05-15',0,N'Hà Nội'    ,'0862457905','hovanthoi76@gmail.com'        ,N'Thạc sĩ',1,1),

(N'Lưu Văn'      ,N'Đại'    ,'1990-05-27',0,N'Hà Nam'    ,'0350696969','vandai@outlook.com'           ,N'Thạc sĩ',1,2),
(N'Huỳnh Thanh'  ,N'Hòa'    ,'1980-09-30',1,N'Đà Nẵng'   ,'0380796540','hoa4414@gmail.com'            ,N'Thạc sĩ',1,2),      
(N'Thái Ngọc Anh',N'Khôi'   ,'1970-11-12',0,N'Nha Trang' ,'0969045405','tnak1988@gmail.com'           ,N'Tiễn sĩ',1,2),
(N'Vũ Phương'    ,N'Thảo'   ,'1990-10-20',1,N'Hậu Giang' ,'0376942140','phuongthaodv@gmail.com'       ,N'Thạc sĩ',1,2),
(N'Nguyễn Ngọc'  ,N'Tùng'   ,'1960-07-10',0,N'Bến Tre'   ,'0389045405','ngoctung2008@gmail.com'       ,N'Tiễn sĩ',1,2),

(N'Huỳnh Xuân'   ,N'Dũng'   ,'1988-07-26',0,N'Quảng Trị' ,'0700596943','dunghx@caothang.edu.vn'       ,N'Thạc sĩ',1,3),
(N'Nguyễn Văn'   ,N'Toàn'   ,'1970-06-24',0,N'Huế'       ,'0456945867','nguyenvantoan@caothang.edu.vn',N'Tiễn sĩ',1,3),
(N'Ngô Ngọc'     ,N'Tuyên'  ,'1981-03-25',1,N'Tiền Giang','0568794867','ngongoctuyen@caothang.edu.vn' ,N'Thạc sĩ',1,3),
(N'Nguyễn Thiện' ,N'Thông'  ,'1985-10-10',1,N'Lâm Đồng'  ,'0382106790','ngthienthong@gmail.com'       ,N'Thạc sĩ',1,3),
(N'Phạm Văn'     ,N'Mạnh'   ,'1975-11-27',1,N'TP HCM'    ,'0344563450','pvmanhspkt@gmail.com'         ,N'Tiến sĩ',1,3)

go
--tblLOPHOC
insert into tblLopHoc(TenLop,NgayBatDau,NgayKetThuc,SiSo,MaMonHoc,MaGiangVien) values
('CNTT1' ,'12-12-2012','12-12-2012',30,1,7),
('CNTT2' ,'12-12-2012','12-12-2012',30,5,8),
('CNTT3' ,'12-12-2012','12-12-2012',30,6,10),

('OTO1' ,'12-12-2012','12-12-2012',30,8,3),
('OTO2' ,'12-12-2012','12-12-2012',30,9,5),
('OTO3' ,'12-12-2012','12-12-2012',30,11,2),

('KT1'  ,'12-12-2012','12-12-2012',30,15,13),
('KT2'  ,'12-12-2012','12-12-2012',30,16,15),
('KT3'  ,'12-12-2012','12-12-2012',30,18,11),

('CNTT4','12-12-2012','12-12-2012',30,7,8),
('CNTT5','12-12-2012','12-12-2012',30,2,6),
('CNTT6','12-12-2012','12-12-2012',30,3,9),
('CNTT7','12-12-2012','12-12-2012',30,4,10),

('OTO4' ,'12-12-2012','12-12-2012',30,12,1),
('OTO5' ,'12-12-2012','12-12-2012',30,10,4),
('OTO6' ,'12-12-2012','12-12-2012',30,13,2),
('OTO7' ,'12-12-2012','12-12-2012',30,14,3),

('KT4'  ,'12-12-2012','12-12-2012',30,17,13),
('KT5'  ,'12-12-2012','12-12-2012',30,19,15),
('KT6'  ,'12-12-2012','12-12-2012',30,20,11),
('KT7'  ,'12-12-2012','12-12-2012',30,21,14)
go

--tblSINHVIEN
insert into tblSinhVien(Ho,Ten,GioiTinh,NoiSinh,NgaySinh,MaNganh,MaHe,TinhTrang_Id,NienKhoa) values
(N'Nguyễn Đức Công',N'Kiệt'   ,0, N'Vũng Tàu'  ,'1997-02-02',1,1,1,2013),
(N'Đoàn Ngọc'      ,N'Long'   ,0, N'Quảng Ngãi','1997-10-30',2,1,1,2014),
(N'Trần Như Gia'   ,N'Bảo'    ,0, N'Bình Dương','1997-02-24',3,1,1,2015),
(N'Nguyễn Tấn'     ,N'Liêm'   ,0, N'Long An'   ,'1996-06-06',2,1,1,2016),
(N'Nguyễn Minh'    ,N'Nhân'   ,0, N'TP. HCM'   ,'1997-02-24',1,1,1,2013),
(N'Nguyễn Quốc'    ,N'Toản'   ,0, N'Vũng Tàu'  ,'1997-04-07',3,2,1,2014),
(N'Mai Thị Thúy'   ,N'An'     ,1, N'Long An'   ,'1997-10-04',2,2,1,2015),
(N'Lê Vinh'        ,N'Định'   ,0, N'Quảng Ngãi','1997-09-09',2,2,1,2016),
(N'Bùi Quốc'       ,N'Khánh'  ,0, N'Bến Tre'   ,'1997-04-09',2,2,1,2013),
(N'Nguyễn Quốc'    ,N'Thái'   ,0, N'Đồng Tháp' ,'1997-05-29',3,2,1,2014),

(N'Nguyễn Anh'     ,N'Tuấn'   ,0, N'Đồng Nai'  ,'1997-06-15',1,3,1,2015),
(N'Phan Nguyễn Anh',N'Tú'     ,0, N'TP. HCM'   ,'1997-11-17',3,1,1,2016),
(N'Nguyễn Bình'    ,N'Điền'   ,0, N'Đắk Lắk'   ,'1998-08-15',2,3,1,2013),
(N'Lê Thân Trần'   ,N'Đủ'     ,0, N'Long An'   ,'1998-08-21',1,3,1,2014),
(N'Lữ Anh'         ,N'Phong'  ,0, N'Quảng Ngãi','1998-05-30',3,3,1,2015),
(N'Nguyễn Xuân'    ,N'Phúc'   ,0, N'Quảng Ngãi','1998-10-29',2,1,1,2016),
(N'Nguyễn'         ,N'Sáng'   ,0, N'Ninh Thuận','1998-04-16',1,1,1,2013),
(N'Vũ Bình'        ,N'Yên'    ,0, N'Đồng Nai'  ,'1998-10-02',2,1,1,2014),
(N'Liêu Hoàng'     ,N'Chương' ,0, N'Bến Tre'   ,'1998-11-18',1,1,1,2015),
(N'Bạch Ngọc Tuấn' ,N'Cường'  ,0, N'Long An'   ,'1998-11-14',3,1,1,2016),

(N'Phạm Viết'      ,N'Duy'    ,0, N'Quảng Ngãi','1998-06-25',1,2,1,2013),
(N'Võ Trường'      ,N'Giang'  ,0, N'Bến Tre'   ,'1998-03-28',2,2,1,2014),
(N'Vũ Hoàng Minh'  ,N'Hiếu'   ,0, N'Vũng Tàu'  ,'1998-07-02',2,2,1,2015),
(N'Lê Minh'        ,N'Hiệp'   ,0, N'Long An'   ,'1998-04-19',3,2,1,2016),
(N'Đặng Duy'       ,N'Hưng'   ,0, N'Bến Tre'   ,'1998-05-08',2,2,1,2013),
(N'Nguyễn Minh'    ,N'Hưng'   ,0, N'TP. HCM'   ,'1998-06-20',1,3,1,2014),
(N'Hồ Duy'         ,N'Khang'  ,0, N'Tây Ninh'  ,'1998-01-02',2,3,1,2015),
(N'Nguyễn Đậu Vũ'  ,N'Kiệt'   ,0, N'Bến Tre'   ,'1998-03-16',3,3,1,2016),
(N'Nguyễn Thành'   ,N'Long'   ,0, N'An Giang'  ,'1998-12-06',3,3,1,2013),
(N'Nguyễn Văn'     ,N'Nam'    ,0, N'Quảng Ngãi','1998-02-12',3,3,1,2014),

(N'Nguyễn Minh'    ,N'Ngân'    ,1, N'An Giang'  ,'1998-09-19',2,1,1,2015),
(N'Bá Hoài'        ,N'Sơn'     ,0, N'Ninh Thuận','1997-11-20',2,1,1,2016),
(N'Trịnh Minh'     ,N'Tân'     ,0, N'Bình Định' ,'1997-12-24',1,1,1,2013),
(N'Nguyễn Xuân'    ,N'Thịnh'   ,0, N'TP. HCM'   ,'1998-03-02',3,1,1,2014),
(N'Nguyễn Hùng'    ,N'Thuận'   ,0, N'Long An'   ,'1998-11-06',2,1,1,2015),
(N'Nguyễn Hữu'     ,N'Thường'  ,0, N'Long An'   ,'1998-12-04',1,2,1,2016),
(N'Trần Khánh'     ,N'Trung'   ,0, N'TP. HCM'   ,'1998-09-24',1,2,1,2013),
(N'Nguyễn Thành'   ,N'Đạt'     ,0, N'TP. HCM'   ,'1997-08-25',2,2,1,2014),
(N'Đặng Trí'       ,N'Hải'     ,0, N'TP. HCM'   ,'1998-06-04',3,2,1,2015),
(N'Phạm Trần Phi'  ,N'Lâm'     ,0, N'TP. HCM'   ,'1998-04-08',2,2,1,2016),

(N'Nguyễn Trần Trọng' ,N'Lễ'   ,0, N'Tiền Giang','1998-08-03',3,2,1,2013),
(N'Huỳnh Đỗ'          ,N'Lộc'  ,0, N'An Giang'  ,'1998-08-18',1,3,1,2014),
(N'Lê Minh'           ,N'Nhựt' ,0, N'Tiền Giang','1998-09-25',3,3,1,2015),
(N'Nguyễn Minh'       ,N'Quang',0, N'Long An'   ,'1998-02-23',2,3,1,2016),
(N'Trần Đức'          ,N'Thành',0, N'Quảng Bình','1998-06-12',2,3,1,2013),
(N'Nguyễn Ngọc'       ,N'Thịnh',0, N'TP. HCM'   ,'1998-03-12',1,3,1,2014),
(N'Võ Trần'           ,N'Trí'  ,0, N'Bình Thuận','1998-06-04',2,1,1,2015),
(N'Nguyễn Phương'     ,N'Duy'  ,0, N'Long An'   ,'1998-01-06',3,1,1,2016),
(N'Lê Văn'            ,N'Đại'  ,0, N'Đắk Lắk'   ,'1998-10-09',1,1,1,2013),
(N'Đặng Minh'         ,N'Hoàng',0, N'Bình Thuận','1998-01-05',2,1,1,2014),

(N'Phan Bá Hoàng'      ,N'Lộc' ,0, N'Khánh Hòa' ,'1998-02-22',1,1,1,2015),
(N'Huỳnh Công Tôn Khải',N'Minh',0, N'Vũng Tàu'  ,'1998-12-17',3,2,1,2016),
(N'Nguyễn Xuân'        ,N'Nam' ,0, N'Lâm Đồng'  ,'1998-09-14',1,2,1,2013),
(N'Trần Trọng'         ,N'Nghĩa',0, N'Tiền Giang','1998-02-02',2,2,1,2014),
(N'Nguyễn Trọng'       ,N'Nhân',0, N'Đắk Lắk'   ,'1997-04-02',3,2,1,2015),
(N'Lê Trọng'           ,N'Quỳnh',0, N'Thanh Hóa','1998-09-16',2,2,1,2016),
(N'Nguyễn Chấn'        ,N'Tây'  ,0, N'Đồng Tháp','1998-08-29',1,3,1,2013),
(N'Nguyễn Đức'         ,N'Thành',0, N'Tiền Giang','1998-04-09',2,3,1,2014),
(N'Trần Văn'           ,N'Thê'  ,0, N'Sóc Trăng','1997-02-12',3,3,1,2015),
(N'Hồ Hoài'            ,N'Thiên',0, N'Bến Tre'  ,'1998-06-04',1,3,1,2016),

(N'Dương Minh'         ,N'Trí' ,0, N'Lâm Đồng'  ,'1998-05-20',3,3,1,2013),
(N'Phan Xuân'          ,N'Hiếu',0, N'Hà Tĩnh'   ,'1996-07-08',2,1,1,2014),
(N'Phạm Hoàng'         ,N'Minh',0, N'Đồng Nai'  ,'1997-10-25',2,1,1,2015),
(N'Nguyễn Hoàn'        ,N'Bảo' ,0, N'Tây Ninh'  ,'1998-06-28',3,1,1,2016),
(N'Trần Thị Mộng'      ,N'Cầm' ,1, N'Long An'   ,'1998-03-19',1,1,1,2013),
(N'Nguyễn Mạnh'        ,N'Cường',0, N'TP. HCM'  ,'1997-07-29',3,1,1,2014),
(N'Nguyễn Tuấn'        ,N'Cường',0, N'TP. HCM'  ,'1998-03-23',2,2,1,2015),
(N'Tạ Quốc'            ,N'Đạt'  ,0, N'Tiền Giang','1998-01-08',1,2,1,2016),
(N'Trần Tiến'          ,N'Đạt'  ,0, N'Trà Vinh' ,'1998-11-04',3,2,1,2013),
(N'Nguyễn Hữu'         ,N'Đăng' ,0, N'Đồng Tháp','1998-06-01',1,2,1,2014),

(N'Hồ Minh'            ,N'Đường',0, N'Long An'  ,'1998-10-13',2,2,1,2015),
(N'Lê Tấn'             ,N'Hải'  ,0, N'Long An'  ,'1998-01-29',3,3,1,2016),
(N'Lê Hoài'            ,N'Hậu'  ,0, N'An Giang' ,'1998-11-30',2,3,1,2013),
(N'Trần Minh'          ,N'Hiền' ,0, N'Đồng Nai' ,'1998-04-13',1,3,1,2014),
(N'Nguyễn Trung'       ,N'Hiếu' ,0, N'TP. HCM'  ,'1998-05-19',3,3,1,2015),
(N'Nguyễn Văn'         ,N'Hiếu' ,0, N'Lâm Đồng' ,'1998-11-29',2,3,1,2016),
(N'Trần Chí'           ,N'Hiếu' ,0, N'Tiền Giang','1998-06-18',1,1,1,2013),
(N'Châu Thế'           ,N'Hoàng',0, N'Ninh Thuận','1998-12-31',3,1,1,2014),
(N'Phạm Việt'          ,N'Hoàng',0, N'Đồng Nai' ,'1998-08-24',1,1,1,2015),
(N'Hồ Nhật'            ,N'Hòa'  ,0, N'TP. HCM'  ,'1998-11-15',2,1,1,2016),

(N'Nguyễn Thế'         ,N'Hòa',0, N'Bình Thuận'  ,'1998-04-26',1,1,1,2013),
(N'Đỗ Nguyễn Viết'     ,N'Khang',0, N'TP. HCM'   ,'1998-08-15',3,2,1,2014),
(N'Võ Duy'             ,N'Khánh',0, N'Tiền Giang','1997-06-20',1,2,1,2015),
(N'Trần Gia'           ,N'Khiêm',0, N'TP. HCM'   ,'1998-03-01',2,2,1,2016),
(N'Bùi Bảo'            ,N'Linh' ,0, N'Long An'   ,'1998-10-24',3,2,1,2013),
(N'Nguyễn Thành'       ,N'Lực'  ,0, N'TP. HCM'   ,'1998-01-15',2,2,1,2014),
(N'Võ Nguyễn Nhật'     ,N'Minh' ,0, N'Bình Thuận','1997-12-05',1,3,1,2015),
(N'Nguyễn Thanh'       ,N'Nam'  ,0, N' Gia Lai'  ,'1997-02-10',1,3,1,2016),
(N'Lê Chí'             ,N'Nghị' ,0, N'Bến Tre'   ,'1998-11-06',3,3,1,2013),
(N'Lê Thanh'           ,N'Nguyên',0, N'Đồng Nai' ,'1998-01-12',2,3,1,2014),

(N'Đỗ Khương'          ,N'Ninh' ,0, N'TP. HCM'   ,'1998-10-04',1,3,1,2015),
(N'Lê Nhật'            ,N'Phi'  ,0, N'TP. HCM'   ,'1998-10-20',3,1,1,2016),
(N'Phạm Văn'           ,N'Quân' ,0, N'Quảng Ngãi','1998-10-29',1,1,1,2013),
(N'Phan Minh'          ,N'Quyền',0, N'Bình Thuận','1997-06-01',2,1,1,2014),
(N'Võ Anh'             ,N'Quyết',0, N'Quảng Trị' ,'1998-01-19',1,1,1,2015),
(N'Nguyễn Văn'         ,N'Sang',0, N'Đắk Lắk'    ,'1998-09-09',1,1,1,2016),
(N'Nguyễn Lam'         ,N'Sơn',0, N'Thái Bình'   ,'1998-06-04',2,2,1,2013),
(N'Nguyễn Tấn'         ,N'Tài',0, N' Khánh Hòa'  ,'1998-07-11',3,2,1,2014),
(N'Trần Huỳnh Thanh'   ,N'Tài',0, N'TP. HCM'     ,'1998-04-17',2,2,1,2015),
(N'Nguyễn Thanh'       ,N'Tâm',0, N'TP. HCM'     ,'1998-08-09',2,2,1,2016)

go
--tblDIEMHOCTAP
insert into tblDIEMHOCTAP(MaLop,MaSV,DiemChuyenCan,DiemTBKT,DiemThi) values
(6,1,5,6,6.5),
(2,2,6,6,7.5),
(9,3,8,5,7.3),
(2,4,8,7,8.5),
(6,5,10,8,9),
(8,6,9,9,9),
(3,7,8,8,8),
(3,8,6,8,7),
(3,9,10,6,7),
(8,10,10,7,5),
(10,11,10,5,6),
(7,12,10,6,7),
(1,13,9,8,5),
(7,14,6,7,5),
(7,15,5,4,3),
(2,16,6,4,3),
(6,17,6,6,6),
(2,18,4,5,6),
(6,19,3,4,5),
(9,20,6,5,4),
(5,21,6,5,7),
(3,22,3,4,8),
(5,23,6,7,4),
(8,24,10,6,7),
(3,25,10,5,6),
(4,26,10,4,5),
(1,27,8,7,6),
(7,28,9,6,7),
(7,29,4,6,7),
(7,30,7,6,8),
(2,31,10,5,6),
(2,32,7,7,7),
(6,33,6,6,6),
(9,34,8,8,8),
(2,35,9,9,9),
(5,36,10,10,10),
(5,37,9,9,9),
(3,38,5,5,5),
(8,39,8,8,8),
(3,40,8,8,8),
(8,41,6,6,6),
(4,42,6,5.6,7),
(7,43,5,7.5,8),
(1,44,8,7.8,7),
(1,45,7,6,8.3),
(4,46,5,6,8),
(2,47,8,7,6),
(9,48,9,8,7),
(6,49,7,6.5,7),
(2,50,4,3,6),
(6,51,5,6.7,5.5),
(8,52,6,7,8),
(5,53,5,6,8.7),
(3,54,8,5,6),
(8,55,6,5,7),
(3,56,6,7,8),
(4,57,6,7,8),
(1,58,6,5,7),
(7,59,4,5,4),
(4,60,6,5,7),
(7,61,5,4,6),
(2,62,6,5,3),
(2,63,3,4,5),
(9,64,3,4,4),
(6,65,4,3,5),
(9,66,3,4.5,6.5),
(3,67,6,5,4),
(5,68,4,5,6),
(8,69,5,6,7),
(5,70,4,3,5),
(3,71,3,4,6),
(7,72,3,5,6),
(1,73,3,4,6),
(4,74,5,6,7),
(7,75,5,6,7),
(1,76,4,5,5.5),
(6,77,5,6.6,7.6),
(9,78,5,7.6,5.6),
(6,79,4,5,6.5),
(2,80,4,5,6.5),
(6,81,4,6.3,4.5),
(8,82,5,6.7,5.5),
(5,83,5,4,6),
(3,84,3,4.5,5.6),
(8,85,5,6,7),
(3,86,3,4.5,4),
(4,87,5,6.7,5),
(4,88,5,6,7),
(7,89,6,5,6),
(1,90,4,3,5),
(4,91,5,4,7),
(9,92,4,6.5,6),
(6,93,5,6,4),
(2,94,5,4,6),
(6,95,4,5,6),
(6,96,3,4,5),
(3,97,6,5,6),
(8,98,4,5,6),
(3,99,5,6,7),
(3,100,4,5,7)


