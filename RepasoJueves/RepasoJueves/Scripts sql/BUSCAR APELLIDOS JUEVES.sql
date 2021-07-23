CREATE PROCEDURE BUSCAR_NOMBRE
@apellidos varchar(30)
AS
SELECT * from Cliente
where APELLIDOS LIKE @apellidos