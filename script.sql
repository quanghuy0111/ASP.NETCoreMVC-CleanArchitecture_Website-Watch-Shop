USE [master]
GO
/****** Object:  Database [WebBanDongHo]    Script Date: 12/16/2020 9:41:39 AM ******/
CREATE DATABASE [WebBanDongHo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WebBanDongHo', FILENAME = N'F:\SQL\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WebBanDongHo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WebBanDongHo_log', FILENAME = N'F:\SQL\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WebBanDongHo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WebBanDongHo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WebBanDongHo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WebBanDongHo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WebBanDongHo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WebBanDongHo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WebBanDongHo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WebBanDongHo] SET ARITHABORT OFF 
GO
ALTER DATABASE [WebBanDongHo] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [WebBanDongHo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WebBanDongHo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WebBanDongHo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WebBanDongHo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WebBanDongHo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WebBanDongHo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WebBanDongHo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WebBanDongHo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WebBanDongHo] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WebBanDongHo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WebBanDongHo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WebBanDongHo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WebBanDongHo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WebBanDongHo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WebBanDongHo] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [WebBanDongHo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WebBanDongHo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WebBanDongHo] SET  MULTI_USER 
GO
ALTER DATABASE [WebBanDongHo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WebBanDongHo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WebBanDongHo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WebBanDongHo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WebBanDongHo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WebBanDongHo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [WebBanDongHo] SET QUERY_STORE = OFF
GO
USE [WebBanDongHo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/16/2020 9:41:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chiTietHoaDonBan]    Script Date: 12/16/2020 9:41:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chiTietHoaDonBan](
	[IDChiTietHoaDonBan] [int] IDENTITY(1,1) NOT NULL,
	[IDHoaDon] [char](5) NULL,
	[IDSanPham] [char](5) NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_chiTietHoaDonBan] PRIMARY KEY CLUSTERED 
