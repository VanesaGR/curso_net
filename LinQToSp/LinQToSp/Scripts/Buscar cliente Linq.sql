CREATE PROCEDURE buscarcliente
@Nombre varchar(50)
AS
SELECT * from Clientes
where Nombre LIKE '%'+@Nombre+'%'

EXEC buscarcliente 'PEPE';