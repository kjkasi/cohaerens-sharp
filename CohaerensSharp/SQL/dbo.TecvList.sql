USE [CohaerensSharp]
GO

ALTER TABLE [dbo].[TecvList] DROP CONSTRAINT [FK_TecvList_System]
GO

ALTER TABLE [dbo].[TecvList] DROP CONSTRAINT [FK_TecvList_Receiver]
GO

ALTER TABLE [dbo].[TecvList] DROP CONSTRAINT [FK_TecvList_Place]
GO

/****** Object:  Table [dbo].[TecvList]    Script Date: 29.01.2020 13:07:31 ******/
DROP TABLE [dbo].[TecvList]
GO

/****** Object:  Table [dbo].[TecvList]    Script Date: 29.01.2020 13:07:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TecvList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlaceId] [int] NULL,
	[SystemId] [int] NULL,
	[ReceiverId] [int] NULL,
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

ALTER TABLE [dbo].[TecvList]  WITH CHECK ADD  CONSTRAINT [FK_TecvList_Place] FOREIGN KEY([PlaceId])
REFERENCES [dbo].[Place] ([Id])
GO

ALTER TABLE [dbo].[TecvList] CHECK CONSTRAINT [FK_TecvList_Place]
GO

ALTER TABLE [dbo].[TecvList]  WITH CHECK ADD  CONSTRAINT [FK_TecvList_Receiver] FOREIGN KEY([ReceiverId])
REFERENCES [dbo].[Receiver] ([Id])
GO

ALTER TABLE [dbo].[TecvList] CHECK CONSTRAINT [FK_TecvList_Receiver]
GO

ALTER TABLE [dbo].[TecvList]  WITH CHECK ADD  CONSTRAINT [FK_TecvList_System] FOREIGN KEY([SystemId])
REFERENCES [dbo].[System] ([Id])
GO

ALTER TABLE [dbo].[TecvList] CHECK CONSTRAINT [FK_TecvList_System]
GO


