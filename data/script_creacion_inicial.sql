USE [GD2C2017]

--=============================================================================================================--
--*************************************** Dropeos *************************************************************--                                 
--=============================================================================================================--
GO
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
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_uxs_usuario]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXSucursales]'))
ALTER TABLE [SistemaCaido].[UsuariosXSucursales] DROP CONSTRAINT [fk_uxs_usuario]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_uxs_sucursal]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXSucursales]'))
ALTER TABLE [SistemaCaido].[UsuariosXSucursales] DROP CONSTRAINT [fk_uxs_sucursal]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_uxr_usuario]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXRoles]'))
ALTER TABLE [SistemaCaido].[UsuariosXRoles] DROP CONSTRAINT [fk_uxr_usuario]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_uxr_rol]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXRoles]'))
ALTER TABLE [SistemaCaido].[UsuariosXRoles] DROP CONSTRAINT [fk_uxr_rol]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[FK__UsuariosX__IdUsu__0A54486F]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXRoles]'))
ALTER TABLE [SistemaCaido].[UsuariosXRoles] DROP CONSTRAINT [FK__UsuariosX__IdUsu__0A54486F]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[FK__UsuariosX__IdRol__0B486CA8]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXRoles]'))
ALTER TABLE [SistemaCaido].[UsuariosXRoles] DROP CONSTRAINT [FK__UsuariosX__IdRol__0B486CA8]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rxf_rol]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RolesXFuncionalidades]'))
ALTER TABLE [SistemaCaido].[RolesXFuncionalidades] DROP CONSTRAINT [fk_rxf_rol]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rxf_funcionalidad]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RolesXFuncionalidades]'))
ALTER TABLE [SistemaCaido].[RolesXFuncionalidades] DROP CONSTRAINT [fk_rxf_funcionalidad]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[FK__RolesXFun__IdRol__049B6F19]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RolesXFuncionalidades]'))
ALTER TABLE [SistemaCaido].[RolesXFuncionalidades] DROP CONSTRAINT [FK__RolesXFun__IdRol__049B6F19]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[FK__RolesXFun__IdFun__058F9352]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RolesXFuncionalidades]'))
ALTER TABLE [SistemaCaido].[RolesXFuncionalidades] DROP CONSTRAINT [FK__RolesXFun__IdFun__058F9352]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rxf_rendicion]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RendicionesXFacturas]'))
ALTER TABLE [SistemaCaido].[RendicionesXFacturas] DROP CONSTRAINT [fk_rxf_rendicion]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rxf_factura]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RendicionesXFacturas]'))
ALTER TABLE [SistemaCaido].[RendicionesXFacturas] DROP CONSTRAINT [fk_rxf_factura]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[FK__Rendicion__IdRen__17AE438D]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RendicionesXFacturas]'))
ALTER TABLE [SistemaCaido].[RendicionesXFacturas] DROP CONSTRAINT [FK__Rendicion__IdRen__17AE438D]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[FK__Rendicion__IdFac__18A267C6]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RendicionesXFacturas]'))
ALTER TABLE [SistemaCaido].[RendicionesXFacturas] DROP CONSTRAINT [FK__Rendicion__IdFac__18A267C6]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rendiciones_porcentajes]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Rendiciones]'))
ALTER TABLE [SistemaCaido].[Rendiciones] DROP CONSTRAINT [fk_rendiciones_porcentajes]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rendiciones_empresa]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Rendiciones]'))
ALTER TABLE [SistemaCaido].[Rendiciones] DROP CONSTRAINT [fk_rendiciones_empresa]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pxf_productos]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[ProductosXFacturas]'))
ALTER TABLE [SistemaCaido].[ProductosXFacturas] DROP CONSTRAINT [fk_pxf_productos]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pxf_facturas]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[ProductosXFacturas]'))
ALTER TABLE [SistemaCaido].[ProductosXFacturas] DROP CONSTRAINT [fk_pxf_facturas]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_porcentajes_usuario]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Porcentajes]'))
ALTER TABLE [SistemaCaido].[Porcentajes] DROP CONSTRAINT [fk_porcentajes_usuario]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pxf_pago]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[PagosXFacturas]'))
ALTER TABLE [SistemaCaido].[PagosXFacturas] DROP CONSTRAINT [fk_pxf_pago]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pxf_factura]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[PagosXFacturas]'))
ALTER TABLE [SistemaCaido].[PagosXFacturas] DROP CONSTRAINT [fk_pxf_factura]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pagos_sucursal]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Pagos]'))
ALTER TABLE [SistemaCaido].[Pagos] DROP CONSTRAINT [fk_pagos_sucursal]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pagos_mediopago]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Pagos]'))
ALTER TABLE [SistemaCaido].[Pagos] DROP CONSTRAINT [fk_pagos_mediopago]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pagos_cliente]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Pagos]'))
ALTER TABLE [SistemaCaido].[Pagos] DROP CONSTRAINT [fk_pagos_cliente]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_facturas_empresas]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Facturas]'))
ALTER TABLE [SistemaCaido].[Facturas] DROP CONSTRAINT [fk_facturas_empresas]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_facturas_clientes]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Facturas]'))
ALTER TABLE [SistemaCaido].[Facturas] DROP CONSTRAINT [fk_facturas_clientes]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_empresas_rubros]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Empresas]'))
ALTER TABLE [SistemaCaido].[Empresas] DROP CONSTRAINT [fk_empresas_rubros]


GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[SistemaCaido].[DF__Usuarios__Intent__5E75C631]') AND type = 'D')
BEGIN
ALTER TABLE [SistemaCaido].[Usuarios] DROP CONSTRAINT [DF__Usuarios__Intent__5E75C631]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[SistemaCaido].[DF__Sucursale__Habil__615232DC]') AND type = 'D')
BEGIN
ALTER TABLE [SistemaCaido].[Sucursales] DROP CONSTRAINT [DF__Sucursale__Habil__615232DC]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[SistemaCaido].[DF__Roles__Habilitad__5B995986]') AND type = 'D')
BEGIN
ALTER TABLE [SistemaCaido].[Roles] DROP CONSTRAINT [DF__Roles__Habilitad__5B995986]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[SistemaCaido].[DF__Facturas__Habili__7370E317]') AND type = 'D')
BEGIN
ALTER TABLE [SistemaCaido].[Facturas] DROP CONSTRAINT [DF__Facturas__Habili__7370E317]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[SistemaCaido].[DF__Empresas__Habili__6FA05233]') AND type = 'D')
BEGIN
ALTER TABLE [SistemaCaido].[Empresas] DROP CONSTRAINT [DF__Empresas__Habili__6FA05233]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[SistemaCaido].[DF__Clientes__Habili__642E9F87]') AND type = 'D')
BEGIN
ALTER TABLE [SistemaCaido].[Clientes] DROP CONSTRAINT [DF__Clientes__Habili__642E9F87]
END

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_dev_usuario]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXRoles]'))
ALTER TABLE [SistemaCaido].[Devoluciones] DROP CONSTRAINT [fk_dev_usuario]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_dev_cliente]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXRoles]'))
ALTER TABLE [SistemaCaido].[Devoluciones] DROP CONSTRAINT [fk_dev_cliente]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_dxf_dev]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXRoles]'))
ALTER TABLE [SistemaCaido].[DevolucionesXFacturas] DROP CONSTRAINT [fk_dxf_dev]

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_dxf_factura]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXRoles]'))
ALTER TABLE [SistemaCaido].[DevolucionesXFacturas] DROP CONSTRAINT [fk_dxf_factura]

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[EmpresasConMayorMontoRendido]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [SistemaCaido].[EmpresasConMayorMontoRendido]

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[ClientesConMasPagos]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [SistemaCaido].[ClientesConMasPagos]

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
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Sucursales]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Sucursales]

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Rubros]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Rubros]

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
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Clientes]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Clientes]

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Devoluciones]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[Devoluciones]

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[DevolucionesXFacturas]') AND type in (N'U'))
DROP TABLE [SistemaCaido].[DevolucionesXFacturas]

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[usuarioActivo]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [SistemaCaido].[usuarioActivo]

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[existeUsuario]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [SistemaCaido].[existeUsuario]

GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[existeRolConMismoNombre]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [SistemaCaido].[existeRolConMismoNombre]

GO
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
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'tablaFacturas' AND ss.name = N'SistemaCaido')
DROP TYPE [SistemaCaido].[tablaFacturas]

GO
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'listaIDs' AND ss.name = N'SistemaCaido')
DROP TYPE [SistemaCaido].[listaIDs]

GO
IF  EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Items' AND ss.name = N'SistemaCaido')
DROP TYPE [SistemaCaido].[Items]

GO
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'SistemaCaido')
DROP SCHEMA [SistemaCaido]

--=============================================================================================================--
--*************************************** Creacion de Esquema *************************************************--                                 
--=============================================================================================================--

GO
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'SistemaCaido')
EXEC sys.sp_executesql N'CREATE SCHEMA [SistemaCaido]'


--=============================================================================================================--
--*************************************** Creacion de Tipos ***************************************************--                                 
--=============================================================================================================--
GO
IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'Items' AND ss.name = N'SistemaCaido')
CREATE TYPE [SistemaCaido].[Items] AS TABLE(
	[Producto] [int] NULL,
	[Monto] [numeric](18, 2) NULL,
	[Cantidad] [numeric](18, 0) NULL
)
GO

IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'listaIDs' AND ss.name = N'SistemaCaido')
CREATE TYPE [SistemaCaido].[listaIDs] AS TABLE(
	[id] [int] NULL
)
GO

IF NOT EXISTS (SELECT * FROM sys.types st JOIN sys.schemas ss ON st.schema_id = ss.schema_id WHERE st.name = N'tablaFacturas' AND ss.name = N'SistemaCaido')
CREATE TYPE [SistemaCaido].[tablaFacturas] AS TABLE(
	[NumeroFactura] [int] NULL,
	[FechaCobro] [datetime] NULL DEFAULT (sysdatetime()),
	[Empresa] [int] NULL,
	[Cliente] [int] NULL,
	[FechaVencimiento] [datetime] NULL,
	[Importe] [numeric](18, 2) NULL,
	[Sucursal] [int] NULL
)
GO

--=============================================================================================================--
--*************************************** Stored Procedures ***************************************************--                                 
--=============================================================================================================--
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

--********************************* ABM de Empresas ****************************************--

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[AltaEmpresa]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[AltaEmpresa](@Nombre nvarchar(255), @CUIT nvarchar(50), @Direccion nvarchar(255), @IdRubro int)
as begin transaction
	insert into Empresas values (@Nombre, @CUIT, @Direccion, @IdRubro, 1)
	if (@@ERROR != 0)
		begin
			raiserror(''No se pudo dar de alta la empresa..'', 1,1)
			rollback transaction
		end

	commit transaction' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[BajaEmpresa]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[BajaEmpresa](@IdEmpresa int)
as begin transaction

	declare @cantidadFacturas int

	select @cantidadFacturas = count(*) from RendicionesXFacturas rxf
	join Rendiciones ren on rxf.IdRendicion = ren.IdRendicion
	where ren.IdEmpresa = @IdEmpresa
	
	if @cantidadFacturas != 0
		begin
			raiserror(''No se pudo dar de baja la empresa (Facturas sin rendir)..'', 1,1)
			rollback transaction
		end		

	-- Eliminacion logica
	update Empresas set Habilitada = 0 where IdEmpresa = @IdEmpresa
	if (@@ERROR != 0)
		begin
			raiserror(''No se pudo dar de baja la empresa..'', 1,1)
			rollback transaction
		end

	commit transaction' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[ModificacionEmpresa]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
create procedure [SistemaCaido].[ModificacionEmpresa](@IdEmpresa int, @Nombre nvarchar(255), @CUIT nvarchar(50), @Direccion nvarchar(255), @IdRubro int, @Habilitada char)
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
			raiserror(''No se pudo modificar la empresa..'', 1,1)
			rollback transaction
		end

	commit transaction' 
END



--********************************* ABM de Sucursales ****************************************--
GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[AltaSucursal]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[AltaSucursal](@Nombre nvarchar(255), @Direccion nvarchar(255), @CodigoPostal varchar(4))
as begin transaction
	insert into Sucursales values (@Nombre, @Direccion, @CodigoPostal, 1)	
	if (@@ERROR != 0)
		begin
			raiserror(''No se pudo dar de alta la sucursal..'', 1,1)
			rollback transaction
		end

	commit transaction' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[BajaSucursal]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[BajaSucursal](@IdSucursal int)
