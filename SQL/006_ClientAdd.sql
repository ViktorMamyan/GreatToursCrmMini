USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE ClientAdd
	@ClientFullName NVARCHAR(50), @ClientContacts NVARCHAR(512)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Client (ClientFullName,ClientContacts) VALUES(@ClientFullName,@ClientContacts)
END
GO