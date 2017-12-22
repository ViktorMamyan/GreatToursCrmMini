USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER FUNCTION [dbo].[GetBankExpense]
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
		,B.Comment
	FROM BankExpense B
	INNER JOIN BankExpType T ON T.TypeID = B.TypeID
)