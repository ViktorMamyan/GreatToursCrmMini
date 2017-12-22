USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[HotelBookingUpdate]
	@HotelBookID INT,@HotelID INT,@StartDate DATE,@EndDate DATE
	,@Price DECIMAL(12,0),@Cost DECIMAL(12,0),@CustomerID INT,@AdultCount TINYINT
	,@ChildCount TINYINT,@BabyCount TINYINT
	,@ChildYearsComment NVARCHAR(255),@FoodTypeID INT,@Transfer BIT
	,@OperatorID INT,@PaymaetDeathLine DATE,@PrePayPrice DECIMAL(12,0),@NextPayDate DATE,@IsTotalyPayed BIT
	,@TransferPrice DECIMAL(12,0)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE HotelBooking
		SET HotelID = @HotelID
		,StartDate = @StartDate
		,EndDate = @EndDate
		,Price = @Price
		,Cost = @Cost
		,CustomerID = @CustomerID
		,AdultCount = @AdultCount
		,ChildCount = @ChildCount
		,BabyCount = @BabyCount
		,ChildYearsComment = @ChildYearsComment
		,FoodTypeID = @FoodTypeID
		,[Transfer] = @Transfer
		,OperatorID = @OperatorID
		,PaymaetDeathLine = @PaymaetDeathLine
		,PrePayPrice = @PrePayPrice
		,NextPayDate = @NextPayDate
		,IsTotalyPayed = @IsTotalyPayed
		,TransferPrice = @TransferPrice
	WHERE HotelBookID = @HotelBookID
END