(
	[IDChiTietHoaDonBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chiTietHoaDonNhap]    Script Date: 12/16/2020 9:41:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chiTietHoaDonNhap](
	[IDChiTietHoaDonNhap] [int] IDENTITY(1,1) NOT NULL,
	[IDHoaDonNhap] [char](5) NULL,
	[IDSanPham] [char](5) NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_chiTietHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[IDChiTietHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoaDonBan]    Script Date: 12/16/2020 9:41:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoaDonBan](
	[IDHoaDonBan] [char](5) NOT NULL,
	[IDKhachHang] [char](5) NULL,
	[ThanhTien] [float] NOT NULL,
	[NgayBan] [datetime] NOT NULL,
	[TrangThai] [nvarchar](20) NULL,
 CONSTRAINT [PK_hoaDonBan] PRIMARY KEY CLUSTERED 
(
	[IDHoaDonBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoaDonNhap]    Script Date: 12/16/2020 9:41:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoaDonNhap](
	[IDHoaDonNhap] [char](5) NOT NULL,
	[IDNhaCungCap] [char](5) NULL,
	[ThanhTien] [float] NOT NULL,
	[NgayNhap] [datetime] NOT NULL,
 CONSTRAINT [PK_hoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[IDHoaDonNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachHang]    Script Date: 12/16/2020 9:41:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachHang](
	[IDKhachHang] [char](5) NOT NULL,
	[HoKhachHang] [nvarchar](50) NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[DiaChiNhanHang] [varchar](200) NULL,
	[SoDienThoai] [varchar](10) NULL,
 CONSTRAINT [PK_khachHang] PRIMARY KEY CLUSTERED 
(
	[IDKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loaiDay]    Script Date: 12/16/2020 9:41:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaiDay](
	[IDDay] [char](5) NOT NULL,
	[TenLoaiDay] [nvarchar](50) NULL,
 CONSTRAINT [PK_loaiDay] PRIMARY KEY CLUSTERED 
(
	[IDDay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhaCungCap]    Script Date: 12/16/2020 9:41:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhaCungCap](
	[IDNhaCungCap] [char](5) NOT NULL,
	[TenNhacungCap] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[SoDienThoai] [varchar](10) NULL,
 CONSTRAINT [PK_nhaCungCap] PRIMARY KEY CLUSTERED 
(
	[IDNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sanPham]    Script Date: 12/16/2020 9:41:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sanPham](
	[IDSanPham] [char](5) NOT NULL,
	[TenSanPham] [nvarchar](50) NULL,
	[IDDay] [char](5) NULL,
	[IDThuongHieu] [char](5) NULL,
	[IDNhaCungCap] [char](5) NULL,
	[BaoHanh] [nvarchar](20) NULL,
	[SoLuong] [int] NOT NULL,
	[Gia] [float] NOT NULL,
	[HinhAnh] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_sanPham] PRIMARY KEY CLUSTERED 
(
	[IDSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taiKhoanKH]    Script Date: 12/16/2020 9:41:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taiKhoanKH](
	[TaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
	[IDKhachHang] [char](5) NULL,
 CONSTRAINT [PK_taiKhoanKH] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thuongHieu]    Script Date: 12/16/2020 9:41:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thuongHieu](
	[IDThuongHieu] [char](5) NOT NULL,
	[TenThuongHieu] [nvarchar](50) NULL,
 CONSTRAINT [PK_thuongHieu] PRIMARY KEY CLUSTERED 
(
	[IDThuongHieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201111140949_InitialCreate', N'5.0.0')
GO
SET IDENTITY_INSERT [dbo].[chiTietHoaDonBan] ON 

INSERT [dbo].[chiTietHoaDonBan] ([IDChiTietHoaDonBan], [IDHoaDon], [IDSanPham], [SoLuong]) VALUES (1, N'DB004', N'SP027', 1)
INSERT [dbo].[chiTietHoaDonBan] ([IDChiTietHoaDonBan], [IDHoaDon], [IDSanPham], [SoLuong]) VALUES (2, N'DB004', N'SP034', 1)
INSERT [dbo].[chiTietHoaDonBan] ([IDChiTietHoaDonBan], [IDHoaDon], [IDSanPham], [SoLuong]) VALUES (3, N'DB004', N'SP012', 1)
INSERT [dbo].[chiTietHoaDonBan] ([IDChiTietHoaDonBan], [IDHoaDon], [IDSanPham], [SoLuong]) VALUES (4, N'DB003', N'SP055', 1)
INSERT [dbo].[chiTietHoaDonBan] ([IDChiTietHoaDonBan], [IDHoaDon], [IDSanPham], [SoLuong]) VALUES (5, N'DB002', N'SP059', 1)
INSERT [dbo].[chiTietHoaDonBan] ([IDChiTietHoaDonBan], [IDHoaDon], [IDSanPham], [SoLuong]) VALUES (6, N'DB001', N'SP044', 1)
INSERT [dbo].[chiTietHoaDonBan] ([IDChiTietHoaDonBan], [IDHoaDon], [IDSanPham], [SoLuong]) VALUES (7, N'DB001', N'SP005', 1)
SET IDENTITY_INSERT [dbo].[chiTietHoaDonBan] OFF
GO
SET IDENTITY_INSERT [dbo].[chiTietHoaDonNhap] ON 

INSERT [dbo].[chiTietHoaDonNhap] ([IDChiTietHoaDonNhap], [IDHoaDonNhap], [IDSanPham], [SoLuong]) VALUES (1, N'DN004', N'SP053', 4)
INSERT [dbo].[chiTietHoaDonNhap] ([IDChiTietHoaDonNhap], [IDHoaDonNhap], [IDSanPham], [SoLuong]) VALUES (2, N'DN004', N'SP050', 2)
INSERT [dbo].[chiTietHoaDonNhap] ([IDChiTietHoaDonNhap], [IDHoaDonNhap], [IDSanPham], [SoLuong]) VALUES (3, N'DN003', N'SP018', 3)
INSERT [dbo].[chiTietHoaDonNhap] ([IDChiTietHoaDonNhap], [IDHoaDonNhap], [IDSanPham], [SoLuong]) VALUES (4, N'DN002', N'SP058', 4)
INSERT [dbo].[chiTietHoaDonNhap] ([IDChiTietHoaDonNhap], [IDHoaDonNhap], [IDSanPham], [SoLuong]) VALUES (5, N'DN002', N'SP066', 5)
INSERT [dbo].[chiTietHoaDonNhap] ([IDChiTietHoaDonNhap], [IDHoaDonNhap], [IDSanPham], [SoLuong]) VALUES (6, N'DN001', N'SP060', 3)
INSERT [dbo].[chiTietHoaDonNhap] ([IDChiTietHoaDonNhap], [IDHoaDonNhap], [IDSanPham], [SoLuong]) VALUES (7, N'DN001', N'SP045', 1)
INSERT [dbo].[chiTietHoaDonNhap] ([IDChiTietHoaDonNhap], [IDHoaDonNhap], [IDSanPham], [SoLuong]) VALUES (8, N'DN001', N'SP025', 2)
SET IDENTITY_INSERT [dbo].[chiTietHoaDonNhap] OFF
GO
INSERT [dbo].[hoaDonBan] ([IDHoaDonBan], [IDKhachHang], [ThanhTien], [NgayBan], [TrangThai]) VALUES (N'DB001', N'KH003', 10000000, CAST(N'2020-10-20T00:00:00.000' AS DateTime), N' ')
INSERT [dbo].[hoaDonBan] ([IDHoaDonBan], [IDKhachHang], [ThanhTien], [NgayBan], [TrangThai]) VALUES (N'DB002', N'KH005', 4650000, CAST(N'2020-11-20T00:00:00.000' AS DateTime), N' ')
INSERT [dbo].[hoaDonBan] ([IDHoaDonBan], [IDKhachHang], [ThanhTien], [NgayBan], [TrangThai]) VALUES (N'DB003', N'KH004', 5710000, CAST(N'2020-11-27T00:00:00.000' AS DateTime), N' ')
INSERT [dbo].[hoaDonBan] ([IDHoaDonBan], [IDKhachHang], [ThanhTien], [NgayBan], [TrangThai]) VALUES (N'DB004', N'KH001', 9217000, CAST(N'2020-12-01T00:00:00.000' AS DateTime), N' ')
GO
INSERT [dbo].[hoaDonNhap] ([IDHoaDonNhap], [IDNhaCungCap], [ThanhTien], [NgayNhap]) VALUES (N'DN001', N'NC002', 33022000, CAST(N'2020-02-20T00:00:00.000' AS DateTime))
INSERT [dbo].[hoaDonNhap] ([IDHoaDonNhap], [IDNhaCungCap], [ThanhTien], [NgayNhap]) VALUES (N'DN002', N'NC004', 51510000, CAST(N'2020-06-01T00:00:00.000' AS DateTime))
INSERT [dbo].[hoaDonNhap] ([IDHoaDonNhap], [IDNhaCungCap], [ThanhTien], [NgayNhap]) VALUES (N'DN003', N'NC001', 31092000, CAST(N'2020-06-29T00:00:00.000' AS DateTime))
INSERT [dbo].[hoaDonNhap] ([IDHoaDonNhap], [IDNhaCungCap], [ThanhTien], [NgayNhap]) VALUES (N'DN004', N'NC005', 29000000, CAST(N'2020-10-24T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[khachHang] ([IDKhachHang], [HoKhachHang], [TenKhachHang], [DiaChiNhanHang], [SoDienThoai]) VALUES (N'KH001', N'Nguyễn', N'Phát', N'Dang Chat', N'0982765221')
INSERT [dbo].[khachHang] ([IDKhachHang], [HoKhachHang], [TenKhachHang], [DiaChiNhanHang], [SoDienThoai]) VALUES (N'KH002', N'Lê', N'Nhân', N'Duong Ba Trac', N'0788889378')
INSERT [dbo].[khachHang] ([IDKhachHang], [HoKhachHang], [TenKhachHang], [DiaChiNhanHang], [SoDienThoai]) VALUES (N'KH003', N'Nguyễn', N'Nguyên', N'Tam Danh', N'0944449394')
INSERT [dbo].[khachHang] ([IDKhachHang], [HoKhachHang], [TenKhachHang], [DiaChiNhanHang], [SoDienThoai]) VALUES (N'KH004', N'Cao', N'Hưng', N'Ta Quang Buu', N'0909189189')
INSERT [dbo].[khachHang] ([IDKhachHang], [HoKhachHang], [TenKhachHang], [DiaChiNhanHang], [SoDienThoai]) VALUES (N'KH005', N'Nguyễn', N'Huy', N'Au Duong Lan', N'0906600189')
GO
INSERT [dbo].[loaiDay] ([IDDay], [TenLoaiDay]) VALUES (N'LD001', N'Dây da')
INSERT [dbo].[loaiDay] ([IDDay], [TenLoaiDay]) VALUES (N'LD002', N'Dây vải')
INSERT [dbo].[loaiDay] ([IDDay], [TenLoaiDay]) VALUES (N'LD003', N'Dây cao su')
INSERT [dbo].[loaiDay] ([IDDay], [TenLoaiDay]) VALUES (N'LD004', N'Thép không gỉ')
GO
INSERT [dbo].[nhaCungCap] ([IDNhaCungCap], [TenNhacungCap], [DiaChi], [SoDienThoai]) VALUES (N'NC001', N'Nhật Bản', N'Tan Binh', N'0123456789')
INSERT [dbo].[nhaCungCap] ([IDNhaCungCap], [TenNhacungCap], [DiaChi], [SoDienThoai]) VALUES (N'NC002', N'Mỹ', N'Tan Phu', N'0234567891')
INSERT [dbo].[nhaCungCap] ([IDNhaCungCap], [TenNhacungCap], [DiaChi], [SoDienThoai]) VALUES (N'NC003', N'Đan Mạch', N'Thu Duc', N'0345678912')
INSERT [dbo].[nhaCungCap] ([IDNhaCungCap], [TenNhacungCap], [DiaChi], [SoDienThoai]) VALUES (N'NC004', N'Thụy Sĩ', N'Binh Tan', N'0456789123')
INSERT [dbo].[nhaCungCap] ([IDNhaCungCap], [TenNhacungCap], [DiaChi], [SoDienThoai]) VALUES (N'NC005', N'Thụy Điển', N'Binh Thanh', N'0567891234')
INSERT [dbo].[nhaCungCap] ([IDNhaCungCap], [TenNhacungCap], [DiaChi], [SoDienThoai]) VALUES (N'NC006', N'Hồng Kông', N'Phu Nhuan', N'0678912345')
GO
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP001', N'Orient_FAG02004B0', N'LD001', N'TH011', N'NC001', N'2 năm', 10, 5810000, N'/images/DATA/Orient_FAG02004B0.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP002', N'Orient_FAL00003W0', N'LD004', N'TH011', N'NC001', N'2 năm', 10, 6170000, N'/images/DATA/Orient_FAL00003W0.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP003', N'Orient_FET0P002B0', N'LD004', N'TH011', N'NC001', N'2 năm', 10, 9080000, N'/images/DATA/Orient_FET0P002B0.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP004', N'Orient_FGW01004A0', N'LD001', N'TH011', N'NC001', N'2 năm', 10, 3810000, N'/images/DATA/Orient_FGW01004A0.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP005', N'Orient_RA-AC0011S10B', N'LD001', N'TH011', N'NC001', N'2 năm', 10, 7080000, N'/images/DATA/Orient_RA-AC0011S10B.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP006', N'Fouette_OR-FAIRYIII', N'LD001', N'TH007', N'NC006', N'2 năm', 10, 2550000, N'/images/DATA/Fouette_OR-FAIRYIII.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP007', N'Fouette_OR-5', N'LD001', N'TH007', N'NC006', N'2 năm', 10, 1550000, N'/images/DATA/Fouette_OR-5.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP008', N'Fouette_OR-STAR', N'LD001', N'TH007', N'NC006', N'2 năm', 10, 1550000, N'/images/DATA/Fouette_OR-STAR.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP009', N'Fouette_OR-LOVE', N'LD001', N'TH007', N'NC006', N'2 năm', 10, 1550000, N'/images/DATA/Fouette_OR-LOVE.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP010', N'Casio_EFV-540DC-1BVUDF', N'LD004', N'TH003', N'NC001', N'2 năm', 10, 4489000, N'/images/DATA/Casio_EFV-540DC-1BVUDF.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP011', N'Casio_MTP-VD300L-1EUDF', N'LD001', N'TH003', N'NC001', N'2 năm', 10, 1457000, N'/images/DATA/Casio_MTP-VD300L-1EUDF.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP012', N'Casio_LTP-1170N-9ARDF', N'LD004', N'TH003', N'NC001', N'2 năm', 10, 1387000, N'/images/DATA/Casio_LTP-1170N-9ARDF.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP013', N'Casio_MW-240-7EVDF', N'LD003', N'TH003', N'NC001', N'2 năm', 10, 517000, N'/images/DATA/Casio_MW-240-7EVDF.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP014', N'Casio_AE1200WHD', N'LD004', N'TH003', N'NC001', N'2 năm', 10, 1246000, N'/images/DATA/Casio_AE1200WHD.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP015', N'G-Shock_DW-5600MS-1DR', N'LD003', N'TH008', N'NC001', N'2 năm', 10, 3169000, N'/images/DATA/G-Shock_DW-5600MS-1DR.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP016', N'G-Shock_GAX-100MSB-1ADR', N'LD003', N'TH008', N'NC001', N'2 năm', 10, 5100000, N'/images/DATA/G-Shock_GAX-100MSB-1ADR.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP017', N'Baby-G_MSG-S200-7ADR', N'LD003', N'TH008', N'NC001', N'2 năm', 10, 3737000, N'/images/DATA/Baby-G_MSG-S200-7ADR.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP018', N'G-Shock_GST-S310D-1A9DR', N'LD004', N'TH008', N'NC001', N'2 năm', 10, 10364000, N'/images/DATA/G-Shock_GST-S310D-1A9DR.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP019', N'G-Shock_GA-200RG-1ADR', N'LD003', N'TH008', N'NC001', N'2 năm', 10, 5452000, N'/images/DATA/G-Shock_GA-200RG-1ADR.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP020', N'Citizen_NH8350-59L', N'LD004', N'TH004', N'NC001', N'2 năm', 10, 5520000, N'/images/DATA/Citizen_NH8350-59L.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP021', N'Citizen_BH3003-51A', N'LD004', N'TH004', N'NC001', N'2 năm', 10, 4300000, N'/images/DATA/Citizen_BH3003-51A.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP022', N'Citizen_BI1050-05A', N'LD002', N'TH004', N'NC001', N'2 năm', 10, 2700000, N'/images/DATA/Citizen_BI1050-05A.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP023', N'Citizen_BM9012-02A', N'LD001', N'TH004', N'NC001', N'2 năm', 10, 6600000, N'/images/DATA/Citizen_BM9012-02A.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP024', N'Citizen_CA4425-10X', N'LD001', N'TH004', N'NC001', N'2 năm', 10, 7750000, N'/images/DATA/Citizen_CA4425-10X.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP025', N'Fossil_ES4821', N'LD004', N'TH006', N'NC002', N'2 năm', 10, 3480000, N'/images/DATA/Fossil_ES4821.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP026', N'Fossil_ES4534', N'LD004', N'TH006', N'NC002', N'2 năm', 10, 4020000, N'/images/DATA/Fossil_ES4534.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP027', N'Fossil_ES4837', N'LD004', N'TH006', N'NC002', N'2 năm', 10, 3480000, N'/images/DATA/Fossil_ES4837.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP028', N'Fossil_ES4433', N'LD004', N'TH006', N'NC002', N'2 năm', 10, 3380000, N'/images/DATA/Fossil_ES4433.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP029', N'Fossil_ES4671', N'LD004', N'TH006', N'NC002', N'2 năm', 10, 3480000, N'/images/DATA/Fossil_ES4671.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP030', N'Skagen_SKW6654', N'LD001', N'TH014', N'NC003', N'2 năm', 10, 2960000, N'/images/DATA/Skagen_SKW6654.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP031', N'Skagen_SKW6454', N'LD002', N'TH014', N'NC003', N'2 năm', 10, 4630000, N'/images/DATA/Skagen_SKW6454.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP032', N'Skagen_SKW6578', N'LD001', N'TH014', N'NC003', N'2 năm', 10, 2960000, N'/images/DATA/Skagen_SKW6578.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP033', N'Skagen_SKW2699', N'LD004', N'TH014', N'NC003', N'2 năm', 10, 3280000, N'/images/DATA/Skagen_SKW2699.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP034', N'Skagen_456SSS', N'LD004', N'TH014', N'NC003', N'2 năm', 10, 4350000, N'/images/DATA/Skagen_456SSS.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP035', N'Seiko_SPB121J1', N'LD001', N'TH013', N'NC001', N'2 năm', 10, 24840000, N'/images/DATA/Seiko_SPB121J1.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP036', N'Seiko_SSC715P1', N'LD004', N'TH013', N'NC001', N'2 năm', 10, 8720000, N'/images/DATA/Seiko_SSC715P1.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP037', N'Seiko_SRPC91K1', N'LD003', N'TH013', N'NC001', N'2 năm', 10, 11820000, N'/images/DATA/Seiko_SRPC91K1.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP038', N'Seiko_SSA383K1', N'LD002', N'TH013', N'NC001', N'2 năm', 10, 7540000, N'/images/DATA/Seiko_SSA383K1.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP039', N'Seiko_SSA810J1', N'LD004', N'TH013', N'NC001', N'2 năm', 10, 13070000, N'/images/DATA/Seiko_SSA810J1.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP040', N'OP_89322GS-T', N'LD004', N'TH010', N'NC001', N'2 năm', 10, 2840000, N'/images/DATA/OP_89322GS-T.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP041', N'OP_130MS-GL-T-06', N'LD001', N'TH010', N'NC001', N'2 năm', 10, 2000000, N'/images/DATA/OP_130MS-GL-T-06.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP042', N'OP_9908AGS-D-88', N'LD004', N'TH010', N'NC001', N'2 năm', 10, 6970000, N'/images/DATA/OP_9908AGS-D-88.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP043', N'OP_5695MS-T', N'LD004', N'TH010', N'NC001', N'2 năm', 10, 2800000, N'/images/DATA/OP_5695MS-T.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP044', N'OP_5695LSK-V', N'LD004', N'TH010', N'NC001', N'2 năm', 10, 2920000, N'/images/DATA/OP_5695LSK-V.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP045', N'MichaelKors_MK3191', N'LD004', N'TH009', N'NC002', N'2 năm', 10, 6910000, N'/images/DATA/MichaelKors_MK3191.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP046', N'MichaelKors_MK4409', N'LD004', N'TH009', N'NC002', N'2 năm', 10, 6760000, N'/images/DATA/MichaelKors_MK4409.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP047', N'MichaelKors_MK8752', N'LD004', N'TH009', N'NC002', N'2 năm', 10, 6910000, N'/images/DATA/MichaelKors_MK8752.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP048', N'MichaelKors_MK8631', N'LD001', N'TH009', N'NC002', N'2 năm', 10, 5400000, N'/images/DATA/MichaelKors_MK8631.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP049', N'MichaelKors_MK2715', N'LD001', N'TH009', N'NC002', N'2 năm', 10, 5270000, N'/images/DATA/MichaelKors_MK2715.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP050', N'DanielWellington_DW00100014', N'LD001', N'TH005', N'NC005', N'2 năm', 10, 5300000, N'/images/DATA/DanielWellington_DW00100014.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP051', N'DanielWellington_DW00100311', N'LD002', N'TH005', N'NC005', N'2 năm', 10, 3500000, N'/images/DATA/DanielWellington_DW00100311.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP052', N'DanielWellington_DW00100164', N'LD004', N'TH005', N'NC005', N'2 năm', 10, 4100000, N'/images/DATA/DanielWellington_DW00100164.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP053', N'DanielWellington_DW00100277', N'LD002', N'TH005', N'NC005', N'2 năm', 10, 4600000, N'/images/DATA/DanielWellington_DW00100277.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP054', N'DanielWellington_DW00100135', N'LD001', N'TH005', N'NC005', N'2 năm', 10, 5300000, N'/images/DATA/DanielWellington_DW00100135.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP055', N'Candino_C45582', N'LD001', N'TH002', N'NC004', N'2 năm', 10, 5710000, N'/images/DATA/Candino_C42922.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP056', N'Candino_C42922', N'LD001', N'TH002', N'NC004', N'2 năm', 10, 4650000, N'/images/DATA/Candino_C44714.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP057', N'Candino_C44714', N'LD001', N'TH002', N'NC004', N'2 năm', 10, 5710000, N'/images/DATA/Candino_C46401.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP058', N'Candino_C46401', N'LD001', N'TH002', N'NC004', N'2 năm', 10, 6750000, N'/images/DATA/Candino_C42921.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP059', N'Candino_C42921', N'LD001', N'TH002', N'NC004', N'2 năm', 10, 4650000, N'/images/DATA/Saga_53229 SVMWSV-6.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP060', N'Saga_53229 SVMWSV-6', N'LD004', N'TH012', N'NC002', N'2 năm', 10, 6384000, N'/images/DATA/Saga_80727 GPMWGP-2L.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP061', N'Saga_80727 GPMWGP-2L', N'LD004', N'TH012', N'NC002', N'2 năm', 10, 6004000, N'/images/DATA/Saga_53555 SVMWSV-2.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP062', N'Saga_53555 SVMWSV-2', N'LD004', N'TH012', N'NC002', N'2 năm', 10, 5244000, N'/images/DATA/Saga_71865 GPMWGP-2L.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP063', N'Saga_71865 GPMWGP-2L', N'LD004', N'TH012', N'NC002', N'2 năm', 10, 6764000, N'/images/DATA/Saga_71865 GPMWGP-2L.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP064', N'Saga_53624 RGBDBK-2', N'LD004', N'TH012', N'NC002', N'2 năm', 10, 6384000, N'/images/DATA/Saga_53624 RGBDBK-2.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP065', N'Adriatica_A3694.51B3QZ', N'LD004', N'TH001', N'NC004', N'2 năm', 10, 6210000, N'/images/DATA/Adriatica_A3694.51B3QZ.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP066', N'Adriatica_A8109.5153Q', N'LD004', N'TH001', N'NC004', N'2 năm', 10, 4440000, N'/images/DATA/Adriatica_A8109.5153Q.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP067', N'Adriatica_A3603.5113QZ', N'LD004', N'TH001', N'NC004', N'2 năm', 10, 5490000, N'/images/DATA/Adriatica_A3603.5113QZ.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP068', N'Adriatica_A3508.1143QZ', N'LD004', N'TH001', N'NC004', N'2 năm', 10, 5310000, N'/images/DATA/Adriatica_A3508.1143QZ.jpg')
INSERT [dbo].[sanPham] ([IDSanPham], [TenSanPham], [IDDay], [IDThuongHieu], [IDNhaCungCap], [BaoHanh], [SoLuong], [Gia], [HinhAnh]) VALUES (N'SP069', N'Adriatica_A3143.2111Q', N'LD004', N'TH001', N'NC004', N'2 năm', 10, 5610000, N'/images/DATA/Adriatica_A3143.2111Q.jpg')
GO
INSERT [dbo].[taiKhoanKH] ([TaiKhoan], [MatKhau], [IDKhachHang]) VALUES (N'admin', N'123456', N'KH000')
INSERT [dbo].[taiKhoanKH] ([TaiKhoan], [MatKhau], [IDKhachHang]) VALUES (N'caohung', N'iklmno', N'KH004')
INSERT [dbo].[taiKhoanKH] ([TaiKhoan], [MatKhau], [IDKhachHang]) VALUES (N'lenhan', N'290620', N'KH002')
INSERT [dbo].[taiKhoanKH] ([TaiKhoan], [MatKhau], [IDKhachHang]) VALUES (N'nguyenhuy', N'qwerty', N'KH005')
INSERT [dbo].[taiKhoanKH] ([TaiKhoan], [MatKhau], [IDKhachHang]) VALUES (N'nguyennguyen', N'456789', N'KH003')
INSERT [dbo].[taiKhoanKH] ([TaiKhoan], [MatKhau], [IDKhachHang]) VALUES (N'nguyenphat', N'abcdef', N'KH001')
GO
INSERT [dbo].[thuongHieu] ([IDThuongHieu], [TenThuongHieu]) VALUES (N'TH001', N'ADRIATICA')
INSERT [dbo].[thuongHieu] ([IDThuongHieu], [TenThuongHieu]) VALUES (N'TH002', N'CANDINO')
INSERT [dbo].[thuongHieu] ([IDThuongHieu], [TenThuongHieu]) VALUES (N'TH003', N'CASIO')
INSERT [dbo].[thuongHieu] ([IDThuongHieu], [TenThuongHieu]) VALUES (N'TH004', N'CITIZEN')
INSERT [dbo].[thuongHieu] ([IDThuongHieu], [TenThuongHieu]) VALUES (N'TH005', N'DANIEL WELLINGTON')
INSERT [dbo].[thuongHieu] ([IDThuongHieu], [TenThuongHieu]) VALUES (N'TH006', N'FOSSIL')
INSERT [dbo].[thuongHieu] ([IDThuongHieu], [TenThuongHieu]) VALUES (N'TH007', N'FOUETTÉ')
INSERT [dbo].[thuongHieu] ([IDThuongHieu], [TenThuongHieu]) VALUES (N'TH008', N'G-SHOCK & BABY-G')
INSERT [dbo].[thuongHieu] ([IDThuongHieu], [TenThuongHieu]) VALUES (N'TH009', N'MICHAEL KORS')
INSERT [dbo].[thuongHieu] ([IDThuongHieu], [TenThuongHieu]) VALUES (N'TH010', N'OP')
INSERT [dbo].[thuongHieu] ([IDThuongHieu], [TenThuongHieu]) VALUES (N'TH011', N'ORIENT')
INSERT [dbo].[thuongHieu] ([IDThuongHieu], [TenThuongHieu]) VALUES (N'TH012', N'SAGA')
INSERT [dbo].[thuongHieu] ([IDThuongHieu], [TenThuongHieu]) VALUES (N'TH013', N'SEIKO')
INSERT [dbo].[thuongHieu] ([IDThuongHieu], [TenThuongHieu]) VALUES (N'TH014', N'SKAGEN')
GO
USE [master]
GO
ALTER DATABASE [WebBanDongHo] SET  READ_WRITE 
GO
