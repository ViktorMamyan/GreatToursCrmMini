USE [GT]
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