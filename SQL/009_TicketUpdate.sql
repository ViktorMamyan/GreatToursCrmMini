USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE TicketUpdate
	 @TicketID INT,@ReservNumber NVARCHAR(50),@FromAirportID INT,@ToAirportID INT
	,@FlyDayTime DATETIME2(0),@WithReturn BIT,@ReturnFlyDayTime DATETIME2(0)
	,@Price DECIMAL(12,0),@Cost DECIMAL(12,0),@CustomerID INT,@AdultCount TINYINT
	,@ChildCount TINYINT,@BabyCount TINYINT,@ChildYearsComment NVARCHAR(50),@OperatorID INT
	,@PaymaetDeathLine DATE,@PrePayPrice DECIMAL(12,0),@NextPayDate DATE,@IsTotalyPayed BIT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Ticket
		SET ReservNumber = @ReservNumber
			,FromAirportID = @FromAirportID
			,ToAirportID = @ToAirportID
			,FlyDayTime = @FlyDayTime
			,WithReturn = @WithReturn
			,ReturnFlyDayTime = @ReturnFlyDayTime
			,Price = @Price
			,Cost = @Cost
			,CustomerID = @CustomerID
			,AdultCount = @AdultCount
			,ChildCount = @ChildCount
			,BabyCount = @BabyCount
			,ChildYearsComment = @ChildYearsComment
			,OperatorID = @OperatorID
			,PaymaetDeathLine = @PaymaetDeathLine
			,PrePayPrice = @PrePayPrice
			,NextPayDate = @NextPayDate
			,IsTotalyPayed = @IsTotalyPayed
	WHERE TicketID = @TicketID
END
GO