CREATE DATABASE dbMiPrimerContrato
GO
USE dbMiPrimerContrato
GO
CREATE TABLE tblPersona
(
cedula varchar(10) PRIMARY KEY,
nombre varchar(50),
apellido varchar(50),
tipoPersonal varchar(20),
departamento varchar(20),
titulo varchar(50),
estado varchar(20),
pdf varbinary(MAX)
)