USE [HardwareSystemDB]
GO
/****** Object:  Table [dbo].[billingTb]    Script Date: 5/14/2024 2:55:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[billingTb](
	[BillingId] [int] IDENTITY(1,1) NOT NULL,
	[BillBy] [nvarchar](100) NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[BillingDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[BillingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categoryTb]    Script Date: 5/14/2024 2:55:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoryTb](
	[CategoryCode] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customerTb]    Script Date: 5/14/2024 2:55:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customerTb](
	[CustomerCode] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Gender] [varchar](10) NULL,
	[Phone] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productTb]    Script Date: 5/14/2024 2:55:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productTb](
	[ProductCode] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[CategoryName] [nvarchar](50) NULL,
	[Price] [decimal](10, 2) NULL,
	[Quantity] [int] NULL,
	[Company] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[userTb]    Script Date: 5/14/2024 2:55:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[userTb](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Role] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[billingTb] ON 
GO
INSERT [dbo].[billingTb] ([BillingId], [BillBy], [Amount], [BillingDate]) VALUES (1, N'John Doe', CAST(50.00 AS Decimal(10, 2)), CAST(N'2024-05-14T10:30:00.000' AS DateTime))
GO
INSERT [dbo].[billingTb] ([BillingId], [BillBy], [Amount], [BillingDate]) VALUES (2, N'User', CAST(9.99 AS Decimal(10, 2)), CAST(N'2024-05-14T00:12:22.570' AS DateTime))
GO
INSERT [dbo].[billingTb] ([BillingId], [BillBy], [Amount], [BillingDate]) VALUES (3, N'User', CAST(10.00 AS Decimal(10, 2)), CAST(N'2024-05-14T00:12:22.570' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[billingTb] OFF
GO
SET IDENTITY_INSERT [dbo].[categoryTb] ON 
GO
INSERT [dbo].[categoryTb] ([CategoryCode], [CategoryName]) VALUES (1, N'Power Tools')
GO
INSERT [dbo].[categoryTb] ([CategoryCode], [CategoryName]) VALUES (2, N'Hardware Accessories')
GO
INSERT [dbo].[categoryTb] ([CategoryCode], [CategoryName]) VALUES (3, N'Electrical Supplies')
GO
SET IDENTITY_INSERT [dbo].[categoryTb] OFF
GO
SET IDENTITY_INSERT [dbo].[productTb] ON 
GO
INSERT [dbo].[productTb] ([ProductCode], [Name], [CategoryName], [Price], [Quantity], [Company]) VALUES (11, N'Laptop', N'Electronics', CAST(999.99 AS Decimal(10, 2)), 18, N'ABC Electronics')
GO
INSERT [dbo].[productTb] ([ProductCode], [Name], [CategoryName], [Price], [Quantity], [Company]) VALUES (12, N'Chair', N'Furniture', CAST(49.99 AS Decimal(10, 2)), 100, N'Comfort Furniture')
GO
INSERT [dbo].[productTb] ([ProductCode], [Name], [CategoryName], [Price], [Quantity], [Company]) VALUES (13, N'Hammer', N'Tools', CAST(9.99 AS Decimal(10, 2)), 169, N'Tool Masters')
GO
INSERT [dbo].[productTb] ([ProductCode], [Name], [CategoryName], [Price], [Quantity], [Company]) VALUES (14, N'Smartphone', N'Electronics', CAST(599.99 AS Decimal(10, 2)), 23, N'XYZ Mobiles')
GO
INSERT [dbo].[productTb] ([ProductCode], [Name], [CategoryName], [Price], [Quantity], [Company]) VALUES (18, N'Charger', N'Electronics', CAST(10.00 AS Decimal(10, 2)), 10, N'Samsung')
GO
SET IDENTITY_INSERT [dbo].[productTb] OFF
GO
SET IDENTITY_INSERT [dbo].[userTb] ON 
GO
INSERT [dbo].[userTb] ([Id], [Username], [Password], [Role]) VALUES (2, N'User', N'User123', N'User')
GO
INSERT [dbo].[userTb] ([Id], [Username], [Password], [Role]) VALUES (5, N'Dipu', N'3333', N'Admin')
GO
INSERT [dbo].[userTb] ([Id], [Username], [Password], [Role]) VALUES (8, N'Admin', N'admin123', N'Admin')
GO
SET IDENTITY_INSERT [dbo].[userTb] OFF
GO
ALTER TABLE [dbo].[billingTb] ADD  DEFAULT (getdate()) FOR [BillingDate]
GO
