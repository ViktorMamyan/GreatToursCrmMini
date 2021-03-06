USE [GT]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[TourEdit]
		 @TourID INT,@TourName NVARCHAR(50),@TourStartDate DATE,@TourEndDate DATE,@DirectionID INT
		,@OperatorID INT,@CustomerID INT,@Price DECIMAL(12,0),@Cost DECIMAL(12,0)
		,@UseBonusCard BIT,@AddBouns BIT,@Card NVARCHAR(50),@Points INT,@ByAnotherCustomer BIT
		,@AdultCount TINYINT,@ChildCount TINYINT,@BabyCount TINYINT,@ChildYearsComment NVARCHAR(255)
		,@PaymaetDeathLine DATE,@PrePayPrice DECIMAL(12,0),@NextPayDate DATE,@IsTotalyPayed BIT
		,@HotelList NVARCHAR(MAX),@TicketList NVARCHAR(MAX),@InsuranceList NVARCHAR(MAX)
		,@Excursion NVARCHAR(50),@VIsa NVARCHAR(50),@Transfer NVARCHAR(50),@TourType NVARCHAR(50)
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
				,Price = @Price
				,Cost = @Cost
				,AdultCount = @AdultCount
				,ChildCount = @ChildCount
				,BabyCount = @BabyCount
				,ChildYearsComment = @ChildYearsComment
				,PaymaetDeathLine = @PaymaetDeathLine
				,PrePayPrice = @PrePayPrice
				,NextPayDate = @NextPayDate
				,IsTotalyPayed = @IsTotalyPayed
				,HotelList = @HotelList
				,TicketList = @TicketList
				,InsuranceList = @InsuranceList
				,Excursion = @Excursion
				,VIsa = @VIsa
				,[Transfer] = @Transfer
				,TourType = @TourType
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