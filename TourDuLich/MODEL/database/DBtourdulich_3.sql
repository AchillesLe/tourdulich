USE [master]
GO
/****** Object:  Database [tourdulich]    Script Date: 11/15/2017 6:09:54 PM ******/
CREATE DATABASE [tourdulich]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tourdulich', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\tourdulich.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'tourdulich_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\tourdulich_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [tourdulich] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tourdulich].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tourdulich] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tourdulich] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tourdulich] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tourdulich] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tourdulich] SET ARITHABORT OFF 
GO
ALTER DATABASE [tourdulich] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [tourdulich] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tourdulich] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tourdulich] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tourdulich] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tourdulich] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tourdulich] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tourdulich] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tourdulich] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tourdulich] SET  DISABLE_BROKER 
GO
ALTER DATABASE [tourdulich] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tourdulich] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tourdulich] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tourdulich] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tourdulich] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tourdulich] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tourdulich] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tourdulich] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [tourdulich] SET  MULTI_USER 
GO
ALTER DATABASE [tourdulich] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tourdulich] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tourdulich] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tourdulich] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [tourdulich] SET DELAYED_DURABILITY = DISABLED 
GO
USE [tourdulich]
GO
/****** Object:  Table [dbo].[ctthamquan]    Script Date: 11/15/2017 6:09:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ctthamquan](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[matour] [int] NOT NULL,
	[madiadiem] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[diadiems]    Script Date: 11/15/2017 6:09:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diadiems](
	[madiadiem] [int] IDENTITY(1,1) NOT NULL,
	[tendiadiem] [nvarchar](100) NOT NULL,
	[matinh] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[madiadiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[doandulichs]    Script Date: 11/15/2017 6:09:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doandulichs](
	[madoan] [int] IDENTITY(1,1) NOT NULL,
	[matour] [int] NOT NULL,
	[tendoan] [nvarchar](100) NOT NULL,
	[ngaykhoihanh] [datetime] NOT NULL,
	[ngayketthuc] [datetime] NOT NULL,
	[tongtienkhachsan] [float] NOT NULL,
	[tongtienan] [float] NOT NULL,
	[tongtienphuongtien] [float] NOT NULL,
	[tongtienchiphikhac] [float] NOT NULL,
	[tongtientour] [float] NOT NULL,
	[tongtiendoan] [float] NOT NULL,
	[ngaytao] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[madoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[doankhachhang]    Script Date: 11/15/2017 6:09:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doankhachhang](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[madoan] [int] NOT NULL,
	[makhachhang] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[doankhachsan]    Script Date: 11/15/2017 6:09:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doankhachsan](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[madoan] [int] NOT NULL,
	[makhachsan] [int] NOT NULL,
	[sotien] [float] NOT NULL,
	[ngayden] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[doannhanvien]    Script Date: 11/15/2017 6:09:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doannhanvien](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[madoan] [int] NOT NULL,
	[manhanvien] [int] NOT NULL,
	[manhiemvu] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khachhangs]    Script Date: 11/15/2017 6:09:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[khachhangs](
	[makhachhang] [int] IDENTITY(1,1) NOT NULL,
	[tenkhachhang] [nvarchar](100) NOT NULL,
	[sodienthoai] [nvarchar](100) NOT NULL,
	[cmt] [varchar](15) NOT NULL,
	[diachi] [varchar](100) NOT NULL,
	[sex] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[makhachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[khachsans]    Script Date: 11/15/2017 6:09:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachsans](
	[makhachsan] [int] IDENTITY(1,1) NOT NULL,
	[tenkhachsan] [nvarchar](100) NOT NULL,
	[matinh] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[makhachsan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[loaitours]    Script Date: 11/15/2017 6:09:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaitours](
	[maloai] [int] IDENTITY(1,1) NOT NULL,
	[tenloaitour] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhanviens]    Script Date: 11/15/2017 6:09:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanviens](
	[manhanvien] [int] IDENTITY(1,1) NOT NULL,
	[tennhanvien] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhiemvus]    Script Date: 11/15/2017 6:09:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhiemvus](
	[manhiemvu] [int] IDENTITY(1,1) NOT NULL,
	[tennhiemvu] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[manhiemvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tinhs]    Script Date: 11/15/2017 6:09:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tinhs](
	[matinh] [int] IDENTITY(1,1) NOT NULL,
	[tentinh] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[matinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tours]    Script Date: 11/15/2017 6:09:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tours](
	[matour] [int] IDENTITY(1,1) NOT NULL,
	[tentour] [nvarchar](100) NOT NULL,
	[diemden] [int] NOT NULL,
	[diemdi] [int] NOT NULL,
	[dacdiem] [text] NOT NULL,
	[giatour] [float] NOT NULL,
	[loaitour] [int] NOT NULL,
	[ngaytao] [datetime] NOT NULL,
	[ngaycapnhat] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[matour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[doandulichs] ADD  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[khachhangs] ADD  DEFAULT ((1)) FOR [sex]
GO
ALTER TABLE [dbo].[tours] ADD  DEFAULT (getdate()) FOR [ngaytao]
GO
ALTER TABLE [dbo].[tours] ADD  DEFAULT (getdate()) FOR [ngaycapnhat]
GO
ALTER TABLE [dbo].[ctthamquan]  WITH CHECK ADD  CONSTRAINT [FK_ctthamquan_diadiem] FOREIGN KEY([madiadiem])
REFERENCES [dbo].[diadiems] ([madiadiem])
GO
ALTER TABLE [dbo].[ctthamquan] CHECK CONSTRAINT [FK_ctthamquan_diadiem]
GO
ALTER TABLE [dbo].[ctthamquan]  WITH CHECK ADD  CONSTRAINT [FK_ctthamquan_tour] FOREIGN KEY([matour])
REFERENCES [dbo].[tours] ([matour])
GO
ALTER TABLE [dbo].[ctthamquan] CHECK CONSTRAINT [FK_ctthamquan_tour]
GO
ALTER TABLE [dbo].[diadiems]  WITH CHECK ADD  CONSTRAINT [FK_diadiems_tinhs] FOREIGN KEY([matinh])
REFERENCES [dbo].[tinhs] ([matinh])
GO
ALTER TABLE [dbo].[diadiems] CHECK CONSTRAINT [FK_diadiems_tinhs]
GO
ALTER TABLE [dbo].[doandulichs]  WITH CHECK ADD  CONSTRAINT [FK_doandulichs_tours] FOREIGN KEY([matour])
REFERENCES [dbo].[tours] ([matour])
GO
ALTER TABLE [dbo].[doandulichs] CHECK CONSTRAINT [FK_doandulichs_tours]
GO
ALTER TABLE [dbo].[doankhachhang]  WITH CHECK ADD  CONSTRAINT [FK_doankhachhang_doandulichs] FOREIGN KEY([madoan])
REFERENCES [dbo].[doandulichs] ([madoan])
GO
ALTER TABLE [dbo].[doankhachhang] CHECK CONSTRAINT [FK_doankhachhang_doandulichs]
GO
ALTER TABLE [dbo].[doankhachhang]  WITH CHECK ADD  CONSTRAINT [FK_doankhachhang_khachhang] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[khachhangs] ([makhachhang])
GO
ALTER TABLE [dbo].[doankhachhang] CHECK CONSTRAINT [FK_doankhachhang_khachhang]
GO
ALTER TABLE [dbo].[doankhachsan]  WITH CHECK ADD  CONSTRAINT [FK_doankhachsan_doandulichs] FOREIGN KEY([madoan])
REFERENCES [dbo].[doandulichs] ([madoan])
GO
ALTER TABLE [dbo].[doankhachsan] CHECK CONSTRAINT [FK_doankhachsan_doandulichs]
GO
ALTER TABLE [dbo].[doankhachsan]  WITH CHECK ADD  CONSTRAINT [FK_doankhachsan_khachsan] FOREIGN KEY([makhachsan])
REFERENCES [dbo].[khachsans] ([makhachsan])
GO
ALTER TABLE [dbo].[doankhachsan] CHECK CONSTRAINT [FK_doankhachsan_khachsan]
GO
ALTER TABLE [dbo].[doannhanvien]  WITH CHECK ADD  CONSTRAINT [FK_doannhanvien_doandulichs] FOREIGN KEY([madoan])
REFERENCES [dbo].[doandulichs] ([madoan])
GO
ALTER TABLE [dbo].[doannhanvien] CHECK CONSTRAINT [FK_doannhanvien_doandulichs]
GO
ALTER TABLE [dbo].[doannhanvien]  WITH CHECK ADD  CONSTRAINT [FK_doannhanvien_nhanviens] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[nhanviens] ([manhanvien])
GO
ALTER TABLE [dbo].[doannhanvien] CHECK CONSTRAINT [FK_doannhanvien_nhanviens]
GO
ALTER TABLE [dbo].[doannhanvien]  WITH CHECK ADD  CONSTRAINT [FK_doannhanvien_nhiemvu] FOREIGN KEY([manhiemvu])
REFERENCES [dbo].[nhiemvus] ([manhiemvu])
GO
ALTER TABLE [dbo].[doannhanvien] CHECK CONSTRAINT [FK_doannhanvien_nhiemvu]
GO
ALTER TABLE [dbo].[khachsans]  WITH CHECK ADD  CONSTRAINT [FK_khachsans_tinhs] FOREIGN KEY([matinh])
REFERENCES [dbo].[tinhs] ([matinh])
GO
ALTER TABLE [dbo].[khachsans] CHECK CONSTRAINT [FK_khachsans_tinhs]
GO
ALTER TABLE [dbo].[tours]  WITH CHECK ADD  CONSTRAINT [FK_tours_loaitour] FOREIGN KEY([loaitour])
REFERENCES [dbo].[loaitours] ([maloai])
GO
ALTER TABLE [dbo].[tours] CHECK CONSTRAINT [FK_tours_loaitour]
GO
ALTER TABLE [dbo].[tours]  WITH CHECK ADD  CONSTRAINT [FK_tours_tinh_1] FOREIGN KEY([diemden])
REFERENCES [dbo].[tinhs] ([matinh])
GO
ALTER TABLE [dbo].[tours] CHECK CONSTRAINT [FK_tours_tinh_1]
GO
ALTER TABLE [dbo].[tours]  WITH CHECK ADD  CONSTRAINT [FK_tours_tinh_2] FOREIGN KEY([diemdi])
REFERENCES [dbo].[tinhs] ([matinh])
GO
ALTER TABLE [dbo].[tours] CHECK CONSTRAINT [FK_tours_tinh_2]
GO
USE [master]
GO
ALTER DATABASE [tourdulich] SET  READ_WRITE 
GO
