CREATE TABLE [dbo].[DepartmentResearchWorkSchedule]
(
	[ID] INT NOT NULL IDENTITY(1,1),
	[DayOfWeekID] INT NOT NULL,
	[DepartmentResearchID] INT NOT NULL,
	[StartTime] TIME NOT NULL,
	[EndTime] TIME NOT NULL,
	CONSTRAINT [PK_DepartmentResearchWorkSchedule] PRIMARY KEY ([ID]),
	CONSTRAINT [FK_DepartmentResearchWorkSchedule_DayOfWeek] FOREIGN KEY ([DayOfWeekID]) REFERENCES [dbo].[DayOfWeek]([ID]),
	CONSTRAINT [FK_DepartmentResearchWorkSchedule_DepartmentResearch] FOREIGN KEY ([DepartmentResearchID]) REFERENCES [dbo].[DepartmentResearch]([ID])
)
