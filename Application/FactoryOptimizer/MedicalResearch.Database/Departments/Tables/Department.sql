CREATE TABLE [dbo].[Department]
(
	[ID] INT NOT NULL IDENTITY(1,1),
	[CityID] INT NOT NULL,
	[Street] NVARCHAR(255) NOT NULL,
	[Building] NVARCHAR(50) NOT NULL,
	[PhoneNumber] NVARCHAR(13) NOT NULL,
	CONSTRAINT [PK_Department] PRIMARY KEY ([ID]),
	CONSTRAINT [FK_Department_City] FOREIGN KEY ([CityID]) REFERENCES [dbo].[City]([ID])
)
