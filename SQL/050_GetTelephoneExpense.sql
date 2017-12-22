USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER FUNCTION [dbo].[GetTelephoneExpense]
(	

)
RETURNS TABLE 
AS
RETURN 
(
	SELECT TelExpID
		,CreationDate
		,PhoneNumber
		,Fee
		,ForYear
		,ForMonth
		,Comment
	FROM TelephoneExpense
)