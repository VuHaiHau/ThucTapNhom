USE [master]
GO
/****** Object:  Database [QlNhanSu]    Script Date: 5/20/2019 11:34:25 PM ******/
CREATE DATABASE [QlNhanSu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QlNhanSu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QlNhanSu.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QlNhanSu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QlNhanSu_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QlNhanSu] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QlNhanSu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QlNhanSu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QlNhanSu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QlNhanSu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QlNhanSu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QlNhanSu] SET ARITHABORT OFF 
GO
ALTER DATABASE [QlNhanSu] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QlNhanSu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QlNhanSu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QlNhanSu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QlNhanSu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QlNhanSu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QlNhanSu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QlNhanSu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QlNhanSu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QlNhanSu] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QlNhanSu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QlNhanSu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QlNhanSu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QlNhanSu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QlNhanSu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QlNhanSu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QlNhanSu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QlNhanSu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QlNhanSu] SET  MULTI_USER 
GO
ALTER DATABASE [QlNhanSu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QlNhanSu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QlNhanSu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QlNhanSu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QlNhanSu] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QlNhanSu]
GO
/****** Object:  Table [dbo].[BaoHiem]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BaoHiem](
	[MaNhanVien] [varchar](5) NOT NULL,
	[LoaiBaoHiem] [nvarchar](50) NULL,
	[SoThe] [varchar](20) NULL,
	[NgayCap] [date] NULL,
	[NgayHetHan] [date] NULL,
	[NoiCap] [nvarchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChamCong]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChamCong](
	[MaNhanVien] [varchar](5) NOT NULL,
	[Ngay] [date] NOT NULL,
	[TinhTrang] [nvarchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [varchar](5) NOT NULL,
	[TenCv] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ctChucVu]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ctChucVu](
	[MaNhanVien] [varchar](5) NULL,
	[MaCV] [varchar](5) NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
	[LyDo] [nvarchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HopDong]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HopDong](
	[MaHD] [varchar](5) NOT NULL,
	[NgayVaoLam] [date] NOT NULL,
	[HeSoLuong] [int] NOT NULL,
	[MaCV] [varchar](5) NOT NULL,
	[MaPB] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Luong]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Luong](
	[HeSoLuong] [int] NOT NULL,
	[LuongCB] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HeSoLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](5) NOT NULL,
	[MaPB] [varchar](5) NOT NULL,
	[MaHD] [varchar](5) NOT NULL,
	[HeSoLuong] [int] NOT NULL,
	[TenNV] [nvarchar](100) NOT NULL,
	[GioiTinh] [nvarchar](5) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[SoCM] [varchar](20) NOT NULL,
	[DienThoai] [varchar](20) NOT NULL,
	[TrinhDoHV] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
	[Email] [varchar](20) NULL,
	[Hinh] [nvarchar](100) NOT NULL,
	[TTHonNhan] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPB] [varchar](5) NOT NULL,
	[TenPB] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhuCap]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhuCap](
	[MaNhanVien] [varchar](5) NOT NULL,
	[LoaiPC] [nvarchar](50) NULL,
	[Tien] [int] NULL,
	[TuNgay] [date] NULL,
	[DenNgay] [date] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[MaNhanVien] [varchar](5) NOT NULL,
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[TenQuyenHan] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThuongPhat]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThuongPhat](
	[MaNhanVien] [varchar](5) NOT NULL,
	[Loai] [nvarchar](50) NULL,
	[Tien] [int] NULL,
	[LyDo] [nvarchar](max) NULL,
	[Ngay] [date] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[BaoHiem]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[ChamCong]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[ctChucVu]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[ctChucVu]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD FOREIGN KEY([HeSoLuong])
REFERENCES [dbo].[Luong] ([HeSoLuong])
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([HeSoLuong])
REFERENCES [dbo].[Luong] ([HeSoLuong])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HopDong] ([MaHD])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[PhuCap]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[Taikhoan]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[ThuongPhat]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
/****** Object:  StoredProcedure [dbo].[CapNhatChucVu]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[CapNhatChucVu]
@macv varchar(5),
@tencv nvarchar(50)
as
	if(exists(select MaCV from ChucVu where MaCV = @macv))
	begin
		update ChucVu set MaCV = @macv, TenCV = @tencv where MaCV = @macv
	end

----------------------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[CapNhatLuong]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[CapNhatLuong]
@hesoluong int,
@luongcb int
as
	Update Luong set LuongCB = @luongcb where HeSoLuong = @hesoluong

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[CapNhatMaCvTrongHopDong]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[CapNhatMaCvTrongHopDong]
@mahd varchar(5),
@macv varchar(5)
as
	update HopDong set MaCV = @macv where MaHD = @mahd
GO
/****** Object:  StoredProcedure [dbo].[CapNhatNgayVaoLam]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[CapNhatNgayVaoLam]
@ngay date,
@manv varchar(5)
as
	update HopDong set NgayVaoLam = @ngay from NhanVien inner join HopDong on NhanVien.MaHD = HopDong.MaHD where MaNhanVien = @manv
------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------Bảng Hợp Đồng-----------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[CapNhatPhongBan]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create Proc [dbo].[CapNhatPhongBan]
@maphong varchar(5),
@tenphong nvarchar(20)
as
	update PhongBan set MaPB = @maphong, TenPB = @tenphong
	where MaPB = @maphong

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[DangNhap]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[DangNhap]
@taikhoan nvarchar(50),
@matkhau nvarchar(50)
as
if(exists(select TenDangNhap from TaiKhoan where TenDangNhap = @taikhoan and MatKhau = @matkhau))
begin
	select err = 0
end
else
	select err = 1
-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[DemSoNgayLam]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create proc [dbo].[DemSoNgayLam]
@manv varchar(5),
@ngaydau date,
@ngaycuoi date
as
	select MaNhanVien, COUNT(Ngay)as NgayLam from ChamCong 
	where MaNhanVien = @manv and (Ngay >= @ngaydau and Ngay <= @ngaycuoi) and TinhTrang = N'Đi Làm'
	Group By MaNhanVien

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[DemSoNgaynghiCoPhep]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[DemSoNgaynghiCoPhep]
@manv varchar(5),
@ngaydau date,
@ngaycuoi date
as
	select MaNhanVien, COUNT(Ngay)as NgayLam from ChamCong 
	where MaNhanVien = @manv and (Ngay >= @ngaydau and Ngay <= @ngaycuoi) and TinhTrang = N'Nghỉ Có Phép'
	Group By MaNhanVien

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[DemSoNgayNghiKhongPhep]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[DemSoNgayNghiKhongPhep]
@manv varchar(5),
@ngaydau date,
@ngaycuoi date
as
	select MaNhanVien, COUNT(Ngay)as NgayLam from ChamCong 
	where MaNhanVien = @manv and (Ngay >= @ngaydau and Ngay <= @ngaycuoi) and TinhTrang = N'Nghỉ Không Phép'
	Group By MaNhanVien

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[DoiMatKhau]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[DoiMatKhau]
@manv varchar(5),
@taikhoan nvarchar(50),
@matkhaumoi nvarchar(50)
as
	update TaiKhoan set MaNhanVien = @manv, TenDangNhap = @taikhoan, MatKhau = @matkhaumoi
	where TenDangNhap = @taikhoan

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[HienPhongBan]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[HienPhongBan]
@maphong varchar(5)
as
	if(@maphong = '0')
	begin
		select PhongBan.MaPB, TenPB, count(NhanVien.MaPB) as SoNV
		from PhongBan left join NhanVien on PhongBan.MaPB = NhanVien.MaPB
		GROUP BY PhongBan.MaPB, TenPB
	end
	else
	begin
		select PhongBan.MaPB, TenPB, count(NhanVien.MaPB) as SoNV
		from PhongBan left join NhanVien on PhongBan.MaPB = NhanVien.MaPB
		where PhongBan.MaPB = @maphong
		GROUP BY PhongBan.MaPB, TenPB
	end	

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[LayBaoHiem]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[LayBaoHiem]
@ma varchar(5),
@loaibh nvarchar(50)
as
	if(@ma = '0')
	begin
		select NhanVien.MaNhanVien, TenNV, LoaiBaoHiem, NgayHetHan
		from NhanVien left join BaoHiem on NhanVien.MaNhanVien = BaoHiem.MaNhanVien
	end
	else
	begin
		select NhanVien.MaNhanVien, TenNV, LoaiBaoHiem, SoThe, NgayCap, NgayHetHan, NoiCap
		from NhanVien left join BaoHiem on NhanVien.MaNhanVien = BaoHiem.MaNhanVien
		where NhanVien.MaNhanVien = @ma and LoaiBaoHiem = @loaibh
	end
---------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[LayChamCong]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[LayChamCong]
@ma varchar(5),
@ngay date
as
if(@ma = '0')
begin
	select ChamCong.MaNhanVien, NhanVien.TenNV, TinhTrang 
	from ChamCong inner join NhanVien on ChamCong.MaNhanVien = NhanVien.MaNhanVien
	where Ngay = @ngay
end
else
begin
	select ngay from ChamCong where Ngay = @ngay
end

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[LayChucVu]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[LayChucVu]
@ma varchar(5)
as
	if(@ma = '0')
	begin
		select MaCV, TenCv from ChucVu
	end
	else
	begin
		select MaCV, TenCv from ChucVu where MaCV = @ma
	end

----------------------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[LayChucVuTuMaNV]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[LayChucVuTuMaNV](
@manv varchar(5))
as 
	select TenCV from (NhanVien inner join HopDong on NhanVien.MaHD = HopDong.MaHD) inner join ChucVu on HopDong.MaCV = ChucVu.MaCV
	where MaNhanVien = @manv

----------------------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[LayctChucVu]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[LayctChucVu]
@manv varchar(5)
as
	if(@manv = '0')
	begin
		select MaNhanVien, ' ' as TenNV,  ' ' as TenCv, NgayBatDau, NgayKetThuc, LyDo from ctChucVu
	end
	else
	begin
		select MaNhanVien, ' ' as TenNV,  ' ' as TenCv, NgayBatDau, NgayKetThuc, LyDo from ctChucVu where MaNhanVien = @manv
	end

------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------Bảo Hiểm-----------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[LayLuongCB]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[LayLuongCB]
@hesoluong int
as
	select LuongCB From Luong where HeSoLuong = @hesoluong


------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------Bảng Chức Vụ-----------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[LayLuongCBTuHSL]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[LayLuongCBTuHSL]
@hsl int
as
	select LuongCB from Luong where HeSoLuong = @hsl

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[layMaCVTuTenCV]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[layMaCVTuTenCV]
@tencv nvarchar(100)
as
	if(exists(select TenCV from ChucVu where TenCV = @tencv))
	begin
		select MaCV from ChucVu where TenCV = @tencv
	end
	else
		select err = 1

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[layMaHopDong]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[layMaHopDong]
@mahd varchar(5)
as
if(@mahd = '0')
begin
	select MaHD from HopDong
end
else 
begin
	select MaHD from HopDong where MaHD = @mahd
end

------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[layMaHopDongTuMaNV]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[layMaHopDongTuMaNV](
@manv  varchar(5))
as
	select MaHD from NhanVien where MaNhanVien = @manv
-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[LayMaNV]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------Bảng Nhân Viên-----------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------

Create Proc [dbo].[LayMaNV]
@tendangnhap nvarchar(50)
as
if(@tendangnhap = '0')
begin
	select MaNhanVien from NhanVien
end
else 
begin
	select MaNhanVien from Taikhoan where TenDangNhap = @tendangnhap
end
-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[layMaNVTuTenNV]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[layMaNVTuTenNV]
@tennv nvarchar(50)
as
	select MaNhanVien from NhanVien where TenNV = @tennv
-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[layMaPBTuTenPB]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------Bảng Phòng Ban-----------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------

Create Proc [dbo].[layMaPBTuTenPB]
@tenpb nvarchar(100)
as
	if(exists(select TenPB from PhongBan where TenPB = @tenpb))
	begin
		select MaPB from PhongBan where TenPB = @tenpb
	end
	else
		select err = 1

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[LayNgayVaoLam]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[LayNgayVaoLam]
@manv varchar(5)
as
	select NgayVaoLam from NhanVien inner join HopDong on NhanVien.MaHD = HopDong.MaHD where MaNhanVien = @manv

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[LayNhanVienTuMaPB]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[LayNhanVienTuMaPB]--'0','12-1-2016', '12-30-2016'
@mapb varchar(5),
@ngaydau date,
@ngaycuoi date
as
	if(@mapb = '0')
	begin
		select TenNV, Loai, Tien, LyDo
		from NhanVien left join ThuongPhat on NhanVien.MaNhanVien = ThuongPhat.MaNhanVien
		where (Ngay >= @ngaydau and Ngay <= @ngaycuoi) or Ngay is null
	end
	else
	begin
		select TenNV, Loai, Tien, LyDo
		from NhanVien left join ThuongPhat on NhanVien.MaNhanVien = ThuongPhat.MaNhanVien
		where (@mapb = MaPB and (Ngay >= @ngaydau and Ngay <= @ngaycuoi)) or Ngay is null
	end

------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[LayPhuCap]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[LayPhuCap]
@ma varchar(5)
as
	if(@ma = '0')
	begin
		select PhuCap.MaNhanVien, TenNV, LoaiPC, Tien, TuNgay, DenNgay from PhuCap left join NhanVien on PhuCap.MaNhanVien = NhanVien.MaNhanVien
		order by TuNgay Desc
	end
	else
	begin
		select PhuCap.MaNhanVien, TenNV, LoaiPC, Tien, TuNgay, DenNgay from PhuCap left join NhanVien on PhuCap.MaNhanVien = NhanVien.MaNhanVien
		where PhuCap.MaNhanVien = @ma
		order by TuNgay Desc
	end

---------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[LayQuyenHanNV]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[LayQuyenHanNV]
@taikhoan nvarchar(50),
@matkhau nvarchar(50)
as
	select TenQuyenHan from Taikhoan where TenDangNhap = @taikhoan and MatKhau = @matkhau


GO
/****** Object:  StoredProcedure [dbo].[layTenNhanVien]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[layTenNhanVien]
@manhanvien varchar(5)
as
if(@manhanvien = '0')
begin
	Select MaNhanVien, TenNV from NhanVien
end
else
begin
	select TenNV from NhanVien where MaNhanVien = @manhanvien
end

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[layTenPBTuMaNV]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[layTenPBTuMaNV]
@manv varchar(5)
as
	select TenPB  from NhanVien inner join PhongBan on NhanVien.MaPB = PhongBan.MaPB where MaNhanVien = @manv
-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[LayThongTinNV]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create Proc [dbo].[LayThongTinNV]
@manhanvien varchar(5)
as
if(@manhanvien = 'NV')
begin
	select MaNhanVien, TenNV, GioiTinh, ChucVu.TenCV 
	from (NhanVien inner join HopDong on NhanVien.MaHD = HopDong.MaHD) inner join ChucVu on HopDong.MaCV = ChucVu.maCV
end
else
	select MaNhanVien, NhanVien.MaPB, MaCV, NhanVien.HeSoLuong, NhanVien.MaHD, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh
	from NhanVien inner join HopDong on NhanVien.MaHD = HopDong.MaHD where MaNhanVien = @manhanvien

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[LayTienPhuCap]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[LayTienPhuCap]
@manv varchar(5),
@ngay date
as
	select MaNhanVien, Sum(Tien) as Tien From PhuCap 
	where MaNhanVien = @manv and (TuNgay <= @ngay and DenNgay >= @ngay)
	group by MaNhanVien

------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------Bảng Lương-----------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[Ma]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[Ma]
@manv nvarchar(50)
as
	select NhanVien.MaPB, MaCV, NhanVien.HeSoLuong, NhanVien.MaHD from NhanVien inner join HopDong on NhanVien.MaHD = HopDong.MaHD where MaNhanVien = @manv

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[NvCoTK]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[NvCoTK]
@ma varchar(5)
as
if(@ma = '0')
begin
	select NhanVien.MaNhanVien, TenNV, TenDangNhap, MatKhau, TenQuyenHan
	from NhanVien right join Taikhoan on NhanVien.MaNhanVien = Taikhoan.MaNhanVien
end
else
begin
	select MaNhanVien, TenDangNhap, MatKhau, TenQuyenHan
	from TaiKhoan
	where MaNhanVien = @ma
end
-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[NvCTaiKhoan]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------Bảng Tài Khoản-----------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------
Create Proc [dbo].[NvCTaiKhoan]
@ma varchar(5)
as
if(@ma = '0')
begin
	select NhanVien.MaNhanVien, TenNV, ChucVu.TenCv 
	from ((NhanVien inner join HopDong on NhanVien.MaHD = HopDong.MaHD) inner join ChucVu on HopDong.MaCV = ChucVu.MaCV) 
		left join Taikhoan on NhanVien.MaNhanVien = Taikhoan.MaNhanVien
	where TenDangNhap is null
end

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[pcLayNhanVien]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[pcLayNhanVien]
@ma varchar(5)
as
	if(@ma = '0')
	begin
		select MaNhanVien, TenNV from NhanVien
	end

-----------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[SuaBaoHiem]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[SuaBaoHiem]
@manv varchar(5),
@loaibhcu nvarchar(50),
@loaibhmoi nvarchar(50),
@sothe varchar(20),
@ngaycap date,
@ngayhethan date,
@noicap nvarchar(100)
as
	update BaoHiem set MaNhanVien = @manv, LoaiBaoHiem = @loaibhmoi, SoThe = @sothe, NgayCap = @ngaycap, NgayHetHan = @ngayhethan, NoiCap = @noicap
	where MaNhanVien = @manv and LoaiBaohiem = @loaibhcu

---------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[SuactChucVu]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[SuactChucVu]
@manv varchar(5),
@macv varchar(5),
@ngaykt date
as
	update ctChucVu set NgayKetThuc = @ngaykt where MaCV = @macv and MaNhanVien = @manv

-------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[SuaNhanVien]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create Proc [dbo].[SuaNhanVien]
@manv varchar(5),
@mapb varchar(5),
@hesoluong int,
@mahd varchar(5),
@tennv Nvarchar(50),
@gioitinh nvarchar(5),
@ngaysinh date,
@socm varchar(20),
@sodt varchar(20),
@trinhdo nvarchar(50),
@diachi nvarchar(100),
@email nvarchar(50),
@honnhan nvarchar(10),
@hinh nvarchar(50)
as
	update NhanVien
	set MaNhanVien = @manv, MaPB = @mapb, HeSoLuong = @hesoluong, MaHD = @mahd, TenNV = @tennv, GioiTinh = @gioitinh, 
		NgaySinh = @ngaysinh, SoCM = @socm, DienThoai = @sodt, TrinhDoHV = @trinhdo, DiaChi = @diachi, Email = @email, 
		TTHonNhan = @honnhan, Hinh = @hinh
	where MaNhanVien = @manv

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[SuaPhuCap]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[SuaPhuCap]
@manv varchar(5),
@loaipcc nvarchar(50),
@loaipcm nvarchar(50),
@tien int,
@tungay date,
@denngay date
as
	update PhuCap set LoaiPC = @loaipcm, Tien = @tien, TuNgay = @tungay, DenNgay = @denngay
	where MaNhanVien = @manv and LoaiPC = @loaipcc

---------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[SuaThongTinNhanVien]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[SuaThongTinNhanVien]
@manv varchar(5),
@tennv nvarchar(50),
@mapb varchar(5),
@hesoluong int,
@gioitinh nvarchar(5),
@ngaysinh date,
@socm varchar(20),
@sodt varchar(20),
@trinhdo nvarchar(50),
@diachi nvarchar(100),
@email nvarchar(50),
@honnhan nvarchar(10),
@hinh nvarchar(50)
as
	update NhanVien
	set MaNhanVien = @manv, TenNV = @tennv, MaPB = @mapb, HeSoLuong = @hesoluong, GioiTinh = @gioitinh, 
		NgaySinh = @ngaysinh, SoCM = @socm, DienThoai = @sodt, TrinhDoHV = @trinhdo, DiaChi = @diachi, Email = @email, 
		TTHonNhan = @honnhan, Hinh = @hinh
	where MaNhanVien = @manv

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[SuaTK]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[SuaTK]
@manv varchar(5),
@maqh varchar(5),
@taikhoan nvarchar(50),
@matkhau nvarchar(50)
as
	update Taikhoan set MaNhanVien = @manv, TenQuyenHan = @maqh, TenDangNhap = @taikhoan, MatKhau = @matkhau
	where MaNhanVien = @manv

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[ThemBaoHiem]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[ThemBaoHiem]
@manv varchar(5),
@loaibh nvarchar(50),
@sothe varchar(20),
@ngaycap date,
@ngayhethan date,
@noicap nvarchar(100)
as
	insert into BaoHiem(MaNhanVien, LoaiBaoHiem, SoThe, NgayCap, NgayHetHan, NoiCap) values(@manv, @loaibh, @sothe, @ngaycap, @ngayhethan, @noicap)

---------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[ThemChamCong]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[ThemChamCong]
@manv varchar(5),
@ngay date,
@tinhtrang Nvarchar(20)
as
	insert into ChamCong(MaNhanVien, Ngay, TinhTrang) values (@manv, @ngay, @tinhtrang)
	
-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[ThemChucVu]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[ThemChucVu]
@macv varchar(5),
@tencv nvarchar(50)
as
	insert into ChucVu(MaCV, TenCv) values(@macv, @tencv)

----------------------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[ThemctChucVu]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[ThemctChucVu]
@manv varchar(5),
@macv varchar(5),
@ngaybd date,
@lydo nvarchar(100)
as
	insert into ctChucVU(MaNhanVien, MaCV, NgayBatDau, LyDo) values(@manv, @macv, @ngaybd, @lydo)

-------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[ThemHopDong]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[ThemHopDong]
@mahd varchar(5),
@ngayvaolam date,
@hesoluong int,
@macv varchar(5),
@mapb varchar(5)
as
	insert into HopDong(MaHD, NgayVaoLam, HeSoLuong, MaCV, MaPB) 
	values(@mahd, @ngayvaolam,  @hesoluong, @macv, @mapb)

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[ThemNhanVien]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[ThemNhanVien]
@manv varchar(5),
@tennv nvarchar(50),
@mapb varchar(5),
@hesoluong int,
@mahd varchar(5),
@gioitinh nvarchar(5),
@ngaysinh date,
@socm varchar(20),
@sodt varchar(20),
@trinhdo nvarchar(50),
@diachi nvarchar(100),
@email nvarchar(50),
@honnhan nvarchar(10),
@hinh  nvarchar(50)
as
	insert into NhanVien(MaNhanVien, TenNV, MaPB, HeSoLuong, MaHD, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh )
	values (@manv, @tennv, @mapb, @hesoluong, @mahd, @gioitinh, @ngaysinh, @socm, @sodt, @trinhdo, @diachi, @email, @honnhan, @hinh)
-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[ThemPhongBan]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create Proc [dbo].[ThemPhongBan]
@maphong varchar(5),
@tenphong nvarchar(20)
as
	if(not exists(select MaPB from PhongBan where MaPB = @maphong))
	begin
		insert into PhongBan(MaPB, TenPB) values(@maphong, @tenphong)
	end
	else
		select err = 1


-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[ThemPhuCap]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[ThemPhuCap]
@manv varchar(5),
@loaipc nvarchar(50),
@tien int,
@tungay date,
@denngay date
as
	insert into PhuCap(MaNhanVien, LoaiPC, Tien, TuNgay, DenNgay) values(@manv, @loaipc, @tien, @tungay, @denngay)

---------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[ThemTaiKhoan]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[ThemTaiKhoan]
@manv varchar(5),
@taikhoan nvarchar(50),
@matkhau nvarchar(50),
@tenquyenhan nvarchar(20)
as
if(not exists(select TenDangNhap from Taikhoan where TenDangNhap = @taikhoan))
begin
	insert into Taikhoan(MaNhanVien, TenDangNhap, MatKhau, TenQuyenHan)
			values(@manv, @taikhoan,@matkhau, @tenquyenhan)
	select err = '0'
end
else select err = '1'

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[ThemThuongPhat]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[ThemThuongPhat]
@manv varchar(5),
@loai nvarchar(100),
@tien int,
@lydo nvarchar(100),
@ngay date
as
	insert into ThuongPhat(MaNhanVien, Loai, Tien, LyDo, Ngay) values(@manv, @loai, @tien, @lydo, @ngay)

------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------ctChucVu-----------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[ThongTinNhanVien]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create Proc [dbo].[ThongTinNhanVien]
@manhanvien varchar(5)
as
	select MaNhanVien, TenNV, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, TTHonNhan, Hinh, ChucVu.TenCV, PhongBan.TenPB, 
			NhanVien.HeSoLuong
	from ((NhanVien inner join PhongBan on NhanVien.MaPB = PhongBan.MaPB) inner join HopDong on NhanVien.MaHD = HopDong.MaHD)
	inner join ChucVu on HopDong.MaCV = ChucVu.MaCV
	where MaNhanVien = @manhanvien

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[tkccXemTheoTenVaPhongBan]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[tkccXemTheoTenVaPhongBan]
@tennv nvarchar(50),
@tenpb nvarchar(20),
@ngaydau date,
@ngaycuoi date,
@khoa int
as
	if(@khoa = 1)
	begin
		select NhanVien.MaNhanVien, TenNV, TinhTrang, Ngay
		from NhanVien inner join ChamCong on NhanVien.MaNhanVien = ChamCong.MaNhanVien
		where TenNV like @tennv and Ngay >= @ngaydau and Ngay <= @ngaycuoi
		order by NhanVien.MaNhanVien
	end
	else
	begin
		select NhanVien.MaNhanVien, TenNV, TinhTrang, Ngay
		from (NhanVien inner join ChamCong on NhanVien.MaNhanVien = ChamCong.MaNhanVien) inner join PhongBan
				on NhanVien.MaPB = PhongBan.MaPB
		where TenPB = @tenPB and Ngay >= @ngaydau and Ngay <= @ngaycuoi
		order by NhanVien.MaNhanVien
	end

-----------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[tkNhanVien]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[tkNhanVien]
@tukhoa nvarchar(100),
@gt int
as
if(@gt = 1)
begin 
	select MaNhanVien, TenNV, GioiTinh, ChucVu.TenCV 
	from ((NhanVien inner join HopDong on NhanVien.MaHD = HopDong.MaHD) inner join PhongBan on NhanVien.MaPB = PhongBan.MaPB) inner join ChucVu on HopDong.MaCV = ChucVu.MaCV
	where (TenNV like '%'+@tukhoa+'%' or SoCM like '%'+@tukhoa+'%' or DienThoai like '%'+@tukhoa+'%' or TrinhDoHV like '%'+@tukhoa+'%' or DiaChi like '%'+@tukhoa+'%' 
		or Email like '%'+@tukhoa+'%' or TTHonNhan like '%'+@tukhoa+'%' or TenCv like '%'+@tukhoa+'%' or TenPB like '%'+@tukhoa+'%') and GioiTinh = N'Nam'
end
else if(@gt = 2)
begin 
	select MaNhanVien, TenNV, GioiTinh, ChucVu.TenCV 
	from ((NhanVien inner join HopDong on NhanVien.MaHD = HopDong.MaHD) inner join PhongBan on NhanVien.MaPB = PhongBan.MaPB) inner join ChucVu on HopDong.MaCV = ChucVu.MaCV
	where (TenNV like '%'+@tukhoa+'%' or SoCM like '%'+@tukhoa+'%' or DienThoai like '%'+@tukhoa+'%' or TrinhDoHV like '%'+@tukhoa+'%' or DiaChi like '%'+@tukhoa+'%' 
		or Email like '%'+@tukhoa+'%' or TTHonNhan like '%'+@tukhoa+'%' or TenCv like '%'+@tukhoa+'%' or TenPB like '%'+@tukhoa+'%') and GioiTinh = N'Nữ'
end
else
begin
	select MaNhanVien, TenNV, GioiTinh, ChucVu.TenCV 
	from ((NhanVien inner join HopDong on NhanVien.MaHD = HopDong.MaHD) inner join PhongBan on NhanVien.MaPB = PhongBan.MaPB) inner join ChucVu on HopDong.MaCV = ChucVu.MaCV
	where (TenNV like '%'+@tukhoa+'%' or SoCM like '%'+@tukhoa+'%' or DienThoai like '%'+@tukhoa+'%' or TrinhDoHV like '%'+@tukhoa+'%' or DiaChi like '%'+@tukhoa+'%' 
		or Email like '%'+@tukhoa+'%' or TTHonNhan like '%'+@tukhoa+'%' or TenCv like '%'+@tukhoa+'%' or TenPB like '%'+@tukhoa+'%')
end
GO
/****** Object:  StoredProcedure [dbo].[tkNhanVienNghi]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create proc [dbo].[tkNhanVienNghi]
@ngaydau date,
@ngaycuoi date,
@khoa int
as
	if(@khoa = 1)
	begin
		select NhanVien.MaNhanVien, TenNV, Ngay
		from NhanVien inner join ChamCong on NhanVien.MaNhanVien = ChamCong.MaNhanVien
		where Ngay = @ngaydau and TinhTrang = N'Nghỉ Không Phép'
	end
	else
	begin
		select NhanVien.MaNhanVien, TenNV, Ngay
		from NhanVien inner join ChamCong on NhanVien.MaNhanVien = ChamCong.MaNhanVien
		where Ngay >= @ngaydau and Ngay <= @ngaycuoi and TinhTrang = N'Nghỉ Không Phép'
	end

-----------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[tkNhanVienNghiCoPhep]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[tkNhanVienNghiCoPhep]
@ngaydau date,
@ngaycuoi date,
@khoa int
as
	if(@khoa = 1)
	begin
		select NhanVien.MaNhanVien, TenNV, Ngay
		from NhanVien inner join ChamCong on NhanVien.MaNhanVien = ChamCong.MaNhanVien
		where Ngay = @ngaydau and TinhTrang = N'Nghỉ Có Phép'
	end
	else
	begin
		select NhanVien.MaNhanVien, TenNV, Ngay
		from NhanVien inner join ChamCong on NhanVien.MaNhanVien = ChamCong.MaNhanVien
		where Ngay >= @ngaydau and Ngay <= @ngaycuoi and TinhTrang = N'Nghỉ Có Phép'
	end
-----------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[tkSoNgayDiLamCuaNhanVien]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[tkSoNgayDiLamCuaNhanVien]
@ngaydau date,
@ngaycuoi date,
@khoa int
as
	if(@khoa = 1)
	begin
		select distinct NhanVien.MaNhanVien, TenNV, count(TinhTrang) as SoNN
		from NhanVien inner join ChamCong on NhanVien.MaNhanVien = ChamCong.MaNhanVien
		where Ngay >= @ngaydau and Ngay <= @ngaycuoi and TinhTrang = N'Đi Làm'
		group by NhanVien.MaNhanVien, TenNV
	end
	else if(@khoa = 2)
	begin
		select distinct NhanVien.MaNhanVien, TenNV, count(TinhTrang) as SoNN
		from NhanVien inner join ChamCong on NhanVien.MaNhanVien = ChamCong.MaNhanVien
		where Ngay >= @ngaydau and Ngay <= @ngaycuoi and TinhTrang = N'Nghỉ Có Phép'
		group by NhanVien.MaNhanVien, TenNV
	end
	else
	begin
		select distinct NhanVien.MaNhanVien, TenNV, count(TinhTrang) as SoNN
		from NhanVien inner join ChamCong on NhanVien.MaNhanVien = ChamCong.MaNhanVien
		where Ngay >= @ngaydau and Ngay <= @ngaycuoi and TinhTrang = N'Nghỉ Không Phép'
		group by NhanVien.MaNhanVien, TenNV
	end
-----------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[TongLuongNV]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create proc [dbo].[TongLuongNV]
@ma varchar(5)
as
if(@ma = '0')
begin
	select MaNhanVien, TenNV, NhanVien.HeSoLuong, '0' as NL, '0' as T, '0' as P, '0' as Tien, '0' as TL
	From NhanVien inner join Luong on NhanVien.HeSoLuong = Luong.HeSoLuong
end
else 
begin
	select LuongCB from NhanVien inner join Luong on NhanVien.HeSoLuong = Luong.HeSoLuong
	where MaNhanVien = @ma
end

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[XoaBaoHiem]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[XoaBaoHiem]
@manv varchar(5),
@loaibh nvarchar(50)
as
	delete BaoHiem where MaNhanVien = @manv and LoaiBaohiem = @loaibh

---------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[XoaBaoHiemTheoNV]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[XoaBaoHiemTheoNV]
@manv varchar(5)
as
	delete BaoHiem where MaNhanVien = @manv
------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------PhuCap-----------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[XoaCapNhat]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[XoaCapNhat]
@macv varchar(5)
as
	delete ChucVu where MaCV = @macv
------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------Bảng Thưởng Phạt-----------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[XoaChamCong]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[XoaChamCong]
@manv varchar(5)
as
	delete ChamCong where MaNhanVien = @manv

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[XoaChamCongTheoNgay]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[XoaChamCongTheoNgay]
@ngay date
as
	delete ChamCong where Ngay = @ngay


-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[XoactChucVu]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[XoactChucVu]
@manv varchar(5)
as
	delete ctChucVu where MaNhanVien = @manv

-------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[XoaHopDong]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[XoaHopDong]
@mahd varchar(5)
as
delete HopDong where MaHD = @mahd
-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[XoaNhanVien]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[XoaNhanVien]
@manv varchar(5)
as
	if(exists(select MaNhanVien from NhanVien where MaNhanVien = @manv))
	begin
		delete NhanVien where MaNhanVien = @manv
	end
	else 
		select err = 1
-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[XoaPhongBan]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create Proc [dbo].[XoaPhongBan]
@maphong varchar(5)
as
	if((not exists(select MaPB from NhanVien where MaPB = @maphong)) and (not exists (Select MaPB from HopDong where MaPB = @maphong)))
	begin
		delete PhongBan where MaPB = @maphong
	end
	else
		select err = 1

-------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[XoaPhuCap]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[XoaPhuCap]
@manv varchar(5),
@loaipc nvarchar(50)
as
	delete PhuCap where MaNhanVien = @manv and LoaiPC = @loaipc

---------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[XoaPhuCapTheoNV]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[XoaPhuCapTheoNV]
@manv varchar(5)
as
	delete PhuCap where MaNhanVien = @manv
------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------Thống Kê-----------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[XoaThuongPhat]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[XoaThuongPhat]
@manv varchar(5),
@loai nvarchar(100),
@tien int,
@lydo nvarchar(100)
as
	delete ThuongPhat where (MaNhanVien = @manv and Loai = @loai and Tien = @tien and LyDo = @lydo)

------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[XoaThuongPhatTheoNV]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[XoaThuongPhatTheoNV]
@manv varchar(5)
as
	delete ThuongPhat where MaNhanVien = @manv
------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[XoaTK]    Script Date: 5/20/2019 11:34:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [dbo].[XoaTK]
@ma varchar(5)
as
	delete Taikhoan where MaNhanVien = @ma

-------------------------------------------------------------------------------------------------

GO
USE [master]
GO
ALTER DATABASE [QlNhanSu] SET  READ_WRITE 
GO
