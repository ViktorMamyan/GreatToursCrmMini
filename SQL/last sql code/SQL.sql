USE [GT]
GO

CREATE TYPE [dbo].[ID_List] AS TABLE(
	[ID] [int] NOT NULL
)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetLasCustomerDetailsID]
(
)
RETURNS INT
AS
BEGIN
	DECLARE @R INT

	SELECT @R = MAX(CustomerDetailsID) FROM CustomerDetails

	RETURN ISNULL(@R,0)

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetLasCustomerID]
(
)
RETURNS INT
AS
BEGIN
	DECLARE @R INT

	SELECT @R = MAX(CustomerID) FROM Customer

	RETURN ISNULL(@R,0)

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetLasDirectionID]
(
)
RETURNS INT
AS
BEGIN
	DECLARE @R INT

	SELECT @R = MAX(DirectionID) FROM Direction

	RETURN ISNULL(@R,0)

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetLasDirectionOperatorCombinationID]
(
)
RETURNS INT
AS
BEGIN
	DECLARE @R INT

	SELECT @R = MAX(ID) FROM DirectionOperatorCombination

	RETURN ISNULL(@R,0)

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetLastBonuseCardID]
(
)
RETURNS INT
AS
BEGIN
	DECLARE @R INT

	SELECT @R = MAX(CardID) FROM BonuseCard

	RETURN ISNULL(@R,0)

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetLasTourID]
(
)
RETURNS INT
AS
BEGIN
	DECLARE @R INT

	SELECT @R = MAX(TourID) FROM Tour

	RETURN ISNULL(@R,0)

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetTourOperatorID]
(
)
RETURNS INT
AS
BEGIN
	DECLARE @R INT

	SELECT @R = MAX(TourOperatorID) FROM TourOperator

	RETURN ISNULL(@R,0)

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerDetails](
	[CustomerDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Passport] [nvarchar](50) NULL,
	[BirthDate] [date] NULL,
	[Address] [nvarchar](255) NULL,
	[IMG] [varbinary](max) NULL,
	[Tel] [varchar](50) NULL,
	[Viber] [varchar](50) NULL,
	[Skype] [nvarchar](50) NULL,
	[Facebook] [nvarchar](50) NULL,
 CONSTRAINT [PK_CustomerDetails] PRIMARY KEY CLUSTERED 
(
	[CustomerDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetCustomerDetailsIMG]
(@CustomerDetailsID INT)
RETURNS TABLE 
AS
RETURN 
(
	SELECT TOP (1) IMG
	FROM CustomerDetails
	WHERE CustomerDetailsID = @CustomerDetailsID
)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tour](
	[TourID] [int] IDENTITY(1,1) NOT NULL,
	[TourName] [nvarchar](50) NOT NULL,
	[TourStartDate] [date] NOT NULL,
	[TourEndDate] [date] NOT NULL,
	[DirectionID] [int] NOT NULL,
	[OperatorID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[TotalPrice] [decimal](18, 0) NOT NULL,
	[ApproximateIncome] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Tour] PRIMARY KEY CLUSTERED 
(
	[TourID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direction](
	[DirectionID] [int] IDENTITY(1,1) NOT NULL,
	[DirectionName] [nvarchar](255) NOT NULL,
	[SinlgeDirection] [bit] NOT NULL,
	[VisaDetails] [nvarchar](512) NOT NULL,
 CONSTRAINT [PK_Direction] PRIMARY KEY CLUSTERED 
(
	[DirectionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TourOperator](
	[TourOperatorID] [int] IDENTITY(1,1) NOT NULL,
	[OperatorName] [nvarchar](255) NOT NULL,
	[Director] [nvarchar](50) NULL,
	[OperatorLocation] [nvarchar](255) NOT NULL,
	[RequestByURL] [bit] NOT NULL,
	[RequestURL] [nvarchar](255) NULL,
	[website] [nvarchar](50) NULL,
	[Tel] [varchar](50) NULL,
	[skype] [nvarchar](50) NULL,
	[facebook] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
 CONSTRAINT [PK_TourOperator] PRIMARY KEY CLUSTERED 
(
	[TourOperatorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](255) NOT NULL,
	[RegisterDate] [date] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetTour]
(	
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT T.TourID
		,T.TourName
		,T.TourStartDate
		,T.TourEndDate
		,D.DirectionName
		,C.CustomerName
		,O.OperatorName
		,T.DirectionID
		,T.OperatorID
		,T.CustomerID
		,T.TotalPrice
		,T.ApproximateIncome
	FROM Tour T
	INNER JOIN Direction D ON D.DirectionID = T.DirectionID
	INNER JOIN TourOperator O ON O.TourOperatorID = T.OperatorID
	INNER JOIN Customer C ON C.CustomerID = T.CustomerID
)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BonuseCard](
	[CardID] [int] IDENTITY(1,1) NOT NULL,
	[Card] [nvarchar](50) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[CreateDate] [date] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_BonuseCard] PRIMARY KEY CLUSTERED 
(
	[CardID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetBonuseCard]
(	
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT BC.CardID
		,BC.[Card]
		,C.CustomerName
		,BC.CustomerID
		,BC.CreateDate
		,BC.IsActive
	FROM BonuseCard BC
	INNER JOIN Customer C ON C.CustomerID = BC.CustomerID
)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetDirection]
(	
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT DirectionID
		,DirectionName
		,SinlgeDirection
		,VisaDetails
	FROM Direction
)

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bonus](
	[BonusID] [int] IDENTITY(1,1) NOT NULL,
	[CardID] [int] NOT NULL,
	[TourID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[UseDate] [date] NOT NULL,
	[Points] [int] NOT NULL,
	[Direction] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bonus] PRIMARY KEY CLUSTERED 
(
	[BonusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetBonusByTourID]
(	
	@TourID INT
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT TOP (1)
  		 C.[Card]
		,B.Points
		,B.Direction
		,CAST(IIF(B.CustomerID = C.CustomerID ,0,1) AS BIT) IsDiffCustomer
	FROM Bonus B
	INNER JOIN BonuseCard C ON C.CardID = B.CardID
	WHERE B.TourID = @TourID
)

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TourCustomerDetails](
	[TourDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[TourID] [int] NOT NULL,
	[CustomerDetailsID] [int] NOT NULL,
 CONSTRAINT [PK_TourCustomerDetails] PRIMARY KEY CLUSTERED 
(
	[TourDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetTourCustomersByTourID]
(	
	@TourID INT
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT TCD.TourDetailsID
		,TCD.TourID
		,TCD.CustomerDetailsID
		,T.TourName
		,CONCAT(C.FirstName,N' ',C.LastName) Customer
	FROM TourCustomerDetails TCD
	INNER JOIN Tour T ON T.TourID = TCD.TourID
	INNER JOIN CustomerDetails C ON C.CustomerDetailsID = TCD.CustomerDetailsID
)

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetCustomerDetailsByTourID]
(	
	@TourID INT
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT C.CustomerDetailsID
			,CONCAT(C.FirstName,N' ',C.LastName) Customer
	FROM Tour T
	INNER JOIN CustomerDetails C ON C.CustomerID = T.CustomerID
	WHERE T.TourID = @TourID
)

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetTourOperator]
(	

)
RETURNS TABLE 
AS
RETURN 
(
SELECT TourOperatorID
      ,OperatorName
      ,ISNULL(Director,N'') AS Director
      ,OperatorLocation
      ,RequestByURL
      ,ISNULL(RequestURL,N'') AS RequestURL
      ,ISNULL(website,N'') AS website
      ,ISNULL(Tel,'') AS Tel
      ,ISNULL(skype,N'') AS skype
      ,ISNULL(facebook,N'') AS facebook
	  ,ISNULL(email,N'') AS email
  FROM TourOperator
)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DirectionOperatorCombination](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DirectionID] [int] NOT NULL,
	[OperatorID] [int] NOT NULL,
 CONSTRAINT [PK_DirectionOperatorCombination] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetDirectionOperatorCombination]
(	
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT DOC.ID
		,DOC.DirectionID
		,DOC.OperatorID
		,D.DirectionName
		,T.OperatorName
	FROM DirectionOperatorCombination DOC
	INNER JOIN Direction D ON D.DirectionID = DOC.DirectionID
	INNER JOIN TourOperator T ON T.TourOperatorID = DOC.OperatorID
)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetCustomer]
(	
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT CustomerID
		,CustomerName
		,RegisterDate
	FROM Customer
)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetCustomerDetails]
(	
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT CD.CustomerDetailsID
		,CD.CustomerID
		,C.CustomerName
		,CD.FirstName
		,CD.LastName
		,CD.Passport
		,CD.BirthDate
		,CD.[Address]
		--,CD.IMG
		,CD.Tel
		,CD.Viber
		,CD.Skype
		,CD.Facebook
	FROM CustomerDetails CD
	INNER JOIN Customer C ON C.CustomerID = CD.CustomerID
)
GO

CREATE UNIQUE NONCLUSTERED INDEX [UQ_TourID] ON [dbo].[Bonus]
(
	[TourID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO

CREATE UNIQUE NONCLUSTERED INDEX [UQ_Card] ON [dbo].[BonuseCard]
(
	[Card] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO

CREATE UNIQUE NONCLUSTERED INDEX [UQ_Passport] ON [dbo].[CustomerDetails]
(
	[Passport] ASC
)
WHERE ([Passport] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO

CREATE UNIQUE NONCLUSTERED INDEX [UQ_DirectionSingle] ON [dbo].[Direction]
(
	[DirectionName] ASC,
	[SinlgeDirection] ASC
)
INCLUDE ( 	[VisaDetails]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
GO

CREATE UNIQUE NONCLUSTERED INDEX [UQ_DirID_OpID] ON [dbo].[DirectionOperatorCombination]
(
	[DirectionID] ASC,
	[OperatorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO

CREATE UNIQUE NONCLUSTERED INDEX [UQ_TourName] ON [dbo].[Tour]
(
	[TourName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE UNIQUE NONCLUSTERED INDEX [UQ_TourCustomer] ON [dbo].[TourCustomerDetails]
(
	[TourID] ASC,
	[CustomerDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bonus]  WITH CHECK ADD  CONSTRAINT [FK_Bonus_BonuseCard] FOREIGN KEY([CardID])
REFERENCES [dbo].[BonuseCard] ([CardID])
GO
ALTER TABLE [dbo].[Bonus] CHECK CONSTRAINT [FK_Bonus_BonuseCard]
GO
ALTER TABLE [dbo].[Bonus]  WITH CHECK ADD  CONSTRAINT [FK_Bonus_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Bonus] CHECK CONSTRAINT [FK_Bonus_Customer]
GO
ALTER TABLE [dbo].[Bonus]  WITH CHECK ADD  CONSTRAINT [FK_Bonus_Tour] FOREIGN KEY([TourID])
REFERENCES [dbo].[Tour] ([TourID])
GO
ALTER TABLE [dbo].[Bonus] CHECK CONSTRAINT [FK_Bonus_Tour]
GO
ALTER TABLE [dbo].[BonuseCard]  WITH CHECK ADD  CONSTRAINT [FK_BonuseCard_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[BonuseCard] CHECK CONSTRAINT [FK_BonuseCard_Customer]
GO
ALTER TABLE [dbo].[CustomerDetails]  WITH CHECK ADD  CONSTRAINT [FK_CustomerDetails_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[CustomerDetails] CHECK CONSTRAINT [FK_CustomerDetails_Customer]
GO
ALTER TABLE [dbo].[DirectionOperatorCombination]  WITH CHECK ADD  CONSTRAINT [FK_DirectionOperatorCombination_Direction] FOREIGN KEY([DirectionID])
REFERENCES [dbo].[Direction] ([DirectionID])
GO
ALTER TABLE [dbo].[DirectionOperatorCombination] CHECK CONSTRAINT [FK_DirectionOperatorCombination_Direction]
GO
ALTER TABLE [dbo].[DirectionOperatorCombination]  WITH CHECK ADD  CONSTRAINT [FK_DirectionOperatorCombination_TourOperator] FOREIGN KEY([OperatorID])
REFERENCES [dbo].[TourOperator] ([TourOperatorID])
GO
ALTER TABLE [dbo].[DirectionOperatorCombination] CHECK CONSTRAINT [FK_DirectionOperatorCombination_TourOperator]
GO
ALTER TABLE [dbo].[Tour]  WITH CHECK ADD  CONSTRAINT [FK_Tour_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Tour] CHECK CONSTRAINT [FK_Tour_Customer]
GO
ALTER TABLE [dbo].[Tour]  WITH CHECK ADD  CONSTRAINT [FK_Tour_Direction] FOREIGN KEY([DirectionID])
REFERENCES [dbo].[Direction] ([DirectionID])
GO
ALTER TABLE [dbo].[Tour] CHECK CONSTRAINT [FK_Tour_Direction]
GO
ALTER TABLE [dbo].[Tour]  WITH CHECK ADD  CONSTRAINT [FK_Tour_TourOperator] FOREIGN KEY([OperatorID])
REFERENCES [dbo].[TourOperator] ([TourOperatorID])
GO
ALTER TABLE [dbo].[Tour] CHECK CONSTRAINT [FK_Tour_TourOperator]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BonuseCardAdd]
	@Card NVARCHAR(50),@CustomerID INT,@CreateDate DATE,@IsActive BIT
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			IF EXISTS(SELECT * FROM BonuseCard WHERE [Card] = @Card)
				BEGIN
					SET @msg = N'Նման գրանցում գոյություն ունի';
					THROW 50001, @msg,1;
				END
			INSERT INTO BonuseCard ([Card],CustomerID,CreateDate,IsActive) VALUES(@Card,@CustomerID,@CreateDate,@IsActive)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BonuseCardDelete]
	@CardID INT
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM BonuseCard WHERE CardID = @CardID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BonuseCardEdit]
	@CardID INT,@Card NVARCHAR(50),@CustomerID INT,@CreateDate DATE,@IsActive BIT
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			IF EXISTS(SELECT * FROM BonuseCard WHERE [Card] = @Card AND CardID <> @CardID)
				BEGIN
					SET @msg = N'Նման գրանցում գոյություն ունի';
					THROW 50001, @msg,1;
				END
			UPDATE BonuseCard
			SET [Card] = @Card
				,CustomerID = @CustomerID
				,CreateDate = @CreateDate
				,IsActive = @IsActive
			WHERE CardID = @CardID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CustomerAdd]
	@CustomerName NVARCHAR(255), @RegisterDate DATE
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO Customer (CustomerName,RegisterDate) VALUES(@CustomerName,@RegisterDate)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CustomerDelete]
	@CustomerID INT
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM Customer WHERE CustomerID = @CustomerID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CustomerDetailsAdd]
	@CustomerID INT, @FirstName NVARCHAR(50), @LastName NVARCHAR(50)
		,@Passport NVARCHAR(50), @BirthDate DATE, @Address NVARCHAR(255), @IMG VARBINARY(MAX)
		,@Tel VARCHAR(50), @Viber VARCHAR(50), @Skype NVARCHAR(50), @Facebook NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO CustomerDetails (CustomerID,FirstName,LastName,Passport,BirthDate,[Address],IMG,Tel,Viber,Skype,Facebook)
			VALUES(@CustomerID,@FirstName,@LastName,@Passport,@BirthDate,@Address,@IMG,@Tel,@Viber,@Skype,@Facebook)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CustomerDetailsDelete]
	@CustomerDetailsID INT
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM CustomerDetails WHERE CustomerDetailsID = @CustomerDetailsID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CustomerDetailsEdit]
		@CustomerDetailsID INT, @CustomerID INT, @FirstName NVARCHAR(50), @LastName NVARCHAR(50)
		,@Passport NVARCHAR(50), @BirthDate DATE, @Address NVARCHAR(255)
		,@Tel VARCHAR(50), @Viber VARCHAR(50), @Skype NVARCHAR(50), @Facebook NVARCHAR(50)
		,@UpdateIMG BIT, @IMG VARBINARY(MAX)
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
		IF @UpdateIMG = 1
			BEGIN
				UPDATE CustomerDetails
				SET CustomerID = @CustomerID
					,FirstName = @FirstName
					,LastName = @LastName
					,Passport = @Passport
					,BirthDate = @BirthDate
					,[Address] = @Address
					,IMG = @IMG
					,Tel = @Tel
					,Viber = @Viber
					,Skype = @Skype
					,Facebook = @Facebook
				WHERE CustomerDetailsID = @CustomerDetailsID
			END
		ELSE
			BEGIN
				UPDATE CustomerDetails
				SET CustomerID = @CustomerID
					,FirstName = @FirstName
					,LastName = @LastName
					,Passport = @Passport
					,BirthDate = @BirthDate
					,[Address] = @Address
					,Tel = @Tel
					,Viber = @Viber
					,Skype = @Skype
					,Facebook = @Facebook
				WHERE CustomerDetailsID = @CustomerDetailsID
			END
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CustomerEdit]
	@CustomerID INT, @CustomerName NVARCHAR(255), @RegisterDate DATE
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE Customer
			SET CustomerName = @CustomerName
				,RegisterDate = @RegisterDate
			WHERE CustomerID = @CustomerID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DirectionAdd]
	@DirectionName NVARCHAR(255),@SinlgeDirection BIT,@VisaDetails NVARCHAR(512)
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			IF EXISTS(SELECT * FROM Direction WHERE DirectionName = @DirectionName AND SinlgeDirection = @SinlgeDirection)
				BEGIN
					SET @msg = N'Նման գրանցում գոյություն ունի';
					THROW 50001, @msg,1;
				END

				INSERT INTO Direction (DirectionName,SinlgeDirection,VisaDetails) VALUES(@DirectionName,@SinlgeDirection,@VisaDetails)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DirectionDelete]
	@DirectionID INT
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM Direction WHERE DirectionID = @DirectionID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH

END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DirectionEdit]
	@DirectionID INT,@DirectionName NVARCHAR(255),@SinlgeDirection BIT,@VisaDetails NVARCHAR(512)
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			IF EXISTS(SELECT * FROM Direction WHERE DirectionName = @DirectionName AND SinlgeDirection = @SinlgeDirection AND DirectionID <> @DirectionID)
				BEGIN
					SET @msg = N'Նման գրանցում գոյություն ունի';
					THROW 50001, @msg,1;
				END

				UPDATE Direction
				SET DirectionName = @DirectionName,SinlgeDirection = @SinlgeDirection,VisaDetails = @VisaDetails
				WHERE DirectionID = @DirectionID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DirectionOperatorCombinationAdd]
	@DirectionID INT, @OperatorID ID_List READONLY
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			IF EXISTS(SELECT * FROM DirectionOperatorCombination WHERE DirectionID = @DirectionID AND OperatorID IN (SELECT ID FROM @OperatorID))
				BEGIN
					SET @msg = N'Նման գրանցում գոյություն ունի';
					THROW 50001, @msg,1;
				END

				INSERT INTO DirectionOperatorCombination
				SELECT @DirectionID, ID FROM @OperatorID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DirectionOperatorCombinationDelete]
	@ID INT
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM DirectionOperatorCombination WHERE ID = @ID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DirectionOperatorCombinationEdit]
	@DirectionID INT, @OperatorID ID_List READONLY
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			--IF EXISTS(SELECT * FROM DirectionOperatorCombination WHERE DirectionID = @DirectionID AND OperatorID IN (SELECT ID FROM @OperatorID WHERE DirectionID <> @DirectionID))
			--	BEGIN
			--		SET @msg = N'Նման գրանցում գոյություն ունի';
			--		THROW 50001, @msg,1;
			--	END

			MERGE DirectionOperatorCombination AS TARGET
			USING @OperatorID AS SOURCE ON (TARGET.OperatorID = SOURCE.ID AND TARGET.DirectionID = @DirectionID)
			WHEN NOT MATCHED BY TARGET THEN INSERT (DirectionID,OperatorID) VALUES (@DirectionID,SOURCE.ID)
			WHEN NOT MATCHED BY SOURCE AND TARGET.DirectionID = @DirectionID THEN DELETE;

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TourAdd]
		@TourName NVARCHAR(50),@TourStartDate DATE,@TourEndDate DATE,@DirectionID INT
		,@OperatorID INT,@CustomerID INT,@TotalPrice DECIMAL(18,0),@ApproximateIncome DECIMAL(18,0)
		,@UseBonusCard BIT,@AddBouns BIT,@Card NVARCHAR(50),@Points INT,@ByAnotherCustomer BIT
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			IF EXISTS(SELECT * FROM Tour WHERE TourName = @TourName)
				BEGIN
					SET @msg = N'Նման գրանցում գոյություն ունի';
					THROW 50001, @msg,1;
				END

			DECLARE @Pnt INT = 0
			DECLARE @CardID INT = NULL

			IF @UseBonusCard = 1
				BEGIN
					IF @AddBouns = 1
						BEGIN
							SELECT @CardID = CardID FROM BonuseCard WHERE [Card] = @Card AND IsActive = 1
							SET @Pnt = @Points
						END
					ELSE
						BEGIN
							IF @ByAnotherCustomer = 0
								BEGIN
									SELECT @CardID = CardID FROM BonuseCard WHERE [Card] = @Card AND CustomerID = @CustomerID AND IsActive = 1
								END
							else
								BEGIN
									SELECT @CardID = CardID FROM BonuseCard WHERE [Card] = @Card AND IsActive = 1
								END

							IF @CardID IS NULL
								BEGIN
									SET @msg = N'Անորոշ քարտ կամ քարտը պատկանում է այլ հաճախորդի';
									THROW 50001, @msg,1;
								END

								SET @Pnt = @Points * (-1)
								DECLARE @TotalPoints INT

								SELECT @TotalPoints = SUM(Points) FROM Bonus WHERE CardID = @CardID

								IF @Points > @TotalPoints
									BEGIN
										SET @msg = N'Մարումը գերազանցում է առկա միավորները՝ ' + CAST(@TotalPoints AS NVARCHAR(50));
										THROW 50001, @msg,1;
									END
						END
				END

			INSERT INTO Tour (TourName, TourStartDate, TourEndDate, DirectionID, OperatorID, CustomerID, TotalPrice, ApproximateIncome)
			VALUES (@TourName, @TourStartDate, @TourEndDate, @DirectionID, @OperatorID, @CustomerID, @TotalPrice, @ApproximateIncome)

			DECLARE @TourID INT
			SELECT @TourID = IDENT_CURRENT ('dbo.Tour')

			IF @UseBonusCard = 1 AND @CardID IS NOT NULL AND @Pnt <> 0
				BEGIN
					INSERT INTO Bonus (CardID,TourID,CustomerID,UseDate,Points,Direction)
					VALUES(@CardID,@TourID,@CustomerID,CURRENT_TIMESTAMP,@Pnt,CASE WHEN @Pnt < 0 THEN N'OUT' ELSE 'IN' END)
				END
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TourCustomerAdd]
	@TourID INT, @CustomerDetailsID ID_List READONLY
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			IF EXISTS(SELECT * FROM TourCustomerDetails WHERE TourID = @TourID AND CustomerDetailsID IN (SELECT ID FROM @CustomerDetailsID))
				BEGIN
					SET @msg = N'Նման գրանցում գոյություն ունի';
					THROW 50001, @msg,1;
				END

				INSERT INTO TourCustomerDetails
				SELECT @TourID, ID FROM @CustomerDetailsID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TourCustomerDetailsDelete]
	@TourDetailsID INT
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM TourCustomerDetails WHERE TourDetailsID = @TourDetailsID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TourCustomerEdit]
	@TourID INT, @CustomerDetailsID ID_List READONLY
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM TourCustomerDetails WHERE TourID = @TourID

			INSERT INTO TourCustomerDetails
			SELECT @TourID, ID FROM @CustomerDetailsID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TourDelete]
	@TourID INT
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM Tour WHERE TourID = @TourID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TourEdit]
		 @TourID INT,@TourName NVARCHAR(50),@TourStartDate DATE,@TourEndDate DATE,@DirectionID INT
		,@OperatorID INT,@CustomerID INT,@TotalPrice DECIMAL(18,0),@ApproximateIncome DECIMAL(18,0)
		,@UseBonusCard BIT,@AddBouns BIT,@Card NVARCHAR(50),@Points INT,@ByAnotherCustomer BIT
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	DECLARE @msg NVARCHAR(1024)
	BEGIN TRY
		BEGIN TRANSACTION
			IF EXISTS(SELECT * FROM Tour WHERE TourName = @TourName AND TourID <> @TourID)
				BEGIN
					SET @msg = N'Նման գրանցում գոյություն ունի';
					THROW 50001, @msg,1;
				END

			DECLARE @SumPoint INT = 0
			
			DECLARE @Pnt INT = 0
			DECLARE @CardID INT = NULL

			IF @UseBonusCard = 0
				BEGIN
					SELECT @SumPoint = SUM(Points) FROM Bonus WHERE TourID <> @TourID
					IF @SumPoint < 0
						BEGIN
							SET @msg = N'Բոնուսի կուտակման արդյունքում ստացվում է բացասական մնացորդ';
							THROW 50001, @msg,1;
						END
					DELETE FROM Bonus WHERE TourID = @TourID
				END
			ELSE
				BEGIN
					IF @AddBouns = 1
						BEGIN
							SELECT @CardID = CardID FROM BonuseCard WHERE [Card] = @Card AND IsActive = 1
							SET @Pnt = @Points
						END
					ELSE
						BEGIN
							IF @ByAnotherCustomer = 0
								BEGIN
									SELECT @CardID = CardID FROM BonuseCard WHERE [Card] = @Card AND CustomerID = @CustomerID AND IsActive = 1
								END
							else
								BEGIN
									SELECT @CardID = CardID FROM BonuseCard WHERE [Card] = @Card AND IsActive = 1
								END

							IF @CardID IS NULL
								BEGIN
									SET @msg = N'Անորոշ քարտ կամ քարտը պատկանում է այլ հաճախորդի';
									THROW 50001, @msg,1;
								END

								SET @Pnt = @Points * (-1)
								DECLARE @TotalPoints INT

								SELECT @TotalPoints = SUM(Points) FROM Bonus WHERE CardID = @CardID AND TourID <> @TourID

								IF @Points > @TotalPoints
									BEGIN
										SET @msg = N'Մարումը գերազանցում է առկա միավորները՝ ' + CAST(@TotalPoints AS NVARCHAR(50));
										THROW 50001, @msg,1;
									END
						END		
				END

			UPDATE Tour
			SET TourName = @TourName
				,TourStartDate = @TourStartDate
				,TourEndDate = @TourEndDate
				,DirectionID = @DirectionID
				,OperatorID = @OperatorID
				,CustomerID = @CustomerID
				,TotalPrice = @TotalPrice
				,ApproximateIncome = @ApproximateIncome
			WHERE TourID = @TourID

	IF @UseBonusCard = 1 AND @CardID IS NOT NULL AND @Pnt <> 0
		BEGIN
			DELETE FROM Bonus WHERE TourID = @TourID

			INSERT INTO Bonus (CardID,TourID,CustomerID,UseDate,Points,Direction)
			VALUES(@CardID,@TourID,@CustomerID,CURRENT_TIMESTAMP,@Pnt,CASE WHEN @Pnt < 0 THEN N'OUT' ELSE 'IN' END)
		END

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TourOperatorAdd]
	@OperatorName NVARCHAR(255),@Director NVARCHAR(50),@OperatorLocation NVARCHAR(255),@RequestByURL BIT,@RequestURL NVARCHAR(255),@website NVARCHAR(50),@Tel VARCHAR(50),@skype NVARCHAR(50),@facebook NVARCHAR(50),@email NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO TourOperator (OperatorName,Director,OperatorLocation,RequestByURL,RequestURL,website,Tel,skype,facebook,email)
			VALUES (@OperatorName,@Director,@OperatorLocation,@RequestByURL,@RequestURL,@website,@Tel,@skype,@facebook,@email)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TourOperatorDelete]
	@TourOperatorID INT
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM TourOperator WHERE TourOperatorID = @TourOperatorID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TourOperatorEdit]
	@ID INT,@OperatorName NVARCHAR(255),@Director NVARCHAR(50),@OperatorLocation NVARCHAR(255),@RequestByURL BIT,@RequestURL NVARCHAR(255),@website NVARCHAR(50),@Tel VARCHAR(50),@skype NVARCHAR(50),@facebook NVARCHAR(50),@email NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE TourOperator
			SET OperatorName = @OperatorName
				,Director = @Director
				,OperatorLocation = @OperatorLocation
				,RequestByURL = @RequestByURL
				,RequestURL = @RequestURL
				,website = @website
				,Tel = @Tel
				,skype = @skype
				,facebook = @facebook
				,email = @email
			WHERE TourOperatorID = @ID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF XACT_STATE() = -1 ROLLBACK;
		THROW
	END CATCH
END
GO