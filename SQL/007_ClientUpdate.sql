USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE ClientUpdate
	@ClientID INT, @ClientFullName NVARCHAR(50), @ClientContacts NVARCHAR(512)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Client 
		SET ClientFullName = @ClientFullName
		,ClientContacts = @ClientContacts
	WHERE ClientID = @ClientID
END
GO