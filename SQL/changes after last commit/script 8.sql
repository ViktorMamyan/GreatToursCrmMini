USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE DirectionOperatorCombinationEdit
	@DirectionID INT, @OperatorID ID_List READONLY
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			--IF EXISTS(SELECT * FROM DirectionOperatorCombination WHERE DirectionID = @DirectionID AND OperatorID IN (SELECT ID FROM @OperatorID WHERE DirectionID <> @DirectionID))
			--	BEGIN
			--		SET @msg = N'Նման գրանցում գոյություն ունի';
			--		THROW 50001, @msg,1;
			--	END

			MERGE DirectionOperatorCombination AS TARGET
			USING @OperatorID AS SOURCE ON (TARGET.OperatorID = SOURCE.ID AND TARGET.DirectionID = @DirectionID)
			WHEN NOT MATCHED BY TARGET THEN INSERT (DirectionID,OperatorID) VALUES (@DirectionID,SOURCE.ID)
			WHEN NOT MATCHED BY SOURCE AND TARGET.DirectionID = @DirectionID THEN DELETE;

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END