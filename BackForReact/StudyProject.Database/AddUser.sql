CREATE PROCEDURE [dbo].[AddUser]
	@UserName nvarchar(50),
	@IsActive bit
AS
	INSERT [dbo].[Users](UserName, IsActiv)
	VALUES(@UserName, @IsActive)

