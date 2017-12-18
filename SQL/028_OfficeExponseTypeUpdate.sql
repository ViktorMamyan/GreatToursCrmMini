USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE OfficeExponseTypeUpdate
	@OfficeExponseTypeID INT, @OfficeExpType NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE OfficeExponseType SET OfficeExpType = @OfficeExpType WHERE OfficeExponseTypeID = @OfficeExponseTypeID
END
GO