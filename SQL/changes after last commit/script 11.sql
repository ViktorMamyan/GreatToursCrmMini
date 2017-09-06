USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE CustomerDetailsAdd
	@CustomerID INT, @FirstName NVARCHAR(50), @LastName NVARCHAR(50)
		,@Passport NVARCHAR(50), @BirthDate DATE, @Address NVARCHAR(255), @IMG VARBINARY(MAX)
		,@Tel VARCHAR(50), @Viber VARCHAR(50), @Skype NVARCHAR(50), @Facebook NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO CustomerDetails (CustomerID,FirstName,LastName,Passport,BirthDate,[Address],IMG,Tel,Viber,Skype,Facebook)
			VALUES(@CustomerID,@FirstName,@LastName,@Passport,@BirthDate,@Address,@IMG,@Tel,@Viber,@Skype,@Facebook)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END