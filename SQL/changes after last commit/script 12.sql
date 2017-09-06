USE [GT]
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