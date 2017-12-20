USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE HotelBookingUpdate
	@HotelBookID INT,@HotelName NVARCHAR(255),@StartDate DATE,@EndDate DATE
	,@Price DECIMAL(12,0),@Cost DECIMAL(12,0),@CustomerID INT,@AdultCount TINYINT
	,@ChildCount TINYINT,@BabyCount TINYINT
	,@ChildYearsComment NVARCHAR(255),@FoodTypeID INT,@Transfer BIT
	,@OperatorID INT,@PaymaetDeathLine DATE,@PrePayPrice DECIMAL(12,0),@NextPayDate DATE,@IsTotalyPayed BIT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE HotelBooking
		SET HotelName = @HotelName
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
	WHERE HotelBookID = @HotelBookID
END
GO