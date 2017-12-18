USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetUtilityExpense
(	

)
RETURNS TABLE 
AS
RETURN 
(
	SELECT U.UtilExpID
		,U.CreationDate
		,T.Utility
		,U.Fee
		,U.ForYear
		,U.ForMonth
		,U.UtilityTypeID
	FROM UtilityExpense U
	INNER JOIN UtilityType T ON T.UtilityTypeID = U.UtilityTypeID
)
GO