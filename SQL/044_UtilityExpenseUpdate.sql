USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[UtilityExpenseUpdate]
	@UtilExpID INT, @Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @UtilityTypeID INT, @Comment NVARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE UtilityExpense
		SET Fee = @Fee
		,ForYear = @ForYear
		,ForMonth = @ForMonth
		,UtilityTypeID = @UtilityTypeID
		,Comment = @Comment
	WHERE UtilExpID = @UtilExpID
END