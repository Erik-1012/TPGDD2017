CREATE TRIGGER dbo.HashUsuariosPassword
ON dbo.Usuario
INSTEAD OF INSERT
AS
BEGIN

	INSERT dbo.Usuario(username, contrase�a, habilitadx)
		SELECT username, HASHBYTES('SHA2_256', contrase�a), habilitadx
		FROM inserted;

END