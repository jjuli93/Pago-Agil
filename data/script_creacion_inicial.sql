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
		Nombre nvarchar(255),
		Direccion nvarchar(255),
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
		Nombre nvarchar(255),
		Apellido nvarchar(255),
		DNI numeric(18,0),
		Mail nvarchar(255),
		--Telefono varchar(10),
		Direccion nvarchar(255),
		CodigoPostal nvarchar(4),
		FechaNacimiento datetime,
		Habilitado varchar(1),
		PRIMARY KEY(IdCliente),
	);
END


-- Medios de Pago
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'MediosPago' ))
BEGIN
	CREATE TABLE [SistemaCaido].MediosPago (
		IdMedioPago int NOT NULL identity(1,1),
		Nombre nvarchar(255),
		PRIMARY KEY(IdMedioPago),
	);
END


-- Pagos
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'Pagos' ))
BEGIN
	CREATE TABLE [SistemaCaido].Pagos(
		IdPago int NOT NULL identity(1,1),
		FechaCobro datetime,
		IdCliente int,
		Importe numeric(18,2),
		IdSucursal int,
		IdMedioPago int,
		PRIMARY KEY(IdPago),
		FOREIGN KEY(IdCliente) REFERENCES [SistemaCaido].Clientes,
		FOREIGN KEY(IdSucursal) REFERENCES [SistemaCaido].Sucursales,
		FOREIGN KEY(IdMedioPago) REFERENCES [SistemaCaido].MediosPago,
	);
END


-- Rubros
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'Rubros' ))
BEGIN
	CREATE TABLE [SistemaCaido].Rubros(
		IdRubro int NOT NULL identity(1,1),
		Nombre nvarchar(255),
		PRIMARY KEY(IdRubro),
	);
END


-- Empresas
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'Empresas' ))
BEGIN
	CREATE TABLE [SistemaCaido].Empresas(
		IdEmpresa int NOT NULL identity(1,1),
		Nombre nvarchar(255),
		CUIT nvarchar(50),
		Direccion nvarchar(255),
		IdRubro int,
		Habilitada char,
		PRIMARY KEY(IdEmpresa),
		FOREIGN KEY(IdRubro) REFERENCES [SistemaCaido].Rubros, 
	);
END


-- Facturas
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'Facturas' ))
BEGIN
	CREATE TABLE [SistemaCaido].Facturas(
		IdFactura int NOT NULL identity(1,1),
		IdCliente int,
		IdEmpresa int,
		NumeroFactura numeric(18,0),
		FechaAlta datetime,
		FechaVencimiento datetime,
		Importe numeric(18,2),
		PRIMARY KEY(IdFactura),
		FOREIGN KEY(IdCliente) REFERENCES [SistemaCaido].Clientes,
		FOREIGN KEY(IdEmpresa) REFERENCES [SistemaCaido].Empresas,
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


-- Migracion de Datos
GO

/* Usuarios */
INSERT INTO [SistemaCaido].Usuarios VALUES('Admin', 'w23e')

/* Roles */
INSERT INTO [SistemaCaido].Roles VALUES('Administrador')
INSERT INTO [SistemaCaido].Roles VALUES('Cobrador')

/* Funcionalidades */
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('ABM de Rol')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('Registro de Usuario')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('ABM de Cliente')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('ABM de Empresa')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('ABM de Sucursal')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('ABM de Facturas')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('Registro de Pago de Facturas')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('Rendicion de Facturas Cobradas')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('Listado Estadistico')

/* Clientes */
INSERT INTO [SistemaCaido].Clientes (Nombre, Apellido, DNI, Mail, Direccion, CodigoPostal, FechaNacimiento, Habilitado)
SELECT DISTINCT [Cliente-Nombre], [Cliente-Apellido], [Cliente-Dni], Cliente_Mail, 
				Cliente_Direccion, Cliente_Codigo_Postal, [Cliente-Fecha_Nac], 1
FROM gd_esquema.Maestra WHERE [Cliente-Apellido] + [Cliente-Nombre] IS NOT NULL

/* Rubros */
INSERT INTO [SistemaCaido].Rubros (Nombre)
SELECT DISTINCT Rubro_Descripcion FROM gd_esquema.Maestra WHERE Rubro_Descripcion IS NOT NULL

/* Empresas */
INSERT INTO [SistemaCaido].Empresas (Nombre, CUIT, Direccion, IdRubro, Habilitada)
SELECT DISTINCT Empresa_Nombre, Empresa_Cuit, Empresa_Direccion, Empresa_Rubro, 1 
FROM gd_esquema.Maestra WHERE Empresa_Nombre IS NOT NULL

/* Sucursales */
INSERT INTO [SistemaCaido].Sucursales (Nombre, Direccion, CodigoPostal, Habilitada)
SELECT DISTINCT Sucursal_Nombre, Sucursal_Dirección, Sucursal_Codigo_Postal, 1
FROM gd_esquema.Maestra WHERE Sucursal_Nombre IS NOT NULL


/*
DROP TABLE [SistemaCaido].RolesXFuncionalidades
DROP TABLE [SistemaCaido].UsuariosXRoles
DROP TABLE [SistemaCaido].Roles
DROP TABLE [SistemaCaido].Funcionalidades
DROP TABLE [SistemaCaido].Usuarios
DROP TABLE [SistemaCaido].Empresas
DROP TABLE [SistemaCaido].Sucursales
DROP TABLE [SistemaCaido].Clientes
DROP TABLE [SistemaCaido].MediosPago
DROP TABLE [SistemaCaido].Pagos
DROP TABLE [SistemaCaido].Rubros
DROP TABLE [SistemaCaido].Facturas
DROP SCHEMA [SistemaCaido]
*/
