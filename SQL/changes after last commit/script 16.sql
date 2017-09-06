USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE CustomerDetailsEdit
		@CustomerDetailsID INT, @CustomerID INT, @FirstName NVARCHAR(50), @LastName NVARCHAR(50)
		,@Passport NVARCHAR(50), @BirthDate DATE, @Address NVARCHAR(255)
		,@Tel VARCHAR(50), @Viber VARCHAR(50), @Skype NVARCHAR(50), @Facebook NVARCHAR(50)
		,@UpdateIMG BIT, @IMG VARBINARY(MAX)
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
		IF @UpdateIMG = 1
			BEGIN
				UPDATE CustomerDetails
				SET CustomerID = @CustomerID
					,FirstName = @FirstName
					,LastName = @LastName
					,Passport = @Passport
					,BirthDate = @BirthDate
					,[Address] = @Address
					,IMG = @IMG
					,Tel = @Tel
					,Viber = @Viber
					,Skype = @Skype
					,Facebook = @Facebook
				WHERE CustomerDetailsID = @CustomerDetailsID
			END
		ELSE
			BEGIN
				UPDATE CustomerDetails
				SET CustomerID = @CustomerID
					,FirstName = @FirstName
					,LastName = @LastName
					,Passport = @Passport
					,BirthDate = @BirthDate
					,[Address] = @Address
					,Tel = @Tel
					,Viber = @Viber
					,Skype = @Skype
					,Facebook = @Facebook
				WHERE CustomerDetailsID = @CustomerDetailsID
			END
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END