USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE BankExpenseDelete
	@BankExpenseID INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM BankExpense WHERE BankExpenseID = @BankExpenseID
END
GO