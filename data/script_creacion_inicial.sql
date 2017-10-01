USE GD2C2017
GO

--=============================================================================================================--
--*************************************** Dropeos ************************************************--                                 
--=============================================================================================================--

IF EXISTS (SELECT name FROM sysobjects WHERE name='existeRolConMismoNombre' AND type in ( N'FN', N'IF', N'TF', N'FS', N'FT' ))
	DROP FUNCTION [SistemaCaido].existeRolConMismoNombre
IF EXISTS (SELECT name FROM sysobjects WHERE name='existeUsuario' AND type in ( N'FN', N'IF', N'TF', N'FS', N'FT' ))
	DROP FUNCTION [SistemaCaido].existeUsuario
IF EXISTS (SELECT name FROM sysobjects WHERE name='usuarioActivo' AND type in ( N'FN', N'IF', N'TF', N'FS', N'FT' ))
	DROP FUNCTION [SistemaCaido].usuarioActivo


IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_get_clientes' AND type='p')
	DROP PROCEDURE [SistemaCaido].sp_get_clientes
IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_get_funcionalidades' AND type='p')
	DROP PROCEDURE [SistemaCaido].sp_get_funcionalidades
IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_get_funcionalidades_rol' AND type='p')
	DROP PROCEDURE [SistemaCaido].sp_get_funcionalidades_rol
IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_obtenerPorcentajeActual' AND type='p')
	DROP PROCEDURE [SistemaCaido].sp_obtenerPorcentajeActual
IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_baja_cliente' AND type='p')
	DROP PROCEDURE [SistemaCaido].sp_baja_cliente
IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_update_cliente' AND type='p')
	DROP PROCEDURE [SistemaCaido].sp_update_cliente
IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_alta_cliente' AND type='p')
	DROP PROCEDURE [SistemaCaido].sp_alta_cliente
IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_get_roles_usuario' AND type='p')
	DROP PROCEDURE [SistemaCaido].sp_get_roles_usuario
IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_login_check' AND type='p')
	DROP PROCEDURE [SistemaCaido].sp_login_check
IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_incrementar_intentos_fallidos' AND type='p')
	DROP PROCEDURE [SistemaCaido].sp_incrementar_intentos_fallidos
IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_limpiar_intentos_fallidos' AND type='p')
    DROP PROCEDURE [SistemaCaido].sp_limpiar_intentos_fallidos
IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_get_roles' AND type='p')
	DROP PROCEDURE [SistemaCaido].sp_get_roles
IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_get_roles_habilitados' AND type='p')
	DROP PROCEDURE [SistemaCaido].sp_get_roles_habilitados
IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_baja_rol' AND type='p')
	DROP PROCEDURE [SistemaCaido].sp_baja_rol
IF EXISTS (SELECT name FROM sysobjects WHERE name='sp_update_rol' AND type='p')
	DROP PROCEDURE [SistemaCaido].sp_update_rol	
IF OBJECT_ID('[SistemaCaido].sp_alta_rol', 'P') IS NOT NULL
	DROP PROCEDURE [SistemaCaido].sp_alta_rol
IF OBJECT_ID('[SistemaCaido].AltaCliente', 'P') IS NOT NULL
	DROP PROCEDURE [SistemaCaido].AltaCliente
IF OBJECT_ID('[SistemaCaido].BajaCliente', 'P') IS NOT NULL
	DROP PROCEDURE [SistemaCaido].BajaCliente
IF OBJECT_ID('[SistemaCaido].ModificacionCliente', 'P') IS NOT NULL
	DROP PROCEDURE [SistemaCaido].ModificacionCliente
IF OBJECT_ID('[SistemaCaido].AltaEmpresa', 'P') IS NOT NULL
	DROP PROCEDURE [SistemaCaido].AltaEmpresa
IF OBJECT_ID('[SistemaCaido].BajaEmpresa', 'P') IS NOT NULL
	DROP PROCEDURE [SistemaCaido].BajaEmpresa
IF OBJECT_ID('[SistemaCaido].ModificacionEmpresa', 'P') IS NOT NULL
	DROP PROCEDURE [SistemaCaido].ModificacionEmpresa
IF OBJECT_ID('[SistemaCaido].AltaSucursal', 'P') IS NOT NULL
	DROP PROCEDURE [SistemaCaido].AltaSucursal
IF OBJECT_ID('[SistemaCaido].BajaSucursal', 'P') IS NOT NULL
	DROP PROCEDURE [SistemaCaido].BajaSucursal
IF OBJECT_ID('[SistemaCaido].ModificacionSucursal', 'P') IS NOT NULL
	DROP PROCEDURE [SistemaCaido].ModificacionSucursal


IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'RendicionesXFacturas' ))
	DROP TABLE [SistemaCaido].RendicionesXFacturas
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'UsuariosXSucursales' ))
	DROP TABLE [SistemaCaido].UsuariosXSucursales
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'PagosXFacturas' ))
	DROP TABLE [SistemaCaido].PagosXFacturas
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'UsuariosXRoles' ))
	DROP TABLE [SistemaCaido].UsuariosXRoles
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'RolesXFuncionalidades' ))
	DROP TABLE [SistemaCaido].RolesXFuncionalidades
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Rendiciones' ))
	DROP TABLE [SistemaCaido].Rendiciones
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Porcentajes' ))
	DROP TABLE [SistemaCaido].Porcentajes
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'ProductosXFacturas' ))
	DROP TABLE [SistemaCaido].ProductosXFacturas
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Productos' ))
	DROP TABLE [SistemaCaido].Productos
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Facturas' ))
	DROP TABLE [SistemaCaido].Facturas
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Empresas' ))
	DROP TABLE [SistemaCaido].Empresas
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Rubros' ))
	DROP TABLE [SistemaCaido].Rubros
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Pagos' ))
	DROP TABLE [SistemaCaido].Pagos
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'MediosPago' ))
	DROP TABLE [SistemaCaido].MediosPago
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Clientes' ))
	DROP TABLE [SistemaCaido].Clientes
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Sucursales' ))
	DROP TABLE [SistemaCaido].Sucursales
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Usuarios' ))
	DROP TABLE [SistemaCaido].Usuarios
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Roles' ))
	DROP TABLE [SistemaCaido].Roles
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Funcionalidades' ))
	DROP TABLE [SistemaCaido].Funcionalidades

--DROP TRIGGER [SistemaCaido].tr_nuevoCliente
--DROP TRIGGER [SistemaCaido].tr_nuevaEmpresa

IF (EXISTS (SELECT * FROM sys.types WHERE name = 'listaIDs' ))  
	DROP TYPE [SistemaCaido].listaIDs

IF (EXISTS (SELECT * FROM sys.schemas WHERE name = 'SistemaCaido'))
	DROP SCHEMA [SistemaCaido]

GO

--=============================================================================================================--
--*************************************** Creacion del esquema ************************************************--                                 
--=============================================================================================================--

CREATE SCHEMA SistemaCaido
GO

--=============================================================================================================--
--*************************************** Creacion de Tipos ************************************************--                                 
--=============================================================================================================--

CREATE TYPE SistemaCaido.listaIDs 
AS TABLE (id int);
GO

	
--=============================================================================================================--
--*************************************** Creacion de tablas ************************************************--                                 
--=============================================================================================================--

-- Funcionalidades
CREATE TABLE SistemaCaido.Funcionalidades(
	IdFuncionalidad int NOT NULL identity(1,1),
	Nombre varchar(30) NOT NULL,
	PRIMARY KEY(IdFuncionalidad),
)	
GO

-- Roles
CREATE TABLE SistemaCaido.Roles(
	IdRol int NOT NULL identity(1,1),
	Nombre varchar(30) not null,
	Habilitado bit not null default(1),
	PRIMARY KEY(IdRol),
)

-- Usuarios
GO

CREATE TABLE SistemaCaido.Usuarios(
	IdUsuario int NOT NULL identity(1,1),
	Username varchar(30) NOT NULL,
	Password varchar(255) NOT NULL,
	IntentosFallidos int default(0) not null,
	PRIMARY KEY(IdUsuario),
)

-- Sucursales
GO

CREATE TABLE SistemaCaido.Sucursales(
	IdSucursal int NOT NULL identity(1,1),
	Nombre nvarchar(255) NOT NULL,
	Direccion nvarchar(255) NOT NULL,
	CodigoPostal varchar(4) NOT NULL,
	Habilitada char default(1) NOT NULL,
	PRIMARY KEY(IdSucursal),
)

-- Clientes
GO

CREATE TABLE SistemaCaido.Clientes(
	IdCliente int NOT NULL identity(1,1),
	Nombre nvarchar(255) NOT NULL,
	Apellido nvarchar(255) NOT NULL,
	DNI numeric(18,0) NOT NULL,
	Mail nvarchar(255) NOT NULL,
	Telefono varchar(10) ,  -- no pongo not null porque en la base maestra no existe el campo
	Direccion nvarchar(255) NOT NULL,
	CodigoPostal nvarchar(4) NOT NULL,
	FechaNacimiento datetime NOT NULL,
	Habilitado varchar(1) default(1) NOT NULL,
	PRIMARY KEY(IdCliente),
)

-- Medios de Pago
GO

CREATE TABLE SistemaCaido.MediosPago (
	IdMedioPago int NOT NULL identity(1,1),
	Nombre nvarchar(255) NOT NULL,
	PRIMARY KEY(IdMedioPago),
)

-- Pagos
GO

CREATE TABLE SistemaCaido.Pagos(
	IdPago int NOT NULL identity(1,1),
	NumeroPago int not null,
	FechaCobro datetime NOT NULL,
	IdCliente int NOT NULL,
	Importe numeric(18,2) NOT NULL,
	IdSucursal int NOT NULL,
	IdMedioPago int NOT NULL,
	PRIMARY KEY(IdPago),
	FOREIGN KEY(IdCliente) REFERENCES SistemaCaido.Clientes,
	FOREIGN KEY(IdSucursal) REFERENCES SistemaCaido.Sucursales,
	FOREIGN KEY(IdMedioPago) REFERENCES SistemaCaido.MediosPago,
)

-- Rubros
GO

CREATE TABLE SistemaCaido.Rubros(
	IdRubro int NOT NULL identity(1,1),
	Nombre nvarchar(255) NOT NULL,
	PRIMARY KEY(IdRubro),
)

-- Empresas
GO

CREATE TABLE SistemaCaido.Empresas(
	IdEmpresa int NOT NULL identity(1,1),
	Nombre nvarchar(255) NOT NULL,
	CUIT nvarchar(50) NOT NULL,
	Direccion nvarchar(255) NOT NULL,
	IdRubro int NOT NULL,
	Habilitada char default(1) NOT NULL,
	PRIMARY KEY(IdEmpresa),
	FOREIGN KEY(IdRubro) REFERENCES SistemaCaido.Rubros, 
);

