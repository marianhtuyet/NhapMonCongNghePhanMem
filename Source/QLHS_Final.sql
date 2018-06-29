﻿create database QLHS
use QLHS
create table BANGDIEM
(
	MANH INT NOT NULL,
	MALOP INT NOT NULL,
	MAHK INT NOT NULL,
	MAMH INT NOT NULL,
	MAHS INT NOT NULL,
	HESO INT NULL,
	LANKIEMTRA INT NOT NULL,
	HINHTHUCKIEMTRA NVARCHAR(50) NOT NULL,
	DIEM FLOAT NULL,
	CONSTRAINT PK_BANGDIEM PRIMARY KEY (MANH,MAHK,MALOP,MAMH,MAHS,LANKIEMTRA,HINHTHUCKIEMTRA)
)
create table DIEMTBMON
(
	MANH INT NOT NULL,
	MALOP INT NOT NULL,
	MAMH INT NOT NULL,
	MAHS INT NOT NULL,
	TBHK1 FLOAT NULL,
	TBHK2 FLOAT NULL,
	CANAM FLOAT NULL,
	CONSTRAINT PK_DIEMTBMON PRIMARY KEY (MANH,MALOP,MAMH,MAHS)
)
create table BAOCAO
(
	MANH INT NOT NULL,
	MALOP INT NOT NULL,
	MAMH INT NOT NULL,
	SISO FLOAT NULL,
	SOLUONGDAT FLOAT NULL,
	TYLE float NULL,
	CONSTRAINT PK_BAOCAO PRIMARY KEY (MANH,MALOP,MAMH)
)
create table DIEMTBCHUNG
(
	MANH INT NOT NULL,
	MALOP INT NOT NULL,
	MAHS INT NOT NULL,
	TBHK1 FLOAT NULL,
	TBHK2 FLOAT NULL,
	CANAM FLOAT NULL,
	CONSTRAINT PK_DIEMTBCHUNG PRIMARY KEY(MANH,MALOP,MAHS)
)
CREATE TABLE BAOCAOCHUNG
(
	MANH INT NOT NULL,
	MALOP INT NOT NULL,
	SISO FLOAT NULL,
	SOLUONGDAT FLOAT NULL,
	TYLE FLOAT NULL,
	CONSTRAINT PK_BAOCAOCHUNG PRIMARY KEY(MANH,MALOP)
)
CREATE TABLE HOCSINH
(
	MAHS INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	HOTEN NVARCHAR(40) NOT NULL,
	DIACHI NVARCHAR(40) NOT NULL,
	NGAYSINH SMALLDATETIME NOT NULL,
	GIOITINH NVARCHAR(40) NOT NULL,
	TONGIAO NVARCHAR(40) NOT NULL,
	DANTOC NVARCHAR(40) NOT NULL,
	HOTENCHA NVARCHAR(40) NOT NULL,
	NGHENGHIEPCHA NVARCHAR(40) NOT NULL,
	HOTENME NVARCHAR(40) NOT NULL,
	NGHENGHIEPME NVARCHAR(40) NOT NULL
)
CREATE TABLE CHITIETLOP
(
	MAHS INT NOT NULL,
	MALOP INT NOT NULL, 
	MANH INT NOT NULL,
	CONSTRAINT PK_CHITIETLOP PRIMARY KEY(MAHS,MALOP,MANH)
)
CREATE TABLE LOPHOC
(
	MALOP INT PRIMARY KEY NOT NULL,
	TENLOP VARCHAR(20) NULL,
	MAKHOI INT NULL
)
CREATE TABLE NAMHOC
(
	MANH NCHAR(10) PRIMARY KEY NOT NULL,
	TENNH NCHAR(10) NULL
)
CREATE TABLE MONHOC
(
	MAMH INT PRIMARY KEY NOT NULL,
	TENMH NVARCHAR(10) NULL
)
CREATE TABLE NGUOIDUNG
(
	TENDN NVARCHAR(50) PRIMARY KEY NOT NULL,
	PASS CHAR(30) NULL,
	TENNGUOIDUNG CHAR(100) NULL,
	[LEVEL] INT NULL
)
CREATE TABLE QUYDINH
(
	TUOIMAX INT NULL,
	TUOIMIN INT NULL,
	SISO INT NULL,
	DIEMDAT INT NULL,
	DIEMMAX INT NULL,
	DIEMMIN INT NULL,
	LOP10 INT NULL,
	LOP11 INT NULL,
	LOP12 INT NULL
)	
CREATE TABLE KHOILOP
(
	MAKHOI int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TENKHOI nchar(10) NULL,
)
CREATE TABLE HOCKY
(
	MAHK INT PRIMARY KEY NOT NULL,
	TENHK NVARCHAR(20) NULL,
)

