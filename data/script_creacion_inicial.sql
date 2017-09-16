USE GD2C2017

-- Creacion de Esquema
GO
CREATE SCHEMA [SistemaCaido];

-- Tipos
GO
IF (NOT EXISTS (SELECT * FROM sys.types
				WHERE name = 'TablaFuncionalidades' ))
BEGIN 
	CREATE TYPE [SistemaCaido].TablaFuncionalidades 
	AS TABLE(Funcionalidad nvarchar(255) NULL)
END


-- Creacion de Tablas
GO
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
		Telefono varchar(10),
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
		IdPago int NOT NULL,
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


-- Item Facturas
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'Item_Facturas' ))
BEGIN
	CREATE TABLE [SistemaCaido].Item_Facturas(
		IdItem int NOT NULL identity(1,1),
		IdFactura int,
		Cantidad numeric(18,0),
		Monto numeric(18,2),
		PRIMARY KEY(IdItem),
		FOREIGN KEY(IdFactura) REFERENCES [SistemaCaido].Facturas,
	);
END


-- Rendiciones
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'Rendiciones' ))
BEGIN
	CREATE TABLE [SistemaCaido].Rendiciones(
		IdRendicion int NOT NULL identity(1,1),
		IdEmpresa int,
		NumeroRendicion numeric(18,0),
		Fecha datetime,
		PRIMARY KEY(IdRendicion),
		FOREIGN KEY(IdEmpresa) REFERENCES [SistemaCaido].Empresas,
	);
END


-- Productos
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'Productos' ))
BEGIN
	CREATE TABLE [SistemaCaido].Productos(
		IdProducto int NOT NULL identity(1,1),
		Descripcion nvarchar(255),
		Precio numeric(18,2),
		PRIMARY KEY(IdProducto),
	);

END


-- Porcentajes
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'Porcentajes' ))
BEGIN
	CREATE TABLE [SistemaCaido].Porcentajes(
		IdPorcentajes int NOT NULL identity(1,1),
		Porcentaje numeric(3,2),
		FechaAlta datetime,
		IdUsuario int
		PRIMARY KEY(IdPorcentajes),
		FOREIGN KEY(IdUsuario) REFERENCES [SistemaCaido].Usuarios
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


-- PagosXFacturas
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'PagosXFacturas' ))
BEGIN
	CREATE TABLE [SistemaCaido].PagosXFacturas(
		IdPago int,
		IdFactura int
		PRIMARY KEY(IdPago, IdFactura),
		FOREIGN KEY(IdPago) REFERENCES [SistemaCaido].Pagos,
		FOREIGN KEY(IdFactura) REFERENCES [SistemaCaido].Facturas,
	);
END

-- UsuariosXSucursales
GO
IF (NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_SCHEMA = '[SistemaCaido]' AND
					  TABLE_NAME   = 'UsuariosXSucursales' ))
BEGIN
	CREATE TABLE [SistemaCaido].UsuariosXSucursales(
		IdUsuario int,
		IdSucursal int,
		PRIMARY KEY(IdUsuario, IdSucursal),
		FOREIGN KEY(IdUsuario) REFERENCES [SistemaCaido].Usuarios,
		FOREIGN KEY(IdSucursal) REFERENCES [SistemaCaido].Sucursales,
	);
END

-- Migracion de Datos
GO

/* Usuarios */
INSERT INTO [SistemaCaido].Usuarios VALUES('Admin', 'w23e')
INSERT INTO [SistemaCaido].Usuarios VALUES('Usuario1', 'inicio123')

/* Roles */
INSERT INTO [SistemaCaido].Roles VALUES('Administrador')
INSERT INTO [SistemaCaido].Roles VALUES('Cobrador')

/* Porcentajes*/
-- INSERT INTO [SistemaCaido].Porcentajes VALUES(CAST('100' as numeric(3,2)), CONVERT(datetime, GETDATE()), 1)

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

