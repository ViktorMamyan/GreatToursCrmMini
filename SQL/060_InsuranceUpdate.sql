USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[InsuranceUpdate]
	@InsuranceID INT,@StartDate DATE,@EndDate DATE,@ClientID INT,@Price DECIMAL(12,0)
	,@Cost DECIMAL(12,0),@ReturnableDate DATE,@IsMulti BIT,@DaysCount SMALLINT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Insurance
		SET StartDate = @StartDate
		,EndDate = @EndDate
		,ClientID = @ClientID
		,Price = @Price
		,Cost = @Cost
		,ReturnableDate = @ReturnableDate
		,IsMulti = @IsMulti
		,DaysCount = @DaysCount
	WHERE InsuranceID = @InsuranceID
END