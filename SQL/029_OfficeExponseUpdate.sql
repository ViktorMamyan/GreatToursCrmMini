USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].OfficeExponseUpdate
	@OfficeExponseID INT, @Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @OfficeExponseTypeID INT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE OfficeExponse
		SET Fee = @Fee
		,ForYear = @ForYear
		,ForMonth = @ForMonth
		,OfficeExponseTypeID = @OfficeExponseTypeID
	WHERE OfficeExponseID = @OfficeExponseID
END