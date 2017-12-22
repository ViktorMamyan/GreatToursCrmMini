USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[TelephoneExpenseAdd]
	@Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @PhoneNumber VARCHAR(50), @Comment NVARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO TelephoneExpense(CreationDate,Fee,ForYear,ForMonth,PhoneNumber,Comment) VALUES(CURRENT_TIMESTAMP,@Fee,@ForYear,@ForMonth,@PhoneNumber,@Comment)
END