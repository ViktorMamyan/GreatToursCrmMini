USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE TourAdd
		@TourName NVARCHAR(50),@TourStartDate DATE,@TourEndDate DATE,@DirectionID INT
		,@OperatorID INT,@CustomerID INT,@TotalPrice DECIMAL(18,0),@ApproximateIncome DECIMAL(18,0)
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			IF EXISTS(SELECT * FROM Tour WHERE TourName = @TourName)
				BEGIN
					SET @msg = N'Նման գրանցում գոյություն ունի';
					THROW 50001, @msg,1;
				END
			INSERT INTO Tour (TourName, TourStartDate, TourEndDate, DirectionID, OperatorID, CustomerID, TotalPrice, ApproximateIncome)
			VALUES (@TourName, @TourStartDate, @TourEndDate, @DirectionID, @OperatorID, @CustomerID, @TotalPrice, @ApproximateIncome)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END