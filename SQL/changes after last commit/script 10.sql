USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[TourOperatorAdd]
	@OperatorName NVARCHAR(255),@Director NVARCHAR(50),@OperatorLocation NVARCHAR(255),@RequestByURL BIT,@RequestURL NVARCHAR(255),@website NVARCHAR(50),@Tel VARCHAR(50),@skype NVARCHAR(50),@facebook NVARCHAR(50),@email NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO TourOperator (OperatorName,Director,OperatorLocation,RequestByURL,RequestURL,website,Tel,skype,facebook,email)
			VALUES (@OperatorName,@Director,@OperatorLocation,@RequestByURL,@RequestURL,@website,@Tel,@skype,@facebook,@email)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END