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
ALTER TABLE dbo.Tour
	DROP CONSTRAINT FK_Tour_Customer
GO
ALTER TABLE dbo.Customer SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Tour
	DROP CONSTRAINT FK_Tour_TourOperator
GO
ALTER TABLE dbo.TourOperator SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Tour
	DROP CONSTRAINT FK_Tour_Direction
GO
ALTER TABLE dbo.Direction SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Tour
	(
	TourID int NOT NULL IDENTITY (1, 1),
	CreationDate date NOT NULL,
	TourName nvarchar(50) NOT NULL,
	TourStartDate date NOT NULL,
	TourEndDate date NOT NULL,
	Price decimal(12, 0) NOT NULL,
	Cost decimal(12, 0) NULL,
	CustomerID int NOT NULL,
	AdultCount tinyint NOT NULL,
	ChildCount tinyint NULL,
	BabyCount tinyint NULL,
	ChildYearsComment nvarchar(255) NULL,
	DirectionID int NOT NULL,
	OperatorID int NOT NULL,
	PaymaetDeathLine date NULL,
	PrePayPrice decimal(12, 0) NULL,
	NextPayDate date NULL,
	IsTotalyPayed bit NOT NULL,
	HotelList nvarchar(MAX) NULL,
	TicketList nvarchar(MAX) NULL,
	InsuranceList nvarchar(MAX) NULL,
	Excursion nvarchar(50) NULL,
	VIsa nvarchar(50) NULL,
	Transfer nvarchar(50) NULL,
	TourType nvarchar(50) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Tour SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Tour ON
GO
IF EXISTS(SELECT * FROM dbo.Tour)
	 EXEC('INSERT INTO dbo.Tmp_Tour (TourID, CreationDate, TourName, TourStartDate, TourEndDate, Price, Cost, CustomerID, AdultCount, ChildCount, BabyCount, ChildYearsComment, DirectionID, OperatorID, PaymaetDeathLine, PrePayPrice, NextPayDate, IsTotalyPayed, HotelList, TicketList, InsuranceList, Excursion, VIsa, Transfer, TourType)
		SELECT TourID, CreationDate, TourName, TourStartDate, TourEndDate, Price, Cost, CustomerID, AdultCount, ChildCount, BabyCount, ChildYearsComment, DirectionID, OperatorID, PaymaetDeathLine, PrePayPrice, NextPayDate, IsTotalyPayed, CONVERT(nvarchar(MAX), HotelList), CONVERT(nvarchar(MAX), TicketList), CONVERT(nvarchar(MAX), InsuranceList), Excursion, VIsa, Transfer, TourType FROM dbo.Tour WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Tour OFF
GO
ALTER TABLE dbo.TourCustomerDetails
	DROP CONSTRAINT FK_TourCustomerDetails_Tour
GO
ALTER TABLE dbo.Bonus
	DROP CONSTRAINT FK_Bonus_Tour
GO
DROP TABLE dbo.Tour
GO
EXECUTE sp_rename N'dbo.Tmp_Tour', N'Tour', 'OBJECT' 
GO
ALTER TABLE dbo.Tour ADD CONSTRAINT
	PK_Tour PRIMARY KEY CLUSTERED 
	(
	TourID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
CREATE UNIQUE NONCLUSTERED INDEX UQ_TourName ON dbo.Tour
	(
	TourName
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE dbo.Tour ADD CONSTRAINT
	FK_Tour_Direction FOREIGN KEY
	(
	DirectionID
	) REFERENCES dbo.Direction
	(
	DirectionID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Tour ADD CONSTRAINT
	FK_Tour_TourOperator FOREIGN KEY
	(
	OperatorID
	) REFERENCES dbo.TourOperator
	(
	TourOperatorID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Tour ADD CONSTRAINT
	FK_Tour_Customer FOREIGN KEY
	(
	CustomerID
	) REFERENCES dbo.Customer
	(
	CustomerID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Bonus ADD CONSTRAINT
	FK_Bonus_Tour FOREIGN KEY
	(
	TourID
	) REFERENCES dbo.Tour
	(
	TourID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Bonus SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.TourCustomerDetails ADD CONSTRAINT
	FK_TourCustomerDetails_Tour FOREIGN KEY
	(
	TourID
	) REFERENCES dbo.Tour
	(
	TourID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.TourCustomerDetails SET (LOCK_ESCALATION = TABLE)
GO
COMMIT