USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[HotelBookingAdd]
	@HotelID INT,@StartDate DATE,@EndDate DATE
	,@Price DECIMAL(12,0),@Cost DECIMAL(12,0),@CustomerID INT,@AdultCount TINYINT
	,@ChildCount TINYINT,@BabyCount TINYINT
	,@ChildYearsComment NVARCHAR(255),@FoodTypeID INT,@Transfer BIT
	,@OperatorID INT,@PaymaetDeathLine DATE,@PrePayPrice DECIMAL(12,0),@NextPayDate DATE,@IsTotalyPayed BIT
	,@TransferPrice DECIMAL(12,0)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO HotelBooking (CreationDate,HotelID,StartDate,EndDate,Price,Cost,CustomerID,AdultCount,ChildCount,BabyCount,ChildYearsComment,FoodTypeID,[Transfer],OperatorID,PaymaetDeathLine,PrePayPrice,NextPayDate,IsTotalyPayed,TransferPrice)
	VALUES(CURRENT_TIMESTAMP,@HotelID,@StartDate,@EndDate,@Price,@Cost,@CustomerID,@AdultCount,@ChildCount,@BabyCount,@ChildYearsComment,@FoodTypeID,@Transfer,@OperatorID,@PaymaetDeathLine,@PrePayPrice,@NextPayDate,@IsTotalyPayed,@TransferPrice)
END