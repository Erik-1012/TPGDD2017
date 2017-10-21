INSERT INTO Sucursal (nombre, domicilio, codigo_postal, habilitada)

	SELECT DISTINCT

		[Sucursal_Nombre] AS nombre,
		[Sucursal_Direcci�n] AS domicilio,
		[Sucursal_Codigo_Postal] AS codigo_Postal,
		habilitada = 1

	FROM [GD2C2017].[gd_esquema].[Maestra]

	WHERE	Sucursal_Nombre IS NOT NULL AND		/* Hay una fila de sucursal con todos sus campos nulos */
			Sucursal_Direcci�n IS NOT NULL AND
			Sucursal_Codigo_Postal IS NOT NULL