USE [GT]
GO
/****** Object:  UserDefinedFunction [dbo].[GetTourOperator]    Script Date: 06.09.2017 20:21:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER FUNCTION [dbo].[GetTourOperator]
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