SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION GetBonusByTourID
(	
	@TourID INT
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT TOP (1)
  		 C.[Card]
		,B.Points
		,B.Direction
		,CAST(IIF(B.CustomerID = C.CustomerID ,0,1) AS BIT) IsDiffCustomer
	FROM Bonus B
	INNER JOIN BonuseCard C ON C.CardID = B.CardID
	WHERE B.TourID = @TourID
)
GO