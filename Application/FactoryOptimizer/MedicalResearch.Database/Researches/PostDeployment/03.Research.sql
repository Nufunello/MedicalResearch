SET IDENTITY_INSERT [dbo].[Research] ON
INSERT INTO [dbo].[Research] ([ID], [GroupResearchID], [PreparationID], [Name], [Description], [DeadlineInDays], [Cost])
VALUES
(1, 1, 1, N'Аналіз крові загальний (12 показників)', NULL, 1, 120),
(2, 1, 1, N'Розгорнутий аналіз крові', N'(загальний аналіз крові, ШОЕ, лейкоцитарна формула)', 1, 160),
(3, 1, 2, N'Загальний аналіз ліквору', NULL, 1, 200),
(4, 1, 2, N'Аналіз плевральної рідини', NULL, 1, 220),
(5, 2, 1, N'pH крові', NULL, 1, 70),
(6, 2, 1, N'Глюкоза', NULL, 1, 90),
(7, 2, 2, N'Фібротест', NULL, 5, 2800), 
(8, 2, 2, N'Гастрин', NULL, 1, 240)
SET IDENTITY_INSERT [dbo].[Research] OFF