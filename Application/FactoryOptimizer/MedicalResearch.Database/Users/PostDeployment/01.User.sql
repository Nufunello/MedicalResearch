SET IDENTITY_INSERT [dbo].[User] ON
INSERT INTO [dbo].[User]([ID], [Email], [Password], [CanChange])
VALUES
(2,
'admin1!@gmail.com',
'nq2FMslb87OJZ2CTbH0FzX5myrc=',
1)
SET IDENTITY_INSERT [dbo].[User] OFF
GO