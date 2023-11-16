CREATE DATABASE QuanLyMiCay;
GO
USE QuanLyMiCay;
GO
USE master;
GO
-- Tạo bảng TaiKhoan
CREATE TABLE TaiKhoan (
    MaTaiKhoan INT IDENTITY(1,1) PRIMARY KEY,
    TenTaiKhoan NVARCHAR(255) NOT NULL,
    MatKhau NVARCHAR(255) NOT NULL
);
GO
-- Tạo bảng BanAn
CREATE TABLE BanAn (
    MaBanAn INT IDENTITY(1,1) PRIMARY KEY,
    TenBanAn NVARCHAR(255) NOT NULL
);
GO
-- Tạo bảng LoaiThucAn
CREATE TABLE LoaiThucAn (
    MaLoaiThucAn INT IDENTITY(1,1) PRIMARY KEY,
    TenLoaiThucAn NVARCHAR(255) NOT NULL
);
GO
-- Tạo bảng ThucAn
CREATE TABLE ThucAn (
    MaThucAn INT IDENTITY(1,1) PRIMARY KEY,
    MaLoaiThucAn INT FOREIGN KEY REFERENCES LoaiThucAn(MaLoaiThucAn),
    TenThucAn NVARCHAR(255) NOT NULL,
    GiaThucAn DECIMAL(10,2) NOT NULL
);
GO
-- Tạo bảng HoaDon
CREATE TABLE HoaDon (
    MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    NgayTao DATE NOT NULL,
    NgayKetThuc DATE,
    MaBanAn INT FOREIGN KEY REFERENCES BanAn(MaBanAn),
    TongTien DECIMAL(10,2) NOT NULL
);
Go
ALTER TABLE HoaDon
ADD IsPaid bit NOT NULL DEFAULT 0;
GO
-- Tạo bảng ChiTietHoaDon
CREATE TABLE ChiTietHoaDon (
    MaChiTietHoaDon INT IDENTITY(1,1) PRIMARY KEY,
    MaHoaDon INT FOREIGN KEY REFERENCES HoaDon(MaHoaDon),
    MaThucAn INT FOREIGN KEY REFERENCES ThucAn(MaThucAn),
    DonGia DECIMAL(10,2) NOT NULL,
    SoLuong INT NOT NULL,
    ThanhTien DECIMAL(10,2) NOT NULL
);
GO
USE QuanLyMiCay;
GO
-- Thêm dữ liệu mẫu cho bảng TaiKhoan
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau) VALUES
('admin', '123456'),
('user1', '123456'),
('user2', '123456');
GO

-- Thêm dữ liệu mẫu cho bảng BanAn
INSERT INTO BanAn (TenBanAn) VALUES
('Ban 4'),
('Ban 5'),
('Ban 6');
GO

-- Thêm dữ liệu mẫu cho bảng LoaiThucAn
INSERT INTO LoaiThucAn (TenLoaiThucAn) VALUES
('Mi Cay'),
('Nuoc Uong');
GO

-- Thêm dữ liệu mẫu cho bảng ThucAn
INSERT INTO ThucAn (MaLoaiThucAn, TenThucAn, GiaThucAn) VALUES
(1, 'Mi Cay Hai San', 40000),
(1, 'Mi Cay Bo', 45000),
(1, 'Mi Cay Dui Ga', 45000),
(1, 'Mi Cay Thap Cam', 55000),
(2, 'Coca Cola', 15000),
(2, 'Pepsi', 15000),
(2, 'Sting', 15000);
GO

-- Thêm dữ liệu mẫu cho bảng HoaDon
INSERT INTO HoaDon (NgayTao, NgayKetThuc, MaBanAn, TongTien) VALUES
('2023-10-24', NULL, 1, 0),
('2023-10-23', '2023-10-23', 2, 85000);
GO

-- Thêm dữ liệu mẫu cho bảng ChiTietHoaDon
INSERT INTO ChiTietHoaDon (MaHoaDon, MaThucAn, DonGia, SoLuong, ThanhTien) VALUES
(1, 1, 40000, 1, 40000),
(1, 2, 45000, 1, 45000),
(2, 3, 15000, 2, 30000),
(2, 4, 30000, 1, 30000);
GO

