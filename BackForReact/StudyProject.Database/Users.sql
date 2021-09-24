CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [UserName] NVARCHAR(50) NULL, 
    [IsActiv] BIT NULL
)
