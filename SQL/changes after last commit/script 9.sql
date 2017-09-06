USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE BonuseCardAdd
	@Card NVARCHAR(50),@CustomerID INT,@CreateDate DATE,@IsActive BIT
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			IF EXISTS(SELECT * FROM BonuseCard WHERE [Card] = @Card)
				BEGIN
					SET @msg = N'Նման գրանցում գոյություն ունի';
					THROW 50001, @msg,1;
				END
			INSERT INTO BonuseCard ([Card],CustomerID,CreateDate,IsActive) VALUES(@Card,@CustomerID,@CreateDate,@IsActive)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END