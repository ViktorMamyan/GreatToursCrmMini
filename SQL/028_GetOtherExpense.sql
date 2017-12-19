SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetOtherExpense
(	

)
RETURNS TABLE 
AS
RETURN 
(
	SELECT O.OtherExpenseID
		,O.CreationDate
		,T.TypeName
		,O.Fee
		,O.ForYear
		,O.ForMonth
		,O.TypeID
	FROM OtherExpense O
	INNER JOIN OtherExpenseType T ON T.TypeID = O.TypeID
)
GO