as begin transaction
	-- Eliminacion logica
	update Sucursales set Habilitada = 0 where IdSucursal = @IdSucursal
	if (@@ERROR != 0)
		begin
			raiserror(''No se pudo dar de baja la sucursal..'', 1,1)
			rollback transaction
		end

	commit transaction' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[ModificacionSucursal]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[ModificacionSucursal]
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
			raiserror(''No se pudo dar de baja la sucursal..'', 1,1)
			rollback transaction
		end

	commit transaction' 
END



--********************************* ABM de Facturas ****************************************--
GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[AltaFactura]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

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
			raiserror(''No se pudo dar de alta la factura..'', 1,1)
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
						raiserror(''No existe el producto..'', 1,1)
						rollback transaction
					end
				else
					begin
						insert into ProductosXFacturas values(@Producto, @IdFactura, @Cantidad)
						if (@@ERROR != 0)
							begin
								raiserror(''No se pudo dar de alta el item de factura..'', 1,1)
								rollback transaction
							end
						else
							set @Importe = @Importe + (@Monto * @Cantidad)
					end
			end

			-- Actualizo el importe de la factura recientemente ingresada
			update Facturas set Importe = @Importe where IdFactura = @IdFactura
			
		end
	commit transaction'
END


GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[BajaFactura]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[BajaFactura](@IdFactura int)
as begin transaction
	--Se borra la factura?
	delete from Facturas where IdFactura = @IdFactura
	if (@@ERROR != 0)
		begin
			raiserror(''No se pudo dar de baja la factura..'', 1,1)
			rollback transaction
		end

	commit transaction' 
END


GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[ModificacionFactura]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
create procedure [SistemaCaido].[ModificacionFactura]
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
			raiserror(''No se pudo modificar la factura..'', 1,1)
			rollback transaction
		end

	commit transaction' 
END

--********************************* ABM de Clientes ****************************************--
GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_alta_cliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[sp_alta_cliente] (@nombre varchar(250), @apellido varchar(250), @fechanac date, @dni numeric(10,0), @direccion varchar(250),@codpost numeric(18,0), @telefono numeric(18,0))
as
begin

set xact_abort on
begin tran

	if((select count(*) from SistemaCaido.Clientes where DNI = @dni) > 0) THROW 51000, ''Ya existe un cliente con el numero de DNI ingresado.'', 1;

	declare @usuario varchar(255)
	declare @contraseña varchar(255)
	set @usuario =   convert(varchar(255), @dni)
	set @contraseña =   convert(varchar(255), @dni)

	insert into SistemaCaido.Clientes(Nombre,Apellido,FechaNacimiento,DNI,Direccion,CodigoPostal,Telefono)
	values(@nombre, @apellido, @fechanac, @dni, @direccion, @codpost, @telefono)

commit

end' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_baja_cliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[sp_baja_cliente] (@idcliente numeric(10,0)) as
begin
	update SistemaCaido.clientes
	set Habilitado = 0
	where IdCliente = @idcliente
end' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_get_clientes]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[sp_get_clientes](@nombre varchar(250), @apellido varchar(250), @dni numeric(18,0), @habilitado bit) as
begin

select IdCliente as ID, Nombre as Nombre ,Apellido as Apellido ,CodigoPostal as Codigo_Postal,Direccion as Direccion ,DNI as DNI,FechaNacimiento as Fecha_Nacimiento ,Telefono as Telefono,Habilitado as Habilitado
from SistemaCaido.Clientes
where (@apellido is null or (Apellido like CONCAT(''%'',@apellido,''%'')))
and   (@nombre is null or   (Nombre like CONCAT(''%'',@nombre,''%'')))
and	  (@dni is null or (DNI = @dni))
and   (@habilitado is null or (Habilitado = @habilitado))

OPTION (RECOMPILE)
end' 
END


--********************************* Registrar Pago ****************************************--
GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[RegistrarPago]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[RegistrarPago](@Facturas SistemaCaido.tablaFacturas readonly,
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
					raiserror(''No se pudo registrar el pago..'', 1,1)
					rollback transaction
				end
			commit transaction
		end' 
END


--********************************* ABM de Rol ****************************************--
GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_alta_rol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[sp_alta_rol] (@nombre varchar(255), @habilitado  bit, @listaFuncionalidades sistemaCaido.listaIDs readonly)
as
begin

set xact_abort on
begin tran

if(sistemaCaido.existeRolConMismoNombre( @nombre, null) = 1) THROW 51000, ''Ya existe un Rol con el nombre ingresado.'', 1;	

insert into SistemaCaido.Roles (Nombre, Habilitado)
values(@nombre, @habilitado)

insert into SistemaCaido.RolesXFuncionalidades (IdRol, IdFuncionalidad)
select  IdRol, id
from @listaFuncionalidades, SistemaCaido.Roles
where @nombre = Nombre

commit
end' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_baja_rol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[sp_baja_rol] (@id numeric(10,0))
as
begin

update SistemaCaido.Roles 
set Habilitado = 0
where idRol = @id

end' 
END


GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_get_funcionalidades]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[sp_get_funcionalidades] as
begin
	select * 
	from SistemaCaido.Funcionalidades
end' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_get_funcionalidades_rol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[sp_get_funcionalidades_rol](@idRol numeric(10,0)) as
begin
	select f.*
	from SistemaCaido.funcionalidades f, SistemaCaido.RolesXFuncionalidades rf
	where @idRol = rf.IdRol
	and rf.IdFuncionalidad = f.IdFuncionalidad
end' 
END


GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_get_roles_habilitados]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[sp_get_roles_habilitados]
as
begin

select * 
from Roles
where Habilitado = 1

end' 
END


--********************************* Login ****************************************--
GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_incrementar_intentos_fallidos]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[sp_incrementar_intentos_fallidos] (@username varchar(255))
as
begin

update  SistemaCaido.Usuarios set IntentosFallidos = (IntentosFallidos + 1)
where Username = @username

end' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_limpiar_intentos_fallidos]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[sp_limpiar_intentos_fallidos] (@username varchar(255))
as
begin

update SistemaCaido.Usuarios set IntentosFallidos = 0
where Username = @username

end' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_login_check]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

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
		where Username = @username) = HASHBYTES(''SHA2_256'',cast(@contrasenia as varchar(255)))begin  set @retorno = (select u.IdUsuario  from SistemaCaido.Usuarios u where u.Username = @username) exec SistemaCaido.sp_limpiar_intentos_fallidos @username end
			else 
			begin
			set @retorno=-2
			exec SistemaCaido.sp_incrementar_intentos_fallidos @username 
			end
		end
	return @retorno

end' 
END


GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_get_roles]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[sp_get_roles]
as
begin

select IdRol as ID, Nombre as Descripcion, Habilitado as Habilitado
from Roles

end' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_get_roles_usuario]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[sp_get_roles_usuario] (@idUsuario numeric (10,0))	
as
begin

select r.*
from SistemaCaido.Usuarios u, SistemaCaido.UsuariosXRoles ur, SistemaCaido.Roles r
where u.IdUsuario = @idUsuario
and u.IdUsuario = ur.IdUsuario
and ur.IdRol = r.IdRol
and r.Habilitado = 1 	

end' 
END


GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_obtenerPorcentajeActual]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[sp_obtenerPorcentajeActual] as
begin
	select top 1 Porcentaje
	from SistemaCaido.Porcentajes
	order by IdPorcentaje desc
end' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_update_cliente]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[sp_update_cliente] (@nombre varchar(250),  @apellido varchar(250), @DNI numeric(18), @fechaNacimiento date, @direccion varchar(250), @codPostal numeric, @telefono numeric(18,0), @habilitado numeric(1,0), @idcliente numeric(10,0)) as
begin

set xact_abort on
begin tran	

if((select count(*) from SistemaCaido.Clientes where DNI = @dni and @idcliente != IdCliente) > 0) THROW 51000, ''Ya existe un cliente con el numero de DNI ingresado.'', 1;

update SistemaCaido.Clientes
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

end' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[sp_update_rol]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

create procedure [SistemaCaido].[sp_update_rol] (@id numeric(10,0), @nombre varchar(255), @habilitado bit, @listaFuncionalidades SistemaCaido.listaIDs readonly)	
as
begin

set xact_abort on
begin tran

if(SistemaCaido.existeRolConMismoNombre(@nombre, @id) = 1) THROW 51000, ''Ya existe un Rol con el nombre ingresado.'', 1;

update SistemaCaido.Roles
set Nombre = @nombre, Habilitado = @habilitado
where IdRol = @id

delete from SistemaCaido.RolesXFuncionalidades
where IdRol = @id

insert into SistemaCaido.RolesXFuncionalidades (IdRol, IdFuncionalidad)
select  @id, id
from @listaFuncionalidades

commit

end' 
END

--=============================================================================================================--
--*************************************** Creacion de Funciones ************************************************--                                 
--=============================================================================================================--
GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[existeRolConMismoNombre]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'

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

end' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[existeUsuario]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'

create function [SistemaCaido].[existeUsuario](@username varchar(255))
returns bit
begin
declare @retorno bit

if((select count(*)
	from SistemaCaido.Usuarios
	where Username = @username) > 0) set @retorno = 1 else set @retorno = 0
return @retorno

end' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[usuarioActivo]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'

create function [SistemaCaido].[usuarioActivo] (@username varchar(255))
returns bit
begin
declare @retorno bit

if((select IntentosFallidos
	from SistemaCaido.Usuarios
	where Username = @username) < 3) set @retorno = 1 else set @retorno = 0

return @retorno
end' 
END

--=============================================================================================================--
--*************************************** Creacion de Tablas **************************************************--                                 
--=============================================================================================================--
GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON


IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Clientes]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL primary key,
	[Nombre] [nvarchar](255) NOT NULL,
	[Apellido] [nvarchar](255) NOT NULL,
	[DNI] [numeric](18, 0) NOT NULL,
	[Mail] [nvarchar](255) NOT NULL,
	[Telefono] [varchar](10) NULL,
	[Direccion] [nvarchar](255) NOT NULL,
	[CodigoPostal] [nvarchar](4) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Habilitado] [varchar](1) NOT NULL)
END


GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON


IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Empresas]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[Empresas](
	[IdEmpresa] [int] IDENTITY(1,1) NOT NULL primary key,
	[Nombre] [nvarchar](255) NOT NULL,
	[CUIT] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](255) NOT NULL,
	[IdRubro] [int] NOT NULL,
	[Habilitada] [char](1) NOT NULL)
END


GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON


IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Facturas]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[Facturas](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdCliente] [int] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[NumeroFactura] [numeric](18, 0) NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[FechaVencimiento] [datetime] NOT NULL,
	[Importe] [numeric](18, 2) NOT NULL,
	[Habilitada] [char](1) NOT NULL)
END


GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON


IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Funcionalidades]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[Funcionalidades](
	[IdFuncionalidad] [int] IDENTITY(1,1) NOT NULL primary key,
	[Nombre] [varchar](30) NOT NULL)
END


GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[MediosPago]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[MediosPago](
	[IdMedioPago] [int] IDENTITY(1,1) NOT NULL primary key,
	[Nombre] [nvarchar](255) NOT NULL)
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Pagos]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[Pagos](
	[IdPago] [int] IDENTITY(1,1) NOT NULL primary key,
	[NumeroPago] [int] NOT NULL,
	[FechaCobro] [datetime] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Importe] [numeric](18, 2) NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdMedioPago] [int] NOT NULL)
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[PagosXFacturas]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[PagosXFacturas](
	[IdPagoXFactura] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdPago] [int] NOT NULL,
	[IdFactura] [int] NOT NULL)
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Porcentajes]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[Porcentajes](
	[IdPorcentaje] [int] IDENTITY(1,1) NOT NULL primary key,
	[Porcentaje] [numeric](3, 2) NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[IdUsuario] [int] NOT NULL)
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Productos]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[Productos](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL primary key,
	[Descripcion] [nvarchar](255) NULL,
	[Precio] [numeric](18, 2) NOT NULL)
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[ProductosXFacturas]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[ProductosXFacturas](
	[IdProductoXFactura] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdProducto] [int] NOT NULL,
	[IdFactura] [int] NOT NULL,
	[Cantidad] [numeric](18, 0) NOT NULL)
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Rendiciones]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[Rendiciones](
	[IdRendicion] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdEmpresa] [int] NOT NULL,
	[NumeroRendicion] [numeric](18, 0) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdPorcentaje] [int] NOT NULL,
	[Importe] [numeric](18, 2) NOT NULL)
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[RendicionesXFacturas]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[RendicionesXFacturas](
	[IdRendicionXFactura] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdRendicion] [int] NOT NULL,
	[IdFactura] [int] NOT NULL)
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON


GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Roles]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[Roles](
	[IdRol] [int] IDENTITY(1,1) NOT NULL primary key,
	[Nombre] [varchar](30) NOT NULL,
	[Habilitado] [bit] NOT NULL)
