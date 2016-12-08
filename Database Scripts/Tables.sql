SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('Items','U') IS NULL
BEGIN
	PRINT 'Creating Table dbo.Items'
	
	CREATE TABLE [dbo].[Items](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Name] [nvarchar](256) NOT NULL,
		[ResourceUrl] [nvarchar](1024) NOT NULL,
		[Category] [int] NOT NULL,
		[SellBy] [int] NOT NULL,
		[Rate] [decimal](10, 2) NOT NULL
		CONSTRAINT [dbo.PK_Items] PRIMARY KEY CLUSTERED 
		(
			[Name] ASC
		)
	)
END

GO

IF OBJECT_ID('Items_Audit','U') IS NULL
BEGIN
	PRINT 'Creating Table dbo.Items_Audit'
	
	CREATE TABLE [dbo].[Items_Audit](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Name] [nvarchar](256) NOT NULL,
		[ResourceUrl] [nvarchar](1024) NOT NULL,
		[Category] [int] NOT NULL,
		[SellBy] [int] NOT NULL,
		[Rate] [decimal](10, 2) NOT NULL,
		[Action] [tinyint] NOT NULL,
		[ModifiedBy] [nvarchar](128) NOT NULL,
		[ModifiedDateTime] [datetime] NOT NULL DEFAULT (GETUTCDATE())
		CONSTRAINT [dbo.PK_Items_Audit] PRIMARY KEY CLUSTERED 
		(
			[Id] ASC
		)
	)
END

GO