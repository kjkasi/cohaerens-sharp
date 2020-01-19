USE [CohaerensSharp]
GO

/****** Object:  StoredProcedure [dbo].[Chart]    Script Date: 19.01.2020 19:09:53 ******/
DROP PROCEDURE [dbo].[Chart]
GO

/****** Object:  StoredProcedure [dbo].[Chart]    Script Date: 19.01.2020 19:09:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Minin Anton>
-- Create date: <19.01.2020>
-- Description:	<Get Graph by Id>
-- =============================================
CREATE PROCEDURE [dbo].[Chart]
	@Id int
AS
BEGIN
	SELECT		Id,
				tsn,
				hour,
				el,
				az,
				l1l2,
				p1p2,
				validity,
				COUNT(Id) OVER (ORDER BY Id) AS qty
	FROM		dbo.TecContent
	WHERE		Id = @Id
END
GO


