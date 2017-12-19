USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetBankExpense
(	

)
RETURNS TABLE 
AS
RETURN 
(
	SELECT B.BankExpenseID
		,B.CreationDate
		,T.TypeName
		,B.Fee
		,B.ForYear
		,B.ForMonth
		,B.TypeID
	FROM BankExpense B
	INNER JOIN BankExpType T ON T.TypeID = B.TypeID
)
GO