USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION GetTour
(	
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT T.TourID
		,T.TourName
		,T.TourStartDate
		,T.TourEndDate
		,D.DirectionName
		,C.CustomerName
		,O.OperatorName
		,T.DirectionID
		,T.OperatorID
		,T.CustomerID
		,T.TotalPrice
		,T.ApproximateIncome
	FROM Tour T
	INNER JOIN Direction D ON D.DirectionID = T.DirectionID
	INNER JOIN TourOperator O ON O.TourOperatorID = T.OperatorID
	INNER JOIN Customer C ON C.CustomerID = T.CustomerID
)