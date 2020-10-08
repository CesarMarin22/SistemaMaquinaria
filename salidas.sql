create database salidasm;

use salidasm;
 
drop database salidasm;

CREATE TABLE USUARIOS
(
	id_Usuario BIGINT IDENTITY(1,1) NOT NULL,
	nombre varchar(200) NOT NULL,
	usuario varchar(200) NOT NULL,
	contrasena varchar(200) NOT NULL,
	tipo_usuario varchar(200) not null, 
	

	CONSTRAINT PK_Usuarios PRIMARY KEY(id_Usuario)
);

 insert into USUARIOS values('SISTEMAS','SISTEMAS','137946','ADMINISTRADOR');
 insert into USUARIOS values('ROCIO','ROCIO IBETH','M123Q','USUARIO');
 insert into USUARIOS values('MARY','MARY','M456Q','MARY');
 insert into USUARIOS values('CONSULTA','CONSULTA','12345','CONSULTA');
 select * from USUARIOS

CREATE TABLE OBRA
(
	id_Obra BIGINT IDENTITY NOT NULL,
	nombre_obra varchar(200) NOT NULL,
	lugar_obra varchar(200) NOT NULL,
	fecha_inicio varchar(200) not null, 
	fecha_termino varchar(200) not null,
	empresa_factura  varchar(200) NOT NULL,
	estimacion float NOT NULL,
	costo float NOT NULL,
	residente varchar(200) NOT NULL,
	notas varchar(200) NOT NULL,
	cliente_obra varchar(200) NOT NULL,

	CONSTRAINT PK_Obra PRIMARY KEY(id_Obra)
);

SELECT * FROM OBRA
DELETE FROM OBRA
drop table OBRA
select id_Obra, lugar_obra, fecha_inicio, fecha_termino, empresa_factura, estimacion, costo, residente, notas, cliente_obra FROM OBRA where nombre_obra = 'DISTRIBUIDOR'

CREATE TABLE CLIENTE
(
	id_Cliente BIGINT IDENTITY(1,1) NOT NULL,
	nombre_cliente varchar(200) NOT NULL,
	rfc varchar(200) NOT NULL,
	empresa varchar(200) NOT NULL,
	direccion  varchar(200) NOT NULL,
	colonia  varchar(200) NOT NULL,
	cuidad  varchar(200) NOT NULL,
	codigo_postal float NOT NULL,
	telefono float NOT NULL,
	correo varchar(200) NOT NULL,

	CONSTRAINT PK_Cliente PRIMARY KEY(id_Cliente)
);

SELECT * FROM CLIENTE
DELETE FROM CLIENTE

CREATE TABLE MAQUINA
(
	id_Maquina BIGINT IDENTITY(1,1) NOT NULL,
	nombre_maquina varchar(200) NOT NULL,
	marca varchar(200) NOT NULL,
	serie varchar(200) NOT NULL,
	origen  varchar(200) NOT NULL,
	precio  float NOT NULL,
	existe_maquina bit NOT NULL,
	horas_acumuladas int NOT NULL,
	horas_totales int NOT NULL,
	encargado  varchar(200) NOT NULL, 
	categoria varchar(200) NOT NULL

	CONSTRAINT PK_Maquina PRIMARY KEY(id_Maquina)
	
	
);

SELECT * FROM MAQUINA
SELECT * FROM MAQUINA WHERE existe_maquina =1
drop table MAQUINA
select id_Maquina from MAQUINA WHERE nombre_maquina = 'PIPAS'

CREATE TABLE FALLAS
(
	id_Falla BIGINT IDENTITY(1,1) NOT NULL,
	maquina varchar(200) NOT NULL,
	sistema_afectado varchar(200) NOT NULL,
	descripcion  varchar(200) NOT NULL,
	fecha varchar(200) NOT NULL,
	

	CONSTRAINT PK_Falla PRIMARY KEY(id_Falla)
);

SELECT * FROM FALLAS


