USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UtilityExpenseUpdate]
	@UtilExpID INT, @Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @UtilityTypeID INT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE UtilityExpense
		SET Fee = @Fee
		,ForYear = @ForYear
		,ForMonth = @ForMonth
		,UtilityTypeID = @UtilityTypeID
	WHERE UtilExpID = @UtilExpID
END