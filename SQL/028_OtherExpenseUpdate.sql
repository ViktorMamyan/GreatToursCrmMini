USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[OtherExpenseUpdate]
	@OtherExpenseID INT, @Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @TypeID INT, @Comment NVARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE OtherExpense
		SET Fee = @Fee
		,ForYear = @ForYear
		,ForMonth = @ForMonth
		,TypeID = @TypeID
		,Comment = @Comment
	WHERE OtherExpenseID = @OtherExpenseID
END