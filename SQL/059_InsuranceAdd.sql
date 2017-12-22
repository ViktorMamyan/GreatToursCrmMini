USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[InsuranceAdd]
	@StartDate DATE,@EndDate DATE,@ClientID INT,@Price DECIMAL(12,0),@Cost DECIMAL(12,0)
	,@ReturnableDate DATE,@IsMulti BIT,@DaysCount SMALLINT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Insurance (CreationDate,StartDate,EndDate,ClientID,Price,Cost,ReturnableDate,IsMulti,DaysCount)
	VALUES(CURRENT_TIMESTAMP,@StartDate,@EndDate,@ClientID,@Price,@Cost,@ReturnableDate,@IsMulti,@DaysCount)
END