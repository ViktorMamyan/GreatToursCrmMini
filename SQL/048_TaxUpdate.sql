USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[TaxUpdate]
	@TaxID INT, @Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @TaxTypeID INT, @Comment NVARCHAR(255)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE Tax
	SET Fee = @Fee
		,ForYear = @ForYear
		,ForMonth = @ForMonth
		,TaxTypeID = @TaxTypeID
		,Comment = @Comment
	WHERE TaxID = @TaxID
END