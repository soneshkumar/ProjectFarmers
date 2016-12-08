SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('Trigger_Items','TR') IS NOT NULL
BEGIN
	DROP TRIGGER Trigger_Items;
END
GO

PRINT 'Creating Trigger Trigger_Items on table dbo.Items'
GO

CREATE TRIGGER [dbo].[Trigger_Items] ON [dbo].[Items] 
AFTER INSERT, DELETE, UPDATE
AS
BEGIN
	INSERT INTO [dbo].[Items_Audit](
		Name
		, ResourceUrl
		, Category
		, SellBy
		, Rate
		, [Action]
		, ModifiedBy
		, ModifiedDateTime
	)
	SELECT
		I.Name
		, I.ResourceUrl
		, I.Category
		, I.SellBy
		, I.Rate
		, CASE WHEN EXISTS (SELECT * FROM deleted D WHERE D.Name = I.Name) THEN 3 ELSE 1 END
		, SUSER_SNAME()
		, GETUTCDATE()
	FROM inserted I

	INSERT INTO [dbo].[Items_Audit](
		Name
		, ResourceUrl
		, Category
		, SellBy
		, Rate
		, [Action]
		, ModifiedBy
		, ModifiedDateTime
	)
	SELECT
		D.Name
		, D.ResourceUrl
		, D.Category
		, D.SellBy
		, D.Rate
		, 2
		, SUSER_SNAME()
		, GETUTCDATE()
	FROM deleted D LEFT JOIN inserted I ON D.Name = I.Name
	WHERE I.Id IS NULL
END

