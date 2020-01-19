USE [CohaerensSharp]
GO

/****** Object:  Table [dbo].[TecvContent]    Script Date: 19.01.2020 21:15:10 ******/
DROP TABLE [dbo].[TecvContent]
GO

/****** Object:  Table [dbo].[TecvContent]    Script Date: 19.01.2020 21:15:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TecvContent](
	[Id] [int] NOT NULL,
	[time_ut] [float] NULL,
	[tec_filt_aver] [float] NULL,
	[rms] [float] NULL,
	[Xaver] [float] NULL,
	[Yaver] [float] NULL,
	[Hmax] [float] NULL,
	[DHmax] [float] NULL,
	[I0] [float] NULL,
	[DI0] [float] NULL,
	[N_of_Sats] [int] NULL
) ON [PRIMARY]
GO


