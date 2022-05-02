SET IDENTITY_INSERT [dbo].[DayOfWeek] ON
INSERT INTO [dbo].[DayOfWeek]([ID], [Name])
VALUES
(1, N'Понеділок'),
(2, N'Вівторок'),
(3, N'Середа'),
(4, N'Четвер'),
(5, N'Пятниця'),
(6, N'Субота'),
(7, N'Неділя')
SET IDENTITY_INSERT [dbo].[DayOfWeek] OFF