USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetAirport
(	

)
RETURNS TABLE 
AS
RETURN 
(
	SELECT A.AirportID, CONCAT(A.Code,N'-',A.City,N'-',A.AirportName,N'-',C.Country) Airport
	,A.Code,A.AirportName,A.City,C.Country
	FROM Airport A
	INNER JOIN Country C ON C.CountryID = A.CountryID
)
GO