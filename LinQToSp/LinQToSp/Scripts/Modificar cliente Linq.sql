CREATE PROCEDURE modificarcliente
@nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@telefono varchar(50)
AS
UPDATE Clientes
SET Nombre=@nombre, Apellido1=@Apellido1, @Apellido2=@Apellido2, Telefono=@telefono
WHERE Nombre=@nombre

EXEC modificarcliente 'PEPE', 'GANDALF', 'EL GRIS', 'XXXXXXXX';