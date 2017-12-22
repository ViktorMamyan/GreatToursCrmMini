USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[AdvertiseAdd]
	@Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @TypeID INT, @Comment NVARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Advertise(CreationDate,Fee,ForYear,ForMonth,TypeID,Comment) VALUES(CURRENT_TIMESTAMP,@Fee,@ForYear,@ForMonth,@TypeID,@Comment)
END