USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION GetSalary
(	

)
RETURNS TABLE 
AS
RETURN 
(
	SELECT S.SalaryID
		,S.CreationDate
		,CONCAT(E.FirstName,N' ',E.LastName) Employee
		,S.Fee
		,S.ForYear
		,S.ForMonth
		,S.EmployeeID
		,S.IsBonus
	FROM Salary S
	INNER JOIN Employee E ON E.EmployeeID = S.EmployeeID
)
GO