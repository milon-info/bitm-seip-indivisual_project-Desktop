USE [master]
GO
/****** Object:  Database [FairManagementDB]    Script Date: 8/6/2015 1:13:56 PM ******/
CREATE DATABASE [FairManagementDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FairManagementDB', FILENAME = N'E:\BASIS _SEIP - Practice (.NET)\BASIS-SEIP Project\Indivisual Project\FairManagementApp\DB\FairManagementDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FairManagementDB_log', FILENAME = N'E:\BASIS _SEIP - Practice (.NET)\BASIS-SEIP Project\Indivisual Project\FairManagementApp\DB\FairManagementDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FairManagementDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FairManagementDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FairManagementDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FairManagementDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FairManagementDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FairManagementDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FairManagementDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FairManagementDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FairManagementDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [FairManagementDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FairManagementDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FairManagementDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FairManagementDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FairManagementDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FairManagementDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FairManagementDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FairManagementDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FairManagementDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FairManagementDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FairManagementDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FairManagementDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FairManagementDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FairManagementDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FairManagementDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FairManagementDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FairManagementDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FairManagementDB] SET  MULTI_USER 
GO
ALTER DATABASE [FairManagementDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FairManagementDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FairManagementDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FairManagementDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [FairManagementDB]
GO
/****** Object:  Table [dbo].[tbl_visitor]    Script Date: 8/6/2015 1:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_visitor](
	[visitor_id] [int] IDENTITY(1,1) NOT NULL,
	[visitor_name] [varchar](100) NULL,
	[visitor_email] [varchar](50) NULL,
	[visitor_contactNo] [varchar](50) NULL,
	[visitor_zoneId] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_visitor] PRIMARY KEY CLUSTERED 
(
	[visitor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_zone]    Script Date: 8/6/2015 1:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_zone](
	[zone_id] [int] IDENTITY(1,1) NOT NULL,
	[zone_code] [varchar](50) NULL,
	[zone_name] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_zone] PRIMARY KEY CLUSTERED 
(
	[zone_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_visitor] ON 

INSERT [dbo].[tbl_visitor] ([visitor_id], [visitor_name], [visitor_email], [visitor_contactNo], [visitor_zoneId]) VALUES (3, N'Milon', N'milon9152@gmail.com', N'01812362303', N'1,3,5,')
INSERT [dbo].[tbl_visitor] ([visitor_id], [visitor_name], [visitor_email], [visitor_contactNo], [visitor_zoneId]) VALUES (4, N'Faruk', N'faruk@gmail.com', N'01812362303', N'1,2,4,')
INSERT [dbo].[tbl_visitor] ([visitor_id], [visitor_name], [visitor_email], [visitor_contactNo], [visitor_zoneId]) VALUES (5, N'Monir', N'monir@gmail.com', N'01676457450', N'1,2,3,')
INSERT [dbo].[tbl_visitor] ([visitor_id], [visitor_name], [visitor_email], [visitor_contactNo], [visitor_zoneId]) VALUES (6, N'Hanif', N'hanif@gmail.com', N'01812362303', N'1,5,')
INSERT [dbo].[tbl_visitor] ([visitor_id], [visitor_name], [visitor_email], [visitor_contactNo], [visitor_zoneId]) VALUES (7, N'Sumon', N'sumon@gmail.com', N'01676457450', N'1,2,3,4,5,11,')
INSERT [dbo].[tbl_visitor] ([visitor_id], [visitor_name], [visitor_email], [visitor_contactNo], [visitor_zoneId]) VALUES (8, N'Saurav', N'saurav@gmail.com', N'01812362303', N'2,3,4,5,')
INSERT [dbo].[tbl_visitor] ([visitor_id], [visitor_name], [visitor_email], [visitor_contactNo], [visitor_zoneId]) VALUES (9, N'Faruk', N'faruk123@gmail.com', N'01676457450', N'1,2,3,11,')
SET IDENTITY_INSERT [dbo].[tbl_visitor] OFF
SET IDENTITY_INSERT [dbo].[tbl_zone] ON 

INSERT [dbo].[tbl_zone] ([zone_id], [zone_code], [zone_name]) VALUES (1, N'1001', N'Enterprise Application Zone')
INSERT [dbo].[tbl_zone] ([zone_id], [zone_code], [zone_name]) VALUES (2, N'1002', N'Mobile Application Zone')
INSERT [dbo].[tbl_zone] ([zone_id], [zone_code], [zone_name]) VALUES (3, N'1003', N'Game & Multimedia Zone')
INSERT [dbo].[tbl_zone] ([zone_id], [zone_code], [zone_name]) VALUES (4, N'1004', N'Telecom Software Zone')
INSERT [dbo].[tbl_zone] ([zone_id], [zone_code], [zone_name]) VALUES (5, N'1005', N'Digital Bangladesh Zone')
INSERT [dbo].[tbl_zone] ([zone_id], [zone_code], [zone_name]) VALUES (11, N'1006', N'Basis Zone')
INSERT [dbo].[tbl_zone] ([zone_id], [zone_code], [zone_name]) VALUES (12, N'1007', N'Bitm Zone')
SET IDENTITY_INSERT [dbo].[tbl_zone] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tbl_visitor]    Script Date: 8/6/2015 1:13:56 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tbl_visitor] ON [dbo].[tbl_visitor]
(
	[visitor_email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tbl_zone]    Script Date: 8/6/2015 1:13:56 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tbl_zone] ON [dbo].[tbl_zone]
(
	[zone_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tbl_zone_1]    Script Date: 8/6/2015 1:13:56 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tbl_zone_1] ON [dbo].[tbl_zone]
(
	[zone_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [FairManagementDB] SET  READ_WRITE 
GO
