USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER FUNCTION [dbo].[GetInsurance]
(	

)
RETURNS TABLE 
AS
RETURN 
(
	SELECT I.InsuranceID
		,I.CreationDate
		,C.CustomerName ClientFullName
		,I.StartDate
		,I.EndDate
		,I.ClientID
		,I.Price
		,I.Cost
		,I.ReturnableDate
	FROM Insurance I
	INNER JOIN Customer C ON C.CustomerID = I.ClientID
)