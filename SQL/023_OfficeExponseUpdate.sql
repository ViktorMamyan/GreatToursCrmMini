USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[OfficeExponseUpdate]
	@OfficeExponseID INT, @Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @OfficeExponseTypeID INT,@Comment NVARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE OfficeExponse
		SET Fee = @Fee
		,ForYear = @ForYear
		,ForMonth = @ForMonth
		,OfficeExponseTypeID = @OfficeExponseTypeID
		,Comment = @Comment
	WHERE OfficeExponseID = @OfficeExponseID
END