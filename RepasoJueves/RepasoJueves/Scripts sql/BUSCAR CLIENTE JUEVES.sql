CREATE PROCEDURE buscarCliente
@idcliente varchar(5)
AS
SELECT * from Cliente
where IDCLIENTE LIKE @idcliente

