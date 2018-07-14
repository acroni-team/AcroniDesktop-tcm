CREATE DATABASE ACRONI_SQL
GO
USE ACRONI_SQL
GO
CREATE TABLE tblCliente (
	usuario VARCHAR(30),
	senha VARCHAR(30),
	email VARCHAR(50)
)
GO
INSERT INTO tblCliente VALUES ('Mota','oi','jota@jot.com')
SELECT senha FROM tblCliente WHERE usuario='Mota'