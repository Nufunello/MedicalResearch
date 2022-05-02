CREATE TABLE [dbo].[WorkSchedule]
(
	[ID] INT NOT NULL IDENTITY(1,1),
	[DayOfWeekID] INT NOT NULL,
	[DepartmentID] INT NOT NULL,
	[StartTime] TIME NOT NULL,
	[EndTime] TIME NOT NULL,
	CONSTRAINT [PK_WorkSchedule] PRIMARY KEY ([ID]),
	CONSTRAINT [FK_WorkSchedule_DayOfWeek] FOREIGN KEY ([DayOfWeekID]) REFERENCES [dbo].[DayOfWeek]([ID]),
	CONSTRAINT [FK_WorkSchedule_Department] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[Department]([ID])
)
