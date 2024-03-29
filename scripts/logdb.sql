USE [master]
GO
/****** Object:  Database [managermentUser]    Script Date: 28/08/2020 6:09:00 PM ******/
CREATE DATABASE [managermentUser]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'managermentUser', FILENAME = N'C:\Users\hoang\managermentUser.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'managermentUser_log', FILENAME = N'C:\Users\hoang\managermentUser_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [managermentUser] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [managermentUser].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [managermentUser] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [managermentUser] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [managermentUser] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [managermentUser] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [managermentUser] SET ARITHABORT OFF 
GO
ALTER DATABASE [managermentUser] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [managermentUser] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [managermentUser] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [managermentUser] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [managermentUser] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [managermentUser] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [managermentUser] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [managermentUser] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [managermentUser] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [managermentUser] SET  ENABLE_BROKER 
GO
ALTER DATABASE [managermentUser] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [managermentUser] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [managermentUser] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [managermentUser] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [managermentUser] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [managermentUser] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [managermentUser] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [managermentUser] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [managermentUser] SET  MULTI_USER 
GO
ALTER DATABASE [managermentUser] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [managermentUser] SET DB_CHAINING OFF 
GO
ALTER DATABASE [managermentUser] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [managermentUser] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [managermentUser] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [managermentUser] SET QUERY_STORE = OFF
GO
USE [managermentUser]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [managermentUser]
GO
/****** Object:  Table [dbo].[savelog]    Script Date: 28/08/2020 6:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[savelog](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](200) NULL,
	[checktime_id] [int] NULL,
	[last_info] [datetime] NULL,
	[edited_info] [datetime] NULL,
	[edit_time] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 28/08/2020 6:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](200) NULL,
	[password] [varchar](50) NULL,
	[email] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[savelog] ON 

INSERT [dbo].[savelog] ([id], [username], [checktime_id], [last_info], [edited_info], [edit_time]) VALUES (1, N'hau', 2, CAST(N'2019-12-12T15:30:00.000' AS DateTime), CAST(N'2019-12-12T16:30:00.000' AS DateTime), CAST(N'2019-12-12T17:30:00.000' AS DateTime))
INSERT [dbo].[savelog] ([id], [username], [checktime_id], [last_info], [edited_info], [edit_time]) VALUES (2, N'hau', 2, CAST(N'2019-12-12T15:30:00.000' AS DateTime), CAST(N'2020-12-12T15:30:00.000' AS DateTime), CAST(N'2019-12-12T17:30:00.000' AS DateTime))
INSERT [dbo].[savelog] ([id], [username], [checktime_id], [last_info], [edited_info], [edit_time]) VALUES (3, N'Vien', 2, NULL, NULL, NULL)
INSERT [dbo].[savelog] ([id], [username], [checktime_id], [last_info], [edited_info], [edit_time]) VALUES (4, N'hau', 3, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[savelog] OFF
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [username], [password], [email]) VALUES (1, N'hau', N'123', N'hoang@gmail.com')
INSERT [dbo].[users] ([id], [username], [password], [email]) VALUES (2, N'vien', N'123', N'vien@gmail.com')
INSERT [dbo].[users] ([id], [username], [password], [email]) VALUES (3, N'admin', N'123', N'admin@gmail.com')
SET IDENTITY_INSERT [dbo].[users] OFF
USE [master]
GO
ALTER DATABASE [managermentUser] SET  READ_WRITE 
GO
