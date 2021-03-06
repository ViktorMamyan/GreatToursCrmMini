USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[GetTour]
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
		,T.Price
		,T.Cost
		,C.CustomerName
		,T.AdultCount
		,T.ChildCount
		,T.BabyCount
		,T.ChildYearsComment
		,D.DirectionName
		,O.OperatorName
		,T.PaymaetDeathLine
		,T.PrePayPrice
		,T.NextPayDate
		,T.IsTotalyPayed
		,T.HotelList
		,T.TicketList
		,T.InsuranceList
		,T.Excursion
		,T.VIsa
		,T.[Transfer]
		,T.TourType
		,T.DirectionID
		,T.OperatorID
		,T.CustomerID
	FROM Tour T
	INNER JOIN Direction D ON D.DirectionID = T.DirectionID
	INNER JOIN TourOperator O ON O.TourOperatorID = T.OperatorID
	INNER JOIN Customer C ON C.CustomerID = T.CustomerID
)