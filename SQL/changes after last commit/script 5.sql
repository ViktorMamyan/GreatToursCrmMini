USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE CustomerAdd
	@CustomerName NVARCHAR(255), @RegisterDate DATE
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO Customer (CustomerName,RegisterDate) VALUES(@CustomerName,@RegisterDate)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END