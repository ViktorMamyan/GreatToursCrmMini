SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetTourCustomersByTourID
(	
	@TourID INT
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT TCD.TourDetailsID
		,TCD.TourID
		,TCD.CustomerDetailsID
		,T.TourName
		,CONCAT(C.FirstName,N' ',C.LastName) Customer
	FROM TourCustomerDetails TCD
	INNER JOIN Tour T ON T.TourID = TCD.TourID
	INNER JOIN CustomerDetails C ON C.CustomerDetailsID = TCD.CustomerDetailsID
)
GO