USE [GD2C2017]
GO

--=============================================================================================================--
--=============================================================================================================--
--*************************************** Dropeos *************************************************************--                                 
--=============================================================================================================--
--=============================================================================================================--

--*************************************** Triggers *************************************************************--   

IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[SistemaCaido].[tr_nuevaSucursal]'))
DROP TRIGGER [SistemaCaido].[tr_nuevaSucursal]
GO

IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[SistemaCaido].[tr_tratarFactura]'))
DROP TRIGGER [SistemaCaido].[tr_tratarFactura]
GO

IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[SistemaCaido].[tr_nuevaFactura]'))
DROP TRIGGER [SistemaCaido].[tr_nuevaFactura]
GO

IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[SistemaCaido].[tr_nuevaEmpresa]'))
DROP TRIGGER [SistemaCaido].[tr_nuevaEmpresa]
GO

IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[SistemaCaido].[tr_nuevoCliente]'))
DROP TRIGGER [SistemaCaido].[tr_nuevoCliente]
GO

IF  EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[SistemaCaido].[tr_baja_rol]'))
DROP TRIGGER [SistemaCaido].[tr_baja_rol]
GO

--*************************************** Listados estadisticos *************************************************************--   

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[EmpresasConMayorMontoRendido]') AND type in (N'P', N'PC'))
DROP procedure [SistemaCaido].[EmpresasConMayorMontoRendido]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[ClientesConMasPagos]') AND type in (N'P', N'PC'))
DROP procedure [SistemaCaido].[ClientesConMasPagos]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[EmpresasConMayorPorcentajeFacturasCobradas]') AND type in (N'P', N'PC'))
DROP procedure [SistemaCaido].[ClientesConMayorPorcentajeFacturasPagadas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[EmpresasConMayorPorcentajeFacturasCobradas]') AND type in (N'P', N'PC'))
DROP procedure [SistemaCaido].[EmpresasConMayorPorcentajeFacturasCobradas]
GO


--*************************************** Tablas *************************************************************--   

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[DevolucionesXFacturas]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[DevolucionesXFacturas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Devoluciones]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Devoluciones]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXSucursales]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[UsuariosXSucursales]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXRoles]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[UsuariosXRoles]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Usuarios]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Usuarios]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[RolesXFuncionalidades]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[RolesXFuncionalidades]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Roles]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Roles]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[RendicionesXFacturas]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[RendicionesXFacturas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Rendiciones]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Rendiciones]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[ProductosXFacturas]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[ProductosXFacturas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Productos]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Productos]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Porcentajes]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Porcentajes]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[PagosXFacturas]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[PagosXFacturas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Pagos]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Pagos]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Sucursales]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Sucursales]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[MediosPago]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[MediosPago]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Funcionalidades]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Funcionalidades]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Facturas]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Facturas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Empresas]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Empresas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Rubros]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Rubros]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Clientes]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Clientes]
GO

--*************************************** Funciones *************************************************************--   

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[usuarioActivo]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [SistemaCaido].[usuarioActivo]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[existeUsuario]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [SistemaCaido].[existeUsuario]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[existeRolConMismoNombre]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [SistemaCaido].[existeRolConMismoNombre]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[GetSiguienteNumeroDeFactura]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [SistemaCaido].[GetSiguienteNumeroDeFactura]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[GetSiguienteNumeroDePago]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [SistemaCaido].[GetSiguienteNumeroDePago]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[GetSiguienteNumeroDeRendicion]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [SistemaCaido].[GetSiguienteNumeroDeRendicion]
GO


--*************************************** Stored procedures *************************************************************--   

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_update_rol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_update_rol]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_update_cliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_update_cliente]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_obtenerPorcentajeActual]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_obtenerPorcentajeActual]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_login_check]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_login_check]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_limpiar_intentos_fallidos]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_limpiar_intentos_fallidos]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_incrementar_intentos_fallidos]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_incrementar_intentos_fallidos]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_get_roles_usuario]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_get_roles_usuario]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_get_roles_habilitados]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_get_roles_habilitados]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_get_roles]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_get_roles]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_get_funcionalidades_rol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_get_funcionalidades_rol]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_get_funcionalidades]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_get_funcionalidades]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_get_clientes]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_get_clientes]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_baja_rol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_baja_rol]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_baja_cliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_baja_cliente]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_alta_rol]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_alta_rol]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_alta_cliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[sp_alta_cliente]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[RegistrarPago]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[RegistrarPago]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[ModificacionSucursal]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[ModificacionSucursal]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[ModificacionFactura]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[ModificacionFactura]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[ModificacionEmpresa]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[ModificacionEmpresa]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[BajaSucursal]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[BajaSucursal]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[BajaFactura]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[BajaFactura]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[BajaEmpresa]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[BajaEmpresa]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[AltaFactura]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[AltaFactura]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[AltaSucursal]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[AltaSucursal]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[AltaEmpresa]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[AltaEmpresa]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[BuscarEmpresas]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[BuscarEmpresas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[BuscarFacturas]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[BuscarFacturas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[BuscarSucursales]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[BuscarSucursales]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[GetFacturasClienteParaPago]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[GetFacturasClienteParaPago]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[GetDatosRendicion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[GetDatosRendicion]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[GetRubros]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[GetRubros]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[RealizarRendicion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[RealizarRendicion]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[GetFacturasPago]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[GetFacturasPago]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[GetPagosCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[GetPagosCliente]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[GetEmpresasHabilitadas]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[GetEmpresasHabilitadas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[GetFacturasParaDevolucionCliente]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[GetFacturasParaDevolucionCliente]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[RealizarDevolucion]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[RealizarDevolucion]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[GetMediosDePago]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[GetMediosDePago]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[FacturaPuedeSerModificada]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[FacturaPuedeSerModificada]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[GetItemsFactura]') AND type in (N'P', N'PC'))
DROP PROCEDURE [SistemaCaido].[GetItemsFactura]
GO


--*************************************** Tipos *************************************************************--   

IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'listaIDs' AND ss.name = N'SistemaCaido')
DROP TYPE [SistemaCaido].[listaIDs]
GO

IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Items' AND ss.name = N'SistemaCaido')
DROP TYPE [SistemaCaido].[Items]
GO

--*************************************** Esquema*************************************************************--   

IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'SistemaCaido')
DROP SCHEMA [SistemaCaido]
GO

--=============================================================================================================--
--=============================================================================================================--
--*************************************** Creacion de Esquema *************************************************--                                 
--=============================================================================================================--
--=============================================================================================================--
CREATE SCHEMA [SistemaCaido]
GO

--=============================================================================================================--
--=============================================================================================================--
--*************************************** Creacion de Tablas **************************************************--                                 
--=============================================================================================================--
--=============================================================================================================--

CREATE TABLE [SistemaCaido].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL primary key,
	[Nombre] [nvarchar](255) NOT NULL,
	[Apellido] [nvarchar](255) NOT NULL,
	[DNI] [numeric](18, 0) NOT NULL unique,
	[Mail] [nvarchar](255) NOT NULL ,  --No pongo unique porque hay clientes con mismo mail en tabla maestra
	[Telefono] [varchar](10) NULL,
	[Direccion] [nvarchar](255) NOT NULL,
	[CodigoPostal] [nvarchar](4) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Habilitado] bit NOT NULL default(1))
GO

CREATE TABLE [SistemaCaido].[Rubros](
	[IdRubro] [int] IDENTITY(1,1) NOT NULL primary key,
	[Nombre] [nvarchar](255) NOT NULL)
GO

CREATE TABLE [SistemaCaido].[Empresas](
	[IdEmpresa] [int] IDENTITY(1,1) NOT NULL primary key,
	[Nombre] [nvarchar](255) NOT NULL,
	[CUIT] [nvarchar](50) NOT NULL UNIQUE,
	[Direccion] [nvarchar](255) NOT NULL,
	[IdRubro] [int] NOT NULL references SistemaCaido.Rubros,
	[Habilitada] bit NOT NULL default(1))
GO

CREATE TABLE [SistemaCaido].[Facturas](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdCliente] [int] NOT NULL references SistemaCaido.Clientes,
	[IdEmpresa] [int] NOT NULL references SistemaCaido.Empresas,
	[NumeroFactura] [numeric](18, 0) NOT NULL unique,
	[FechaAlta] [datetime] NOT NULL,
	[FechaVencimiento] [datetime] NOT NULL,
	[Importe] [numeric](18, 2) NOT NULL,
	[Habilitada] bit NOT NULL default(1))
GO

CREATE TABLE [SistemaCaido].[Funcionalidades](
	[IdFuncionalidad] [int] IDENTITY(1,1) NOT NULL primary key,
	[Nombre] [varchar](30) NOT NULL)
GO

CREATE TABLE [SistemaCaido].[MediosPago](
	[IdMedioPago] [int] IDENTITY(1,1) NOT NULL primary key,
	[Nombre] [nvarchar](255) NOT NULL)
GO

CREATE TABLE [SistemaCaido].[Sucursales](
	[IdSucursal] [int] IDENTITY(1,1) NOT NULL primary key,
	[Nombre] [nvarchar](255) NOT NULL,
	[Direccion] [nvarchar](255) NOT NULL,
	[CodigoPostal] [varchar](4) NOT NULL,
	[Habilitada] bit NOT NULL default(1))
GO

CREATE TABLE [SistemaCaido].[Pagos](
	[IdPago] [int] IDENTITY(1,1) NOT NULL primary key,
	[NumeroPago] [int] NOT NULL unique,
	[FechaCobro] [datetime] NOT NULL,
	[IdCliente] [int] NOT NULL references SistemaCaido.Clientes,
	[Importe] [numeric](18, 2) NOT NULL,
	[IdSucursal] [int] NOT NULL references SistemaCaido.Sucursales,
	[IdMedioPago] [int] NOT NULL)
GO

CREATE TABLE [SistemaCaido].[PagosXFacturas](
	[IdPagoXFactura] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdPago] [int] NOT NULL references SistemaCaido.Pagos,
	[IdFactura] [int] NOT NULL references SistemaCaido.Facturas)
