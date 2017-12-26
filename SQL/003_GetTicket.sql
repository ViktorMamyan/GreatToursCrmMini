USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetTicket
(	

)
RETURNS TABLE 
AS
RETURN 
(
	SELECT T.TicketID
		,T.CreationDate
		,T.ReservNumber
		,(SELECT CONCAT(A.Code,N'-',A.City,N'-',A.AirportName,N'-',C.Country)
			FROM Airport A
			INNER JOIN Country C ON C.CountryID = A.CountryID
			WHERE A.AirportID = T.FromAirportID) FromAirport
		,(SELECT CONCAT(A.Code,N'-',A.City,N'-',A.AirportName,N'-',C.Country)
			FROM Airport A
			INNER JOIN Country C ON C.CountryID = A.CountryID
			WHERE A.AirportID = T.ToAirportID) ToAirport
		,T.FlyDayTime
		,T.WithReturn
		,T.ReturnFlyDayTime
		,T.Price
		,T.Cost
		,U.CustomerName
		,T.AdultCount
		,T.ChildCount
		,T.BabyCount
		,T.ChildYearsComment
		,O.OperatorName
		,T.PaymaetDeathLine
		,T.PrePayPrice
		,T.NextPayDate
		,T.IsTotalyPayed
		,T.FromAirportID
		,T.ToAirportID
		,T.CustomerID
		,T.OperatorID
	FROM Ticket T
	LEFT JOIN Customer U ON U.CustomerID = T.CustomerID
	LEFT JOIN TourOperator O ON O.TourOperatorID = T.OperatorID
)
GO