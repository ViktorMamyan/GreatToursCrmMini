SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetCustomerDetailsByTourID
(	
	@TourID INT
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT C.CustomerDetailsID
			,CONCAT(C.FirstName,N' ',C.LastName) Customer
	FROM Tour T
	INNER JOIN CustomerDetails C ON C.CustomerID = T.CustomerID
	WHERE T.TourID = @TourID
)
GO