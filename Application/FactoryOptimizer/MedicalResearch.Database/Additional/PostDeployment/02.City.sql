SET IDENTITY_INSERT [dbo].[City] ON

INSERT INTO [dbo].[City] ([ID], [RegionID], [Name])
VALUES
(1, 2, N'Дрогобич'),
(2, 2, N'Львів'),
(3, 2, N'Моршин'),
(4, 2, N'Новояворівськ'),
(5, 2, N'Самбір'),
(6, 2, N'Стрий'),
(7, 2, N'Трускавець'),
(8, 1, N'Новоселиця'),
(9, 1, N'Сторожинець'),
(10, 1, N'Чернівці')

SET IDENTITY_INSERT [dbo].[City] OFF
GO