-- Facturas
GO

CREATE TABLE SistemaCaido.Facturas(
	IdFactura int NOT NULL identity(1,1),
	IdCliente int NOT NULL,
	IdEmpresa int NOT NULL,
	NumeroFactura numeric(18,0) NOT NULL,
	FechaAlta datetime NOT NULL,
	FechaVencimiento datetime NOT NULL,
	Importe numeric(18,2) NOT NULL,
	PRIMARY KEY(IdFactura),
	FOREIGN KEY(IdCliente) REFERENCES SistemaCaido.Clientes,
	FOREIGN KEY(IdEmpresa) REFERENCES SistemaCaido.Empresas,
)

-- Productos
GO

CREATE TABLE [SistemaCaido].Productos(
	IdProducto int NOT NULL identity(1,1),
	Descripcion nvarchar(255),
	Precio numeric(18,2) NOT NULL,
	PRIMARY KEY(IdProducto),
)


-- Item Facturas
GO

CREATE TABLE SistemaCaido.ProductosXFacturas(
	IdProductoXFactura int identity(1,1), 
	IdProducto int NOT NULL ,
	IdFactura int NOT NULL,
	Cantidad numeric(18,0) NOT NULL,
	PRIMARY KEY(IdProductoXFactura),
	FOREIGN KEY(IdProducto) REFERENCES SistemaCaido.Productos,
	FOREIGN KEY(IdFactura) REFERENCES SistemaCaido.Facturas,
)

-- Porcentajes
GO

CREATE TABLE [SistemaCaido].Porcentajes(
	IdPorcentaje int NOT NULL identity(1,1),
	Porcentaje numeric(3,2) NOT NULL,
	FechaAlta datetime NOT NULL,
	IdUsuario int NOT NULL,
	PRIMARY KEY(IdPorcentaje),
	FOREIGN KEY(IdUsuario) REFERENCES [SistemaCaido].Usuarios
)

-- Rendiciones
GO

CREATE TABLE SistemaCaido.Rendiciones(
	IdRendicion int NOT NULL identity(1,1),
	IdEmpresa int NOT NULL,
	NumeroRendicion numeric(18,0) NOT NULL,
	Fecha datetime NOT NULL,
	IdPorcentaje int NOT NULL,
	Importe numeric(18,2) not null,
	PRIMARY KEY(IdRendicion),
	FOREIGN KEY(IdEmpresa) REFERENCES SistemaCaido.Empresas,
	FOREIGN KEY(IdPorcentaje) REFERENCES SistemaCaido.Porcentajes
)

-- RolesXFuncionalidades
GO

CREATE TABLE SistemaCaido.RolesXFuncionalidades(
	IdRolXFuncionalidad int IDENTITY(1,1) NOT NULL,
	IdRol int NOT NULL,
	IdFuncionalidad int NOT NULL,
	PRIMARY KEY(IdRolXFuncionalidad),
	FOREIGN KEY(IdRol) REFERENCES SistemaCaido.Roles,
	FOREIGN KEY(IdFuncionalidad) REFERENCES SistemaCaido.Funcionalidades,
);


-- UsuariosXRoles
GO

CREATE TABLE SistemaCaido.UsuariosXRoles(
	IdUsuarioXRol int IDENTITY(1,1) NOT NULL,
	IdUsuario int NOT NULL,
	IdRol int NOT NULL,
	PRIMARY KEY(IdUsuarioXRol),
	FOREIGN KEY(IdUsuario) REFERENCES SistemaCaido.Usuarios,
	FOREIGN KEY(IdRol) REFERENCES SistemaCaido.Roles
	)

-- PagosXFacturas

CREATE TABLE SistemaCaido.PagosXFacturas(
	IdPagoXFactura int IDENTITY(1,1) NOT NULL,
	IdPago int NOT NULL,
	IdFactura int NOT NULL,
	PRIMARY KEY(IdPagoXFactura),
	FOREIGN KEY(IdPago) REFERENCES SistemaCaido.Pagos,
	FOREIGN KEY(IdFactura) REFERENCES SistemaCaido.Facturas,
)

-- UsuariosXSucursales
GO

CREATE TABLE SistemaCaido.UsuariosXSucursales(
	IdUsuarioXSucursal int IDENTITY(1,1) NOT NULL,
	IdUsuario int NOT NULL,
	IdSucursal int NOT NULL,
	PRIMARY KEY(IdUsuarioXSucursal),
	FOREIGN KEY(IdUsuario) REFERENCES SistemaCaido.Usuarios,
	FOREIGN KEY(IdSucursal) REFERENCES SistemaCaido.Sucursales
)

-- RendicionesXFacturas
GO

CREATE TABLE [SistemaCaido].RendicionesXFacturas(
	IdRendicionXFactura int IDENTITY(1,1) NOT NULL,
	IdRendicion int NOT NULL,
	IdFactura int NOT NULL,
	PRIMARY KEY(IdRendicionXFactura),
	FOREIGN KEY(IdRendicion) REFERENCES [SistemaCaido].Rendiciones,
	FOREIGN KEY(IdFactura) REFERENCES [SistemaCaido].Facturas,
)


--=============================================================================================================--
--*************************************** Migracion de datos ************************************************--                                 
--=============================================================================================================--
GO

