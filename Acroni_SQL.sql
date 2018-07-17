CREATE DATABASE ACRONI_SQL
GO
USE ACRONI_SQL
GO
CREATE TABLE tblCliente (
	usuario VARCHAR(30),
	senha VARCHAR(30),
	email VARCHAR(50) PRIMARY KEY
)
GO
INSERT INTO tblCliente VALUES ('Mota','oi','jota@jot.com')
SELECT * FROM tblCliente WHERE usuario='Mota'

UPDATE tblCliente SET usuario = 'Mota',senha = 'oimota' WHERE email = 'oimota@gmail.com'