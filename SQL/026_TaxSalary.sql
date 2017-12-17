USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SalaryAdd]
	@Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @EmployeeID INT, @IsBonus BIT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Salary(CreationDate,Fee,ForYear,ForMonth,EmployeeID,IsBonus) VALUES(CURRENT_TIMESTAMP,@Fee,@ForYear,@ForMonth,@EmployeeID,@IsBonus)
END