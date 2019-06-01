USE [master]
GO
/****** Object:  Database [QLTV]    Script Date: 5/20/2019 9:46:07 PM ******/
CREATE DATABASE [QLTV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLTV.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLTV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLTV_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLTV] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLTV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLTV] SET  MULTI_USER 
GO
ALTER DATABASE [QLTV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLTV] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLTV]
GO
/****** Object:  Table [dbo].[CTPHIEUMUONTRA]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPHIEUMUONTRA](
	[MAPHIEU] [nchar](10) NOT NULL,
	[MASACH] [nchar](10) NOT NULL,
	[SOLUONGTRA] [int] NULL,
	[NGAYTRA] [date] NULL,
	[SOLUONGMUON] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEU] ASC,
	[MASACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Login](
	[taikhoan] [varchar](50) NOT NULL,
	[matkhau] [varchar](100) NULL,
	[phanquyen] [nvarchar](50) NULL,
	[MANV] [nchar](10) NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [nchar](10) NOT NULL,
	[TENNV] [nvarchar](50) NULL,
	[NGAYSINH] [datetime] NULL,
	[GIOITINH] [nvarchar](4) NULL,
	[DIACHI] [nvarchar](30) NULL,
	[LUONG] [int] NULL,
	[SDT] [char](10) NULL,
	[HINHANH] [varchar](max) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUMUONTRA]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUONTRA](
	[MAPHIEU] [nchar](10) NOT NULL,
	[MASV] [nchar](10) NULL,
	[MANV] [nchar](10) NULL,
	[NGAYMUON] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SACH]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SACH](
	[MASACH] [nchar](10) NOT NULL,
	[TENSACH] [nvarchar](50) NULL,
	[TENTG] [nvarchar](50) NULL,
	[NAMXUATBAN] [varchar](8) NULL,
	[SOLUONG] [int] NULL,
	[MATHELOAI] [char](10) NULL,
 CONSTRAINT [PK__SACH__3FC48E4C4E288F6C] PRIMARY KEY CLUSTERED 
(
	[MASACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [nchar](10) NOT NULL,
	[TENSV] [nvarchar](50) NULL,
	[NGAYSINH] [datetime] NULL,
	[GIOITINH] [nvarchar](4) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[LOP] [nvarchar](50) NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MATHELOAI] [char](10) NOT NULL,
	[TENTHELOAI] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MATHELOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CTPHIEUMUONTRA] ([MAPHIEU], [MASACH], [SOLUONGTRA], [NGAYTRA], [SOLUONGMUON]) VALUES (N'P001      ', N'MS02      ', NULL, NULL, 5)
INSERT [dbo].[CTPHIEUMUONTRA] ([MAPHIEU], [MASACH], [SOLUONGTRA], [NGAYTRA], [SOLUONGMUON]) VALUES (N'P001      ', N'MS03      ', NULL, NULL, 10)
INSERT [dbo].[CTPHIEUMUONTRA] ([MAPHIEU], [MASACH], [SOLUONGTRA], [NGAYTRA], [SOLUONGMUON]) VALUES (N'P001      ', N'MS09      ', NULL, NULL, 6)
INSERT [dbo].[CTPHIEUMUONTRA] ([MAPHIEU], [MASACH], [SOLUONGTRA], [NGAYTRA], [SOLUONGMUON]) VALUES (N'P005      ', N'MS04      ', NULL, NULL, 2)
INSERT [dbo].[CTPHIEUMUONTRA] ([MAPHIEU], [MASACH], [SOLUONGTRA], [NGAYTRA], [SOLUONGMUON]) VALUES (N'P005      ', N'MS06      ', NULL, NULL, 12)
INSERT [dbo].[CTPHIEUMUONTRA] ([MAPHIEU], [MASACH], [SOLUONGTRA], [NGAYTRA], [SOLUONGMUON]) VALUES (N'P005      ', N'MS10      ', NULL, NULL, 12)
INSERT [dbo].[CTPHIEUMUONTRA] ([MAPHIEU], [MASACH], [SOLUONGTRA], [NGAYTRA], [SOLUONGMUON]) VALUES (N'P007      ', N'MS04      ', 10, CAST(N'2019-05-11' AS Date), 5)
INSERT [dbo].[CTPHIEUMUONTRA] ([MAPHIEU], [MASACH], [SOLUONGTRA], [NGAYTRA], [SOLUONGMUON]) VALUES (N'P007      ', N'MS09      ', NULL, NULL, 5)
INSERT [dbo].[CTPHIEUMUONTRA] ([MAPHIEU], [MASACH], [SOLUONGTRA], [NGAYTRA], [SOLUONGMUON]) VALUES (N'P008      ', N'MS02      ', NULL, NULL, 13)
INSERT [dbo].[CTPHIEUMUONTRA] ([MAPHIEU], [MASACH], [SOLUONGTRA], [NGAYTRA], [SOLUONGMUON]) VALUES (N'P009      ', N'MS15      ', 10, CAST(N'2019-06-11' AS Date), 4)
INSERT [dbo].[CTPHIEUMUONTRA] ([MAPHIEU], [MASACH], [SOLUONGTRA], [NGAYTRA], [SOLUONGMUON]) VALUES (N'P010      ', N'MS06      ', NULL, NULL, 20)
INSERT [dbo].[Login] ([taikhoan], [matkhau], [phanquyen], [MANV]) VALUES (N'admin', N'123', N'ADMIN', N'NV00      ')
INSERT [dbo].[Login] ([taikhoan], [matkhau], [phanquyen], [MANV]) VALUES (N'admin98', N'1', N'Nhân Viên', N'NV02      ')
INSERT [dbo].[Login] ([taikhoan], [matkhau], [phanquyen], [MANV]) VALUES (N'duong', N'1', N'Nhân Viên', N'NV01      ')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [GIOITINH], [DIACHI], [LUONG], [SDT], [HINHANH]) VALUES (N'NV00      ', N'Nguyễn Văn An', CAST(N'1998-02-01 00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', 3000000, N'0389873736', N'face1.jpg')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [GIOITINH], [DIACHI], [LUONG], [SDT], [HINHANH]) VALUES (N'NV01      ', N'Nguyễn Thu Hương', CAST(N'1991-03-23 00:00:00.000' AS DateTime), N'Nữ', N'Hà Nam', 7900000, N'0387645352', N'face6.jpg')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [GIOITINH], [DIACHI], [LUONG], [SDT], [HINHANH]) VALUES (N'NV02      ', N'Bùi Linh', CAST(N'1997-10-01 00:00:00.000' AS DateTime), N'Nữ', N'Bắc Giang', 3200000, N'0387965252', N'face2.jpg')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [GIOITINH], [DIACHI], [LUONG], [SDT], [HINHANH]) VALUES (N'NV03      ', N'Nguyễn Thùy Linh', CAST(N'1998-10-01 00:00:00.000' AS DateTime), N'Nữ', N'Nam Định', 3000000, N'0362769872', NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [GIOITINH], [DIACHI], [LUONG], [SDT], [HINHANH]) VALUES (N'NV04      ', N'Nguyễn Công Bình', CAST(N'1998-02-01 00:00:00.000' AS DateTime), N'Nam', N'Thái Bình', 4000000, N'0398383837', NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [GIOITINH], [DIACHI], [LUONG], [SDT], [HINHANH]) VALUES (N'NV05      ', N'Nguyễn Thị Minh', CAST(N'1998-02-01 00:00:00.000' AS DateTime), N'Nữ', N'Bình Dương', 5000000, N'0318282764', NULL)
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [GIOITINH], [DIACHI], [LUONG], [SDT], [HINHANH]) VALUES (N'NV07      ', N'Nguyễn Văn Lương', CAST(N'1998-02-01 00:00:00.000' AS DateTime), N'Nam', N'Hà Nội', 3000000, N'0389873730', N'face3.jpg')
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [NGAYSINH], [GIOITINH], [DIACHI], [LUONG], [SDT], [HINHANH]) VALUES (N'NV08      ', N'Nguyễn Văn Trác', CAST(N'1982-10-11 00:00:00.000' AS DateTime), N'Nam', N'Hà Tĩnh', 7800000, N'0389561234', N'face12.jpg')
INSERT [dbo].[PHIEUMUONTRA] ([MAPHIEU], [MASV], [MANV], [NGAYMUON]) VALUES (N'P001      ', N'SV02      ', N'NV02      ', CAST(N'2018-12-10' AS Date))
INSERT [dbo].[PHIEUMUONTRA] ([MAPHIEU], [MASV], [MANV], [NGAYMUON]) VALUES (N'P005      ', N'SV03      ', N'NV01      ', CAST(N'2018-10-10' AS Date))
INSERT [dbo].[PHIEUMUONTRA] ([MAPHIEU], [MASV], [MANV], [NGAYMUON]) VALUES (N'P007      ', N'SV06      ', N'NV03      ', CAST(N'2018-05-23' AS Date))
INSERT [dbo].[PHIEUMUONTRA] ([MAPHIEU], [MASV], [MANV], [NGAYMUON]) VALUES (N'P008      ', N'SV04      ', N'NV01      ', CAST(N'2018-05-29' AS Date))
INSERT [dbo].[PHIEUMUONTRA] ([MAPHIEU], [MASV], [MANV], [NGAYMUON]) VALUES (N'P009      ', N'SV07      ', N'NV04      ', CAST(N'2019-05-11' AS Date))
INSERT [dbo].[PHIEUMUONTRA] ([MAPHIEU], [MASV], [MANV], [NGAYMUON]) VALUES (N'P010      ', N'SV01      ', N'NV05      ', CAST(N'2019-05-19' AS Date))
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TENTG], [NAMXUATBAN], [SOLUONG], [MATHELOAI]) VALUES (N'MS01      ', N'Đắc Nhân Tâm', N'Nguyễn Văn An', N'2000', 60, N'T001      ')
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TENTG], [NAMXUATBAN], [SOLUONG], [MATHELOAI]) VALUES (N'MS02      ', N'Lập Trình Java Cơ bản', N'Bùi Lâm', N'2010', 98, N'T002      ')
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TENTG], [NAMXUATBAN], [SOLUONG], [MATHELOAI]) VALUES (N'MS03      ', N'Lập Trình C#', N'Bùi Văn Ga', N'2005', 54, N'T002      ')
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TENTG], [NAMXUATBAN], [SOLUONG], [MATHELOAI]) VALUES (N'MS04      ', N'Biển Xanh', N'Bùi Văn Lâm', N'2000', 107, N'T001      ')
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TENTG], [NAMXUATBAN], [SOLUONG], [MATHELOAI]) VALUES (N'MS05      ', N'Sách Tham Khảo 88', N'Lâm Chí Quan', N'2010', 40, N'T003      ')
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TENTG], [NAMXUATBAN], [SOLUONG], [MATHELOAI]) VALUES (N'MS06      ', N'Hoa Nguyệt', N'Nguyễn Thanh Phong', N'1997', 580, N'T001      ')
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TENTG], [NAMXUATBAN], [SOLUONG], [MATHELOAI]) VALUES (N'MS07      ', N'Nước Mắt Tự Do', N'Nguyễn Nhật Ánh', N'2000', 20, N'T001      ')
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TENTG], [NAMXUATBAN], [SOLUONG], [MATHELOAI]) VALUES (N'MS08      ', N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', N'Nguyễn Nhật Trung', N'1997', 295, N'T001      ')
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TENTG], [NAMXUATBAN], [SOLUONG], [MATHELOAI]) VALUES (N'MS09      ', N'Truyện Kiều', N'Nguyễn Du', N'1992', 389, N'T001      ')
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TENTG], [NAMXUATBAN], [SOLUONG], [MATHELOAI]) VALUES (N'MS10      ', N'Dế Mèn Phiêu Lưu Ký', N'Tố Hữu', N'2011', 70, N'T004      ')
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TENTG], [NAMXUATBAN], [SOLUONG], [MATHELOAI]) VALUES (N'MS11      ', N'Sách Tham Khảo 88', N'Trần Minh Lâm', N'2010', 100, N'T003      ')
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TENTG], [NAMXUATBAN], [SOLUONG], [MATHELOAI]) VALUES (N'MS12      ', N'Công Tác Văn Phòng', N'Nguyễn Trọng Lưu', N'2012', 100, N'T003      ')
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TENTG], [NAMXUATBAN], [SOLUONG], [MATHELOAI]) VALUES (N'MS13      ', N'Công Nghệ Phần Mềm', N'Bùi Đình Thủy', N'2012', 95, N'T002      ')
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TENTG], [NAMXUATBAN], [SOLUONG], [MATHELOAI]) VALUES (N'MS14      ', N'Công Nghệ Lập Trình Tích Hợp', N'Nguyễn Hào Lâm', N'2018', 98, N'T002      ')
INSERT [dbo].[SACH] ([MASACH], [TENSACH], [TENTG], [NAMXUATBAN], [SOLUONG], [MATHELOAI]) VALUES (N'MS15      ', N'Trái Tim Mùa Thu', N'Huỳnh Nhật Minh', N'2015', 96, N'T001      ')
INSERT [dbo].[SINHVIEN] ([MASV], [TENSV], [NGAYSINH], [GIOITINH], [DIACHI], [LOP]) VALUES (N'SV01      ', N'Nguyễn Thi Sen', CAST(N'1998-05-13 00:00:00.000' AS DateTime), N'Nữ', N'Hà Nam', N'CNTT14')
INSERT [dbo].[SINHVIEN] ([MASV], [TENSV], [NGAYSINH], [GIOITINH], [DIACHI], [LOP]) VALUES (N'SV02      ', N'Trần Quang Khải', CAST(N'1998-05-13 00:00:00.000' AS DateTime), N'Nam', N'Thái Bình', N'MMT15')
INSERT [dbo].[SINHVIEN] ([MASV], [TENSV], [NGAYSINH], [GIOITINH], [DIACHI], [LOP]) VALUES (N'SV03      ', N'Chu Ngọc Ánh', CAST(N'1997-12-01 00:00:00.000' AS DateTime), N'Nữ', N'Hà Nội', N'MMT15')
INSERT [dbo].[SINHVIEN] ([MASV], [TENSV], [NGAYSINH], [GIOITINH], [DIACHI], [LOP]) VALUES (N'SV04      ', N'Nguyễn Trần Bảo Duy', CAST(N'1997-01-01 00:00:00.000' AS DateTime), N'Nam', N'Hà Giang', N'HTTT14')
INSERT [dbo].[SINHVIEN] ([MASV], [TENSV], [NGAYSINH], [GIOITINH], [DIACHI], [LOP]) VALUES (N'SV05      ', N'Nguyễn Gia Lâm', CAST(N'1996-02-03 00:00:00.000' AS DateTime), N'Nam', N'Hải Dương', N'KHMT13')
INSERT [dbo].[SINHVIEN] ([MASV], [TENSV], [NGAYSINH], [GIOITINH], [DIACHI], [LOP]) VALUES (N'SV06      ', N'Bùi Chí Tài', CAST(N'1997-04-05 00:00:00.000' AS DateTime), N'Nam', N'Hưng Yên', N'CNTT15')
INSERT [dbo].[SINHVIEN] ([MASV], [TENSV], [NGAYSINH], [GIOITINH], [DIACHI], [LOP]) VALUES (N'SV07      ', N'Dương Lâm Vỹ', CAST(N'1996-03-02 00:00:00.000' AS DateTime), N'Nam', N'Thái Bình', N'CNTT13')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (N'T001      ', N'Văn Học')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (N'T002      ', N'Tin Học')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (N'T003      ', N'Sách Tham Khảo')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (N'T004      ', N'Truyện Đọc')
INSERT [dbo].[THELOAI] ([MATHELOAI], [TENTHELOAI]) VALUES (N'T005      ', N'Trinh Thám')
ALTER TABLE [dbo].[CTPHIEUMUONTRA]  WITH CHECK ADD FOREIGN KEY([MAPHIEU])
REFERENCES [dbo].[PHIEUMUONTRA] ([MAPHIEU])
GO
ALTER TABLE [dbo].[CTPHIEUMUONTRA]  WITH CHECK ADD FOREIGN KEY([MASACH])
REFERENCES [dbo].[SACH] ([MASACH])
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[PHIEUMUONTRA]  WITH CHECK ADD FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[PHIEUMUONTRA]  WITH CHECK ADD FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_THELOAI] FOREIGN KEY([MATHELOAI])
REFERENCES [dbo].[THELOAI] ([MATHELOAI])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_THELOAI]
GO
/****** Object:  StoredProcedure [dbo].[CAPNHAT_NGUOIDUNG]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[CAPNHAT_NGUOIDUNG](
@MANV NCHAR(10),
@HINHANH VARCHAR(MAX)
)
AS
BEGIN
	UPDATE  NHANVIEN
	SET HINHANH = @HINHANH
	WHERE MANV = @MANV
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_PhieuMuon]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETE_PhieuMuon](@maphieu varchar(10))
AS
BEGIN
	DELETE dbo.PHIEUMUON WHERE MAPM=@maphieu
END

GO
/****** Object:  StoredProcedure [dbo].[DELETE_SinhVien]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETE_SinhVien](@masinh varchar(10))
AS
BEGIN
	DELETE dbo.CHITIETPHIEUMUON WHERE MAPM IN (SELECT MAPM FROM dbo.PHIEUMUON WHERE MASV =@masinh)
	DELETE dbo.PHIEUMUON WHERE MASV=@masinh
	DELETE dbo.SINHVIEN WHERE MASV =@masinh
END
GO
/****** Object:  StoredProcedure [dbo].[DELETE_TAIKHOAN]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETE_TAIKHOAN](
@taikhoan NCHAR(10)
)
AS
BEGIN
	DELETE Login WHERE taikhoan = @taikhoan
END

GO
/****** Object:  StoredProcedure [dbo].[INPHIEUMUON]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INPHIEUMUON]
(
@MAPM NCHAR(10)
)AS BEGIN
	DECLARE @sql nvarchar(max)
	set @sql='  select N.TENNV, SV.TENSV, S.TENSACH,C.SOLUONGMUON,P.NGAYMUON
				from PHIEUMUONTRA P, CTPHIEUMUONTRA C, SACH S, NHANVIEN N,SINHVIEN SV
				where P.MAPHIEU = C.MAPHIEU and C.MASACH = S.MASACH and P.MANV = N.MANV AND P.MASV=SV.MASV AND C.MAPHIEU='''+@MAPM+''' '	
	PRINT (@sql)									
	EXEC(@sql)
END
GO
/****** Object:  StoredProcedure [dbo].[INRAPHIEUMUON]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[INRAPHIEUMUON] @mapm nchar(10)
as select C.MAPHIEU,TENNV,TENSV,TENSACH,SOLUONGMUON,NGAYMUON FROM PHIEUMUONTRA P,NHANVIEN N,SINHVIEN SV,CTPHIEUMUONTRA C,SACH S
WHERE C.MAPHIEU=P.MAPHIEU AND N.MANV=P.MANV AND S.MASACH=C.MASACH AND SV.MASV=P.MASV AND C.MAPHIEU=@mapm
GO
/****** Object:  StoredProcedure [dbo].[INRAPHIEUTRA]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[INRAPHIEUTRA] @mapm nchar(10)
as select C.MAPHIEU,TENNV,TENSV,TENSACH,SOLUONGMUON,SOLUONGTRA,NGAYTRA FROM PHIEUMUONTRA P,NHANVIEN N,SINHVIEN SV,CTPHIEUMUONTRA C,SACH S
WHERE C.MAPHIEU=P.MAPHIEU AND N.MANV=P.MANV AND S.MASACH=C.MASACH AND SV.MASV=P.MASV AND C.MAPHIEU=@mapm
GO
/****** Object:  StoredProcedure [dbo].[Insert_Phieumuon]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_Phieumuon](@maphieu nchar(10), @masv nchar(10), @manv nchar(10),@ngaymuon date)
AS
BEGIN
	INSERT INTO dbo.PHIEUMUONTRA 
	        ( MAPHIEU ,
	          MASV ,
	          MANV ,
	          NGAYMUON
	        )
	VALUES  ( @maphieu , -- MAPM - nchar(10)
	          @masv , -- MANV - nchar(10)
	          @manv , -- MASV - nchar(10)
	          @ngaymuon  -- NGAYMUON - datetime
	        )
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_SinhVien]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_SinhVien](@masv varchar(10), @hoten nvarchar(100),@gioitinh nvarchar(10), @ngaysinh datetime, @diachi nvarchar(100),@lop varchar(25))
AS
BEGIN
	INSERT INTO dbo.SINHVIEN
	        ( MASV ,
	          TENSV ,
	          NGAYSINH ,
	          GIOITINH ,
	          DIACHI ,
	          LOP
	        )
	VALUES  ( @masv, -- MASV - nchar(10)
	          @hoten, -- TENSV - nvarchar(50)
	          @ngaysinh , -- NGAYSINH - datetime
	          @gioitinh , -- GIOITINH - nvarchar(4)
	          @diachi, -- DIACHI - nvarchar(50)
	          @lop-- LOP - nvarchar(50)
	        )
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_taikhoan]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_taikhoan](@taikhoan varchar(50), @matkhau varchar(100), @phanquyen nvarchar(50),@manv nchar(10))
AS
BEGIN
	INSERT INTO Login 
	        ( taikhoan,
	          matkhau,
	          phanquyen,
			  MANV
	        )
	VALUES  ( @taikhoan , -- MAPM - nchar(10)
	          @matkhau , -- MANV - nchar(10)
	          @phanquyen , -- MASV - nchar(10)
	          @manv  -- NGAYMUON - datetime
	        )
END
GO
/****** Object:  StoredProcedure [dbo].[PhieuMuon_All]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PhieuMuon_All]
AS
BEGIN
	SELECT MAPM,TENNV, TENSV,NGAYMUON, NGAYTRA,GHICHU FROM dbo.PHIEUMUON INNER JOIN dbo.NHANVIEN ON NHANVIEN.MANV = PHIEUMUON.MANV INNER JOIN dbo.SINHVIEN ON SINHVIEN.MASV = PHIEUMUON.MASV
END

GO
/****** Object:  StoredProcedure [dbo].[SinhVien_SelectAll]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SinhVien_SelectAll]
AS
BEGIN
	
	  Select C.MAPHIEU, N.TENNV, SV.TENSV, S.TENSACH,C.SOLUONGMUON,P.NGAYMUON
				from PHIEUMUONTRA P, CTPHIEUMUONTRA C, SACH S, NHANVIEN N,SINHVIEN SV
				where P.MAPHIEU = C.MAPHIEU and C.MASACH = S.MASACH and P.MANV = N.MANV AND P.MASV=SV.MASV
	
END
GO
/****** Object:  StoredProcedure [dbo].[suactphieumuontra]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suactphieumuontra](@maphieu nchar(10),@masach nchar(10),@soluongtra int,@ngaytra date,@soluongmuon int)
as 
begin
	UPDATE CTPHIEUMUONTRA SET MASACH=@masach,SOLUONGTRA=@soluongtra,NGAYTRA=@ngaytra, SOLUONGMUON=@soluongmuon WHERE MAPHIEU=@maphieu
	UPDATE SACH set SOLUONG=SOLUONG +@soluongtra where MASACH=@masach
	Update CTPHIEUMUONTRA set SOLUONGMUON=@soluongmuon-@soluongtra  where MASACH=@masach and MAPHIEU=@maphieu
end
GO
/****** Object:  StoredProcedure [dbo].[SuaCTPM]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaCTPM](@maphieu varchar(10),@masach varchar(10),@soluong int)
AS
BEGIN
	UPDATE dbo.CHITIETPHIEUMUON SET MASACH=@masach,SOLUONGMUON=@soluong WHERE MAPM=@maphieu
END
GO
/****** Object:  StoredProcedure [dbo].[SuaPhieuMuonTra]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[SuaPhieuMuonTra](@maphieu nchar(10),@masv nchar(10),@manv nchar(10),@ngaymuon date)
AS
BEGIN
	UPDATE dbo.PHIEUMUONTRA SET MASV=@masv,MANV=@manv,NGAYMUON=@ngaymuon WHERE MAPHIEU=@maphieu
END
GO
/****** Object:  StoredProcedure [dbo].[SuaSach]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaSach](@MASACH NCHAR(10), @TENSACH NVARCHAR(50), @TENTG NVARCHAR(50) ,@NAMXUATBAN VARCHAR(8), @SOLUONG INT ,@MATHELOAI NCHAR(10))
AS BEGIN
UPDATE SACH SET TENSACH=@TENSACH,TENTG=@TENTG,NAMXUATBAN=@NAMXUATBAN,SOLUONG=@SOLUONG,MATHELOAI=@MATHELOAI WHERE MASACH=@MASACH
END
GO
/****** Object:  StoredProcedure [dbo].[THEM_TAIKHOAN]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[THEM_TAIKHOAN](
@taikhoan NvarCHAR(50),
@matkhau NvarCHAR(50),
@MANV NCHAR(10),
@phanquyen NCHAR(10)
)
AS
BEGIN
	INSERT INTO Login
	VALUES (@taikhoan,@matkhau, @MANV, @phanquyen )
END
GO
/****** Object:  StoredProcedure [dbo].[ThemCTPhieuMuonTra]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemCTPhieuMuonTra](@maphieu nchar(10),@masach nchar(10),@soluongtra int,@ngaytra date,@soluongmuon int)
as 
begin
	insert CTPHIEUMUONTRA values (@maphieu,@masach,@soluongtra,@ngaytra,@soluongmuon)
	update SACH set SOLUONG-=@soluongmuon where	 MASACH=@masach
	update SACH set SOLUONG+=@soluongtra where	 MASACH=@masach
	update CTPHIEUMUONTRA set SOLUONGMUON=@soluongmuon-@soluongtra where MASACH=@masach
end
GO
/****** Object:  StoredProcedure [dbo].[ThemCTPM]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROC [dbo].[ThemCTPM](@maphieu varchar(10),@masach varchar(10),@soluong int)
	AS
    BEGIN
    	INSERT INTO dbo.CHITIETPHIEUMUON 
    	        ( MAPM, MASACH, SOLUONGMUON )
    	VALUES  ( @maphieu, -- MAPM - nchar(10)
    	          @masach, -- MASACH - nchar(10)
    	          @soluong  -- SOLUONGMUON - int
    	          )
    END
GO
/****** Object:  StoredProcedure [dbo].[ThemCTPMT123]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemCTPMT123](@maphieu nchar(10),@masach nchar(10),@soluongmuon int)
as 
begin
	insert into CTPHIEUMUONTRA values (@maphieu,@masach,null,null,@soluongmuon)
	update SACH set SOLUONG=SOLUONG  - @soluongmuon where	 MASACH=@masach
end
GO
/****** Object:  StoredProcedure [dbo].[themphieumuon]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[themphieumuon](@maphieu nchar(10),@masach nchar(10),@soluongtra int,@ngaytra date,@soluongmuon int)
as 
begin
	insert into CTPHIEUMUONTRA values (@maphieu,@masach,@soluongtra,@ngaytra,@soluongmuon)
	update SACH set SOLUONG-=@soluongmuon where	 MASACH=@masach
	update SACH set SOLUONG+=@soluongtra where	 MASACH=@masach
	update CTPHIEUMUONTRA set SOLUONGMUON=@soluongmuon-@soluongtra where MASACH=@masach
end
GO
/****** Object:  StoredProcedure [dbo].[themphieumuontra]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themphieumuontra](@maphieu nchar(10),@masach nchar(10),@ngaytra date,@soluongmuon int)
as 
begin
	insert into CTPHIEUMUONTRA values (@maphieu,@masach,null,@ngaytra,@soluongmuon)
	update SACH set SOLUONG=SOLUONG  - @soluongmuon where	 MASACH=@masach
end
GO
/****** Object:  StoredProcedure [dbo].[THEMPHIEUMUONTRA123]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[THEMPHIEUMUONTRA123](@maphieu nchar(10), @masv nchar(10), @manv nchar(10),@ngaymuon date)
AS
BEGIN
	INSERT INTO dbo.PHIEUMUONTRA 
	        ( MAPHIEU ,
	          MASV ,
	          MANV ,
	          NGAYMUON
	        )
	VALUES  ( @maphieu , -- MAPM - nchar(10)
	          @masv , -- MANV - nchar(10)
	          @manv , -- MASV - nchar(10)
	          @ngaymuon  -- NGAYMUON - datetime
	        )
END
GO
/****** Object:  StoredProcedure [dbo].[themphieumuontra12345]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themphieumuontra12345](@maphieu nchar(10),@masach nchar(10),@soluongtra int,@ngaytra date,@soluongmuon int)
as 
begin
	insert into CTPHIEUMUONTRA values (@maphieu,@masach,@soluongtra,@ngaytra,@soluongmuon)
	update SACH set SOLUONG=SOLUONG  - @soluongmuon where	 MASACH=@masach
	update SACH set SOLUONG=SOLUONG + @soluongtra where	 MASACH=@masach
	if (@soluongtra!=NULL)
	update CTPHIEUMUONTRA set SOLUONGMUON=@soluongmuon-@soluongtra ,SOLUONGTRA=NULL where  MASACH=@masach
	
end
GO
/****** Object:  StoredProcedure [dbo].[THEMTAIKHOAN]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
creaTE PROC [dbo].[THEMTAIKHOAN](
@taikhoan NVARCHAR(50),
@matkhau NvarCHAR(50),
@MANV NCHAR(10),
@phanquyen NvarCHAR(50)
)
AS
BEGIN
	INSERT INTO Login
	VALUES (@taikhoan,@matkhau,@MANV,@phanquyen)
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Phieumuon]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Update_Phieumuon](@maphieu varchar(10), @manv varchar(10), @masv varchar(10),@ngaytao datetime, @ngaytra datetime, @ghichu nvarchar(100))
AS
BEGIN
	UPDATE dbo.PHIEUMUON SET MANV=@manv,MASV=@masv,NGAYMUON=@ngaytao, NGAYTRA=@ngaytra WHERE MAPM=@maphieu
END

GO
/****** Object:  StoredProcedure [dbo].[Update_SinhVien]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_SinhVien](@masv varchar(10), @hoten nvarchar(100),@gioitinh nvarchar(10), @ngaysinh datetime, @diachi nvarchar(100),@lop varchar(25))
AS
 BEGIN
 	UPDATE dbo.SINHVIEN SET TENSV=@hoten,NGAYSINH=@ngaysinh,GIOITINH=@gioitinh,DIACHI=@diachi,LOP=@lop WHERE MASV=@masv
 END
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_TAIKHOAN]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATE_TAIKHOAN](
@taikhoan varCHAR(10),
@matkhau varCHAR(10),
@phanquyen NvarCHAR(10),
@MANV NCHAR(10)
)
AS
BEGIN
	UPDATE Login
	SET matkhau = @matkhau,phanquyen = @phanquyen,MANV = @MANV
	WHERE taikhoan = @taikhoan
END
GO
/****** Object:  StoredProcedure [dbo].[XoaCTPM]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaCTPM](@maphieu varchar(10),@masach varchar(10))
AS
BEGIN
	DELETE dbo.PHIEUMUONTRA WHERE MAPHIEU=@maphieu
	
END
GO
/****** Object:  StoredProcedure [dbo].[XOAPMT]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XOAPMT]
(
@maphieu NCHAR(10)

) AS BEGIN
	DELETE FROM CTPHIEUMUONTRA
	 WHERE MAPHIEU=@maphieu
	 DELETE FROM PHIEUMUONTRA WHERE MAPHIEU=@maphieu

   END
GO
/****** Object:  StoredProcedure [dbo].[XOATAIKHOAN]    Script Date: 5/20/2019 9:46:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XOATAIKHOAN](
@taikhoan NCHAR(10)
)
AS
BEGIN
	DELETE Login WHERE taikhoan = @taikhoan
END
GO
USE [master]
GO
ALTER DATABASE [QLTV] SET  READ_WRITE 
GO
