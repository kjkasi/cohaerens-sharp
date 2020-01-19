USE [CohaerensSharp]
GO

/****** Object:  StoredProcedure [dbo].[Chartv]    Script Date: 19.01.2020 21:14:05 ******/
DROP PROCEDURE [dbo].[Chartv]
GO

/****** Object:  StoredProcedure [dbo].[Chartv]    Script Date: 19.01.2020 21:14:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Minin Anton>
-- Create date: <19.01.2020>
-- Description:	<Get Graph by Id>
-- =============================================
CREATE PROCEDURE [dbo].[Chartv]
	@Id int
AS
BEGIN
	SELECT		*,
				COUNT(Id) OVER (ORDER BY Id) AS qty
	FROM		dbo.TecvContent
	WHERE		Id = @Id
END
GO


