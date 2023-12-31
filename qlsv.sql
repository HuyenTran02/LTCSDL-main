USE [master]
GO
/****** Object:  Database [qlsv1]    Script Date: 6/10/2023 9:51:47 PM ******/
CREATE DATABASE [qlsv1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'qlsv1', FILENAME = N'D:\LTCSDL\QLSV\qlsv1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'qlsv1_log', FILENAME = N'D:\LTCSDL\QLSV\qlsv1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [qlsv1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [qlsv1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [qlsv1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [qlsv1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [qlsv1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [qlsv1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [qlsv1] SET ARITHABORT OFF 
GO
ALTER DATABASE [qlsv1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [qlsv1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [qlsv1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [qlsv1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [qlsv1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [qlsv1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [qlsv1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [qlsv1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [qlsv1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [qlsv1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [qlsv1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [qlsv1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [qlsv1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [qlsv1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [qlsv1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [qlsv1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [qlsv1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [qlsv1] SET RECOVERY FULL 
GO
ALTER DATABASE [qlsv1] SET  MULTI_USER 
GO
ALTER DATABASE [qlsv1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [qlsv1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [qlsv1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [qlsv1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [qlsv1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [qlsv1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'qlsv1', N'ON'
GO
ALTER DATABASE [qlsv1] SET QUERY_STORE = OFF
GO
USE [qlsv1]
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 6/10/2023 9:51:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MSSV] [nchar](10) NOT NULL,
	[id_MH] [nchar](8) NOT NULL,
	[GK_Diem] [float] NOT NULL,
	[CK_Diem] [float] NOT NULL,
	[DiemHe_10] [float] NOT NULL,
	[DiemHe_4] [float] NOT NULL,
	[Loai] [nchar](2) NULL,
 CONSTRAINT [PK_Diem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GV]    Script Date: 6/10/2023 9:51:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GV](
	[id] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [nchar](10) NOT NULL,
	[CCCD] [nchar](12) NOT NULL,
	[GioiTinh] [nvarchar](3) NOT NULL,
	[HocVi] [nvarchar](30) NOT NULL,
	[ChucVu] [nvarchar](30) NOT NULL,
	[Que] [nvarchar](50) NOT NULL,
	[Email] [nchar](50) NOT NULL,
	[SDT] [nchar](10) NOT NULL,
 CONSTRAINT [PK_GV] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 6/10/2023 9:51:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[id] [nchar](4) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[Email] [nchar](50) NOT NULL,
	[SDT] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 6/10/2023 9:51:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nchar](8) NOT NULL,
	[KhoaHoc] [nchar](9) NOT NULL,
	[id_Khoa] [nchar](4) NOT NULL,
 CONSTRAINT [PK_Lop_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 6/10/2023 9:51:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[id] [nchar](8) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[SoTinChi] [float] NOT NULL,
	[NgayBatDau] [nchar](10) NOT NULL,
	[NgayKetThuc] [nchar](10) NOT NULL,
	[Buoi] [nvarchar](20) NOT NULL,
	[DiaDiem] [nvarchar](50) NOT NULL,
	[Phong] [nchar](3) NOT NULL,
	[id_GV] [nchar](10) NOT NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SV]    Script Date: 6/10/2023 9:51:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SV](
	[MSSV] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[CCCD] [nchar](12) NOT NULL,
	[NgaySinh] [nchar](10) NOT NULL,
	[GioiTinh] [nvarchar](3) NOT NULL,
	[Que] [nvarchar](50) NOT NULL,
	[SDT] [nchar](10) NOT NULL,
	[Email] [nchar](50) NOT NULL,
	[TrangThai] [nvarchar](30) NOT NULL,
	[id_Lop] [int] NOT NULL,
 CONSTRAINT [PK_SV1] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Diem] ON 

INSERT [dbo].[Diem] ([id], [MSSV], [id_MH], [GK_Diem], [CK_Diem], [DiemHe_10], [DiemHe_4], [Loai]) VALUES (6, N'2051050172', N'ITEC1505', 7, 8, 6, 2, N'C ')
INSERT [dbo].[Diem] ([id], [MSSV], [id_MH], [GK_Diem], [CK_Diem], [DiemHe_10], [DiemHe_4], [Loai]) VALUES (7, N'2051050172', N'MATH1314', 7, 8, 6, 2, N'C ')
SET IDENTITY_INSERT [dbo].[Diem] OFF
GO
INSERT [dbo].[GV] ([id], [HoTen], [NgaySinh], [CCCD], [GioiTinh], [HocVi], [ChucVu], [Que], [Email], [SDT]) VALUES (N'1980222231', N'Trần Ngọc Anh', N'02/01/1980', N'036180215156', N'Nữ', N'Tiến Sĩ', N'Giảng Viên Cơ Hữu', N'Phú Yên', N'tna2231@ou.edu.vn                                 ', N'0456848789')
INSERT [dbo].[GV] ([id], [HoTen], [NgaySinh], [CCCD], [GioiTinh], [HocVi], [ChucVu], [Que], [Email], [SDT]) VALUES (N'1985235812', N'Phạm Hoài Thu', N'15/05/1985', N'045185322598', N'Nữ', N'Tiến Sĩ', N'Giảng Viên Thỉnh Giảng', N'Bình Phước', N'pht5812@ou.edu.vn                                 ', N'0954876145')
INSERT [dbo].[GV] ([id], [HoTen], [NgaySinh], [CCCD], [GioiTinh], [HocVi], [ChucVu], [Que], [Email], [SDT]) VALUES (N'1985352231', N'Hà Anh Tuấn', N'13/06/1985', N'054085123456', N'Nam', N'Tiến Sĩ', N'Giảng Viên Cơ Hữu', N'Trà Vinh', N'hat2231@ou.edu.vn                                 ', N'0987456218')
INSERT [dbo].[GV] ([id], [HoTen], [NgaySinh], [CCCD], [GioiTinh], [HocVi], [ChucVu], [Que], [Email], [SDT]) VALUES (N'1985352246', N'Nguyễn Phương Ly', N'20/06/1985', N'048185345665', N'Nữ', N'Tiến Sĩ', N'Lãnh Đạo Khoa', N'Đồng Nai', N'npl2246@ou.edu.vn                                 ', N'0795864974')
INSERT [dbo].[GV] ([id], [HoTen], [NgaySinh], [CCCD], [GioiTinh], [HocVi], [ChucVu], [Que], [Email], [SDT]) VALUES (N'1989235810', N'Nguyễn Tuấn Đạt', N'15/02/1989', N'049189325678', N'Nam', N'Tiến Sĩ', N'Giảng Viên Thỉnh Giảng', N'Bà Rịa - Vũng Tàu', N'ntd6410@ou.edu.vn                                 ', N'0987467186')
INSERT [dbo].[GV] ([id], [HoTen], [NgaySinh], [CCCD], [GioiTinh], [HocVi], [ChucVu], [Que], [Email], [SDT]) VALUES (N'1990352201', N'Nguyễn Thị Kiều Oanh ', N'01/09/1990', N'047190123456', N'Nữ', N'Thạc Sĩ', N'Giảng Viên Cơ Hữu', N'Bình Dương', N'ntko2201@ou.edu.vn                                ', N'0352294170')
INSERT [dbo].[GV] ([id], [HoTen], [NgaySinh], [CCCD], [GioiTinh], [HocVi], [ChucVu], [Que], [Email], [SDT]) VALUES (N'1990550023', N'Nguyễn Anh Tuấn', N'30/03/1990', N'037190154797', N'Nam', N'Thạc Sĩ', N'Giảng Viên Cơ Hữu', N'Khánh Hòa', N'nat0023@ou.edu.vn                                 ', N'0398745867')
INSERT [dbo].[GV] ([id], [HoTen], [NgaySinh], [CCCD], [GioiTinh], [HocVi], [ChucVu], [Que], [Email], [SDT]) VALUES (N'1991685403', N'Trần Tuấn Đạt', N'11/11/1991', N'001191034569', N'Nam', N'Thạc Sĩ ', N'Chuyên Viên', N'Hà Nội', N'ttd5403@ou.edu.vn                                 ', N'0977856487')
INSERT [dbo].[GV] ([id], [HoTen], [NgaySinh], [CCCD], [GioiTinh], [HocVi], [ChucVu], [Que], [Email], [SDT]) VALUES (N'1993222249', N'Trần Đăng Khoa', N'01/01/1993', N'042193985645', N'Nam', N'Thạc Sĩ', N'Chuyên Viên', N'Đắk Lắk', N'tdk2249@ou.edu.vn                                 ', N'0359814789')
INSERT [dbo].[GV] ([id], [HoTen], [NgaySinh], [CCCD], [GioiTinh], [HocVi], [ChucVu], [Que], [Email], [SDT]) VALUES (N'1995550012', N'Đặng Thùy Linh', N'19/05/1995', N'051195232235', N'Nữ', N'Thạc Sĩ', N'Giảng Viên Cơ Hữu', N'Long An', N'dtl0012@ou.edu.vn                                 ', N'0345997588')
GO
INSERT [dbo].[Khoa] ([id], [Ten], [Email], [SDT]) VALUES (N'2222', N'Kế Toán Kiểm Toán', N'ktkt3518@ou.edu.vn                                ', N'0231469978')
INSERT [dbo].[Khoa] ([id], [Ten], [Email], [SDT]) VALUES (N'2358', N'Tài Chính Ngân Hàng', N'tcnh2358@ou.edu.vn                                ', N'0321456445')
INSERT [dbo].[Khoa] ([id], [Ten], [Email], [SDT]) VALUES (N'3522', N'Công Nghệ Thông Tin', N'cntt3522@ou.edu.vn                                ', N'0325698789')
INSERT [dbo].[Khoa] ([id], [Ten], [Email], [SDT]) VALUES (N'5500', N'Ngôn Ngữ', N'nn3500@ou.edu.vn                                  ', N'0985471673')
INSERT [dbo].[Khoa] ([id], [Ten], [Email], [SDT]) VALUES (N'6854', N'Xã Hội Nhân Văn', N'xhnv6854@ou.edu.vn                                ', N'0321565977')
GO
SET IDENTITY_INSERT [dbo].[Lop] ON 

INSERT [dbo].[Lop] ([id], [Ten], [KhoaHoc], [id_Khoa]) VALUES (1, N'DH23IT01', N'2023-2024', N'3522')
INSERT [dbo].[Lop] ([id], [Ten], [KhoaHoc], [id_Khoa]) VALUES (2, N'DH23KT01', N'2023-2024', N'2222')
INSERT [dbo].[Lop] ([id], [Ten], [KhoaHoc], [id_Khoa]) VALUES (3, N'DH23NN01', N'2023-2024', N'5500')
INSERT [dbo].[Lop] ([id], [Ten], [KhoaHoc], [id_Khoa]) VALUES (4, N'DH23NH01', N'2023-2024', N'2358')
INSERT [dbo].[Lop] ([id], [Ten], [KhoaHoc], [id_Khoa]) VALUES (5, N'DH23NV01', N'2023-2024', N'6854')
SET IDENTITY_INSERT [dbo].[Lop] OFF
GO
INSERT [dbo].[MonHoc] ([id], [Ten], [SoTinChi], [NgayBatDau], [NgayKetThuc], [Buoi], [DiaDiem], [Phong], [id_GV]) VALUES (N'GENG1339', N'Tiếng Anh Nâng Cao 1', 3, N'08/06/2023', N'06/07/2023', N'Sáng', N'175 Nguyễn Kiệm', N'207', N'1990550023')
INSERT [dbo].[MonHoc] ([id], [Ten], [SoTinChi], [NgayBatDau], [NgayKetThuc], [Buoi], [DiaDiem], [Phong], [id_GV]) VALUES (N'GENG1340', N'Tiếng Anh Nâng Cao 2', 3, N'07/06/2023', N'05/07/2023', N'Chiều', N'175 Nguyễn Kiệm', N'110', N'1995550012')
INSERT [dbo].[MonHoc] ([id], [Ten], [SoTinChi], [NgayBatDau], [NgayKetThuc], [Buoi], [DiaDiem], [Phong], [id_GV]) VALUES (N'ITEC1505', N'Cơ Sở Lập Trình', 4, N'09/06/2023', N'23/08/2023', N'Ngày', N'175 Nguyễn Kiệm', N'311', N'1985352231')
INSERT [dbo].[MonHoc] ([id], [Ten], [SoTinChi], [NgayBatDau], [NgayKetThuc], [Buoi], [DiaDiem], [Phong], [id_GV]) VALUES (N'ITEC4402', N'Quản Trị Hệ Cơ Sở Dữ Liệu ', 3, N'07/06/2023', N'16/08/2023', N'Ngày', N'175 Nguyễn Kiệm', N'311', N'1985352246')
INSERT [dbo].[MonHoc] ([id], [Ten], [SoTinChi], [NgayBatDau], [NgayKetThuc], [Buoi], [DiaDiem], [Phong], [id_GV]) VALUES (N'ITEC4409', N'Công Nghệ Phần Mềm', 3, N'05/06/2023', N'14/08/2023', N'Ngày', N'175 Nguyễn Kiệm', N'311', N'1990352201')
INSERT [dbo].[MonHoc] ([id], [Ten], [SoTinChi], [NgayBatDau], [NgayKetThuc], [Buoi], [DiaDiem], [Phong], [id_GV]) VALUES (N'MATH1313', N'Đại Số Tuyến Tính', 3, N'05/06/2023', N'10/07/2023', N'Chiều', N'175 Nguyễn Kiệm', N'204', N'1985235812')
INSERT [dbo].[MonHoc] ([id], [Ten], [SoTinChi], [NgayBatDau], [NgayKetThuc], [Buoi], [DiaDiem], [Phong], [id_GV]) VALUES (N'MATH1314', N'Giải Tích', 3, N'06/06/2023', N'11/07/2023', N'Sáng', N'175 Nguyễn Kiệm', N'405', N'1980222231')
INSERT [dbo].[MonHoc] ([id], [Ten], [SoTinChi], [NgayBatDau], [NgayKetThuc], [Buoi], [DiaDiem], [Phong], [id_GV]) VALUES (N'MISY2501', N'Cấu Trúc Dữ Liệu Và Giải Thuật', 4, N'10/06/2023', N'24/08/2023', N'Ngày', N'175 Nguyễn Kiệm', N'311', N'1990352201')
INSERT [dbo].[MonHoc] ([id], [Ten], [SoTinChi], [NgayBatDau], [NgayKetThuc], [Buoi], [DiaDiem], [Phong], [id_GV]) VALUES (N'P0L11304', N'Triết Học Mác-Lênin', 3, N'06/06/2023', N'11/07/2023', N'Sáng', N'175 Nguyễn Kiệm', N'202', N'1991685403')
GO
INSERT [dbo].[SV] ([MSSV], [HoTen], [CCCD], [NgaySinh], [GioiTinh], [Que], [SDT], [Email], [TrangThai], [id_Lop]) VALUES (N'2051050172', N'Tsần Thị Bích Huyền', N'012345678912', N'21/09/2005', N'Nữ', N'Đồng Nai', N'0386858149', N'2051050172huyen@ou.edu.vn                         ', N'Đang Học', 1)
INSERT [dbo].[SV] ([MSSV], [HoTen], [CCCD], [NgaySinh], [GioiTinh], [Que], [SDT], [Email], [TrangThai], [id_Lop]) VALUES (N'2051050320', N'Nguyễn Thị Hồng Nhi', N'045678912346', N'29/03/2002', N'Nữ', N'Đồng Nai', N'0356977458', N'2051050320Nhi@ou.edu.vn                           ', N'Đang Học', 1)
INSERT [dbo].[SV] ([MSSV], [HoTen], [CCCD], [NgaySinh], [GioiTinh], [Que], [SDT], [Email], [TrangThai], [id_Lop]) VALUES (N'2335221239', N'Hà Thúy Anh', N'037305154797', N'10/10/2005', N'Nữ', N'Khánh Hòa  ', N'0347895142', N'2335221239anh@ou.edu.vn                           ', N'Đang Học', 1)
INSERT [dbo].[SV] ([MSSV], [HoTen], [CCCD], [NgaySinh], [GioiTinh], [Que], [SDT], [Email], [TrangThai], [id_Lop]) VALUES (N'2355002326', N'Trần Hà Thu', N'063305154647', N'12/05/2005', N'Nữ', N'Cà Mau', N'0849874894', N'2355002326                                        ', N'Đang Học', 3)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_GV]    Script Date: 6/10/2023 9:51:49 PM ******/
ALTER TABLE [dbo].[GV] ADD  CONSTRAINT [IX_GV] UNIQUE NONCLUSTERED 
(
	[CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_GV_1]    Script Date: 6/10/2023 9:51:49 PM ******/
ALTER TABLE [dbo].[GV] ADD  CONSTRAINT [IX_GV_1] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_GV_2]    Script Date: 6/10/2023 9:51:49 PM ******/
ALTER TABLE [dbo].[GV] ADD  CONSTRAINT [IX_GV_2] UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Khoa]    Script Date: 6/10/2023 9:51:49 PM ******/
ALTER TABLE [dbo].[Khoa] ADD  CONSTRAINT [IX_Khoa] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Khoa_1]    Script Date: 6/10/2023 9:51:49 PM ******/
ALTER TABLE [dbo].[Khoa] ADD  CONSTRAINT [IX_Khoa_1] UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_SV1]    Script Date: 6/10/2023 9:51:49 PM ******/
ALTER TABLE [dbo].[SV] ADD  CONSTRAINT [IX_SV1] UNIQUE NONCLUSTERED 
(
	[CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_SV1_1]    Script Date: 6/10/2023 9:51:49 PM ******/
ALTER TABLE [dbo].[SV] ADD  CONSTRAINT [IX_SV1_1] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_SV1_2]    Script Date: 6/10/2023 9:51:49 PM ******/
ALTER TABLE [dbo].[SV] ADD  CONSTRAINT [IX_SV1_2] UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_MonHoc] FOREIGN KEY([id_MH])
REFERENCES [dbo].[MonHoc] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_MonHoc]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_SV] FOREIGN KEY([MSSV])
REFERENCES [dbo].[SV] ([MSSV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_SV]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Khoa] FOREIGN KEY([id_Khoa])
REFERENCES [dbo].[Khoa] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_Khoa]
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_MonHoc_GV] FOREIGN KEY([id_GV])
REFERENCES [dbo].[GV] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [FK_MonHoc_GV]
GO
ALTER TABLE [dbo].[SV]  WITH CHECK ADD  CONSTRAINT [FK_SV_Lop] FOREIGN KEY([id_Lop])
REFERENCES [dbo].[Lop] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SV] CHECK CONSTRAINT [FK_SV_Lop]
GO
USE [master]
GO
ALTER DATABASE [qlsv1] SET  READ_WRITE 
GO
