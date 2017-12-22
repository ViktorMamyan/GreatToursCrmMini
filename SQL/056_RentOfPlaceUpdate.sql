USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[RentOfPlaceUpdate]
	@RentID INT, @Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @Comment NVARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE RentOfPlace
	SET Fee = @Fee
	,ForYear = @ForYear
	,ForMonth = @ForMonth
	,Comment = @Comment
	WHERE RentID = @RentID
END