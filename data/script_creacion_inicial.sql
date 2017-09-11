USE GD2C2017

-- Creacion de Esquema
GO
CREATE SCHEMA [SistemaCaido];

GO
-- Creacion de Tablas
-- Funcionalidades
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'Funcionalidades' ))
BEGIN
	CREATE TABLE [SistemaCaido].Funcionalidades(
		IdFuncionalidades int NOT NULL identity(1,1),
		Nombre varchar(30),
		PRIMARY KEY(IdFuncionalidades),
	);
END

-- Roles
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'Roles' ))

BEGIN
	CREATE TABLE [SistemaCaido].Roles(
		IdRol int NOT NULL identity(1,1),
		Nombre varchar(30),
		PRIMARY KEY(IdRol),
	);
END

-- Usuarios
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'Usuarios' ))
BEGIN
	CREATE TABLE [SistemaCaido].Usuarios(
		IdUsuario int NOT NULL identity(1,1),
		Username varchar(10),
		Password varchar(10),
		PRIMARY KEY(IdUsuario),
	);
END

-- Sucursales
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'Sucursales' ))
BEGIN
	CREATE TABLE [SistemaCaido].Sucursales(
		IdSucursal int NOT NULL identity(1,1),
		Nombre varchar(10),
		Direccion varchar(10),
		CodigoPostal varchar(4),
		Habilitada char,
		PRIMARY KEY(IdSucursal),
	);
END


-- Clientes
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'Clientes' ))
BEGIN
	CREATE TABLE [SistemaCaido].Clientes(
		IdCliente int NOT NULL identity(1,1),
		Nombre varchar(10),
		Apellido varchar(10),
		DNI varchar(10),
		Mail varchar(10),
		Telefono varchar(10),
		Direccion varchar(10),
		CodigoPostal varchar(10),
		FechaNacimiento varchar(10),
		Habilitado varchar(1),
		PRIMARY KEY(IdCliente),
	);
END


-- RolesXFuncionalidades
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'RolesXFuncionalidades' ))
BEGIN
	CREATE TABLE [SistemaCaido].RolesXFuncionalidades(
		IdRol int,
		IdFuncionalidades int,
		PRIMARY KEY(IdRol, IdFuncionalidades),
		FOREIGN KEY(IdRol) REFERENCES [SistemaCaido].Roles,
		FOREIGN KEY(IdFuncionalidades) REFERENCES [SistemaCaido].Funcionalidades,
	);
END

-- UsuariosXRoles
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'UsuariosXRoles' ))
BEGIN
	CREATE TABLE [SistemaCaido].UsuariosXRoles(
		IdUsuario int,
		IdRol int,
		PRIMARY KEY(IdUsuario, IdRol),
		FOREIGN KEY(IdUsuario) REFERENCES [SistemaCaido].Usuarios,
		FOREIGN KEY(IdRol) REFERENCES [SistemaCaido].Roles,

	);
END

/*
DROP TABLE [SistemaCaido].Funcionalidades
DROP TABLE [SistemaCaido].Roles
DROP TABLE [SistemaCaido].RolesXFuncionalidades
DROP TABLE [SistemaCaido].Usuarios
DROP TABLE [SistemaCaido].Sucursales
DROP TABLE [SistemaCaido].Clientes
DROP TABLE [SistemaCaido].UsuariosXRoles
*/

