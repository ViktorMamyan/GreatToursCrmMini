USE [GT]
GO

/****** Object:  Table [dbo].[Insurance]    Script Date: 19.12.2017 11:27:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Insurance](
	[InsuranceID] [int] IDENTITY(1,1) NOT NULL,
	[CreationDate] [date] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[ClientID] [int] NOT NULL,
	[Price] [decimal](12, 0) NOT NULL,
	[Cost] [decimal](12, 0) NULL,
	[ReturnableDate] [date] NULL,
 CONSTRAINT [PK_Insurance] PRIMARY KEY CLUSTERED 
(
	[InsuranceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Insurance]  WITH CHECK ADD  CONSTRAINT [FK_Insurance_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO

ALTER TABLE [dbo].[Insurance] CHECK CONSTRAINT [FK_Insurance_Client]
GO