/* Usuario administrador */
INSERT INTO [SistemaCaido].Usuarios (Username, Password)
VALUES('Admin', HASHBYTES('SHA2_256','w23e'))

/* Roles */
INSERT INTO [SistemaCaido].Roles (Nombre)
VALUES('Administrador'), ('Cobrador')

/*Usuarios X Roles*/
INSERT INTO SistemaCaido.UsuariosXRoles (IdRol, IdUsuario)
VALUES (1,1)

/* Porcentajes*/
INSERT INTO [SistemaCaido].Porcentajes VALUES(CAST('5.2' as numeric(3,2)), CONVERT(datetime, GETDATE()), 1)   --TODO ver cual es el porcentaje actual

/* Funcionalidades */
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('ABM de Rol')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('Login y Seguridad')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('Registro de Usuario')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('ABM de Cliente')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('ABM de Empresa')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('ABM de Sucursal')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('ABM de Facturas')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('Registro de Pago de Facturas')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('Rendicion de Facturas Cobradas')
INSERT INTO [SistemaCaido].Funcionalidades VALUES ('Listado Estadistico')

/* Funcionalidades X Roles */
INSERT INTO SistemaCaido.RolesXFuncionalidades (IdRol, IdFuncionalidad)
VALUES (1,1) ,(1,2) ,(1,3) ,(1,4) ,(1,5) ,(1,6) ,(1,7) ,(1,8) ,(1,9) ,(1,10)

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
SELECT DISTINCT Empresa_Nombre, Empresa_Cuit, Empresa_Direccion, r.IdRubro, 1 
FROM gd_esquema.Maestra m
inner join SistemaCaido.Rubros r on r.Nombre = m.Rubro_Descripcion
WHERE Empresa_Nombre IS NOT NULL

/* Sucursales */
INSERT INTO [SistemaCaido].Sucursales (Nombre, Direccion, CodigoPostal, Habilitada)
SELECT DISTINCT Sucursal_Nombre, Sucursal_Dirección, Sucursal_Codigo_Postal, 1
FROM gd_esquema.Maestra WHERE Sucursal_Nombre IS NOT NULL

/* Usuarios X Sucursales */
--TODO falta USUARIOSXSUCURSALES

/* Facturas */
INSERT INTO [SistemaCaido].Facturas (IdCliente, IdEmpresa, NumeroFactura, FechaAlta, FechaVencimiento, Importe)
SELECT DISTINCT IdCliente, IdEmpresa, Nro_Factura, Factura_Fecha, Factura_Fecha_Vencimiento, Factura_Total 
FROM gd_esquema.Maestra 
JOIN [SistemaCaido].Clientes c on [Cliente-Dni] = c.DNI 
JOIN [SistemaCaido].Empresas on Empresa_Nombre = [SistemaCaido].Empresas.Nombre
WHERE Nro_Factura IS NOT NULL
 
 /*
/* Productos */
INSERT INTO [SistemaCaido].Productos (Precio)
Select DISTINCT m.ItemRendicion_Importe
FROM gd_esquema.Maestra m

/* Productos X Facturas*/
INSERT INTO [SistemaCaido].ProductosXFacturas(IdFactura, Cantidad, IdProducto)   
SELECT IdFactura, ItemFactura_Cantidad, ItemFactura_Monto FROM gd_esquema.Maestra 
JOIN [SistemaCaido].Facturas on Nro_Factura = [SistemaCaido].Facturas.NumeroFactura
WHERE ItemFactura_Cantidad > 0
*/

/* Medios de Pago*/
INSERT INTO [SistemaCaido].MediosPago (Nombre)
SELECT DISTINCT m.FormaPagoDescripcion
FROM gd_esquema.Maestra m
where m.FormaPagoDescripcion is not null

/* Pagos */
INSERT INTO [SistemaCaido].Pagos (NumeroPago, FechaCobro, IdCliente, IdSucursal, IdMedioPago, Importe)    --TODO Falta poner el importe
SELECT DISTINCT Pago_nro, Pago_Fecha, IdCliente, IdSucursal, mp.IdMedioPago, 999
FROM gd_esquema.Maestra m
JOIN [SistemaCaido].Sucursales suc on Sucursal_Nombre = suc.Nombre
JOIN [SistemaCaido].Clientes cli on [Cliente-Dni] = cli.DNI
JOIN [SistemaCaido].MediosPago mp on mp.Nombre = m.FormaPagoDescripcion 
WHERE Pago_nro IS NOT NULL 

/* Pagos X Facturas */
INSERT INTO [SistemaCaido].PagosXFacturas (IdFactura, IdPago)
SELECT distinct f.IdFactura, p.IdPago
FROM gd_esquema.Maestra m
JOIN SistemaCaido.Facturas f on f.NumeroFactura = m.Nro_Factura
JOIN SistemaCaido.Pagos p on p.NumeroPago = m.Pago_nro

/* Rendiciones */
INSERT INTO [SistemaCaido].Rendiciones (IdEmpresa, NumeroRendicion, Fecha, IdPorcentaje, Importe) --TODO falta el importe
SELECT IdEmpresa, Rendicion_Nro, Rendicion_Fecha, p.IdPorcentaje, 999 
FROM gd_esquema.Maestra
JOIN [SistemaCaido].Empresas ON Empresa_Nombre = [SistemaCaido].Empresas.Nombre
JOIN [SistemaCaido].Porcentajes p on p.IdPorcentaje = 1 
WHERE Rendicion_Nro > 0

