CREATE PROCEDURE [dbo].[UpdateUser]
@UserID int,
	@IsActive bit
AS
	UPDATE [dbo].[Users]
	SET IsActiv=@IsActive
	Where Id=@UserID
