USE [CohaerensSharp]
GO

/****** Object:  Table [dbo].[Weather]    Script Date: 29.01.2020 13:05:16 ******/
DROP TABLE [dbo].[Weather]
GO

/****** Object:  Table [dbo].[Weather]    Script Date: 29.01.2020 13:05:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Weather](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Temp] [float] NULL,
	[Pressure] [float] NULL,
	[RH] [float] NULL,
 CONSTRAINT [PK_Weather] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


