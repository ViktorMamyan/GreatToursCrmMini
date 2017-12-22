USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[UtilityExpenseAdd]
	@Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @UtilityTypeID INT, @Comment NVARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO UtilityExpense(CreationDate,Fee,ForYear,ForMonth,UtilityTypeID,Comment) VALUES(CURRENT_TIMESTAMP,@Fee,@ForYear,@ForMonth,@UtilityTypeID,@Comment)
END