/*Rendiciones X Facturas */
INSERT INTO [SistemaCaido].RendicionesXFacturas (IdFactura, IdRendicion)
SELECT DISTINCT f.IdFactura, r.IdRendicion
FROM gd_esquema.Maestra m
JOIN SistemaCaido.Facturas f on f.NumeroFactura = m.Nro_Factura
JOIN SistemaCaido.Rendiciones r on r.NumeroRendicion = m.Rendicion_Nro


--=============================================================================================================--
--*************************************** Triggers ************************************************--                                 
--=============================================================================================================--
go

create trigger [SistemaCaido].tr_nuevoCliente on [SistemaCaido].Clientes instead of insert
as begin
	set nocount on
	 
	if (not exists( select cli.Mail from Clientes cli, inserted ins 
				   where cli.Mail = ins.Mail))
		insert into Clientes
		select Nombre, Apellido, DNI, Mail, Telefono, Direccion, CodigoPostal, FechaNacimiento, 1 from inserted

	else
		-- Se lanza un error
		raiserror('No se puede dar de alta el cliente (Email existente)..', 1,1)

	end

go
create trigger [SistemaCaido].tr_nuevaEmpresa on [SistemaCaido].Empresas instead of insert
as begin
	set nocount on
	 
	if (not exists( select emp.CUIT from Empresas emp, inserted ins 
				   where emp.CUIT = ins.CUIT))
		insert into Empresas
		select Nombre, CUIT, Direccion, IdRubro, 1 from inserted

	else
		-- Se lanza un error
		raiserror('No se puede dar de alta la empresa (CUIT existente)..', 1,1)
	end


go
create trigger [SistemaCaido].tr_nuevaSucursal on [SistemaCaido].Sucursales instead of insert
as begin
	set nocount on
	 
	if (not exists( select suc.CodigoPostal from Sucursales suc, inserted ins 
				   where suc.CodigoPostal = ins.CodigoPostal))
		insert into Sucursales
		select Nombre, Direccion, CodigoPostal, 1 from inserted

	else
		-- Se lanza un error
		raiserror('No se puede dar de alta la sucursal (CP existente)..', 1,1)
	end

go
create trigger [SistemaCaido].tr_nuevaFactura on [SistemaCaido].Facturas instead of insert
as begin
	set nocount on

	declare @FechaVenc datetime
	declare @Empresa int
	declare @ImporteFactura numeric(18,2)
	declare @Habilitada char
	declare @NumeroFactura int
	declare @IdFactura int

	select	@ImporteFactura = ins.Importe,
			@FechaVenc = ins.FechaVencimiento,
			@Empresa = ins.IdEmpresa,
			@Habilitada = emp.Habilitada
	from inserted ins
	join Empresas emp
	on emp.IdEmpresa = ins.IdEmpresa

	if(@ImporteFactura < 0)
		raiserror('El importe de la factura es menor de 0..', 1,1)

	if(@ImporteFactura = 0)
		raiserror('El importe de la factura es igual a 0..', 1,1)	
		
	if(@FechaVenc > sysdatetime())	
		raiserror('La fecha de vencimiento supera la fecha actual..', 1,1)	

	if(@Habilitada = 0)	
		raiserror('La empresa seleccionada esta inactiva..', 1,1)

end

go
create trigger [SistemaCaido].tr_tratarFactura on [SistemaCaido].Facturas instead of update,delete
as begin
	declare @Operacion char
	declare @IdFactura int

	set @Operacion = 'N'

	if exists (select * from inserted) and exists (select * from deleted)
		begin
			set @Operacion = 'U'	--Update

			select top 1 @IdFactura = pxf.IdFactura 
			from PagosXFacturas pxf, inserted ins where pxf.IdFactura = ins.IdFactura
			if(@IdFactura != 0)
				raiserror('La factura a ingresar se encuentra paga..', 1,1)

			select top 1 @IdFactura = rxf.IdFactura 
			from RendicionesXFacturas rxf, inserted ins where rxf.IdFactura = ins.IdFactura
			if(@IdFactura != 0)
				raiserror('La factura a ingresar se encuentra rendida..', 1,1)	

		end

	if not exists (select * from inserted) and exists (select * from deleted)
		begin
			set @Operacion = 'D'	--Delete

			select top 1 @IdFactura = pxf.IdFactura 
			from PagosXFacturas pxf, deleted del where pxf.IdFactura = del.IdFactura
			if(@IdFactura != 0)
				raiserror('La factura a ingresar se encuentra paga..', 1,1)

			select top 1 @IdFactura = rxf.IdFactura 
			from RendicionesXFacturas rxf, deleted del where rxf.IdFactura = del.IdFactura
			if(@IdFactura != 0)
				raiserror('La factura a ingresar se encuentra rendida..', 1,1)	

		end
end

--=============================================================================================================--
--*************************************** Creacion de Funciones ************************************************--                                 
--=============================================================================================================--
GO

create function [sistemaCaido].existeRolConMismoNombre(@nombre varchar(255), @idRol numeric(10))
returns int
begin
declare @retorno bit

if	((select count(*)
	from [sistemaCaido].Roles
	where Nombre = @nombre
	and  (@idRol is null or(IdRol != @idRol))) > 0)

	set @retorno = 1

else
	set @retorno = 0

return @retorno

end
GO


create function [sistemaCaido].existeUsuario(@username varchar(255))
returns bit
begin
declare @retorno bit

