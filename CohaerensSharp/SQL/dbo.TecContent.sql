USE [CohaerensSharp]
GO

/****** Object:  Table [dbo].[TecContent]    Script Date: 29.01.2020 13:06:38 ******/
DROP TABLE [dbo].[TecContent]
GO

/****** Object:  Table [dbo].[TecContent]    Script Date: 29.01.2020 13:06:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TecContent](
	[Id] [int] NOT NULL,
	[tsn] [int] NULL,
	[hour] [float] NOT NULL,
	[el] [float] NULL,
	[az] [float] NULL,
	[l1l2] [float] NULL,
	[p1p2] [float] NULL,
	[validity] [int] NULL
) ON [PRIMARY]
GO


