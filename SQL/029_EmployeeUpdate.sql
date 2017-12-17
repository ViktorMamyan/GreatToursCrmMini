USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE EmployeeUpdate
	@EmployeeID INT, @FirstName NVARCHAR(50), @LastName NVARCHAR(50)
AS
BEGIN

	SET NOCOUNT ON;
	UPDATE Employee
		SET FirstName = @FirstName
		,LastName = @LastName
	WHERE EmployeeID = @EmployeeID
END
GO