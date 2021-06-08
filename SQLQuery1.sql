Create Database Quan_Ly_Ban_Hang

use Quan_Ly_Ban_Hang

Create table ChatLieu
(
MaChatLieu VarChar (50) primary key ,
TenChatLieu Varchar (50)
)

Create table Hang
(
MaHang Varchar (50) primary key ,
MaChatLieu Varchar (50) foreign key (MaChatLieu) references ChatLieu ,
TenHang Varchar (50),
SoLuong int,
DonGiaNhap int default 0,
DonGiaBan int default 0,
GhiChu Varchar (200)
)

Create table Khach
(
MaKhach Varchar (50) primary key ,
TenKhach Varchar (50),
DiaChi varchar (50),
DienThoai Varchar (50)
)

Create table NhanVien
(
MaNhanVien Varchar (50) primary key,
TenNhanVien Varchar (50),
ChucVu Varchar (15),
GioiTinh Varchar (10),
DiaChi Varchar (50),
DienThoai Varchar (50),
NgaySinh Datetime
)
Create table Account
(
TaiKhoan varchar (50) primary key,
MatKhau varchar (50) not null,
MaNhanVien varchar (50)
)

Create table HoaDonBan
(
MaHoaDon Varchar (50) primary key,
MaNhanVien Varchar (50) foreign key (MaNhanVien) references NhanVien,
NgayBan Datetime,
MaKhach Varchar (50) foreign key (MaKhach) references Khach,
)

Create table HoaDonBanCT
(
MaHoaDon Varchar (50) foreign key (MaHoaDon) references HoaDonBan,
MaHang Varchar (50) Foreign key (MaHang) references Hang,
SoLuong int,
DonGia int default 0,
GiamGia Float (50),
ThanhTien Float (50),
Constraint PK_HDCT primary key (MaHoaDon, MaHang)
)
 Create table ChucVu
 (
 IDCV varchar (50) primary key not null,
 TenChucVu varchar (50) not null,
 TaiKhoan varchar (50) foreign key (TaiKhoan) references Account not null,
 )