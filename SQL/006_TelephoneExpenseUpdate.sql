USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].TelephoneExpenseUpdate
	@TelExpID INT, @Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @PhoneNumber VARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE TelephoneExpense
		SET Fee = @Fee
		,ForYear = @ForYear
		,ForMonth = @ForMonth
		,PhoneNumber = @PhoneNumber
	WHERE TelExpID = @TelExpID
END