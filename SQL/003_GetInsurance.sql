USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetInsurance
(	

)
RETURNS TABLE 
AS
RETURN 
(
	SELECT I.InsuranceID
		,I.CreationDate
		,C.ClientFullName
		,C.ClientContacts
		,I.StartDate
		,I.EndDate
		,I.ClientID
		,I.Price
		,I.Cost
		,I.ReturnableDate
	FROM Insurance I
	INNER JOIN Client C ON C.ClientID = I.ClientID
)
GO