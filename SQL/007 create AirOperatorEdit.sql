USE [GT]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AirOperatorEdit]
	@AirOperatorID INT,@AirOperator NVARCHAR(50),@Country NVARCHAR(50),@URL NVARCHAR(255),@Login NVARCHAR(50),@Password NVARCHAR(50)
	,@Contract BIT,@Tel VARCHAR(50),@Email NVARCHAR(50),@website NVARCHAR(50),@FB NVARCHAR(50),@skype NVARCHAR(50),@OtherContacts NVARCHAR(512)
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE AirOperator
			SET AirOperator = @AirOperator
			,Country = @Country
			,[URL] = @URL
			,[Login] = @Login
			,[Password] = @Password
			,[Contract] = @Contract
			,Tel = @Tel
			,Email = @Email
			,website = @website
			,FB = @FB
			,skype = @skype
			,OtherContacts = @OtherContacts
			WHERE AirOperatorID = @AirOperatorID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END