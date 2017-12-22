USE GT
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE HotelsUpdate
	@HotelID INT,@HotelName NVARCHAR(255),@CountryID INT,@Region NVARCHAR(255),@Stars TINYINT,@HotelTypeID INT
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Hotels
		SET HotelName = @HotelName
			,CountryID = @CountryID
			,Region = @Region
			,Stars = @Stars
			,HotelTypeID = @HotelTypeID
	WHERE HotelID = @HotelID
END
GO