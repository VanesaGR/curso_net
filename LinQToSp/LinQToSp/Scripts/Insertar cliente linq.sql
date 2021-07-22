CREATE PROCEDURE insertarcliente
@nombre varchar(50),
@Apellido1 varchar(50),
@Apellido2 varchar(50),
@telefono varchar(50)
AS
INSERT INTO Clientes(Nombre, Apellido1, Apellido2, Telefono)
VALUES(@nombre, @Apellido1, @Apellido2,@telefono)

EXEC insertarcliente 'PEPE', 'PEREZ', 'PERNIA', '44322343';
EXEC insertarcliente 'PACO', 'FLORES', 'LOPEZ', '98986452';