GO

CREATE TABLE [SistemaCaido].[Porcentajes](
	[IdPorcentaje] [int] IDENTITY(1,1) NOT NULL primary key,
	[Porcentaje] [numeric](3, 2) NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[IdUsuario] [int] NOT NULL)
GO

CREATE TABLE [SistemaCaido].[Productos](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL primary key,
	[Descripcion] [nvarchar](255) NULL,
	[Precio] [numeric](18, 8) NOT NULL)
GO

CREATE TABLE [SistemaCaido].[ProductosXFacturas](
	[IdProductoXFactura] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdProducto] [int] NOT NULL references SistemaCaido.Productos,
	[IdFactura] [int] NOT NULL references SistemaCaido.Facturas,
	[Cantidad] [numeric](18, 0) NOT NULL)
GO

CREATE TABLE [SistemaCaido].[Rendiciones](
	[IdRendicion] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdEmpresa] [int] NOT NULL references SistemaCaido.Empresas,
	[NumeroRendicion] [numeric](18, 0) NOT NULL unique,
	[Fecha] [datetime] NOT NULL,
	[IdPorcentaje] [int] NOT NULL references SistemaCaido.Porcentajes,
	[ImporteTotal] [numeric](18, 2) NOT NULL,
	[ImporteEmpresa] [numeric](18, 2) NOT NULL)
GO

CREATE TABLE [SistemaCaido].[RendicionesXFacturas](
	[IdRendicionXFactura] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdRendicion] [int] NOT NULL references SistemaCaido.Rendiciones,
	[IdFactura] [int] NOT NULL references SistemaCaido.Facturas)
GO

CREATE TABLE [SistemaCaido].[Roles](
	[IdRol] [int] IDENTITY(1,1) NOT NULL primary key,
	[Nombre] [varchar](30) NOT NULL,
	[Habilitado] [bit] NOT NULL default(1))
GO

CREATE TABLE [SistemaCaido].[RolesXFuncionalidades](
	[IdRolXFuncionalidad] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdRol] [int] NOT NULL references SistemaCaido.Roles,
	[IdFuncionalidad] [int] NOT NULL references SistemaCaido.Funcionalidades)
GO

CREATE TABLE [SistemaCaido].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL primary key,
	[Username] [varchar](30) NOT NULL UNIQUE,
	[Password] [varchar](255) NOT NULL,
	[IntentosFallidos] [int] NOT NULL default(0))
GO

CREATE TABLE [SistemaCaido].[UsuariosXRoles](
	[IdUsuarioXRol] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdUsuario] [int] NOT NULL references SistemaCaido.Usuarios,
	[IdRol] [int] NOT NULL references SistemaCaido.Roles)
GO

CREATE TABLE [SistemaCaido].[UsuariosXSucursales](
	[IdUsuarioXSucursal] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdUsuario] [int] NOT NULL references SistemaCaido.Usuarios,
	[IdSucursal] [int] NOT NULL references SistemaCaido.Sucursales)
GO

CREATE TABLE [SistemaCaido].[Devoluciones](
	[IdDevolucion] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdCliente] [int] NOT NULL references SistemaCaido.Clientes,
	[Motivo] [varchar](250),
	[Fecha] [datetime])
GO

CREATE TABLE [SistemaCaido].[DevolucionesXFacturas](
	[IdDevolucionesXFacturas] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdDevolucion] [int] NOT NULL references SistemaCaido.Devoluciones,
	[IdFactura] [int] NOT NULL references SistemaCaido.Facturas)
GO


--=============================================================================================================--
--=============================================================================================================--
--*************************************** Migracion de datos ************************************************--                                 
--=============================================================================================================--
--=============================================================================================================--

/* Usuario administrador */
INSERT INTO SistemaCaido.Usuarios (Username, Password)
VALUES('Admin', HASHBYTES('SHA2_256','w23e')), ('prueba', HASHBYTES('SHA2_256','prueba'))

/* Roles */
INSERT INTO SistemaCaido.Roles (Nombre)
VALUES('Administrador'), ('Cobrador')

/*Usuarios X Roles*/
INSERT INTO SistemaCaido.UsuariosXRoles (IdRol, IdUsuario)
VALUES (1,1), (1,2), (2,2)

