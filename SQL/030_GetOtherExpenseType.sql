USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetOtherExpenseType
(	

)
RETURNS TABLE 
AS
RETURN 
(
	SELECT TypeID,TypeName FROM OtherExpenseType
)
GO