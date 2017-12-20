USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE HotelBookingAdd
	@HotelName NVARCHAR(255),@StartDate DATE,@EndDate DATE
	,@Price DECIMAL(12,0),@Cost DECIMAL(12,0),@CustomerID INT,@AdultCount TINYINT
	,@ChildCount TINYINT,@BabyCount TINYINT
	,@ChildYearsComment NVARCHAR(255),@FoodTypeID INT,@Transfer BIT
	,@OperatorID INT,@PaymaetDeathLine DATE,@PrePayPrice DECIMAL(12,0),@NextPayDate DATE,@IsTotalyPayed BIT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO HotelBooking (CreationDate,HotelName,StartDate,EndDate,Price,Cost,CustomerID,AdultCount,ChildCount,BabyCount,ChildYearsComment,FoodTypeID,[Transfer],OperatorID,PaymaetDeathLine,PrePayPrice,NextPayDate,IsTotalyPayed)
	VALUES(CURRENT_TIMESTAMP,@HotelName,@StartDate,@EndDate,@Price,@Cost,@CustomerID,@AdultCount,@ChildCount,@BabyCount,@ChildYearsComment,@FoodTypeID,@Transfer,@OperatorID,@PaymaetDeathLine,@PrePayPrice,@NextPayDate,@IsTotalyPayed)
END
GO