/* Porcentajes*/
INSERT INTO SistemaCaido.Porcentajes (Porcentaje, FechaAlta, IdUsuario) 
VALUES(CAST('0.1' as numeric(3,2)), CONVERT(datetime, GETDATE()), 1) 

/* Funcionalidades */
INSERT INTO SistemaCaido.Funcionalidades VALUES ('ABM de Rol')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('ABM de Cliente')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('ABM de Empresa')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('ABM de Sucursal')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('ABM de Facturas')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('Devoluciones de Facturas')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('Registro de Pago de Facturas')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('Rendicion de Facturas Cobradas')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('Listado Estadistico')

/* Funcionalidades X Roles */
INSERT INTO SistemaCaido.RolesXFuncionalidades (IdRol, IdFuncionalidad)
VALUES (1,1) ,(1,2) ,(1,3) ,(1,4) ,(1,5) ,(1,6) ,(1,7) ,(1,8) ,(1,9), (2,7)

/* Clientes */
INSERT INTO SistemaCaido.Clientes (Nombre, Apellido, DNI, Mail, Direccion, CodigoPostal, FechaNacimiento, Habilitado)
SELECT DISTINCT [Cliente-Nombre], [Cliente-Apellido], [Cliente-Dni], Cliente_Mail, 
				Cliente_Direccion, Cliente_Codigo_Postal, [Cliente-Fecha_Nac], 1
FROM gd_esquema.Maestra WHERE [Cliente-Apellido] + [Cliente-Nombre] IS NOT NULL

/* Rubros */
INSERT INTO SistemaCaido.Rubros (Nombre)
SELECT DISTINCT Rubro_Descripcion FROM gd_esquema.Maestra WHERE Rubro_Descripcion IS NOT NULL

/* Empresas */
INSERT INTO SistemaCaido.Empresas (Nombre, CUIT, Direccion, IdRubro, Habilitada)
SELECT DISTINCT Empresa_Nombre, Empresa_Cuit, Empresa_Direccion, r.IdRubro, 1 
FROM gd_esquema.Maestra m
inner join SistemaCaido.Rubros r on r.Nombre = m.Rubro_Descripcion
WHERE Empresa_Nombre IS NOT NULL

/* Sucursales */
INSERT INTO SistemaCaido.Sucursales (Nombre, Direccion, CodigoPostal, Habilitada)
SELECT DISTINCT Sucursal_Nombre, Sucursal_Dirección, Sucursal_Codigo_Postal, 1
FROM gd_esquema.Maestra WHERE Sucursal_Nombre IS NOT NULL

/* Usuarios X Sucursales */
INSERT INTO SistemaCaido.UsuariosXSucursales (IdSucursal, IdUsuario)
values(1,1)

/* Facturas */
INSERT INTO SistemaCaido.Facturas (IdCliente, IdEmpresa, NumeroFactura, FechaAlta, FechaVencimiento, Importe, Habilitada)
SELECT DISTINCT IdCliente, IdEmpresa, Nro_Factura, Factura_Fecha, Factura_Fecha_Vencimiento, Factura_Total, 1 
FROM gd_esquema.Maestra 
JOIN SistemaCaido.Clientes c on [Cliente-Dni] = c.DNI 
JOIN SistemaCaido.Empresas on Empresa_Nombre = SistemaCaido.Empresas.Nombre
WHERE Nro_Factura IS NOT NULL
 
 
/* Productos */
INSERT INTO SistemaCaido.Productos (Precio)
Select DISTINCT convert(numeric(18,8),(m.ItemFactura_Monto / m.ItemFactura_Cantidad))	
FROM gd_esquema.Maestra m

/* Productos X Facturas*/
INSERT INTO SistemaCaido.ProductosXFacturas(IdFactura, Cantidad, IdProducto)   
SELECT f.IdFactura, m.ItemFactura_Cantidad, p.IdProducto 
FROM gd_esquema.Maestra m
JOIN SistemaCaido.Facturas f on m.Nro_Factura = f.NumeroFactura
JOIN SistemaCaido.Productos p on convert(numeric(18,8),(m.ItemFactura_Monto / m.ItemFactura_Cantidad)) = p.Precio
WHERE ItemFactura_Cantidad > 0
and m.Pago_nro is null


/* Medios de Pago*/
INSERT INTO SistemaCaido.MediosPago (Nombre)
SELECT DISTINCT m.FormaPagoDescripcion
FROM gd_esquema.Maestra m
where m.FormaPagoDescripcion is not null


/* Pagos */
INSERT INTO SistemaCaido.Pagos (NumeroPago, FechaCobro, IdCliente, IdSucursal, IdMedioPago, Importe) 
SELECT DISTINCT Pago_nro, Pago_Fecha, cli.IdCliente, IdSucursal, mp.IdMedioPago, m.Total
FROM gd_esquema.Maestra m
JOIN SistemaCaido.Sucursales suc on Sucursal_Nombre = suc.Nombre
JOIN SistemaCaido.Clientes cli on [Cliente-Dni] = cli.DNI
JOIN SistemaCaido.MediosPago mp on mp.Nombre = m.FormaPagoDescripcion
WHERE Pago_nro IS NOT NULL 


/* Pagos X Facturas */
INSERT INTO SistemaCaido.PagosXFacturas (IdFactura, IdPago)
SELECT distinct f.IdFactura, p.IdPago
FROM gd_esquema.Maestra m
JOIN SistemaCaido.Facturas f on f.NumeroFactura = m.Nro_Factura
JOIN SistemaCaido.Pagos p on p.NumeroPago = m.Pago_nro

/* Rendiciones */
INSERT INTO SistemaCaido.Rendiciones (IdEmpresa, NumeroRendicion, Fecha, IdPorcentaje,ImporteTotal, ImporteEmpresa)
SELECT distinct e.IdEmpresa, Rendicion_Nro, Rendicion_Fecha, p.IdPorcentaje,SUM(f.importe), (SUM(f.Importe) * p.Porcentaje)
FROM gd_esquema.Maestra m
JOIN SistemaCaido.Empresas e ON Empresa_Nombre = e.Nombre
JOIN SistemaCaido.Porcentajes p on p.IdPorcentaje = 1 
JOIN SistemaCaido.Facturas f on m.Nro_Factura = f.NumeroFactura
WHERE Rendicion_Nro > 0
Group by e.IdEmpresa, Rendicion_Nro, Rendicion_Fecha, p.IdPorcentaje, p.Porcentaje


/*Rendiciones X Facturas */
INSERT INTO SistemaCaido.RendicionesXFacturas (IdFactura, IdRendicion)
SELECT DISTINCT f.IdFactura, r.IdRendicion
FROM gd_esquema.Maestra m
JOIN SistemaCaido.Facturas f on f.NumeroFactura = m.Nro_Factura
JOIN SistemaCaido.Rendiciones r on r.NumeroRendicion = m.Rendicion_Nro

GO


--=============================================================================================================--
--=============================================================================================================--
--*************************************** Creacion de Tipos ***************************************************--                                 
--=============================================================================================================--
--=============================================================================================================--


