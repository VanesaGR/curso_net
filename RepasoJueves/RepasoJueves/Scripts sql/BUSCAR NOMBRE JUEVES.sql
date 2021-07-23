CREATE PROCEDURE BUSCAR_NOMBRE
@nombre varchar(30)
AS
SELECT * from Cliente
where NOMBRES LIKE @nombre