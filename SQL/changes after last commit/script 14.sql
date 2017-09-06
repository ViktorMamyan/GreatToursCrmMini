USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION GetCustomerDetailsIMG
(@CustomerDetailsID INT)
RETURNS TABLE 
AS
RETURN 
(
	SELECT TOP (1) IMG
	FROM CustomerDetails
	WHERE CustomerDetailsID = @CustomerDetailsID
)