CREATE TYPE [SistemaCaido].[Items] AS TABLE(
	[Descripcion] varchar(250) NULL,
	[Monto] [numeric](18, 2) NULL,
	[Cantidad] [numeric](18, 0) NULL
)
GO

CREATE TYPE [SistemaCaido].[listaIDs] AS TABLE(
	[id] [int] NULL
)
GO


--=============================================================================================================--
--=============================================================================================================--
--*************************************** Triggers ************************************************************--                                 
--=============================================================================================================--
--=============================================================================================================--

create trigger [SistemaCaido].[tr_nuevoCliente] on [SistemaCaido].[Clientes] instead of insert
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

GO


create trigger [SistemaCaido].[tr_nuevaEmpresa] on [SistemaCaido].[Empresas] instead of insert
as begin
	set nocount on
	 
	if (not exists( select emp.CUIT from Empresas emp, inserted ins 
				   where emp.CUIT = ins.CUIT))
		insert into Empresas
		select Nombre, CUIT, Direccion, IdRubro, 1 from inserted

	else
		-- Se lanza un error
		THROW 51000, 'No se puede dar de alta la empresa (CUIT existente)', 1;
	end

GO


create trigger [SistemaCaido].[tr_nuevaFactura] on [SistemaCaido].[Facturas] instead of insert
as begin
	set nocount on

	declare @FechaVenc datetime
	declare @Empresa int
	declare @ImporteFactura numeric(18,2)
	declare @Habilitada bit
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
		THROW 51000, 'El importe de la factura es menor de 0', 1;

	if(@ImporteFactura = 0)
		THROW 51000, 'El importe de la factura es igual a 0', 1;
		
	if(@FechaVenc < sysdatetime())	
		THROW 51000, 'La fecha de vencimiento es menor a la fecha actual', 1;

	if(@Habilitada = 0)
		THROW 51000, 'La empresa seleccionada esta inactiva..', 1;

	-- Si paso todo, inserto	
	INSERT INTO Facturas (IdCliente, IdEmpresa, NumeroFactura, FechaAlta, FechaVencimiento, Importe)
	SELECT ins.IdCliente, ins.IdEmpresa, ins.NumeroFactura, ins.FechaAlta, ins.FechaVencimiento, ins.Importe 
	FROM inserted ins

end

GO


create trigger [SistemaCaido].[tr_tratarFactura] on [SistemaCaido].[Facturas] instead of update,delete
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
				THROW 51000, 'La factura a ingresar se encuentra paga..', 1;

			select top 1 @IdFactura = rxf.IdFactura 
			from RendicionesXFacturas rxf, inserted ins where rxf.IdFactura = ins.IdFactura
			if(@IdFactura != 0)
				THROW 51000, 'La factura a ingresar se encuentra rendida..', 1;

		end

	if not exists (select * from inserted) and exists (select * from deleted)
		begin
			set @Operacion = 'D'	--Delete

			select top 1 @IdFactura = pxf.IdFactura 
			from PagosXFacturas pxf, deleted del where pxf.IdFactura = del.IdFactura
			if(@IdFactura != 0)
				THROW 51000, 'La factura a ingresar se encuentra paga..', 1;

			select top 1 @IdFactura = rxf.IdFactura 
			from RendicionesXFacturas rxf, deleted del where rxf.IdFactura = del.IdFactura
			if(@IdFactura != 0)
				THROW 51000, 'La factura a ingresar se encuentra rendida..', 1;

		end
end

GO


create trigger [SistemaCaido].[tr_nuevaSucursal] on [SistemaCaido].[Sucursales] instead of insert
as begin
	set nocount on
	 
	if (not exists( select suc.CodigoPostal from Sucursales suc, inserted ins 
				   where suc.CodigoPostal = ins.CodigoPostal))
		insert into Sucursales
		select Nombre, Direccion, CodigoPostal, 1 from inserted

	else
		-- Se lanza un error
		THROW 51000, 'No se puede dar de alta la sucursal (CP existente)', 1;
	end
	 
GO

create trigger [SistemaCaido].tr_baja_rol on [SistemaCaido].Roles for update
as
begin
if UPDATE(habilitado)
	begin
		delete from [SistemaCaido].UsuariosXRoles
		where IdRol in (select i.IdRol
						from inserted i
						 where i.Habilitado = 0)
	end
end
GO



--=============================================================================================================--
--=============================================================================================================--
--*************************************** Funciones ***********************************************************--                                 
--=============================================================================================================--
--=============================================================================================================--


create function [SistemaCaido].[existeRolConMismoNombre](@nombre varchar(255), @idRol numeric(10))
returns int
begin
declare @retorno bit

if	((select count(*)
	from SistemaCaido.Roles
	where Nombre = @nombre
	and  (@idRol is null or(IdRol != @idRol))) > 0)

	set @retorno = 1

else
	set @retorno = 0

return @retorno

end
GO


create function [SistemaCaido].[existeUsuario](@username varchar(255))
returns bit
begin
declare @retorno bit

if((select count(*)
	from SistemaCaido.Usuarios
	where Username = @username) > 0) set @retorno = 1 else set @retorno = 0
return @retorno

end
GO


create function [SistemaCaido].[usuarioActivo] (@username varchar(255))
returns bit
begin
declare @retorno bit

if((select IntentosFallidos
	from SistemaCaido.Usuarios
	where Username = @username) < 3) set @retorno = 1 else set @retorno = 0

return @retorno
end
GO


create procedure [SistemaCaido].[sp_obtenerPorcentajeActual] as
begin
	select top 1 p.IdPorcentaje, p.Porcentaje
	from SistemaCaido.Porcentajes p
	order by IdPorcentaje desc
end

GO

create function SistemaCaido.GetSiguienteNumeroDeFactura ()
returns int
begin
	
	return(select MAX(f.NumeroFactura)+ 1 from SistemaCaido.Facturas f )
END
GO

create function SistemaCaido.GetSiguienteNumeroDePago ()
returns int
begin
	
	return(select MAX(p.NumeroPago)+ 1 from SistemaCaido.Pagos p )
END
GO

create function SistemaCaido.GetSiguienteNumeroDeRendicion()
returns int
begin
	
	return(select MAX(r.NumeroRendicion)+ 1 from SistemaCaido.Rendiciones r )
END
GO
	


--=============================================================================================================--
--=============================================================================================================--
--*************************************** Stored Procedures ***************************************************--                                 
--=============================================================================================================--
--=============================================================================================================--


--********************************* ABM de Empresas ****************************************--


create procedure [SistemaCaido].[AltaEmpresa](@Nombre nvarchar(255), @CUIT nvarchar(50), @Direccion nvarchar(255), @IdRubro int)
as begin transaction
	insert into SistemaCaido.Empresas values (@Nombre, @CUIT, @Direccion, @IdRubro, 1)
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo dar de alta la empresa..', 1,1)
			rollback transaction
		end

	commit transaction

GO


