USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].AdvertiseUpdate
	@AdvertiseID INT, @Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @TypeID INT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Advertise
		SET Fee = @Fee
		,ForYear = @ForYear
		,ForMonth = @ForMonth
		,TypeID = @TypeID
	WHERE AdvertiseID = @AdvertiseID
END