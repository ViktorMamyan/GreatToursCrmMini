USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetAdvertise
(	

)
RETURNS TABLE 
AS
RETURN 
(
	SELECT A.AdvertiseID
		,A.CreationDate
		,T.TypeName
		,A.Fee
		,A.ForYear
		,A.ForMonth
		,A.TypeID
	FROM Advertise A
	INNER JOIN AdvertiseType T ON T.TypeID = A.TypeID
)
GO