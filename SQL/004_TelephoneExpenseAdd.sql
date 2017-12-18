USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].TelephoneExpenseAdd
	@Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @PhoneNumber VARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO TelephoneExpense(CreationDate,Fee,ForYear,ForMonth,PhoneNumber) VALUES(CURRENT_TIMESTAMP,@Fee,@ForYear,@ForMonth,@PhoneNumber)
END