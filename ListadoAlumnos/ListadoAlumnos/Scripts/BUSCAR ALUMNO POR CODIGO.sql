CREATE PROCEDURE buscar_codigoAlumno
@codigo int
AS
SELECT * FROM LISTADO_ALUMNOS
WHERE codigo LIKE @codigo;