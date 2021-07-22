CREATE PROCEDURE modificarcliente
@idcliente varchar(5),
@nombres varchar(30),
@apellidos varchar(30)
AS
UPDATE Cliente
SET @idcliente=idcliente, @nombres=nombres, @apellidos=apellidos
WHERE @nombres=nombres;

EXEC modificarcliente 'B13', 'SOLEDAD', 'PEREZ ALONSO';