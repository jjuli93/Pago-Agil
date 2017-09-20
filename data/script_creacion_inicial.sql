IF OBJECT_ID('[SistemaCaido].AltaRol', 'P') IS NOT NULL
DROP PROC [SistemaCaido].AltaRol
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
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'RolesXFuncionalidades' ))
DROP TABLE [SistemaCaido].RolesXFuncionalidades
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'UsuariosXRoles' ))
DROP TABLE [SistemaCaido].UsuariosXRoles
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'UsuariosXSucursales' ))
DROP TABLE [SistemaCaido].UsuariosXSucursales
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'PagosXFacturas' ))
DROP TABLE [SistemaCaido].PagosXFacturas
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Roles' ))
DROP TABLE [SistemaCaido].Roles
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Funcionalidades' ))
DROP TABLE [SistemaCaido].Funcionalidades
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Usuarios' ))
DROP TABLE [SistemaCaido].Usuarios
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Pagos' ))
DROP TABLE [SistemaCaido].Pagos
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Item_Facturas' ))
DROP TABLE [SistemaCaido].Item_Facturas
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Rendiciones' ))
DROP TABLE [SistemaCaido].Rendiciones
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Sucursales' ))
DROP TABLE [SistemaCaido].Sucursales
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'MediosPago' ))
DROP TABLE [SistemaCaido].MediosPago
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Facturas' ))
DROP TABLE [SistemaCaido].Facturas
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Empresas' ))
DROP TABLE [SistemaCaido].Empresas
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Clientes' ))
DROP TABLE [SistemaCaido].Clientes
IF (EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'SistemaCaido' AND TABLE_NAME   = 'Rubros' ))
DROP TABLE [SistemaCaido].Rubros

--DROP TRIGGER [SistemaCaido].tr_nuevoCliente
--DROP TRIGGER [SistemaCaido].tr_nuevaEmpresa
IF (EXISTS (SELECT * FROM sys.types WHERE name = 'TablaFuncionalidades' ))  
DROP TYPE [SistemaCaido].TablaFuncionalidades
DROP SCHEMA [SistemaCaido]

USE GD2C2017

-- Creacion de Esquema
GO

CREATE SCHEMA SistemaCaido

-- Tipos
GO

	CREATE TYPE SistemaCaido.TablaFuncionalidades 
	AS TABLE(Funcionalidad nvarchar(255) NULL)
	
-- Creacion de Tablas
GO
-- Funcionalidades
	CREATE TABLE SistemaCaido.Funcionalidades(
		IdFuncionalidades int NOT NULL identity(1,1),
		Nombre varchar(30),
		PRIMARY KEY(IdFuncionalidades),
	)

-- Roles
GO

	CREATE TABLE SistemaCaido.Roles(
		IdRol int NOT NULL identity(1,1),
		Nombre varchar(30),
		PRIMARY KEY(IdRol),
	)

-- Usuarios
GO

	CREATE TABLE SistemaCaido.Usuarios(
		IdUsuario int NOT NULL identity(1,1),
		Username varchar(10),
		Password varchar(10),
		PRIMARY KEY(IdUsuario),
	)

-- Sucursales
GO

	CREATE TABLE SistemaCaido.Sucursales(
		IdSucursal int NOT NULL identity(1,1),
		Nombre nvarchar(255),
		Direccion nvarchar(255),
		CodigoPostal varchar(4),
		Habilitada char,
		PRIMARY KEY(IdSucursal),
	)

-- Clientes
GO

	CREATE TABLE SistemaCaido.Clientes(
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
	)

-- Medios de Pago
GO

	CREATE TABLE SistemaCaido.MediosPago (
		IdMedioPago int NOT NULL identity(1,1),
		Nombre nvarchar(255),
		PRIMARY KEY(IdMedioPago),
	)

-- Pagos
GO

	CREATE TABLE SistemaCaido.Pagos(
		IdPago int NOT NULL identity(1,1),
		NumeroPago int not null,
		FechaCobro datetime,
		IdCliente int,
		Importe numeric(18,2),
		IdSucursal int,
		IdMedioPago int,
		PRIMARY KEY(IdPago),
		FOREIGN KEY(IdCliente) REFERENCES SistemaCaido.Clientes,
		FOREIGN KEY(IdSucursal) REFERENCES SistemaCaido.Sucursales,
		FOREIGN KEY(IdMedioPago) REFERENCES SistemaCaido.MediosPago,
	)

-- Rubros
GO

	CREATE TABLE SistemaCaido.Rubros(
		IdRubro int NOT NULL identity(1,1),
		Nombre nvarchar(255),
		PRIMARY KEY(IdRubro),
	)

-- Empresas
GO

	CREATE TABLE SistemaCaido.Empresas(
		IdEmpresa int NOT NULL identity(1,1),
		Nombre nvarchar(255),
		CUIT nvarchar(50),
		Direccion nvarchar(255),
		IdRubro int,
		Habilitada char,
		PRIMARY KEY(IdEmpresa),
		FOREIGN KEY(IdRubro) REFERENCES SistemaCaido.Rubros, 
	);

