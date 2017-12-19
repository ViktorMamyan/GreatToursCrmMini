USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE InsuranceUpdate
	@InsuranceID INT,@StartDate DATE,@EndDate DATE,@ClientID INT,@Price DECIMAL(12,0),@Cost DECIMAL(12,0),@ReturnableDate DATE
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
	WHERE InsuranceID = @InsuranceID
END
GO