END


GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[RolesXFuncionalidades]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[RolesXFuncionalidades](
	[IdRolXFuncionalidad] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdRol] [int] NOT NULL,
	[IdFuncionalidad] [int] NOT NULL)
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Rubros]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[Rubros](
	[IdRubro] [int] IDENTITY(1,1) NOT NULL primary key,
	[Nombre] [nvarchar](255) NOT NULL)
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON


GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Sucursales]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[Sucursales](
	[IdSucursal] [int] IDENTITY(1,1) NOT NULL primary key,
	[Nombre] [nvarchar](255) NOT NULL,
	[Direccion] [nvarchar](255) NOT NULL,
	[CodigoPostal] [varchar](4) NOT NULL,
	[Habilitada] [char](1) NOT NULL)
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON


GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Usuarios]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL primary key,
	[Username] [varchar](30) NOT NULL,
	[Password] [varchar](255) NOT NULL,
	[IntentosFallidos] [int] NOT NULL)
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXRoles]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[UsuariosXRoles](
	[IdUsuarioXRol] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdUsuario] [int] NOT NULL,
	[IdRol] [int] NOT NULL)
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXSucursales]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[UsuariosXSucursales](
	[IdUsuarioXSucursal] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdUsuario] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL)
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[Devoluciones]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[Devoluciones](
	[IdDevolucion] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdUsuario] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Motivo] [varchar](50),
	[Fecha] [datetime])
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[DevolucionesXFacturas]') AND type in (N'U'))
BEGIN
CREATE TABLE [SistemaCaido].[DevolucionesXFacturas](
	[IdDevolucionesXFacturas] [int] IDENTITY(1,1) NOT NULL primary key,
	[IdDevolucion] [int] NOT NULL,
	[IdFactura] [int] NOT NULL,
	[Motivo] [varchar](50),
	[Fecha] [datetime])
END

--=============================================================================================================--
--*************************************** Listados Estadisticos ***********************************************--                                 
--=============================================================================================================--
GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[ClientesConMasPagos]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
create function [SistemaCaido].[ClientesConMasPagos](@Anio char(4), @Trimestre int)
returns table
as return(
	select top 5 IdCliente Cliente, count(*) CantidadPagos 
	from Pagos
	where year(FechaCobro) = @Anio and
		  month(FechaCobro) between (3 * @Trimestre - 2) and (3 * @Trimestre)
  group by IdCliente
  order by 2 desc
)' 
END

GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[SistemaCaido].[EmpresasConMayorMontoRendido]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
BEGIN
execute dbo.sp_executesql @statement = N'
create function [SistemaCaido].[EmpresasConMayorMontoRendido](@Anio char(4), @Trimestre int)
returns table
as return(
	select top 5 emp.Nombre Empresa, SUM(rend.Importe - (rend.Importe * porc.Porcentaje) / 100) MontoRendido
	from Empresas emp
	join Rendiciones rend on emp.IdEmpresa = rend.IdEmpresa
	join Porcentajes porc on rend.IdPorcentaje = porc.IdPorcentaje
	where year(rend.Fecha) = @Anio and
		  month(rend.Fecha) between (3 * @Trimestre - 2) and (3 * @Trimestre)
	group by emp.Nombre, rend.Importe, porc.Porcentaje
)' 
END


--=============================================================================================================--
--*************************************** Campos con valor DEFAULT*********************************************--                                 
--=============================================================================================================--
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[SistemaCaido].[DF__Clientes__Habili__642E9F87]') AND type = 'D')
BEGIN
ALTER TABLE [SistemaCaido].[Clientes] ADD  DEFAULT ((1)) FOR [Habilitado]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[SistemaCaido].[DF__Empresas__Habili__6FA05233]') AND type = 'D')
BEGIN
ALTER TABLE [SistemaCaido].[Empresas] ADD  DEFAULT ((1)) FOR [Habilitada]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[SistemaCaido].[DF__Facturas__Habili__7370E317]') AND type = 'D')
BEGIN
ALTER TABLE [SistemaCaido].[Facturas] ADD  DEFAULT ((1)) FOR [Habilitada]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[SistemaCaido].[DF__Roles__Habilitad__5B995986]') AND type = 'D')
BEGIN
ALTER TABLE [SistemaCaido].[Roles] ADD  DEFAULT ((1)) FOR [Habilitado]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[SistemaCaido].[DF__Sucursale__Habil__615232DC]') AND type = 'D')
BEGIN
ALTER TABLE [SistemaCaido].[Sucursales] ADD  DEFAULT ((1)) FOR [Habilitada]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[SistemaCaido].[DF__Usuarios__Intent__5E75C631]') AND type = 'D')
BEGIN
ALTER TABLE [SistemaCaido].[Usuarios] ADD  DEFAULT ((0)) FOR [IntentosFallidos]
END

