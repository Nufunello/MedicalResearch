﻿CREATE TABLE [dbo].[DayOfWeek]
(
	[ID] INT NOT NULL IDENTITY(1,1),
	[Name] NVARCHAR(50) NOT NULL,
	CONSTRAINT [PK_DayOfWeek] PRIMARY KEY ([ID])
)
