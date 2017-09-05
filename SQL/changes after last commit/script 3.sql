USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION GetDirectionOperatorCombination
(	
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT DOC.ID
		,DOC.DirectionID
		,DOC.OperatorID
		,D.DirectionName
		,T.OperatorName
	FROM DirectionOperatorCombination DOC
	INNER JOIN Direction D ON D.DirectionID = DOC.DirectionID
	INNER JOIN TourOperator T ON T.TourOperatorID = DOC.OperatorID
)