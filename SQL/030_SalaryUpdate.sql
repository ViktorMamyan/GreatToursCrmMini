USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SalaryUpdate]
	@SalaryID INT, @Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @EmployeeID INT, @IsBonus BIT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Salary
		SET Fee = @Fee
		,ForYear = @ForYear
		,ForMonth = @ForMonth
		,EmployeeID = @EmployeeID
		,IsBonus = @IsBonus
	WHERE SalaryID = @SalaryID
END