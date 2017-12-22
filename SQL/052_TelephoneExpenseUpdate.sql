USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[TelephoneExpenseUpdate]
	@TelExpID INT, @Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @PhoneNumber VARCHAR(50), @Comment NVARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE TelephoneExpense
		SET Fee = @Fee
		,ForYear = @ForYear
		,ForMonth = @ForMonth
		,PhoneNumber = @PhoneNumber
		,Comment = @Comment
	WHERE TelExpID = @TelExpID
END