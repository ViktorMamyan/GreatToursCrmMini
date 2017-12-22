USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetHotels
(	

)
RETURNS TABLE 
AS
RETURN 
(
	SELECT H.HotelID
		,H.HotelName
		,C.Country
		,H.Region
		,H.Stars
		,T.[Type]
		,H.CountryID
		,H.HotelTypeID
	FROM Hotels H
	INNER JOIN Country C ON C.CountryID = H.CountryID
	INNER JOIN HotelType T ON T.TypeID = H.HotelTypeID
)
GO