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
	DROP CONSTRAINT FK_PrePay
GO
ALTER TABLE dbo.PrePayment SET (LOCK_ESCALATION = TABLE)
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
	ChildCount tinyint NOT NULL,
	BabyCount tinyint NOT NULL,
	ChildYearsComment nvarchar(255) NULL,
	FoodTypeID int NOT NULL,
	Transfer bit NOT NULL,
	PrePayID int NULL,
	OperatorID int NULL,
	PaymaetDeathLine date NULL,
	IsTotalyPayed bit NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_HotelBooking SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_HotelBooking ON
GO
IF EXISTS(SELECT * FROM dbo.HotelBooking)
	 EXEC('INSERT INTO dbo.Tmp_HotelBooking (HotelBookID, CreationDate, StartDate, EndDate, Price, Cost, CustomerID, AdultCount, ChildCount, BabyCount, ChildYearsComment, FoodTypeID, Transfer, PrePayID, OperatorID, PaymaetDeathLine, IsTotalyPayed)
		SELECT HotelBookID, CreationDate, StartDate, EndDate, Price, Cost, CustomerID, AdultCount, ChildCount, BabyCount, ChildYearsComment, FoodTypeID, Transfer, PrePayID, OperatorID, PaymaetDeathLine, IsTotalyPayed FROM dbo.HotelBooking WITH (HOLDLOCK TABLOCKX)')
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
	FK_PrePay FOREIGN KEY
	(
	PrePayID
	) REFERENCES dbo.PrePayment
	(
	PrePeyID
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