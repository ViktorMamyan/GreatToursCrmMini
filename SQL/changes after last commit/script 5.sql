USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE DirectionOperatorCombinationAdd
	@DirectionID INT, @OperatorID ID_List READONLY
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			IF EXISTS(SELECT * FROM DirectionOperatorCombination WHERE DirectionID = @DirectionID AND OperatorID IN (SELECT ID FROM @OperatorID))
				BEGIN
					SET @msg = N'Նման գրանցում գոյություն ունի';
					THROW 50001, @msg,1;
				END

				INSERT INTO DirectionOperatorCombination
				SELECT @DirectionID, ID FROM @OperatorID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END