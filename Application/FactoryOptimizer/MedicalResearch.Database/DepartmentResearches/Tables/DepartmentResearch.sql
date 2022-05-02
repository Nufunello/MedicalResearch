CREATE TABLE [dbo].[DepartmentResearch]
(
	[ID] INT NOT NULL IDENTITY(1,1),
	[DepartmentID] INT NOT NULL,
	[ResearchID] INT NOT NULL,
	[Cabinet] INT NOT NULL,
	CONSTRAINT [PK_DepartmentResearch] PRIMARY KEY ([ID]),
	CONSTRAINT [FK_DepartmentResearch_Department] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[Department]([ID]),
	CONSTRAINT [FK_DepartmentResearch_Research] FOREIGN KEY ([ResearchID]) REFERENCES [dbo].[Research]([ID])
)
