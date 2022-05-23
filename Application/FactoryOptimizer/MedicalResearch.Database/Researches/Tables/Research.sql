CREATE TABLE [dbo].[Research]
(
	[ID] INT NOT NULL IDENTITY(1,1),
	[Name] NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(MAX),
	[DeadlineInDays] INT NOT NULL,
	[Cost] MONEY NOT NULL,
	[GroupResearchID] INT NOT NULL,
	[PreparationDescription] NVARCHAR(MAX) NULL,
	CONSTRAINT [PK_Research] PRIMARY KEY ([ID]),
	CONSTRAINT [FK_Research_GroupResearch] FOREIGN KEY ([GroupResearchID]) REFERENCES [dbo].[GroupResearch]([ID])
)
