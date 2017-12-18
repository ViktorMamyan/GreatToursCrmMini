USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetOfficeExponse
(	

)
RETURNS TABLE 
AS
RETURN 
(
	SELECT O.OfficeExponseID
		,O.CreationDate
		,T.OfficeExpType
		,O.Fee
		,O.ForYear
		,O.ForMonth
		,O.OfficeExponseTypeID
	FROM OfficeExponse O
	INNER JOIN OfficeExponseType T ON T.OfficeExponseTypeID = O.OfficeExponseTypeID
)
GO