USE [CohaerensSharp]
GO

/****** Object:  Table [dbo].[TecvList]    Script Date: 19.01.2020 21:14:50 ******/
DROP TABLE [dbo].[TecvList]
GO

/****** Object:  Table [dbo].[TecvList]    Script Date: 19.01.2020 21:14:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TecvList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Height] [int] NULL,
	[Low] [int] NULL,
	[High] [int] NULL,
 CONSTRAINT [PK_TecvList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


