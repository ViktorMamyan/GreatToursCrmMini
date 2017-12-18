USE [GT]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UtilityExpense](
	[UtilExpID] [int] IDENTITY(1,1) NOT NULL,
	[CreationDate] [date] NOT NULL,
	[Fee] [decimal](12, 0) NOT NULL,
	[ForYear] [smallint] NOT NULL,
	[ForMonth] [tinyint] NOT NULL,
	[UtilityTypeID] [int] NOT NULL,
 CONSTRAINT [PK_UtilityExpense] PRIMARY KEY CLUSTERED 
(
	[UtilExpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[UtilityExpense]  WITH CHECK ADD  CONSTRAINT [FK_UtilityExpense_UtilityType] FOREIGN KEY([UtilityTypeID])
REFERENCES [dbo].[UtilityType] ([UtilityTypeID])
GO

ALTER TABLE [dbo].[UtilityExpense] CHECK CONSTRAINT [FK_UtilityExpense_UtilityType]
GO