USE [GT]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Ticket](
	[TicketID] [int] IDENTITY(1,1) NOT NULL,
	[CreationDate] [date] NOT NULL,
	[ReservNumber] [nvarchar](50) NOT NULL,
	[FromAirportID] [int] NOT NULL,
	[ToAirportID] [int] NOT NULL,
	[FlyDayTime] [datetime2](0) NOT NULL,
	[WithReturn] [bit] NOT NULL,
	[ReturnFlyDayTime] [datetime2](0) NULL,
	[Price] [decimal](12, 0) NOT NULL,
	[Cost] [decimal](12, 0) NULL,
	[CustomerID] [int] NOT NULL,
	[AdultCount] [tinyint] NOT NULL,
	[ChildCount] [tinyint] NULL,
	[BabyCount] [tinyint] NULL,
	[ChildYearsComment] [nvarchar](50) NULL,
	[OperatorID] [int] NULL,
	[PaymaetDeathLine] [date] NULL,
	[PrePayPrice] [decimal](12, 0) NULL,
	[NextPayDate] [date] NULL,
	[IsTotalyPayed] [bit] NOT NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[TicketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Airport] FOREIGN KEY([FromAirportID])
REFERENCES [dbo].[Airport] ([AirportID])
GO

ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Airport]
GO

ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Airport1] FOREIGN KEY([ToAirportID])
REFERENCES [dbo].[Airport] ([AirportID])
GO

ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Airport1]
GO

ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO

ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Customer]
GO

ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_TourOperator] FOREIGN KEY([OperatorID])
REFERENCES [dbo].[TourOperator] ([TourOperatorID])
GO

ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_TourOperator]
GO