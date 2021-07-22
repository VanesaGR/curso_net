CREATE PROCEDURE EliminarCliente
@apellidos varchar(30)
AS
Delete from Cliente
WHERE @apellidos = Apellidos


EXEC EliminarCliente 'PEREZ PEREZ';