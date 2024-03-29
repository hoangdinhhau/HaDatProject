
USE [master]
go
drop database zkdb

GO
/****** Object:  Database [zkdb]    Script Date: 27/08/2020 5:01:22 PM ******/
CREATE DATABASE [zkdb]
GO
use zkdb;
go
CREATE TABLE [dbo].[checkinout](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userid] [nvarchar](20) NULL,
	[pin] [nvarchar](20) NULL,
	[checktime] [datetime] NULL,
	[checktype] [nvarchar](5) NULL,
	[verifycode] [int] NULL,
	[sn] [nvarchar](20) NULL,
	[sensorid] [nvarchar](5) NULL,
	[workcode] [nvarchar](20) NULL,
	[reserved] [nvarchar](20) NULL,
	[sn_name] [nvarchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[checkinout] ON 

INSERT [dbo].[checkinout] ([id], [userid], [pin], [checktime], [checktype], [verifycode], [sn], [sensorid], [workcode], [reserved], [sn_name]) VALUES (1, NULL, N'09999999', CAST(N'2019-12-12T00:00:00.000' AS DateTime), N'0212', 212, N'212', N'212', N'12', N'212', N'212')
INSERT [dbo].[checkinout] ([id], [userid], [pin], [checktime], [checktype], [verifycode], [sn], [sensorid], [workcode], [reserved], [sn_name]) VALUES (2, NULL, N'09999999', CAST(N'2019-12-08T00:00:00.000' AS DateTime), N'1', 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[checkinout] ([id], [userid], [pin], [checktime], [checktype], [verifycode], [sn], [sensorid], [workcode], [reserved], [sn_name]) VALUES (3, NULL, N'09999999', CAST(N'2019-12-07T00:00:00.000' AS DateTime), N'1', 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[checkinout] ([id], [userid], [pin], [checktime], [checktype], [verifycode], [sn], [sensorid], [workcode], [reserved], [sn_name]) VALUES (4, NULL, N'09999999', CAST(N'2019-12-06T00:00:00.000' AS DateTime), N'1', 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[checkinout] ([id], [userid], [pin], [checktime], [checktype], [verifycode], [sn], [sensorid], [workcode], [reserved], [sn_name]) VALUES (5, NULL, N'09999999', CAST(N'2019-12-05T00:00:00.000' AS DateTime), N'1', 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[checkinout] ([id], [userid], [pin], [checktime], [checktype], [verifycode], [sn], [sensorid], [workcode], [reserved], [sn_name]) VALUES (6, NULL, N'09999999', CAST(N'2019-12-04T00:00:00.000' AS DateTime), N'1', 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[checkinout] ([id], [userid], [pin], [checktime], [checktype], [verifycode], [sn], [sensorid], [workcode], [reserved], [sn_name]) VALUES (7, NULL, N'09999999', CAST(N'2019-12-03T00:00:00.000' AS DateTime), N'1', 11, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[checkinout] ([id], [userid], [pin], [checktime], [checktype], [verifycode], [sn], [sensorid], [workcode], [reserved], [sn_name]) VALUES (8, NULL, N'09999999', CAST(N'2019-12-03T00:00:00.000' AS DateTime), N'1', 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[checkinout] ([id], [userid], [pin], [checktime], [checktype], [verifycode], [sn], [sensorid], [workcode], [reserved], [sn_name]) VALUES (9, NULL, N'08888888', CAST(N'2019-12-03T00:00:00.000' AS DateTime), N'1', 1, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[checkinout] OFF
USE [master]
GO
ALTER DATABASE [zkdb] SET  READ_WRITE 
GO
