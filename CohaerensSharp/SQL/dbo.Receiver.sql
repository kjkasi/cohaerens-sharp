USE [CohaerensSharp]
GO

/****** Object:  Table [dbo].[Receiver]    Script Date: 19.01.2020 19:09:01 ******/
DROP TABLE [dbo].[Receiver]
GO

/****** Object:  Table [dbo].[Receiver]    Script Date: 19.01.2020 19:09:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Receiver](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Desciption] [nvarchar](50) NULL,
 CONSTRAINT [PK_Receiver] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