--=============================================================================================================--
--*************************************** Foreign Keys ********************************************************--                                 
--=============================================================================================================--
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_empresas_rubros]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Empresas]'))
ALTER TABLE [SistemaCaido].[Empresas]  WITH CHECK ADD  CONSTRAINT [fk_empresas_rubros] FOREIGN KEY([IdRubro])
REFERENCES [SistemaCaido].[Rubros] ([IdRubro])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_empresas_rubros]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Empresas]'))
ALTER TABLE [SistemaCaido].[Empresas] CHECK CONSTRAINT [fk_empresas_rubros]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_facturas_clientes]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Facturas]'))
ALTER TABLE [SistemaCaido].[Facturas]  WITH CHECK ADD  CONSTRAINT [fk_facturas_clientes] FOREIGN KEY([IdCliente])
REFERENCES [SistemaCaido].[Clientes] ([IdCliente])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_facturas_clientes]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Facturas]'))
ALTER TABLE [SistemaCaido].[Facturas] CHECK CONSTRAINT [fk_facturas_clientes]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_facturas_empresas]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Facturas]'))
ALTER TABLE [SistemaCaido].[Facturas]  WITH CHECK ADD  CONSTRAINT [fk_facturas_empresas] FOREIGN KEY([IdEmpresa])
REFERENCES [SistemaCaido].[Empresas] ([IdEmpresa])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_facturas_empresas]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Facturas]'))
ALTER TABLE [SistemaCaido].[Facturas] CHECK CONSTRAINT [fk_facturas_empresas]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pagos_cliente]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Pagos]'))
ALTER TABLE [SistemaCaido].[Pagos]  WITH CHECK ADD  CONSTRAINT [fk_pagos_cliente] FOREIGN KEY([IdCliente])
REFERENCES [SistemaCaido].[Clientes] ([IdCliente])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pagos_cliente]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Pagos]'))
ALTER TABLE [SistemaCaido].[Pagos] CHECK CONSTRAINT [fk_pagos_cliente]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pagos_mediopago]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Pagos]'))
ALTER TABLE [SistemaCaido].[Pagos]  WITH CHECK ADD  CONSTRAINT [fk_pagos_mediopago] FOREIGN KEY([IdMedioPago])
REFERENCES [SistemaCaido].[MediosPago] ([IdMedioPago])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pagos_mediopago]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Pagos]'))
ALTER TABLE [SistemaCaido].[Pagos] CHECK CONSTRAINT [fk_pagos_mediopago]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pagos_sucursal]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Pagos]'))
ALTER TABLE [SistemaCaido].[Pagos]  WITH CHECK ADD  CONSTRAINT [fk_pagos_sucursal] FOREIGN KEY([IdSucursal])
REFERENCES [SistemaCaido].[Sucursales] ([IdSucursal])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pagos_sucursal]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Pagos]'))
ALTER TABLE [SistemaCaido].[Pagos] CHECK CONSTRAINT [fk_pagos_sucursal]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pxf_factura]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[PagosXFacturas]'))
ALTER TABLE [SistemaCaido].[PagosXFacturas]  WITH CHECK ADD  CONSTRAINT [fk_pxf_factura] FOREIGN KEY([IdFactura])
REFERENCES [SistemaCaido].[Facturas] ([IdFactura])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pxf_factura]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[PagosXFacturas]'))
ALTER TABLE [SistemaCaido].[PagosXFacturas] CHECK CONSTRAINT [fk_pxf_factura]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pxf_pago]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[PagosXFacturas]'))
ALTER TABLE [SistemaCaido].[PagosXFacturas]  WITH CHECK ADD  CONSTRAINT [fk_pxf_pago] FOREIGN KEY([IdPago])
REFERENCES [SistemaCaido].[Pagos] ([IdPago])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pxf_pago]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[PagosXFacturas]'))
ALTER TABLE [SistemaCaido].[PagosXFacturas] CHECK CONSTRAINT [fk_pxf_pago]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_porcentajes_usuario]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Porcentajes]'))
ALTER TABLE [SistemaCaido].[Porcentajes]  WITH CHECK ADD  CONSTRAINT [fk_porcentajes_usuario] FOREIGN KEY([IdUsuario])
REFERENCES [SistemaCaido].[Usuarios] ([IdUsuario])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_porcentajes_usuario]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Porcentajes]'))
ALTER TABLE [SistemaCaido].[Porcentajes] CHECK CONSTRAINT [fk_porcentajes_usuario]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pxf_facturas]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[ProductosXFacturas]'))
ALTER TABLE [SistemaCaido].[ProductosXFacturas]  WITH CHECK ADD  CONSTRAINT [fk_pxf_facturas] FOREIGN KEY([IdFactura])
REFERENCES [SistemaCaido].[Facturas] ([IdFactura])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pxf_facturas]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[ProductosXFacturas]'))
ALTER TABLE [SistemaCaido].[ProductosXFacturas] CHECK CONSTRAINT [fk_pxf_facturas]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pxf_productos]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[ProductosXFacturas]'))
ALTER TABLE [SistemaCaido].[ProductosXFacturas]  WITH CHECK ADD  CONSTRAINT [fk_pxf_productos] FOREIGN KEY([IdProducto])
REFERENCES [SistemaCaido].[Productos] ([IdProducto])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_pxf_productos]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[ProductosXFacturas]'))
ALTER TABLE [SistemaCaido].[ProductosXFacturas] CHECK CONSTRAINT [fk_pxf_productos]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rendiciones_empresa]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Rendiciones]'))
ALTER TABLE [SistemaCaido].[Rendiciones]  WITH CHECK ADD  CONSTRAINT [fk_rendiciones_empresa] FOREIGN KEY([IdEmpresa])
REFERENCES [SistemaCaido].[Empresas] ([IdEmpresa])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rendiciones_empresa]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Rendiciones]'))
ALTER TABLE [SistemaCaido].[Rendiciones] CHECK CONSTRAINT [fk_rendiciones_empresa]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rendiciones_porcentajes]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Rendiciones]'))
ALTER TABLE [SistemaCaido].[Rendiciones]  WITH CHECK ADD  CONSTRAINT [fk_rendiciones_porcentajes] FOREIGN KEY([IdPorcentaje])
REFERENCES [SistemaCaido].[Porcentajes] ([IdPorcentaje])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rendiciones_porcentajes]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[Rendiciones]'))
ALTER TABLE [SistemaCaido].[Rendiciones] CHECK CONSTRAINT [fk_rendiciones_porcentajes]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rxf_factura]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RendicionesXFacturas]'))
ALTER TABLE [SistemaCaido].[RendicionesXFacturas]  WITH CHECK ADD  CONSTRAINT [fk_rxf_factura] FOREIGN KEY([IdFactura])
REFERENCES [SistemaCaido].[Facturas] ([IdFactura])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rxf_factura]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RendicionesXFacturas]'))
ALTER TABLE [SistemaCaido].[RendicionesXFacturas] CHECK CONSTRAINT [fk_rxf_factura]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rxf_rendicion]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RendicionesXFacturas]'))
ALTER TABLE [SistemaCaido].[RendicionesXFacturas]  WITH CHECK ADD  CONSTRAINT [fk_rxf_rendicion] FOREIGN KEY([IdRendicion])
REFERENCES [SistemaCaido].[Rendiciones] ([IdRendicion])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rxf_rendicion]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RendicionesXFacturas]'))
ALTER TABLE [SistemaCaido].[RendicionesXFacturas] CHECK CONSTRAINT [fk_rxf_rendicion]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rxf_funcionalidad]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RolesXFuncionalidades]'))
ALTER TABLE [SistemaCaido].[RolesXFuncionalidades]  WITH CHECK ADD  CONSTRAINT [fk_rxf_funcionalidad] FOREIGN KEY([IdFuncionalidad])
REFERENCES [SistemaCaido].[Funcionalidades] ([IdFuncionalidad])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rxf_funcionalidad]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RolesXFuncionalidades]'))
ALTER TABLE [SistemaCaido].[RolesXFuncionalidades] CHECK CONSTRAINT [fk_rxf_funcionalidad]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rxf_rol]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RolesXFuncionalidades]'))
ALTER TABLE [SistemaCaido].[RolesXFuncionalidades]  WITH CHECK ADD  CONSTRAINT [fk_rxf_rol] FOREIGN KEY([IdRol])
REFERENCES [SistemaCaido].[Roles] ([IdRol])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_rxf_rol]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[RolesXFuncionalidades]'))
ALTER TABLE [SistemaCaido].[RolesXFuncionalidades] CHECK CONSTRAINT [fk_rxf_rol]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_uxr_rol]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXRoles]'))
ALTER TABLE [SistemaCaido].[UsuariosXRoles]  WITH CHECK ADD  CONSTRAINT [fk_uxr_rol] FOREIGN KEY([IdRol])
REFERENCES [SistemaCaido].[Roles] ([IdRol])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_uxr_rol]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXRoles]'))
ALTER TABLE [SistemaCaido].[UsuariosXRoles] CHECK CONSTRAINT [fk_uxr_rol]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_uxr_usuario]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXRoles]'))
ALTER TABLE [SistemaCaido].[UsuariosXRoles]  WITH CHECK ADD  CONSTRAINT [fk_uxr_usuario] FOREIGN KEY([IdUsuario])
REFERENCES [SistemaCaido].[Usuarios] ([IdUsuario])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_uxr_usuario]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXRoles]'))
ALTER TABLE [SistemaCaido].[UsuariosXRoles] CHECK CONSTRAINT [fk_uxr_usuario]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_uxs_sucursal]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXSucursales]'))
ALTER TABLE [SistemaCaido].[UsuariosXSucursales]  WITH CHECK ADD  CONSTRAINT [fk_uxs_sucursal] FOREIGN KEY([IdSucursal])
REFERENCES [SistemaCaido].[Sucursales] ([IdSucursal])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_uxs_sucursal]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXSucursales]'))
ALTER TABLE [SistemaCaido].[UsuariosXSucursales] CHECK CONSTRAINT [fk_uxs_sucursal]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_uxs_usuario]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXSucursales]'))
ALTER TABLE [SistemaCaido].[UsuariosXSucursales]  WITH CHECK ADD  CONSTRAINT [fk_uxs_usuario] FOREIGN KEY([IdUsuario])
REFERENCES [SistemaCaido].[Usuarios] ([IdUsuario])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_uxs_usuario]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXSucursales]'))
ALTER TABLE [SistemaCaido].[UsuariosXSucursales] CHECK CONSTRAINT [fk_uxs_usuario]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_dev_usuario]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXSucursales]'))
ALTER TABLE [SistemaCaido].[Devoluciones] WITH CHECK ADD CONSTRAINT [fk_dev_usuario] FOREIGN KEY([IdUsuario])
REFERENCES [SistemaCaido].[Usuarios] ([IdUsuario])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_dev_cliente]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXSucursales]'))
ALTER TABLE [SistemaCaido].[Devoluciones] WITH CHECK ADD CONSTRAINT [fk_dev_cliente] FOREIGN KEY([IdCliente])
REFERENCES [SistemaCaido].[Clientes] ([IdCliente])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_dxf_dev]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXSucursales]'))
ALTER TABLE [SistemaCaido].[DevolucionesXFacturas] WITH CHECK ADD CONSTRAINT [fk_dxf_dev] FOREIGN KEY([IdDevolucion])
REFERENCES [SistemaCaido].[Devoluciones] ([IdDevolucion])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[SistemaCaido].[fk_dxf_factura]') AND parent_object_id = OBJECT_ID(N'[SistemaCaido].[UsuariosXSucursales]'))
ALTER TABLE [SistemaCaido].[DevolucionesXFacturas] WITH CHECK ADD CONSTRAINT [fk_dxf_factura] FOREIGN KEY([IdFactura])
REFERENCES [SistemaCaido].[Facturas] ([IdFactura])