create procedure [SistemaCaido].[BajaEmpresa](@IdEmpresa int)
as begin transaction

	declare @cantidadFacturas int

	select @cantidadFacturas = count(*) from SistemaCaido.Facturas f
										where f.IdEmpresa = @IdEmpresa
										and f.IdFactura not in (select IdFactura from SistemaCaido.RendicionesXFacturas)
	
	if @cantidadFacturas != 0
			THROW 51000, 'No se pudo dar de baja la empresa (Facturas sin rendir)', 1;	

	-- Eliminacion logica
	update Empresas set Habilitada = 0 where IdEmpresa = @IdEmpresa
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo dar de baja la empresa..', 1,1)
			rollback transaction
		end

	commit transaction

GO


create procedure [SistemaCaido].[ModificacionEmpresa](@IdEmpresa int, @Nombre nvarchar(255), @CUIT nvarchar(50), @Direccion nvarchar(255), @IdRubro int, @Habilitada bit)
as begin transaction

	if((select count(*) from SistemaCaido.Empresas where CUIT = @CUIT AND IdEmpresa != @IdEmpresa) > 0) THROW 51000, 'No se pudo modificar la empresa (CUIT existente)', 1;

	update SistemaCaido.Empresas
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
GO


create procedure SistemaCaido.BuscarEmpresas (@Nombre nvarchar(255), @CUIT nvarchar(50),  @IdRubro int)
as begin
	Select e.IdEmpresa, e.Nombre 'Nombre', e.CUIT, e.Direccion, e.Habilitada, r.Nombre 'Rubro'
	From SistemaCaido.Empresas e
	Join SistemaCaido.Rubros r on e.IdRubro = r.IdRubro
	where (@nombre is null or (e.nombre like CONCAT('%',@nombre,'%')))
	and (@CUIT is null or (e.CUIT like CONCAT('%',@CUIT,'%')))
	and (@IdRubro is null or (e.IdRubro = @IdRubro))
end
GO

create procedure SistemaCaido.GetRubros
as begin
	Select r.IdRubro, r.Nombre
	From SistemaCaido.Rubros r
end
GO

--********************************* ABM de Sucursales ****************************************--

create procedure [SistemaCaido].[AltaSucursal](@Nombre nvarchar(255), @Direccion nvarchar(255), @CodigoPostal varchar(4))
as begin transaction
	insert into SistemaCaido.Sucursales values (@Nombre, @Direccion, @CodigoPostal, 1)	
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo dar de alta la sucursal..', 1,1)
			rollback transaction
		end

	commit transaction

GO


create procedure [SistemaCaido].[BajaSucursal](@IdSucursal int)
as begin transaction
	-- Eliminacion logica
	update SistemaCaido.Sucursales set Habilitada = 0 where IdSucursal = @IdSucursal
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo dar de baja la sucursal..', 1,1)
			rollback transaction
		end

	commit transaction

GO


create procedure [SistemaCaido].[ModificacionSucursal]
(@IdSucursal int, @Nombre nvarchar(255), @Direccion nvarchar(255), @CodigoPostal varchar(4), @Habilitada bit) 
as begin transaction

	if((select count(*) from SistemaCaido.Sucursales where CodigoPostal = @CodigoPostal AND IdSucursal != @IdSucursal) > 0) THROW 51000, 'No se puede dar de alta la sucursal (CP existente)', 1;

	update SistemaCaido.Sucursales
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

GO


create procedure SistemaCaido.BuscarSucursales (@Nombre nvarchar(255), @CodigoPostal nvarchar(4),  @Direccion nvarchar(255))
as begin
	Select s.IdSucursal, s.CodigoPostal, s.Direccion, s.Habilitada, s.Nombre
	From SistemaCaido.Sucursales s
	where (@nombre is null or (s.Nombre like CONCAT('%',@nombre,'%')))
	and (@CodigoPostal is null or (s.CodigoPostal like CONCAT('%',@CodigoPostal,'%')))
	and (@Direccion is null or (s.Direccion like CONCAT('%', @Direccion,'%')))
end
GO


--********************************* ABM de Facturas ****************************************--

create procedure [SistemaCaido].AltaFactura
(@IdCliente int, @IdEmpresa int, @NumeroFactura numeric(18,0), @FechaVencimiento datetime, 
 @Items [SistemaCaido].Items readonly)
as begin transaction
	declare @Importe numeric(18,2)
	declare @Monto numeric(18,2)
	declare @Descripcion varchar
	declare @Cantidad numeric(18,0)
	declare @IdFactura int
	declare @IdProducto int

	set @Importe = 0

	-- Agregar la factura con importe 0
	insert into SistemaCaido.Facturas (IdCliente, IdEmpresa, NumeroFactura, FechaAlta, FechaVencimiento, Importe)
	values (@IdCliente, @IdEmpresa, @NumeroFactura, sysdatetime(), @FechaVencimiento, @Importe)	
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
			select Descripcion, Monto, Cantidad from @Items

			open items_cursor
			fetch next from items_cursor into  @Descripcion, @Monto, @Cantidad

			while(@@FETCH_STATUS = 0) 
			begin
				Insert into SistemaCaido.Productos (Descripcion, Precio)
				values (@Descripcion, @Monto)

				set @IDProducto = @@IDENTITY

				Insert into SistemaCaido.ProductosXFacturas (Cantidad, IdProducto, IdFactura)
				values(@Cantidad, @IdProducto, @IdFactura)

				set @Importe = @Importe + (@Monto * @Cantidad)
				
			end

			-- Actualizo el importe de la factura recientemente ingresada
			update SistemaCaido.Facturas set Importe = @Importe where IdFactura = @IdFactura
			
		end
	commit transaction

GO


create procedure [SistemaCaido].[BajaFactura](@IdFactura int)
as begin transaction
	--Se borra la factura?
	delete from SistemaCaido.Facturas where IdFactura = @IdFactura
	if (@@ERROR != 0)
		begin
			raiserror('No se pudo dar de baja la factura..', 1,1)
			rollback transaction
		end

	commit transaction

GO


Create procedure SistemaCaido.GetItemsFactura(@IdFactura int)
as begin
	Select p.Descripcion, p.Precio, pf.Cantidad
	From SistemaCaido.Facturas f
	Inner join SistemaCaido.ProductosXFacturas pf on pf.IdFactura = f.IdFactura
	Inner join SistemaCaido.Productos p on p.IdProducto = pf.IdProducto
	where f.IdFactura = @IdFactura
END
GO


Create procedure SistemaCaido.FacturaPuedeSerModificada(@IdFactura int)
as begin
	Select case when (p.IdPago is null and rd.IdRendicionXFactura is null) then 1 else 0 end
	from SistemaCaido.Facturas f
	left join SistemaCaido.DevolucionesXFacturas df on df.IdFactura = f.IdFactura
	left join SistemaCaido.Devoluciones d on d.IdDevolucion = df.IdDevolucion
	left join SistemaCaido.PagosXFacturas pf on pf.IdFactura = f.IdFactura
	left join SistemaCaido.Pagos p on p.IdPago = pf.IdPago And (d.IdDevolucion is null or d.Fecha < p.FechaCobro)
	left join SistemaCaido.RendicionesXFacturas rd on rd.IdFactura = f.IdFactura
	where f.IdFactura = @IdFactura
END
GO