if((select count(*)
	from [sistemaCaido].Usuarios
	where Username = @username) > 0) set @retorno = 1 else set @retorno = 0
return @retorno

end
GO


create function [sistemaCaido].usuarioActivo (@username varchar(255))
returns bit
begin
declare @retorno bit

if((select IntentosFallidos
	from [sistemaCaido].Usuarios
	where Username = @username) < 3) set @retorno = 1 else set @retorno = 0

return @retorno
end
GO



--=============================================================================================================--
--*************************************** Creacion de Procedures ************************************************--                                 
--=============================================================================================================--
go

--********************************* ABM de Rol ****************************************--

create procedure [SistemaCaido].sp_alta_rol (@nombre varchar(255), @habilitado  bit, @listaFuncionalidades sistemaCaido.listaIDs readonly)
as
begin

set xact_abort on
begin tran

if(sistemaCaido.existeRolConMismoNombre( @nombre, null) = 1) THROW 51000, 'Ya existe un Rol con el nombre ingresado.', 1;	

insert into [sistemaCaido].Roles (Nombre, Habilitado)
values(@nombre, @habilitado)

insert into [sistemaCaido].RolesXFuncionalidades (IdRol, IdFuncionalidad)
select  IdRol, id
from @listaFuncionalidades, [sistemaCaido].Roles
where @nombre = Nombre

commit
end
GO


create procedure [SistemaCaido].sp_baja_rol (@id numeric(10,0))
as
begin

update [SistemaCaido].Roles 
set Habilitado = 0
where idRol = @id

end
GO


create procedure [SistemaCaido].sp_update_rol (@id numeric(10,0), @nombre varchar(255), @habilitado bit, @listaFuncionalidades [SistemaCaido].listaIDs readonly)	
as
begin

set xact_abort on
begin tran

if([SistemaCaido].existeRolConMismoNombre(@nombre, @id) = 1) THROW 51000, 'Ya existe un Rol con el nombre ingresado.', 1;

update [SistemaCaido].Roles
set Nombre = @nombre, Habilitado = @habilitado
where IdRol = @id

delete from [SistemaCaido].RolesXFuncionalidades
where IdRol = @id

insert into [SistemaCaido].RolesXFuncionalidades (IdRol, IdFuncionalidad)
select  @id, id
from @listaFuncionalidades

commit

end
GO


create procedure [SistemaCaido].sp_get_roles_habilitados
as
begin

select * 
from Roles
where Habilitado = 1

end
GO


create procedure [SistemaCaido].sp_get_roles
as
begin

select IdRol as ID, Nombre as Descripcion, Habilitado as Habilitado
from Roles

end
GO

create procedure [SistemaCaido].sp_get_funcionalidades_rol(@idRol numeric(10,0)) as
begin
	select f.*
	from [SistemaCaido].funcionalidades f, [SistemaCaido].RolesXFuncionalidades rf
	where @idRol = rf.IdRol
	and rf.IdFuncionalidad = f.IdFuncionalidad
end
GO


create procedure [SistemaCaido].sp_get_funcionalidades as
begin
	select * 
	from [SistemaCaido].Funcionalidades
end
GO

--********************************* Login ****************************************--

create procedure [SistemaCaido].sp_limpiar_intentos_fallidos (@username varchar(255))
as
begin

update [SistemaCaido].Usuarios set IntentosFallidos = 0
where Username = @username

end
GO


create procedure [SistemaCaido].sp_incrementar_intentos_fallidos (@username varchar(255))
as
begin

update  [SistemaCaido].Usuarios set IntentosFallidos = (IntentosFallidos + 1)
where Username = @username

end
GO


create procedure [SistemaCaido].sp_login_check(@username varchar (255), @contrasenia varchar(255), @retorno int output)
as
begin

 if ([SistemaCaido].existeUsuario(@username)) = 0 set @retorno = -1
	else
	begin
	if([SistemaCaido].usuarioActivo(@username) = 0) set @retorno = -3
		else
		if(select Password
		from [SistemaCaido].Usuarios
		where Username = @username) = HASHBYTES('SHA2_256',cast(@contrasenia as varchar(255)))begin  set @retorno = (select u.IdUsuario  from [SistemaCaido].Usuarios u where u.Username = @username) exec [SistemaCaido].sp_limpiar_intentos_fallidos @username end
			else 
			begin
			set @retorno=-2
			exec [SistemaCaido].sp_incrementar_intentos_fallidos @username 
			end
		end
	return @retorno

end
GO


create procedure [SistemaCaido].sp_get_roles_usuario (@idUsuario numeric (10,0))	
as
begin

select r.*
from [SistemaCaido].Usuarios u, [SistemaCaido].UsuariosXRoles ur, [SistemaCaido].Roles r
where u.IdUsuario = @idUsuario
and u.IdUsuario = ur.IdUsuario
and ur.IdRol = r.IdRol
and r.Habilitado = 1 	

end
GO		



--********************************* ABM de Clientes ****************************************--

create procedure [SistemaCaido].sp_alta_cliente (@nombre varchar(250), @apellido varchar(250), @fechanac date, @dni numeric(10,0), @direccion varchar(250),@codpost numeric(18,0), @telefono numeric(18,0))
as
begin

