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
CREATE TABLE dbo.Tmp_AirOperator
	(
	AirOperatorID int NOT NULL IDENTITY (1, 1),
	AirOperator nvarchar(50) NOT NULL,
	Country nvarchar(50) NULL,
	URL nvarchar(255) NULL,
	Login nvarchar(50) NULL,
	Password nvarchar(50) NULL,
	Contract bit NOT NULL,
	Tel varchar(50) NULL,
	Email nvarchar(50) NULL,
	website nvarchar(50) NULL,
	FB nvarchar(50) NULL,
	skype nvarchar(50) NULL,
	OtherContacts nvarchar(512) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_AirOperator SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_AirOperator ON
GO
IF EXISTS(SELECT * FROM dbo.AirOperator)
	 EXEC('INSERT INTO dbo.Tmp_AirOperator (AirOperatorID, AirOperator, Country, URL, Login, Password, Contract, Tel, Email, website, FB, skype, OtherContacts)
		SELECT AirOperatorID, AirOperator, Country, URL, Login, Password, Contract, Tel, Email, website, FB, skype, OtherContacts FROM dbo.AirOperator WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_AirOperator OFF
GO
DROP TABLE dbo.AirOperator
GO
EXECUTE sp_rename N'dbo.Tmp_AirOperator', N'AirOperator', 'OBJECT' 
GO
ALTER TABLE dbo.AirOperator ADD CONSTRAINT
	PK_AirOperator PRIMARY KEY CLUSTERED 
	(
	AirOperatorID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
