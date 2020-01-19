USE [CohaerensSharp]
GO

ALTER TABLE [dbo].[TecList] DROP CONSTRAINT [FK_TecList_System]
GO

ALTER TABLE [dbo].[TecList] DROP CONSTRAINT [FK_TecList_Receiver]
GO

ALTER TABLE [dbo].[TecList] DROP CONSTRAINT [FK_TecList_Place]
GO

/****** Object:  Table [dbo].[TecList]    Script Date: 19.01.2020 19:07:26 ******/
DROP TABLE [dbo].[TecList]
GO

/****** Object:  Table [dbo].[TecList]    Script Date: 19.01.2020 19:07:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TecList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlaceId] [int] NULL,
	[SystemId] [int] NULL,
	[ReceiverId] [int] NULL,
	[Created] [nvarchar](50) NULL,
	[Sources] [nvarchar](50) NULL,
	[Satellite] [nvarchar](50) NULL,
	[Interval] [nvarchar](50) NULL,
	[Site] [nvarchar](50) NULL,
	[Position] [nvarchar](50) NULL,
 CONSTRAINT [PK_TecList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TecList]  WITH CHECK ADD  CONSTRAINT [FK_TecList_Place] FOREIGN KEY([PlaceId])
REFERENCES [dbo].[Place] ([Id])
GO

ALTER TABLE [dbo].[TecList] CHECK CONSTRAINT [FK_TecList_Place]
GO

ALTER TABLE [dbo].[TecList]  WITH CHECK ADD  CONSTRAINT [FK_TecList_Receiver] FOREIGN KEY([ReceiverId])
REFERENCES [dbo].[Receiver] ([Id])
GO

ALTER TABLE [dbo].[TecList] CHECK CONSTRAINT [FK_TecList_Receiver]
GO

ALTER TABLE [dbo].[TecList]  WITH CHECK ADD  CONSTRAINT [FK_TecList_System] FOREIGN KEY([SystemId])
REFERENCES [dbo].[System] ([Id])
GO

ALTER TABLE [dbo].[TecList] CHECK CONSTRAINT [FK_TecList_System]
GO


