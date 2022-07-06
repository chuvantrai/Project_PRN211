USE [Bds_CShap]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/7/2022 12:16:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 7/7/2022 12:16:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[NewsId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[DateUp] [date] NOT NULL,
	[ImgAvar] [image] NOT NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[NewsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 7/7/2022 12:16:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](250) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[RegionalId] [int] NOT NULL,
	[LetterPrice] [nvarchar](50) NOT NULL,
	[NoPrice] [bigint] NOT NULL,
	[DateUp] [date] NOT NULL,
	[ImgAvar] [image] NOT NULL,
	[LinkGGMap] [nvarchar](max) NULL,
	[AreaM2] [float] NULL,
	[HorizontalM] [float] NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Regional]    Script Date: 7/7/2022 12:16:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Regional](
	[RegionalId] [int] IDENTITY(1,1) NOT NULL,
	[RegionalName] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Regional] PRIMARY KEY CLUSTERED 
(
	[RegionalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 7/7/2022 12:16:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 7/7/2022 12:16:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](250) NOT NULL,
	[Email] [nvarchar](250) NOT NULL,
	[Password] [nvarchar](250) NOT NULL,
	[Phone] [nvarchar](250) NOT NULL,
	[Dob] [date] NOT NULL,
	[Gender] [bit] NOT NULL,
	[RoleId] [int] NOT NULL,
	[ImgAvar] [image] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRequest]    Script Date: 7/7/2022 12:16:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRequest](
	[RequestId] [int] IDENTITY(1,1) NOT NULL,
	[UseId] [int] NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[DateRequest] [date] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_UserRequest] PRIMARY KEY CLUSTERED 
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (1, N'Căn hộ')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (2, N'Đất nền')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (3, N'Nhà Phố')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (4, N'Biệt Thự')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Regional] ON 

INSERT [dbo].[Regional] ([RegionalId], [RegionalName]) VALUES (1, N'Cam lâm')
INSERT [dbo].[Regional] ([RegionalId], [RegionalName]) VALUES (2, N'Diêm Khánh')
INSERT [dbo].[Regional] ([RegionalId], [RegionalName]) VALUES (3, N'Khánh Vĩnh')
INSERT [dbo].[Regional] ([RegionalId], [RegionalName]) VALUES (4, N'Nha Trang')
INSERT [dbo].[Regional] ([RegionalId], [RegionalName]) VALUES (5, N'Cam Rang')
INSERT [dbo].[Regional] ([RegionalId], [RegionalName]) VALUES (6, N'Ninh Hòa')
INSERT [dbo].[Regional] ([RegionalId], [RegionalName]) VALUES (7, N'Vạn Ninh')
INSERT [dbo].[Regional] ([RegionalId], [RegionalName]) VALUES (8, N'Khu Vực Khác')
SET IDENTITY_INSERT [dbo].[Regional] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (1, N'admin')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (2, N'customer')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [FullName], [Email], [Password], [Phone], [Dob], [Gender], [RoleId], [ImgAvar]) VALUES (1, N'Admin Trai', N'123@gmail.com', N'123', N'0362351671', CAST(N'2001-04-15' AS Date), 1, 1, NULL)
INSERT [dbo].[User] ([UserId], [FullName], [Email], [Password], [Phone], [Dob], [Gender], [RoleId], [ImgAvar]) VALUES (2, N'Chu Văn Trai', N'111@gmail.com', N'123', N'12345678', CAST(N'2002-09-15' AS Date), 0, 2, NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Regional] FOREIGN KEY([RegionalId])
REFERENCES [dbo].[Regional] ([RegionalId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Regional]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
ALTER TABLE [dbo].[UserRequest]  WITH CHECK ADD  CONSTRAINT [FK_UserRequest_User] FOREIGN KEY([UseId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[UserRequest] CHECK CONSTRAINT [FK_UserRequest_User]
GO
