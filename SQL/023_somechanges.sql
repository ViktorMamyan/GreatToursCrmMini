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
ALTER TABLE dbo.HotelBooking
	DROP CONSTRAINT FK_Food
GO
ALTER TABLE dbo.FoodType SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.HotelBooking
	DROP CONSTRAINT FK_HotelBooking_TourOperator
GO
ALTER TABLE dbo.TourOperator SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.HotelBooking
	DROP CONSTRAINT FK_HotelBooking_Customer
GO
ALTER TABLE dbo.Customer SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_HotelBooking
	(
	HotelBookID int NOT NULL IDENTITY (1, 1),
	CreationDate date NOT NULL,
	HotelName nvarchar(255) NOT NULL,
	StartDate date NOT NULL,
	EndDate date NOT NULL,
	Price decimal(12, 0) NOT NULL,
	Cost decimal(12, 0) NULL,
	CustomerID int NOT NULL,
	AdultCount tinyint NOT NULL,
	ChildCount tinyint NULL,
	BabyCount tinyint NULL,
	ChildYearsComment nvarchar(255) NULL,
	FoodTypeID int NULL,
	Transfer bit NOT NULL,
	OperatorID int NULL,
	PaymaetDeathLine date NULL,
	PrePayPrice decimal(12, 0) NULL,
	NextPayDate date NULL,
	IsTotalyPayed bit NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_HotelBooking SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_HotelBooking ON
GO
IF EXISTS(SELECT * FROM dbo.HotelBooking)
	 EXEC('INSERT INTO dbo.Tmp_HotelBooking (HotelBookID, CreationDate, HotelName, StartDate, EndDate, Price, Cost, CustomerID, AdultCount, ChildCount, BabyCount, ChildYearsComment, FoodTypeID, Transfer, OperatorID, PaymaetDeathLine, PrePayPrice, NextPayDate, IsTotalyPayed)
		SELECT HotelBookID, CreationDate, HotelName, StartDate, EndDate, Price, Cost, CustomerID, AdultCount, ChildCount, BabyCount, ChildYearsComment, FoodTypeID, Transfer, OperatorID, PaymaetDeathLine, PrePayPrice, NextPayDate, IsTotalyPayed FROM dbo.HotelBooking WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_HotelBooking OFF
GO
DROP TABLE dbo.HotelBooking
GO
EXECUTE sp_rename N'dbo.Tmp_HotelBooking', N'HotelBooking', 'OBJECT' 
GO
ALTER TABLE dbo.HotelBooking ADD CONSTRAINT
	PK_HotelBooking PRIMARY KEY CLUSTERED 
	(
	HotelBookID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.HotelBooking ADD CONSTRAINT
	FK_HotelBooking_Customer FOREIGN KEY
	(
	CustomerID
	) REFERENCES dbo.Customer
	(
	CustomerID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.HotelBooking ADD CONSTRAINT
	FK_HotelBooking_TourOperator FOREIGN KEY
	(
	OperatorID
	) REFERENCES dbo.TourOperator
	(
	TourOperatorID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.HotelBooking ADD CONSTRAINT
	FK_Food FOREIGN KEY
	(
	FoodTypeID
	) REFERENCES dbo.FoodType
	(
	FoodTypeID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT