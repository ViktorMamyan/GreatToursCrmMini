USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TaxUpdate]
	@TaxID INT, @Fee DECIMAL(12,0), @ForYear SMALLINT, @ForMonth TINYINT, @TaxTypeID INT
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE Tax
	SET Fee = @Fee
		,ForYear = @ForYear
		,ForMonth = @ForMonth
		,TaxTypeID = @TaxTypeID
	WHERE TaxID = @TaxID
END