CREATE TABLE OPERADORES
(
	id_operadores BIGINT IDENTITY(1,1) NOT NULL,
	nombre varchar(200) NOT NULL,
	telefono varchar(200) NOT NULL
	
	CONSTRAINT PK_Operadores PRIMARY KEY(id_operadores)
);

select * from OPERADORES
drop table OPERADORES

CREATE TABLE SALIDAS
(
	id_salidas BIGINT IDENTITY(1,1) NOT NULL,
	id_maquina  BIGINT  NOT NULL,
	nombre_maquinaria varchar(200) NOT NULL,
	nombre_operador varchar(200) NOT NULL,
	fecha_salida varchar(200) NOT NULL,
	fecha_regreso  varchar(200) NOT NULL,
	origen  varchar(200) NOT NULL,
	nombre_obra  varchar(200) NOT NULL,
	cliente varchar(200) NOT NULL,
	categoria varchar(200) NOT NULL,

	
	CONSTRAINT PK_Salidas PRIMARY KEY(id_salidas),
	CONSTRAINT FK_Maquina foreign key (id_Maquina) references MAQUINA (id_Maquina)
);

SELECT * FROM SALIDAS
drop table SALIDAS

SELECT * from SALIDAS s, MAQUINA ma  WHERE s.id_maquina = ma.id_Maquina

CREATE TABLE TIENEN
(
	id_Tienen  BIGINT IDENTITY(1,1) NOT NULL,
	id_Maquina BIGINT NOT NULL,
	id_Falla BIGINT NOT NULL,
	fecha date NOT NULL,

	CONSTRAINT PK_Tienen PRIMARY KEY(id_Tienen)
);
CREATE TABLE PIZARRON
(
	id_Pizarron BIGINT IDENTITY(1,1) NOT NULL,
	id_Maquina  BIGINT NOT NULL,
	id_salidas  BIGINT NOT NULL,
	CONSTRAINT PK_Pizarron PRIMARY KEY(id_Pizarron),
	CONSTRAINT FK_Maquina foreign key (id_Maquina) references MAQUINA (id_Maquina),
	CONSTRAINT FK_Salidas foreign key (id_salidas) references SALIDAS (id_salidas)
);

SELECT * FROM PIZARRON
drop table PIZARRON

SELECT pizza.id_Pizarron, ma.id_Maquina, sa.id_salidas, ma.nombre_maquina, sa.nombre_obra, ma.origen, sa.fecha_salida, sa.fecha_regreso, ma.encargado, sa.nombre_operador, ma.categoria 
FROM PIZARRON pizza, MAQUINA ma, SALIDAS sa
WHERE pizza.id_Maquina = ma.id_Maquina and pizza.id_salidas = sa.id_salidas
 


CREATE TABLE HORAS_MAQUINA
(
	id_Horas_Maquina BIGINT IDENTITY(1,1) NOT NULL,
	maquina varchar(200) NOT NULL,
	horas_trabajadas int NOT NULL,
	horas_acumuladas int NOT NULL,
	horas_totales int NOT NULL,
	fecha_inicio varchar(200) NOT NULL,
	fecha_finales varchar(200) NOT NULL,
	servicio bit NOT NULL,
	notas varchar NOT NULL,	

	CONSTRAINT PK_Horas PRIMARY KEY(id_Horas_Maquina)
);

 select * from HORAS_MAQUINA
 select * from pizarron
 drop table HORAS_MAQUINA


 INSERT INTO OBRA(id_Obra, nombre_obra, lugar_obra, fecha_inicio, fecha_termino, empresa_factura, estimacion, costo, residente, notas, cliente_obra) VALUES('2222','DISTRIBUIDOR','SAN LUIS POTOSI','22-05-2020','01-06-2020','Argufer Grupo Constructor','25000','35000','Gerardo Alonso Perez','PRUEBA1','Cesar Cardona')

 SELECT ma.serie, ma.nombre_maquina, s.nombre_obra, ma.origen, s.fecha_salida, s.fecha_regreso, ma.encargado, s.nombre_operador, ma.categoria from SALIDAS s, MAQUINA ma  WHERE s.id_maquina = ma.id_Maquina and ma.categoria='TRACTORES'