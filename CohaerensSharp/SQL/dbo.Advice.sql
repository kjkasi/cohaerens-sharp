USE [CohaerensSharp]
GO

ALTER TABLE [dbo].[Advice] DROP CONSTRAINT [FK_Advice_Weather]
GO

ALTER TABLE [dbo].[Advice] DROP CONSTRAINT [FK_Advice_TecvList]
GO

ALTER TABLE [dbo].[Advice] DROP CONSTRAINT [FK_Advice_TecList]
GO

/****** Object:  Table [dbo].[Advice]    Script Date: 29.01.2020 13:04:23 ******/
DROP TABLE [dbo].[Advice]
GO

/****** Object:  Table [dbo].[Advice]    Script Date: 29.01.2020 13:04:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Advice](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TecId] [int] NULL,
	[TecvId] [int] NULL,
	[WeatherId] [int] NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Advice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Advice]  WITH CHECK ADD  CONSTRAINT [FK_Advice_TecList] FOREIGN KEY([TecId])
REFERENCES [dbo].[TecList] ([Id])
GO

ALTER TABLE [dbo].[Advice] CHECK CONSTRAINT [FK_Advice_TecList]
GO

ALTER TABLE [dbo].[Advice]  WITH CHECK ADD  CONSTRAINT [FK_Advice_TecvList] FOREIGN KEY([TecvId])
REFERENCES [dbo].[TecvList] ([Id])
GO

ALTER TABLE [dbo].[Advice] CHECK CONSTRAINT [FK_Advice_TecvList]
GO

ALTER TABLE [dbo].[Advice]  WITH CHECK ADD  CONSTRAINT [FK_Advice_Weather] FOREIGN KEY([WeatherId])
REFERENCES [dbo].[Weather] ([Id])
GO

ALTER TABLE [dbo].[Advice] CHECK CONSTRAINT [FK_Advice_Weather]
GO