set xact_abort on
begin tran


	if((select count(*) from [SistemaCaido].Clientes where DNI = @dni) > 0) THROW 51000, 'Ya existe un cliente con el numero de DNI ingresado.', 1;

	declare @usuario varchar(255)
	declare @contraseña varchar(255)
	set @usuario =   convert(varchar(255), @dni)
	set @contraseña =   convert(varchar(255), @dni)

	insert into [SistemaCaido].Clientes(Nombre,Apellido,FechaNacimiento,DNI,Direccion,CodigoPostal,Telefono)
	values(@nombre, @apellido, @fechanac, @dni, @direccion, @codpost, @telefono)

commit

end
GO


create procedure [SistemaCaido].sp_update_cliente (@nombre varchar(250),  @apellido varchar(250), @DNI numeric(18), @fechaNacimiento date, @direccion varchar(250), @codPostal numeric, @telefono numeric(18,0), @habilitado numeric(1,0), @idcliente numeric(10,0)) as
begin

set xact_abort on
begin tran	

if((select count(*) from [SistemaCaido].Clientes where DNI = @dni and @idcliente != IdCliente) > 0) THROW 51000, 'Ya existe un cliente con el numero de DNI ingresado.', 1;

update [SistemaCaido].Clientes
set Nombre = @nombre,
Apellido = @apellido,
FechaNacimiento = @fechaNacimiento,
Direccion = @direccion,
CodigoPostal = @codPostal,
Telefono = @telefono,
DNI = @DNI,
Habilitado = @habilitado
where IdCliente = @idcliente

commit

end
GO


create procedure [SistemaCaido].sp_baja_cliente (@idcliente numeric(10,0)) as
begin
	update [SistemaCaido].clientes
	set Habilitado = 0
	where IdCliente = @idcliente
end
GO



create procedure [SistemaCaido].sp_get_clientes(@nombre varchar(250), @apellido varchar(250), @dni numeric(18,0), @habilitado bit) as
begin

select IdCliente as ID, Nombre as Nombre ,Apellido as Apellido ,CodigoPostal as Codigo_Postal,Direccion as Direccion ,DNI as DNI,FechaNacimiento as Fecha_Nacimiento ,Telefono as Telefono,Habilitado as Habilitado
from [SistemaCaido].Clientes
where (@apellido is null or (Apellido like CONCAT('%',@apellido,'%')))
and   (@nombre is null or   (Nombre like CONCAT('%',@nombre,'%')))
and	  (@dni is null or (DNI = @dni))
and   (@habilitado is null or (Habilitado = @habilitado))

OPTION (RECOMPILE)
end
go


create procedure [SistemaCaido].sp_obtenerPorcentajeActual as
begin
	select top 1 Porcentaje
	from [SistemaCaido].Porcentajes
	order by IdPorcentaje desc
end
GO

--********************************* ABM de Empresas ****************************************--

create procedure [SistemaCaido].AltaEmpresa(@Nombre nvarchar(255), @CUIT nvarchar(50), @Direccion nvarchar(255), @IdRubro int)
as begin transaction
	insert into Empresas values (@Nombre, @CUIT, @Direccion, @IdRubro, 1)
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo dar de alta la empresa..', 1,1)
			rollback transaction
		end

	commit transaction

go
create procedure [SistemaCaido].BajaEmpresa(@IdEmpresa int)
as begin transaction

	declare @cantidadFacturas int

	select @cantidadFacturas = count(*) from RendicionesXFacturas rxf
	join Rendiciones ren on rxf.IdRendicion = ren.IdRendicion
	where ren.IdEmpresa = @IdEmpresa
	
	if @cantidadFacturas != 0
		begin
			raiserror('No se pudo dar de baja la empresa (Facturas sin rendir)..', 1,1)
			rollback transaction
		end		

	-- Eliminacion logica
	update Empresas set Habilitada = 0 where IdEmpresa = @IdEmpresa
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo dar de baja la empresa..', 1,1)
			rollback transaction
		end

	commit transaction	
	
go
create procedure [SistemaCaido].ModificacionEmpresa(@IdEmpresa int, @Nombre nvarchar(255), @CUIT nvarchar(50), @Direccion nvarchar(255), @IdRubro int, @Habilitada char)
as begin transaction
	update Empresas
	set Nombre = @Nombre,
		CUIT = @CUIT,
		Direccion = @Direccion,
		IdRubro = @IdRubro,
		Habilitada = @Habilitada
	where IdEmpresa = @IdEmpresa
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo modificar la empresa..', 1,1)
			rollback transaction
		end

	commit transaction

go

--********************************* ABM de Sucursales ****************************************--

create procedure [SistemaCaido].AltaSucursal(@Nombre nvarchar(255), @Direccion nvarchar(255), @CodigoPostal varchar(4))
as begin transaction
	insert into Sucursales values (@Nombre, @Direccion, @CodigoPostal, 1)	
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo dar de alta la sucursal..', 1,1)
			rollback transaction
		end

	commit transaction

go
create procedure [SistemaCaido].BajaSucursal(@IdSucursal int)
as begin transaction
	-- Eliminacion logica
	update Sucursales set Habilitada = 0 where IdSucursal = @IdSucursal
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo dar de baja la sucursal..', 1,1)
			rollback transaction
		end

	commit transaction

go
create procedure [SistemaCaido].ModificacionSucursal
(@IdSucursal int, @Nombre nvarchar(255), @Direccion nvarchar(255), @CodigoPostal varchar(4), @Habilitada char) 
as begin transaction
	update Sucursales
	set Nombre = @Nombre,
		Direccion = @Direccion,
		CodigoPostal = @CodigoPostal,
		Habilitada = @Habilitada
	where IdSucursal = @IdSucursal

	if (@@ERROR != 0)
		begin
			raiserror('No se pudo dar de baja la sucursal..', 1,1)
			rollback transaction
		end

	commit transaction


