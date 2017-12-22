USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER FUNCTION [dbo].[GetRentOfPlace]
(	
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT RentID
		,CreationDate
		,Fee
		,ForYear
		,ForMonth
		,Comment
	FROM RentOfPlace
)