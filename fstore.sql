USE [FStore]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 30/6/2022 4:12:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NULL,
	[email] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
	[city] [nvarchar](255) NULL,
	[country] [nvarchar](255) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([id], [name], [email], [password], [city], [country]) VALUES (1, N'Hoang Hai', N'abc@gmail.com', N'1', N'HCM', N'Viet Nam')
INSERT [dbo].[Member] ([id], [name], [email], [password], [city], [country]) VALUES (6, N'Van Que', N'b@gmail.com', N'1', N'HN', N'Viet Nam')
INSERT [dbo].[Member] ([id], [name], [email], [password], [city], [country]) VALUES (7, N'Thang', N'a@gmail.com', N'1', N'Dak Lak', N'Viet Nam')
INSERT [dbo].[Member] ([id], [name], [email], [password], [city], [country]) VALUES (8, N'Tien', N'd@gmail.com', N'2', N'New York', N'US')
INSERT [dbo].[Member] ([id], [name], [email], [password], [city], [country]) VALUES (23, N'Amen', N'create@gmailc.om', N'1', N'New York', N'US')
INSERT [dbo].[Member] ([id], [name], [email], [password], [city], [country]) VALUES (12, N'Oda', N'a1@gmail.com', N'4', N'Bristol', N'UK')
INSERT [dbo].[Member] ([id], [name], [email], [password], [city], [country]) VALUES (13, N'Faker', N'a2@gmail.com', N'5', N'Nottingham', N'UK')
INSERT [dbo].[Member] ([id], [name], [email], [password], [city], [country]) VALUES (14, N'Messi', N'a3@gmail.com', N'6', N'Liverpool', N'UK')
INSERT [dbo].[Member] ([id], [name], [email], [password], [city], [country]) VALUES (15, N'Hola', N'a4@gmail.com', N'7', N'Chicago', N'US')
INSERT [dbo].[Member] ([id], [name], [email], [password], [city], [country]) VALUES (16, N'Nana', N'a8@gmail.com', N'8', N'Calgary', N'Canada')
INSERT [dbo].[Member] ([id], [name], [email], [password], [city], [country]) VALUES (17, N'Pasa', N'a15@gmail.com', N'9', N'Toronto', N'Canada')
INSERT [dbo].[Member] ([id], [name], [email], [password], [city], [country]) VALUES (18, N'Bill', N'a222@gmail.com', N'101', N'Paris', N'Franch')
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Member__AB6E6164A7434597]    Script Date: 30/6/2022 4:12:10 PM ******/
ALTER TABLE [dbo].[Member] ADD UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
