CREATE PROCEDURE [dbo].[GetAllUsers]
AS
	SELECT Id,
	UserName,
	IsActiv
From [dbo].[Users]
