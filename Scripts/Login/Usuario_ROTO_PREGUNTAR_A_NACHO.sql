CREATE TRIGGER HashUsuariosPassword
ON SQL_BOYS.Usuario
INSTEAD OF INSERT
AS
BEGIN

	INSERT SQL_BOYS.Usuario(username, contrase�a, habilitadx)
		SELECT username, HASHBYTES('SHA2_256', contrase�a), habilitadx
		FROM inserted;

END