create procedure [SistemaCaido].[ModificacionFactura]
(@IdFactura int, @IdCliente int, @IdEmpresa int, @NumeroFactura int, @FechaAlta datetime, @FechaVencimiento datetime, @Items SistemaCaido.Items readonly)
as begin transaction
	
	Declare @Descripcion varchar(250)
	Declare @Monto Numeric(18,2)
	Declare @IdProducto int
	Declare @Cantidad int
	Declare @Importe int
	Set @Importe = 0

	update SistemaCaido.Facturas
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

	delete p
	from SistemaCaido.Productos p
	Inner join SistemaCaido.ProductosXFacturas pf on pf.IdProducto = p.IdProducto
	where pf.IdFactura = @IdFactura

	delete from SistemaCaido.ProductosXFacturas
	where IdFactura = @IdFactura

	declare items_cursor cursor for
	select Descripcion, Monto, Cantidad from @Items

	open items_cursor
	fetch next from items_cursor into  @Descripcion, @Monto, @Cantidad

	while(@@FETCH_STATUS = 0) 
	begin
		Insert into SistemaCaido.Productos (Descripcion, Precio)
		values (@Descripcion, @Monto)

		set @IDProducto = @@IDENTITY

		Insert into SistemaCaido.ProductosXFacturas (Cantidad, IdProducto, IdFactura)
		values(@Cantidad, @IdProducto, @IdFactura)

		set @Importe = @Importe + (@Monto * @Cantidad)
				
	end

	update SistemaCaido.Facturas set Importe = @Importe where IdFactura = @IdFactura

	commit transaction

GO


create procedure SistemaCaido.BuscarFacturas (@numeroFactura int, @idCliente int)
as begin
	Select *
	From SistemaCaido.Facturas f
	where (@numeroFactura is null or (f.NumeroFactura = @numeroFactura))
	and (@idCliente is null or (@idCliente = f.IdCliente))

end
GO

--********************************* ABM de Clientes ****************************************--

create procedure [SistemaCaido].[sp_alta_cliente] (@nombre varchar(250), @apellido varchar(250), @fechanac date, @dni numeric(10,0), @direccion varchar(250),@codpost numeric(18,0), @telefono numeric(18,0), @email nvarchar(255))
as
begin

set xact_abort on
begin tran

	if((select count(*) from SistemaCaido.Clientes where Mail = @email) > 0) THROW 51000, 'Ya existe un cliente con el mail ingresado.', 1;
	
	declare @usuario varchar(255)
	declare @contraseña varchar(255)
	set @usuario =   convert(varchar(255), @dni)
	set @contraseña =   convert(varchar(255), @dni)

	insert into SistemaCaido.Clientes(Nombre,Apellido,FechaNacimiento,DNI,Direccion,CodigoPostal,Telefono, Mail)
	values(@nombre, @apellido, @fechanac, @dni, @direccion, @codpost, @telefono, @email)

commit

end

GO


create procedure [SistemaCaido].[sp_baja_cliente] (@idcliente numeric(10,0)) as
begin
	update SistemaCaido.clientes
	set Habilitado = 0
	where IdCliente = @idcliente
end

GO


create procedure [SistemaCaido].[sp_update_cliente] (@nombre varchar(250),  @apellido varchar(250), @DNI numeric(18), @fechaNacimiento date, @direccion varchar(250), @codPostal numeric, @telefono numeric(18,0), @habilitado bit, @idcliente numeric(10,0), @email nvarchar(255)) as
begin

set xact_abort on
begin tran	

if((select count(*) from SistemaCaido.Clientes where Mail = @email and @idcliente != IdCliente) > 0) THROW 51000, 'Ya existe un cliente con el mail ingresado.', 1;

update SistemaCaido.Clientes
set Nombre = @nombre,
Apellido = @apellido,
FechaNacimiento = @fechaNacimiento,
Direccion = @direccion,
CodigoPostal = @codPostal,
Telefono = @telefono,
DNI = @DNI,
Mail = @email,
Habilitado = @habilitado
where IdCliente = @idcliente

commit

end

GO


create procedure [SistemaCaido].[sp_get_clientes](@nombre varchar(250), @apellido varchar(250), @dni numeric(18,0), @habilitado bit) as
begin

select  IdCliente ID,Nombre as Nombre ,Apellido as Apellido ,CodigoPostal as Codigo_Postal,Direccion as Direccion ,DNI as DNI,FechaNacimiento as Fecha_Nacimiento ,ISNULL(Telefono, '') as Telefono,Habilitado as Habilitado, Mail as Mail
from SistemaCaido.Clientes
where (@apellido is null or (Apellido like CONCAT('%',@apellido,'%')))
and   (@nombre is null or   (Nombre like CONCAT('%',@nombre,'%')))
and	  (@dni is null or (DNI = @dni))
and   (@habilitado is null or (Habilitado = @habilitado))
order by Nombre, Apellido

OPTION (RECOMPILE)
end

GO

--********************************* Registrar Pago ****************************************--

create procedure [SistemaCaido].[RegistrarPago](@IdsFacturas SistemaCaido.listaIDs readonly,
											  @Cliente int, @Sucursal int, @MedioPago int)
as begin transaction
	declare @ImporteTotal numeric(18,2) 
	declare @NumeroPago int
	declare @IdPago int

	set @ImporteTotal = 0
	set @NumeroPago = 0

	select @ImporteTotal = SUM(fact1.Importe) 
	from Facturas fact1
	join @IdsFacturas fact2 on fact1.IdFactura = fact2.id

	select @NumeroPago = SistemaCaido.GetSiguienteNumeroDePago()

	if(@ImporteTotal = 0)
		THROW 51000, 'No se pudo registrar el pago, el importe total es 0', 1;
	
	if((select count(*) from SistemaCaido.Facturas f
					   Inner join @IdsFacturas i on f.IdFactura = i.id
					   Inner join Empresas e on e.IdEmpresa = f.IdEmpresa
					   where e.Habilitada = 0) > 0)
		THROW 51000, 'No se pudo registrar el pago, hay facturas de empresas no habilitadas', 1;
	
	insert into SistemaCaido.Pagos (NumeroPago, FechaCobro, IdCliente, Importe, IdSucursal, IdMedioPago)
	values (@NumeroPago, sysdatetime(), @Cliente, @ImporteTotal, @Sucursal, @MedioPago)

	set @IdPago = SCOPE_IDENTITY()

	insert into SistemaCaido.PagosXFacturas (IdFactura, IdPago)
	Select f.id, @IdPago
	From @IdsFacturas f

commit transaction

GO


Create procedure SistemaCaido.GetFacturasClienteParaPago(@IdCliente INT)
as begin
	Select *
	From SistemaCaido.Facturas f
	where f.IdCliente = @IdCliente
	and f.IdFactura not in (select f2.IdFactura
							from SistemaCaido.Facturas f2
							Inner join SistemaCaido.PagosXFacturas pf on pf.IdFactura = f2.IdFactura
							Inner join SistemaCaido.Pagos p on pf.IdPago = p.IdPago
							left join SistemaCaido.DevolucionesXFacturas df on df.IdFactura = f2.IdFactura
							left join SistemaCaido.Devoluciones d on d.IdDevolucion = df.IdDevolucion
							where d.IdDevolucion is null
							or d.Fecha < p.FechaCobro )
END
GO


