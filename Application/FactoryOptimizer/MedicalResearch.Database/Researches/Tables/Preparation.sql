CREATE TABLE [dbo].[Preparation]
(
	[ID] INT NOT NULL IDENTITY(1,1),
	[Name] NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(MAX) NOT NULL,
	CONSTRAINT [PK_Preparation] PRIMARY KEY ([ID])
)
