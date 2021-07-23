CREATE PROCEDURE MostrarClientes
@idcliente varchar(5)
AS
SELECT *
FROM CLIENTE
WHERE cliente.idcliente=@idcliente;


