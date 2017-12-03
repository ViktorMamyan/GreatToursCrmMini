USE [GT]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetAirOperator]
(	

)
RETURNS TABLE 
AS
RETURN 
(
SELECT
  	 AirOperatorID
	,AirOperator
	,ISNULL(Country,N'') Country
	,ISNULL([URL], N'') [URL]
	,ISNULL([Login], N'') [Login]
	,ISNULL([Password], N'') [Password]
	,[Contract]
	,ISNULL(Tel, '') Tel
	,ISNULL(Email, N'') Email
	,ISNULL(website, N'') website
	,ISNULL(FB, N'') FB
	,ISNULL(skype, N'') skype
	,ISNULL(OtherContacts, N'') OtherContacts
  FROM AirOperator
)