create procedure SistemaCaido.GetMediosDePago
as begin
	Select *
	From SistemaCaido.MediosPago
end
GO


--********************************* Registrar rendicion ****************************************--

Create procedure SistemaCaido.GetDatosRendicion (@IdEmpresa INT, @fecha datetime)
as begin

	if((select count(*) from SistemaCaido.Rendiciones r where r.IdEmpresa = @IdEmpresa and YEAR(r.Fecha) = YEAR(@fecha) and MONTH(r.Fecha) = MONTH(@fecha)) > 0)
		THROW 51000, 'Ya existe una rendicion para esta empresa en el mes de la fecha', 1;

	Select f.*, p.*
	From SistemaCaido.Facturas f
	Inner join SistemaCaido.PagosXFacturas pf on pf.IdFactura = f.IdFactura
	Inner join SistemaCaido.Pagos p  on p.IdPago = pf.IdPago
	where f.IdEmpresa = @IdEmpresa
	and YEAR(p.FechaCobro) = YEAR(@fecha)
	and MONTH(p.FechaCobro) = MONTH(@fecha)
	order by f.NumeroFactura

	Select ISNULL(SUM(f.Importe),0) 'Importe_Total', ISNULL(SUM(f.Importe) * ((Select top 1 p.Porcentaje from SistemaCaido.Porcentajes p order by p.IdPorcentaje desc)),0)	'Importe_Empresa'		
	From SistemaCaido.Facturas f
	Inner join SistemaCaido.PagosXFacturas pf on pf.IdFactura = f.IdFactura
	Inner join SistemaCaido.Pagos p  on p.IdPago = pf.IdPago
	where f.IdEmpresa = @IdEmpresa
	and YEAR(p.FechaCobro) = YEAR(@fecha)
	and MONTH(p.FechaCobro) = MONTH(@fecha)

	select top 1 p.Porcentaje * 100 'Porcentaje'
	From SistemaCaido.Porcentajes p
	order by p.IdPorcentaje desc

END
GO

Create procedure SistemaCaido.RealizarRendicion(@IdEmpresa INT, @fecha datetime)
as begin
	if((select count(*) from SistemaCaido.Rendiciones r where r.IdEmpresa = @IdEmpresa and YEAR(r.Fecha) = YEAR(@fecha) and MONTH(r.Fecha) = MONTH(@fecha)) > 0)
		THROW 51000, 'Ya existe una rendicion para esta empresa en el mes de la fecha', 1;
	else
		BEGIN
		Insert into SistemaCaido.Rendiciones (Fecha, IdEmpresa, IdPorcentaje, ImporteTotal, ImporteEmpresa, NumeroRendicion)
		Select @fecha, @IdEmpresa, (Select top 1 p.IdPorcentaje from SistemaCaido.Porcentajes p order by p.IdPorcentaje desc), ISNULL(SUM(f.Importe),0), ISNULL(SUM(f.Importe) * ((Select top 1 p.Porcentaje from SistemaCaido.Porcentajes p order by p.IdPorcentaje desc)),0), SistemaCaido.GetSiguienteNumeroDeRendicion()   
		From SistemaCaido.Facturas f
		Inner join SistemaCaido.PagosXFacturas pf on pf.IdFactura = f.IdFactura
		Inner join SistemaCaido.Pagos p  on p.IdPago = pf.IdPago
		where f.IdEmpresa = @IdEmpresa
		and YEAR(p.FechaCobro) = YEAR(@fecha)
		and MONTH(p.FechaCobro) = MONTH(@fecha)
		END

		Declare @IDRendicion INT
		Set @IDrendicion = @@Identity

		Insert into SistemaCaido.RendicionesXFacturas (IdFactura, IdRendicion)
		Select f.IdFactura, @IDRendicion
		From SistemaCaido.Facturas f
		Inner join SistemaCaido.PagosXFacturas pf on pf.IdFactura = f.IdFactura
		Inner join SistemaCaido.Pagos p  on p.IdPago = pf.IdPago
		where f.IdEmpresa = @IdEmpresa
		and YEAR(p.FechaCobro) = YEAR(@fecha)
		and MONTH(p.FechaCobro) = MONTH(@fecha)
END
GO


create procedure SistemaCaido.GetEmpresasHabilitadas
as begin
	select *
	from SistemaCaido.Empresas e
	where e.Habilitada = 1
END
GO

--********************************* Registrar devolucion ****************************************--

Create Procedure SistemaCaido.GetFacturasParaDevolucionCliente(@IdCliente INT)
as begin
	Select *
	From SistemaCaido.Facturas f
	Inner join SistemaCaido.PagosXFacturas pf on pf.IdFactura = f.IdFactura
	Inner join SistemaCaido.Pagos p on p.IdPago = pf.IdPago
	where (p.FechaCobro > (select top 1 ISNULL(d.Fecha, 0)
						   from SistemaCaido.Facturas f2
						   left join SistemaCaido.DevolucionesXFacturas df on df.IdFactura = f2.IdFactura
						   left join SistemaCaido.Devoluciones d on d.IdDevolucion = df.IdDevolucion
						   where f2.IdFactura = f.IdFactura
						   order by d.Fecha desc))  --No haya sido devuelta
	And (f.IdFactura not in (select rf.IdFactura
							 from SistemaCaido.RendicionesXFacturas rf)) --No haya sido rendida
	And f.IdCliente = @IdCliente
END
GO

Create procedure SistemaCaido.RealizarDevolucion (@IdCliente INT, @Motivo nvarchar(255), @Fecha DateTime, @ListaIdsFacturas SistemaCaido.listaIDs readonly)
as begin

set xact_abort on
begin tran

Insert into SistemaCaido.Devoluciones (Fecha, IdCliente, Motivo)
values(@Fecha, @IdCliente, @Motivo)

Insert into SistemaCaido.DevolucionesXFacturas (IdDevolucion, IdFactura)
Select @@IDENTITY, f.id
From @ListaIdsFacturas f

commit
END
GO


--********************************* ABM de Rol ****************************************--

create procedure [SistemaCaido].[sp_alta_rol] (@nombre varchar(255), @habilitado  bit, @listaFuncionalidades sistemaCaido.listaIDs readonly)
as
begin

set xact_abort on
begin tran

if(sistemaCaido.existeRolConMismoNombre( @nombre, null) = 1) THROW 51000, 'Ya existe un Rol con el nombre ingresado.', 1;	

insert into SistemaCaido.Roles (Nombre, Habilitado)
values(@nombre, @habilitado)

insert into SistemaCaido.RolesXFuncionalidades (IdRol, IdFuncionalidad)
select  IdRol, id
from @listaFuncionalidades, SistemaCaido.Roles
where @nombre = Nombre

commit
end

GO


create procedure [SistemaCaido].[sp_baja_rol] (@id numeric(10,0))
as
begin

update SistemaCaido.Roles 
set Habilitado = 0
where idRol = @id

delete SistemaCaido.UsuariosXRoles
where IdRol = @id


end

GO


create procedure [SistemaCaido].[sp_update_rol] (@id numeric(10,0), @nombre varchar(255), @habilitado bit, @listaFuncionalidades SistemaCaido.listaIDs readonly)	
as
begin

