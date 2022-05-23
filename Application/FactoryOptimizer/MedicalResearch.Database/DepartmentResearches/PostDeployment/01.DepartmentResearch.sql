SET IDENTITY_INSERT [dbo].[DepartmentResearch] ON

INSERT INTO [dbo].[DepartmentResearch]([ID],[DepartmentID], [ResearchID], [Cabinet])
VALUES
(1, 1, 1, 1),
(2, 1, 5, 5),
(3, 2, 2, 2),
(4, 2, 6, 6),
(5, 3, 3, 3),
(6, 3, 7, 7),
(7, 4, 4, 4),
(8, 4, 8, 8),
(9, 5, 1, 1),
(10, 5, 5, 5),
(11, 6, 2, 2),
(12, 6, 6, 6),
(13, 7, 3, 3),
(14, 7, 7, 7),
(15, 8, 4, 4),
(16, 8, 8, 8),
(17, 9, 1, 1),
(18, 9, 5, 5)

SET IDENTITY_INSERT [dbo].[DepartmentResearch] OFF
GO