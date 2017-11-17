/*

INSERT INTO Usuario (username, contrase�a, habilitadx) values

	('admin',			'w23e',				1),
	('cobrador1',		'cobrador',			1),
	('cobrador2',		'cobrador',			1),
	('cobrador3',		'cobrador',			1),
	('cobrador4',		'cobrador',			1),
	('deshabilitado',	'deshabilitado',	0),
	('a',				'a',				1)

*/

INSERT INTO SQL_BOYS.Usuario (username, contrase�a, habilitadx) values 

	('cobrador1',		'fda9be620062a617156c1c6dbc788a6a204f85fe06e8ead0e3a43817b0e382db', 1),		-- Password: cobrador
	('cobrador2',		'fda9be620062a617156c1c6dbc788a6a204f85fe06e8ead0e3a43817b0e382db', 1),		-- Password: cobrador
	('cobrador3',		'fda9be620062a617156c1c6dbc788a6a204f85fe06e8ead0e3a43817b0e382db', 1),		-- Password: cobrador
	('cobrador4',		'fda9be620062a617156c1c6dbc788a6a204f85fe06e8ead0e3a43817b0e382db', 1),		-- Password: cobrador
	('deshabilitado',	'68de79aa60784d315201bac92fedae8297eed7c10f105b1e7704bd193244e27b', 0),		-- Password: deshabilitado
	('a',				'ca978112ca1bbdcafac231b39a23dc4da786eff8147c4e72b9807785afee48bb', 1)		-- Password: a

GO

CREATE FUNCTION SQL_BOYS.obtenerUsuario(@nombre nvarchar(255))
RETURNS table

	return (
	
		select u.* from SQL_BOYS.Usuario u
			where u.username = @nombre

	)

GO

/*Puede ser que esto no se use - AVERIGUAR*/
/*CREATE TRIGGER HashUsuariosPassword
ON SQL_BOYS.Usuario
INSTEAD OF INSERT
AS
BEGIN

	INSERT SQL_BOYS.Usuario(username, contrase�a, habilitadx)
		SELECT username, HASHBYTES('SHA2_256', contrase�a), habilitadx
		FROM inserted;

END*/