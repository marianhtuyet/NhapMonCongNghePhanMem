

create table NAMHOC
(
	MaNamHoc char(8) primary key,
	TenNamHoc varchar(40)

);

create table HOCKY
(
	MaHocKy char(8) primary key,
	TenHK varchar(20),
	HeSoHK int

);

create table KHOILOP
(
	MaKhoi char(8) primary key,
	TenKhoi varchar(20)

)

create table LOPHOC
(
	MaLop char(8) primary key,
	TenLop varchar(20),
	MaNH char(8),
	MaHK char(8),
	SiSo int,
	MaGVCN char(8)
)

create table MONHOC
(
	MaMH char(8) primary key,
	TenMH varchar(30),
	HeSoMH int
)

create table KQHOCKY
(
	MaHS char(8),
	MaHK char(8),
	DTBHocKy float,
	MaHocLuc char(8),
	MaHanhKiem char(8),
	MaKetQua char(8), 
	primary key( MaHS, MaHK)
)

create table KETQUA
(
	MaKetQua char (8) primary key,
	TenKetQua varchar(20)

)

create table KQHOCKYMONHOC
(
	MaKQHocKy char(8),
	MaHS char(8) references HOCSINH(MaHS),
	MaMonHoc char(8) references MONHOC(MaMH),
	MaHocKy char(8),
	DiemTBMon float,
	primary key(MaKQHocKy, MaHS)
)

create table DIEM
(
	MaKQHocKy char(8) references KQHOCKYMONHOC(MaKQHocKy),
	MaLoai char(8) primary key,
	Diem int

)

create table LOAIDIEM
(
	MaLoai char(8) primary key,
	TenLoai varchar(20),
	HeSo int
)

create table KQCANAMMONHOC
(
	MaHS char(8),
	MaMH char(8),
	DTBCaNam float,
	primary key(MaHS, MaMH)
)
create table HOCLUC
(
	MaHocLuc char(8),
	TenHocLuc varchar(20)
)

create table HANHKIEM
(
	MaHanhKiem char(8),
	TenHanhKiem varchar(20)
)

create table HOCSINH
(
	MaHS char(8),
	MaLop char(8),
	MaKetQua char(8),
	MaHocLuc char(8),
	MaHanhKiem char(8),
	DiemTBCaNam float
)

create table HOSOHOCSINH
(
	MaHS char(8) references HOCSINH(MaHS),
	MaHoSo char(8) primary key,
	HoTenHS varchar(20),
	GioiTinh bit,
	NgaySinh date,
	NoiSinh varchar(50),
	TonGiao varchar(20),
	HoTenCha varchar(40),
	NgheNghiepCha varchar(40),
	HoTenMe varchar(40),
	NgheNghiepMe varchar(40),
	LyDoVaoHoc varchar(100)
)
create table GIAOVIEN
(
	MaGV char(8) primary key,
	TenGiaoVien varchar(40),
	NgaySinh date,
	NoiSinh varchar(50),
	GioiTinh bit,
	DiaChi varchar(100),
	DienThoai double,
	DanToc varchar(30),
	TonGiao varchar(30),
	MaMH char(8)
)
 
create table LOAINGUOIDUNG
(
	MaND char(8) primary key,
	TenND varchar(30),
	MaLoaiND char(8),
	TenDNhap varchar(40),
	MatKhau varchar(30)
)

