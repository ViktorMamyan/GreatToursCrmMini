USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetTax]
(	
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT T.TaxID
		,T.CreationDate
		,TT.TaxType
		,T.Fee
		,T.ForYear
		,T.ForMonth
		,T.TaxTypeID
	FROM Tax T
	INNER JOIN TaxTypes TT ON TT.TaxTypeID = T.TaxTypeID
)