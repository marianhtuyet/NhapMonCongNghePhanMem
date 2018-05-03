
create table HOCSINH
(
	MaHS int,
	TenHS varchar(40),
	MaLop int
	)

create table LOPHOC
(
	MaLop int,
	TenLop varchar(20),
	SiSo int,
	MaHK int
)
create table MONHOC
(
	MaMH int,
	TenMH varchar(20),
	HeSo int
)
create table DIEM
(
	Mieng float,
	Diem15pL1 float,
	Diem15pL2 float,
	Diem15pL3 float,
	Diem1TietL1 float,
	Diem1TietL2 float,
	Diem1TietL3 float,
	DiemHocKy float,
	MaHS int,
	MaBD int,
	DTBMon float
)

create table BANGDIEM
(
	MaBD int,
	MaMH int,
	MaHK int,
	MaLop int
	)

create table HOCKY
(
	MaHK int,
	TenHK varchar(10),
	HeSo int
)
create table TONGKETHK
(
	MaHS int,
	MaHK int,
	MaLop int,
	DTBHK float,
	HanhKiem varchar(10)
)
