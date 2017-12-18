USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UtilityExpenseAdd]
	@Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @UtilityTypeID INT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO UtilityExpense(CreationDate,Fee,ForYear,ForMonth,UtilityTypeID) VALUES(CURRENT_TIMESTAMP,@Fee,@ForYear,@ForMonth,@UtilityTypeID)
END