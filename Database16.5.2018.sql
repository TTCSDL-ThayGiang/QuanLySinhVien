USE [master]
GO
/****** Object:  Database [Quan_ly_sinh_vien]    Script Date: 5/16/2018 11:45:02 AM ******/
CREATE DATABASE [Quan_ly_sinh_vien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quan_ly_sinh_vien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.TC\MSSQL\DATA\Quan_ly_sinh_vien.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Quan_ly_sinh_vien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.TC\MSSQL\DATA\Quan_ly_sinh_vien_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quan_ly_sinh_vien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET RECOVERY FULL 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET  MULTI_USER 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Quan_ly_sinh_vien', N'ON'
GO
USE [Quan_ly_sinh_vien]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 5/16/2018 11:45:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[DisplayName] [nvarchar](100) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](100) NOT NULL DEFAULT ((0)),
	[Type] [int] NOT NULL DEFAULT ((3)),
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bang_diem]    Script Date: 5/16/2018 11:45:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bang_diem](
	[Ma_sinh_vien] [char](10) NOT NULL,
	[Ma_hoc_phan] [char](10) NOT NULL,
	[Diem_chuyen_can] [int] NULL,
	[Diem_thuong_xuyen] [int] NULL,
	[Diem_cuoi_ky] [int] NULL,
 CONSTRAINT [SV_HP] PRIMARY KEY CLUSTERED 
(
	[Ma_sinh_vien] ASC,
	[Ma_hoc_phan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Giao_vien]    Script Date: 5/16/2018 11:45:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Giao_vien](
	[Ma_Giao_Vien] [char](10) NOT NULL,
	[Ten_giao_vien] [nvarchar](50) NULL,
	[Gioi_tinh] [bit] NULL,
	[Hoc_vi] [nvarchar](30) NULL,
	[Dia_chi] [nvarchar](50) NULL,
	[Ma_khoa] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_Giao_Vien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hoc_ky]    Script Date: 5/16/2018 11:45:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hoc_ky](
	[Ma_hoc_ky] [char](10) NOT NULL,
	[Ten_hoc_ky] [nvarchar](30) NULL,
	[Thoi_gian_bat_dau] [date] NULL,
	[Thoi_gian_ket_thuc] [date] NULL,
	[Ma_lop] [char](10) NULL,
	[Nam_hoc] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_hoc_ky] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hoc_phan]    Script Date: 5/16/2018 11:45:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hoc_phan](
	[Ma_hoc_phan] [char](10) NOT NULL,
	[Ten_hoc_phan] [nvarchar](30) NULL,
	[So_tin_chi] [int] NULL,
	[Ma_hoc_ky] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_hoc_phan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 5/16/2018 11:45:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Khoa](
	[Ma_khoa] [char](10) NOT NULL,
	[Ten_khoa] [nvarchar](50) NULL,
	[Ma_cnkhoa] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_khoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KyHoc]    Script Date: 5/16/2018 11:45:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyHoc](
	[Makyhoc] [int] NOT NULL,
	[Tenhocky] [nvarchar](20) NOT NULL,
	[Manamhoc] [int] NULL,
 CONSTRAINT [PK_KyHoc] PRIMARY KEY CLUSTERED 
(
	[Makyhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lop]    Script Date: 5/16/2018 11:45:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lop](
	[Ma_lop] [char](10) NOT NULL,
	[Ten_lop] [nvarchar](50) NULL,
	[Ma_khoa] [char](10) NULL,
	[Ma_giaoviencn] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_lop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lop_hoc_phan]    Script Date: 5/16/2018 11:45:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lop_hoc_phan](
	[Ma_lop_hoc_phan] [char](10) NOT NULL,
	[Ma_hoc_phan] [char](10) NULL,
	[Ma_giao_vien] [char](10) NULL,
	[So_sv_toi_da] [int] NULL,
	[Ngay_bat_dau] [date] NULL,
	[Thoi_gian_hoc] [nvarchar](50) NULL,
	[Giang_duong] [nvarchar](20) NULL,
	[Ngay_ket_thuc] [date] NULL,
	[Ngay_thi] [date] NULL,
	[Hinh_thuc_thi] [nvarchar](30) NULL,
	[MaKyHoc] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_lop_hoc_phan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Namhoc]    Script Date: 5/16/2018 11:45:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Namhoc](
	[Manamhoc] [int] NOT NULL,
	[Tennamhoc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Namhoc] PRIMARY KEY CLUSTERED 
(
	[Manamhoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phieu_dang_ky]    Script Date: 5/16/2018 11:45:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phieu_dang_ky](
	[Ma_phieu] [char](10) NOT NULL,
	[Ma_sinh_vien] [char](10) NULL,
	[Ma_lop_hoc_phan] [char](10) NULL,
	[Lan_dang_ky] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ma_phieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sinh_vien]    Script Date: 5/16/2018 11:45:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sinh_vien](
	[Ma_sinh_vien] [char](10) NOT NULL,
	[Ten_sinh_vien] [nvarchar](50) NULL,
	[Ngay_sinh] [date] NULL,
	[Gioi_tinh] [nvarchar](5) NULL,
	[Dia_chi] [nvarchar](50) NULL,
	[Ma_lop] [char](10) NULL,
 CONSTRAINT [PK__Sinh_vie__D1CBC51D2BB4B4E9] PRIMARY KEY CLUSTERED 
(
	[Ma_sinh_vien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Account] ([DisplayName], [UserName], [PassWord], [Type]) VALUES (N'Admin', N'Admin', N'1', 1)
INSERT [dbo].[Account] ([DisplayName], [UserName], [PassWord], [Type]) VALUES (N'ABC', N'GiaoVien1', N'1', 2)
INSERT [dbo].[Account] ([DisplayName], [UserName], [PassWord], [Type]) VALUES (N'TienChung', N'Hocsinh1', N'1', 3)
INSERT [dbo].[Bang_diem] ([Ma_sinh_vien], [Ma_hoc_phan], [Diem_chuyen_can], [Diem_thuong_xuyen], [Diem_cuoi_ky]) VALUES (N'SV1       ', N'06201151  ', 6, 7, 8)
INSERT [dbo].[Bang_diem] ([Ma_sinh_vien], [Ma_hoc_phan], [Diem_chuyen_can], [Diem_thuong_xuyen], [Diem_cuoi_ky]) VALUES (N'SV1       ', N'12100151  ', 4, 9, 7)
INSERT [dbo].[Bang_diem] ([Ma_sinh_vien], [Ma_hoc_phan], [Diem_chuyen_can], [Diem_thuong_xuyen], [Diem_cuoi_ky]) VALUES (N'sv1       ', N'12101151  ', 6, 9, 9)
INSERT [dbo].[Bang_diem] ([Ma_sinh_vien], [Ma_hoc_phan], [Diem_chuyen_can], [Diem_thuong_xuyen], [Diem_cuoi_ky]) VALUES (N'sv1       ', N'12160151  ', 8, 9, 6)
INSERT [dbo].[Bang_diem] ([Ma_sinh_vien], [Ma_hoc_phan], [Diem_chuyen_can], [Diem_thuong_xuyen], [Diem_cuoi_ky]) VALUES (N'sv2       ', N'12221151  ', 7, 7, 7)
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV1       ', N'Bùi Quốc Hưng', 1, N'TS', N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV10      ', N'Lưu Hồng Dũng', 1, N'TS', N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV11      ', N'Tạ Minh Thanh', 1, N'TS', N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV12      ', N'Lê Văn Toán', 1, N'ts', N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV13      ', N'Phạm Mạnh Thảo', 0, NULL, N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV14      ', N'Nguyễn Tài Hoài Thanh', 0, NULL, N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV15      ', N'Bùi Hữu Toán ', 1, NULL, N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV16      ', N'Lưu Xuân Bách', 1, NULL, N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV17      ', N'Lê Quang Huy', 1, NULL, N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV18      ', N'Phan Nguyên Hải', 1, NULL, N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV19      ', N'Phạm Văn Việt', 1, NULL, N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV2       ', N'Bùi Văn Định', 1, N'TS', N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV20      ', N'Phạm Quốc Hoàng', 1, NULL, N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV21      ', N' Lê Văn Luận', 1, NULL, N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV22      ', N'Nguyễn Trung Thành', 1, NULL, N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV23      ', N'Nguyễn Văn Toàn', 1, NULL, N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV24      ', N'Lê Khắc Thủy', 1, NULL, N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV25      ', N'Phùng Mạnh Hùng', 1, NULL, N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV3       ', N'Đỗ Anh Tuấn', 1, N'TS', N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV4       ', N'Nguyễn Thị Thu Hương', 0, N'TS', N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV5       ', N'Phạm Thế Anh', 1, N'TS', N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV6       ', N'Phạm Tiến Dũng', 1, N'TS', N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV7       ', N'Vũ Anh Mỹ', 0, N'TS', N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV8       ', N'Nguyễn Trung Thành', 1, N'TS', N'Hà Nội', N'1         ')
INSERT [dbo].[Giao_vien] ([Ma_Giao_Vien], [Ten_giao_vien], [Gioi_tinh], [Hoc_vi], [Dia_chi], [Ma_khoa]) VALUES (N'GV9       ', N'Nguyễn Quang Uy', 1, N'TS', N'Hà Nội', N'1         ')
INSERT [dbo].[Hoc_ky] ([Ma_hoc_ky], [Ten_hoc_ky], [Thoi_gian_bat_dau], [Thoi_gian_ket_thuc], [Ma_lop], [Nam_hoc]) VALUES (N'1         ', N'Học kỳ 1', CAST(N'2018-04-03' AS Date), NULL, N'CNTT14    ', N'2017-2018')
INSERT [dbo].[Hoc_ky] ([Ma_hoc_ky], [Ten_hoc_ky], [Thoi_gian_bat_dau], [Thoi_gian_ket_thuc], [Ma_lop], [Nam_hoc]) VALUES (N'2         ', N'Học kỳ 2', CAST(N'2018-04-03' AS Date), NULL, N'CNTT14    ', N'2017-2018')
INSERT [dbo].[Hoc_ky] ([Ma_hoc_ky], [Ten_hoc_ky], [Thoi_gian_bat_dau], [Thoi_gian_ket_thuc], [Ma_lop], [Nam_hoc]) VALUES (N'3         ', N'Học kỳ 3', CAST(N'2018-04-03' AS Date), NULL, N'CNTT14    ', N'2017-2018')
INSERT [dbo].[Hoc_ky] ([Ma_hoc_ky], [Ten_hoc_ky], [Thoi_gian_bat_dau], [Thoi_gian_ket_thuc], [Ma_lop], [Nam_hoc]) VALUES (N'4         ', N'Học kỳ 4', CAST(N'2018-04-03' AS Date), NULL, N'CNTT14    ', N'2017-2018')
INSERT [dbo].[Hoc_ky] ([Ma_hoc_ky], [Ten_hoc_ky], [Thoi_gian_bat_dau], [Thoi_gian_ket_thuc], [Ma_lop], [Nam_hoc]) VALUES (N'5         ', N'Học jỳ 5', CAST(N'2018-04-03' AS Date), NULL, N'CNTT14    ', N'2017-2018')
INSERT [dbo].[Hoc_ky] ([Ma_hoc_ky], [Ten_hoc_ky], [Thoi_gian_bat_dau], [Thoi_gian_ket_thuc], [Ma_lop], [Nam_hoc]) VALUES (N'6         ', N'Học kỳ 6', CAST(N'2018-04-03' AS Date), NULL, N'CNTT14    ', N'2017-2018')
INSERT [dbo].[Hoc_ky] ([Ma_hoc_ky], [Ten_hoc_ky], [Thoi_gian_bat_dau], [Thoi_gian_ket_thuc], [Ma_lop], [Nam_hoc]) VALUES (N'7         ', N'Học kỳ 7', CAST(N'2018-04-03' AS Date), NULL, N'CNTT14    ', N'2017-2018')
INSERT [dbo].[Hoc_ky] ([Ma_hoc_ky], [Ten_hoc_ky], [Thoi_gian_bat_dau], [Thoi_gian_ket_thuc], [Ma_lop], [Nam_hoc]) VALUES (N'8         ', N'Học kỳ 8', CAST(N'2018-04-03' AS Date), NULL, N'CNTT14    ', N'2017-2018')
INSERT [dbo].[Hoc_ky] ([Ma_hoc_ky], [Ten_hoc_ky], [Thoi_gian_bat_dau], [Thoi_gian_ket_thuc], [Ma_lop], [Nam_hoc]) VALUES (N'9         ', N'Học kỳ 9', CAST(N'2018-04-03' AS Date), NULL, N'CNTT14    ', NULL)
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'06201151  ', N'Quân sự chung', 2, N'1         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12100151  ', N'Hình giải tích', 3, N'1         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12101151  ', N'Giải tích 1', 4, N'1         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12160151  ', N'Toán chuyên đề', 4, N'2         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12221151  ', N'Toán rời rạc', 3, N'4         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12224151  ', N'Lý thuyết hệ điều
hành', 3, N'4         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12225151  ', N'Phân tích thiết kế giải thuật ', 3, N'6         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12321151  ', N'Cơ sở dữ liệu', 4, N'5         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12322151  ', N'Đảm bảo và an toàn
thông tin', 3, N'5         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12323151  ', N'Công nghệ phần
mềm', 3, N'6         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12324151  ', N'Tương tác người máy', 2, N'6         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12421151  ', N'Mạng máy tính', 3, N'4         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12423151  ', N'Công nghệ lập trình
tích hợp', 2, N'6         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12500151  ', N'Lập trình cơ bản', 3, N'2         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12522151  ', N'Lập trình hướng đối
tượng', 3, N'4         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12524151  ', N'Ngôn ngữ lập trình 1', 2, N'3         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12525151  ', N'Kỹ thuật Lập trình', 3, N'3         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'12525152  ', N'Ngôn ngữ lập trình
2', 2, N'5         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'13103151  ', N'Tiếng Anh B11', 3, N'7         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'3         ', N'Giải tích 2 ', 4, N'2         ')
INSERT [dbo].[Hoc_phan] ([Ma_hoc_phan], [Ten_hoc_phan], [So_tin_chi], [Ma_hoc_ky]) VALUES (N'3222215   ', N'Cấu trúc máy tính', 3, N'5         ')
INSERT [dbo].[Khoa] ([Ma_khoa], [Ten_khoa], [Ma_cnkhoa]) VALUES (N'1         ', N'Công nghệ thông tin', N'1         ')
INSERT [dbo].[Khoa] ([Ma_khoa], [Ten_khoa], [Ma_cnkhoa]) VALUES (N'2         ', N'Khoa cơ khí', N'2         ')
INSERT [dbo].[Khoa] ([Ma_khoa], [Ten_khoa], [Ma_cnkhoa]) VALUES (N'3         ', N'Khoa động lực', N'3         ')
INSERT [dbo].[Khoa] ([Ma_khoa], [Ten_khoa], [Ma_cnkhoa]) VALUES (N'4         ', N'Khoa vô tuyến', N'4         ')
INSERT [dbo].[KyHoc] ([Makyhoc], [Tenhocky], [Manamhoc]) VALUES (1, N'Học kỳ1', 1)
INSERT [dbo].[KyHoc] ([Makyhoc], [Tenhocky], [Manamhoc]) VALUES (2, N'Học kỳ 2', 1)
INSERT [dbo].[KyHoc] ([Makyhoc], [Tenhocky], [Manamhoc]) VALUES (3, N'Học kỳ 1', 2)
INSERT [dbo].[KyHoc] ([Makyhoc], [Tenhocky], [Manamhoc]) VALUES (4, N'Học kỳ 2', 2)
INSERT [dbo].[Lop] ([Ma_lop], [Ten_lop], [Ma_khoa], [Ma_giaoviencn]) VALUES (N'CNPM14    ', N'Công nghệ phần mềm 14', N'1         ', N'GV4       ')
INSERT [dbo].[Lop] ([Ma_lop], [Ten_lop], [Ma_khoa], [Ma_giaoviencn]) VALUES (N'CNPM15    ', N'Công nghệ phần mềm 15', N'1         ', N'GV4       ')
INSERT [dbo].[Lop] ([Ma_lop], [Ten_lop], [Ma_khoa], [Ma_giaoviencn]) VALUES (N'CNPM16    ', N'Công nghệ phần mềm 16', N'1         ', N'GV4       ')
INSERT [dbo].[Lop] ([Ma_lop], [Ten_lop], [Ma_khoa], [Ma_giaoviencn]) VALUES (N'CNPM17    ', N'Công nghệ phần mềm 17', N'1         ', N'GV4       ')
INSERT [dbo].[Lop] ([Ma_lop], [Ten_lop], [Ma_khoa], [Ma_giaoviencn]) VALUES (N'CNTT14    ', N'Công nghệ thông tin 14', N'1         ', N'GV1       ')
INSERT [dbo].[Lop] ([Ma_lop], [Ten_lop], [Ma_khoa], [Ma_giaoviencn]) VALUES (N'CNTT15    ', N'Công nghệ thông tin 15', N'1         ', N'GV1       ')
INSERT [dbo].[Lop] ([Ma_lop], [Ten_lop], [Ma_khoa], [Ma_giaoviencn]) VALUES (N'CNTT16    ', N'Công nghệ thông tin 16', N'1         ', N'GV1       ')
INSERT [dbo].[Lop] ([Ma_lop], [Ten_lop], [Ma_khoa], [Ma_giaoviencn]) VALUES (N'HTTT14    ', N'Hệ thống thông tin 14', N'1         ', N'GV2       ')
INSERT [dbo].[Lop] ([Ma_lop], [Ten_lop], [Ma_khoa], [Ma_giaoviencn]) VALUES (N'HTTT15    ', N'Hệ thống thông tin 15', N'1         ', N'GV2       ')
INSERT [dbo].[Lop] ([Ma_lop], [Ten_lop], [Ma_khoa], [Ma_giaoviencn]) VALUES (N'HTTT16    ', N'Hệ thống thông tin 16', N'1         ', N'GV2       ')
INSERT [dbo].[Lop] ([Ma_lop], [Ten_lop], [Ma_khoa], [Ma_giaoviencn]) VALUES (N'MMT14     ', N'Mạng máy tính 14', N'1         ', N'GV3       ')
INSERT [dbo].[Lop] ([Ma_lop], [Ten_lop], [Ma_khoa], [Ma_giaoviencn]) VALUES (N'MMT15     ', N'Mạng máy tính 15', N'1         ', N'GV3       ')
INSERT [dbo].[Lop] ([Ma_lop], [Ten_lop], [Ma_khoa], [Ma_giaoviencn]) VALUES (N'MMT16     ', N'Mạng máy tính 16', N'1         ', N'GV3       ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'06201151  ', N'06201151  ', N'GV1       ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5315', NULL, CAST(N'2018-04-04' AS Date), N'Viết', NULL)
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'06201152  ', N'06201151  ', N'GV1       ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5315', NULL, CAST(N'2018-04-04' AS Date), N'Viết', NULL)
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'12101151 1', N'12101151  ', N'GV15      ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5315', NULL, NULL, N'Viết', N'1         ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'12101151 2', N'12101151  ', N'GV15      ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5315', NULL, NULL, N'Viết', N'1         ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'12160151 1', N'12160151  ', N'GV16      ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5312', NULL, NULL, N'Viết', N'1         ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'12160151 2', N'12160151  ', N'GV16      ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5312', NULL, NULL, N'Viết', N'1         ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'12160151 3', N'12160151  ', N'GV16      ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5312', NULL, NULL, N'Viết', N'1         ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'12160151 4', N'12160151  ', N'GV17      ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5312', NULL, NULL, N'Viết', N'1         ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'12160151 5', N'12160151  ', N'GV17      ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5312', NULL, NULL, N'Viết', N'1         ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'12160151 6', N'12160151  ', N'GV17      ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5312', NULL, NULL, N'Viết', N'1         ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'13103151 1', N'13103151  ', N'GV18      ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5509', NULL, NULL, N'Viết', N'1         ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'13103151 2', N'13103151  ', N'GV19      ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5509', NULL, NULL, N'Viết', N'1         ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'13103151 3', N'13103151  ', N'GV18      ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5511', NULL, NULL, N'Viết', N'2         ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'13103151 4', N'13103151  ', N'GV19      ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5511', NULL, NULL, N'Viết', N'2         ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'13103151 5', N'13103151  ', N'GV18      ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5511', NULL, NULL, N'Viết', N'2         ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'13103151 6', N'13103151  ', N'GV19      ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5512', NULL, NULL, N'Viết', N'2         ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'13103151 7', N'13103151  ', N'GV18      ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5512', NULL, NULL, N'Viết', N'2         ')
INSERT [dbo].[Lop_hoc_phan] ([Ma_lop_hoc_phan], [Ma_hoc_phan], [Ma_giao_vien], [So_sv_toi_da], [Ngay_bat_dau], [Thoi_gian_hoc], [Giang_duong], [Ngay_ket_thuc], [Ngay_thi], [Hinh_thuc_thi], [MaKyHoc]) VALUES (N'13103151 8', N'06201151  ', N'GV1       ', 100, CAST(N'2018-04-03' AS Date), NULL, N'H5 5512', NULL, CAST(N'2018-05-10' AS Date), N'Viết', NULL)
INSERT [dbo].[Namhoc] ([Manamhoc], [Tennamhoc]) VALUES (1, N'Năm học 2015-2016')
INSERT [dbo].[Namhoc] ([Manamhoc], [Tennamhoc]) VALUES (2, N'Năm học 2016-2017')
INSERT [dbo].[Namhoc] ([Manamhoc], [Tennamhoc]) VALUES (3, N'Năm học 2017-2018')
INSERT [dbo].[Namhoc] ([Manamhoc], [Tennamhoc]) VALUES (4, N'Năm học 2018-2019')
INSERT [dbo].[Namhoc] ([Manamhoc], [Tennamhoc]) VALUES (5, N'Năm học 2019-2020')
INSERT [dbo].[Sinh_vien] ([Ma_sinh_vien], [Ten_sinh_vien], [Ngay_sinh], [Gioi_tinh], [Dia_chi], [Ma_lop]) VALUES (N'SV1       ', N'Tiêu Năng Đạt', CAST(N'2018-04-02' AS Date), N'nam', N'Hà Nội', N'CNTT14    ')
INSERT [dbo].[Sinh_vien] ([Ma_sinh_vien], [Ten_sinh_vien], [Ngay_sinh], [Gioi_tinh], [Dia_chi], [Ma_lop]) VALUES (N'SV10      ', N'Đặng Quốc Đạt', CAST(N'2018-04-02' AS Date), N'nam', N'Hà Nội', N'CNTT14    ')
INSERT [dbo].[Sinh_vien] ([Ma_sinh_vien], [Ten_sinh_vien], [Ngay_sinh], [Gioi_tinh], [Dia_chi], [Ma_lop]) VALUES (N'SV2       ', N'Hoàng Văn Đông', CAST(N'2018-04-02' AS Date), N'nam', N'Hà Nội', N'CNTT14    ')
INSERT [dbo].[Sinh_vien] ([Ma_sinh_vien], [Ten_sinh_vien], [Ngay_sinh], [Gioi_tinh], [Dia_chi], [Ma_lop]) VALUES (N'SV3       ', N'Đỗ Viết Hiểu', CAST(N'2018-04-02' AS Date), N'nam', N'Hà Nội', N'CNTT14    ')
INSERT [dbo].[Sinh_vien] ([Ma_sinh_vien], [Ten_sinh_vien], [Ngay_sinh], [Gioi_tinh], [Dia_chi], [Ma_lop]) VALUES (N'SV4       ', N'Trần Hải Long', CAST(N'2018-04-02' AS Date), N'nam', N'Hà Nội', N'CNTT14    ')
INSERT [dbo].[Sinh_vien] ([Ma_sinh_vien], [Ten_sinh_vien], [Ngay_sinh], [Gioi_tinh], [Dia_chi], [Ma_lop]) VALUES (N'SV5       ', N'Phạm Văn Nam', CAST(N'2018-04-02' AS Date), N'nam', N'Hà Nội', N'CNTT14    ')
INSERT [dbo].[Sinh_vien] ([Ma_sinh_vien], [Ten_sinh_vien], [Ngay_sinh], [Gioi_tinh], [Dia_chi], [Ma_lop]) VALUES (N'SV6       ', N'Dương Ngọc Sáng', CAST(N'2018-04-02' AS Date), N'nữ', N'Hà Nội', N'CNTT14    ')
INSERT [dbo].[Sinh_vien] ([Ma_sinh_vien], [Ten_sinh_vien], [Ngay_sinh], [Gioi_tinh], [Dia_chi], [Ma_lop]) VALUES (N'SV7       ', N'Bùi Minh Tuấn', CAST(N'2018-04-02' AS Date), N'nữ', N'Hà Nội', N'CNTT14    ')
INSERT [dbo].[Sinh_vien] ([Ma_sinh_vien], [Ten_sinh_vien], [Ngay_sinh], [Gioi_tinh], [Dia_chi], [Ma_lop]) VALUES (N'SV8       ', N'Trần Bùi Bông', CAST(N'2018-04-02' AS Date), N'nữ', N'Hà Nội', N'CNTT14    ')
INSERT [dbo].[Sinh_vien] ([Ma_sinh_vien], [Ten_sinh_vien], [Ngay_sinh], [Gioi_tinh], [Dia_chi], [Ma_lop]) VALUES (N'SV9       ', N'Bùi Quang Đạt', CAST(N'2018-04-02' AS Date), N'nam', N'Hà Nội', N'CNTT14    ')
ALTER TABLE [dbo].[Bang_diem]  WITH CHECK ADD FOREIGN KEY([Ma_hoc_phan])
REFERENCES [dbo].[Hoc_phan] ([Ma_hoc_phan])
GO
ALTER TABLE [dbo].[Bang_diem]  WITH CHECK ADD  CONSTRAINT [FK__Bang_diem__Ma_si__2C3393D0] FOREIGN KEY([Ma_sinh_vien])
REFERENCES [dbo].[Sinh_vien] ([Ma_sinh_vien])
GO
ALTER TABLE [dbo].[Bang_diem] CHECK CONSTRAINT [FK__Bang_diem__Ma_si__2C3393D0]
GO
ALTER TABLE [dbo].[Giao_vien]  WITH CHECK ADD FOREIGN KEY([Ma_khoa])
REFERENCES [dbo].[Khoa] ([Ma_khoa])
GO
ALTER TABLE [dbo].[Hoc_ky]  WITH CHECK ADD FOREIGN KEY([Ma_lop])
REFERENCES [dbo].[Lop] ([Ma_lop])
GO
ALTER TABLE [dbo].[Hoc_phan]  WITH CHECK ADD FOREIGN KEY([Ma_hoc_ky])
REFERENCES [dbo].[Hoc_ky] ([Ma_hoc_ky])
GO
ALTER TABLE [dbo].[KyHoc]  WITH CHECK ADD  CONSTRAINT [FK_KyHoc_Namhoc] FOREIGN KEY([Manamhoc])
REFERENCES [dbo].[Namhoc] ([Manamhoc])
GO
ALTER TABLE [dbo].[KyHoc] CHECK CONSTRAINT [FK_KyHoc_Namhoc]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([Ma_giaoviencn])
REFERENCES [dbo].[Giao_vien] ([Ma_Giao_Vien])
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([Ma_khoa])
REFERENCES [dbo].[Khoa] ([Ma_khoa])
GO
ALTER TABLE [dbo].[Lop_hoc_phan]  WITH CHECK ADD FOREIGN KEY([Ma_giao_vien])
REFERENCES [dbo].[Giao_vien] ([Ma_Giao_Vien])
GO
ALTER TABLE [dbo].[Lop_hoc_phan]  WITH CHECK ADD FOREIGN KEY([Ma_hoc_phan])
REFERENCES [dbo].[Hoc_phan] ([Ma_hoc_phan])
GO
ALTER TABLE [dbo].[Phieu_dang_ky]  WITH CHECK ADD  CONSTRAINT [FK__Phieu_dan__Ma_si__35BCFE0A] FOREIGN KEY([Ma_sinh_vien])
REFERENCES [dbo].[Sinh_vien] ([Ma_sinh_vien])
GO
ALTER TABLE [dbo].[Phieu_dang_ky] CHECK CONSTRAINT [FK__Phieu_dan__Ma_si__35BCFE0A]
GO
ALTER TABLE [dbo].[Sinh_vien]  WITH CHECK ADD  CONSTRAINT [FK__Sinh_vien__Ma_lo__38996AB5] FOREIGN KEY([Ma_lop])
REFERENCES [dbo].[Lop] ([Ma_lop])
GO
ALTER TABLE [dbo].[Sinh_vien] CHECK CONSTRAINT [FK__Sinh_vien__Ma_lo__38996AB5]
GO
/****** Object:  StoredProcedure [dbo].[GetAccountByUserName]    Script Date: 5/16/2018 11:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetAccountByUserName]
@username NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName=@username
END	

GO
/****** Object:  StoredProcedure [dbo].[GetGiaoVien]    Script Date: 5/16/2018 11:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetGiaoVien]
AS
SELECT * FROM dbo.Giao_vien

GO
/****** Object:  StoredProcedure [dbo].[GetHocPhan]    Script Date: 5/16/2018 11:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetHocPhan]
AS
BEGIN
	SELECT * FROM dbo.Hoc_phan
END



GO
/****** Object:  StoredProcedure [dbo].[GetLopHocPhan]    Script Date: 5/16/2018 11:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetLopHocPhan]
AS
BEGIN
	SELECT hp.Ma_hoc_phan, hp.Ten_hoc_phan, hp.So_tin_chi, 
	lhp.Ma_lop_hoc_phan, gv. Ma_giao_vien,gv.Ten_giao_vien, 
	lhp.So_sv_toi_da,lhp.Giang_duong,lhp.Ngay_bat_dau, lhp.Ngay_thi, 
	lhp.Hinh_thuc_thi, nh.Tennamhoc,kh.Tenhocky
	FROM dbo.Giao_vien gv,dbo.Hoc_phan hp,dbo.Lop_hoc_phan lhp ,dbo.Namhoc nh,dbo.KyHoc kh
	WHERE lhp.Ma_giao_vien=gv.Ma_giao_vien AND lhp.Ma_hoc_phan=hp.Ma_hoc_phan AND kh.Manamhoc=nh.Manamhoc AND lhp.MaKyHoc=kh.Makyhoc
END

GO
/****** Object:  StoredProcedure [dbo].[GetLopHocPhanByNamHocIDAndHocKyID]    Script Date: 5/16/2018 11:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetLopHocPhanByNamHocIDAndHocKyID]
@Namhocid int, @HocKyID int
AS
BEGIN
	SELECT hp.Ma_hoc_phan, hp.Ten_hoc_phan, hp.So_tin_chi, 
	lhp.Ma_lop_hoc_phan, gv. Ma_giao_vien,gv.Ten_giao_vien, 
	lhp.So_sv_toi_da,lhp.Giang_duong,lhp.Ngay_bat_dau, lhp.Ngay_thi, 
	lhp.Hinh_thuc_thi, nh.Tennamhoc,kh.Tenhocky
	FROM dbo.Giao_vien gv,dbo.Hoc_phan hp,dbo.Lop_hoc_phan lhp ,dbo.Namhoc nh,dbo.KyHoc kh
	WHERE lhp.Ma_giao_vien=gv.Ma_giao_vien AND lhp.Ma_hoc_phan=hp.Ma_hoc_phan AND kh.Manamhoc=nh.Manamhoc AND lhp.MaKyHoc=kh.Makyhoc
	AND nh.Manamhoc=@Namhocid AND kh.Makyhoc=@HocKyID
END 

GO
/****** Object:  StoredProcedure [dbo].[GetSinhVien]    Script Date: 5/16/2018 11:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetSinhVien]
AS
SELECT * FROM dbo.Sinh_vien

GO
/****** Object:  StoredProcedure [dbo].[InsertLopHocPhan]    Script Date: 5/16/2018 11:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[InsertLopHocPhan]
@malophocphan CHAR(10),@Ma_hoc_phan CHAR(10),
	          @Ma_giao_vien CHAR(10),
	          @So_sv_toi_da int,
	          @Ngay_bat_dau DATE,	          
	          @Giang_duong NVARCHAR(20),	          
	          @Ngay_thi DATE,
	          @Hinh_thuc_thi NVARCHAR(30)
AS
BEGIN
	INSERT dbo.Lop_hoc_phan
	        ( Ma_lop_hoc_phan ,
	          Ma_hoc_phan ,
	          Ma_giao_vien ,
	          So_sv_toi_da ,
	          Ngay_bat_dau ,
	          
	          Giang_duong ,
	          
	          Ngay_thi ,
	          Hinh_thuc_thi
	        )
	VALUES  ( @malophocphan , -- Ma_lop_hoc_phan - char(10)
	          @Ma_hoc_phan , -- Ma_hoc_phan - char(10)
	          @Ma_giao_vien , -- Ma_giao_vien - char(10)
	          @So_sv_toi_da , -- So_sv_toi_da - int
	          @Ngay_bat_dau , -- Ngay_bat_dau - date
	          @Giang_duong , -- Giang_duong - nvarchar(20)	          
	          @Ngay_thi , -- Ngay_thi - date
	          @Hinh_thuc_thi  -- Hinh_thuc_thi - nvarchar(30)
	        )
END


GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 5/16/2018 11:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Login]
@username NVARCHAR(100), @passWord NVARCHAR(100) AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName=@username AND PassWord=@passWord
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateLopHocPhan]    Script Date: 5/16/2018 11:45:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateLopHocPhan]
@malophocphancu CHAR(10), @malophocphanmoi CHAR(10),
			@Ma_hoc_phan CHAR(10),
	          @Ma_giao_vien CHAR(10),
	          @So_sv_toi_da int,
	          @Ngay_bat_dau DATE,	          
	          @Giang_duong NVARCHAR(20),	          
	          @Ngay_thi DATE,
	          @Hinh_thuc_thi NVARCHAR(30)
AS
BEGIN
	UPDATE dbo.Lop_hoc_phan SET Ma_lop_hoc_phan=@malophocphanmoi,Ma_hoc_phan=@Ma_hoc_phan,
    Ma_giao_vien=@Ma_giao_vien, So_sv_toi_da=@So_sv_toi_da, Ngay_bat_dau=@Ngay_bat_dau,
	Giang_duong=@Giang_duong,Ngay_thi=@Ngay_thi, Hinh_thuc_thi=@Hinh_thuc_thi WHERE Ma_lop_hoc_phan=@malophocphancu
END


GO
USE [master]
GO
ALTER DATABASE [Quan_ly_sinh_vien] SET  READ_WRITE 
GO