--=============================================================================================================--
--*************************************** Triggers ************************************************************--                                 
--=============================================================================================================--
GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[SistemaCaido].[tr_nuevoCliente]'))
EXEC dbo.sp_executesql @statement = N'
create trigger [SistemaCaido].[tr_nuevoCliente] on [SistemaCaido].[Clientes] instead of insert
as begin
	set nocount on
	 
	if (not exists( select cli.Mail from Clientes cli, inserted ins 
				   where cli.Mail = ins.Mail))
		insert into Clientes
		select Nombre, Apellido, DNI, Mail, Telefono, Direccion, CodigoPostal, FechaNacimiento, 1 from inserted

	else
		-- Se lanza un error
		raiserror(''No se puede dar de alta el cliente (Email existente)..'', 1,1)

	end' 
GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[SistemaCaido].[tr_nuevaEmpresa]'))
EXEC dbo.sp_executesql @statement = N'
create trigger [SistemaCaido].[tr_nuevaEmpresa] on [SistemaCaido].[Empresas] instead of insert
as begin
	set nocount on
	 
	if (not exists( select emp.CUIT from Empresas emp, inserted ins 
				   where emp.CUIT = ins.CUIT))
		insert into Empresas
		select Nombre, CUIT, Direccion, IdRubro, 1 from inserted

	else
		-- Se lanza un error
		raiserror(''No se puede dar de alta la empresa (CUIT existente)..'', 1,1)
	end' 
GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[SistemaCaido].[tr_nuevaFactura]'))
EXEC dbo.sp_executesql @statement = N'
create trigger [SistemaCaido].[tr_nuevaFactura] on [SistemaCaido].[Facturas] instead of insert
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
		raiserror(''El importe de la factura es menor de 0..'', 1,1)

	if(@ImporteFactura = 0)
		raiserror(''El importe de la factura es igual a 0..'', 1,1)	
		
	if(@FechaVenc > sysdatetime())	
		raiserror(''La fecha de vencimiento supera la fecha actual..'', 1,1)	

	if(@Habilitada = 0)	
		raiserror(''La empresa seleccionada esta inactiva..'', 1,1)