set xact_abort on
begin tran

if(SistemaCaido.existeRolConMismoNombre(@nombre, @id) = 1) THROW 51000, 'Ya existe un Rol con el nombre ingresado.', 1;

update SistemaCaido.Roles
set Nombre = @nombre, Habilitado = @habilitado
where IdRol = @id

delete from SistemaCaido.RolesXFuncionalidades
where IdRol = @id

insert into SistemaCaido.RolesXFuncionalidades (IdRol, IdFuncionalidad)
select  @id, id
from @listaFuncionalidades

commit

end

GO



create procedure [SistemaCaido].[sp_get_funcionalidades] as
begin
	select * 
	from SistemaCaido.Funcionalidades
end

GO


create procedure [SistemaCaido].[sp_get_funcionalidades_rol](@idRol numeric(10,0)) as
begin
	select f.*
	from SistemaCaido.funcionalidades f, SistemaCaido.RolesXFuncionalidades rf
	where @idRol = rf.IdRol
	and rf.IdFuncionalidad = f.IdFuncionalidad
end

GO


create procedure [SistemaCaido].[sp_get_roles_habilitados]
as
begin

select * 
from Roles
where Habilitado = 1

end

GO

--********************************* Login ****************************************--

create procedure [SistemaCaido].[sp_incrementar_intentos_fallidos] (@username varchar(255))
as
begin

update  SistemaCaido.Usuarios set IntentosFallidos = (IntentosFallidos + 1)
where Username = @username

end

GO


create procedure [SistemaCaido].[sp_limpiar_intentos_fallidos] (@username varchar(255))
as
begin

update SistemaCaido.Usuarios set IntentosFallidos = 0
where Username = @username

end

GO


create procedure [SistemaCaido].[sp_login_check](@username varchar (255), @contrasenia varchar(255), @retorno int output)
as
begin

 if (SistemaCaido.existeUsuario(@username)) = 0 set @retorno = -1
	else
	begin
	if(SistemaCaido.usuarioActivo(@username) = 0) set @retorno = -3
		else
		if(select Password
		from SistemaCaido.Usuarios
		where Username = @username) = HASHBYTES('SHA2_256',cast(@contrasenia as varchar(255)))begin  set @retorno = (select u.IdUsuario  from SistemaCaido.Usuarios u where u.Username = @username) exec SistemaCaido.sp_limpiar_intentos_fallidos @username end
			else 
			begin
			set @retorno=-2
			exec SistemaCaido.sp_incrementar_intentos_fallidos @username 
			end
		end
	return @retorno

end

GO


create procedure [SistemaCaido].[sp_get_roles]
as
begin

select IdRol as ID, Nombre as Descripcion, Habilitado as Habilitado
from SistemaCaido.Roles

end

GO


create procedure [SistemaCaido].[sp_get_roles_usuario] (@idUsuario numeric (10,0))	
as
begin

select r.*
from SistemaCaido.Usuarios u, SistemaCaido.UsuariosXRoles ur, SistemaCaido.Roles r
where u.IdUsuario = @idUsuario
and u.IdUsuario = ur.IdUsuario
and ur.IdRol = r.IdRol
and r.Habilitado = 1 	

end

GO


--=============================================================================================================--
--=============================================================================================================--
--*************************************** Listados Estadisticos ***********************************************--                                 
--=============================================================================================================--
--=============================================================================================================--


create procedure [SistemaCaido].[ClientesConMasPagos](@Anio int, @Trimestre int)
as begin
	select top 5 c.Nombre, c.Apellido, ISNULL(count(*),0) CantidadPagos 
	from SistemaCaido.Pagos p
	Join SistemaCaido.Clientes c on p.IdCliente = c.IdCliente
	where year(FechaCobro) = @Anio and
		  month(FechaCobro) between ((3 * @Trimestre) - 2) and (3 * @Trimestre)
  group by c.IdCliente, c.Nombre, c.Apellido
  order by CantidadPagos desc
end

GO


create procedure [SistemaCaido].[EmpresasConMayorMontoRendido](@Anio int, @Trimestre int)
as begin
	select top 5 emp.Nombre Empresa, ISNULL(SUM(ImporteEmpresa),0) MontoRendido
	from SistemaCaido.Empresas emp
	join SistemaCaido.Rendiciones rend on emp.IdEmpresa = rend.IdEmpresa
	join SistemaCaido.Porcentajes porc on rend.IdPorcentaje = porc.IdPorcentaje
	where year(rend.Fecha) = @Anio and
		  month(rend.Fecha) between ((3 * @Trimestre) - 2) and (3 * @Trimestre)
	group by emp.IdEmpresa, emp.Nombre
	order by MontoRendido desc
end
GO


Create procedure SistemaCaido.EmpresasConMayorPorcentajeFacturasCobradas (@Anio int, @Trimestre int)
as begin
	Select top 5 e.Nombre , convert(decimal(5,2),((COUNT(distinct f.IdFactura) * 100) / cast((select count(*) 
							  from SistemaCaido.PagosXFacturas pf2 
							  Join SistemaCaido.Pagos p2 on pf2.IdPago = p2.IdPago 
					   		  where  YEAR(p2.FechaCobro) = @Anio
							  And MONTH(p2.FechaCobro) between ((3 * @Trimestre) - 2) and (3 * @Trimestre)) as float))) Porcentaje_Facturas
	From SistemaCaido.Empresas e
	Join SistemaCaido.Facturas f on f.IdEmpresa = e.IdEmpresa
	Join SistemaCaido.PagosXFacturas pf on f.IdFactura = pf.IdFactura
	Join SistemaCaido.Pagos p on p.IdPago = pf.IdPago
	where  YEAR(p.FechaCobro) = @Anio
	And MONTH(p.FechaCobro) between (3 * @Trimestre - 2) and (3 * @Trimestre)
	group by e.IdEmpresa, e.Nombre
	order by Porcentaje_Facturas desc
end
GO


Create procedure SistemaCaido.ClientesConMayorPorcentajeFacturasPagadas (@Anio int, @Trimestre int)
as begin
	Select top 5 c.Nombre, c.Apellido, Convert(decimal(4,2),((COUNT(distinct f.IdFactura) * 100) / cast((select count(*) 
							  from SistemaCaido.PagosXFacturas pf2 
							  Join SistemaCaido.Pagos p2 on pf2.IdPago = p2.IdPago 
					   		  where  YEAR(p2.FechaCobro) = @Anio
							  And MONTH(p2.FechaCobro) between (3 * @Trimestre - 2) and (3 * @Trimestre)) as float))) Porcentaje_Facturas
	From SistemaCaido.Clientes c
	Join SistemaCaido.Facturas f on c.IdCliente = f.IdCliente
	Join SistemaCaido.PagosXFacturas pf on f.IdFactura = pf.IdFactura
	Join SistemaCaido.Pagos p on p.IdPago = pf.IdPago
	where  YEAR(p.FechaCobro) = @Anio
	And MONTH(p.FechaCobro) between ((3 * @Trimestre) - 2) and (3 * @Trimestre)
	group by c.IdCliente, c.Nombre, c.Apellido
	order by Porcentaje_Facturas desc
end
GO





