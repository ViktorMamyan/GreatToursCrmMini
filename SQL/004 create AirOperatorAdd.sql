USE [GT]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AirOperatorAdd]
	@AirOperator NVARCHAR(50),@Country NVARCHAR(50),@URL NVARCHAR(255),@Login NVARCHAR(50),@Password NVARCHAR(50)
	,@Contract BIT,@Tel VARCHAR(50),@Email NVARCHAR(50),@website NVARCHAR(50),@FB NVARCHAR(50),@skype NVARCHAR(50),@OtherContacts NVARCHAR(512)
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO dbo.AirOperator (AirOperator, Country, [URL], [Login], [Password], [Contract], Tel, Email, website, FB, skype, OtherContacts)
			VALUES(@AirOperator, @Country, @URL, @Login, @Password, @Contract, @Tel, @Email, @website, @FB, @skype, @OtherContacts)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END