-- Facturas
GO

	CREATE TABLE SistemaCaido.Facturas(
		IdFactura int NOT NULL identity(1,1),
		IdCliente int,
		IdEmpresa int,
		NumeroFactura numeric(18,0),
		FechaAlta datetime,
		FechaVencimiento datetime,
		Importe numeric(18,2),
		PRIMARY KEY(IdFactura),
		FOREIGN KEY(IdCliente) REFERENCES SistemaCaido.Clientes,
		FOREIGN KEY(IdEmpresa) REFERENCES SistemaCaido.Empresas,
	)

-- Item Facturas
GO

	CREATE TABLE SistemaCaido.Item_Facturas(
		IdItem int NOT NULL identity(1,1),
		IdFactura int,
		Cantidad numeric(18,0),
		Monto numeric(18,2),
		PRIMARY KEY(IdItem),
		FOREIGN KEY(IdFactura) REFERENCES SistemaCaido.Facturas,
	)

-- Rendiciones
GO

	CREATE TABLE SistemaCaido.Rendiciones(
		IdRendicion int NOT NULL identity(1,1),
		IdEmpresa int,
		NumeroRendicion numeric(18,0),
		Fecha datetime,
		PRIMARY KEY(IdRendicion),
		FOREIGN KEY(IdEmpresa) REFERENCES SistemaCaido.Empresas,
	)

-- RolesXFuncionalidades
GO

	CREATE TABLE SistemaCaido.RolesXFuncionalidades(
		IdRol int,
		IdFuncionalidades int,
		PRIMARY KEY(IdRol, IdFuncionalidades),
		FOREIGN KEY(IdRol) REFERENCES SistemaCaido.Roles,
		FOREIGN KEY(IdFuncionalidades) REFERENCES SistemaCaido.Funcionalidades,
	);


-- UsuariosXRoles
GO
	CREATE TABLE SistemaCaido.UsuariosXRoles(
		IdUsuario int,
		IdRol int,
		PRIMARY KEY(IdUsuario, IdRol),
		FOREIGN KEY(IdUsuario) REFERENCES SistemaCaido.Usuarios,
		FOREIGN KEY(IdRol) REFERENCES SistemaCaido.Roles
		)

-- PagosXFacturas

	CREATE TABLE SistemaCaido.PagosXFacturas(
		IdPago int,
		IdFactura int
		PRIMARY KEY(IdPago, IdFactura),
		FOREIGN KEY(IdPago) REFERENCES SistemaCaido.Pagos,
		FOREIGN KEY(IdFactura) REFERENCES SistemaCaido.Facturas,
	)

-- UsuariosXSucursales
GO

	CREATE TABLE SistemaCaido.UsuariosXSucursales(
		IdUsuario int,
		IdSucursal int,
		PRIMARY KEY(IdUsuario, IdSucursal),
		FOREIGN KEY(IdUsuario) REFERENCES SistemaCaido.Usuarios,
		FOREIGN KEY(IdSucursal) REFERENCES SistemaCaido.Sucursales
		)

-- Migracion de Datos
GO

/* Usuarios */
INSERT INTO [SistemaCaido].Usuarios VALUES('Admin', 'w23e')
INSERT INTO [SistemaCaido].Usuarios VALUES('Usuario1', 'inicio123')

/* Roles */
INSERT INTO [SistemaCaido].Roles VALUES('Administrador')
INSERT INTO [SistemaCaido].Roles VALUES('Cobrador')

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
JOIN [SistemaCaido].Clientes c on [Cliente-Dni] = c.DNI 
JOIN [SistemaCaido].Empresas on Empresa_Nombre = [SistemaCaido].Empresas.Nombre
WHERE Nro_Factura IS NOT NULL
 
/* Item Facturas */
INSERT INTO [SistemaCaido].Item_Facturas (IdFactura, Cantidad, Monto)
SELECT IdFactura, ItemFactura_Cantidad, ItemFactura_Monto FROM gd_esquema.Maestra 
JOIN [SistemaCaido].Facturas on Nro_Factura = [SistemaCaido].Facturas.NumeroFactura
WHERE ItemFactura_Cantidad > 0

/* Pagos */
INSERT INTO [SistemaCaido].Pagos (NumeroPago, FechaCobro, IdCliente, IdSucursal)
SELECT DISTINCT Pago_nro, Pago_Fecha, IdCliente, IdSucursal FROM gd_esquema.Maestra
JOIN [SistemaCaido].Sucursales suc on Sucursal_Nombre = suc.Nombre
JOIN [SistemaCaido].Clientes cli on [Cliente-Dni] = cli.DNI
WHERE Pago_nro IS NOT NULL 

/* Rendiciones */
INSERT INTO [SistemaCaido].Rendiciones (IdEmpresa, NumeroRendicion, Fecha)
SELECT IdEmpresa, Rendicion_Nro, Rendicion_Fecha FROM gd_esquema.Maestra
JOIN [SistemaCaido].Empresas ON Empresa_Nombre = [SistemaCaido].Empresas.Nombre
WHERE Rendicion_Nro > 0

 


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