end' 
GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[SistemaCaido].[tr_tratarFactura]'))
EXEC dbo.sp_executesql @statement = N'
create trigger [SistemaCaido].[tr_tratarFactura] on [SistemaCaido].[Facturas] instead of update,delete
as begin
	declare @Operacion char
	declare @IdFactura int

	set @Operacion = ''N''

	if exists (select * from inserted) and exists (select * from deleted)
		begin
			set @Operacion = ''U''	--Update

			select top 1 @IdFactura = pxf.IdFactura 
			from PagosXFacturas pxf, inserted ins where pxf.IdFactura = ins.IdFactura
			if(@IdFactura != 0)
				raiserror(''La factura a ingresar se encuentra paga..'', 1,1)

			select top 1 @IdFactura = rxf.IdFactura 
			from RendicionesXFacturas rxf, inserted ins where rxf.IdFactura = ins.IdFactura
			if(@IdFactura != 0)
				raiserror(''La factura a ingresar se encuentra rendida..'', 1,1)	

		end

	if not exists (select * from inserted) and exists (select * from deleted)
		begin
			set @Operacion = ''D''	--Delete

			select top 1 @IdFactura = pxf.IdFactura 
			from PagosXFacturas pxf, deleted del where pxf.IdFactura = del.IdFactura
			if(@IdFactura != 0)
				raiserror(''La factura a ingresar se encuentra paga..'', 1,1)

			select top 1 @IdFactura = rxf.IdFactura 
			from RendicionesXFacturas rxf, deleted del where rxf.IdFactura = del.IdFactura
			if(@IdFactura != 0)
				raiserror(''La factura a ingresar se encuentra rendida..'', 1,1)	

		end
end' 
GO
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON

IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[SistemaCaido].[tr_nuevaSucursal]'))
EXEC dbo.sp_executesql @statement = N'
create trigger [SistemaCaido].[tr_nuevaSucursal] on [SistemaCaido].[Sucursales] instead of insert
as begin
	set nocount on
	 
	if (not exists( select suc.CodigoPostal from Sucursales suc, inserted ins 
				   where suc.CodigoPostal = ins.CodigoPostal))
		insert into Sucursales
		select Nombre, Direccion, CodigoPostal, 1 from inserted

	else
		-- Se lanza un error
		raiserror(''No se puede dar de alta la sucursal (CP existente)..'', 1,1)
	end' 
GO

--=============================================================================================================--
--*************************************** Migracion de datos ************************************************--                                 
--=============================================================================================================--

/* Usuario administrador */
INSERT INTO SistemaCaido.Usuarios (Username, Password)
VALUES('Admin', HASHBYTES('SHA2_256','w23e'))

/* Roles */
INSERT INTO SistemaCaido.Roles (Nombre)
VALUES('Administrador'), ('Cobrador')

/*Usuarios X Roles*/
INSERT INTO SistemaCaido.UsuariosXRoles (IdRol, IdUsuario)
VALUES (1,1)

/* Porcentajes*/
INSERT INTO SistemaCaido.Porcentajes VALUES(CAST('5.2' as numeric(3,2)), CONVERT(datetime, GETDATE()), 1)   --TODO ver cual es el porcentaje actual

/* Funcionalidades */
INSERT INTO SistemaCaido.Funcionalidades VALUES ('ABM de Rol')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('Login y Seguridad')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('Registro de Usuario')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('ABM de Cliente')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('ABM de Empresa')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('ABM de Sucursal')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('ABM de Facturas')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('Registro de Pago de Facturas')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('Rendicion de Facturas Cobradas')
INSERT INTO SistemaCaido.Funcionalidades VALUES ('Listado Estadistico')

/* Funcionalidades X Roles */
INSERT INTO SistemaCaido.RolesXFuncionalidades (IdRol, IdFuncionalidad)
VALUES (1,1) ,(1,2) ,(1,3) ,(1,4) ,(1,5) ,(1,6) ,(1,7) ,(1,8) ,(1,9) ,(1,10)

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
--TODO falta USUARIOSXSUCURSALES

/* Facturas */
INSERT INTO SistemaCaido.Facturas (IdCliente, IdEmpresa, NumeroFactura, FechaAlta, FechaVencimiento, Importe)
SELECT DISTINCT IdCliente, IdEmpresa, Nro_Factura, Factura_Fecha, Factura_Fecha_Vencimiento, Factura_Total 
FROM gd_esquema.Maestra 
JOIN SistemaCaido.Clientes c on [Cliente-Dni] = c.DNI 
JOIN SistemaCaido.Empresas on Empresa_Nombre = SistemaCaido.Empresas.Nombre
WHERE Nro_Factura IS NOT NULL
 
 /*
/* Productos */
INSERT INTO SistemaCaido.Productos (Precio)
Select DISTINCT m.ItemRendicion_Importe
FROM gd_esquema.Maestra m

/* Productos X Facturas*/
INSERT INTO SistemaCaido.ProductosXFacturas(IdFactura, Cantidad, IdProducto)   
SELECT IdFactura, ItemFactura_Cantidad, ItemFactura_Monto FROM gd_esquema.Maestra 
JOIN SistemaCaido.Facturas on Nro_Factura = SistemaCaido.Facturas.NumeroFactura
WHERE ItemFactura_Cantidad > 0
*/

/* Medios de Pago*/
INSERT INTO SistemaCaido.MediosPago (Nombre)
SELECT DISTINCT m.FormaPagoDescripcion
FROM gd_esquema.Maestra m
where m.FormaPagoDescripcion is not null

/* Pagos */
INSERT INTO SistemaCaido.Pagos (NumeroPago, FechaCobro, IdCliente, IdSucursal, IdMedioPago, Importe)    --TODO Falta poner el importe
SELECT DISTINCT Pago_nro, Pago_Fecha, IdCliente, IdSucursal, mp.IdMedioPago, 999
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
INSERT INTO SistemaCaido.Rendiciones (IdEmpresa, NumeroRendicion, Fecha, IdPorcentaje, Importe) --TODO falta el importe
SELECT IdEmpresa, Rendicion_Nro, Rendicion_Fecha, p.IdPorcentaje, 999 
FROM gd_esquema.Maestra
JOIN SistemaCaido.Empresas ON Empresa_Nombre = SistemaCaido.Empresas.Nombre
JOIN SistemaCaido.Porcentajes p on p.IdPorcentaje = 1 
WHERE Rendicion_Nro > 0

/*Rendiciones X Facturas */
INSERT INTO SistemaCaido.RendicionesXFacturas (IdFactura, IdRendicion)
SELECT DISTINCT f.IdFactura, r.IdRendicion
FROM gd_esquema.Maestra m
JOIN SistemaCaido.Facturas f on f.NumeroFactura = m.Nro_Factura
JOIN SistemaCaido.Rendiciones r on r.NumeroRendicion = m.Rendicion_Nro

