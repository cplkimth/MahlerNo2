USE [master]
GO
/****** Object:  Database [MahlerNo2]    Script Date: 2019-12-23 오전 1:23:59 ******/
CREATE DATABASE [MahlerNo2]
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MahlerNo2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MahlerNo2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MahlerNo2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MahlerNo2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MahlerNo2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MahlerNo2] SET ARITHABORT OFF 
GO
ALTER DATABASE [MahlerNo2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MahlerNo2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MahlerNo2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MahlerNo2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MahlerNo2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MahlerNo2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MahlerNo2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MahlerNo2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MahlerNo2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MahlerNo2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MahlerNo2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MahlerNo2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MahlerNo2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MahlerNo2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MahlerNo2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MahlerNo2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MahlerNo2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MahlerNo2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MahlerNo2] SET  MULTI_USER 
GO
ALTER DATABASE [MahlerNo2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MahlerNo2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MahlerNo2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MahlerNo2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MahlerNo2', N'ON'
GO
USE [MahlerNo2]
GO
/****** Object:  User [mahler]    Script Date: 2019-12-23 오전 1:23:59 ******/
CREATE USER [mahler] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [mahler]
GO
/****** Object:  Table [dbo].[Emoticon]    Script Date: 2019-12-23 오전 1:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emoticon](
	[EmoticonId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[At] [datetime] NOT NULL,
 CONSTRAINT [PK_Emoticon] PRIMARY KEY CLUSTERED 
(
	[EmoticonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Log]    Script Date: 2019-12-23 오전 1:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log](
	[LogId] [int] IDENTITY(1,1) NOT NULL,
	[At] [datetime] NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED 
(
	[LogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shot]    Script Date: 2019-12-23 오전 1:23:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shot](
	[At] [datetime] NOT NULL,
	[Data] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_Shot] PRIMARY KEY CLUSTERED 
(
	[At] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Emoticon] ON 
GO
INSERT [dbo].[Emoticon] ([EmoticonId], [Name], [At]) VALUES (1, N'쉬고싶어요', CAST(N'2019-10-02T17:35:06.567' AS DateTime))
GO
INSERT [dbo].[Emoticon] ([EmoticonId], [Name], [At]) VALUES (2, N'어려워요', CAST(N'2019-10-02T17:35:06.000' AS DateTime))
GO
INSERT [dbo].[Emoticon] ([EmoticonId], [Name], [At]) VALUES (3, N'재밌어요', CAST(N'2019-10-02T17:35:06.000' AS DateTime))
GO
INSERT [dbo].[Emoticon] ([EmoticonId], [Name], [At]) VALUES (4, N'쉬고싶어요', CAST(N'2019-10-02T17:35:06.000' AS DateTime))
GO
INSERT [dbo].[Emoticon] ([EmoticonId], [Name], [At]) VALUES (6, N'어려워요', CAST(N'2019-10-02T17:35:06.000' AS DateTime))
GO
INSERT [dbo].[Emoticon] ([EmoticonId], [Name], [At]) VALUES (7, N'어려워요', CAST(N'2019-10-02T17:35:06.000' AS DateTime))
GO
INSERT [dbo].[Emoticon] ([EmoticonId], [Name], [At]) VALUES (8, N'재밌어요', CAST(N'2019-10-02T17:35:06.000' AS DateTime))
GO
INSERT [dbo].[Emoticon] ([EmoticonId], [Name], [At]) VALUES (10, N'쉬고싶어요', CAST(N'2019-10-02T17:35:06.000' AS DateTime))
GO
INSERT [dbo].[Emoticon] ([EmoticonId], [Name], [At]) VALUES (11, N'쉬고싶어요', CAST(N'2019-10-06T15:06:06.000' AS DateTime))
GO
INSERT [dbo].[Emoticon] ([EmoticonId], [Name], [At]) VALUES (12, N'어려워요', CAST(N'2019-10-06T15:28:37.813' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Emoticon] OFF
GO
ALTER TABLE [dbo].[Emoticon] ADD  CONSTRAINT [DF_Emoticon_EmoticonCode]  DEFAULT (N'') FOR [Name]
GO
ALTER TABLE [dbo].[Emoticon] ADD  CONSTRAINT [DF_Emoticon_At]  DEFAULT (getdate()) FOR [At]
GO
USE [master]
GO
ALTER DATABASE [MahlerNo2] SET  READ_WRITE 
GO
