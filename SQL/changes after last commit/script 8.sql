USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION GetBonuseCard
(	
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT BC.CardID
		,BC.[Card]
		,C.CustomerName
		,BC.CustomerID
		,BC.CreateDate
		,BC.IsActive
	FROM BonuseCard BC
	INNER JOIN Customer C ON C.CustomerID = BC.CustomerID
)