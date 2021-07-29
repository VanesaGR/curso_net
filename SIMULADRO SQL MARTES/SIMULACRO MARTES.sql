CREATE TABLE comercial(
id int PRIMARY KEY,
nombre varchar(100),
apellido1 varchar(100),
apellido2 varchar(100),
ciudad varchar(100),
comision decimal(2,2),)

CREATE TABLE pedido(
id int PRIMARY KEY,
cantidad decimal(38,2),
fecha date,
id_cliente int,
id_comercial int,)

CREATE TABLE cliente(
id int PRIMARY KEY,
nombre varchar(100),
apellido1 varchar(100),
apellido2 varchar(100),
ciudad varchar(100),
categoria int,)

--MODIFICACION PARA ESTABLECIMIENTO DE FOREIGN KEY--

ALTER TABLE pedido
ADD CONSTRAINT fk_idcomercial
FOREIGN KEY (id_comercial)
REFERENCES comercial (id)

ALTER TABLE pedido
ADD CONSTRAINT fk_idcliente
FOREIGN KEY(id_cliente)
REFERENCES	cliente(id)

--INSERCI�N DE DATOS--

INSERT INTO cliente VALUES(1, 'Aar�n', 'Rivero', 'G�mez', 'Almer�a', 100);
INSERT INTO cliente VALUES(2, 'Adela', 'Salas', 'D�az', 'Granada', 200);
INSERT INTO cliente VALUES(3, 'Adolfo', 'Rubio', 'Flores', 'Sevilla', NULL);
INSERT INTO cliente VALUES(4, 'Adri�n', 'Su�rez', NULL, 'Ja�n', 300);
INSERT INTO cliente VALUES(5, 'Marcos', 'Loyola', 'M�ndez', 'Almer�a', 200);
INSERT INTO cliente VALUES(6, 'Mar�a', 'Santana', 'Moreno', 'C�diz', 100);
INSERT INTO cliente VALUES(7, 'Pilar', 'Ruiz', NULL, 'Sevilla', 300);
INSERT INTO cliente VALUES(8, 'Pepe', 'Ruiz', 'Santana', 'Huelva', 200);
INSERT INTO cliente VALUES(9, 'Guillermo', 'L�pez', 'G�mez', 'Granada', 225);
INSERT INTO cliente VALUES(10, 'Daniel', 'Santana', 'Loyola', 'Sevilla', 125);

INSERT INTO comercial VALUES(1, 'Daniel', 'S�ez', 'Vega', 'Gij�n',  0.15);
INSERT INTO comercial VALUES(2, 'Juan', 'G�mez', 'L�pez', 'Oviedo', 0.13);
INSERT INTO comercial VALUES(3, 'Diego','Flores', 'Salas', 'Avil�s', 0.11);
INSERT INTO comercial VALUES(4, 'Marta','Herrera', 'Gil', 'Mieres', 0.14);
INSERT INTO comercial VALUES(5, 'Antonio','Carretero', 'Ortega', 'El Entrego', 0.12);
INSERT INTO comercial VALUES(6, 'Manuel','Dom�nguez', 'Hern�ndez', 'Madrid', 0.13);
INSERT INTO comercial VALUES(7, 'Antonio','Vega', 'Hern�ndez', 'Sevilla', 0.11);
INSERT INTO comercial VALUES(8, 'Alfredo','Ruiz', 'Flores', 'Llanes', 0.05);

INSERT INTO pedido VALUES(1, 150.5, '2017-10-05', 5, 2);
INSERT INTO pedido VALUES(2, 270.65, '2016-09-10', 1, 5);
INSERT INTO pedido VALUES(3, 65.26, '2017-10-05', 2, 1);
INSERT INTO pedido VALUES(4, 110.5, '2016-08-17', 8, 3);
INSERT INTO pedido VALUES(5, 948.5, '2017-09-10', 5, 2);
INSERT INTO pedido VALUES(6, 2400.6, '2016-07-27', 7, 1);
INSERT INTO pedido VALUES(7, 5760, '2015-09-10', 2, 1);
INSERT INTO pedido VALUES(8, 1983.43, '2017-10-10', 4, 6);
INSERT INTO pedido VALUES(9, 2480.4, '2016-10-10', 8, 3);
INSERT INTO pedido VALUES(10, 250.45, '2015-06-27', 8, 2);
INSERT INTO pedido VALUES(11, 75.29, '2016-08-17', 3, 7);
INSERT INTO pedido VALUES(12, 3045.6, '2017-04-25', 2, 1);
INSERT INTO pedido VALUES(13, 545.75, '2019-01-25', 6, 1);
INSERT INTO pedido VALUES(14, 145.82, '2017-02-02', 6, 1);
INSERT INTO pedido VALUES(15, 370.85, '2019-03-11', 1, 5);
INSERT INTO pedido VALUES(16, 2389.23, '2019-03-11', 1, 5);