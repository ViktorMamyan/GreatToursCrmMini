USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SalaryUpdate]
	@SalaryID INT, @Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @EmployeeID INT, @IsBonus BIT, @Comment NVARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Salary
		SET Fee = @Fee
		,ForYear = @ForYear
		,ForMonth = @ForMonth
		,EmployeeID = @EmployeeID
		,IsBonus = @IsBonus
		,Comment = @Comment
	WHERE SalaryID = @SalaryID
END