﻿SET IDENTITY_INSERT [dbo].[Research] ON

INSERT INTO [dbo].[Research] ([ID], [GroupResearchID],[PreparationDescription], [Name], [Description], [DeadlineInDays], [Cost])
VALUES
(1, 1, N'Для виключення факторів, які можуть впливати на результати дослідження, необхідно дотримуватися наступних правил підготовки:
важливою умовою для лабораторних досліджень є здача крові натщесерце — 6 -12 годинний період голодування.
В день дослідження допустимо вживання невеликої кількості води.
за 6 — 12 годин до дослідження слід виключити прийом алкоголю, куріння, прийом їжі, обмежити фізичну активність.
виключити прийом ліків, якщо відмінити прийом ліків неможливо, необхідно проінформувати про це лабораторію.
дітей до 5 років, перед здачею крові, бажано поїти кип’яченою водою (порціями до 150–200 мл., протягом 30 хвилин).
для грудних дітей — перед здачею крові витримати максимально можливу паузу між годуваннями.', N'Аналіз крові загальний (12 показників)', NULL, 1, 120),
(2, 1, N'Для виключення факторів, які можуть впливати на результати дослідження, необхідно дотримуватися наступних правил підготовки:
важливою умовою для лабораторних досліджень є здача крові натщесерце — 6 -12 годинний період голодування.
В день дослідження допустимо вживання невеликої кількості води.
за 6 — 12 годин до дослідження слід виключити прийом алкоголю, куріння, прийом їжі, обмежити фізичну активність.
виключити прийом ліків, якщо відмінити прийом ліків неможливо, необхідно проінформувати про це лабораторію.
дітей до 5 років, перед здачею крові, бажано поїти кип’яченою водою (порціями до 150–200 мл., протягом 30 хвилин).
для грудних дітей — перед здачею крові витримати максимально можливу паузу між годуваннями.', N'Розгорнутий аналіз крові', N'(загальний аналіз крові, ШОЕ, лейкоцитарна формула)', 1, 160),
(3, 1, N'Після сну повинно пройти не більше 2 годин, кров здавати вранці в стані спокою, перед дослідженням виключить пальпацію молочних залоз.', N'Загальний аналіз ліквору', NULL, 1, 200),
(4, 1, N'Після сну повинно пройти не більше 2 годин, кров здавати вранці в стані спокою, перед дослідженням виключить пальпацію молочних залоз.', N'Аналіз плевральної рідини', NULL, 1, 220),
(5, 2, N'Для виключення факторів, які можуть впливати на результати дослідження, необхідно дотримуватися наступних правил підготовки:
важливою умовою для лабораторних досліджень є здача крові натщесерце — 6 -12 годинний період голодування.
В день дослідження допустимо вживання невеликої кількості води.
за 6 — 12 годин до дослідження слід виключити прийом алкоголю, куріння, прийом їжі, обмежити фізичну активність.
виключити прийом ліків, якщо відмінити прийом ліків неможливо, необхідно проінформувати про це лабораторію.
дітей до 5 років, перед здачею крові, бажано поїти кип’яченою водою (порціями до 150–200 мл., протягом 30 хвилин).
для грудних дітей — перед здачею крові витримати максимально можливу паузу між годуваннями.', N'pH крові', NULL, 1, 70),
(6, 2, N'Для виключення факторів, які можуть впливати на результати дослідження, необхідно дотримуватися наступних правил підготовки:
важливою умовою для лабораторних досліджень є здача крові натщесерце — 6 -12 годинний період голодування.
В день дослідження допустимо вживання невеликої кількості води.
за 6 — 12 годин до дослідження слід виключити прийом алкоголю, куріння, прийом їжі, обмежити фізичну активність.
виключити прийом ліків, якщо відмінити прийом ліків неможливо, необхідно проінформувати про це лабораторію.
дітей до 5 років, перед здачею крові, бажано поїти кип’яченою водою (порціями до 150–200 мл., протягом 30 хвилин).
для грудних дітей — перед здачею крові витримати максимально можливу паузу між годуваннями.', N'Глюкоза', NULL, 1, 90),
(7, 2, N'Після сну повинно пройти не більше 2 годин, кров здавати вранці в стані спокою, перед дослідженням виключить пальпацію молочних залоз.', N'Фібротест', NULL, 5, 2800), 
(8, 2, N'Після сну повинно пройти не більше 2 годин, кров здавати вранці в стані спокою, перед дослідженням виключить пальпацію молочних залоз.', N'Гастрин', NULL, 1, 240)

SET IDENTITY_INSERT [dbo].[Research] OFF
GO