--********************************* ABM de Facturas ****************************************--
go
create type [SistemaCaido].Items as table(
	Producto int,
	Monto numeric(18,2),
	Cantidad numeric(18,0)
);

go
create procedure [SistemaCaido].AltaFactura
(@IdCliente int, @IdEmpresa int, @NumeroFactura numeric(18,0), @FechaVencimiento datetime, 
 @Items [SistemaCaido].Items readonly)
as begin transaction
	declare @Importe numeric(18,2)
	declare @Monto numeric(18,2)
	declare @Producto int
	declare @Cantidad numeric(18,0)
	declare @IdFactura int

	set @Importe = 0

	-- Agregar la factura con importe 0
	insert into Facturas values (@IdCliente, @IdEmpresa, @NumeroFactura, sysdatetime(), @FechaVencimiento, @Importe)	
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo dar de alta la factura..', 1,1)
			rollback transaction
		end

	else
		begin
			-- Obtener el Id del ultimo insert
			set @IdFactura = @@IDENTITY
			 
			declare items_cursor cursor for
			select Producto, Monto, Cantidad from @Items

			open items_cursor
			fetch next from items_cursor into @Monto, @Cantidad

			while(@@FETCH_STATUS = 0) 
			begin
				select @Monto = isnull(Precio,0) from Productos where IdProducto = @Producto
				if (@Monto = 0)
					begin
						--No existe el producto
						raiserror('No existe el producto..', 1,1)
						rollback transaction
					end
				else
					begin
						insert into ProductosXFacturas values(@Producto, @IdFactura, @Cantidad)
						if (@@ERROR != 0)
							begin
								raiserror('No se pudo dar de alta el item de factura..', 1,1)
								rollback transaction
							end
						else
							set @Importe = @Importe + (@Monto * @Cantidad)
					end
			end

			-- Actualizo el importe de la factura recientemente ingresada
			update Facturas set Importe = @Importe where IdFactura = @IdFactura
			
		end
	commit transaction

go
create procedure [SistemaCaido].BajaFactura(@IdFactura int)
as begin transaction
	--Se borra la factura?
	delete from Facturas where IdFactura = @IdFactura
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo dar de baja la factura..', 1,1)
			rollback transaction
		end

	commit transaction
	
go
create procedure [SistemaCaido].ModificacionFactura
(@IdFactura int, @IdCliente int, @IdEmpresa int, @NumeroFactura int, @FechaAlta datetime, @FechaVencimiento datetime, @Importe numeric(18,2))
as begin transaction
	update Facturas
	set IdCliente = @IdCliente,
		IdEmpresa = @IdEmpresa,
		NumeroFactura = @NumeroFactura,
		FechaAlta = @FechaAlta,
		FechaVencimiento = @FechaVencimiento,
		Importe = @Importe
	where IdFactura = @IdFactura
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo modificar la factura..', 1,1)
			rollback transaction
		end

	commit transaction




------------ Registro de Pago de Facturas
go
create type [SistemaCaido].tablaFacturas as table(
	NumeroFactura int,
	FechaCobro datetime default sysdatetime(),
	Empresa int,
	Cliente int,
	FechaVencimiento datetime,
	Importe numeric(18,2),
	Sucursal int
);

go
create procedure [SistemaCaido].RegistrarPago(@Facturas [SistemaCaido].tablaFacturas readonly,
											  @Cliente int, @Sucursal int, @MedioPago int)
as begin transaction
	declare @ImporteTotal numeric(18,2) 
	declare @NumeroPago int

	set @ImporteTotal = 0
	set @NumeroPago = 0

	select @ImporteTotal = SUM(fact1.Importe) from Facturas fact1
	join @Facturas fact2 on fact1.IdFactura = fact2.NumeroFactura

	if(@ImporteTotal != 0)
		begin
			insert into Pagos values (@NumeroPago, sysdatetime(), @Cliente, @ImporteTotal, @Sucursal, @MedioPago)
			if (@@ERROR != 0)
				begin
					raiserror('No se pudo registrar el pago..', 1,1)
					rollback transaction
				end
			commit transaction
		end


------------ Rendicion de facturas cobradas
------------ Listado Estadistico ------------
go
create function [SistemaCaido].ClientesConMasPagos(@Anio char(4), @Trimestre int)
returns table
as return(
	select top 5 IdCliente Cliente, count(*) CantidadPagos 
	from Pagos
	where year(FechaCobro) = @Anio and
		  month(FechaCobro) between (3 * @Trimestre - 2) and (3 * @Trimestre)
  group by IdCliente
  order by 2 desc
)

go
create function [SistemaCaido].EmpresasConMayorMontoRendido(@Anio char(4), @Trimestre int)
returns table
as return(
	select top 5 emp.Nombre Empresa, SUM(rend.Importe - (rend.Importe * porc.Porcentaje) / 100) MontoRendido
	from Empresas emp
	join Rendiciones rend on emp.IdEmpresa = rend.IdEmpresa
	join Porcentajes porc on rend.IdPorcentaje = porc.IdPorcentaje
	where year(rend.Fecha) = @Anio and
		  month(rend.Fecha) between (3 * @Trimestre - 2) and (3 * @Trimestre)
	group by emp.Nombre, rend.Importe, porc.Porcentaje
)

