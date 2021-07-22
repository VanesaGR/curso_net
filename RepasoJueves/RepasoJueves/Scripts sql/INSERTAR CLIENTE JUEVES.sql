CREATE PROCEDURE Insertarcliente
@idcliente varchar(5),
@apellidos varchar(30),
@nombres varchar(30)
AS
INSERT INTO Cliente(IDCLIENTE, APELLIDOS, NOMBRES)
VALUES(@idcliente, @apellidos, @nombres);

EXEC Insertarcliente 'B40', 'SUAREZ RODRIGUEZ', 'SUSANA'