/* Facturas */
INSERT INTO [SistemaCaido].Facturas (IdCliente, IdEmpresa, NumeroFactura, FechaAlta, FechaVencimiento, Importe)
SELECT DISTINCT IdCliente, IdEmpresa, Nro_Factura, Factura_Fecha, Factura_Fecha_Vencimiento, Factura_Total 
FROM gd_esquema.Maestra 
JOIN [SistemaCaido].Clientes on [Cliente-Nombre] + [Cliente-Apellido] = [SistemaCaido].Clientes.Nombre + [SistemaCaido].Clientes.Apellido
JOIN [SistemaCaido].Empresas on Empresa_Nombre = [SistemaCaido].Empresas.Nombre
WHERE Nro_Factura IS NOT NULL
 
/* Item Facturas */
INSERT INTO [SistemaCaido].Item_Facturas (IdFactura, Cantidad, Monto)
SELECT IdFactura, ItemFactura_Cantidad, ItemFactura_Monto FROM gd_esquema.Maestra 
JOIN [SistemaCaido].Facturas on Nro_Factura = [SistemaCaido].Facturas.NumeroFactura
WHERE ItemFactura_Cantidad > 0

/* Pagos */
INSERT INTO [SistemaCaido].Pagos (IdPago, FechaCobro) --, IdCliente, IdSucursal)
SELECT DISTINCT Pago_nro, Pago_Fecha FROM gd_esquema.Maestra --, IdCliente, IdSucursal FROM gd_esquema.Maestra
--JOIN [SistemaCaido].Sucursales suc on Sucursal_Nombre = suc.Nombre
--JOIN [SistemaCaido].Clientes cli on [Cliente-Apellido] + [Cliente-Nombre] = cli.Apellido + [Cliente-Nombre]
WHERE Pago_nro IS NOT NULL 

/* Rendiciones */
INSERT INTO [SistemaCaido].Rendiciones (IdEmpresa, NumeroRendicion, Fecha)
SELECT IdEmpresa, Rendicion_Nro, Rendicion_Fecha FROM gd_esquema.Maestra
JOIN [SistemaCaido].Empresas ON Empresa_Nombre = [SistemaCaido].Empresas.Nombre
WHERE Rendicion_Nro > 0

/*
DROP TABLE [SistemaCaido].RolesXFuncionalidades
DROP TABLE [SistemaCaido].UsuariosXRoles
DROP TABLE [SistemaCaido].UsuariosXSucursales
DROP TABLE [SistemaCaido].PagosXFacturas
DROP TABLE [SistemaCaido].Porcentajes
DROP TABLE [SistemaCaido].Productos
DROP TABLE [SistemaCaido].Roles
DROP TABLE [SistemaCaido].Funcionalidades
DROP TABLE [SistemaCaido].Usuarios
DROP TABLE [SistemaCaido].Pagos
DROP TABLE [SistemaCaido].Item_Facturas
DROP TABLE [SistemaCaido].Rendiciones
DROP TABLE [SistemaCaido].Sucursales
DROP TABLE [SistemaCaido].MediosPago
DROP TABLE [SistemaCaido].Facturas
DROP TABLE [SistemaCaido].Empresas
DROP TABLE [SistemaCaido].Clientes
DROP TABLE [SistemaCaido].Rubros
DROP TRIGGER [SistemaCaido].tr_nuevoCliente
DROP TRIGGER [SistemaCaido].tr_nuevaEmpresa
DROP PROCEDURE [SistemaCaido].AltaRol
DROP PROCEDURE [SistemaCaido].AltaCliente
DROP PROCEDURE [SistemaCaido].BajaCliente
DROP PROCEDURE [SistemaCaido].ModificacionCliente
DROP PROCEDURE [SistemaCaido].AltaEmpresa
DROP PROCEDURE [SistemaCaido].BajaEmpresa
DROP PROCEDURE [SistemaCaido].ModificacionEmpresa
DROP PROCEDURE [SistemaCaido].AltaSucursal
DROP PROCEDURE [SistemaCaido].BajaSucursal
DROP PROCEDURE [SistemaCaido].ModificacionSucursal
DROP TYPE [SistemaCaido].TablaFuncionalidades
DROP SCHEMA [SistemaCaido]
*/

