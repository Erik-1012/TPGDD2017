CREATE TRIGGER SQL_BOYS.HashUsuariosPassword
ON SQL_BOYS.Usuario
INSTEAD OF INSERT
AS
BEGIN

	INSERT SQL_BOYS.Usuario(username, contraseņa, habilitadx)
		SELECT username, HASHBYTES('SHA2_256', contraseņa), habilitadx
		FROM inserted;

END