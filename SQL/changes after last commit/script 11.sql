USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[TourOperatorEdit]
	@ID INT,@OperatorName NVARCHAR(255),@Director NVARCHAR(50),@OperatorLocation NVARCHAR(255),@RequestByURL BIT,@RequestURL NVARCHAR(255),@website NVARCHAR(50),@Tel VARCHAR(50),@skype NVARCHAR(50),@facebook NVARCHAR(50),@email NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE TourOperator
			SET OperatorName = @OperatorName
				,Director = @Director
				,OperatorLocation = @OperatorLocation
				,RequestByURL = @RequestByURL
				,RequestURL = @RequestURL
				,website = @website
				,Tel = @Tel
				,skype = @skype
				,facebook = @facebook
				,email = @email
			WHERE TourOperatorID = @ID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END