-- Triggers
go
create trigger [SistemaCaido].tr_nuevoCliente on [SistemaCaido].Clientes instead of insert
as begin
	set nocount on
	 
	if (not exists( select cli.Mail from Clientes cli, inserted ins 
				   where cli.Mail = ins.Mail))
		insert into Clientes
		select Nombre, Apellido, DNI, Mail, Telefono, Direccion, CodigoPostal, FechaNacimiento, 1 from inserted

	else
		-- Se actualiza el existente
		update Clientes
		set Mail = ins.Mail
		from Clientes cli, inserted ins
		where cli.IdCliente = ins.IdCliente
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
		-- Se actualiza el existente
		update Empresas
		set CUIT = ins.CUIT
		from Empresas emp, inserted ins
		where emp.IdEmpresa = ins.IdEmpresa
	end



-- Stored Procedures
go
create procedure [SistemaCaido].AltaRol(@Rol nvarchar(255), @Funcionalidades [SistemaCaido].TablaFuncionalidades readonly)
as begin transaction
	declare @cantidadFilas int
	declare @numeroFila int
	declare @Funcionalidad nvarchar(255)

	set @numeroFila		= 0
	set @cantidadFilas	= (select count(*) from @Funcionalidades)

	insert into Roles values (@Rol)
	if (@@ERROR != 0)
	begin
		raiserror('No se pudo dar de alta el rol..', 1,1)
		rollback transaction
	END

	declare funcionalidad_cursor cursor for 
	select Funcionalidad FROM @Funcionalidades

	open funcionalidad_cursor
	fetch next from funcionalidad_cursor into @Funcionalidad

	while(@@FETCH_STATUS = 0)
		begin
			insert into RolesXFuncionalidades values (@Rol, @Funcionalidad)
			if (@@ERROR != 0)
			begin
				raiserror('No se pudo dar de alta el rol..', 1,1)
				rollback transaction
			end

			insert into Funcionalidades values (@Funcionalidad)
			if (@@ERROR != 0)
			begin
				raiserror('No se pudo dar de alta el rol..', 1,1)
				rollback transaction
			end

			fetch next from funcionalidad_cursor into @Funcionalidad
		end

	commit transaction

go
create procedure [SistemaCaido].AltaCliente
(@Nombre nvarchar(255), @Apellido nvarchar(255), @DNI numeric(18,0), @Mail nvarchar(255),
 @Telefono varchar(10), @Direccion nvarchar(255), @CodigoPostal nvarchar(4), @FechaNacimiento datetime)
 as begin transaction

	insert into Clientes values (@Nombre, @Apellido, @DNI, @Mail, @Telefono, @Direccion, @CodigoPostal, @FechaNacimiento, 1)
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo dar de alta el cliente..', 1,1)
			rollback transaction
		end

	commit transaction

go
create procedure [SistemaCaido].BajaCliente(@IdCliente int)
 as begin transaction
	/*
	delete from Clientes where IdCliente = @IdCliente
	*/
	-- Eliminacion logica
	update Clientes set Habilitado = 0 where IdCliente = @IdCliente
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo dar de baja el cliente..', 1,1)
			rollback transaction
		end

	commit transaction

go
create procedure [SistemaCaido].ModificacionCliente
(@IdCliente int, @Nombre nvarchar(255), @Apellido nvarchar(255), @DNI numeric(18,0), @Mail nvarchar(255),
 @Telefono varchar(10), @Direccion nvarchar(255), @CodigoPostal nvarchar(4), @FechaNacimiento datetime, @Habilitado char)
 as begin transaction
	
	update Clientes
	set Nombre = @Nombre, Apellido = @Apellido, 
		DNI = @DNI, 
		Mail = @Mail,
		Telefono = @Telefono,
		Direccion = @Direccion,
		CodigoPostal = @CodigoPostal,
		FechaNacimiento = @FechaNacimiento,
		Habilitado = @Habilitado
		
	where IdCliente = @IdCliente
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo modificar el cliente..', 1,1)
			rollback transaction
		end

	commit transaction
		

go
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
/*
	delete from Empresas where IdEmpresa = @IdEmpresa
	*/
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
