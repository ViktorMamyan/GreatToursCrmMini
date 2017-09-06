USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION GetCustomerDetails
(	
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT CD.CustomerDetailsID
		,CD.CustomerID
		,C.CustomerName
		,CD.FirstName
		,CD.LastName
		,CD.Passport
		,CD.BirthDate
		,CD.[Address]
		--,CD.IMG
		,CD.Tel
		,CD.Viber
		,CD.Skype
		,CD.Facebook
	FROM CustomerDetails CD
	INNER JOIN Customer C ON C.CustomerID = CD.CustomerID
)