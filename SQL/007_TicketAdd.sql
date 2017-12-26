USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE TicketAdd
	 @ReservNumber NVARCHAR(50),@FromAirportID INT,@ToAirportID INT
	,@FlyDayTime DATETIME2(0),@WithReturn BIT,@ReturnFlyDayTime DATETIME2(0)
	,@Price DECIMAL(12,0),@Cost DECIMAL(12,0),@CustomerID INT,@AdultCount TINYINT
	,@ChildCount TINYINT,@BabyCount TINYINT,@ChildYearsComment NVARCHAR(50),@OperatorID INT
	,@PaymaetDeathLine DATE,@PrePayPrice DECIMAL(12,0),@NextPayDate DATE,@IsTotalyPayed BIT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Ticket (CreationDate,ReservNumber,FromAirportID,ToAirportID,FlyDayTime,WithReturn
		,ReturnFlyDayTime,Price,Cost,CustomerID,AdultCount,ChildCount,BabyCount,ChildYearsComment
		,OperatorID,PaymaetDeathLine,PrePayPrice,NextPayDate,IsTotalyPayed)
	VALUES (CURRENT_TIMESTAMP,@ReservNumber,@FromAirportID,@ToAirportID,@FlyDayTime,@WithReturn
		,@ReturnFlyDayTime,@Price,@Cost,@CustomerID,@AdultCount,@ChildCount,@BabyCount,@ChildYearsComment
		,@OperatorID,@PaymaetDeathLine,@PrePayPrice,@NextPayDate,@IsTotalyPayed)
END
GO