-- Định dạng ngày giờ Ngày Tháng Năm
set dateformat dmy

-- Insert dữ liệu nền
-- Insert DataTable HOCSINH
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Lê Hoàng Gia',N'Thành phố Hồ Chí Minh','20/12/2000',N'Nam',N'Không',N'Kinh',N'Lê Hoàng Gia Thất',N'Công nhân',N'Nguyễn Thị Hồng',N'May')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Nông Thị Thanh',N'Thủ Dầu Một, Bình Dương','02/02/2002',N'Nữ',N'Không',N'Tày',N'Nông Tà Tính',N'Nông',N'Lê Hồng Anh',N'Nông')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Nguyễn Văn Tài',N'Thành phố Hồ Chí Minh','20/12/2003',N'Nam',N'Không',N'Kinh',N'Nguyễn Văn Tám',N'Phụ hồ',N'Trần Thị Xuân',N'Công nhân')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Trương Thành Đạt',N'Thành phố Hồ Chí Minh','24/1/2002',N'Nam',N'Công Giáo',N'Kinh',N'Trương Thành Tài',N'Văn phòng',N'Nguyễn Hồng Hạnh',N'Giáo viên')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Phạm Thanh Tài',N'Thành phố Hồ Chí Minh','23/12/2000',N'Nam',N'Không',N'Kinh',N'Phạm Thanh Quý',N'Văn phòng',N'Lê Bích Ngọc',N'Công nhân')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Vũ Trung Dũng',N'Thành phố Hồ Chí Minh','27/7/2000',N'Nam',N'Không',N'Kinh',N'Vũ Quốc Bảo',N'Công nhân',N'Trần Thị Thúy Thảo',N'Văn phòng')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Phạm Đình Minh',N'Thành phố Hồ Chí Minh','11/09/2000',N'Nam',N'Không',N'Kinh',N'Phạm Chí Hảo',N'Công nhân',N'Trương Thúy Minh',N'Nội trợ')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Nguyễn Nhật Tiến Anh',N'Thành phố Hồ Chí Minh','28/7/2000',N'Nam',N'Phật Giáo',N'Kinh',N'Nguyễn Tiến Minh',N'Huấn luyện viên',N'Lương Thúy Vi',N'Giáo viên')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Phạm Thị Minh Nguyệt',N'Thành phố Hồ Chí Minh','25/12/2002',N'Nữ',N'Không',N'Kinh',N'Phạm Nhật Trường',N'Công nhân',N'Lê Bích Thúy',N'Nội trợ')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Nguyễn Việt Cường',N'Thành phố Hồ Chí Minh','19/12/2003',N'Nam',N'Không',N'Kinh',N'Nguyễn Quốc Anh',N'Công nhân',N'Trần Thị Thanh Thúy',N'Văn phòng')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Trần Thị Thu Thảo',N'Thành phố Hồ Chí Minh','20/8/2002',N'Nữ',N'Không',N'Kinh',N'Trần Nhật Minh',N'Đầu bếp',N'Lương Bích Ngọc',N'Kinh doanh')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Bùi Trần Minh Ngọc',N'Thành phố Hồ Chí Minh','22/2/2001',N'Nữ',N'Không',N'Kinh',N'Bùi Đại Gia',N'Công nhân',N'Nguyễn Thúy Nga',N'Văn phòng')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Trần Thị Kim Yến',N'Thành phố Hồ Chí Minh','24/12/2001',N'Nữ',N'Không',N'Kinh',N'Trần Quốc Đại',N'Công nhân',N'Nguyễn Thị Bích Vân',N'Văn phòng')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Cao Hoàng Đạt',N'Thành phố Hồ Chí Minh','03/02/2002',N'Nam',N'Không',N'Kinh',N'Cao Văn Vũ',N'Công nhân',N'Trần Ngọc Minh Anh',N'Công nhân')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Lê Thành Luân',N'Thành phố Hồ Chí Minh','09/10/2001',N'Nam',N'Không',N'Kinh',N'Lê Quý Bảo',N'Công nhân',N'Nguyễn Thị Thúy',N'Công nhân')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Ngô Thị Phương Anh',N'Thành phố Hồ Chí Minh','24/2/2000',N'Nữ',N'Không',N'Kinh',N'Ngô Gia Lâm',N'Văn phòng',N'Trương Thu Thiên',N'Văn phòng')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Lê Thị Mộng Thi',N'Thành phố Hồ Chí Minh','02/11/2000',N'Nữ',N'Không',N'Kinh',N'Lê Tấn Nguyên',N'Công nhân',N'Trần Thị Thu Hòa',N'Văn phòng')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Nguyễn Thị Hoài Anh',N'Thành phố Hồ Chí Minh','19/9/2002',N'Nữ',N'Không',N'Kinh',N'Nguyễn Thái Toàn',N'Kinh doanh',N'Lê Thị Hòa',N'Công nhân')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Nguyễn Thành Trung',N'Thành phố Hồ Chí Minh','11/07/2003',N'Nam',N'Công Giáo',N'Kinh',N'Nguyễn Thành Tân',N'Kinh doanh',N'Trần Thị Thục Trinh',N'Văn phòng')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Nguyễn Hoàng Thanh',N'Thành phố Hồ Chí Minh','27/7/2001',N'Nam',N'Không',N'Kinh',N'Nguyễn Văn Tín',N'Công nhân',N'Lê Thục Oanh',N'Nội trợ')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Trần Thanh Tùng',N'Thành phố Hồ Chí Minh','20/8/2003',N'Nam',N'Không',N'Kinh',N'Trần Thanh Tuấn',N'Văn phòng',N'Huỳnh Thị Thắm',N'Nội trợ')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Trịnh Quốc Cường',N'Thành phố Hồ Chí Minh','23/3/2003',N'Nam',N'Không',N'Kinh',N'Trịnh Quốc Đạt',N'Công nhân',N'Nguyễn Thủy Tiên',N'Công nhân')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Nguyễn Quang Hữu',N'Thành phố Hồ Chí Minh','10/02/2002',N'Nam',N'Không',N'Kinh',N'Nguyễn Quang Đạt',N'Công nhân',N'Vũ Dạ Thảo',N'Văn phòng')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Trịnh Thị Linh',N'Thành phố Hồ Chí Minh','01/02/2001',N'Nữ',N'Không',N'Kinh',N'Trịnh Quốc Bảo',N'Công nhân',N'Lưu Huyền Trân',N'Văn phòng')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Ngô Mỹ Linh',N'Thành phố Hồ Chí Minh','05/06/2003',N'Nữ',N'Không',N'Kinh',N'Ngô Văn Toàn',N'Kinh doanh',N'Lê Thanh Vân',N'Công nhân')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Phan Thị Mỹ',N'Thành phố Hồ Chí Minh','20/4/2002',N'Nữ',N'Không',N'Kinh',N'Phan Thế Minh',N'Văn phòng',N'Nguyễn Thị Vân',N'Công nhân')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Hoàng Thái Thanh',N'Thành phố Hồ Chí Minh','22/1/2002',N'Nam',N'Không',N'Kinh',N'Hoàng Thái Tuất',N'Kinh doanh',N'Trần Thị Anh',N'Nội trợ')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'Nguyễn Trần Gia Bảo',N'Thành phố Hồ Chí Minh','12/02/2001',N'Nam',N'Không',N'Kinh',N'Nguyễn Văn Tài',N'Kinh doanh',N'Trần Thị Kim Liên',N'Kinh doanh')
insert into HOCSINH(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME) VALUES (N'KaLe Nhật Nguyên',N'Biên Hòa, Đồng Nai','01/01/2003',N'Nam',N'Công Giáo',N'Kinh',N'Kale Nhật Hoàng',N'Kinh doanh',N'Lê Phương Hiền',N'Nội trợ')

