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
CREATE TABLE dbo.Hotels
	(
	HotelID int NOT NULL IDENTITY (1, 1),
	HotelName nvarchar(255) NOT NULL,
	CountryID int NOT NULL,
	Region nvarchar(255) NOT NULL,
	Stars tinyint NULL,
	HotelTypeID int NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Hotels ADD CONSTRAINT
	PK_Hotels PRIMARY KEY CLUSTERED 
	(
	HotelID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Hotels SET (LOCK_ESCALATION = TABLE)
GO
COMMIT