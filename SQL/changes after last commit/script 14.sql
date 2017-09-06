USE [GT]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE TourCustomerAdd
	@TourID INT, @CustomerDetailsID ID_List READONLY
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			IF EXISTS(SELECT * FROM TourCustomerDetails WHERE TourID = @TourID AND CustomerDetailsID IN (SELECT ID FROM @CustomerDetailsID))
				BEGIN
					SET @msg = N'Նման գրանցում գոյություն ունի';
					THROW 50001, @msg,1;
				END

				INSERT INTO TourCustomerDetails
				SELECT @TourID, ID FROM @CustomerDetailsID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END