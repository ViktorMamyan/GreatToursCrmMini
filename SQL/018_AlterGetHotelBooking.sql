USE [GT]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER FUNCTION [dbo].[GetHotelBooking]
(	

)
RETURNS TABLE 
AS
RETURN 
(
	SELECT H.HotelBookID
		,H.CreationDate
		,H.HotelName
		,H.StartDate
		,H.EndDate
		,H.Price
		,H.Cost
		,C.CustomerName
		,H.AdultCount
		,H.ChildCount
		,H.BabyCount
		,H.ChildYearsComment
		,F.FoodName
		,H.[Transfer]
		,H.PrePayPrice
		,H.NextPayDate
		,O.OperatorName
		,H.PaymaetDeathLine
		,H.IsTotalyPayed
		,H.CustomerID
		,H.FoodTypeID
		,H.OperatorID
	FROM HotelBooking H
	INNER JOIN Customer C ON C.CustomerID = H.CustomerID
	LEFT JOIN FoodType F ON F.FoodTypeID = H.FoodTypeID
	LEFT JOIN TourOperator O ON O.TourOperatorID = H.OperatorID
)