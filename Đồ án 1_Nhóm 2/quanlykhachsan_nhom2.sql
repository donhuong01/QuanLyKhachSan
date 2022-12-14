USE [QUANLYKHACHSAN]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 4/17/2022 12:32:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MaDV] [nchar](10) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[LoaiDV] [nvarchar](50) NULL,
	[MoTaDV] [nvarchar](max) NULL,
	[TrangThai] [bit] NULL,
	[SoLuong] [int] NULL,
	[DonGia] [decimal](10, 0) NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONGLICHLV]    Script Date: 4/17/2022 12:32:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONGLICHLV](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[TenBP] [nvarchar](50) NULL,
 CONSTRAINT [PK_DONGLICHLV] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONGPHIEUCC]    Script Date: 4/17/2022 12:32:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONGPHIEUCC](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_DONGPHIEUCC] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONGPHIEULUONG]    Script Date: 4/17/2022 12:32:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONGPHIEULUONG](
	[MaNV] [nchar](10) NOT NULL,
	[TenBP] [nvarchar](50) NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgayCong] [int] NULL,
	[TenChucVu] [nvarchar](50) NULL,
	[TienThuong] [decimal](18, 2) NULL,
	[HeSoLuong] [decimal](18, 2) NULL,
	[LuongCB] [decimal](18, 2) NULL,
	[PhuCap] [decimal](18, 2) NULL,
	[ThanhTien] [decimal](18, 2) NULL,
 CONSTRAINT [PK_DONGPHIEULUONG] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 4/17/2022 12:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [nchar](10) NOT NULL,
	[TenHD] [nvarchar](50) NULL,
	[MaKH] [nchar](10) NULL,
	[MaDV] [nchar](10) NULL,
	[MaPhong] [nchar](10) NULL,
	[VAT] [decimal](4, 2) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON_DV]    Script Date: 4/17/2022 12:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON_DV](
	[MaDV] [nchar](10) NOT NULL,
	[MaHD] [nchar](10) NULL,
	[LoaiDV] [nvarchar](50) NULL,
	[TenDV] [nvarchar](50) NULL,
	[SoLuongDV] [int] NULL,
	[DonGiaDV] [decimal](18, 0) NULL,
	[ThanhTien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_HOADON_DV] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON_KH]    Script Date: 4/17/2022 12:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON_KH](
	[MaKH] [nchar](10) NOT NULL,
	[MaHD] [nchar](10) NULL,
	[TenKH] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[ThoiGianThuePhong] [int] NULL,
	[ThoiGianSDDV] [int] NULL,
 CONSTRAINT [PK_HOADON_KH] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON_PHONG]    Script Date: 4/17/2022 12:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON_PHONG](
	[MaPhong] [nchar](10) NOT NULL,
	[MaHD] [nchar](10) NULL,
	[LoaiPhong] [nvarchar](50) NULL,
	[TenPhong] [nvarchar](50) NULL,
	[SoLuongPhong] [int] NULL,
	[DonGiaPhong] [decimal](18, 0) NULL,
	[ThanhTien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_HOADON_PHONG] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 4/17/2022 12:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[CMND] [nchar](20) NULL,
	[EmailKH] [nvarchar](50) NULL,
	[SoDT] [nchar](15) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[QuocTich] [nchar](20) NULL,
	[GioiTinh] [bit] NULL,
	[LichHen] [datetime] NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LICHLAMVIEC]    Script Date: 4/17/2022 12:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LICHLAMVIEC](
	[SoLichLV] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NULL,
	[CaLam] [nchar](10) NULL,
	[GioVaoLam] [datetime] NULL,
	[GioTanLam] [datetime] NULL,
	[ViTriLamViec] [nvarchar](50) NULL,
	[NhiemVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_LICHLAMVIEC] PRIMARY KEY CLUSTERED 
(
	[SoLichLV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGUOIDUNGHT]    Script Date: 4/17/2022 12:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOIDUNGHT](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nchar](20) NULL,
	[LoaiNguoiDung] [nvarchar](50) NULL,
 CONSTRAINT [PK_NGUOIDUNG_HT] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 4/17/2022 12:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nchar](10) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[TenBP] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](max) NULL,
	[Email] [nvarchar](50) NULL,
	[SoDT] [nchar](20) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[ViTriLamViec] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN_1_1] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUCHAMCONG]    Script Date: 4/17/2022 12:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUCHAMCONG](
	[MaPhieuCC] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NULL,
	[NgayChamCong] [datetime] NULL,
 CONSTRAINT [PK_PHIEUCHAMCONG] PRIMARY KEY CLUSTERED 
(
	[MaPhieuCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEULUONG]    Script Date: 4/17/2022 12:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEULUONG](
	[MaPhieuLuong] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NULL,
 CONSTRAINT [PK_PHIEULUONG] PRIMARY KEY CLUSTERED 
(
	[MaPhieuLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 4/17/2022 12:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[MaPhong] [nchar](10) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[LoaiPhong] [nvarchar](50) NOT NULL,
	[ViTriPhong] [nchar](20) NULL,
	[SoLuong] [int] NULL,
	[TinhTrang] [bit] NULL,
	[MoTaPhong] [nvarchar](max) NULL,
	[DonGia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_PHONG_1] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [LoaiDV], [MoTaDV], [TrangThai], [SoLuong], [DonGia]) VALUES (N'DV1       ', N'Giặt là', N'Bên ngoài khách sạn', N'sử dụng dịch vụ bên ngoài khách sạn', 1, 200, CAST(150000 AS Decimal(10, 0)))
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [LoaiDV], [MoTaDV], [TrangThai], [SoLuong], [DonGia]) VALUES (N'DV2       ', N'Sửa chữa', N'Bên trong khách sạn', N'sử dụng dịch vụ bên trong khách sạn', 0, 50, CAST(200000 AS Decimal(10, 0)))
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [LoaiDV], [MoTaDV], [TrangThai], [SoLuong], [DonGia]) VALUES (N'DV3       ', N'Vận chuyển', N'Bên trong khách sạn', N'sử dụng dịch vụ bên trong khách sạn', 1, 300, CAST(350000 AS Decimal(10, 0)))
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [LoaiDV], [MoTaDV], [TrangThai], [SoLuong], [DonGia]) VALUES (N'DV4       ', N'Chăm sóc khách hàng', N'Bên trong', N'sử dụng dịch vụ bên trong khách sạn', 0, 1000, CAST(500000 AS Decimal(10, 0)))
GO
INSERT [dbo].[DONGLICHLV] ([MaNV], [TenNV], [TenBP]) VALUES (N'NV1       ', N'Đào Lê Hải An', N'Kế Toán')
INSERT [dbo].[DONGLICHLV] ([MaNV], [TenNV], [TenBP]) VALUES (N'NV2       ', N'Nguyễn Quang Tuấn', N'Hành Chính')
INSERT [dbo].[DONGLICHLV] ([MaNV], [TenNV], [TenBP]) VALUES (N'NV3       ', N'Đỗ Thanh Nhàn', N'Marketing')
INSERT [dbo].[DONGLICHLV] ([MaNV], [TenNV], [TenBP]) VALUES (N'NV4       ', N'Nguyễn Trần Trung Quân', N'Bếp')
GO
INSERT [dbo].[DONGPHIEUCC] ([MaNV], [TenNV], [TinhTrang]) VALUES (N'NV1       ', N'Đào Lê Hải An', 1)
INSERT [dbo].[DONGPHIEUCC] ([MaNV], [TenNV], [TinhTrang]) VALUES (N'NV2       ', N'Nguyễn Trần Trung Quân', 0)
INSERT [dbo].[DONGPHIEUCC] ([MaNV], [TenNV], [TinhTrang]) VALUES (N'NV3       ', N'Nguyễn Quang Tuấn', 1)
INSERT [dbo].[DONGPHIEUCC] ([MaNV], [TenNV], [TinhTrang]) VALUES (N'NV4       ', N'Lê Thanh Nhàn', 0)
GO
INSERT [dbo].[DONGPHIEULUONG] ([MaNV], [TenBP], [TenNV], [NgayCong], [TenChucVu], [TienThuong], [HeSoLuong], [LuongCB], [PhuCap], [ThanhTien]) VALUES (N'NV1       ', N'Kế Toán', N'Nguyễn Trần Trung Quân', 24, N'Trưởng phòng', CAST(2500000.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), CAST(6000000.00 AS Decimal(18, 2)), CAST(1500000.00 AS Decimal(18, 2)), CAST(436000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DONGPHIEULUONG] ([MaNV], [TenBP], [TenNV], [NgayCong], [TenChucVu], [TienThuong], [HeSoLuong], [LuongCB], [PhuCap], [ThanhTien]) VALUES (N'NV2       ', N'Hành Chính', N'Đào Thanh hà', 25, N'Phó phòng', CAST(2000000.00 AS Decimal(18, 2)), CAST(2.50 AS Decimal(18, 2)), CAST(5000000.00 AS Decimal(18, 2)), CAST(900000.00 AS Decimal(18, 2)), CAST(315400000.00 AS Decimal(18, 2)))
INSERT [dbo].[DONGPHIEULUONG] ([MaNV], [TenBP], [TenNV], [NgayCong], [TenChucVu], [TienThuong], [HeSoLuong], [LuongCB], [PhuCap], [ThanhTien]) VALUES (N'NV3       ', N'Marketing', N'Nguyễn Quang Tuấn', 26, N'Nhân Viên', CAST(1800000.00 AS Decimal(18, 2)), CAST(1.80 AS Decimal(18, 2)), CAST(4800000.00 AS Decimal(18, 2)), CAST(500000.00 AS Decimal(18, 2)), CAST(226940000.00 AS Decimal(18, 2)))
INSERT [dbo].[DONGPHIEULUONG] ([MaNV], [TenBP], [TenNV], [NgayCong], [TenChucVu], [TienThuong], [HeSoLuong], [LuongCB], [PhuCap], [ThanhTien]) VALUES (N'NV4       ', N'Bếp', N'Đỗ Thanh Nhàn', 23, N'Giám đốc', CAST(2100000.00 AS Decimal(18, 2)), CAST(3.90 AS Decimal(18, 2)), CAST(5200000.00 AS Decimal(18, 2)), CAST(700000.00 AS Decimal(18, 2)), CAST(469240000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[HOADON] ([MaHD], [TenHD], [MaKH], [MaDV], [MaPhong], [VAT]) VALUES (N'HD1       ', N'Hóa đơn phòng', N'KH1       ', N'DV1       ', N'PH2       ', CAST(0.20 AS Decimal(4, 2)))
INSERT [dbo].[HOADON] ([MaHD], [TenHD], [MaKH], [MaDV], [MaPhong], [VAT]) VALUES (N'HD2       ', N'Hóa đơn dịch vụ', N'KH3       ', N'DV3       ', N'PH3       ', CAST(0.30 AS Decimal(4, 2)))
INSERT [dbo].[HOADON] ([MaHD], [TenHD], [MaKH], [MaDV], [MaPhong], [VAT]) VALUES (N'HD3       ', N'Hóa khách hàng', N'KH2       ', N'DV2       ', N'PH1       ', CAST(0.44 AS Decimal(4, 2)))
INSERT [dbo].[HOADON] ([MaHD], [TenHD], [MaKH], [MaDV], [MaPhong], [VAT]) VALUES (N'HD4       ', N'Hóa đơn tổng', N'KH4       ', N'DV4       ', N'PH4       ', CAST(0.50 AS Decimal(4, 2)))
GO
INSERT [dbo].[HOADON_DV] ([MaDV], [MaHD], [LoaiDV], [TenDV], [SoLuongDV], [DonGiaDV], [ThanhTien]) VALUES (N'DV1       ', N'HD2       ', N'Bên ngoài khách sạn', N'Giặt là', 4, CAST(150000 AS Decimal(18, 0)), CAST(600000 AS Decimal(18, 0)))
INSERT [dbo].[HOADON_DV] ([MaDV], [MaHD], [LoaiDV], [TenDV], [SoLuongDV], [DonGiaDV], [ThanhTien]) VALUES (N'DV2       ', N'HD2       ', N'Bên trong khách sạn', N'Sửa chữa', 3, CAST(200000 AS Decimal(18, 0)), CAST(600000 AS Decimal(18, 0)))
INSERT [dbo].[HOADON_DV] ([MaDV], [MaHD], [LoaiDV], [TenDV], [SoLuongDV], [DonGiaDV], [ThanhTien]) VALUES (N'DV3       ', N'HD3       ', N'Bên trong khách sạn', N'Vận chuyển', 2, CAST(350000 AS Decimal(18, 0)), CAST(700000 AS Decimal(18, 0)))
INSERT [dbo].[HOADON_DV] ([MaDV], [MaHD], [LoaiDV], [TenDV], [SoLuongDV], [DonGiaDV], [ThanhTien]) VALUES (N'DV4       ', N'HD3       ', N'Bên trong', N'Chăm sóc khách hàng', 3, CAST(500000 AS Decimal(18, 0)), CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[HOADON_DV] ([MaDV], [MaHD], [LoaiDV], [TenDV], [SoLuongDV], [DonGiaDV], [ThanhTien]) VALUES (N'DV5       ', N'HD1       ', N'Bên ngoài khách sạn', N'Spa', 2, CAST(250000 AS Decimal(18, 0)), CAST(500000 AS Decimal(18, 0)))
GO
INSERT [dbo].[HOADON_KH] ([MaKH], [MaHD], [TenKH], [Email], [DiaChi], [ThoiGianThuePhong], [ThoiGianSDDV]) VALUES (N'KH1       ', N'HD3       ', N'Đỗ Thị Thùy Dương', N'duong@gmail.com', N'Hà Nội', 3, 2)
INSERT [dbo].[HOADON_KH] ([MaKH], [MaHD], [TenKH], [Email], [DiaChi], [ThoiGianThuePhong], [ThoiGianSDDV]) VALUES (N'KH2       ', N'HD2       ', N'Nguyễn Phương Mai', N'mai@gmail.com', N'Hải Dương', 4, 3)
INSERT [dbo].[HOADON_KH] ([MaKH], [MaHD], [TenKH], [Email], [DiaChi], [ThoiGianThuePhong], [ThoiGianSDDV]) VALUES (N'KH3       ', N'HD4       ', N'Trần Thanh Hải Nam', N'hainam@gmail.com', N'Mê Linh- Hà Nội', 5, 1)
INSERT [dbo].[HOADON_KH] ([MaKH], [MaHD], [TenKH], [Email], [DiaChi], [ThoiGianThuePhong], [ThoiGianSDDV]) VALUES (N'KH4       ', N'HD1       ', N'Dương Văn Trình', N'duongtrinh@gmail.com', N'Thanh Hóa', 8, 4)
GO
INSERT [dbo].[HOADON_PHONG] ([MaPhong], [MaHD], [LoaiPhong], [TenPhong], [SoLuongPhong], [DonGiaPhong], [ThanhTien]) VALUES (N'PH1       ', N'HD2       ', N'VIP', N'P101      ', 4, CAST(3500000 AS Decimal(18, 0)), CAST(14000000 AS Decimal(18, 0)))
INSERT [dbo].[HOADON_PHONG] ([MaPhong], [MaHD], [LoaiPhong], [TenPhong], [SoLuongPhong], [DonGiaPhong], [ThanhTien]) VALUES (N'PH2       ', N'HD3       ', N'Đơn', N'P201      ', 3, CAST(1500000 AS Decimal(18, 0)), CAST(4500000 AS Decimal(18, 0)))
INSERT [dbo].[HOADON_PHONG] ([MaPhong], [MaHD], [LoaiPhong], [TenPhong], [SoLuongPhong], [DonGiaPhong], [ThanhTien]) VALUES (N'PH3       ', N'HD1       ', N'Đôi', N'P301      ', 5, CAST(2500000 AS Decimal(18, 0)), CAST(12500000 AS Decimal(18, 0)))
INSERT [dbo].[HOADON_PHONG] ([MaPhong], [MaHD], [LoaiPhong], [TenPhong], [SoLuongPhong], [DonGiaPhong], [ThanhTien]) VALUES (N'PH4       ', N'HD4       ', N'Master', N'P401      ', 7, CAST(5000000 AS Decimal(18, 0)), CAST(35000000 AS Decimal(18, 0)))
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [CMND], [EmailKH], [SoDT], [DiaChi], [QuocTich], [GioiTinh], [LichHen]) VALUES (N'KH1       ', N'Đỗ Thị Thùy Dương', N'001301028555        ', N'duong@gmail.com', N'0982272491     ', N'Hà Nội', N'Việt Nam            ', 0, CAST(N'2012-10-02T00:00:00.000' AS DateTime))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [CMND], [EmailKH], [SoDT], [DiaChi], [QuocTich], [GioiTinh], [LichHen]) VALUES (N'KH2       ', N'Nguyễn Phương Mai', N'00130576921         ', N'mai@gmail.com', N'0925475188     ', N'Hải Dương', N'Trung Quốc          ', 0, CAST(N'2020-09-08T00:00:00.000' AS DateTime))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [CMND], [EmailKH], [SoDT], [DiaChi], [QuocTich], [GioiTinh], [LichHen]) VALUES (N'KH3       ', N'Trần Thanh Hải Hoàng', N'09167895421         ', N'hainam@gmail.com', N'0523590117     ', N'Mê Linh- Hà Nội', N'Canada              ', 1, CAST(N'2022-04-14T17:06:06.000' AS DateTime))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [CMND], [EmailKH], [SoDT], [DiaChi], [QuocTich], [GioiTinh], [LichHen]) VALUES (N'KH4       ', N'Dương Văn Trình', N'001301255785        ', N'duongtrinh@gmail.com', N'0987687541     ', N'Thanh Hóa', N'Việt Nam            ', 1, CAST(N'2022-04-15T00:00:00.000' AS DateTime))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [CMND], [EmailKH], [SoDT], [DiaChi], [QuocTich], [GioiTinh], [LichHen]) VALUES (N'KH5       ', N'Đào Lê Phương', N'0013012554          ', N'phuong@gmail.com', N'0982274567     ', N'Hà Nội', N'Thailand            ', 0, CAST(N'2022-04-19T17:46:43.000' AS DateTime))
GO
INSERT [dbo].[LICHLAMVIEC] ([SoLichLV], [MaNV], [CaLam], [GioVaoLam], [GioTanLam], [ViTriLamViec], [NhiemVu]) VALUES (N'LLV1      ', N'NV2       ', N'Ca 1      ', CAST(N'2021-11-04T07:00:00.000' AS DateTime), CAST(N'2021-11-04T16:00:00.000' AS DateTime), N'Bộ phận hành chính', N'Ghi chép sổ sách')
INSERT [dbo].[LICHLAMVIEC] ([SoLichLV], [MaNV], [CaLam], [GioVaoLam], [GioTanLam], [ViTriLamViec], [NhiemVu]) VALUES (N'LLV2      ', N'NV1       ', N'Ca 2      ', CAST(N'2021-10-05T12:00:00.000' AS DateTime), CAST(N'2021-10-05T23:00:00.000' AS DateTime), N'Bộ phận kế toán', N'Mở rộng việc thu hút khách hàng')
INSERT [dbo].[LICHLAMVIEC] ([SoLichLV], [MaNV], [CaLam], [GioVaoLam], [GioTanLam], [ViTriLamViec], [NhiemVu]) VALUES (N'LLV3      ', N'NV4       ', N'Ca 3      ', CAST(N'2021-08-04T18:00:00.000' AS DateTime), CAST(N'2021-09-04T07:00:00.000' AS DateTime), N'Bộ phận bếp', N'Làm mới thực đơn')
INSERT [dbo].[LICHLAMVIEC] ([SoLichLV], [MaNV], [CaLam], [GioVaoLam], [GioTanLam], [ViTriLamViec], [NhiemVu]) VALUES (N'LLV4      ', N'NV3       ', N'Ca 4      ', CAST(N'2021-09-04T04:00:00.000' AS DateTime), CAST(N'2021-09-04T02:30:00.000' AS DateTime), N'Bộ phận Marketing', N'Tiếp đón khách hàng')
GO
INSERT [dbo].[NGUOIDUNGHT] ([UserName], [Password], [LoaiNguoiDung]) VALUES (N'admin', N'12345678            ', N'Quản trị viên')
INSERT [dbo].[NGUOIDUNGHT] ([UserName], [Password], [LoaiNguoiDung]) VALUES (N'nhanvien', N'101201              ', N'Nhân viên')
INSERT [dbo].[NGUOIDUNGHT] ([UserName], [Password], [LoaiNguoiDung]) VALUES (N'nhanvien01', N'111111              ', N'Nhân viên')
INSERT [dbo].[NGUOIDUNGHT] ([UserName], [Password], [LoaiNguoiDung]) VALUES (N'quanly', N'amench              ', N'Quản lý')
INSERT [dbo].[NGUOIDUNGHT] ([UserName], [Password], [LoaiNguoiDung]) VALUES (N'quanly01', N'quanly              ', N'Quản lý')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [UserName], [TenNV], [TenBP], [NgaySinh], [GioiTinh], [DiaChi], [Email], [SoDT], [ChucVu], [ViTriLamViec]) VALUES (N'NV1       ', N'nhanvien', N'Đào Lê Hải Anh', N'Kế toán', CAST(N'2001-10-12T00:00:00.000' AS DateTime), 0, N' Hải Dương', N'haian01@gmail.com', N'0987655774          ', N'Nhân viên', N'Phòng kế toán')
INSERT [dbo].[NHANVIEN] ([MaNV], [UserName], [TenNV], [TenBP], [NgaySinh], [GioiTinh], [DiaChi], [Email], [SoDT], [ChucVu], [ViTriLamViec]) VALUES (N'NV2       ', N'quanly', N'Nguyễn Quang Hải', N'Hành chính', CAST(N'2001-08-16T00:00:00.000' AS DateTime), 1, N'Mê Linh - Hà Nội', N'quangtuan01@gmail.com', N'0743444755          ', N'Phó phòng', N'Phòng hành chính')
INSERT [dbo].[NHANVIEN] ([MaNV], [UserName], [TenNV], [TenBP], [NgaySinh], [GioiTinh], [DiaChi], [Email], [SoDT], [ChucVu], [ViTriLamViec]) VALUES (N'NV3       ', N'quanly', N'Lê Thanh Nhàn', N'Marketing', CAST(N'2001-05-06T00:00:00.000' AS DateTime), 1, N'Bà Rìa- Vũng Tàu', N'thanhnhan@gmail.com', N'0523789437          ', N'Trưởng phòng', N'Phòng Marketing')
INSERT [dbo].[NHANVIEN] ([MaNV], [UserName], [TenNV], [TenBP], [NgaySinh], [GioiTinh], [DiaChi], [Email], [SoDT], [ChucVu], [ViTriLamViec]) VALUES (N'NV4       ', N'nhanvien', N'Đào Lê Phương Thanh', N'Bếp', CAST(N'2001-07-04T00:00:00.000' AS DateTime), 0, N'Hoàng Mai- Hà Nội', N'phuongthoa@gmail.com', N'0674012345          ', N'Trợ lý', N'Phòng bếp')
GO
INSERT [dbo].[PHIEUCHAMCONG] ([MaPhieuCC], [MaNV], [NgayChamCong]) VALUES (N'CC1       ', N'NV1       ', CAST(N'2019-04-06T00:00:00.000' AS DateTime))
INSERT [dbo].[PHIEUCHAMCONG] ([MaPhieuCC], [MaNV], [NgayChamCong]) VALUES (N'CC2       ', N'NV3       ', CAST(N'2020-07-08T00:00:00.000' AS DateTime))
INSERT [dbo].[PHIEUCHAMCONG] ([MaPhieuCC], [MaNV], [NgayChamCong]) VALUES (N'CC3       ', N'NV2       ', CAST(N'2021-09-10T00:00:00.000' AS DateTime))
INSERT [dbo].[PHIEUCHAMCONG] ([MaPhieuCC], [MaNV], [NgayChamCong]) VALUES (N'CC4       ', N'NV4       ', CAST(N'2022-05-09T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[PHIEULUONG] ([MaPhieuLuong], [MaNV]) VALUES (N'PL1       ', N'NV1       ')
INSERT [dbo].[PHIEULUONG] ([MaPhieuLuong], [MaNV]) VALUES (N'PL2       ', N'NV2       ')
INSERT [dbo].[PHIEULUONG] ([MaPhieuLuong], [MaNV]) VALUES (N'PL3       ', N'NV3       ')
INSERT [dbo].[PHIEULUONG] ([MaPhieuLuong], [MaNV]) VALUES (N'PL4       ', N'NV4       ')
GO
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [LoaiPhong], [ViTriPhong], [SoLuong], [TinhTrang], [MoTaPhong], [DonGia]) VALUES (N'PH1       ', N'P101      ', N'VIP', N'Tầng 2              ', 10, 1, N'Sang trọng, quý phái', CAST(3500000 AS Decimal(18, 0)))
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [LoaiPhong], [ViTriPhong], [SoLuong], [TinhTrang], [MoTaPhong], [DonGia]) VALUES (N'PH2       ', N'P201      ', N'Đơn', N'Tầng 3 - tầng 5     ', 20, 0, N'Không gian riêng tu r?ng rãi', CAST(1500000 AS Decimal(18, 0)))
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [LoaiPhong], [ViTriPhong], [SoLuong], [TinhTrang], [MoTaPhong], [DonGia]) VALUES (N'PH3       ', N'P301      ', N'Đôi', N'Tầng 2              ', 15, 0, N'Không gian rộng, khép kín', CAST(2500000 AS Decimal(18, 0)))
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [LoaiPhong], [ViTriPhong], [SoLuong], [TinhTrang], [MoTaPhong], [DonGia]) VALUES (N'PH4       ', N'P401      ', N'Master', N'Tầng 6              ', 2, 1, N'VIP PRO', CAST(5000000 AS Decimal(18, 0)))
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [LoaiPhong], [ViTriPhong], [SoLuong], [TinhTrang], [MoTaPhong], [DonGia]) VALUES (N'PH5       ', N'P507', N'VIP', N'Tầng 3              ', 2, 0, N'Đẹp', CAST(2500000 AS Decimal(18, 0)))
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_DICHVU] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DICHVU] ([MaDV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_DICHVU]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_PHONG] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_PHONG]
GO
ALTER TABLE [dbo].[HOADON_DV]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_DV_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[HOADON_DV] CHECK CONSTRAINT [FK_HOADON_DV_HOADON]
GO
ALTER TABLE [dbo].[HOADON_KH]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KH_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[HOADON_KH] CHECK CONSTRAINT [FK_HOADON_KH_HOADON]
GO
ALTER TABLE [dbo].[HOADON_PHONG]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_PHONG_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[HOADON_PHONG] CHECK CONSTRAINT [FK_HOADON_PHONG_HOADON]
GO
ALTER TABLE [dbo].[LICHLAMVIEC]  WITH CHECK ADD  CONSTRAINT [FK_LICHLAMVIEC_DONGLICHLV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[DONGLICHLV] ([MaNV])
GO
ALTER TABLE [dbo].[LICHLAMVIEC] CHECK CONSTRAINT [FK_LICHLAMVIEC_DONGLICHLV]
GO
ALTER TABLE [dbo].[LICHLAMVIEC]  WITH CHECK ADD  CONSTRAINT [FK_LICHLAMVIEC_DONGPHIEUCC] FOREIGN KEY([MaNV])
REFERENCES [dbo].[DONGPHIEUCC] ([MaNV])
GO
ALTER TABLE [dbo].[LICHLAMVIEC] CHECK CONSTRAINT [FK_LICHLAMVIEC_DONGPHIEUCC]
GO
ALTER TABLE [dbo].[LICHLAMVIEC]  WITH CHECK ADD  CONSTRAINT [FK_LICHLAMVIEC_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[LICHLAMVIEC] CHECK CONSTRAINT [FK_LICHLAMVIEC_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_NGUOIDUNG_HT] FOREIGN KEY([UserName])
REFERENCES [dbo].[NGUOIDUNGHT] ([UserName])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_NGUOIDUNG_HT]
GO
ALTER TABLE [dbo].[PHIEUCHAMCONG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHAMCONG_DONGLICHLV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[DONGLICHLV] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUCHAMCONG] CHECK CONSTRAINT [FK_PHIEUCHAMCONG_DONGLICHLV]
GO
ALTER TABLE [dbo].[PHIEUCHAMCONG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHAMCONG_DONGPHIEULUONG] FOREIGN KEY([MaNV])
REFERENCES [dbo].[DONGPHIEULUONG] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUCHAMCONG] CHECK CONSTRAINT [FK_PHIEUCHAMCONG_DONGPHIEULUONG]
GO
ALTER TABLE [dbo].[PHIEUCHAMCONG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUCHAMCONG_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUCHAMCONG] CHECK CONSTRAINT [FK_PHIEUCHAMCONG_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEULUONG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEULUONG_DONGPHIEULUONG] FOREIGN KEY([MaNV])
REFERENCES [dbo].[DONGPHIEULUONG] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEULUONG] CHECK CONSTRAINT [FK_PHIEULUONG_DONGPHIEULUONG]
GO
ALTER TABLE [dbo].[PHIEULUONG]  WITH CHECK ADD  CONSTRAINT [FK_PHIEULUONG_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEULUONG] CHECK CONSTRAINT [FK_PHIEULUONG_NHANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[Update_password]    Script Date: 4/17/2022 12:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_password] 
	-- Add the parameters for the stored procedure here
	@User nvarchar(50),
    @OldPass nvarchar(50),
    @NewPass nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	if exists (select * from NGUOIDUNGHT where UserName = @User and Password = @OldPass)
    begin
        update NGUOIDUNGHT set Password = @NewPass where UserName = @User
        select 1 as code, N'Thay đổi mật khẩu thành công !!' as MSG
    end
    else
        select 0 as code, N'Tài khoản hoặc mật khẩu sai !!' as MSG
END
GO