-- Insert DataTable QUYDINH
insert into QUYDINH values(20, 15, 40, 5, 10, 0, 4, 3, 2)

-- Insert DataTable LOPHOC
insert into LOPHOC(MALOP,TENLOP,MAKHOI) values (101,'10a1',10)
insert into LOPHOC(MALOP,TENLOP,MAKHOI) values (102,'10a2',10)
insert into LOPHOC(MALOP,TENLOP,MAKHOI) values (103,'10a3',10)
insert into LOPHOC(MALOP,TENLOP,MAKHOI) values (104,'10a4',10)
insert into LOPHOC(MALOP,TENLOP,MAKHOI) values (111,'11a1',11)
insert into LOPHOC(MALOP,TENLOP,MAKHOI) values (112,'11a2',11)
insert into LOPHOC(MALOP,TENLOP,MAKHOI) values (113,'11a3',11)
insert into LOPHOC(MALOP,TENLOP,MAKHOI) values (121,'12a1',12)
insert into LOPHOC(MALOP,TENLOP,MAKHOI) values (122,'12a2',12)

-- Insert DataTable MONHOC
insert into MONHOC(MAMH,TENMH) values (1,N'Toán')
insert into MONHOC(MAMH,TENMH) values (2,N'Ngữ Văn')
insert into MONHOC(MAMH,TENMH) values (3,N'Vật lý')
insert into MONHOC(MAMH,TENMH) values (4,N'Hóa Học')
insert into MONHOC(MAMH,TENMH) values (5,N'Anh Văn')
insert into MONHOC(MAMH,TENMH) values (6,N'Sinh Học')
insert into MONHOC(MAMH,TENMH) values (7,N'Lịch Sử')
insert into MONHOC(MAMH,TENMH) values (8,N'Địa Lý')

-- Insert DataTable NAMHOC
insert into NAMHOC values (2017,'2017-2018')
insert into NAMHOC values (2018,'2018-2019')
insert into NAMHOC values (2019,'2019-2020')
insert into NAMHOC values (2020,'2020-2021')
insert into NAMHOC values (2021,'2021-2022')
insert into NAMHOC values (2022,'2022-2023')
insert into NAMHOC values (2023,'2023-2024')

-- Insert DataTalbe KHOILOP
insert into KHOILOP(TENKHOI) values (N'Khối 10')
insert into KHOILOP(TENKHOI) values (N'Khối 11')
insert into KHOILOP(TENKHOI) values (N'Khối 12')

-- Insert DataTable NGUOIDUNG	
insert into NGUOIDUNG(TENDN,PASS) values ('admin','admin')
insert into NGUOIDUNG(TENDN,PASS) values ('admin2','admin2')
insert into NGUOIDUNG(TENDN,PASS) values ('admin3','admin3')

-- Insert Datatable HOCKY
insert into HOCKY values (1,N'Học kỳ 1')
insert into HOCKY values (2,N'Học kỳ 2')




