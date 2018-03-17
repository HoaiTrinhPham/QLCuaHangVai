USE [master]
GO
/****** Object:  Database [QLCuaHangVai]    Script Date: 14/03/2018 3:37:59 PM ******/
CREATE DATABASE [QLCuaHangVai] ON  PRIMARY 
( NAME = N'QLCuaHangVai', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.HH\MSSQL\DATA\QLCuaHangVai.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLCuaHangVai_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.HH\MSSQL\DATA\QLCuaHangVai_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLCuaHangVai] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLCuaHangVai].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLCuaHangVai] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLCuaHangVai] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLCuaHangVai] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLCuaHangVai] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLCuaHangVai] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLCuaHangVai] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLCuaHangVai] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLCuaHangVai] SET  MULTI_USER 
GO
ALTER DATABASE [QLCuaHangVai] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLCuaHangVai] SET DB_CHAINING OFF 
GO
USE [QLCuaHangVai]
GO
/****** Object:  StoredProcedure [dbo].[LoginNhanVien]    Script Date: 14/03/2018 3:37:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoginNhanVien] 
	@ID nchar(20)
as
	select Pass from NhanVien where ID = @ID

GO
/****** Object:  StoredProcedure [dbo].[LoginQuanLy]    Script Date: 14/03/2018 3:37:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoginQuanLy] 
	@ID nchar(20)
as
	select Pass from QuanLy where ID = @ID

GO
/****** Object:  StoredProcedure [dbo].[P_LAYDOANHTHUTHEONAM]    Script Date: 14/03/2018 3:37:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[P_LAYDOANHTHUTHEONAM](
	@nam int
)
AS
BEGIN
	SELECT 
		(SELECT DonGiaBan FROM HangHoa WHERE Id = CTHD.IdHangHoa) * CTHD.SoLuong 
	FROM ChiTietHoaDon CTHD WHERE CTHD.IdHoaDon IN
												(SELECT ID 
												FROM HoaDon 
												WHERE DATEPART(YEAR,ThoiGian) = @nam)
END 
GO
/****** Object:  StoredProcedure [dbo].[P_LAYDOANHTHUTHEOTHANG]    Script Date: 14/03/2018 3:37:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[P_LAYDOANHTHUTHEOTHANG](
	@thang int,
	@nam int
)
AS
BEGIN
	SELECT 
		(SELECT DonGiaBan FROM HangHoa WHERE Id = CTHD.IdHangHoa) * CTHD.SoLuong 
	FROM ChiTietHoaDon CTHD WHERE CTHD.IdHoaDon IN
												(SELECT ID 
												FROM HoaDon 
												WHERE DATEPART( MONTH,ThoiGian) = @thang AND DATEPART(YEAR,ThoiGian) = @nam)
END 
GO
/****** Object:  StoredProcedure [dbo].[P_LAYNHUNGNAMDACOHOADON]    Script Date: 14/03/2018 3:37:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[P_LAYNHUNGNAMDACOHOADON]
AS
BEGIN
	SELECT DISTINCT CAST(DATEADD(YEAR, DATEDIFF(YEAR, 0, ThoiGian), 0) as DATE) FROM HoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[P_LAYNHUNGTHANGDACOHOADON]    Script Date: 14/03/2018 3:37:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[P_LAYNHUNGTHANGDACOHOADON]
AS
BEGIN
	SELECT DISTINCT CAST(DATEADD(month, DATEDIFF(month, 0, ThoiGian), 0) as DATE) FROM HoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[P_LAYVONTHUCCHITHEONAM]    Script Date: 14/03/2018 3:37:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[P_LAYVONTHUCCHITHEONAM](
	@nam int
)
AS
BEGIN
	SELECT (SELECT DonGiaNhap FROM HangHoa WHERE Id = CTHD.IdHangHoa) * CTHD.SoLuong FROM ChiTietHoaDon CTHD WHERE CTHD.IdHoaDon IN
	(SELECT ID FROM HoaDon WHERE DATEPART(YEAR,ThoiGian) = @nam)
END 
GO
/****** Object:  StoredProcedure [dbo].[P_LAYVONTHUCCHITHEOTHANG]    Script Date: 14/03/2018 3:37:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[P_LAYVONTHUCCHITHEOTHANG](
	@thang int, 
	@nam int
)
AS
BEGIN
	SELECT (SELECT DonGiaNhap FROM HangHoa WHERE Id = CTHD.IdHangHoa) * CTHD.SoLuong FROM ChiTietHoaDon CTHD WHERE CTHD.IdHoaDon IN
	(SELECT ID FROM HoaDon WHERE DATEPART( MONTH,ThoiGian) = @thang AND DATEPART(YEAR,ThoiGian) = @nam)
END 

GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 14/03/2018 3:37:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdHoaDon] [int] NOT NULL,
	[IdHangHoa] [int] NOT NULL,
	[SoLuong] [tinyint] NOT NULL,
	[MoTa] [ntext] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 14/03/2018 3:37:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGiaNhap] [money] NOT NULL,
	[DonGiaBan] [money] NOT NULL,
	[MoTa] [ntext] NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 14/03/2018 3:37:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ThoiGian] [date] NOT NULL,
	[IdNguoiXuat] [nchar](20) NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 14/03/2018 3:37:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [nchar](20) NULL,
	[Pass] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuanLy]    Script Date: 14/03/2018 3:37:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLy](
	[ID] [nchar](20) NOT NULL,
	[Pass] [nvarchar](max) NULL,
 CONSTRAINT [PK_QuanLy] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON 

INSERT [dbo].[ChiTietHoaDon] ([Id], [IdHoaDon], [IdHangHoa], [SoLuong], [MoTa]) VALUES (1, 1, 1, 100, N' ')
INSERT [dbo].[ChiTietHoaDon] ([Id], [IdHoaDon], [IdHangHoa], [SoLuong], [MoTa]) VALUES (4, 6, 1, 50, N' ')
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
SET IDENTITY_INSERT [dbo].[HangHoa] ON 

INSERT [dbo].[HangHoa] ([Id], [Ten], [SoLuong], [DonGiaNhap], [DonGiaBan], [MoTa]) VALUES (1, N'Lua to tam', 1000, 3000.0000, 5000.0000, N'Tao cung k biet')
SET IDENTITY_INSERT [dbo].[HangHoa] OFF
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([Id], [ThoiGian], [IdNguoiXuat]) VALUES (1, CAST(0xFE3D0B00 AS Date), N'hh                  ')
INSERT [dbo].[HoaDon] ([Id], [ThoiGian], [IdNguoiXuat]) VALUES (2, CAST(0xF13D0B00 AS Date), N'hh                  ')
INSERT [dbo].[HoaDon] ([Id], [ThoiGian], [IdNguoiXuat]) VALUES (3, CAST(0xF33D0B00 AS Date), N'hh                  ')
INSERT [dbo].[HoaDon] ([Id], [ThoiGian], [IdNguoiXuat]) VALUES (4, CAST(0x123E0B00 AS Date), N'hh                  ')
INSERT [dbo].[HoaDon] ([Id], [ThoiGian], [IdNguoiXuat]) VALUES (5, CAST(0x4F3E0B00 AS Date), N'hh                  ')
INSERT [dbo].[HoaDon] ([Id], [ThoiGian], [IdNguoiXuat]) VALUES (6, CAST(0xE23C0B00 AS Date), N'hh                  ')
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
INSERT [dbo].[QuanLy] ([ID], [Pass]) VALUES (N'hh                  ', N'123')
INSERT [dbo].[QuanLy] ([ID], [Pass]) VALUES (N'hoaitrinh           ', N'12345')
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HangHoa] FOREIGN KEY([IdHangHoa])
REFERENCES [dbo].[HangHoa] ([Id])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HangHoa]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([IdHoaDon])
REFERENCES [dbo].[HoaDon] ([Id])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_QuanLy] FOREIGN KEY([IdNguoiXuat])
REFERENCES [dbo].[QuanLy] ([ID])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_QuanLy]
GO
USE [master]
GO
ALTER DATABASE [QLCuaHangVai] SET  READ_WRITE 
GO
