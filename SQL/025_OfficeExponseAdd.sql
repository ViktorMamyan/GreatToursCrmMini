USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[OfficeExponseAdd]
	@Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @OfficeExponseTypeID INT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO OfficeExponse(CreationDate,Fee,ForYear,ForMonth,OfficeExponseTypeID) VALUES(CURRENT_TIMESTAMP,@Fee,@ForYear,@ForMonth,@OfficeExponseTypeID)
END