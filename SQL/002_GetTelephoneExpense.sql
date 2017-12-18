USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetTelephoneExpense
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
	FROM TelephoneExpense
)
GO