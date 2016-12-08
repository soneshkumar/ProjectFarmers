SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('GetSellableInventories','P') IS NULL
BEGIN
	PRINT 'Creating the Procedure dbo.GetSellableInventories'
	
	EXEC('CREATE PROCEDURE dbo.GetSellableInventories AS SET NOCOUNT ON;')
END
GO

PRINT 'Altering the Procedure dbo.GetSellableInventories'
GO

ALTER PROCEDURE [dbo].[GetSellableInventories]
(
	@requestedBy int
)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT
		Id
		, Name
		, ResourceUrl
		, Category
		, SellBy
		, Rate
	FROM dbo.Items WITH (NOLOCK)

	SET NOCOUNT OFF;
END