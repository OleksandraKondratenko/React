CREATE PROCEDURE [dbo].[UpdateUser]
	@IsActive bit
AS
	UPDATE [dbo].[Users]
	SET IsActiv=@IsActive
