USE [GT]
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

ALTER TABLE [dbo].[BonuseCard]  WITH CHECK ADD  CONSTRAINT [FK_BonuseCard_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO

ALTER TABLE [dbo].[BonuseCard] CHECK CONSTRAINT [FK_BonuseCard_Customer]
GO