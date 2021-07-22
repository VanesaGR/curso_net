CREATE PROCEDURE EliminarCliente
@Nombre varchar(50)
AS
Delete from Clientes
WHERE @Nombre=Nombre

EXEC EliminarCliente 'PEPE';