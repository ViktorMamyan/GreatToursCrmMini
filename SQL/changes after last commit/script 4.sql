USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION GetCustomer
(	
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT CustomerID
		,CustomerName
		,RegisterDate
	FROM Customer
)