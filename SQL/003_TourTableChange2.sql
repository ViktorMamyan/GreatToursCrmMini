USE GT
GO

BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Tour ADD
	HotelList nvarchar(512) NULL,
	TicketList nvarchar(512) NULL,
	InsuranceList nvarchar(512) NULL,
	Excursion nvarchar(50) NULL,
	VIsa nvarchar(50) NULL,
	[Transfer] nvarchar(50) NULL,
	TourType nvarchar(50) NULL
GO
ALTER TABLE dbo.Tour SET (LOCK_ESCALATION = TABLE)
GO
COMMIT