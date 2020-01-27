USE [master]
GO
/****** Object:  Database [AseguradoraBD]    Script Date: 27/01/2020 6:40:18 ******/
CREATE DATABASE [AseguradoraBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AseguradoraBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\AseguradoraBD.mdf' , SIZE = 60480KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AseguradoraBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\AseguradoraBD_log.ldf' , SIZE = 94528KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AseguradoraBD] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AseguradoraBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AseguradoraBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AseguradoraBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AseguradoraBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AseguradoraBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AseguradoraBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [AseguradoraBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AseguradoraBD] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [AseguradoraBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AseguradoraBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AseguradoraBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AseguradoraBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AseguradoraBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AseguradoraBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AseguradoraBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AseguradoraBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AseguradoraBD] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AseguradoraBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AseguradoraBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AseguradoraBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AseguradoraBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AseguradoraBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AseguradoraBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AseguradoraBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AseguradoraBD] SET RECOVERY FULL 
GO
ALTER DATABASE [AseguradoraBD] SET  MULTI_USER 
GO
ALTER DATABASE [AseguradoraBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AseguradoraBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AseguradoraBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AseguradoraBD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AseguradoraBD', N'ON'
GO
USE [AseguradoraBD]
GO
/****** Object:  StoredProcedure [dbo].[AprobarSolicitud]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE proc [dbo].[AprobarSolicitud]
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as
 
 update detalleSeguroVoluntario set Estado =  @Estado, Nota = @Nota where id_ctVehiculo = @idSolicitud
 update ctVehiculo set idEstado =  @Estado where Id = @idSolicitud



GO
/****** Object:  StoredProcedure [dbo].[AprobarSolicitudContenido]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[AprobarSolicitudContenido]
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as
 
 update detalleSeguroContenido set Estado =  @Estado, Nota = @Nota where id_ctMueblesInmuebles = @idSolicitud
 update ctMueblesInmuebles set idEstado =  @Estado where Id = @idSolicitud
GO
/****** Object:  StoredProcedure [dbo].[AprobarSolicitudEdificaciones]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AprobarSolicitudEdificaciones]
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as
 
 update detalleEdificaciones set Estado =  @Estado, Nota = @Nota where id_ctMueblesInmuebles = @idSolicitud
 update ctMueblesInmuebles set idEstado =  @Estado where Id = @idSolicitud

GO
/****** Object:  StoredProcedure [dbo].[AprobarSolicitudEmpresasNegocio]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[AprobarSolicitudEmpresasNegocio]
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as
 
 update detalleSeguroEmpresaNegocio set Estado =  @Estado, Nota = @Nota where id_ctEmpresasNegocios = @idSolicitud
 update ctEmpresasNegocios set idEstado =  @Estado where Id = @idSolicitud

GO
/****** Object:  StoredProcedure [dbo].[AprobarSolicitudObligatorio]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[AprobarSolicitudObligatorio]
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as
 
 update detalleSeguroObligatorio set Estado =  @Estado, Nota = @Nota where id_ctVehiculo = @idSolicitud
 update ctVehiculo set idEstado =  @Estado where Id = @idSolicitud

GO
/****** Object:  StoredProcedure [dbo].[AprobarSolicitudTodoRiesgo]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AprobarSolicitudTodoRiesgo]
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as
 
 update detalleSeguroTodoRiesgo set Estado =  @Estado, Nota = @Nota where id_ctVehiculo = @idSolicitud
 update ctVehiculo set idEstado =  @Estado where Id = @idSolicitud

GO
/****** Object:  StoredProcedure [dbo].[CancelarPoliza]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[CancelarPoliza]
@idPoliza int,
@FechaHora datetime,
@Nota varchar(max)
as
update vdPoliza set
Estado= 2, FechaHora= @FechaHora, Nota = @Nota
where id= @IdPoliza
GO
/****** Object:  StoredProcedure [dbo].[CancelarPolizaEmpresaNegocio]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[CancelarPolizaEmpresaNegocio]
@idPoliza int,
@FechaHora datetime,
@Nota varchar(max)
as
update emPoliza set
Estado= 2, FechaHora= @FechaHora, Nota = @Nota
where id= @IdPoliza
GO
/****** Object:  StoredProcedure [dbo].[CancelarPolizaInmuebles]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CancelarPolizaInmuebles]
@idPoliza int,
@FechaHora datetime,
@Nota varchar(max)
as
update inPoliza set
Estado= 2, FechaHora= @FechaHora, Nota = @Nota
where id= @IdPoliza

GO
/****** Object:  StoredProcedure [dbo].[CancelarPolizaVehiculo]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CancelarPolizaVehiculo]
@idPoliza int,
@FechaHora datetime,
@Nota varchar(max)
as
update vhPoliza set
Estado= 2, FechaHora= @FechaHora, Nota = @Nota
where id= @IdPoliza
GO
/****** Object:  StoredProcedure [dbo].[CargarCargos]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CargarCargos]
as
select * from CargoEmp
GO
/****** Object:  StoredProcedure [dbo].[CargarId]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CargarId]
as
if Exists(select * from detalleSeguroSalud)
	SELECT IDENT_CURRENT ('detalleSeguroSalud') + 1 
ELSE	
	SELECT 1		

GO
/****** Object:  StoredProcedure [dbo].[CargarId_detalleSeguroContenido]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[CargarId_detalleSeguroContenido]
as
if Exists(select * from detalleSeguroContenido)
	SELECT IDENT_CURRENT ('detalleSeguroContenido') + 1 
ELSE	
	SELECT 1	


GO
/****** Object:  StoredProcedure [dbo].[CargarId_detalleSeguroEdificaciones]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[CargarId_detalleSeguroEdificaciones]
as
if Exists(select * from detalleEdificaciones)
	SELECT IDENT_CURRENT ('detalleEdificaciones') + 1 
ELSE	
	SELECT 1	

GO
/****** Object:  StoredProcedure [dbo].[CargarId_detalleSeguroEmpresa]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[CargarId_detalleSeguroEmpresa]
as
if Exists(select * from detalleSeguroEmpresaNegocio)
	SELECT IDENT_CURRENT ('detalleSeguroEmpresaNegocio') + 1 
ELSE	
	SELECT 1	

GO
/****** Object:  StoredProcedure [dbo].[CargarId_detalleSeguroObligatorio]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CargarId_detalleSeguroObligatorio]
as
if Exists(select * from detalleSeguroObligatorio)
	SELECT IDENT_CURRENT ('detalleSeguroObligatorio') + 1 
ELSE	
	SELECT 1	
GO
/****** Object:  StoredProcedure [dbo].[CargarId_detalleSeguroTodoRiesgo]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[CargarId_detalleSeguroTodoRiesgo]
as
if Exists(select * from detalleSeguroTodoRiesgo)
	SELECT IDENT_CURRENT ('detalleSeguroTodoRiesgo') + 1 
ELSE	
	SELECT 1	


GO
/****** Object:  StoredProcedure [dbo].[CargarId_detalleSeguroVoluntario]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[CargarId_detalleSeguroVoluntario]
as
if Exists(select * from detalleSeguroVoluntario)
	SELECT IDENT_CURRENT ('detalleSeguroVoluntario') + 1 
ELSE	
	SELECT 1	


GO
/****** Object:  StoredProcedure [dbo].[CargarId_Factura]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CargarId_Factura]
as
if Exists(select * from Facturas)
	SELECT IDENT_CURRENT ('Facturas') + 1 
ELSE	
	SELECT 1	

GO
/****** Object:  StoredProcedure [dbo].[CargarNombreEmpleado]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CargarNombreEmpleado]
@id int,
@Nombre varchar output,
@Cedula varchar output
as
select id, Nombre, Cedula from Empleado where @id = id

GO
/****** Object:  StoredProcedure [dbo].[CargarPolizasActivas]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CargarPolizasActivas]
@IdCliente int
as
select vh.Id as "Núm Poliza", PS.[Nombre del Seguro], PS.Area, cE.Validacion as "Estado" from vdPoliza vh join PolizaDeSeguros PS
on vh.IdPolizaDeSeguro = Ps.id join cEstado cE on vh.Estado = cE.idEstado where Id_Cliente = @IdCliente and cE.idEstado = 1
 UNION  
select em.Id as "Núm Poliza", PS.[Nombre del Seguro], PS.Area, cE.Validacion as "Estado" from emPoliza em join PolizaDeSeguros PS
on em.IdPolizaDeSeguro = Ps.id join cEstado cE on em.Estado = cE.idEstado where Id_Cliente =  @IdCliente and cE.idEstado = 1
 UNION  
select vh.Id as "Núm Poliza", PS.[Nombre del Seguro], PS.Area, cE.Validacion as "Estado" from vhPoliza vh join PolizaDeSeguros PS
on vh.IdPolizaDeSeguro = Ps.id join cEstado cE on vh.Estado = cE.idEstado where Id_Cliente =  @IdCliente and cE.idEstado = 1
 UNION  
select _in.Id as "Núm Poliza", PS.[Nombre del Seguro], PS.Area, cE.Validacion as "Estado" from inPoliza _in join PolizaDeSeguros PS
on _in.IdPolizaDeSeguro = Ps.id join cEstado cE on _in.Estado = cE.idEstado where Id_Cliente =  @IdCliente and cE.idEstado = 1

GO
/****** Object:  StoredProcedure [dbo].[CargarPolizasActivasDev]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[CargarPolizasActivasDev]
@IdCliente int
as
select vh.Id as "Núm Poliza", PS.[Nombre del Seguro], cE.Validacion from vdPoliza vh join PolizaDeSeguros PS
on vh.IdPolizaDeSeguro = Ps.id join cEstado cE on vh.Estado = cE.idEstado where Id_Cliente = @IdCliente
 UNION  
select em.Id as "Núm Poliza", PS.[Nombre del Seguro], cE.Validacion from emPoliza em join PolizaDeSeguros PS
on em.IdPolizaDeSeguro = Ps.id join cEstado cE on em.Estado = cE.idEstado where Id_Cliente =  @IdCliente
 UNION  
select vh.Id as "Núm Poliza", PS.[Nombre del Seguro], cE.Validacion from vhPoliza vh join PolizaDeSeguros PS
on vh.IdPolizaDeSeguro = Ps.id join cEstado cE on vh.Estado = cE.idEstado where Id_Cliente =  @IdCliente
 UNION  
select _in.Id as "Núm Poliza", PS.[Nombre del Seguro], cE.Validacion from inPoliza _in join PolizaDeSeguros PS
on _in.IdPolizaDeSeguro = Ps.id join cEstado cE on _in.Estado = cE.idEstado where Id_Cliente =  @IdCliente

GO
/****** Object:  StoredProcedure [dbo].[CargarPolizasActivasEInactivas]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CargarPolizasActivasEInactivas]
@IdCliente int
as
select vh.Id as "Núm Poliza", PS.[Nombre del Seguro], cE.Validacion as "Estado" from vdPoliza vh join PolizaDeSeguros PS
on vh.IdPolizaDeSeguro = Ps.id join cEstado cE on vh.Estado = cE.idEstado where Id_Cliente = @IdCliente
 UNION  
select em.Id as "Núm Poliza", PS.[Nombre del Seguro], cE.Validacion as "Estado" from emPoliza em join PolizaDeSeguros PS
on em.IdPolizaDeSeguro = Ps.id join cEstado cE on em.Estado = cE.idEstado where Id_Cliente =  @IdCliente
 UNION  
select vh.Id as "Núm Poliza", PS.[Nombre del Seguro], cE.Validacion as "Estado" from vhPoliza vh join PolizaDeSeguros PS
on vh.IdPolizaDeSeguro = Ps.id join cEstado cE on vh.Estado = cE.idEstado where Id_Cliente =  @IdCliente
 UNION  
select _in.Id as "Núm Poliza", PS.[Nombre del Seguro], cE.Validacion as "Estado" from inPoliza _in join PolizaDeSeguros PS
on _in.IdPolizaDeSeguro = Ps.id join cEstado cE on _in.Estado = cE.idEstado where Id_Cliente =  @IdCliente

GO
/****** Object:  StoredProcedure [dbo].[CargarPolizasDeSeguros]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[CargarPolizasDeSeguros]
as
select PS.id, PS.[Nombre del Seguro] from PolizaDeSeguros PS
GO
/****** Object:  StoredProcedure [dbo].[ComprobarAcceso]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[ComprobarAcceso]
@NombreUsuario varchar(20),
@Contrasena varchar(30)
as
if exists(select NombreUsuario,Contrasena from Usuarios where NombreUsuario = @NombreUsuario and Contrasena = @Contrasena)
	return 1
else
	return 0

GO
/****** Object:  StoredProcedure [dbo].[ConsultaPolizasDisponibles]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ConsultaPolizasDisponibles]
as
select ps.id, ps.[Nombre del Seguro], ps.Area, ps.Descripcion, ps.Precio, cp.Categoria, cp.Tipo
from PolizaDeSeguros ps join CategoriaPolizas cp on ps.id = cp.id_SeguroPoliza
GO
/****** Object:  StoredProcedure [dbo].[CrearDevolucion]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CrearDevolucion]
@idCliente int,
@idSolicitud int,
@idPoliza int,
@ADevolver decimal(18,2),
@Motivo varchar(max),
@FechaHora datetime
as
insert into Devoluciones(id_Cliente, id_Solicitud, id_Poliza, [A Devolver], Motivo, FechaHora)
values (@idCliente, @idSolicitud, @idPoliza, @ADevolver, @Motivo, @FechaHora)


GO
/****** Object:  StoredProcedure [dbo].[CrearPoliza]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CrearPoliza]
@IdCliente int,

@idEmpleado int,
@Total decimal(18,2),
@Estado_ctVida int,         -------
@FechaHora datetime,		-------

@idSolicitud int,
@idSeguro int,
@T_Pago varchar(25),
@PagoParcial decimal(18,2),   
@Descuento decimal(18,2),
----------------
 --
@InstitutoDondeLabora varchar(50),
@AntecedentesPersonales varchar(MAX),
@Fecha date,								------					--------
@Tipo varchar(50),

@Poliza varchar(MAX),				
@EstadoPoliza int,						------
@Vencimiento date
as
BEGIN
insert into ctVida(id_Cliente, id_Empleado, Total, idEstado, FechaHora)
values (@IdCliente, @idEmpleado, @Total, @Estado_ctVida, @FechaHora)



declare @id_ctVida int
set @id_ctVida = SCOPE_IDENTITY()

insert into detalleSeguroSalud(id_ctVida, InstitucionDondeLabora,
[Antecedentes personales], Fecha, Estado, Tipo) values (@id_ctVida,
@InstitutoDondeLabora, @AntecedentesPersonales, @Fecha, @Estado_ctVida, @Tipo)



insert into vdPoliza(Id_Cliente, Poliza, IdPolizaDeSeguro, Estado,
FechaHora, Vencimiento) values (@IdCliente, @Poliza, @idSeguro, @EstadoPoliza, @FechaHora, @Vencimiento)

insert into Facturas 
      ([id_Cliente]
	  ,[id_Empleado]
	  ,[id_Solicitud]
      ,[id_Seguro]
      ,[Precio]
      ,[T_Pago]
      ,[Pago Parcial]
      ,[SubTotal]
      ,[Descuento]
      ,[FechaHora]) values (@IdCliente, @idEmpleado, @idSolicitud, @idSeguro,
	  @Total, @T_Pago, @PagoParcial, @Total,
	  @Descuento, @FechaHora) 

END	
GO
/****** Object:  StoredProcedure [dbo].[CrearPolizaEdificaciones]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CrearPolizaEdificaciones]
@IdCliente int,
@IdPolizaSeguro int,
@Poliza varchar(MAX), 
@FechaHora datetime, 
@Vencimiento date
as
insert into inPoliza(Id_Cliente, IdPolizaDeSeguro, Poliza, Estado,
FechaHora, Vencimiento) values (@IdCliente, @IdPolizaSeguro,@Poliza, 1, @FechaHora, @Vencimiento)

GO
/****** Object:  StoredProcedure [dbo].[CrearPolizaSeguroContenido]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CrearPolizaSeguroContenido]
@IdCliente int,
@IdPolizaSeguro int,
@Poliza varchar(MAX), 
@FechaHora datetime, 
@Vencimiento date
as
insert into inPoliza(Id_Cliente, IdPolizaDeSeguro, Poliza, Estado,
FechaHora, Vencimiento) values (@IdCliente, @IdPolizaSeguro,@Poliza, 1, @FechaHora, @Vencimiento)

GO
/****** Object:  StoredProcedure [dbo].[CrearPolizaSeguroEmpresaNegocio]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[CrearPolizaSeguroEmpresaNegocio]
@IdCliente int,
@IdPolizaSeguro int,
@Poliza varchar(MAX), 
@FechaHora datetime, 
@Vencimiento date
as
insert into emPoliza(Id_Cliente, IdPolizaDeSeguro, Poliza, Estado,
FechaHora, Vencimiento) values (@IdCliente, @IdPolizaSeguro,@Poliza, 1, @FechaHora, @Vencimiento)

GO
/****** Object:  StoredProcedure [dbo].[CrearPolizaSeguroObligatorio]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CrearPolizaSeguroObligatorio]
@IdCliente int,
@IdPolizaSeguro int,
@Poliza varchar(MAX), 
@FechaHora datetime, 
@Vencimiento date
as
insert into vhPoliza(Id_Cliente, IdPolizaDeSeguro, Poliza, Estado,
FechaHora, Vencimiento) values (@IdCliente, @IdPolizaSeguro,@Poliza, 1, @FechaHora, @Vencimiento)

GO
/****** Object:  StoredProcedure [dbo].[CrearPolizaSeguroTodoRiesgo]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CrearPolizaSeguroTodoRiesgo]
@IdCliente int,
@IdPolizaSeguro int,
@Poliza varchar(MAX), 
@FechaHora datetime, 
@Vencimiento date
as
insert into vhPoliza(Id_Cliente, IdPolizaDeSeguro, Poliza, Estado,
FechaHora, Vencimiento) values (@IdCliente, @IdPolizaSeguro,@Poliza, 1, @FechaHora, @Vencimiento)

GO
/****** Object:  StoredProcedure [dbo].[CrearPolizaSeguroVoluntario]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[CrearPolizaSeguroVoluntario]
@IdCliente int,
@IdPolizaSeguro int,
@Poliza varchar(MAX), 
@FechaHora datetime, 
@Vencimiento date
as
insert into vhPoliza(Id_Cliente, IdPolizaDeSeguro, Poliza, Estado,
FechaHora, Vencimiento) values (@IdCliente, @IdPolizaSeguro,@Poliza, 1, @FechaHora, @Vencimiento)


GO
/****** Object:  StoredProcedure [dbo].[CrearSolicitud]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CrearSolicitud]

@IdCliente int,

@idEmpleado int,
@Total decimal(18,2),       
@Fecha date,		

@idSolicitud int,
@idSeguro int,
@T_Pago varchar(25),
@PagoParcial decimal(18,2),   
@Descuento decimal(18,2),

----------------
 
@NombreEmpresa varchar(80),
@CopiaEstatutos varbinary(max),
@CopiaActaAsignacionRNC varbinary(max),
@CopiaCedulaPres_RepreAut varbinary(max),
@TelefonoEntAutorizada varchar(30),
@CorreoElectronicoEntAutorizada varchar(50),

@FechaHora datetime,
@Tipo varchar(50),

---------------------
@Imagen1 varbinary(max),
@Imagen2 varbinary(max),
@Imagen3 varbinary(max),
@Imagen4 varbinary(max),
@Imagen5 varbinary(max)
as

insert into ctEmpresasNegocios(id_Cliente, id_Empleado, Total, idEstado, Fecha)
values (@IdCliente, @idEmpleado, @Total, 3, @FechaHora)


declare @id_ctEmpresasNegocios int
set @id_ctEmpresasNegocios = SCOPE_IDENTITY()

insert into detalleSeguroEmpresaNegocio(id_ctEmpresasNegocios, [Nombre Empresa],
[Copia de los Estatutos], [Copia Acta Asignacion RNC], [Copia Cedula Presidente y Representante autorizado]
, [Telefono de Entidad Autorizada], [Correo electronico de Entidad Autorizada], [Inspeccion del Local]
, [Estado], [FechaHora], [Tipo], idFactura) values (@id_ctEmpresasNegocios,
@NombreEmpresa, @CopiaEstatutos, @CopiaActaAsignacionRNC, @CopiaCedulaPres_RepreAut, @TelefonoEntAutorizada,
 @CorreoElectronicoEntAutorizada, 'Pendiente', 3, @FechaHora, @Tipo, @idSolicitud)

declare @id_detalleSeguroEmpresaNegocio int
set @id_detalleSeguroEmpresaNegocio = SCOPE_IDENTITY()

insert into Facturas 
      ([id_Cliente]
	  ,[id_Empleado]
	  ,[id_Solicitud]
      ,[id_Seguro]
      ,[Precio]
      ,[T_Pago]
      ,[Pago Parcial]
      ,[SubTotal]
      ,[Descuento]
      ,[FechaHora]) values (@IdCliente, @idEmpleado, @idSolicitud, @idSeguro,
	  @Total, @T_Pago, @PagoParcial, @Total,
	  @Descuento, @FechaHora) 

insert into imagenesCotenidoInspSeguroEmpresas(id_detallesSeguroEmpresasN, Imagen)
 values (@id_detalleSeguroEmpresaNegocio, @Imagen1),
		(@id_detalleSeguroEmpresaNegocio, @Imagen2),
		(@id_detalleSeguroEmpresaNegocio, @Imagen3),
		(@id_detalleSeguroEmpresaNegocio, @Imagen4),
		(@id_detalleSeguroEmpresaNegocio, @Imagen5)


GO
/****** Object:  StoredProcedure [dbo].[CrearSolicitudSeguroContenido]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CrearSolicitudSeguroContenido]

@IdCliente int,

@idEmpleado int,
@Total decimal(18,2),       
@Fecha date,		
----------------

@idSolicitud int,
@idSeguro int,
@T_Pago varchar(25),
@PagoParcial decimal(18,2),   
@Descuento decimal(18,2),
----------------
@TipoVivienda varchar(50),
@Situacion varchar(50),
@Propietario varchar (50),
@ViviendaHabitual varchar(4),
@ViviendaAlquilada varchar(4),
@CodigoPostal varchar(15),
@DesabitadaPor3MesesAlAno varchar (50),
@AnoConstruccion int,
@M2Vivienda decimal(18,2),
@DescripcionMuebles varchar(max),
@ValorEstimadoMuebles int,

@FechaHora datetime,
@Tipo varchar(50)

as

insert into ctMueblesInmuebles(id_Cliente, id_Empleado, Total, idEstado, Fecha)
values (@IdCliente, @idEmpleado, @Total, 3, @FechaHora)

declare @id_ctMueblesInmuebles int
set @id_ctMueblesInmuebles = SCOPE_IDENTITY()

insert into detalleSeguroContenido( id_ctMueblesInmuebles,
	   [Tipo de Vivienda]
      ,[Situacion]
      ,[Propietario]
      ,[Vivienda habitual]
      ,[Vivienda Alquilada]
      ,[Codigo Postal]
      ,[Deshabitada por mas de tres meses al ano]
      ,[Ano de Construccion]
      ,[M2 de la Vivienda]
	  ,DescripcionMuebles
	  ,ValorEstimadoMuebles
	  ,[Estado]
      ,[FechaHora]
      ,[Tipo], idFactura) values (@id_ctMueblesInmuebles,
    @TipoVivienda,
	@Situacion,
	@Propietario,
	@ViviendaHabitual,
	@ViviendaAlquilada,
	@CodigoPostal,
	@DesabitadaPor3MesesAlAno,
	@AnoConstruccion,
	@M2Vivienda,
	@DescripcionMuebles,
	@ValorEstimadoMuebles,
	3,
	@FechaHora,
	@Tipo, @idSolicitud)

	insert into Facturas 
      ([id_Cliente]
	  ,[id_Empleado]
	  ,[id_Solicitud]
      ,[id_Seguro]
      ,[Precio]
      ,[T_Pago]
      ,[Pago Parcial]
      ,[SubTotal]
      ,[Descuento]
      ,[FechaHora]) values (@IdCliente, @idEmpleado, @idSolicitud, @idSeguro,
	  @Total, @T_Pago, @PagoParcial, @Total,
	  @Descuento, @FechaHora) 
      
GO
/****** Object:  StoredProcedure [dbo].[CrearSolicitudSeguroEdificaciones]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CrearSolicitudSeguroEdificaciones]

@IdCliente int,

@idEmpleado int,
@Total decimal(18,2),       
@Fecha date,		
----------------

@idSolicitud int,
@idSeguro int,
@T_Pago varchar(25),
@PagoParcial decimal(18,2),   
@Descuento decimal(18,2),
----------------
@TipoVivienda varchar(50),
@Situacion varchar(50),
@Propietario varchar (50),
@ViviendaHabitual varchar(4),
@ViviendaAlquilada varchar(4),
@CodigoPostal varchar(15),
@DesabitadaPor3MesesAlAno varchar (50),
@AnoConstruccion int,
@M2Vivienda decimal(18,2),
@M2EdificacionesAnexas decimal(18,2),
@CapitalOtrasInstalaciones varchar(max),

@FechaHora datetime,
@Tipo varchar(50)

as

insert into ctMueblesInmuebles(id_Cliente, id_Empleado, Total, idEstado, Fecha)
values (@IdCliente, @idEmpleado, @Total, 3, @FechaHora)

declare @id_ctMueblesInmuebles int
set @id_ctMueblesInmuebles = SCOPE_IDENTITY()

insert into detalleEdificaciones( id_ctMueblesInmuebles,
	   [Tipo de Vivienda]
      ,[Situacion]
      ,[Propietario]
      ,[Vivienda habitual]
      ,[Vivienda Alquilada]
      ,[Codigo Postal]
      ,[Deshabitada por mas de tres meses al ano]
      ,[Ano de Construccion]
      ,[M2 de la Vivienda]
      ,[M2 de edificaciones anexas]
      ,[Capital de otras instalaciones]
	  ,[Estado]
      ,[FechaHora]
      ,[Tipo], idFactura) values (@id_ctMueblesInmuebles,
    @TipoVivienda,
	@Situacion,
	@Propietario,
	@ViviendaHabitual,
	@ViviendaAlquilada,
	@CodigoPostal,
	@DesabitadaPor3MesesAlAno,
	@AnoConstruccion,
	@M2Vivienda,
	@M2EdificacionesAnexas,
	@CapitalOtrasInstalaciones,
	3,
	@FechaHora,
	@Tipo, @idSolicitud)

	insert into Facturas 
      ([id_Cliente]
	  ,[id_Empleado]
	  ,[id_Solicitud]
      ,[id_Seguro]
      ,[Precio]
      ,[T_Pago]
      ,[Pago Parcial]
      ,[SubTotal]
      ,[Descuento]
      ,[FechaHora]) values (@IdCliente, @idEmpleado, @idSolicitud, @idSeguro,
	  @Total, @T_Pago, @PagoParcial, @Total,
	  @Descuento, @FechaHora) 
      

GO
/****** Object:  StoredProcedure [dbo].[CrearSolicitudSeguroVEH_Obligatorio]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CrearSolicitudSeguroVEH_Obligatorio]

@IdCliente int,

@idEmpleado int,
@Total decimal(18,2),       
@Fecha date,		

----------------

@idSolicitud int,
@idSeguro int,
@T_Pago varchar(25),
@PagoParcial decimal(18,2),   
@Descuento decimal(18,2),
----------------
@MarcaVehiculo varchar(20),
      @Modelo varchar(20),
      @Matricula varchar(20),
      @Ano int,
      @Cilindros int,
      @Carroceria varchar(20),
      @Categoria varchar(20),
      @Uso varchar(20),

      @FechaHora datetime,
      @Tipo varchar(50)


as

insert into ctVehiculo(id_Cliente, id_Empleado, Total, idEstado, Fecha)
values (@IdCliente, @idEmpleado, @Total, 3, @FechaHora)


declare @id_ctVehiculo int
set @id_ctVehiculo = SCOPE_IDENTITY()

insert into detalleSeguroObligatorio(id_ctVehiculo
      ,[Marca de Vehiculo]
      ,[Modelo]
      ,[Matricula]
      ,[Ano]
      ,[Cilindros]
      ,[Carroceria]
      ,[Categoria]
      ,[Uso]
	  ,[Estado]
      ,[FechaHora]
      ,[Tipo], idFactura) values (@id_ctVehiculo,
	  @MarcaVehiculo,
      @Modelo,
      @Matricula,
      @Ano,
      @Cilindros,
      @Carroceria,
      @Categoria,
      @Uso,
      3,

      @FechaHora,
      @Tipo, @idSolicitud)

	  insert into Facturas 
      ([id_Cliente]
	  ,[id_Empleado]
	  ,[id_Solicitud]
      ,[id_Seguro]
      ,[Precio]
      ,[T_Pago]
      ,[Pago Parcial]
      ,[SubTotal]
      ,[Descuento]
      ,[FechaHora]) values (@IdCliente, @idEmpleado, @idSolicitud, @idSeguro,
	  @Total, @T_Pago, @PagoParcial, @Total,
	  @Descuento, @FechaHora) 
GO
/****** Object:  StoredProcedure [dbo].[CrearSolicitudSeguroVEH_TodoRiesgo]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CrearSolicitudSeguroVEH_TodoRiesgo]

@IdCliente int,

@idEmpleado int,
@Total decimal(18,2),       
@Fecha date,		

----------------

@idSolicitud int,
@idSeguro int,
@T_Pago varchar(25),
@PagoParcial decimal(18,2),   
@Descuento decimal(18,2),
----------------
@MarcaVehiculo varchar(20),
      @Modelo varchar(20),
      @Matricula varchar(20),
      @Ano int,
      @Cilindros int,
      @Carroceria varchar(20),
      @Categoria varchar(20),
      @Uso varchar(20),

      @FechaHora datetime,
      @Tipo varchar(50)


as

insert into ctVehiculo(id_Cliente, id_Empleado, Total, idEstado, Fecha)
values (@IdCliente, @idEmpleado, @Total, 3, @FechaHora)


declare @id_ctVehiculo int
set @id_ctVehiculo = SCOPE_IDENTITY()

insert into detalleSeguroTodoRiesgo(id_ctVehiculo
      ,[Marca de Vehiculo]
      ,[Modelo]
      ,[Matricula]
      ,[Ano]
      ,[Cilindros]
      ,[Carroceria]
      ,[Categoria]
      ,[Uso]
	  ,[Estado]
      ,[FechaHora]
      ,[Tipo], idFactura) values (@id_ctVehiculo,
	  @MarcaVehiculo,
      @Modelo,
      @Matricula,
      @Ano,
      @Cilindros,
      @Carroceria,
      @Categoria,
      @Uso,
      3,

      @FechaHora,
      @Tipo, @idSolicitud)


	insert into Facturas 
      ([id_Cliente]
	  ,[id_Empleado]
	  ,[id_Solicitud]
      ,[id_Seguro]
      ,[Precio]
      ,[T_Pago]
      ,[Pago Parcial]
      ,[SubTotal]
      ,[Descuento]
      ,[FechaHora]) values (@IdCliente, @idEmpleado, @idSolicitud, @idSeguro,
	  @Total, @T_Pago, @PagoParcial, @Total,
	  @Descuento, @FechaHora) 
GO
/****** Object:  StoredProcedure [dbo].[CrearSolicitudSeguroVEH_Voluntario]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CrearSolicitudSeguroVEH_Voluntario]

@IdCliente int,

@idEmpleado int,
@Total decimal(18,2),       
@Fecha date,		

----------------

@idSolicitud int,
@idSeguro int,
@T_Pago varchar(25),
@PagoParcial decimal(18,2),   
@Descuento decimal(18,2),
----------------
@MarcaVehiculo varchar(20),
      @Modelo varchar(20),
      @Matricula varchar(20),
      @Ano int,
      @Cilindros int,
      @Carroceria varchar(20),
      @Categoria varchar(20),
      @Uso varchar(20),

      @FechaHora datetime,
      @Tipo varchar(50)


as

insert into ctVehiculo(id_Cliente, id_Empleado, Total, idEstado, Fecha)
values (@IdCliente, @idEmpleado, @Total, 3, @FechaHora)


declare @id_ctVehiculo int
set @id_ctVehiculo = SCOPE_IDENTITY()

insert into detalleSeguroVoluntario(id_ctVehiculo
      ,[Marca de Vehiculo]
      ,[Modelo]
      ,[Matricula]
      ,[Ano]
      ,[Cilindros]
      ,[Carroceria]
      ,[Categoria]
      ,[Uso]
	  ,[Estado]
      ,[FechaHora]
      ,[Tipo], idFactura) values (@id_ctVehiculo,
	  @MarcaVehiculo,
      @Modelo,
      @Matricula,
      @Ano,
      @Cilindros,
      @Carroceria,
      @Categoria,
      @Uso,
      3,
      @FechaHora,
      @Tipo, @idSolicitud)

	  
	insert into Facturas 
      ([id_Cliente]
	  ,[id_Empleado]
	  ,[id_Solicitud]
      ,[id_Seguro]
      ,[Precio]
      ,[T_Pago]
      ,[Pago Parcial]
      ,[SubTotal]
      ,[Descuento]
      ,[FechaHora]) values (@IdCliente, @idEmpleado, @idSolicitud, @idSeguro,
	  @Total, @T_Pago, @PagoParcial, @Total,
	  @Descuento, @FechaHora) 
GO
/****** Object:  StoredProcedure [dbo].[EliminarCliente]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarCliente]
@Id int
as
delete from Cliente where id=@Id
GO
/****** Object:  StoredProcedure [dbo].[EliminarEmpleado]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarEmpleado]
@Id int
as
delete from Empleado where id=@Id

GO
/****** Object:  StoredProcedure [dbo].[em_MostrarPolizas]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[em_MostrarPolizas]
as
select Pol.Id_Cliente AS "Id Cliente", Pol.id AS "Núm. Póliza", ps.[Nombre del Seguro], Pol.Poliza, ps.Area, ps.Precio, cE.Validacion AS "Estado", Pol.FechaHora AS "Fecha Hora",
 Pol.Vencimiento, Cliente.Nombre, Cliente.Apellido,
 Cliente.Cedula AS "Cédula", Cliente.Telefono AS "Teléfono", Cliente.Sexo, Pol.Nota
  from emPoliza Pol join PolizaDeSeguros ps on Pol.idPolizaDeSeguro = ps.id  join Cliente on Pol.Id_Cliente = Cliente.Id
join cEstado cE on Pol.Estado = cE.idEstado 
GO
/****** Object:  StoredProcedure [dbo].[GuardarReclamo]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[GuardarReclamo]
@_Area int,
@IdCliente int,
@IdSiniestro int,
@IdPoliza int,
@ActaPolicial image,
@CopiaMatricula image,
@CopiaCedula image,
@CostoEstimado decimal(18,2),
@FechaHora datetime
as
declare @Deducible decimal
set @Deducible = @CostoEstimado * 0.15

if(@_Area = 1)
begin
	insert into vdReclamos(Id_Cliente, Id_Siniestro, Id_Poliza, [Acta Policial],
	[Copia matricula], [Copia cedula], Estado, Deducible, [Costo estimado], FechaHora)
	values (@IdCliente, @IdSiniestro, @IdPoliza, @ActaPolicial, @CopiaMatricula,
	@CopiaCedula, 1, @Deducible, @CostoEstimado, @FechaHora)
end

else if(@_Area = 2)
begin
	insert into vhReclamos(Id_Cliente, Id_Siniestro, Id_Poliza, [Acta Policial],
	[Copia matricula], [Copia cedula], Estado, Deducible, [Costo estimado], FechaHora)
	values (@IdCliente, @IdSiniestro, @IdPoliza, @ActaPolicial, @CopiaMatricula,
	@CopiaCedula, 1, @Deducible, @CostoEstimado, @FechaHora)
end

else if(@_Area = 3)
begin
	insert into emReclamos(Id_Cliente, Id_Siniestro, Id_Poliza, [Acta Policial],
	[Copia matricula], [Copia cedula], Estado, Deducible, [Costo estimado], FechaHora)
	values (@IdCliente, @IdSiniestro, @IdPoliza, @ActaPolicial, @CopiaMatricula,
	@CopiaCedula, 1, @Deducible, @CostoEstimado, @FechaHora)
end

else if(@_Area = 4)
begin
	insert into inReclamos(Id_Cliente, Id_Siniestro, Id_Poliza, [Acta Policial],
	[Copia matricula], [Copia cedula], Estado, Deducible, [Costo estimado], FechaHora)
	values (@IdCliente, @IdSiniestro, @IdPoliza, @ActaPolicial, @CopiaMatricula,
	@CopiaCedula, 1, @Deducible, @CostoEstimado, @FechaHora)
end
GO
/****** Object:  StoredProcedure [dbo].[GuardarSiniestro]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE proc [dbo].[GuardarSiniestro]
@Id_Cliente int,
@Id_Empleado int,
@Siniestro varchar(max),
@FechaHora datetime
as
insert into Siniestros(id_Cliente, id_Empleado, Siniestro, FechaHora)
values (@Id_Cliente, @Id_Empleado, @Siniestro, @FechaHora)

insert into Siniestro_Reclamos(id_Siniestro) values
(SCOPE_IDENTITY())


GO
/****** Object:  StoredProcedure [dbo].[in_MostrarPolizas]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[in_MostrarPolizas]
as
select Pol.Id_Cliente AS "Id Cliente", Pol.id AS "Núm. Póliza", ps.[Nombre del Seguro], Pol.Poliza, ps.Area, ps.Precio, cE.Validacion AS "Estado", Pol.FechaHora AS "Fecha Hora",
 Pol.Vencimiento, Cliente.Nombre, Cliente.Apellido,
 Cliente.Cedula AS "Cédula", Cliente.Telefono AS "Teléfono", Cliente.Sexo, Pol.Nota
  from inPoliza Pol join PolizaDeSeguros ps on Pol.idPolizaDeSeguro = ps.id  join Cliente on Pol.Id_Cliente = Cliente.Id
join cEstado cE on Pol.Estado = cE.idEstado 
GO
/****** Object:  StoredProcedure [dbo].[InsertarCargo]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[InsertarCargo]
@Cargo varchar(100)
as
insert into CargoEmp(Cargo) values (@Cargo)

GO
/****** Object:  StoredProcedure [dbo].[InsertarCliente]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[InsertarCliente]
@id int output,
@Nombre varchar(50),
@Apellido Varchar(50),
@Direccion Varchar(100),
@Cedula varchar(30),
@Nacionalidad varchar(50),
@Telefono varchar(15),
@CorreoElectronico varchar(50),
@Sexo varchar(1),
@RNC varchar(15),
@FechaHora datetime
as 
insert into Cliente(Nombre,Apellido,Direccion,
Cedula, Nacionalidad,Telefono, [Correo Electronico], Sexo, RNC, FechaHora)
values (@Nombre, @Apellido, @Direccion, @Cedula, @Nacionalidad, @Telefono,
@CorreoElectronico, @Sexo, @RNC, @FechaHora)
set @id = SCOPE_IDENTITY()

GO
/****** Object:  StoredProcedure [dbo].[InsertarEmpleado]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarEmpleado]
@Nombre varchar(50),
@Apellido Varchar(50),
@Direccion Varchar(100),
@Cedula varchar(30),
@Telefono varchar(15),
@CorreoElectronico varchar(50),
@idCargo int,
@Sexo nchar(2),
@Fecha date
as 
insert into Empleado (Nombre,Apellido,Direccion,
Cedula,Telefono, [Correo Electronico], idCargo, Sexo, Fecha)
values (@Nombre, @Apellido, @Direccion, @Cedula, @Telefono,
@CorreoElectronico, @idCargo, @Sexo, @Fecha)

GO
/****** Object:  StoredProcedure [dbo].[ModificarCliente]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ModificarCliente]
@Id int,
@Nombre varchar(50),
@Apellido Varchar(50),
@Direccion Varchar(100),
@Cedula varchar(30),
@Nacionalidad varchar(50),
@Telefono varchar(15),
@CorreoElectronico varchar(50),
@Sexo varchar(1),
@RNC varchar(15),
@FechaHora datetime
as
update Cliente set Nombre=@Nombre, Apellido=@Apellido, Direccion=@Direccion,
Cedula=@Cedula, Nacionalidad=@Nacionalidad,Telefono=@Telefono, [Correo Electronico]=@CorreoElectronico, Sexo=@Sexo, RNC=@RNC, FechaHora=@FechaHora where Id=@Id

GO
/****** Object:  StoredProcedure [dbo].[ModificarEmpleado]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ModificarEmpleado]
@Id int,
@Nombre varchar(50),
@Apellido Varchar(50),
@Direccion Varchar(100),
@Cedula varchar(30),
@Telefono varchar(15),
@CorreoElectronico varchar(50),
@idCargo int,
@Sexo nchar(2),
@Fecha date
as
update Empleado set Nombre=@Nombre, Apellido=@Apellido, Direccion=@Direccion,
Cedula=@Cedula,Telefono=@Telefono, [Correo Electronico]=@CorreoElectronico, idCargo=@idCargo, Sexo=@Sexo, Fecha=@Fecha where Id=@Id
GO
/****** Object:  StoredProcedure [dbo].[MostrarClientes]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MostrarClientes]
as
select * from Cliente

GO
/****** Object:  StoredProcedure [dbo].[MostrarDetalleSeguroContenido]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MostrarDetalleSeguroContenido]
as
select C.Id, C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Tipo de Vivienda], dSV.Situacion, dSV.Propietario,
dSV.[Vivienda habitual], dSV.[Vivienda Alquilada], dSV.[Codigo Postal], dSV.[Deshabitada por mas de tres meses al ano],
dSV.[Ano de Construccion], dSV.[M2 de la Vivienda], dSV.[DescripcionMuebles],
dSV.[ValorEstimadoMuebles], dSV.id_ctMueblesInmuebles as "Id Solicitud", dSV.Nota, cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleSeguroContenido dSV on ctv.id = dSV.id_ctMueblesInmuebles join cEstado cE on dSV.Estado = cE.idEstado

GO
/****** Object:  StoredProcedure [dbo].[MostrarDetalleSeguroEdificaciones]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE	 proc [dbo].[MostrarDetalleSeguroEdificaciones]
as
select C.Id, C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Tipo de Vivienda], dSV.Situacion, dSV.Propietario,
dSV.[Vivienda habitual], dSV.[Vivienda Alquilada], dSV.[Codigo Postal], dSV.[Deshabitada por mas de tres meses al ano],
dSV.[Ano de Construccion], dSV.[M2 de la Vivienda], dSV.[M2 de edificaciones anexas],
dSV.[Capital de otras instalaciones], dSV.Nota, dSV.Tipo, dSV.id_ctMueblesInmuebles as "Id Solicitud", cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleEdificaciones dSV on ctv.id = dSV.id_ctMueblesInmuebles join cEstado cE on dSV.Estado = cE.idEstado

GO
/****** Object:  StoredProcedure [dbo].[MostrarDetalleSeguroObligatorio]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[MostrarDetalleSeguroObligatorio]
as
select C.Id, C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Marca de Vehiculo], dSV.Modelo, dSV.Matricula,
dSV.Ano as "Año", dSV.Cilindros, dSV.Carroceria, dSV.Categoria, dSV.Uso, dSV.Nota,dSV.id_ctVehiculo as "Id Solicitud", cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleSeguroObligatorio dSV on ctv.id = dSV.id_ctVehiculo join cEstado cE on dSV.Estado = cE.idEstado

GO
/****** Object:  StoredProcedure [dbo].[MostrarDetalleSeguroTodoRiesgo]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MostrarDetalleSeguroTodoRiesgo]
as
select C.Id, C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Marca de Vehiculo], dSV.Modelo, dSV.Matricula,
dSV.Ano as "Año", dSV.Cilindros, dSV.Carroceria, dSV.Categoria, dSV.Uso, dSV.id_ctVehiculo as "Id Solicitud", dSV.Nota, cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleSeguroTodoRiesgo dSV on ctv.id = dSV.id_ctVehiculo join cEstado cE on dSV.Estado = cE.idEstado

GO
/****** Object:  StoredProcedure [dbo].[MostrarDetalleSeguroVoluntario]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MostrarDetalleSeguroVoluntario]
as
select C.Id as "Id Cliente", dSV.id_ctVehiculo as "Id Solicitud", C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Marca de Vehiculo], dSV.Modelo, dSV.Matricula,
dSV.Ano as "Año", dSV.Cilindros, dSV.Carroceria, dSV.Categoria, dSV.Uso, dSV.Nota, dSV.id_ctVehiculo as "Id Solicitud",cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleSeguroVoluntario dSV on ctv.id = dSV.id_ctVehiculo join cEstado cE on dSV.Estado = cE.idEstado

GO
/****** Object:  StoredProcedure [dbo].[MostrarEmpleados]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarEmpleados]
as
select * from Empleado


GO
/****** Object:  StoredProcedure [dbo].[MostrarSeguroEmpresaNegocios]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[MostrarSeguroEmpresaNegocios]
as
select C.Id, C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC  
,dSV.[Nombre Empresa]
      ,dSV.[Telefono de Entidad Autorizada]
      ,dSV.[Correo electronico de Entidad Autorizada]
      ,dSV.[Inspeccion del Local]
      ,dSV.[FechaHora]
      ,dSV.[Nota]
      ,dSV.[Tipo]
	  ,cE.Estado, dSV.Tipo, dSV.id_ctEmpresasNegocios as "Id Solicitud", dSV.FechaHora from Cliente C join ctEmpresasNegocios ctv on C.Id = ctv.id_Cliente
 join detalleSeguroEmpresaNegocio dSV on ctv.id = dSV.id_ctEmpresasNegocios join cEstado cE on dSV.Estado = cE.idEstado


GO
/****** Object:  StoredProcedure [dbo].[MostrarSegurosDePolizas]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarSegurosDePolizas]
as
select * from PolizaDeSeguros
GO
/****** Object:  StoredProcedure [dbo].[MostrarSiniestros]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MostrarSiniestros]
as
select c.Id as "id Cliente", c.Nombre, c.Apellido, c.Cedula, e.Nombre as "Empleado"
, s.Siniestro, s.FechaHora as "Fecha Hora" from Siniestros s join Cliente c on s.id_Cliente
= c.Id join Empleado e on s.id_Empleado = e.Id  
GO
/****** Object:  StoredProcedure [dbo].[RechazarSolicitud]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[RechazarSolicitud]
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as

 update detalleSeguroVoluntario set Estado =  @Estado, Nota = @Nota where id_ctVehiculo = @idSolicitud

  update ctVehiculo set idEstado =  @Estado where id = @idSolicitud

GO
/****** Object:  StoredProcedure [dbo].[RechazarSolicitudContenido]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[RechazarSolicitudContenido]
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as

update detalleSeguroContenido set Estado =  @Estado, Nota = @Nota where id_ctMueblesInmuebles = @idSolicitud
update ctMueblesInmuebles set idEstado =  @Estado where id = @idSolicitud
GO
/****** Object:  StoredProcedure [dbo].[RechazarSolicitudEdificaciones]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[RechazarSolicitudEdificaciones]
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as

update detalleEdificaciones set Estado =  @Estado, Nota = @Nota where id_ctMueblesInmuebles = @idSolicitud
update ctMueblesInmuebles set idEstado =  @Estado where id = @idSolicitud

GO
/****** Object:  StoredProcedure [dbo].[RechazarSolicitudEmpresasNegocio]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[RechazarSolicitudEmpresasNegocio]
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as

update detalleSeguroEmpresaNegocio set Estado =  @Estado, Nota = @Nota where id_ctEmpresasNegocios = @idSolicitud
update ctEmpresasNegocios set idEstado =  @Estado where id = @idSolicitud
GO
/****** Object:  StoredProcedure [dbo].[RechazarSolicitudObligatorio]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[RechazarSolicitudObligatorio]
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as

update detalleSeguroObligatorio set Estado =  @Estado, Nota = @Nota where id_ctVehiculo = @idSolicitud
update ctVehiculo set idEstado =  @Estado where id = @idSolicitud


GO
/****** Object:  StoredProcedure [dbo].[RechazarSolicitudTodoRiesgo]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[RechazarSolicitudTodoRiesgo]
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as

update detalleSeguroTodoRiesgo set Estado =  @Estado, Nota = @Nota where id_ctVehiculo = @idSolicitud
update ctVehiculo set idEstado =  @Estado where id = @idSolicitud

GO
/****** Object:  StoredProcedure [dbo].[RenovacionPoliza]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[RenovacionPoliza]
@IdPoliza int, --
@IdCliente int, --
@IdEmpleado int, --

@Poliza varchar(MAX), /**/
@Precio decimal(18,2), --
@T_Pago decimal(18,2), --
@Parcial decimal(18,2), --
@FechaHora datetime, --
@Vencimiento date /**/
as
update vdPoliza set Poliza= @Poliza,
Estado= 1, FechaHora= @FechaHora, Vencimiento= @Vencimiento
where id= @IdPoliza

declare @IdPolizaDeSeguro int
set @IdPolizaDeSeguro = (Select vdPoliza.IdPolizaDeSeguro from vdPoliza where vdPoliza.id = @IdPoliza)

insert into PagoPolizas(id_Cliente,id_Empleado, idPolizaDeSeguro,
idPolizaVd,Precio, T_Pago, [Pago Parcial], FechaHora)
values (@IdCliente, @IdEmpleado, @IdPolizaDeSeguro, @IdPoliza, @Precio, @T_Pago, @Parcial,
 @FechaHora)
GO
/****** Object:  StoredProcedure [dbo].[RenovacionPolizaEmpresaNegocio]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[RenovacionPolizaEmpresaNegocio]
@IdPoliza int, --
@IdCliente int, --
@IdEmpleado int, --

@Poliza varchar(MAX), /**/
@Precio decimal(18,2), --
@T_Pago decimal(18,2), --
@Parcial decimal(18,2), --
@FechaHora datetime, --
@Vencimiento date /**/
as
update emPoliza set Poliza= @Poliza,
Estado= 1, FechaHora= @FechaHora, Vencimiento= @Vencimiento
where id= @IdPoliza

declare @IdPolizaDeSeguro int
set @IdPolizaDeSeguro = (Select vdPoliza.IdPolizaDeSeguro from vdPoliza where vdPoliza.id = @IdPoliza)

insert into PagoPolizas(id_Cliente,id_Empleado, idPolizaDeSeguro,
idPolizaVd,Precio, T_Pago, [Pago Parcial], FechaHora)
values (@IdCliente, @IdEmpleado, @IdPolizaDeSeguro, @IdPoliza, @Precio, @T_Pago, @Parcial,
 @FechaHora)
GO
/****** Object:  StoredProcedure [dbo].[RenovacionPolizaInmuebles]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[RenovacionPolizaInmuebles]
@IdPoliza int, --
@IdCliente int, --
@IdEmpleado int, --

@Poliza varchar(MAX), /**/
@Precio decimal(18,2), --
@T_Pago decimal(18,2), --
@Parcial decimal(18,2), --
@FechaHora datetime, --
@Vencimiento date /**/
as
update inPoliza set Poliza= @Poliza,
Estado= 1, FechaHora= @FechaHora, Vencimiento= @Vencimiento
where id= @IdPoliza

declare @IdPolizaDeSeguro int
set @IdPolizaDeSeguro = (Select vdPoliza.IdPolizaDeSeguro from vdPoliza where vdPoliza.id = @IdPoliza)

insert into PagoPolizas(id_Cliente,id_Empleado, idPolizaDeSeguro,
idPolizaVd,Precio, T_Pago, [Pago Parcial], FechaHora)
values (@IdCliente, @IdEmpleado, @IdPolizaDeSeguro, @IdPoliza, @Precio, @T_Pago, @Parcial,
 @FechaHora)

GO
/****** Object:  StoredProcedure [dbo].[RenovacionPolizaVehiculo]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[RenovacionPolizaVehiculo]
@IdPoliza int, --
@IdCliente int, --
@IdEmpleado int, --

@Poliza varchar(MAX), /**/
@Precio decimal(18,2), --
@T_Pago decimal(18,2), --
@Parcial decimal(18,2), --
@FechaHora datetime, --
@Vencimiento date /**/
as
update vhPoliza set Poliza= @Poliza,
Estado= 1, FechaHora= @FechaHora, Vencimiento= @Vencimiento
where id= @IdPoliza

declare @IdPolizaDeSeguro int
set @IdPolizaDeSeguro = (Select vdPoliza.IdPolizaDeSeguro from vdPoliza where vdPoliza.id = @IdPoliza)

insert into PagoPolizas(id_Cliente,id_Empleado, idPolizaDeSeguro,
idPolizaVd,Precio, T_Pago, [Pago Parcial], FechaHora)
values (@IdCliente, @IdEmpleado, @IdPolizaDeSeguro, @IdPoliza, @Precio, @T_Pago, @Parcial,
 @FechaHora)
GO
/****** Object:  StoredProcedure [dbo].[SeguroContenido]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SeguroContenido] ---------------------------------------------
as
select ct.id_Cliente
	  ,sen.[id]
	  ,sen.idFactura as "Id Factura"
      ,[Tipo de Vivienda]
      ,[Situacion]
      ,[Propietario]
      ,[Vivienda habitual]
      ,[Vivienda Alquilada]
      ,[Codigo Postal]
      ,[Deshabitada por mas de tres meses al ano]
      ,[Ano de Construccion]
      ,[M2 de la Vivienda]
      ,[DescripcionMuebles]
      ,[ValorEstimadoMuebles]
      ,cE.Estado
      ,[id_Seguro]
      ,[Precio]
      ,[T_Pago]
      ,[Pago Parcial]
      ,[Descuento]
	  ,sen.Tipo
	  ,sen.[FechaHora] as "Fecha Hora"
      ,sen.[Nota] from detalleSeguroContenido sen join cEstado cE on sen.Estado = cE.idEstado
	  join ctMueblesInmuebles ct on sen.id_ctMueblesInmuebles = ct.id join Facturas f on f.id = sen.idFactura where sen.Estado = 1
GO
/****** Object:  StoredProcedure [dbo].[SeguroEdificaciones]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SeguroEdificaciones]
as
select ct.id_Cliente
	  ,sen.[id]
	   ,sen.idFactura as "Id Factura"
      ,[Tipo de Vivienda]
      ,[Situacion]
      ,[Propietario]
      ,[Vivienda habitual]
      ,[Vivienda Alquilada]
      ,[Codigo Postal]
      ,[Deshabitada por mas de tres meses al ano]
      ,[Ano de Construccion]
      ,[M2 de la Vivienda]
      ,[M2 de edificaciones anexas]
      ,[Capital de otras instalaciones]
      ,cE.Estado
      ,[id_Seguro]
      ,[Precio]
      ,[T_Pago]
      ,[Pago Parcial]
      ,[Descuento]
	  ,sen.Tipo
	  ,sen.[FechaHora] as "Fecha Hora"
      ,sen.[Nota] from detalleEdificaciones sen join cEstado cE on sen.Estado = cE.idEstado
	  join ctMueblesInmuebles ct on sen.id_ctMueblesInmuebles = ct.id join Facturas f on f.id = sen.idFactura where sen.Estado = 1
GO
/****** Object:  StoredProcedure [dbo].[SeguroEmpresasNegocios]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SeguroEmpresasNegocios]
as
select ct.id_Cliente
	  ,sen.[id]
	   ,sen.idFactura as "Id Factura"
      ,[Nombre Empresa]
      ,[Telefono de Entidad Autorizada]
      ,[Correo electronico de Entidad Autorizada]
      ,[Inspeccion del Local]
      ,cE.Estado
      ,sen.[Nota]
	  ,cE.Estado
      ,[id_Seguro]
      ,[Precio]
      ,[T_Pago]
      ,[Pago Parcial]
      ,[Descuento]
	  ,sen.Tipo
	  ,sen.[FechaHora] as "Fecha Hora" from detalleSeguroEmpresaNegocio sen join cEstado cE on sen.Estado = cE.idEstado
	  join ctEmpresasNegocios ct on sen.id_ctEmpresasNegocios = ct.id join Facturas f on f.id = sen.idFactura where sen.Estado = 1
GO
/****** Object:  StoredProcedure [dbo].[SeguroObligatorio]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SeguroObligatorio]
as
select ct.id_Cliente
	  ,sen.[id] as "Id Solicitud"
	  ,sen.idFactura as "Id Factura"
      ,[Marca de Vehiculo]
      ,[Modelo]
      ,[Matricula]
      ,[Ano] as "Año"
      ,[Cilindros]
      ,[Carroceria]
      ,[Categoria]
      ,[Uso]
      ,sen.[Nota]
      ,cE.Estado
      ,[id_Seguro]
      ,[Precio]
      ,[T_Pago]
      ,[Pago Parcial]
      ,[Descuento]
	  ,sen.Tipo
	  ,sen.[FechaHora] as "Fecha Hora" from detalleSeguroObligatorio sen join cEstado cE on sen.Estado = cE.idEstado
	  join ctVehiculo ct on sen.id_ctVehiculo = ct.id join Facturas f on f.id = sen.idFactura where sen.Estado = 1
GO
/****** Object:  StoredProcedure [dbo].[SeguroTodoRiesgo]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SeguroTodoRiesgo]
as
select ct.id_Cliente
	  ,sen.[id] as "Id Solicitud"
	  ,sen.idFactura as "Id Factura"
      ,[Marca de Vehiculo]
      ,[Modelo]
      ,[Matricula]
      ,[Ano] as "Año"
      ,[Cilindros]
      ,[Carroceria]
      ,[Categoria]
      ,[Uso]
      ,sen.[Nota]
      ,cE.Estado
      ,[id_Seguro]
      ,[Precio]
      ,[T_Pago]
      ,[Pago Parcial]
      ,[Descuento]
	  ,sen.Tipo
	  ,sen.[FechaHora] as "Fecha Hora" from detalleSeguroTodoRiesgo sen join cEstado cE on sen.Estado = cE.idEstado
	  join ctVehiculo ct on sen.id_ctVehiculo = ct.id join Facturas f on f.id = sen.idFactura where sen.Estado = 1

GO
/****** Object:  StoredProcedure [dbo].[SeguroVoluntario]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SeguroVoluntario]
as
select ct.id_Cliente
	  ,sen.[id] as "Id Solicitud"
	  ,sen.idFactura as "Id Factura"
      ,[Marca de Vehiculo]
      ,[Modelo]
      ,[Matricula]
      ,[Ano] as "Año"
      ,[Cilindros]
      ,[Carroceria]
      ,[Categoria]
      ,[Uso]
      ,sen.[Nota]
      ,cE.Estado
      ,[id_Seguro]
      ,[Precio]
      ,[T_Pago]
      ,[Pago Parcial]
      ,[Descuento]
	  ,sen.Tipo
	  ,sen.[FechaHora] as "Fecha Hora" from detalleSeguroVoluntario sen join cEstado cE on sen.Estado = cE.idEstado
	  join ctVehiculo ct on sen.id_ctVehiculo = ct.id join Facturas f on f.id = sen.idFactura where sen.Estado = 1


GO
/****** Object:  StoredProcedure [dbo].[vd_MostrarPolizas]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[vd_MostrarPolizas]
as
select vdPoliza.Id_Cliente AS "Id Cliente", vdPoliza.id AS "Núm. Póliza", PolizaDeSeguros.[Nombre del Seguro], vdPoliza.Poliza, PolizaDeSeguros.Area, PolizaDeSeguros.Precio, cEstado.Validacion AS "Estado", vdPoliza.FechaHora AS "Fecha Hora",
 vdPoliza.Vencimiento, Cliente.Nombre, Cliente.Apellido,
 Cliente.Cedula AS "Cédula", Cliente.Telefono AS "Teléfono", Cliente.Sexo, vdPoliza.Nota
  from vdPoliza join PolizaDeSeguros on vdPoliza.idPolizaDeSeguro = PolizaDeSeguros.id  join Cliente on vdPoliza.Id_Cliente = Cliente.Id
join cEstado on vdPoliza.Estado = cEstado.idEstado 
GO
/****** Object:  StoredProcedure [dbo].[vd_MostrarPolizasEmpresasNegocio]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[vd_MostrarPolizasEmpresasNegocio]
as
select e.Id_Cliente AS "Id Cliente", e.id AS "Núm. Póliza", PolizaDeSeguros.[Nombre del Seguro], e.Poliza, PolizaDeSeguros.Area, PolizaDeSeguros.Precio, cEstado.Validacion AS "Estado", e.FechaHora AS "Fecha Hora",
 e.Vencimiento, Cliente.Nombre, Cliente.Apellido,
 Cliente.Cedula AS "Cédula", Cliente.Telefono AS "Teléfono", Cliente.Sexo, e.Nota
  from emPoliza  e join PolizaDeSeguros on e.idPolizaDeSeguro = PolizaDeSeguros.id  join Cliente on e.Id_Cliente = Cliente.Id
join cEstado on e.Estado = cEstado.idEstado 

GO
/****** Object:  StoredProcedure [dbo].[vd_MostrarPolizasInmuebles]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[vd_MostrarPolizasInmuebles]
as
select i.Id_Cliente AS "Id Cliente", i.id AS "Núm. Póliza", PolizaDeSeguros.[Nombre del Seguro], i.Poliza, PolizaDeSeguros.Area, PolizaDeSeguros.Precio, cEstado.Validacion AS "Estado", i.FechaHora AS "Fecha Hora",
 i.Vencimiento, Cliente.Nombre, Cliente.Apellido,
 Cliente.Cedula AS "Cédula", Cliente.Telefono AS "Teléfono", Cliente.Sexo, i.Nota
  from inPoliza i join PolizaDeSeguros on i.idPolizaDeSeguro = PolizaDeSeguros.id  join Cliente on i.Id_Cliente = Cliente.Id
join cEstado on i.Estado = cEstado.idEstado 
GO
/****** Object:  StoredProcedure [dbo].[vd_MostrarPolizasVehiculo]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[vd_MostrarPolizasVehiculo]
as
select v.Id_Cliente AS "Id Cliente", v.id AS "Núm. Póliza", PolizaDeSeguros.[Nombre del Seguro], v.Poliza, PolizaDeSeguros.Area, PolizaDeSeguros.Precio, cEstado.Validacion AS "Estado", v.FechaHora AS "Fecha Hora",
 v.Vencimiento, Cliente.Nombre, Cliente.Apellido,
 Cliente.Cedula AS "Cédula", Cliente.Telefono AS "Teléfono", Cliente.Sexo, v.Nota
  from vhPoliza v join PolizaDeSeguros on v.idPolizaDeSeguro = PolizaDeSeguros.id  join Cliente on v.Id_Cliente = Cliente.Id
join cEstado on v.Estado = cEstado.idEstado 
GO
/****** Object:  StoredProcedure [dbo].[VerFacturasSolicitud]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[VerFacturasSolicitud]
as
select c.Nombre, c.Apellido, c.Cedula, e.Nombre as "Atendido por", ps.[Nombre del Seguro], f.Precio, f.T_Pago, f.[Pago Parcial],
f.SubTotal, f.Descuento, f.FechaHora as "Fecha Hora", f.Nota from Facturas f join Cliente c on f.id_Cliente
= c.Id join Empleado e on f.id_Empleado = e.Id join PolizaDeSeguros ps on
f.id_Seguro = ps.id
GO
/****** Object:  StoredProcedure [dbo].[VerReclamos]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[VerReclamos]
as
select c.Nombre, c.Apellido, c.Cedula, r.id_Siniestro,
ps.[Nombre del Seguro], cE.Estado, r.Deducible, r.[Costo estimado], r.FechaHora as "Fecha Hora"
 from vdReclamos r join Cliente c on r.id_Cliente = c.Id join PolizaDeSeguros ps on
r.id_Poliza = ps.id join cEstado cE on r.Estado = cE.idEstado
GO
/****** Object:  StoredProcedure [dbo].[VerSiniestros]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[VerSiniestros]
as
select c.Nombre, c.Apellido, c.Cedula, e.Nombre as "Empleado"
, s.Siniestro, s.FechaHora as "Fecha Hora" from Siniestros s join Cliente c on s.id_Cliente
= c.Id join Empleado e on s.id_Empleado = e.Id  
GO
/****** Object:  StoredProcedure [dbo].[vh_MostrarPolizas]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[vh_MostrarPolizas]
as
select Pol.Id_Cliente AS "Id Cliente", Pol.id AS "Núm. Póliza", ps.[Nombre del Seguro], Pol.Poliza, ps.Area, ps.Precio, cE.Validacion AS "Estado", Pol.FechaHora AS "Fecha Hora",
 Pol.Vencimiento, Cliente.Nombre, Cliente.Apellido,
 Cliente.Cedula AS "Cédula", Cliente.Telefono AS "Teléfono", Cliente.Sexo, Pol.Nota
  from vhPoliza Pol join PolizaDeSeguros ps on Pol.idPolizaDeSeguro = ps.id  join Cliente on Pol.Id_Cliente = Cliente.Id
join cEstado cE on Pol.Estado = cE.idEstado 
GO
/****** Object:  Table [dbo].[CargoEmp]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CargoEmp](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Cargo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CargoEmp] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CategoriaPolizas]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CategoriaPolizas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_SeguroPoliza] [int] NOT NULL,
	[Categoria] [varchar](50) NOT NULL,
	[Tipo] [varchar](10) NULL,
 CONSTRAINT [PK_CategoriaPolizas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cEstado]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cEstado](
	[idEstado] [int] IDENTITY(1,1) NOT NULL,
	[Validacion] [varchar](20) NOT NULL,
	[Estado] [varchar](20) NOT NULL,
 CONSTRAINT [PK_cEstado] PRIMARY KEY CLUSTERED 
(
	[idEstado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Direccion] [varchar](max) NOT NULL,
	[Cedula] [varchar](15) NOT NULL,
	[Nacionalidad] [varchar](50) NULL,
	[Telefono] [varchar](15) NOT NULL,
	[Correo Electronico] [varchar](50) NOT NULL,
	[Sexo] [varchar](1) NOT NULL,
	[RNC] [varchar](15) NULL,
	[FechaHora] [datetime] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ctEmpresasNegocios]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ctEmpresasNegocios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NOT NULL,
	[id_Empleado] [int] NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Fecha] [date] NOT NULL,
	[idEstado] [int] NOT NULL,
 CONSTRAINT [PK_ctEmpresasNegocios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ctMueblesInmuebles]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ctMueblesInmuebles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NULL,
	[id_Empleado] [int] NULL,
	[Total] [decimal](18, 2) NULL,
	[Fecha] [datetime] NULL,
	[idEstado] [int] NULL,
 CONSTRAINT [PK_ctMueblesInmuebles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ctVehiculo]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ctVehiculo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NULL,
	[id_Empleado] [int] NULL,
	[Total] [decimal](18, 2) NULL,
	[Fecha] [datetime] NULL,
	[idEstado] [int] NULL,
 CONSTRAINT [PK_SeguroVoluntario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ctVida]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ctVida](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NOT NULL,
	[id_Empleado] [int] NOT NULL,
	[Total] [decimal](18, 2) NULL,
	[FechaHora] [datetime] NOT NULL,
	[idEstado] [int] NOT NULL,
 CONSTRAINT [PK_ctVida] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dependientesSeguroSalud]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dependientesSeguroSalud](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_detalleSeguroSalud] [int] NOT NULL,
	[Parentesco] [varchar](50) NOT NULL,
	[Fecha Nacimiento] [varchar](50) NOT NULL,
	[Oficialia] [varchar](50) NOT NULL,
	[Libro] [varchar](50) NOT NULL,
	[Folio] [varchar](50) NOT NULL,
	[Acta] [varchar](50) NOT NULL,
	[Ano] [varchar](50) NOT NULL,
	[Antecedentes personales] [varchar](max) NOT NULL,
	[Estado] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Nota] [varchar](max) NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_dependientesSeguroSalud] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalleEdificaciones]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleEdificaciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idFactura] [int] NOT NULL,
	[id_ctMueblesInmuebles] [int] NOT NULL,
	[Tipo de Vivienda] [varchar](50) NOT NULL,
	[Situacion] [varchar](50) NOT NULL,
	[Propietario] [varchar](50) NOT NULL,
	[Vivienda habitual] [varchar](4) NOT NULL,
	[Vivienda Alquilada] [varchar](50) NOT NULL,
	[Codigo Postal] [varchar](15) NOT NULL,
	[Deshabitada por mas de tres meses al ano] [varchar](50) NOT NULL,
	[Ano de Construccion] [int] NOT NULL,
	[M2 de la Vivienda] [decimal](18, 2) NOT NULL,
	[M2 de edificaciones anexas] [decimal](18, 2) NOT NULL,
	[Capital de otras instalaciones] [varchar](max) NOT NULL,
	[Estado] [int] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Nota] [varchar](max) NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_detalleEdificaciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalleSeguroContenido]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleSeguroContenido](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_ctMueblesInmuebles] [int] NOT NULL,
	[idFactura] [int] NOT NULL,
	[Tipo de Vivienda] [varchar](50) NOT NULL,
	[Situacion] [varchar](50) NOT NULL,
	[Propietario] [varchar](50) NOT NULL,
	[Vivienda habitual] [varchar](50) NOT NULL,
	[Vivienda Alquilada] [varchar](50) NOT NULL,
	[Codigo Postal] [varchar](15) NOT NULL,
	[Deshabitada por mas de tres meses al ano] [varchar](50) NOT NULL,
	[Ano de Construccion] [int] NOT NULL,
	[M2 de la Vivienda] [decimal](18, 2) NOT NULL,
	[DescripcionMuebles] [varchar](max) NOT NULL,
	[ValorEstimadoMuebles] [int] NOT NULL,
	[Estado] [int] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Nota] [varchar](max) NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_detalleSeguroContenido] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalleSeguroEmpresaNegocio]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleSeguroEmpresaNegocio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idFactura] [int] NOT NULL,
	[id_ctEmpresasNegocios] [int] NOT NULL,
	[Nombre Empresa] [varchar](80) NOT NULL,
	[Copia de los Estatutos] [varbinary](max) NOT NULL,
	[Copia Acta Asignacion RNC] [varbinary](max) NOT NULL,
	[Copia Cedula Presidente y Representante autorizado] [varbinary](max) NOT NULL,
	[Telefono de Entidad Autorizada] [varchar](30) NOT NULL,
	[Correo electronico de Entidad Autorizada] [varchar](50) NOT NULL,
	[Inspeccion del Local] [varchar](50) NOT NULL,
	[Estado] [int] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Nota] [varchar](max) NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_detalleSeguroEmpresaNegocio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalleSeguroObligatorio]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleSeguroObligatorio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_ctVehiculo] [int] NOT NULL,
	[Marca de Vehiculo] [varchar](20) NOT NULL,
	[Modelo] [varchar](20) NOT NULL,
	[Matricula] [varchar](20) NOT NULL,
	[Ano] [int] NOT NULL,
	[Cilindros] [int] NOT NULL,
	[Carroceria] [varchar](20) NOT NULL,
	[Categoria] [varchar](20) NOT NULL,
	[Uso] [varchar](20) NOT NULL,
	[Nota] [varchar](max) NULL,
	[Estado] [int] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[idFactura] [int] NOT NULL,
 CONSTRAINT [PK_SeguroObligatorio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalleSeguroRiesgoMuerte]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleSeguroRiesgoMuerte](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_ctVida] [int] NOT NULL,
	[Antecedentes Personales] [varchar](max) NOT NULL,
	[InstitutoDondeLabora] [varchar](50) NOT NULL,
	[Estado] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Nota] [varchar](max) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[idFactura] [int] NOT NULL,
 CONSTRAINT [PK_detalleSeguroRiesgoMuerte] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalleSeguroRiesgosLaborales]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleSeguroRiesgosLaborales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_ctVida] [int] NOT NULL,
	[Copia ultima Asamblea] [image] NOT NULL,
	[Copia Estatutos] [image] NOT NULL,
	[Certificacion Inscripcion DGII y Regimen Tributario] [image] NOT NULL,
	[Fecha Registro DGII] [date] NOT NULL,
	[Copia Acta de Asignacion del RNC] [image] NOT NULL,
	[Copia Registro Mercantil] [image] NOT NULL,
	[Carta de Solicitud Entidad Autorizada] [varchar](max) NOT NULL,
	[Copia Cedula Presidente y Representante autorizado] [image] NOT NULL,
	[Telefono de Entidad Autorizada] [varchar](30) NOT NULL,
	[Correo electronico de Entidad Autorizada] [varchar](50) NOT NULL,
	[Validacion] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK_detalleSeguroRiesgosLaborales] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalleSeguroSalud]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleSeguroSalud](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_ctVida] [int] NOT NULL,
	[InstitucionDondeLabora] [varchar](50) NOT NULL,
	[Antecedentes personales] [varchar](max) NOT NULL,
	[Estado] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Nota] [varchar](max) NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_detalleSeguroSalud] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalleSeguroTodoRiesgo]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleSeguroTodoRiesgo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_ctVehiculo] [int] NOT NULL,
	[Marca de Vehiculo] [varchar](20) NOT NULL,
	[Modelo] [varchar](20) NOT NULL,
	[Matricula] [varchar](20) NOT NULL,
	[Ano] [int] NOT NULL,
	[Cilindros] [int] NOT NULL,
	[Carroceria] [varchar](20) NOT NULL,
	[Categoria] [varchar](20) NOT NULL,
	[Uso] [varchar](20) NOT NULL,
	[Nota] [varchar](max) NULL,
	[Estado] [int] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[idFactura] [int] NOT NULL,
 CONSTRAINT [PK_SeguroTodoRiesgo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalleSeguroVoluntario]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleSeguroVoluntario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[id_ctVehiculo] [int] NOT NULL,
	[Marca de Vehiculo] [varchar](20) NOT NULL,
	[Modelo] [varchar](20) NOT NULL,
	[Matricula] [varchar](20) NOT NULL,
	[Ano] [int] NOT NULL,
	[Cilindros] [int] NOT NULL,
	[Carroceria] [varchar](20) NOT NULL,
	[Categoria] [varchar](20) NOT NULL,
	[Uso] [varchar](20) NOT NULL,
	[Nota] [varchar](max) NULL,
	[Estado] [int] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[idFactura] [int] NOT NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Devoluciones]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Devoluciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NOT NULL,
	[id_Solicitud] [int] NULL,
	[id_Poliza] [int] NULL,
	[A Devolver] [decimal](18, 2) NOT NULL,
	[Motivo] [varchar](max) NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[idPolizaDeSeguro] [int] NOT NULL,
 CONSTRAINT [PK_Devoluciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[emEvidencia]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emEvidencia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Imagen] [image] NOT NULL,
	[id_emReclamos] [int] NOT NULL,
 CONSTRAINT [PK_emEvidencia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id] [int] IDENTITY(1,893641) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Direccion] [varchar](max) NOT NULL,
	[Cedula] [varchar](30) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
	[Correo Electronico] [varchar](50) NOT NULL,
	[idCargo] [int] NOT NULL,
	[Sexo] [varchar](1) NOT NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[emPoliza]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[emPoliza](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[IdPolizaDeSeguro] [int] NOT NULL,
	[Poliza] [varchar](max) NOT NULL,
	[Estado] [int] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Vencimiento] [date] NOT NULL,
	[Nota] [varchar](max) NULL,
 CONSTRAINT [PK_emPoliza] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmpSeguroRiesgosLaborales]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmpSeguroRiesgosLaborales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_detalleSeguroRiesgosLab] [int] NULL,
	[Nomina Empleado] [varbinary](max) NULL,
	[Carta de Solicitud Repres y Prop] [varbinary](max) NULL,
	[Copia Cedula Propietario] [varbinary](max) NULL,
	[Copia Cedula Representante] [varbinary](max) NULL,
	[Estado] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Nota] [varchar](max) NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EmpSeguroRiesgosLaborales] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[emReclamos]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emReclamos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NOT NULL,
	[id_Siniestro] [int] NOT NULL,
	[id_Poliza] [int] NOT NULL,
	[Acta Policial] [image] NULL,
	[Copia matricula] [image] NULL,
	[Copia cedula] [image] NULL,
	[Estado] [int] NOT NULL,
	[Deducible] [decimal](18, 2) NOT NULL,
	[Costo estimado] [decimal](18, 2) NULL,
	[FechaHora] [datetime] NOT NULL,
 CONSTRAINT [PK_emReclamos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Facturas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NOT NULL,
	[id_Empleado] [int] NOT NULL,
	[id_Solicitud] [int] NOT NULL,
	[id_Seguro] [int] NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[T_Pago] [varchar](25) NOT NULL,
	[Pago Parcial] [decimal](18, 2) NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
	[Descuento] [decimal](18, 2) NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Nota] [varchar](max) NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[imagenesCotenidoInspSeguroEmpresas]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[imagenesCotenidoInspSeguroEmpresas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_detallesSeguroEmpresasN] [int] NOT NULL,
	[Imagen] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_imagenesCotenidoInspSeguroEmpresas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inEvidencia]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inEvidencia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Imagen] [varbinary](max) NOT NULL,
	[id_inReclamos] [int] NOT NULL,
 CONSTRAINT [PK_inEvidencia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inPoliza]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inPoliza](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[IdPolizaDeSeguro] [int] NOT NULL,
	[Poliza] [varchar](max) NOT NULL,
	[Estado] [int] NOT NULL,
	[Vencimiento] [date] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Nota] [varchar](max) NULL,
 CONSTRAINT [PK_inPoliza] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inReclamos]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inReclamos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NOT NULL,
	[id_Siniestro] [int] NOT NULL,
	[id_Poliza] [int] NOT NULL,
	[Acta Policial] [image] NULL,
	[Copia matricula] [image] NULL,
	[Copia cedula] [image] NULL,
	[Estado] [int] NOT NULL,
	[Deducible] [decimal](18, 2) NOT NULL,
	[Costo estimado] [decimal](18, 2) NULL,
	[FechaHora] [datetime] NOT NULL,
 CONSTRAINT [PK_inReclamos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PagoPolizas]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PagoPolizas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NOT NULL,
	[id_Empleado] [int] NOT NULL,
	[idPolizaDeSeguro] [int] NOT NULL,
	[idPolizaVd] [int] NULL,
	[idPolizaEm] [int] NULL,
	[idPolizaVh] [int] NULL,
	[idPolizaIn] [int] NULL,
	[FechaHora] [datetime] NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[T_Pago] [decimal](18, 2) NOT NULL,
	[Pago Parcial] [decimal](18, 2) NULL,
	[Nota] [varchar](max) NULL,
 CONSTRAINT [PK_PagoPolizas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PolizaDeSeguros]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PolizaDeSeguros](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre del Seguro] [varchar](50) NOT NULL,
	[Area] [varchar](100) NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK_Seguros] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Siniestro_Reclamos]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siniestro_Reclamos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Siniestro] [int] NULL,
	[id_vhReclamo] [int] NULL,
	[id_vdReclamo] [int] NULL,
	[id_inReclamo] [int] NULL,
	[id_emReclamo] [int] NULL,
 CONSTRAINT [PK_Siniestro_Reclamos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Siniestros]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Siniestros](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NOT NULL,
	[id_Empleado] [int] NOT NULL,
	[Siniestro] [varchar](max) NULL,
	[FechaHora] [datetime] NULL,
 CONSTRAINT [PK_Siniestros] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[Contrasena] [varchar](50) NOT NULL,
	[Privilegio] [varchar](50) NOT NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vdEvidencia]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vdEvidencia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Imagen] [varbinary](max) NOT NULL,
	[id_vdReclamos] [int] NOT NULL,
 CONSTRAINT [PK_vdEvidencia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vdPoliza]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vdPoliza](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[IdPolizaDeSeguro] [int] NULL,
	[Poliza] [varchar](max) NOT NULL,
	[Estado] [int] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Vencimiento] [date] NOT NULL,
	[Nota] [varchar](max) NULL,
 CONSTRAINT [PK_vdPoliza] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vdReclamos]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vdReclamos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NOT NULL,
	[id_Siniestro] [int] NOT NULL,
	[id_Poliza] [int] NOT NULL,
	[Acta Policial] [image] NULL,
	[Copia matricula] [image] NULL,
	[Copia cedula] [image] NULL,
	[Estado] [int] NOT NULL,
	[Deducible] [decimal](18, 2) NOT NULL,
	[Costo estimado] [decimal](18, 2) NULL,
	[FechaHora] [datetime] NOT NULL,
 CONSTRAINT [PK_vdReclamos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vhEvidencia]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vhEvidencia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Imagen] [varbinary](max) NULL,
	[id_vhReclamos] [int] NOT NULL,
 CONSTRAINT [PK_vhEvidencia_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vhPoliza]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vhPoliza](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[IdPolizaDeSeguro] [int] NOT NULL,
	[Poliza] [varchar](max) NOT NULL,
	[Estado] [int] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Vencimiento] [date] NOT NULL,
	[Nota] [varchar](max) NULL,
 CONSTRAINT [PK_Poliza_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vhReclamos]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vhReclamos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NOT NULL,
	[id_Siniestro] [int] NOT NULL,
	[id_Poliza] [int] NOT NULL,
	[Acta Policial] [image] NULL,
	[Copia matricula] [image] NULL,
	[Copia cedula] [image] NULL,
	[Estado] [int] NOT NULL,
	[Deducible] [decimal](18, 2) NOT NULL,
	[Costo estimado] [decimal](18, 2) NULL,
	[FechaHora] [datetime] NOT NULL,
 CONSTRAINT [PK_vhReclamos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  View [dbo].[FacturasDelMesActual]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[FacturasDelMesActual]
as
select c.Nombre, c.Apellido, c.Cedula, e.Nombre as "Atendido_por", ps.[Nombre del Seguro] as Nombre_del_Seguro, f.Precio, f.T_Pago, f.[Pago Parcial] as Pago_Parcial,
f.SubTotal, f.Descuento, f.FechaHora as "Fecha_Hora", f.Nota from Facturas f join Cliente c on f.id_Cliente
= c.Id join Empleado e on f.id_Empleado = e.Id join PolizaDeSeguros ps on
f.id_Seguro = ps.id where DATEPART(mm, f.FechaHora) = DATEPART(mm, GETDATE())
GO
/****** Object:  View [dbo].[PolizasEmitidasAlMes]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[PolizasEmitidasAlMes]
as
select vd.Id as "NúmPoliza", PS.[Nombre del Seguro] as Nombre_del_Seguro, PS.Area, cE.Validacion as "Estado", vd.FechaHora from vdPoliza vd join PolizaDeSeguros PS
on vd.IdPolizaDeSeguro = Ps.id join cEstado cE on vd.Estado = cE.idEstado where DATEPART(mm, vd.FechaHora) = DATEPART(mm, GETDATE()) 
 UNION  
select em.Id as "NúmPoliza", PS.[Nombre del Seguro] as Nombre_del_Seguro, PS.Area, cE.Validacion as "Estado", em.FechaHora from emPoliza em join PolizaDeSeguros PS
on em.IdPolizaDeSeguro = Ps.id join cEstado cE on em.Estado = cE.idEstado where DATEPART(mm, em.FechaHora) = DATEPART(mm, GETDATE()) 
 UNION  
select vh.Id as "NúmPoliza", PS.[Nombre del Seguro] as Nombre_del_Seguro, PS.Area, cE.Validacion as "Estado", vh.FechaHora from vhPoliza vh join PolizaDeSeguros PS
on vh.IdPolizaDeSeguro = Ps.id join cEstado cE on vh.Estado = cE.idEstado where DATEPART(mm, vh.FechaHora) = DATEPART(mm, GETDATE()) 
 UNION  
select _in.Id as "NúmPoliza", PS.[Nombre del Seguro] as Nombre_del_Seguro, PS.Area, cE.Validacion as "Estado", _in.FechaHora from inPoliza _in join PolizaDeSeguros PS
on _in.IdPolizaDeSeguro = Ps.id join cEstado cE on _in.Estado = cE.idEstado where DATEPART(mm, _in.FechaHora) = DATEPART(mm, GETDATE()) 

GO
/****** Object:  View [dbo].[SiniestrosAlMes]    Script Date: 27/01/2020 6:40:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[SiniestrosAlMes]
as
select c.Nombre, c.Apellido, c.Cedula, e.Nombre as "Empleado"
, s.Siniestro, s.FechaHora from Siniestros s join Cliente c on s.id_Cliente
= c.Id join Empleado e on s.id_Empleado = e.Id  where DATEPART(mm, s.FechaHora) = DATEPART(mm, GETDATE()) 
GO
SET IDENTITY_INSERT [dbo].[CargoEmp] ON 

INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (6, N'Administrador Contable')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (5, N'Agente de Negocio')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (10, N'Analista de políticas')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (4, N'Digitador')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (3, N'Emisor de Póliza')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (2, N'Gerente')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (18, N'Maestro')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (8, N'Presidente')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (9, N'Secretario')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (1, N'Servicio al cliente')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (7, N'Sub Gerente')
SET IDENTITY_INSERT [dbo].[CargoEmp] OFF
SET IDENTITY_INSERT [dbo].[CategoriaPolizas] ON 

INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (1, 1, N'Básico', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (2, 1, N'Básico', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (3, 1, N'Básico', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (4, 1, N'Semi Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (5, 1, N'Semi Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (6, 1, N'Semi Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (7, 1, N'Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (8, 1, N'Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (9, 1, N'Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (10, 2, N'Básico', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (11, 2, N'Básico', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (12, 2, N'Básico', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (13, 2, N'Semi Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (14, 2, N'Semi Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (15, 2, N'Semi Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (16, 2, N'Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (17, 2, N'Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (18, 2, N'Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (19, 5, N'Básico', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (20, 5, N'Básico', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (21, 5, N'Básico', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (22, 5, N'Semi Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (23, 5, N'Semi Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (24, 5, N'Semi Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (25, 5, N'Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (26, 5, N'Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (27, 5, N'Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (28, 8, N'Básico', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (29, 8, N'Básico', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (30, 8, N'Básico', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (31, 8, N'Semi Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (32, 8, N'Semi Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (33, 8, N'Semi Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (34, 8, N'Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (35, 8, N'Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (36, 8, N'Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (37, 10, N'Básico', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (38, 10, N'Básico', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (39, 10, N'Básico', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (40, 10, N'Semi Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (41, 10, N'Semi Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (42, 10, N'Semi Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (43, 10, N'Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (44, 10, N'Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (45, 10, N'Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (46, 13, N'Básico', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (47, 13, N'Básico', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (48, 13, N'Básico', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (49, 13, N'Semi Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (50, 13, N'Semi Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (51, 13, N'Semi Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (52, 13, N'Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (53, 13, N'Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (54, 13, N'Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (55, 14, N'Básico', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (56, 14, N'Básico', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (57, 14, N'Básico', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (58, 14, N'Semi Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (59, 14, N'Semi Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (60, 14, N'Semi Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (61, 14, N'Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (62, 14, N'Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (63, 14, N'Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (64, 15, N'Básico', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (65, 15, N'Básico', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (66, 15, N'Básico', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (67, 15, N'Semi Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (68, 15, N'Semi Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (69, 15, N'Semi Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (70, 15, N'Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (71, 15, N'Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (72, 15, N'Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (73, 16, N'Básico', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (74, 16, N'Básico', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (75, 16, N'Básico', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (76, 16, N'Semi Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (77, 16, N'Semi Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (78, 16, N'Semi Full', N'C')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (79, 16, N'Full', N'A')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (80, 16, N'Full', N'B')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria], [Tipo]) VALUES (81, 16, N'Full', N'C')
SET IDENTITY_INSERT [dbo].[CategoriaPolizas] OFF
SET IDENTITY_INSERT [dbo].[cEstado] ON 

INSERT [dbo].[cEstado] ([idEstado], [Validacion], [Estado]) VALUES (1, N'Activo', N'Aceptada')
INSERT [dbo].[cEstado] ([idEstado], [Validacion], [Estado]) VALUES (2, N'Inactivo', N'Rechazada')
INSERT [dbo].[cEstado] ([idEstado], [Validacion], [Estado]) VALUES (3, N'Eliminado', N'En proceso')
SET IDENTITY_INSERT [dbo].[cEstado] OFF
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (1, N'Juan', N'Perez', N'Centro del Hogar', N'124-2332143-4', N'Extranjera', N'829-974-8963', N'ElExtranjero@outloolk.com', N'M', N'18000', CAST(0x0000AB170167B1D2 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (3, N'Fulanito', N'Delian', N'Perensejo Esq. mirador #6', N'103-1231232-1', N'Extranjera', N'809-555-5555', N'EstadosCiviles@outlook.com', N'M', N'18000', CAST(0x0000AB170167BB5F AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (5, N'Luis', N'Peña', N'Barrio 30 de Mayo #7', N'239-3242342-3', N'Extranjera', N'809-632-9898', N'juandedios@gmail.com', N'M', N'878', CAST(0x0000AB170167C33A AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (6, N'filten', N'cruz', N'Barrio Pueblo Nuevo #14', N'823-1282321-1', N'Extranjera', N'809-231-0562', N'juliana74@hotmail.com', N'F', N'35454', CAST(0x0000AB1701691CDE AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (7, N'adrian', N'valdez', N'padre billini #18', N'723-1232321-2', N'Extranjera', N'809-654-8741', N'sadasd@asdasd', N'F', N'53454', CAST(0x0000AB170167DAA3 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (8, N'ambar', N'lopez', N'sanchez #127', N'623-1232321-2', N'Extranjera', N'809-258-7414', N'hubsert@gmail.es', N'F', N'846+54', CAST(0x0000AB170167E1C1 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (9, N'jonas', N'feliz', N'luis del monte #452', N'523-1232321-2', N'Extranjera', N'809-321-7812', N'juliana74@hotmail.com', N'F', N'5454', CAST(0x0000AB170167E6DD AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (12, N'amberic', N'julian', N'villa central #854', N'121-2312767-6', N'dominicana', N'809-324-8514', N'ElExtranjero@outloolk.com', N'M', N'4564', CAST(0x0000AB170167ED23 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (13, N'Pedro', N'feliz', N'ASeneamiento', N'757-4546546-5', N'dominicana', N'(829)-686-8999', N'pioterelPio@gmail.com', N'M', N'445684', CAST(0x0000AB170167F980 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (14, N'penelope', N'diaz', N'nuestra se;ora del rosario #245', N'787-8721231-2', N'dominicana', N'(231)-231-2123', N'pedrofl;orimon78@yahoo.com', N'M', N'864654', CAST(0x0000AB170168081E AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (15, N'Panelope', N'perez', N'villa estela # 34', N'131-2312313-2', N'dominicana', N'(123)-413-2423', N'lucasduda@gmail.com', N'M', N'866874', CAST(0x0000AB040007FCC2 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (16, N'ana', N'julian', N'cambolla #24', N'858-6896448-8', N'dominicana', N'809-324-7156', N'qwe@hotmail.com', N'M', N'87897', CAST(0x0000AB17016B2F01 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (17, N'luisa', N'cruz', N'barrio enrriquillo #78', N'860-6545548-8', N'dominicana', N'809-521-1745', N'qwesad@Gmail.com', N'M', N'4445', CAST(0x0000AB17016A4F47 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (18, N'maniga', N'peter', N'barrio la playa #16', N'869-6488523-3', N'dominicana', N'809-632-7412', N'hubsert@gmail.es', N'M', N'2424', CAST(0x0000AB17016B4D50 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (19, N'anneti', N'josh', N'barrio enrriquillo #67', N'132-1321231-2', N'dominicana', N'(132)-123-1231', N'asdqwdasd', N'M', N'4556', CAST(0x0000AB04001CE724 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (20, N'maria', N'peterson', N'palo alto #26', N'671-2312312-3', N'dominicana', N'(123)-123-1232', N'mendezpichardo@gmail.com', N'M', N'465465', CAST(0x0000AB1701695A32 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (21, N'juan', N'corporan', N'jaquimeyes # 78', N'231-2312312-3', N'dominicana', N'(123)-123-1232', N'cortez@gmail.com', N'M', N'86487', CAST(0x0000AB04001DD6B1 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (22, N'pedro', N'gonzalez', N'palmarito 321', N'934-2342342-3', N'dominicana', N'(234)-234-2342', N'adrian@gmail.com', N'M', N'112312', CAST(0x0000AB17016A14DF AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (23, N'yernira', N'peterson', N'barrio esperanza, duverge #98', N'034-2342342-3', N'dominicana', N'(234)-234-2342', N'willian@gmail.com', N'M', N'545543', CAST(0x0000AB17016A0A10 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (24, N'amina', N'de la cruz', N'barrio balaguer #67', N'423-4321423-4', N'dominicana', N'(234)-234-2342', N'lenys@gmail.com', N'M', N'453435', CAST(0x0000AB170169F457 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (25, N'candida', N'juanes', N'nuestra se;ora del rosario #245', N'234-2344822-3', N'dominicana', N'(345)-345-3453', N'ludwing45@gmail.com', N'M', N'78876', CAST(0x0000AB17016ABB39 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (26, N'patricia', N'lin', N'palmarito 321', N'898-8923442-3', N'dominicana', N'829-654-7125', N'zafiro@gmail.com', N'M', N'47655', CAST(0x0000AB170169E79F AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (27, N'luisa', N'paterson', N'cambolla #24', N'324-2343123-4', N'dominicana', N'849-654-8236', N'jonas@gmail.com', N'F', N'45465', CAST(0x0000AB1701681E92 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (28, N'josefina', N'florian', N'luis del monte #452', N'534-4323423-4', N'dominicana', N'829-547-9135', N'pioterelPio@gmail.com', N'M', N'4564', CAST(0x0000AB17016967F8 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (29, N'angela', N'matos', N'luis del monte #452', N'734-3453453-2', N'dominicana', N'(345)-345-3453', N'eri@gmail.com', N'M', N'18000', CAST(0x0000AB170169D949 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (30, N'Nahum', N'pineda', N'Jaquimelles City', N'402-2809228-0', N'dominicana', N'(849)-785-256', N'nahumelfuerte@hotmailcom', N'M', N'1351', CAST(0x0000AB050102A5BD AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (31, N'dimariot', N'wilber', N'Barrio Pueblo Nuevo #14', N'234-2312312-2', N'dominicana', N'(123)-112-3132', N'pocarls@gmail.com', N'M', N'321321', CAST(0x0000AB05017DDB7B AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (32, N'Onesimo', N'Estrella', N'Sanchez #13', N'234-2343243-2', N'extranjera', N'(234)-234-2342', N'Caewqe@Hotmail.com', N'M', N'21321', CAST(0x0000AB05017E1610 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (33, N'PAran', N'Love', N'barrio la playa #16', N'234-1246767-8', N'extranjera', N'(234)-234-8989', N'juanadedios@outlook.com', N'M', N'3131', CAST(0x0000AB170169C5F9 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (34, N'cruz', N'velez', N'nuestra se;ora del rosario #245', N'213-1231676-6', N'dominicana', N'(123)-123-32', N'juanp@gmail.com', N'M', N'1321', CAST(0x0000AB1701699DB5 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (35, N'Joaquin', N'Navarro', N'Calle #3 Esq. Mella', N'768-0843432-4', N'Extranjera', N'(809)-856-5454', N'ElNavarrete@hotmail.com', N'M', N'12321', CAST(0x0000AB170168ADE0 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (36, N'Eliezer', N'Montero', N'Calle El Derricadero #10', N'231-4232342-3', N'dominicana', N'(234)-234-2342', N'EliezerElMan@hotmail.com', N'M', N'21231', CAST(0x0000AB06011601F9 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (37, N'Gregory', N'joset', N'padre billini #18', N'234-2342342-3', N'extranjera', N'(234)-234-2234', N'asasd%^Y45ysad', N'M', N'231321', CAST(0x0000AB06012C4534 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (38, N'ochoa', N'lum', N'padre billini #18', N'112-1212121-2', N'dominicana', N'(121)-212-121', N'pocarls@gmail.com', N'M', N'31321', CAST(0x0000AB060169FE05 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (39, N'robert', N'cadet', N'villa central #854', N'123-1231231-2', N'dominicana', N'(123)-123-123', N'juanadedios@outlook.com', N'F', N'5454', CAST(0x0000AB06016A264D AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (40, N'roger', N'rogelio', N'luis del monte #452', N'123-1253123-3', N'dominicana', N'(333)-333-3333', N'Caewqe@Hotmail.com', N'F', N'351321', CAST(0x0000AB1701683FE3 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (41, N'mars', N'nicolas', N'barrio san jose #44', N'342-4234234-6', N'dominicana', N'(234)-234-234', N'nahumelfuerte@hotmailcom', N'M', N'564654', CAST(0x0000AB1701684CB4 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (42, N'lin', N'anderson ', N'barrio alfa #23', N'023-1242342-3', N'dominicana', N'(234)-234-2342', N'RDMatos@hotmai.com', N'M', N'65464', CAST(0x0000AB1701690F73 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (43, N'jan', N'de los santos', N'barrio olivero #25', N'234-2342342-2', N'dominicana', N'(234)-234-2343', N'ElNavarrete@hotmail.com', N'M', N'4546', CAST(0x0000AB0601719315 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (44, N'benoit', N'Perez Berroa', N'Ecuartillos el Man', N'602-1231231-2', N'dominicana', N'(343)-434-2234', N'EliezerElMan@hotmail.com', N'M', N'864684', CAST(0x0000AB17016A7130 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (45, N'magaly', N'Martinez Cena', N'Calle Los 20 Brazos, Esq. El cuartel #10', N'123-5464567-4', N'dominicana', N'(436)-534-5234', N'PanyDominicanaMartinez@outlook.com', N'F', N'4456456', CAST(0x0000AB13011245EF AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (46, N'victor', N'Matos', N'Calle Octava y la Novena #9', N'846-5224122-4', N'dominicana', N'(828)-469-8926', N'RDMatos@hotmai.com', N'F', N'21351351', CAST(0x0000AB18014DAB0A AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (47, N'all', N'feliz', N'barrio los guandules #67', N'234-3242342-3', N'dominicana', N'(234)-234-2342', N'PanyDominicanaMartinez@outlook.com', N'M', N'54545641', CAST(0x0000AB1B00D96F1A AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (48, N'lebron', N'pineda', N'barrio alta mira, enrriquillo #66', N'047-2369373-2', N'dominicana', N'(234)-234-3243', N'asdasdaasd', N'M', N'545341531', CAST(0x0000AB1B00DA8C69 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (49, N'nelson', N'matias', N'barrio los guandules #55', N'747-2369373-2', N'dominicana', N'(234)-234-3243', N'asdasdaasd', N'M', N'2132123', CAST(0x0000AB1B00DA96AF AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (50, N'alfonso', N'matos', N'villa central #854', N'747-2369373-9', N'dominicana', N'(234)-234-3243', N'asdasdaasd', N'M', N'2362632', CAST(0x0000AB1B00DA9C56 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (51, N'robinson', N'encarnacion', N'Calle El Derricadero #10', N'234-2345677-8', N'dominicana', N'(243)-534-6456', N'efsdfsdf', N'M', N'5656', CAST(0x0000AB1B00DB0199 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (53, N'david', N'castro', N'villa central #854', N'000-0000000-0', N'dominicana', N'(054)-545-4545', N'qweqwe', N'M', N'36522', CAST(0x0000AB1B00DB41E9 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (55, N'alex', N'gomez', N'Calle #3 Esq. Mella', N'432-5345435-4', N'dominicana', N'(435)-345-3453', N'sdvsdf', N'M', N'32323', CAST(0x0000AB1B00DCB3E8 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (56, N'tommy', N'corporan', N'nuestra se;ora del rosario #245', N'345-3453453-4', N'dominicana', N'(435)-345-3453', N'sfgsg', N'M', N'32323', CAST(0x0000AB1B00DD7BE4 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (57, N'aasdasd', N'phan', N'luis del monte #452', N'829-2862852-3', N'dominicana', N'(321)-432-4234', N'asdasdasd', N'M', N'236232', CAST(0x0000AB1B00DF348E AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (59, N'Eliezer', N'Gonzales', N'Sanchez #127', N'402-2579183-1', N'dominicana', N'(809)-526-3014', N'Eliezer24@gmail.com', N'M', N'21231', CAST(0x0000AB1B01669C55 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (60, N'Carlos', N'Jimenez', N'galvan', N'778-8445555-5', N'extranjero', N'(125)-565-8854', N'carlosuuurue', N'M', N'', CAST(0x0000AB1C00B8B666 AS DateTime))
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[ctEmpresasNegocios] ON 

INSERT [dbo].[ctEmpresasNegocios] ([id], [id_Cliente], [id_Empleado], [Total], [Fecha], [idEstado]) VALUES (26, 59, 893659, CAST(160000.00 AS Decimal(18, 2)), CAST(0x76400B00 AS Date), 1)
INSERT [dbo].[ctEmpresasNegocios] ([id], [id_Cliente], [id_Empleado], [Total], [Fecha], [idEstado]) VALUES (27, 59, 893659, CAST(400000.00 AS Decimal(18, 2)), CAST(0x76400B00 AS Date), 1)
INSERT [dbo].[ctEmpresasNegocios] ([id], [id_Cliente], [id_Empleado], [Total], [Fecha], [idEstado]) VALUES (28, 1, 893659, CAST(800000.00 AS Decimal(18, 2)), CAST(0x77400B00 AS Date), 1)
INSERT [dbo].[ctEmpresasNegocios] ([id], [id_Cliente], [id_Empleado], [Total], [Fecha], [idEstado]) VALUES (29, 32, 893659, CAST(400000.00 AS Decimal(18, 2)), CAST(0x9A400B00 AS Date), 2)
INSERT [dbo].[ctEmpresasNegocios] ([id], [id_Cliente], [id_Empleado], [Total], [Fecha], [idEstado]) VALUES (30, 32, 893659, CAST(800000.00 AS Decimal(18, 2)), CAST(0x9A400B00 AS Date), 3)
SET IDENTITY_INSERT [dbo].[ctEmpresasNegocios] OFF
SET IDENTITY_INSERT [dbo].[ctMueblesInmuebles] ON 

INSERT [dbo].[ctMueblesInmuebles] ([id], [id_Cliente], [id_Empleado], [Total], [Fecha], [idEstado]) VALUES (10, 45, 1, CAST(900000.00 AS Decimal(18, 2)), CAST(0x0000AB17015D2155 AS DateTime), 2)
INSERT [dbo].[ctMueblesInmuebles] ([id], [id_Cliente], [id_Empleado], [Total], [Fecha], [idEstado]) VALUES (11, 59, 893659, CAST(50000.00 AS Decimal(18, 2)), CAST(0x0000AB1C0029616A AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[ctMueblesInmuebles] OFF
SET IDENTITY_INSERT [dbo].[ctVehiculo] ON 

INSERT [dbo].[ctVehiculo] ([id], [id_Cliente], [id_Empleado], [Total], [Fecha], [idEstado]) VALUES (9, 45, 1, CAST(280000.00 AS Decimal(18, 2)), CAST(0x0000AB17016E17FB AS DateTime), 1)
INSERT [dbo].[ctVehiculo] ([id], [id_Cliente], [id_Empleado], [Total], [Fecha], [idEstado]) VALUES (10, 45, 1, CAST(600000.00 AS Decimal(18, 2)), CAST(0x0000AB180097E24E AS DateTime), 1)
INSERT [dbo].[ctVehiculo] ([id], [id_Cliente], [id_Empleado], [Total], [Fecha], [idEstado]) VALUES (11, 37, 893659, CAST(400000.00 AS Decimal(18, 2)), CAST(0x0000AB1B018B5BCE AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[ctVehiculo] OFF
SET IDENTITY_INSERT [dbo].[ctVida] ON 

INSERT [dbo].[ctVida] ([id], [id_Cliente], [id_Empleado], [Total], [FechaHora], [idEstado]) VALUES (1, 1, 1, CAST(1.00 AS Decimal(18, 2)), CAST(0x0000AAE200000000 AS DateTime), 1)
INSERT [dbo].[ctVida] ([id], [id_Cliente], [id_Empleado], [Total], [FechaHora], [idEstado]) VALUES (2, 1, 1, CAST(1.00 AS Decimal(18, 2)), CAST(0x0000AAE200000000 AS DateTime), 1)
INSERT [dbo].[ctVida] ([id], [id_Cliente], [id_Empleado], [Total], [FechaHora], [idEstado]) VALUES (3, 32, 1, CAST(100000.00 AS Decimal(18, 2)), CAST(0x0000AB060110AEC7 AS DateTime), 1)
INSERT [dbo].[ctVida] ([id], [id_Cliente], [id_Empleado], [Total], [FechaHora], [idEstado]) VALUES (4, 31, 1, CAST(100000.00 AS Decimal(18, 2)), CAST(0x0000AB0601159712 AS DateTime), 1)
INSERT [dbo].[ctVida] ([id], [id_Cliente], [id_Empleado], [Total], [FechaHora], [idEstado]) VALUES (5, 36, 1, CAST(100000.00 AS Decimal(18, 2)), CAST(0x0000AB0601161EFF AS DateTime), 1)
INSERT [dbo].[ctVida] ([id], [id_Cliente], [id_Empleado], [Total], [FechaHora], [idEstado]) VALUES (6, 37, 1, CAST(100000.00 AS Decimal(18, 2)), CAST(0x0000AB06012C50ED AS DateTime), 1)
INSERT [dbo].[ctVida] ([id], [id_Cliente], [id_Empleado], [Total], [FechaHora], [idEstado]) VALUES (7, 36, 1, CAST(100000.00 AS Decimal(18, 2)), CAST(0x0000AB0601661B3D AS DateTime), 1)
INSERT [dbo].[ctVida] ([id], [id_Cliente], [id_Empleado], [Total], [FechaHora], [idEstado]) VALUES (8, 37, 1, CAST(100000.00 AS Decimal(18, 2)), CAST(0x0000AB060167247B AS DateTime), 1)
INSERT [dbo].[ctVida] ([id], [id_Cliente], [id_Empleado], [Total], [FechaHora], [idEstado]) VALUES (9, 44, 1, CAST(100000.00 AS Decimal(18, 2)), CAST(0x0000AB0A0157D1E3 AS DateTime), 1)
INSERT [dbo].[ctVida] ([id], [id_Cliente], [id_Empleado], [Total], [FechaHora], [idEstado]) VALUES (10, 45, 1, CAST(66000.00 AS Decimal(18, 2)), CAST(0x0000AB15000EC94E AS DateTime), 1)
INSERT [dbo].[ctVida] ([id], [id_Cliente], [id_Empleado], [Total], [FechaHora], [idEstado]) VALUES (11, 15, 1, CAST(100000.00 AS Decimal(18, 2)), CAST(0x0000AB18013F2455 AS DateTime), 1)
INSERT [dbo].[ctVida] ([id], [id_Cliente], [id_Empleado], [Total], [FechaHora], [idEstado]) VALUES (12, 46, 1, CAST(100000.00 AS Decimal(18, 2)), CAST(0x0000AB18014E0EE7 AS DateTime), 1)
INSERT [dbo].[ctVida] ([id], [id_Cliente], [id_Empleado], [Total], [FechaHora], [idEstado]) VALUES (13, 46, 1, CAST(100000.00 AS Decimal(18, 2)), CAST(0x0000AB18014E7EAB AS DateTime), 1)
INSERT [dbo].[ctVida] ([id], [id_Cliente], [id_Empleado], [Total], [FechaHora], [idEstado]) VALUES (14, 32, 893659, CAST(100000.00 AS Decimal(18, 2)), CAST(0x0000AB3F0149ABCE AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[ctVida] OFF
SET IDENTITY_INSERT [dbo].[detalleEdificaciones] ON 

INSERT [dbo].[detalleEdificaciones] ([id], [idFactura], [id_ctMueblesInmuebles], [Tipo de Vivienda], [Situacion], [Propietario], [Vivienda habitual], [Vivienda Alquilada], [Codigo Postal], [Deshabitada por mas de tres meses al ano], [Ano de Construccion], [M2 de la Vivienda], [M2 de edificaciones anexas], [Capital de otras instalaciones], [Estado], [FechaHora], [Nota], [Tipo]) VALUES (1, 10, 11, N'Apartamento', N'Urbanizacion', N'Carlos Sanchez', N'Sí', N'No', N'18000', N'No', 2007, CAST(588.00 AS Decimal(18, 2)), CAST(350.00 AS Decimal(18, 2)), N'N/A', 1, CAST(0x0000AB1C0029616A AS DateTime), N'', N'Semi Full - C')
SET IDENTITY_INSERT [dbo].[detalleEdificaciones] OFF
SET IDENTITY_INSERT [dbo].[detalleSeguroContenido] ON 

INSERT [dbo].[detalleSeguroContenido] ([id], [id_ctMueblesInmuebles], [idFactura], [Tipo de Vivienda], [Situacion], [Propietario], [Vivienda habitual], [Vivienda Alquilada], [Codigo Postal], [Deshabitada por mas de tres meses al ano], [Ano de Construccion], [M2 de la Vivienda], [DescripcionMuebles], [ValorEstimadoMuebles], [Estado], [FechaHora], [Nota], [Tipo]) VALUES (1, 10, 2, N'Datos', N'Datos', N'Datos', N'Sí', N'Sí', N'5445454', N'Sí', 9685, CAST(25566.00 AS Decimal(18, 2)), N'Datos', 2555, 2, CAST(0x0000AB17015D2155 AS DateTime), N'', N'Básico - C')
SET IDENTITY_INSERT [dbo].[detalleSeguroContenido] OFF
SET IDENTITY_INSERT [dbo].[detalleSeguroObligatorio] ON 

INSERT [dbo].[detalleSeguroObligatorio] ([id], [id_ctVehiculo], [Marca de Vehiculo], [Modelo], [Matricula], [Ano], [Cilindros], [Carroceria], [Categoria], [Uso], [Nota], [Estado], [FechaHora], [Tipo], [idFactura]) VALUES (1, 10, N'Dodge', N'Real', N'EDA22343', 2015, 2, N'Carro', N'2', N'Privado', N'', 1, CAST(0x0000AB180097E24E AS DateTime), N'Semi Full - C', 4)
SET IDENTITY_INSERT [dbo].[detalleSeguroObligatorio] OFF
SET IDENTITY_INSERT [dbo].[detalleSeguroSalud] ON 

INSERT [dbo].[detalleSeguroSalud] ([id], [id_ctVida], [InstitucionDondeLabora], [Antecedentes personales], [Estado], [Fecha], [Nota], [Tipo]) VALUES (2, 1, N'sdfsdf', N'sdfgfdg', 1, CAST(0x0000AAE200000000 AS DateTime), NULL, N'qwqew')
INSERT [dbo].[detalleSeguroSalud] ([id], [id_ctVida], [InstitucionDondeLabora], [Antecedentes personales], [Estado], [Fecha], [Nota], [Tipo]) VALUES (3, 2, N'qwedasdasd', N'sdfsdf', 1, CAST(0x0000AAE200000000 AS DateTime), NULL, N'eqwr')
INSERT [dbo].[detalleSeguroSalud] ([id], [id_ctVida], [InstitucionDondeLabora], [Antecedentes personales], [Estado], [Fecha], [Nota], [Tipo]) VALUES (4, 3, N'd', N'dd', 1, CAST(0x0000AB0600000000 AS DateTime), NULL, N'Full')
INSERT [dbo].[detalleSeguroSalud] ([id], [id_ctVida], [InstitucionDondeLabora], [Antecedentes personales], [Estado], [Fecha], [Nota], [Tipo]) VALUES (5, 4, N'as', N'as', 1, CAST(0x0000AB0600000000 AS DateTime), NULL, N'Básico')
INSERT [dbo].[detalleSeguroSalud] ([id], [id_ctVida], [InstitucionDondeLabora], [Antecedentes personales], [Estado], [Fecha], [Nota], [Tipo]) VALUES (6, 5, N'as', N'as', 1, CAST(0x0000AB0600000000 AS DateTime), NULL, N'Full')
INSERT [dbo].[detalleSeguroSalud] ([id], [id_ctVida], [InstitucionDondeLabora], [Antecedentes personales], [Estado], [Fecha], [Nota], [Tipo]) VALUES (7, 6, N'dsfgdsgf', N'fdg', 1, CAST(0x0000AB0600000000 AS DateTime), NULL, N'Full')
INSERT [dbo].[detalleSeguroSalud] ([id], [id_ctVida], [InstitucionDondeLabora], [Antecedentes personales], [Estado], [Fecha], [Nota], [Tipo]) VALUES (8, 7, N'as', N'asas', 1, CAST(0x0000AB0600000000 AS DateTime), NULL, N'Full')
INSERT [dbo].[detalleSeguroSalud] ([id], [id_ctVida], [InstitucionDondeLabora], [Antecedentes personales], [Estado], [Fecha], [Nota], [Tipo]) VALUES (9, 8, N'd', N'd', 1, CAST(0x0000AB0600000000 AS DateTime), NULL, N'Full')
INSERT [dbo].[detalleSeguroSalud] ([id], [id_ctVida], [InstitucionDondeLabora], [Antecedentes personales], [Estado], [Fecha], [Nota], [Tipo]) VALUES (10, 9, N'RiñonesRiñonesRiñonesRiñonesRiñonesRiñonesvRiñones', N'PedreriaELManx', 1, CAST(0x0000AB0A00000000 AS DateTime), NULL, N'Básico - C')
INSERT [dbo].[detalleSeguroSalud] ([id], [id_ctVida], [InstitucionDondeLabora], [Antecedentes personales], [Estado], [Fecha], [Nota], [Tipo]) VALUES (11, 10, N'asdasd', N'asdasd', 1, CAST(0x0000AB1500000000 AS DateTime), NULL, N'Básico - C')
INSERT [dbo].[detalleSeguroSalud] ([id], [id_ctVida], [InstitucionDondeLabora], [Antecedentes personales], [Estado], [Fecha], [Nota], [Tipo]) VALUES (12, 11, N'Cafe Santo Domingo', N'Cancer, Piedras en los Riñones', 1, CAST(0x0000AB1800000000 AS DateTime), NULL, N'Básico - C')
INSERT [dbo].[detalleSeguroSalud] ([id], [id_ctVida], [InstitucionDondeLabora], [Antecedentes personales], [Estado], [Fecha], [Nota], [Tipo]) VALUES (13, 12, N'Escuela Codigo Novenio', N'Asmatica, Rinitis alerjica, Operacion', 1, CAST(0x0000AB1800000000 AS DateTime), NULL, N'Básico - C')
INSERT [dbo].[detalleSeguroSalud] ([id], [id_ctVida], [InstitucionDondeLabora], [Antecedentes personales], [Estado], [Fecha], [Nota], [Tipo]) VALUES (14, 13, N'Escuela Codigo Novenio', N'Asmatica, Rinitis alerjica, Operacion', 1, CAST(0x0000AB1800000000 AS DateTime), NULL, N'Básico - C')
INSERT [dbo].[detalleSeguroSalud] ([id], [id_ctVida], [InstitucionDondeLabora], [Antecedentes personales], [Estado], [Fecha], [Nota], [Tipo]) VALUES (15, 14, N'wrsgfsf', N'sdfsdf', 1, CAST(0x0000AB3F00000000 AS DateTime), NULL, N'Básico - C')
SET IDENTITY_INSERT [dbo].[detalleSeguroSalud] OFF
SET IDENTITY_INSERT [dbo].[detalleSeguroVoluntario] ON 

INSERT [dbo].[detalleSeguroVoluntario] ([Id], [id_ctVehiculo], [Marca de Vehiculo], [Modelo], [Matricula], [Ano], [Cilindros], [Carroceria], [Categoria], [Uso], [Nota], [Estado], [FechaHora], [Tipo], [idFactura]) VALUES (1, 9, N'Honda', N'Accord', N'ER03D963', 2016, 6, N'Carro', N'2', N'Privado', N'Muy Bien', 1, CAST(0x0000AB17016E17FB AS DateTime), N'Básico - C', 3)
INSERT [dbo].[detalleSeguroVoluntario] ([Id], [id_ctVehiculo], [Marca de Vehiculo], [Modelo], [Matricula], [Ano], [Cilindros], [Carroceria], [Categoria], [Uso], [Nota], [Estado], [FechaHora], [Tipo], [idFactura]) VALUES (2, 11, N'Mazda', N'BT50', N'AW846CF', 2019, 4, N'Carro', N'2', N'Privado', N'', 1, CAST(0x0000AB1B018B5BCE AS DateTime), N'Básico - A', 9)
SET IDENTITY_INSERT [dbo].[detalleSeguroVoluntario] OFF
SET IDENTITY_INSERT [dbo].[Devoluciones] ON 

INSERT [dbo].[Devoluciones] ([id], [id_Cliente], [id_Solicitud], [id_Poliza], [A Devolver], [Motivo], [FechaHora], [idPolizaDeSeguro]) VALUES (4, 1, 0, 2, CAST(343214.00 AS Decimal(18, 2)), N'qwdqwsdas', CAST(0x0000AB1B01493697 AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Devoluciones] OFF
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (1, N'Javier', N'Perez Cuevas', N'Calle Benjamin Matos #4', N'402-1509373-9', N'(849)-637-1170', N'Robert85-@hotmail.com', 8, N'M', CAST(0x9A400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (3, N'alfonso', N'perez', N'ASDASD', N'223-1231213-1', N'829-864-8654', N'QADSASD', 1, N'F', CAST(0x4B400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (4, N'Francisco', N'Peña Suaso', N'Los Rios de Venezuela', N'323-1231213-1', N'(552)-534-2342', N'MeGustaElVerde@Mucho.com', 6, N'M', CAST(0x76400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (5, N'enyel', N'gonzale', N'780', N'423-1231231-2', N'809-456-8544', N'PerezPerez', 1, N'M', CAST(0x53400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (8, N'Nahum', N'Matoss', N'Jaquimelles', N'524-3236467-5', N'(324)-234-6343', N'Nahummatos@Gmail.com', 7, N'M', CAST(0x76400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (9, N'Gaby', N'Perez', N'Pley Grande #14', N'886-8656565-6', N'(829)-859-8564', N'ewfweasd@asiEs.ORg', 18, N'F', CAST(0x9A400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (10, N'Rodrigo', N'figuereo', N'El Jaimito 23 esq. duarte #14', N'686-8656565-6', N'809-565-5642', N'ewfweasd@asiEs.ORg', 2, N'M', CAST(0x4C400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (13, N'Enrrique', N'matos', N'barahona', N'223-9636565-6', N'829-548-5486', N'errinquegmail.com', 1, N'M', CAST(0x53400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (14, N'michael', N'cabrera', N'jaquimeyes', N'223-8656565-6', N'849-852-1300', N'asd', 1, N'M', CAST(0x53400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (15, N'nahum', N'matos', N'por hay', N'402-2809228-8', N'849-7858-0426', N'nahum2694matos@gmail.com', 1, N'M', CAST(0x6F400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (16, N'uriel', N'perez', N'palo alto', N'345-3454345-4', N'(345)-345-3453', N'hgjghj', 1, N'M', CAST(0x75400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (17, N'Matos', N'beltre', N'peñon', N' 532 -0233453-4', N'(435)-345-3435', N'werewr', 2, N'M', CAST(0x75400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (18, N'maicol', N'batista', N'canoa', N'332-1423443-3', N'(235)-131-2333', N'werewr', 2, N'M', CAST(0x75400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (893659, N'Gregory', N'Matos', N'duverge', N'212-5452123-8', N'(809)-525-6896', N'asdasdasdasd', 1, N'F', CAST(0x72400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (1787300, N'Janer', N'Perez', N'barahona', N'443-2853495-8', N'(495)-098-6098', N'RDWRTÿgwoepfkjwe@sdks;ldg', 2, N'M', CAST(0x76400B00 AS Date))
SET IDENTITY_INSERT [dbo].[Empleado] OFF
SET IDENTITY_INSERT [dbo].[emPoliza] ON 

INSERT [dbo].[emPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (1, 59, 8, N' Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales.ENTIDAD ASEGURADORA …………………………………….NOTA INFORMATIVA AL TOMADOR DEL SEGURO(ASEGURADO)La información que se contiene en este documento se ofrece en cumplimiento de lo dispuesto en la Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y de los artículos 104 a 107 de su Reglamento de desarrollo, aprobado por Real Decreto 2486/1998.LEGISLACIÓN APLICABLE AL CONTRATO DE SEGUROLey 50/1980, de 8 de octubre, de Contrato de Seguro; Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y su Reglamento de desarrollo(Real Decreto nº 2486/1998, de 20 de noviembre). Condiciones Generales, Especiales y Particulares del Contrato.ENTIDAD ASEGURADORADenominación Social: ………………………………. es el nombre comercial de ……………………………………………………………………………………………………………….. con N.I.F.: ………………………………., con domicilio en ………………………………..Corresponde a la Dirección General de Seguros, dependiente del Ministerio de Economía y Hacienda, el control y supervisión de la actividad de dicha Entidad Aseguradora.INSTANCIAS DE RECLAMACIÓN ………………………………. 1) Servicio de Atención al Cliente cuyo reglamento se encuentra a disposición de los interesados en las oficinas de ………………………………..2) Con carácter general los conflictos se resolverán por los jueces y tribunales competentes.3) Asimismo puede acudirse, para resolver las controversias que puedan plantearse, al procedimiento administrativo de reclamación ante la Dirección General de Seguros para el cual está legitimado el tomador, asegurado, beneficiario, tercero perjudicado o derechohabiente de cualquiera de ellos.CONDICIONES GENERALES DEL SEGURO DE VIDA INDIVIDUALEl presente contrato de seguro de vida se rige por lo dispuesto en la Ley 50/1980, de 8 de octubre, de contrato de Seguro, T.R de Ordenación y Supervisión de los Seguros Privados, R.D.Leg 6/2004, R.D. 2486/1998 de 20 de Noviembre y por lo convenido en las Condiciones Generales, Especiales y Particulares de este contrato, sin que tengan validez las cláusulas limitativas de los derechos de los asegurados que no sean específicamente aceptadas por el tomador de la póliza.No requerirán dicha aceptación las meras transcripciones o referencias a preceptos legales.El control de la actividad que desarrolla la Entidad Aseguradora, le corresponde al Ministerio de Economía y Hacienda del Estado español, que lo ejerce a través de la Dirección General de Seguros y Fondos de Pensiones.ARTÍCULO PRELIMINAR. DEFINICIONES.Para los efectos de este contrato se entenderá por:', 1, CAST(0x0000AB1B018A5E59 AS DateTime), CAST(0x2D410B00 AS Date), NULL)
INSERT [dbo].[emPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (2, 59, 8, N' Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales.ENTIDAD ASEGURADORA …………………………………….NOTA INFORMATIVA AL TOMADOR DEL SEGURO(ASEGURADO)La información que se contiene en este documento se ofrece en cumplimiento de lo dispuesto en la Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y de los artículos 104 a 107 de su Reglamento de desarrollo, aprobado por Real Decreto 2486/1998.LEGISLACIÓN APLICABLE AL CONTRATO DE SEGUROLey 50/1980, de 8 de octubre, de Contrato de Seguro; Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y su Reglamento de desarrollo(Real Decreto nº 2486/1998, de 20 de noviembre). Condiciones Generales, Especiales y Particulares del Contrato.ENTIDAD ASEGURADORADenominación Social: ………………………………. es el nombre comercial de ……………………………………………………………………………………………………………….. con N.I.F.: ………………………………., con domicilio en ………………………………..Corresponde a la Dirección General de Seguros, dependiente del Ministerio de Economía y Hacienda, el control y supervisión de la actividad de dicha Entidad Aseguradora.INSTANCIAS DE RECLAMACIÓN ………………………………. 1) Servicio de Atención al Cliente cuyo reglamento se encuentra a disposición de los interesados en las oficinas de ………………………………..2) Con carácter general los conflictos se resolverán por los jueces y tribunales competentes.3) Asimismo puede acudirse, para resolver las controversias que puedan plantearse, al procedimiento administrativo de reclamación ante la Dirección General de Seguros para el cual está legitimado el tomador, asegurado, beneficiario, tercero perjudicado o derechohabiente de cualquiera de ellos.CONDICIONES GENERALES DEL SEGURO DE VIDA INDIVIDUALEl presente contrato de seguro de vida se rige por lo dispuesto en la Ley 50/1980, de 8 de octubre, de contrato de Seguro, T.R de Ordenación y Supervisión de los Seguros Privados, R.D.Leg 6/2004, R.D. 2486/1998 de 20 de Noviembre y por lo convenido en las Condiciones Generales, Especiales y Particulares de este contrato, sin que tengan validez las cláusulas limitativas de los derechos de los asegurados que no sean específicamente aceptadas por el tomador de la póliza.No requerirán dicha aceptación las meras transcripciones o referencias a preceptos legales.El control de la actividad que desarrolla la Entidad Aseguradora, le corresponde al Ministerio de Economía y Hacienda del Estado español, que lo ejerce a través de la Dirección General de Seguros y Fondos de Pensiones.ARTÍCULO PRELIMINAR. DEFINICIONES.Para los efectos de este contrato se entenderá por:', 1, CAST(0x0000AB1C001D41CA AS DateTime), CAST(0x2E410B00 AS Date), NULL)
INSERT [dbo].[emPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (3, 1, 8, N' Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales.ENTIDAD ASEGURADORA …………………………………….NOTA INFORMATIVA AL TOMADOR DEL SEGURO(ASEGURADO)La información que se contiene en este documento se ofrece en cumplimiento de lo dispuesto en la Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y de los artículos 104 a 107 de su Reglamento de desarrollo, aprobado por Real Decreto 2486/1998.LEGISLACIÓN APLICABLE AL CONTRATO DE SEGUROLey 50/1980, de 8 de octubre, de Contrato de Seguro; Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y su Reglamento de desarrollo(Real Decreto nº 2486/1998, de 20 de noviembre). Condiciones Generales, Especiales y Particulares del Contrato.ENTIDAD ASEGURADORADenominación Social: ………………………………. es el nombre comercial de ……………………………………………………………………………………………………………….. con N.I.F.: ………………………………., con domicilio en ………………………………..Corresponde a la Dirección General de Seguros, dependiente del Ministerio de Economía y Hacienda, el control y supervisión de la actividad de dicha Entidad Aseguradora.INSTANCIAS DE RECLAMACIÓN ………………………………. 1) Servicio de Atención al Cliente cuyo reglamento se encuentra a disposición de los interesados en las oficinas de ………………………………..2) Con carácter general los conflictos se resolverán por los jueces y tribunales competentes.3) Asimismo puede acudirse, para resolver las controversias que puedan plantearse, al procedimiento administrativo de reclamación ante la Dirección General de Seguros para el cual está legitimado el tomador, asegurado, beneficiario, tercero perjudicado o derechohabiente de cualquiera de ellos.CONDICIONES GENERALES DEL SEGURO DE VIDA INDIVIDUALEl presente contrato de seguro de vida se rige por lo dispuesto en la Ley 50/1980, de 8 de octubre, de contrato de Seguro, T.R de Ordenación y Supervisión de los Seguros Privados, R.D.Leg 6/2004, R.D. 2486/1998 de 20 de Noviembre y por lo convenido en las Condiciones Generales, Especiales y Particulares de este contrato, sin que tengan validez las cláusulas limitativas de los derechos de los asegurados que no sean específicamente aceptadas por el tomador de la póliza.No requerirán dicha aceptación las meras transcripciones o referencias a preceptos legales.El control de la actividad que desarrolla la Entidad Aseguradora, le corresponde al Ministerio de Economía y Hacienda del Estado español, que lo ejerce a través de la Dirección General de Seguros y Fondos de Pensiones.ARTÍCULO PRELIMINAR. DEFINICIONES.Para los efectos de este contrato se entenderá por:', 1, CAST(0x0000AB1C00BCE91D AS DateTime), CAST(0x2E410B00 AS Date), NULL)
SET IDENTITY_INSERT [dbo].[emPoliza] OFF
SET IDENTITY_INSERT [dbo].[Facturas] ON 

INSERT [dbo].[Facturas] ([id], [id_Cliente], [id_Empleado], [id_Solicitud], [id_Seguro], [Precio], [T_Pago], [Pago Parcial], [SubTotal], [Descuento], [FechaHora], [Nota]) VALUES (1, 45, 1, 2, 8, CAST(800000.00 AS Decimal(18, 2)), N'Al contado', CAST(0.00 AS Decimal(18, 2)), CAST(800000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0x0000AB170150F1B5 AS DateTime), NULL)
INSERT [dbo].[Facturas] ([id], [id_Cliente], [id_Empleado], [id_Solicitud], [id_Seguro], [Precio], [T_Pago], [Pago Parcial], [SubTotal], [Descuento], [FechaHora], [Nota]) VALUES (2, 45, 1, 2, 13, CAST(900000.00 AS Decimal(18, 2)), N'Al contado', CAST(0.00 AS Decimal(18, 2)), CAST(900000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0x0000AB17015D2155 AS DateTime), NULL)
INSERT [dbo].[Facturas] ([id], [id_Cliente], [id_Empleado], [id_Solicitud], [id_Seguro], [Precio], [T_Pago], [Pago Parcial], [SubTotal], [Descuento], [FechaHora], [Nota]) VALUES (3, 45, 1, 3, 14, CAST(280000.00 AS Decimal(18, 2)), N'Al contado', CAST(0.00 AS Decimal(18, 2)), CAST(280000.00 AS Decimal(18, 2)), CAST(120000.00 AS Decimal(18, 2)), CAST(0x0000AB17016E17FB AS DateTime), NULL)
INSERT [dbo].[Facturas] ([id], [id_Cliente], [id_Empleado], [id_Solicitud], [id_Seguro], [Precio], [T_Pago], [Pago Parcial], [SubTotal], [Descuento], [FechaHora], [Nota]) VALUES (4, 45, 1, 4, 15, CAST(600000.00 AS Decimal(18, 2)), N'Al contado', CAST(0.00 AS Decimal(18, 2)), CAST(600000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0x0000AB180097E24E AS DateTime), NULL)
INSERT [dbo].[Facturas] ([id], [id_Cliente], [id_Empleado], [id_Solicitud], [id_Seguro], [Precio], [T_Pago], [Pago Parcial], [SubTotal], [Descuento], [FechaHora], [Nota]) VALUES (5, 15, 1, 12, 2, CAST(100000.00 AS Decimal(18, 2)), N'Al contado', CAST(0.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0x0000AB18013F2455 AS DateTime), NULL)
INSERT [dbo].[Facturas] ([id], [id_Cliente], [id_Empleado], [id_Solicitud], [id_Seguro], [Precio], [T_Pago], [Pago Parcial], [SubTotal], [Descuento], [FechaHora], [Nota]) VALUES (6, 46, 1, 13, 2, CAST(100000.00 AS Decimal(18, 2)), N'Al contado', CAST(0.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0x0000AB18014E7EAB AS DateTime), NULL)
INSERT [dbo].[Facturas] ([id], [id_Cliente], [id_Empleado], [id_Solicitud], [id_Seguro], [Precio], [T_Pago], [Pago Parcial], [SubTotal], [Descuento], [FechaHora], [Nota]) VALUES (7, 59, 893659, 7, 8, CAST(160000.00 AS Decimal(18, 2)), N'Al contado', CAST(0.00 AS Decimal(18, 2)), CAST(160000.00 AS Decimal(18, 2)), CAST(640000.00 AS Decimal(18, 2)), CAST(0x0000AB1B01687AC4 AS DateTime), NULL)
INSERT [dbo].[Facturas] ([id], [id_Cliente], [id_Empleado], [id_Solicitud], [id_Seguro], [Precio], [T_Pago], [Pago Parcial], [SubTotal], [Descuento], [FechaHora], [Nota]) VALUES (8, 59, 893659, 8, 8, CAST(400000.00 AS Decimal(18, 2)), N'Al contado', CAST(0.00 AS Decimal(18, 2)), CAST(400000.00 AS Decimal(18, 2)), CAST(400000.00 AS Decimal(18, 2)), CAST(0x0000AB1B0181DC7D AS DateTime), NULL)
INSERT [dbo].[Facturas] ([id], [id_Cliente], [id_Empleado], [id_Solicitud], [id_Seguro], [Precio], [T_Pago], [Pago Parcial], [SubTotal], [Descuento], [FechaHora], [Nota]) VALUES (9, 37, 893659, 9, 14, CAST(400000.00 AS Decimal(18, 2)), N'Al contado', CAST(0.00 AS Decimal(18, 2)), CAST(400000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0x0000AB1B018B5BCE AS DateTime), NULL)
INSERT [dbo].[Facturas] ([id], [id_Cliente], [id_Empleado], [id_Solicitud], [id_Seguro], [Precio], [T_Pago], [Pago Parcial], [SubTotal], [Descuento], [FechaHora], [Nota]) VALUES (10, 59, 893659, 10, 10, CAST(50000.00 AS Decimal(18, 2)), N'Al contado', CAST(0.00 AS Decimal(18, 2)), CAST(50000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0x0000AB1C0029616A AS DateTime), NULL)
INSERT [dbo].[Facturas] ([id], [id_Cliente], [id_Empleado], [id_Solicitud], [id_Seguro], [Precio], [T_Pago], [Pago Parcial], [SubTotal], [Descuento], [FechaHora], [Nota]) VALUES (11, 1, 893659, 11, 8, CAST(800000.00 AS Decimal(18, 2)), N'Al contado', CAST(0.00 AS Decimal(18, 2)), CAST(800000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0x0000AB1C00BC55D3 AS DateTime), NULL)
INSERT [dbo].[Facturas] ([id], [id_Cliente], [id_Empleado], [id_Solicitud], [id_Seguro], [Precio], [T_Pago], [Pago Parcial], [SubTotal], [Descuento], [FechaHora], [Nota]) VALUES (12, 32, 893659, 12, 8, CAST(400000.00 AS Decimal(18, 2)), N'Al contado', CAST(0.00 AS Decimal(18, 2)), CAST(400000.00 AS Decimal(18, 2)), CAST(400000.00 AS Decimal(18, 2)), CAST(0x0000AB3F01464C0C AS DateTime), NULL)
INSERT [dbo].[Facturas] ([id], [id_Cliente], [id_Empleado], [id_Solicitud], [id_Seguro], [Precio], [T_Pago], [Pago Parcial], [SubTotal], [Descuento], [FechaHora], [Nota]) VALUES (13, 32, 893659, 12, 8, CAST(800000.00 AS Decimal(18, 2)), N'Al contado', CAST(0.00 AS Decimal(18, 2)), CAST(800000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0x0000AB3F01467948 AS DateTime), NULL)
INSERT [dbo].[Facturas] ([id], [id_Cliente], [id_Empleado], [id_Solicitud], [id_Seguro], [Precio], [T_Pago], [Pago Parcial], [SubTotal], [Descuento], [FechaHora], [Nota]) VALUES (14, 32, 893659, 15, 2, CAST(100000.00 AS Decimal(18, 2)), N'Al contado', CAST(0.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0x0000AB3F0149ABCE AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Facturas] OFF
SET IDENTITY_INSERT [dbo].[inPoliza] ON 

INSERT [dbo].[inPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [Vencimiento], [FechaHora], [Nota]) VALUES (1, 59, 10, N' Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales.ENTIDAD ASEGURADORA …………………………………….NOTA INFORMATIVA AL TOMADOR DEL SEGURO(ASEGURADO)La información que se contiene en este documento se ofrece en cumplimiento de lo dispuesto en la Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y de los artículos 104 a 107 de su Reglamento de desarrollo, aprobado por Real Decreto 2486/1998.LEGISLACIÓN APLICABLE AL CONTRATO DE SEGUROLey 50/1980, de 8 de octubre, de Contrato de Seguro; Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y su Reglamento de desarrollo(Real Decreto nº 2486/1998, de 20 de noviembre). Condiciones Generales, Especiales y Particulares del Contrato.ENTIDAD ASEGURADORADenominación Social: ………………………………. es el nombre comercial de ……………………………………………………………………………………………………………….. con N.I.F.: ………………………………., con domicilio en ………………………………..Corresponde a la Dirección General de Seguros, dependiente del Ministerio de Economía y Hacienda, el control y supervisión de la actividad de dicha Entidad Aseguradora.INSTANCIAS DE RECLAMACIÓN ………………………………. 1) Servicio de Atención al Cliente cuyo reglamento se encuentra a disposición de los interesados en las oficinas de ………………………………..2) Con carácter general los conflictos se resolverán por los jueces y tribunales competentes.3) Asimismo puede acudirse, para resolver las controversias que puedan plantearse, al procedimiento administrativo de reclamación ante la Dirección General de Seguros para el cual está legitimado el tomador, asegurado, beneficiario, tercero perjudicado o derechohabiente de cualquiera de ellos.CONDICIONES GENERALES DEL SEGURO DE VIDA INDIVIDUALEl presente contrato de seguro de vida se rige por lo dispuesto en la Ley 50/1980, de 8 de octubre, de contrato de Seguro, T.R de Ordenación y Supervisión de los Seguros Privados, R.D.Leg 6/2004, R.D. 2486/1998 de 20 de Noviembre y por lo convenido en las Condiciones Generales, Especiales y Particulares de este contrato, sin que tengan validez las cláusulas limitativas de los derechos de los asegurados que no sean específicamente aceptadas por el tomador de la póliza.No requerirán dicha aceptación las meras transcripciones o referencias a preceptos legales.El control de la actividad que desarrolla la Entidad Aseguradora, le corresponde al Ministerio de Economía y Hacienda del Estado español, que lo ejerce a través de la Dirección General de Seguros y Fondos de Pensiones.ARTÍCULO PRELIMINAR. DEFINICIONES.Para los efectos de este contrato se entenderá por:', 1, CAST(0x2E410B00 AS Date), CAST(0x0000AB1C002C8E2C AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[inPoliza] OFF
SET IDENTITY_INSERT [dbo].[PagoPolizas] ON 

INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (1, 32, 1, 5, 3, NULL, NULL, NULL, CAST(0x0000AB0B017F5701 AS DateTime), CAST(90000.00 AS Decimal(18, 2)), CAST(90000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (2, 44, 1, 1, 9, NULL, NULL, NULL, CAST(0x0000AB0B017F93D4 AS DateTime), CAST(80000.00 AS Decimal(18, 2)), CAST(80000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (3, 36, 1, 2, 7, NULL, NULL, NULL, CAST(0x0000AB0B0180F681 AS DateTime), CAST(100000.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (4, 1, 1, 2, 2, NULL, NULL, NULL, CAST(0x0000AB0B01813009 AS DateTime), CAST(100000.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (5, 31, 1, 1, 4, NULL, NULL, NULL, CAST(0x0000AB0B01813497 AS DateTime), CAST(80000.00 AS Decimal(18, 2)), CAST(80000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (7, 36, 1, 2, 7, NULL, NULL, NULL, CAST(0x0000AB0B018AC429 AS DateTime), CAST(100000.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (8, 36, 1, 2, 7, NULL, NULL, NULL, CAST(0x0000AB0C001822E3 AS DateTime), CAST(100000.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (9, 36, 1, 2, 7, NULL, NULL, NULL, CAST(0x0000AB1400F6C50E AS DateTime), CAST(100000.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (10, 32, 1, 5, 3, NULL, NULL, NULL, CAST(0x0000AB1400F6D235 AS DateTime), CAST(90000.00 AS Decimal(18, 2)), CAST(90000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (11, 44, 1, 5, 9, NULL, NULL, NULL, CAST(0x0000AB1C001518B8 AS DateTime), CAST(90000.00 AS Decimal(18, 2)), CAST(90000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (12, 1, 1, 16, 1, NULL, NULL, NULL, CAST(0x0000AB1C001AD1AF AS DateTime), CAST(600000.00 AS Decimal(18, 2)), CAST(600000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (13, 45, 1, 2, 7, NULL, NULL, NULL, CAST(0x0000AB1C001B1ADD AS DateTime), CAST(400000.00 AS Decimal(18, 2)), CAST(400000.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (14, 37, 1, 2, 8, NULL, NULL, NULL, CAST(0x0000AB1C001BB0A1 AS DateTime), CAST(400000.00 AS Decimal(18, 2)), CAST(400000.00 AS Decimal(18, 2)), CAST(50505.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (15, 1, 1, 2, 2, NULL, NULL, NULL, CAST(0x0000AB1C001BE142 AS DateTime), CAST(100000.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)), CAST(50505.00 AS Decimal(18, 2)), NULL)
SET IDENTITY_INSERT [dbo].[PagoPolizas] OFF
SET IDENTITY_INSERT [dbo].[PolizaDeSeguros] ON 

INSERT [dbo].[PolizaDeSeguros] ([id], [Nombre del Seguro], [Area], [Descripcion], [Precio], [Fecha]) VALUES (1, N'Seguro Todo Riesgo', N'Vehiculo', N'El costo promedio anual del seguro de auto es de unos $800, pero hay una enorme variación debido a que muchas cosas afectan el precio de una póliza. Todos los factores que afectan el precio de una póliza ayudan a determinar cuál es la posibilidad de que usted tenga un accidente.

Básico - A
Cuanto mejor sea su historial de manejo más baja será la prima de seguros de auto para usted. Si usted ha cometido infracciones de tránsito, tiene multas o ha tenido accidentes con el vehículo, es muy probable que page más por su prima de seguros  que si su historial está libre de estos. También usted puede tener que pagar más por la prima de su seguro si usted es un conductor novato, acaba de sacar su licencia de conducir y no ha tenido seguro de autos por un tiempo determinado de años.

Semi Full - B
A más millas recorridas, hay más posibilidades de que sufra un accidente. Si usted usa su auto para trabajar o recorre una distancia larga para ir a su lugar de trabajo, usted pagará un poco más que si solo usa el auto de vez en cuando, lo que se conoce como de uso de placer o “pleasure use”,  en cuyo caso usted pagará menos por el seguro del auto.

Full - C
El lugar donde usted vive y donde estaciona el auto puede afectar el costo de la prima del seguro de auto. Por lo general, debido a mayores probabilidades de vandalismo, robo y accidentes, las zonas urbanas suelen ser más costosas para el seguro de auto que las ciudades más pequeñas, poblados y áreas rurales.

Otros factores que varían de un área o estado a otro incluyen: el costo de litigación en la zona, costos de gastos de reparación del vehículo y costos de servicios médicos, presencia de fraude generalizado contra los seguros de automóvil y las características climatológicas del lugar.', CAST(80000.00 AS Decimal(18, 2)), CAST(0x60400B00 AS Date))
INSERT [dbo].[PolizaDeSeguros] ([id], [Nombre del Seguro], [Area], [Descripcion], [Precio], [Fecha]) VALUES (2, N'Seguro de Salud', N'Vida', N'El costo promedio anual del seguro de auto es de unos $800, pero hay una enorme variación debido a que muchas cosas afectan el precio de una póliza. Todos los factores que afectan el precio de una póliza ayudan a determinar cuál es la posibilidad de que usted tenga un accidente.

Básico - A
Cuanto mejor sea su historial de manejo más baja será la prima de seguros de auto para usted. Si usted ha cometido infracciones de tránsito, tiene multas o ha tenido accidentes con el vehículo, es muy probable que page más por su prima de seguros  que si su historial está libre de estos. También usted puede tener que pagar más por la prima de su seguro si usted es un conductor novato, acaba de sacar su licencia de conducir y no ha tenido seguro de autos por un tiempo determinado de años.

Semi Full - B
A más millas recorridas, hay más posibilidades de que sufra un accidente. Si usted usa su auto para trabajar o recorre una distancia larga para ir a su lugar de trabajo, usted pagará un poco más que si solo usa el auto de vez en cuando, lo que se conoce como de uso de placer o “pleasure use”,  en cuyo caso usted pagará menos por el seguro del auto.

Full - C
El lugar donde usted vive y donde estaciona el auto puede afectar el costo de la prima del seguro de auto. Por lo general, debido a mayores probabilidades de vandalismo, robo y accidentes, las zonas urbanas suelen ser más costosas para el seguro de auto que las ciudades más pequeñas, poblados y áreas rurales.

Otros factores que varían de un área o estado a otro incluyen: el costo de litigación en la zona, costos de gastos de reparación del vehículo y costos de servicios médicos, presencia de fraude generalizado contra los seguros de automóvil y las características climatológicas del lugar.', CAST(100000.00 AS Decimal(18, 2)), CAST(0xBB3F0B00 AS Date))
INSERT [dbo].[PolizaDeSeguros] ([id], [Nombre del Seguro], [Area], [Descripcion], [Precio], [Fecha]) VALUES (5, N'Seguro Riesgos Laborales', N'Vida', N'El costo promedio anual del seguro de auto es de unos $800, pero hay una enorme variación debido a que muchas cosas afectan el precio de una póliza. Todos los factores que afectan el precio de una póliza ayudan a determinar cuál es la posibilidad de que usted tenga un accidente.

Básico - A
Cuanto mejor sea su historial de manejo más baja será la prima de seguros de auto para usted. Si usted ha cometido infracciones de tránsito, tiene multas o ha tenido accidentes con el vehículo, es muy probable que page más por su prima de seguros  que si su historial está libre de estos. También usted puede tener que pagar más por la prima de su seguro si usted es un conductor novato, acaba de sacar su licencia de conducir y no ha tenido seguro de autos por un tiempo determinado de años.

Semi Full - B
A más millas recorridas, hay más posibilidades de que sufra un accidente. Si usted usa su auto para trabajar o recorre una distancia larga para ir a su lugar de trabajo, usted pagará un poco más que si solo usa el auto de vez en cuando, lo que se conoce como de uso de placer o “pleasure use”,  en cuyo caso usted pagará menos por el seguro del auto.

Full - C
El lugar donde usted vive y donde estaciona el auto puede afectar el costo de la prima del seguro de auto. Por lo general, debido a mayores probabilidades de vandalismo, robo y accidentes, las zonas urbanas suelen ser más costosas para el seguro de auto que las ciudades más pequeñas, poblados y áreas rurales.

Otros factores que varían de un área o estado a otro incluyen: el costo de litigación en la zona, costos de gastos de reparación del vehículo y costos de servicios médicos, presencia de fraude generalizado contra los seguros de automóvil y las características climatológicas del lugar.', CAST(90000.00 AS Decimal(18, 2)), CAST(0x853F0B00 AS Date))
INSERT [dbo].[PolizaDeSeguros] ([id], [Nombre del Seguro], [Area], [Descripcion], [Precio], [Fecha]) VALUES (8, N'Seguro Negocios y Empresas', N'Negocios e Empresas', N'El costo promedio anual del seguro de auto es de unos $800, pero hay una enorme variación debido a que muchas cosas afectan el precio de una póliza. Todos los factores que afectan el precio de una póliza ayudan a determinar cuál es la posibilidad de que usted tenga un accidente.

Básico - A
Cuanto mejor sea su historial de manejo más baja será la prima de seguros de auto para usted. Si usted ha cometido infracciones de tránsito, tiene multas o ha tenido accidentes con el vehículo, es muy probable que page más por su prima de seguros  que si su historial está libre de estos. También usted puede tener que pagar más por la prima de su seguro si usted es un conductor novato, acaba de sacar su licencia de conducir y no ha tenido seguro de autos por un tiempo determinado de años.

Semi Full - B
A más millas recorridas, hay más posibilidades de que sufra un accidente. Si usted usa su auto para trabajar o recorre una distancia larga para ir a su lugar de trabajo, usted pagará un poco más que si solo usa el auto de vez en cuando, lo que se conoce como de uso de placer o “pleasure use”,  en cuyo caso usted pagará menos por el seguro del auto.

Full - C
El lugar donde usted vive y donde estaciona el auto puede afectar el costo de la prima del seguro de auto. Por lo general, debido a mayores probabilidades de vandalismo, robo y accidentes, las zonas urbanas suelen ser más costosas para el seguro de auto que las ciudades más pequeñas, poblados y áreas rurales.

Otros factores que varían de un área o estado a otro incluyen: el costo de litigación en la zona, costos de gastos de reparación del vehículo y costos de servicios médicos, presencia de fraude generalizado contra los seguros de automóvil y las características climatológicas del lugar.', CAST(800000.00 AS Decimal(18, 2)), CAST(0x66400B00 AS Date))
INSERT [dbo].[PolizaDeSeguros] ([id], [Nombre del Seguro], [Area], [Descripcion], [Precio], [Fecha]) VALUES (10, N'Seguro Edificaciones', N'Muebles e Inmuebles', N'El costo promedio anual del seguro de auto es de unos $800, pero hay una enorme variación debido a que muchas cosas afectan el precio de una póliza. Todos los factores que afectan el precio de una póliza ayudan a determinar cuál es la posibilidad de que usted tenga un accidente.

Básico - A
Cuanto mejor sea su historial de manejo más baja será la prima de seguros de auto para usted. Si usted ha cometido infracciones de tránsito, tiene multas o ha tenido accidentes con el vehículo, es muy probable que page más por su prima de seguros  que si su historial está libre de estos. También usted puede tener que pagar más por la prima de su seguro si usted es un conductor novato, acaba de sacar su licencia de conducir y no ha tenido seguro de autos por un tiempo determinado de años.

Semi Full - B
A más millas recorridas, hay más posibilidades de que sufra un accidente. Si usted usa su auto para trabajar o recorre una distancia larga para ir a su lugar de trabajo, usted pagará un poco más que si solo usa el auto de vez en cuando, lo que se conoce como de uso de placer o “pleasure use”,  en cuyo caso usted pagará menos por el seguro del auto.

Full - C
El lugar donde usted vive y donde estaciona el auto puede afectar el costo de la prima del seguro de auto. Por lo general, debido a mayores probabilidades de vandalismo, robo y accidentes, las zonas urbanas suelen ser más costosas para el seguro de auto que las ciudades más pequeñas, poblados y áreas rurales.

Otros factores que varían de un área o estado a otro incluyen: el costo de litigación en la zona, costos de gastos de reparación del vehículo y costos de servicios médicos, presencia de fraude generalizado contra los seguros de automóvil y las características climatológicas del lugar.', CAST(50000.00 AS Decimal(18, 2)), CAST(0x6B400B00 AS Date))
INSERT [dbo].[PolizaDeSeguros] ([id], [Nombre del Seguro], [Area], [Descripcion], [Precio], [Fecha]) VALUES (13, N'Seguro Contenido', N'Muebles e Inmuebles', N'El costo promedio anual del seguro de auto es de unos $800, pero hay una enorme variación debido a que muchas cosas afectan el precio de una póliza. Todos los factores que afectan el precio de una póliza ayudan a determinar cuál es la posibilidad de que usted tenga un accidente.

Básico - A
Cuanto mejor sea su historial de manejo más baja será la prima de seguros de auto para usted. Si usted ha cometido infracciones de tránsito, tiene multas o ha tenido accidentes con el vehículo, es muy probable que page más por su prima de seguros  que si su historial está libre de estos. También usted puede tener que pagar más por la prima de su seguro si usted es un conductor novato, acaba de sacar su licencia de conducir y no ha tenido seguro de autos por un tiempo determinado de años.

Semi Full - B
A más millas recorridas, hay más posibilidades de que sufra un accidente. Si usted usa su auto para trabajar o recorre una distancia larga para ir a su lugar de trabajo, usted pagará un poco más que si solo usa el auto de vez en cuando, lo que se conoce como de uso de placer o “pleasure use”,  en cuyo caso usted pagará menos por el seguro del auto.

Full - C
El lugar donde usted vive y donde estaciona el auto puede afectar el costo de la prima del seguro de auto. Por lo general, debido a mayores probabilidades de vandalismo, robo y accidentes, las zonas urbanas suelen ser más costosas para el seguro de auto que las ciudades más pequeñas, poblados y áreas rurales.

Otros factores que varían de un área o estado a otro incluyen: el costo de litigación en la zona, costos de gastos de reparación del vehículo y costos de servicios médicos, presencia de fraude generalizado contra los seguros de automóvil y las características climatológicas del lugar.', CAST(900000.00 AS Decimal(18, 2)), CAST(0x6E400B00 AS Date))
INSERT [dbo].[PolizaDeSeguros] ([id], [Nombre del Seguro], [Area], [Descripcion], [Precio], [Fecha]) VALUES (14, N'Seguro Voluntario', N'Vehiculo', N'El costo promedio anual del seguro de auto es de unos $800, pero hay una enorme variación debido a que muchas cosas afectan el precio de una póliza. Todos los factores que afectan el precio de una póliza ayudan a determinar cuál es la posibilidad de que usted tenga un accidente.

Básico - A
Cuanto mejor sea su historial de manejo más baja será la prima de seguros de auto para usted. Si usted ha cometido infracciones de tránsito, tiene multas o ha tenido accidentes con el vehículo, es muy probable que page más por su prima de seguros  que si su historial está libre de estos. También usted puede tener que pagar más por la prima de su seguro si usted es un conductor novato, acaba de sacar su licencia de conducir y no ha tenido seguro de autos por un tiempo determinado de años.

Semi Full - B
A más millas recorridas, hay más posibilidades de que sufra un accidente. Si usted usa su auto para trabajar o recorre una distancia larga para ir a su lugar de trabajo, usted pagará un poco más que si solo usa el auto de vez en cuando, lo que se conoce como de uso de placer o “pleasure use”,  en cuyo caso usted pagará menos por el seguro del auto.

Full - C
El lugar donde usted vive y donde estaciona el auto puede afectar el costo de la prima del seguro de auto. Por lo general, debido a mayores probabilidades de vandalismo, robo y accidentes, las zonas urbanas suelen ser más costosas para el seguro de auto que las ciudades más pequeñas, poblados y áreas rurales.

Otros factores que varían de un área o estado a otro incluyen: el costo de litigación en la zona, costos de gastos de reparación del vehículo y costos de servicios médicos, presencia de fraude generalizado contra los seguros de automóvil y las características climatológicas del lugar.', CAST(400000.00 AS Decimal(18, 2)), CAST(0x6E400B00 AS Date))
INSERT [dbo].[PolizaDeSeguros] ([id], [Nombre del Seguro], [Area], [Descripcion], [Precio], [Fecha]) VALUES (15, N'Seguro Obligatorio', N'Vehiculo', N'El costo promedio anual del seguro de auto es de unos $800, pero hay una enorme variación debido a que muchas cosas afectan el precio de una póliza. Todos los factores que afectan el precio de una póliza ayudan a determinar cuál es la posibilidad de que usted tenga un accidente.

Básico - A
Cuanto mejor sea su historial de manejo más baja será la prima de seguros de auto para usted. Si usted ha cometido infracciones de tránsito, tiene multas o ha tenido accidentes con el vehículo, es muy probable que page más por su prima de seguros  que si su historial está libre de estos. También usted puede tener que pagar más por la prima de su seguro si usted es un conductor novato, acaba de sacar su licencia de conducir y no ha tenido seguro de autos por un tiempo determinado de años.

Semi Full - B
A más millas recorridas, hay más posibilidades de que sufra un accidente. Si usted usa su auto para trabajar o recorre una distancia larga para ir a su lugar de trabajo, usted pagará un poco más que si solo usa el auto de vez en cuando, lo que se conoce como de uso de placer o “pleasure use”,  en cuyo caso usted pagará menos por el seguro del auto.

Full - C
El lugar donde usted vive y donde estaciona el auto puede afectar el costo de la prima del seguro de auto. Por lo general, debido a mayores probabilidades de vandalismo, robo y accidentes, las zonas urbanas suelen ser más costosas para el seguro de auto que las ciudades más pequeñas, poblados y áreas rurales.

Otros factores que varían de un área o estado a otro incluyen: el costo de litigación en la zona, costos de gastos de reparación del vehículo y costos de servicios médicos, presencia de fraude generalizado contra los seguros de automóvil y las características climatológicas del lugar.', CAST(600000.00 AS Decimal(18, 2)), CAST(0x65400B00 AS Date))
INSERT [dbo].[PolizaDeSeguros] ([id], [Nombre del Seguro], [Area], [Descripcion], [Precio], [Fecha]) VALUES (16, N'Seguro de Riesgo de Muerte', N'Vida', N'El costo promedio anual del seguro de auto es de unos $800, pero hay una enorme variación debido a que muchas cosas afectan el precio de una póliza. Todos los factores que afectan el precio de una póliza ayudan a determinar cuál es la posibilidad de que usted tenga un accidente.

Básico - A
Cuanto mejor sea su historial de manejo más baja será la prima de seguros de auto para usted. Si usted ha cometido infracciones de tránsito, tiene multas o ha tenido accidentes con el vehículo, es muy probable que page más por su prima de seguros  que si su historial está libre de estos. También usted puede tener que pagar más por la prima de su seguro si usted es un conductor novato, acaba de sacar su licencia de conducir y no ha tenido seguro de autos por un tiempo determinado de años.

Semi Full - B
A más millas recorridas, hay más posibilidades de que sufra un accidente. Si usted usa su auto para trabajar o recorre una distancia larga para ir a su lugar de trabajo, usted pagará un poco más que si solo usa el auto de vez en cuando, lo que se conoce como de uso de placer o “pleasure use”,  en cuyo caso usted pagará menos por el seguro del auto.

Full - C
El lugar donde usted vive y donde estaciona el auto puede afectar el costo de la prima del seguro de auto. Por lo general, debido a mayores probabilidades de vandalismo, robo y accidentes, las zonas urbanas suelen ser más costosas para el seguro de auto que las ciudades más pequeñas, poblados y áreas rurales.

Otros factores que varían de un área o estado a otro incluyen: el costo de litigación en la zona, costos de gastos de reparación del vehículo y costos de servicios médicos, presencia de fraude generalizado contra los seguros de automóvil y las características climatológicas del lugar.', CAST(750950.00 AS Decimal(18, 2)), CAST(0x73400B00 AS Date))
INSERT [dbo].[PolizaDeSeguros] ([id], [Nombre del Seguro], [Area], [Descripcion], [Precio], [Fecha]) VALUES (19, N'Seguro Dependientes de Salud', N'Vida', N'El costo promedio anual del seguro de auto es de unos $800, pero hay una enorme variación debido a que muchas cosas afectan el precio de una póliza. Todos los factores que afectan el precio de una póliza ayudan a determinar cuál es la posibilidad de que usted tenga un accidente.

Básico - A
Cuanto mejor sea su historial de manejo más baja será la prima de seguros de auto para usted. Si usted ha cometido infracciones de tránsito, tiene multas o ha tenido accidentes con el vehículo, es muy probable que page más por su prima de seguros  que si su historial está libre de estos. También usted puede tener que pagar más por la prima de su seguro si usted es un conductor novato, acaba de sacar su licencia de conducir y no ha tenido seguro de autos por un tiempo determinado de años.

Semi Full - B
A más millas recorridas, hay más posibilidades de que sufra un accidente. Si usted usa su auto para trabajar o recorre una distancia larga para ir a su lugar de trabajo, usted pagará un poco más que si solo usa el auto de vez en cuando, lo que se conoce como de uso de placer o “pleasure use”,  en cuyo caso usted pagará menos por el seguro del auto.

Full - C
El lugar donde usted vive y donde estaciona el auto puede afectar el costo de la prima del seguro de auto. Por lo general, debido a mayores probabilidades de vandalismo, robo y accidentes, las zonas urbanas suelen ser más costosas para el seguro de auto que las ciudades más pequeñas, poblados y áreas rurales.

Otros factores que varían de un área o estado a otro incluyen: el costo de litigación en la zona, costos de gastos de reparación del vehículo y costos de servicios médicos, presencia de fraude generalizado contra los seguros de automóvil y las características climatológicas del lugar.', CAST(205888.00 AS Decimal(18, 2)), CAST(0x73400B00 AS Date))
SET IDENTITY_INSERT [dbo].[PolizaDeSeguros] OFF
SET IDENTITY_INSERT [dbo].[Siniestros] ON 

INSERT [dbo].[Siniestros] ([id], [id_Cliente], [id_Empleado], [Siniestro], [FechaHora]) VALUES (1, 1, 1, N'.sjkfhskjdhfk;ljsd;hgldkgh', CAST(0x0000AB0C00000000 AS DateTime))
INSERT [dbo].[Siniestros] ([id], [id_Cliente], [id_Empleado], [Siniestro], [FechaHora]) VALUES (2, 9, 1, N'sdflmgfsadgsdlf mg,s{dmgfsr,hg m
dhj ghj,gf ,hj{d f,hjft{-,hjkñlteyhjñerkyt{ñekty+poe5k
ylpk54yt+ relkht{mgfh ´06jñlkg hn,hgdnDhjn.fg.,jgd-.jdgf-.ndfghngh
jfghjfghjfg
hjf
ghj
fg
hjfg
hj
fg
hjfghjf,h
{fhñ
fghj{ff
hj
fgjfg
fgh
dfhg', CAST(0x0000AB0D017C45A1 AS DateTime))
INSERT [dbo].[Siniestros] ([id], [id_Cliente], [id_Empleado], [Siniestro], [FechaHora]) VALUES (3, 32, 1, N'dasfgasdgaertweryg wth 
etdty jghj fghj fghj fghj fg
hj fg
hj 
fg
hj hgj
fghjg h
jgf
j
gfjfg 
hjf
fghj
fghj f
ghj
fg hj
fg
 hjfg
hjfg
hjfg
hjfg
hj
fghj
fghj
fg
hjfg
hj
fghj
fg
hjfg
hj 
gf hj
fghjf
g
hjfghjfg
hj 
gf
hj fg
j f
ghj
 fgj f
ghj 
fg
hj fghj', CAST(0x0000AB0D017F046F AS DateTime))
INSERT [dbo].[Siniestros] ([id], [id_Cliente], [id_Empleado], [Siniestro], [FechaHora]) VALUES (4, 44, 1, N'fttg''hlkfdsfg
sdf
gsd
fgs
dfg
sdfgs
df
gsd
fg
sdf
gds
fgs
df
gsd
gfds
fg
sdf
gsd
gf
sdf
gsd
fg
sdf
gsd
fg
sd
fgsd
fg
sdfg
sd
fg
sdfg', CAST(0x0000AB0D0184E0FB AS DateTime))
INSERT [dbo].[Siniestros] ([id], [id_Cliente], [id_Empleado], [Siniestro], [FechaHora]) VALUES (5, 1, 1, N'.sjkfhskjdhfk;ljsd;hgldkgh', CAST(0x0000AB0C00000000 AS DateTime))
INSERT [dbo].[Siniestros] ([id], [id_Cliente], [id_Empleado], [Siniestro], [FechaHora]) VALUES (6, 1, 1, N'.sjkfhskjdhfk;ljsd;hgldkgh', CAST(0x0000AB0C00000000 AS DateTime))
INSERT [dbo].[Siniestros] ([id], [id_Cliente], [id_Empleado], [Siniestro], [FechaHora]) VALUES (7, 1, 1, N'weewrtwergdsfbfdb', CAST(0x0000AB0E015BA4A3 AS DateTime))
INSERT [dbo].[Siniestros] ([id], [id_Cliente], [id_Empleado], [Siniestro], [FechaHora]) VALUES (8, 1, 1, N'serrsdfsdfsdf', CAST(0x0000AB1400F5FF24 AS DateTime))
INSERT [dbo].[Siniestros] ([id], [id_Cliente], [id_Empleado], [Siniestro], [FechaHora]) VALUES (9, 44, 1, N'wertesrf', CAST(0x0000AB1400F66523 AS DateTime))
INSERT [dbo].[Siniestros] ([id], [id_Cliente], [id_Empleado], [Siniestro], [FechaHora]) VALUES (10, 36, 1, N'sdfgfds gsfdhgdfhj fghj fghj fghj', CAST(0x0000AB1400F73191 AS DateTime))
INSERT [dbo].[Siniestros] ([id], [id_Cliente], [id_Empleado], [Siniestro], [FechaHora]) VALUES (11, 1, 1, N'Accidente', CAST(0x0000AB1C001F7107 AS DateTime))
INSERT [dbo].[Siniestros] ([id], [id_Cliente], [id_Empleado], [Siniestro], [FechaHora]) VALUES (12, 1, 1, N'kukuhdkhskhdkushxkuhsxkushkuhxukshx', CAST(0x0000AB1C00BD9D51 AS DateTime))
INSERT [dbo].[Siniestros] ([id], [id_Cliente], [id_Empleado], [Siniestro], [FechaHora]) VALUES (13, 32, 1, N'sd.fs,a mgfh.e,afhgsd.,fgñlre gwreHT {efGhD f
hg
fdshs
dfg
s gh 
j fds
hg{j f
h {ñfg{h ñsfd{lgsd
fg 
sgf 
fhb 
f{hgfs{.g s{dflhgñ 
{jñldflhg fhgsdñfffffffhgñsdlf hsf hbsfdñlkhgh', CAST(0x0000AB3F014CD122 AS DateTime))
SET IDENTITY_INSERT [dbo].[Siniestros] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id], [NombreUsuario], [Contrasena], [Privilegio], [Fecha]) VALUES (1, N'Admin', N'1234', N'nocturno', CAST(0xC73A0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
SET IDENTITY_INSERT [dbo].[vdPoliza] ON 

INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (1, 1, 16, N'lkuewrs', 2, CAST(0x0000AB1C000C2018 AS DateTime), CAST(0xAB410B00 AS Date), N'')
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (2, 1, 2, N' Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales.ENTIDAD ASEGURADORA …………………………………….NOTA INFORMATIVA AL TOMADOR DEL SEGURO(ASEGURADO)La información que se contiene en este documento se ofrece en cumplimiento de lo dispuesto en la Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y de los artículos 104 a 107 de su Reglamento de desarrollo, aprobado por Real Decreto 2486/1998.LEGISLACIÓN APLICABLE AL CONTRATO DE SEGUROLey 50/1980, de 8 de octubre, de Contrato de Seguro; Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y su Reglamento de desarrollo(Real Decreto nº 2486/1998, de 20 de noviembre). Condiciones Generales, Especiales y Particulares del Contrato.ENTIDAD ASEGURADORADenominación Social: ………………………………. es el nombre comercial de ……………………………………………………………………………………………………………….. con N.I.F.: ………………………………., con domicilio en ………………………………..Corresponde a la Dirección General de Seguros, dependiente del Ministerio de Economía y Hacienda, el control y supervisión de la actividad de dicha Entidad Aseguradora.INSTANCIAS DE RECLAMACIÓN ………………………………. 1) Servicio de Atención al Cliente cuyo reglamento se encuentra a disposición de los interesados en las oficinas de ………………………………..2) Con carácter general los conflictos se resolverán por los jueces y tribunales competentes.3) Asimismo puede acudirse, para resolver las controversias que puedan plantearse, al procedimiento administrativo de reclamación ante la Dirección General de Seguros para el cual está legitimado el tomador, asegurado, beneficiario, tercero perjudicado o derechohabiente de cualquiera de ellos.CONDICIONES GENERALES DEL SEGURO DE VIDA INDIVIDUALEl presente contrato de seguro de vida se rige por lo dispuesto en la Ley 50/1980, de 8 de octubre, de contrato de Seguro, T.R de Ordenación y Supervisión de los Seguros Privados, R.D.Leg 6/2004, R.D. 2486/1998 de 20 de Noviembre y por lo convenido en las Condiciones Generales, Especiales y Particulares de este contrato, sin que tengan validez las cláusulas limitativas de los derechos de los asegurados que no sean específicamente aceptadas por el tomador de la póliza.No requerirán dicha aceptación las meras transcripciones o referencias a preceptos legales.El control de la actividad que desarrolla la Entidad Aseguradora, le corresponde al Ministerio de Economía y Hacienda del Estado español, que lo ejerce a través de la Dirección General de Seguros y Fondos de Pensiones.ARTÍCULO PRELIMINAR. DEFINICIONES.Para los efectos de este contrato se entenderá por:', 1, CAST(0x0000AB1C001BE142 AS DateTime), CAST(0x77400B00 AS Date), NULL)
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (3, 32, 5, N'ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfgdghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf234-2343243-2ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg3dghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf90000.00aslkdfj;slarjgs;lgkfdhj;lfdkhgjfdl;khfdhj;lfdhj;ldfkhjl;kdfhj;lkdfhkdfhkdfhglkdfjhsldkfjgsdhj;ldkfjgl;fdkhj;lfj;lfdhj;lfdhj;lfdhj;lkfdhj;lfdhj;lkfdhj;lfdhjl;dkfjh', 1, CAST(0x0000AB1400F6D235 AS DateTime), CAST(0x6F400B00 AS Date), NULL)
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (4, 31, 16, N'ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfgdghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf234-2312312-2ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg4dghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf80000.00aslkdfj;slarjgs;lgkfdhj;lfdkhgjfdl;khfdhj;lfdhj;ldfkhjl;kdfhj;lkdfhkdfhkdfhglkdfjhsldkfjgsdhj;ldkfjgl;fdkhj;lfj;lfdhj;lfdhj;lfdhj;lkfdhj;lfdhj;lkfdhj;lfdhjl;dkfjh', 2, CAST(0x0000AB0B01813497 AS DateTime), CAST(0x66400B00 AS Date), NULL)
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (5, 36, 5, N'ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfgdghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf231-4232342-3ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg5dghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf90000.00aslkdfj;slarjgs;lgkfdhj;lfdkhgjfdl;khfdhj;lfdhj;ldfkhjl;kdfhj;lkdfhkdfhkdfhglkdfjhsldkfjgsdhj;ldkfjgl;fdkhj;lfj;lfdhj;lfdhj;lfdhj;lkfdhj;lfdhj;lkfdhj;lfdhjl;dkfjh', 2, CAST(0x0000AB0B017A8B9F AS DateTime), CAST(0x66400B00 AS Date), NULL)
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (6, 37, 2, N'ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfgdghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf234-2342342-3ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg6dghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf80000.00aslkdfj;slarjgs;lgkfdhj;lfdkhgjfdl;khfdhj;lfdhj;ldfkhjl;kdfhj;lkdfhkdfhkdfhglkdfjhsldkfjgsdhj;ldkfjgl;fdkhj;lfj;lfdhj;lfdhj;lfdhj;lkfdhj;lfdhj;lkfdhj;lfdhjl;dkfjh', 1, CAST(0x0000AB0B017940F9 AS DateTime), CAST(0x66400B00 AS Date), NULL)
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (7, 36, 2, N'ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfgdghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf231-4232342-3ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg7dghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf100000.00aslkdfj;slarjgs;lgkfdhj;lfdkhgjfdl;khfdhj;lfdhj;ldfkhjl;kdfhj;lkdfhkdfhkdfhglkdfjhsldkfjgsdhj;ldkfjgl;fdkhj;lfj;lfdhj;lfdhj;lfdhj;lkfdhj;lfdhj;lkfdhj;lfdhjl;dkfjh', 1, CAST(0x0000AB1400F6C50E AS DateTime), CAST(0x6F400B00 AS Date), N'')
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (8, 37, 2, N'ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfgdghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf234-2342342-3ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg8dghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf100000.00aslkdfj;slarjgs;lgkfdhj;lfdkhgjfdl;khfdhj;lfdhj;ldfkhjl;kdfhj;lkdfhkdfhkdfhglkdfjhsldkfjgsdhj;ldkfjgl;fdkhj;lfj;lfdhj;lfdhj;lfdhj;lkfdhj;lfdhj;lkfdhj;lfdhjl;dkfjh', 1, CAST(0x0000AB0C0014F80B AS DateTime), CAST(0x66400B00 AS Date), N'')
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (9, 44, 5, N' Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales.ENTIDAD ASEGURADORA …………………………………….NOTA INFORMATIVA AL TOMADOR DEL SEGURO(ASEGURADO)La información que se contiene en este documento se ofrece en cumplimiento de lo dispuesto en la Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y de los artículos 104 a 107 de su Reglamento de desarrollo, aprobado por Real Decreto 2486/1998.LEGISLACIÓN APLICABLE AL CONTRATO DE SEGUROLey 50/1980, de 8 de octubre, de Contrato de Seguro; Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y su Reglamento de desarrollo(Real Decreto nº 2486/1998, de 20 de noviembre). Condiciones Generales, Especiales y Particulares del Contrato.ENTIDAD ASEGURADORADenominación Social: ………………………………. es el nombre comercial de ……………………………………………………………………………………………………………….. con N.I.F.: ………………………………., con domicilio en ………………………………..Corresponde a la Dirección General de Seguros, dependiente del Ministerio de Economía y Hacienda, el control y supervisión de la actividad de dicha Entidad Aseguradora.INSTANCIAS DE RECLAMACIÓN ………………………………. 1) Servicio de Atención al Cliente cuyo reglamento se encuentra a disposición de los interesados en las oficinas de ………………………………..2) Con carácter general los conflictos se resolverán por los jueces y tribunales competentes.3) Asimismo puede acudirse, para resolver las controversias que puedan plantearse, al procedimiento administrativo de reclamación ante la Dirección General de Seguros para el cual está legitimado el tomador, asegurado, beneficiario, tercero perjudicado o derechohabiente de cualquiera de ellos.CONDICIONES GENERALES DEL SEGURO DE VIDA INDIVIDUALEl presente contrato de seguro de vida se rige por lo dispuesto en la Ley 50/1980, de 8 de octubre, de contrato de Seguro, T.R de Ordenación y Supervisión de los Seguros Privados, R.D.Leg 6/2004, R.D. 2486/1998 de 20 de Noviembre y por lo convenido en las Condiciones Generales, Especiales y Particulares de este contrato, sin que tengan validez las cláusulas limitativas de los derechos de los asegurados que no sean específicamente aceptadas por el tomador de la póliza.No requerirán dicha aceptación las meras transcripciones o referencias a preceptos legales.El control de la actividad que desarrolla la Entidad Aseguradora, le corresponde al Ministerio de Economía y Hacienda del Estado español, que lo ejerce a través de la Dirección General de Seguros y Fondos de Pensiones.ARTÍCULO PRELIMINAR. DEFINICIONES.Para los efectos de este contrato se entenderá por:', 1, CAST(0x0000AB1C001518B8 AS DateTime), CAST(0x77400B00 AS Date), N'')
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (10, 45, 16, N' Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales.ENTIDAD ASEGURADORA …………………………………….NOTA INFORMATIVA AL TOMADOR DEL SEGURO(ASEGURADO)La información que se contiene en este documento se ofrece en cumplimiento de lo dispuesto en la Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y de los artículos 104 a 107 de su Reglamento de desarrollo, aprobado por Real Decreto 2486/1998.LEGISLACIÓN APLICABLE AL CONTRATO DE SEGUROLey 50/1980, de 8 de octubre, de Contrato de Seguro; Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y su Reglamento de desarrollo(Real Decreto nº 2486/1998, de 20 de noviembre). Condiciones Generales, Especiales y Particulares del Contrato.ENTIDAD ASEGURADORADenominación Social: ………………………………. es el nombre comercial de ……………………………………………………………………………………………………………….. con N.I.F.: ………………………………., con domicilio en ………………………………..Corresponde a la Dirección General de Seguros, dependiente del Ministerio de Economía y Hacienda, el control y supervisión de la actividad de dicha Entidad Aseguradora.INSTANCIAS DE RECLAMACIÓN ………………………………. 1) Servicio de Atención al Cliente cuyo reglamento se encuentra a disposición de los interesados en las oficinas de ………………………………..2) Con carácter general los conflictos se resolverán por los jueces y tribunales competentes.3) Asimismo puede acudirse, para resolver las controversias que puedan plantearse, al procedimiento administrativo de reclamación ante la Dirección General de Seguros para el cual está legitimado el tomador, asegurado, beneficiario, tercero perjudicado o derechohabiente de cualquiera de ellos.CONDICIONES GENERALES DEL SEGURO DE VIDA INDIVIDUALEl presente contrato de seguro de vida se rige por lo dispuesto en la Ley 50/1980, de 8 de octubre, de contrato de Seguro, T.R de Ordenación y Supervisión de los Seguros Privados, R.D.Leg 6/2004, R.D. 2486/1998 de 20 de Noviembre y por lo convenido en las Condiciones Generales, Especiales y Particulares de este contrato, sin que tengan validez las cláusulas limitativas de los derechos de los asegurados que no sean específicamente aceptadas por el tomador de la póliza.No requerirán dicha aceptación las meras transcripciones o referencias a preceptos legales.El control de la actividad que desarrolla la Entidad Aseguradora, le corresponde al Ministerio de Economía y Hacienda del Estado español, que lo ejerce a través de la Dirección General de Seguros y Fondos de Pensiones.ARTÍCULO PRELIMINAR. DEFINICIONES.Para los efectos de este contrato se entenderá por:', 1, CAST(0x0000AB15000EC94E AS DateTime), CAST(0x15410B00 AS Date), NULL)
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (11, 15, NULL, N' Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales.ENTIDAD ASEGURADORA …………………………………….NOTA INFORMATIVA AL TOMADOR DEL SEGURO(ASEGURADO)La información que se contiene en este documento se ofrece en cumplimiento de lo dispuesto en la Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y de los artículos 104 a 107 de su Reglamento de desarrollo, aprobado por Real Decreto 2486/1998.LEGISLACIÓN APLICABLE AL CONTRATO DE SEGUROLey 50/1980, de 8 de octubre, de Contrato de Seguro; Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y su Reglamento de desarrollo(Real Decreto nº 2486/1998, de 20 de noviembre). Condiciones Generales, Especiales y Particulares del Contrato.ENTIDAD ASEGURADORADenominación Social: ………………………………. es el nombre comercial de ……………………………………………………………………………………………………………….. con N.I.F.: ………………………………., con domicilio en ………………………………..Corresponde a la Dirección General de Seguros, dependiente del Ministerio de Economía y Hacienda, el control y supervisión de la actividad de dicha Entidad Aseguradora.INSTANCIAS DE RECLAMACIÓN ………………………………. 1) Servicio de Atención al Cliente cuyo reglamento se encuentra a disposición de los interesados en las oficinas de ………………………………..2) Con carácter general los conflictos se resolverán por los jueces y tribunales competentes.3) Asimismo puede acudirse, para resolver las controversias que puedan plantearse, al procedimiento administrativo de reclamación ante la Dirección General de Seguros para el cual está legitimado el tomador, asegurado, beneficiario, tercero perjudicado o derechohabiente de cualquiera de ellos.CONDICIONES GENERALES DEL SEGURO DE VIDA INDIVIDUALEl presente contrato de seguro de vida se rige por lo dispuesto en la Ley 50/1980, de 8 de octubre, de contrato de Seguro, T.R de Ordenación y Supervisión de los Seguros Privados, R.D.Leg 6/2004, R.D. 2486/1998 de 20 de Noviembre y por lo convenido en las Condiciones Generales, Especiales y Particulares de este contrato, sin que tengan validez las cláusulas limitativas de los derechos de los asegurados que no sean específicamente aceptadas por el tomador de la póliza.No requerirán dicha aceptación las meras transcripciones o referencias a preceptos legales.El control de la actividad que desarrolla la Entidad Aseguradora, le corresponde al Ministerio de Economía y Hacienda del Estado español, que lo ejerce a través de la Dirección General de Seguros y Fondos de Pensiones.ARTÍCULO PRELIMINAR. DEFINICIONES.Para los efectos de este contrato se entenderá por:', 1, CAST(0x0000AB18013F2455 AS DateTime), CAST(0x15410B00 AS Date), NULL)
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (13, 46, 2, N' Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales.ENTIDAD ASEGURADORA …………………………………….NOTA INFORMATIVA AL TOMADOR DEL SEGURO(ASEGURADO)La información que se contiene en este documento se ofrece en cumplimiento de lo dispuesto en la Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y de los artículos 104 a 107 de su Reglamento de desarrollo, aprobado por Real Decreto 2486/1998.LEGISLACIÓN APLICABLE AL CONTRATO DE SEGUROLey 50/1980, de 8 de octubre, de Contrato de Seguro; Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y su Reglamento de desarrollo(Real Decreto nº 2486/1998, de 20 de noviembre). Condiciones Generales, Especiales y Particulares del Contrato.ENTIDAD ASEGURADORADenominación Social: ………………………………. es el nombre comercial de ……………………………………………………………………………………………………………….. con N.I.F.: ………………………………., con domicilio en ………………………………..Corresponde a la Dirección General de Seguros, dependiente del Ministerio de Economía y Hacienda, el control y supervisión de la actividad de dicha Entidad Aseguradora.INSTANCIAS DE RECLAMACIÓN ………………………………. 1) Servicio de Atención al Cliente cuyo reglamento se encuentra a disposición de los interesados en las oficinas de ………………………………..2) Con carácter general los conflictos se resolverán por los jueces y tribunales competentes.3) Asimismo puede acudirse, para resolver las controversias que puedan plantearse, al procedimiento administrativo de reclamación ante la Dirección General de Seguros para el cual está legitimado el tomador, asegurado, beneficiario, tercero perjudicado o derechohabiente de cualquiera de ellos.CONDICIONES GENERALES DEL SEGURO DE VIDA INDIVIDUALEl presente contrato de seguro de vida se rige por lo dispuesto en la Ley 50/1980, de 8 de octubre, de contrato de Seguro, T.R de Ordenación y Supervisión de los Seguros Privados, R.D.Leg 6/2004, R.D. 2486/1998 de 20 de Noviembre y por lo convenido en las Condiciones Generales, Especiales y Particulares de este contrato, sin que tengan validez las cláusulas limitativas de los derechos de los asegurados que no sean específicamente aceptadas por el tomador de la póliza.No requerirán dicha aceptación las meras transcripciones o referencias a preceptos legales.El control de la actividad que desarrolla la Entidad Aseguradora, le corresponde al Ministerio de Economía y Hacienda del Estado español, que lo ejerce a través de la Dirección General de Seguros y Fondos de Pensiones.ARTÍCULO PRELIMINAR. DEFINICIONES.Para los efectos de este contrato se entenderá por:', 1, CAST(0x0000AB18014E7EAB AS DateTime), CAST(0x2A410B00 AS Date), NULL)
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (14, 32, 2, N' Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales.ENTIDAD ASEGURADORA …………………………………….NOTA INFORMATIVA AL TOMADOR DEL SEGURO(ASEGURADO)La información que se contiene en este documento se ofrece en cumplimiento de lo dispuesto en la Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y de los artículos 104 a 107 de su Reglamento de desarrollo, aprobado por Real Decreto 2486/1998.LEGISLACIÓN APLICABLE AL CONTRATO DE SEGUROLey 50/1980, de 8 de octubre, de Contrato de Seguro; Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y su Reglamento de desarrollo(Real Decreto nº 2486/1998, de 20 de noviembre). Condiciones Generales, Especiales y Particulares del Contrato.ENTIDAD ASEGURADORADenominación Social: ………………………………. es el nombre comercial de ……………………………………………………………………………………………………………….. con N.I.F.: ………………………………., con domicilio en ………………………………..Corresponde a la Dirección General de Seguros, dependiente del Ministerio de Economía y Hacienda, el control y supervisión de la actividad de dicha Entidad Aseguradora.INSTANCIAS DE RECLAMACIÓN ………………………………. 1) Servicio de Atención al Cliente cuyo reglamento se encuentra a disposición de los interesados en las oficinas de ………………………………..2) Con carácter general los conflictos se resolverán por los jueces y tribunales competentes.3) Asimismo puede acudirse, para resolver las controversias que puedan plantearse, al procedimiento administrativo de reclamación ante la Dirección General de Seguros para el cual está legitimado el tomador, asegurado, beneficiario, tercero perjudicado o derechohabiente de cualquiera de ellos.CONDICIONES GENERALES DEL SEGURO DE VIDA INDIVIDUALEl presente contrato de seguro de vida se rige por lo dispuesto en la Ley 50/1980, de 8 de octubre, de contrato de Seguro, T.R de Ordenación y Supervisión de los Seguros Privados, R.D.Leg 6/2004, R.D. 2486/1998 de 20 de Noviembre y por lo convenido en las Condiciones Generales, Especiales y Particulares de este contrato, sin que tengan validez las cláusulas limitativas de los derechos de los asegurados que no sean específicamente aceptadas por el tomador de la póliza.No requerirán dicha aceptación las meras transcripciones o referencias a preceptos legales.El control de la actividad que desarrolla la Entidad Aseguradora, le corresponde al Ministerio de Economía y Hacienda del Estado español, que lo ejerce a través de la Dirección General de Seguros y Fondos de Pensiones.ARTÍCULO PRELIMINAR. DEFINICIONES.Para los efectos de este contrato se entenderá por:', 1, CAST(0x0000AB3F0149ABCE AS DateTime), CAST(0x50410B00 AS Date), NULL)
SET IDENTITY_INSERT [dbo].[vdPoliza] OFF
SET IDENTITY_INSERT [dbo].[vhPoliza] ON 

INSERT [dbo].[vhPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (1, 1, 15, N' Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales.ENTIDAD ASEGURADORA …………………………………….NOTA INFORMATIVA AL TOMADOR DEL SEGURO(ASEGURADO)La información que se contiene en este documento se ofrece en cumplimiento de lo dispuesto en la Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y de los artículos 104 a 107 de su Reglamento de desarrollo, aprobado por Real Decreto 2486/1998.LEGISLACIÓN APLICABLE AL CONTRATO DE SEGUROLey 50/1980, de 8 de octubre, de Contrato de Seguro; Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y su Reglamento de desarrollo(Real Decreto nº 2486/1998, de 20 de noviembre). Condiciones Generales, Especiales y Particulares del Contrato.ENTIDAD ASEGURADORADenominación Social: ………………………………. es el nombre comercial de ……………………………………………………………………………………………………………….. con N.I.F.: ………………………………., con domicilio en ………………………………..Corresponde a la Dirección General de Seguros, dependiente del Ministerio de Economía y Hacienda, el control y supervisión de la actividad de dicha Entidad Aseguradora.INSTANCIAS DE RECLAMACIÓN ………………………………. 1) Servicio de Atención al Cliente cuyo reglamento se encuentra a disposición de los interesados en las oficinas de ………………………………..2) Con carácter general los conflictos se resolverán por los jueces y tribunales competentes.3) Asimismo puede acudirse, para resolver las controversias que puedan plantearse, al procedimiento administrativo de reclamación ante la Dirección General de Seguros para el cual está legitimado el tomador, asegurado, beneficiario, tercero perjudicado o derechohabiente de cualquiera de ellos.CONDICIONES GENERALES DEL SEGURO DE VIDA INDIVIDUALEl presente contrato de seguro de vida se rige por lo dispuesto en la Ley 50/1980, de 8 de octubre, de contrato de Seguro, T.R de Ordenación y Supervisión de los Seguros Privados, R.D.Leg 6/2004, R.D. 2486/1998 de 20 de Noviembre y por lo convenido en las Condiciones Generales, Especiales y Particulares de este contrato, sin que tengan validez las cláusulas limitativas de los derechos de los asegurados que no sean específicamente aceptadas por el tomador de la póliza.No requerirán dicha aceptación las meras transcripciones o referencias a preceptos legales.El control de la actividad que desarrolla la Entidad Aseguradora, le corresponde al Ministerio de Economía y Hacienda del Estado español, que lo ejerce a través de la Dirección General de Seguros y Fondos de Pensiones.ARTÍCULO PRELIMINAR. DEFINICIONES.Para los efectos de este contrato se entenderá por:', 1, CAST(0x0000AB1C001AD1AF AS DateTime), CAST(0x77400B00 AS Date), N'')
INSERT [dbo].[vhPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (7, 45, 14, N' Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales.ENTIDAD ASEGURADORA …………………………………….NOTA INFORMATIVA AL TOMADOR DEL SEGURO(ASEGURADO)La información que se contiene en este documento se ofrece en cumplimiento de lo dispuesto en la Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y de los artículos 104 a 107 de su Reglamento de desarrollo, aprobado por Real Decreto 2486/1998.LEGISLACIÓN APLICABLE AL CONTRATO DE SEGUROLey 50/1980, de 8 de octubre, de Contrato de Seguro; Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y su Reglamento de desarrollo(Real Decreto nº 2486/1998, de 20 de noviembre). Condiciones Generales, Especiales y Particulares del Contrato.ENTIDAD ASEGURADORADenominación Social: ………………………………. es el nombre comercial de ……………………………………………………………………………………………………………….. con N.I.F.: ………………………………., con domicilio en ………………………………..Corresponde a la Dirección General de Seguros, dependiente del Ministerio de Economía y Hacienda, el control y supervisión de la actividad de dicha Entidad Aseguradora.INSTANCIAS DE RECLAMACIÓN ………………………………. 1) Servicio de Atención al Cliente cuyo reglamento se encuentra a disposición de los interesados en las oficinas de ………………………………..2) Con carácter general los conflictos se resolverán por los jueces y tribunales competentes.3) Asimismo puede acudirse, para resolver las controversias que puedan plantearse, al procedimiento administrativo de reclamación ante la Dirección General de Seguros para el cual está legitimado el tomador, asegurado, beneficiario, tercero perjudicado o derechohabiente de cualquiera de ellos.CONDICIONES GENERALES DEL SEGURO DE VIDA INDIVIDUALEl presente contrato de seguro de vida se rige por lo dispuesto en la Ley 50/1980, de 8 de octubre, de contrato de Seguro, T.R de Ordenación y Supervisión de los Seguros Privados, R.D.Leg 6/2004, R.D. 2486/1998 de 20 de Noviembre y por lo convenido en las Condiciones Generales, Especiales y Particulares de este contrato, sin que tengan validez las cláusulas limitativas de los derechos de los asegurados que no sean específicamente aceptadas por el tomador de la póliza.No requerirán dicha aceptación las meras transcripciones o referencias a preceptos legales.El control de la actividad que desarrolla la Entidad Aseguradora, le corresponde al Ministerio de Economía y Hacienda del Estado español, que lo ejerce a través de la Dirección General de Seguros y Fondos de Pensiones.ARTÍCULO PRELIMINAR. DEFINICIONES.Para los efectos de este contrato se entenderá por:', 1, CAST(0x0000AB1C001B1ADD AS DateTime), CAST(0x77400B00 AS Date), N'')
INSERT [dbo].[vhPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (8, 37, 14, N' Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales.ENTIDAD ASEGURADORA …………………………………….NOTA INFORMATIVA AL TOMADOR DEL SEGURO(ASEGURADO)La información que se contiene en este documento se ofrece en cumplimiento de lo dispuesto en la Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y de los artículos 104 a 107 de su Reglamento de desarrollo, aprobado por Real Decreto 2486/1998.LEGISLACIÓN APLICABLE AL CONTRATO DE SEGUROLey 50/1980, de 8 de octubre, de Contrato de Seguro; Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y su Reglamento de desarrollo(Real Decreto nº 2486/1998, de 20 de noviembre). Condiciones Generales, Especiales y Particulares del Contrato.ENTIDAD ASEGURADORADenominación Social: ………………………………. es el nombre comercial de ……………………………………………………………………………………………………………….. con N.I.F.: ………………………………., con domicilio en ………………………………..Corresponde a la Dirección General de Seguros, dependiente del Ministerio de Economía y Hacienda, el control y supervisión de la actividad de dicha Entidad Aseguradora.INSTANCIAS DE RECLAMACIÓN ………………………………. 1) Servicio de Atención al Cliente cuyo reglamento se encuentra a disposición de los interesados en las oficinas de ………………………………..2) Con carácter general los conflictos se resolverán por los jueces y tribunales competentes.3) Asimismo puede acudirse, para resolver las controversias que puedan plantearse, al procedimiento administrativo de reclamación ante la Dirección General de Seguros para el cual está legitimado el tomador, asegurado, beneficiario, tercero perjudicado o derechohabiente de cualquiera de ellos.CONDICIONES GENERALES DEL SEGURO DE VIDA INDIVIDUALEl presente contrato de seguro de vida se rige por lo dispuesto en la Ley 50/1980, de 8 de octubre, de contrato de Seguro, T.R de Ordenación y Supervisión de los Seguros Privados, R.D.Leg 6/2004, R.D. 2486/1998 de 20 de Noviembre y por lo convenido en las Condiciones Generales, Especiales y Particulares de este contrato, sin que tengan validez las cláusulas limitativas de los derechos de los asegurados que no sean específicamente aceptadas por el tomador de la póliza.No requerirán dicha aceptación las meras transcripciones o referencias a preceptos legales.El control de la actividad que desarrolla la Entidad Aseguradora, le corresponde al Ministerio de Economía y Hacienda del Estado español, que lo ejerce a través de la Dirección General de Seguros y Fondos de Pensiones.ARTÍCULO PRELIMINAR. DEFINICIONES.Para los efectos de este contrato se entenderá por:', 1, CAST(0x0000AB1C001BB0A1 AS DateTime), CAST(0x77400B00 AS Date), N'')
INSERT [dbo].[vhPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (9, 37, 14, N' Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales.ENTIDAD ASEGURADORA …………………………………….NOTA INFORMATIVA AL TOMADOR DEL SEGURO(ASEGURADO)La información que se contiene en este documento se ofrece en cumplimiento de lo dispuesto en la Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y de los artículos 104 a 107 de su Reglamento de desarrollo, aprobado por Real Decreto 2486/1998.LEGISLACIÓN APLICABLE AL CONTRATO DE SEGUROLey 50/1980, de 8 de octubre, de Contrato de Seguro; Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y su Reglamento de desarrollo(Real Decreto nº 2486/1998, de 20 de noviembre). Condiciones Generales, Especiales y Particulares del Contrato.ENTIDAD ASEGURADORADenominación Social: ………………………………. es el nombre comercial de ……………………………………………………………………………………………………………….. con N.I.F.: ………………………………., con domicilio en ………………………………..Corresponde a la Dirección General de Seguros, dependiente del Ministerio de Economía y Hacienda, el control y supervisión de la actividad de dicha Entidad Aseguradora.INSTANCIAS DE RECLAMACIÓN ………………………………. 1) Servicio de Atención al Cliente cuyo reglamento se encuentra a disposición de los interesados en las oficinas de ………………………………..2) Con carácter general los conflictos se resolverán por los jueces y tribunales competentes.3) Asimismo puede acudirse, para resolver las controversias que puedan plantearse, al procedimiento administrativo de reclamación ante la Dirección General de Seguros para el cual está legitimado el tomador, asegurado, beneficiario, tercero perjudicado o derechohabiente de cualquiera de ellos.CONDICIONES GENERALES DEL SEGURO DE VIDA INDIVIDUALEl presente contrato de seguro de vida se rige por lo dispuesto en la Ley 50/1980, de 8 de octubre, de contrato de Seguro, T.R de Ordenación y Supervisión de los Seguros Privados, R.D.Leg 6/2004, R.D. 2486/1998 de 20 de Noviembre y por lo convenido en las Condiciones Generales, Especiales y Particulares de este contrato, sin que tengan validez las cláusulas limitativas de los derechos de los asegurados que no sean específicamente aceptadas por el tomador de la póliza.No requerirán dicha aceptación las meras transcripciones o referencias a preceptos legales.El control de la actividad que desarrolla la Entidad Aseguradora, le corresponde al Ministerio de Economía y Hacienda del Estado español, que lo ejerce a través de la Dirección General de Seguros y Fondos de Pensiones.ARTÍCULO PRELIMINAR. DEFINICIONES.Para los efectos de este contrato se entenderá por:', 1, CAST(0x0000AB3F0151BE75 AS DateTime), CAST(0x50410B00 AS Date), NULL)
SET IDENTITY_INSERT [dbo].[vhPoliza] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__CargoEmp__68A1C0DF4339AB50]    Script Date: 27/01/2020 6:40:18 ******/
ALTER TABLE [dbo].[CargoEmp] ADD UNIQUE NONCLUSTERED 
(
	[Cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Cliente__B4ADFE389788A824]    Script Date: 27/01/2020 6:40:18 ******/
ALTER TABLE [dbo].[Cliente] ADD UNIQUE NONCLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Cliente__B95E33E5A6A971F5]    Script Date: 27/01/2020 6:40:18 ******/
ALTER TABLE [dbo].[Cliente] ADD UNIQUE NONCLUSTERED 
(
	[Id] ASC,
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__detalleS__70E979AC1963E228]    Script Date: 27/01/2020 6:40:18 ******/
ALTER TABLE [dbo].[detalleSeguroEmpresaNegocio] ADD UNIQUE NONCLUSTERED 
(
	[Telefono de Entidad Autorizada] ASC,
	[Correo electronico de Entidad Autorizada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Empleado__B4ADFE382463DBA9]    Script Date: 27/01/2020 6:40:18 ******/
ALTER TABLE [dbo].[Empleado] ADD  CONSTRAINT [UQ__Empleado__B4ADFE382463DBA9] UNIQUE NONCLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CategoriaPolizas]  WITH CHECK ADD  CONSTRAINT [FK_CategoriaPolizas_PolizaDeSeguros] FOREIGN KEY([id_SeguroPoliza])
REFERENCES [dbo].[PolizaDeSeguros] ([id])
GO
ALTER TABLE [dbo].[CategoriaPolizas] CHECK CONSTRAINT [FK_CategoriaPolizas_PolizaDeSeguros]
GO
ALTER TABLE [dbo].[ctEmpresasNegocios]  WITH CHECK ADD  CONSTRAINT [FK_ctEmpresasNegocios_cEstado] FOREIGN KEY([idEstado])
REFERENCES [dbo].[cEstado] ([idEstado])
GO
ALTER TABLE [dbo].[ctEmpresasNegocios] CHECK CONSTRAINT [FK_ctEmpresasNegocios_cEstado]
GO
ALTER TABLE [dbo].[ctEmpresasNegocios]  WITH CHECK ADD  CONSTRAINT [FK_ctEmpresasNegocios_Cliente] FOREIGN KEY([id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[ctEmpresasNegocios] CHECK CONSTRAINT [FK_ctEmpresasNegocios_Cliente]
GO
ALTER TABLE [dbo].[ctEmpresasNegocios]  WITH CHECK ADD  CONSTRAINT [FK_ctEmpresasNegocios_Empleados] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleado] ([Id])
GO
ALTER TABLE [dbo].[ctEmpresasNegocios] CHECK CONSTRAINT [FK_ctEmpresasNegocios_Empleados]
GO
ALTER TABLE [dbo].[ctMueblesInmuebles]  WITH CHECK ADD  CONSTRAINT [FK_ctMueblesInmuebles_cEstado] FOREIGN KEY([idEstado])
REFERENCES [dbo].[cEstado] ([idEstado])
GO
ALTER TABLE [dbo].[ctMueblesInmuebles] CHECK CONSTRAINT [FK_ctMueblesInmuebles_cEstado]
GO
ALTER TABLE [dbo].[ctMueblesInmuebles]  WITH CHECK ADD  CONSTRAINT [FK_ctMueblesInmuebles_Cliente] FOREIGN KEY([id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[ctMueblesInmuebles] CHECK CONSTRAINT [FK_ctMueblesInmuebles_Cliente]
GO
ALTER TABLE [dbo].[ctMueblesInmuebles]  WITH CHECK ADD  CONSTRAINT [FK_ctMueblesInmuebles_Empleados] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleado] ([Id])
GO
ALTER TABLE [dbo].[ctMueblesInmuebles] CHECK CONSTRAINT [FK_ctMueblesInmuebles_Empleados]
GO
ALTER TABLE [dbo].[ctVehiculo]  WITH CHECK ADD  CONSTRAINT [FK_ctVehiculo_cEstado] FOREIGN KEY([idEstado])
REFERENCES [dbo].[cEstado] ([idEstado])
GO
ALTER TABLE [dbo].[ctVehiculo] CHECK CONSTRAINT [FK_ctVehiculo_cEstado]
GO
ALTER TABLE [dbo].[ctVehiculo]  WITH CHECK ADD  CONSTRAINT [FK_ctVehiculo_Cliente] FOREIGN KEY([id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[ctVehiculo] CHECK CONSTRAINT [FK_ctVehiculo_Cliente]
GO
ALTER TABLE [dbo].[ctVehiculo]  WITH CHECK ADD  CONSTRAINT [FK_ctVehiculo_Empleados] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleado] ([Id])
GO
ALTER TABLE [dbo].[ctVehiculo] CHECK CONSTRAINT [FK_ctVehiculo_Empleados]
GO
ALTER TABLE [dbo].[ctVida]  WITH CHECK ADD  CONSTRAINT [FK_ctVida_cEstado] FOREIGN KEY([idEstado])
REFERENCES [dbo].[cEstado] ([idEstado])
GO
ALTER TABLE [dbo].[ctVida] CHECK CONSTRAINT [FK_ctVida_cEstado]
GO
ALTER TABLE [dbo].[ctVida]  WITH CHECK ADD  CONSTRAINT [FK_ctVida_Cliente] FOREIGN KEY([id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[ctVida] CHECK CONSTRAINT [FK_ctVida_Cliente]
GO
ALTER TABLE [dbo].[ctVida]  WITH CHECK ADD  CONSTRAINT [FK_ctVida_Empleados] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleado] ([Id])
GO
ALTER TABLE [dbo].[ctVida] CHECK CONSTRAINT [FK_ctVida_Empleados]
GO
ALTER TABLE [dbo].[dependientesSeguroSalud]  WITH CHECK ADD  CONSTRAINT [FK_dependientesSeguroSalud_detalleSeguroSalud] FOREIGN KEY([id_detalleSeguroSalud])
REFERENCES [dbo].[detalleSeguroSalud] ([id])
GO
ALTER TABLE [dbo].[dependientesSeguroSalud] CHECK CONSTRAINT [FK_dependientesSeguroSalud_detalleSeguroSalud]
GO
ALTER TABLE [dbo].[detalleEdificaciones]  WITH CHECK ADD  CONSTRAINT [FK_detalleEdificaciones_ctMueblesInmuebles] FOREIGN KEY([id_ctMueblesInmuebles])
REFERENCES [dbo].[ctMueblesInmuebles] ([id])
GO
ALTER TABLE [dbo].[detalleEdificaciones] CHECK CONSTRAINT [FK_detalleEdificaciones_ctMueblesInmuebles]
GO
ALTER TABLE [dbo].[detalleSeguroContenido]  WITH CHECK ADD  CONSTRAINT [FK_detalleSeguroContenido_ctMueblesInmuebles] FOREIGN KEY([id_ctMueblesInmuebles])
REFERENCES [dbo].[ctMueblesInmuebles] ([id])
GO
ALTER TABLE [dbo].[detalleSeguroContenido] CHECK CONSTRAINT [FK_detalleSeguroContenido_ctMueblesInmuebles]
GO
ALTER TABLE [dbo].[detalleSeguroEmpresaNegocio]  WITH CHECK ADD  CONSTRAINT [FK_detalleSeguroEmpresaNegocio_ctEmpresasNegocios] FOREIGN KEY([id_ctEmpresasNegocios])
REFERENCES [dbo].[ctEmpresasNegocios] ([id])
GO
ALTER TABLE [dbo].[detalleSeguroEmpresaNegocio] CHECK CONSTRAINT [FK_detalleSeguroEmpresaNegocio_ctEmpresasNegocios]
GO
ALTER TABLE [dbo].[detalleSeguroObligatorio]  WITH CHECK ADD  CONSTRAINT [FK_detalleSeguroObligatorio_ctVehiculo] FOREIGN KEY([id_ctVehiculo])
REFERENCES [dbo].[ctVehiculo] ([id])
GO
ALTER TABLE [dbo].[detalleSeguroObligatorio] CHECK CONSTRAINT [FK_detalleSeguroObligatorio_ctVehiculo]
GO
ALTER TABLE [dbo].[detalleSeguroRiesgoMuerte]  WITH CHECK ADD  CONSTRAINT [FK_detalleSeguroRiesgoMuerte_ctVida] FOREIGN KEY([id_ctVida])
REFERENCES [dbo].[ctVida] ([id])
GO
ALTER TABLE [dbo].[detalleSeguroRiesgoMuerte] CHECK CONSTRAINT [FK_detalleSeguroRiesgoMuerte_ctVida]
GO
ALTER TABLE [dbo].[detalleSeguroRiesgosLaborales]  WITH CHECK ADD  CONSTRAINT [FK_detalleSeguroRiesgosLaborales_ctVida] FOREIGN KEY([id_ctVida])
REFERENCES [dbo].[ctVida] ([id])
GO
ALTER TABLE [dbo].[detalleSeguroRiesgosLaborales] CHECK CONSTRAINT [FK_detalleSeguroRiesgosLaborales_ctVida]
GO
ALTER TABLE [dbo].[detalleSeguroSalud]  WITH CHECK ADD  CONSTRAINT [FK_detalleSeguroSalud_ctVida] FOREIGN KEY([id_ctVida])
REFERENCES [dbo].[ctVida] ([id])
GO
ALTER TABLE [dbo].[detalleSeguroSalud] CHECK CONSTRAINT [FK_detalleSeguroSalud_ctVida]
GO
ALTER TABLE [dbo].[detalleSeguroTodoRiesgo]  WITH CHECK ADD  CONSTRAINT [FK_detalleSeguroTodoRiesgo_ctVehiculo] FOREIGN KEY([id_ctVehiculo])
REFERENCES [dbo].[ctVehiculo] ([id])
GO
ALTER TABLE [dbo].[detalleSeguroTodoRiesgo] CHECK CONSTRAINT [FK_detalleSeguroTodoRiesgo_ctVehiculo]
GO
ALTER TABLE [dbo].[detalleSeguroVoluntario]  WITH CHECK ADD  CONSTRAINT [FK_detalleSeguroVoluntario_ctVehiculo] FOREIGN KEY([id_ctVehiculo])
REFERENCES [dbo].[ctVehiculo] ([id])
GO
ALTER TABLE [dbo].[detalleSeguroVoluntario] CHECK CONSTRAINT [FK_detalleSeguroVoluntario_ctVehiculo]
GO
ALTER TABLE [dbo].[Devoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Devoluciones_Cliente] FOREIGN KEY([id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Devoluciones] CHECK CONSTRAINT [FK_Devoluciones_Cliente]
GO
ALTER TABLE [dbo].[Devoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Devoluciones_PolizaDeSeguros] FOREIGN KEY([idPolizaDeSeguro])
REFERENCES [dbo].[PolizaDeSeguros] ([id])
GO
ALTER TABLE [dbo].[Devoluciones] CHECK CONSTRAINT [FK_Devoluciones_PolizaDeSeguros]
GO
ALTER TABLE [dbo].[emEvidencia]  WITH CHECK ADD  CONSTRAINT [FK_emEvidencia_emReclamos] FOREIGN KEY([id_emReclamos])
REFERENCES [dbo].[emReclamos] ([id])
GO
ALTER TABLE [dbo].[emEvidencia] CHECK CONSTRAINT [FK_emEvidencia_emReclamos]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_CargoEmp] FOREIGN KEY([idCargo])
REFERENCES [dbo].[CargoEmp] ([id])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_CargoEmp]
GO
ALTER TABLE [dbo].[emPoliza]  WITH CHECK ADD  CONSTRAINT [FK_emPoliza_Cliente] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[emPoliza] CHECK CONSTRAINT [FK_emPoliza_Cliente]
GO
ALTER TABLE [dbo].[emPoliza]  WITH CHECK ADD  CONSTRAINT [FK_emPoliza_PolizaDeSeguros] FOREIGN KEY([IdPolizaDeSeguro])
REFERENCES [dbo].[PolizaDeSeguros] ([id])
GO
ALTER TABLE [dbo].[emPoliza] CHECK CONSTRAINT [FK_emPoliza_PolizaDeSeguros]
GO
ALTER TABLE [dbo].[EmpSeguroRiesgosLaborales]  WITH CHECK ADD  CONSTRAINT [FK_EmpSeguroRiesgosLaborales_detalleSeguroRiesgosLaborales] FOREIGN KEY([id_detalleSeguroRiesgosLab])
REFERENCES [dbo].[detalleSeguroRiesgosLaborales] ([id])
GO
ALTER TABLE [dbo].[EmpSeguroRiesgosLaborales] CHECK CONSTRAINT [FK_EmpSeguroRiesgosLaborales_detalleSeguroRiesgosLaborales]
GO
ALTER TABLE [dbo].[emReclamos]  WITH CHECK ADD  CONSTRAINT [FK_emReclamos_Cliente] FOREIGN KEY([id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[emReclamos] CHECK CONSTRAINT [FK_emReclamos_Cliente]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Cliente] FOREIGN KEY([id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Cliente]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Empleado] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleado] ([Id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Empleado]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Seguros] FOREIGN KEY([id_Seguro])
REFERENCES [dbo].[PolizaDeSeguros] ([id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Seguros]
GO
ALTER TABLE [dbo].[imagenesCotenidoInspSeguroEmpresas]  WITH CHECK ADD  CONSTRAINT [FK_imagenesCotenidoInspSeguroEmpresas_detalleSeguroEmpresaNegocio] FOREIGN KEY([id_detallesSeguroEmpresasN])
REFERENCES [dbo].[detalleSeguroEmpresaNegocio] ([id])
GO
ALTER TABLE [dbo].[imagenesCotenidoInspSeguroEmpresas] CHECK CONSTRAINT [FK_imagenesCotenidoInspSeguroEmpresas_detalleSeguroEmpresaNegocio]
GO
ALTER TABLE [dbo].[inEvidencia]  WITH CHECK ADD  CONSTRAINT [FK_inEvidencia_inReclamos] FOREIGN KEY([id_inReclamos])
REFERENCES [dbo].[inReclamos] ([id])
GO
ALTER TABLE [dbo].[inEvidencia] CHECK CONSTRAINT [FK_inEvidencia_inReclamos]
GO
ALTER TABLE [dbo].[inPoliza]  WITH CHECK ADD  CONSTRAINT [FK_inPoliza_Cliente] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[inPoliza] CHECK CONSTRAINT [FK_inPoliza_Cliente]
GO
ALTER TABLE [dbo].[inPoliza]  WITH CHECK ADD  CONSTRAINT [FK_inPoliza_PolizaDeSeguros] FOREIGN KEY([IdPolizaDeSeguro])
REFERENCES [dbo].[PolizaDeSeguros] ([id])
GO
ALTER TABLE [dbo].[inPoliza] CHECK CONSTRAINT [FK_inPoliza_PolizaDeSeguros]
GO
ALTER TABLE [dbo].[inReclamos]  WITH CHECK ADD  CONSTRAINT [FK_inReclamos_Cliente1] FOREIGN KEY([id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[inReclamos] CHECK CONSTRAINT [FK_inReclamos_Cliente1]
GO
ALTER TABLE [dbo].[PagoPolizas]  WITH CHECK ADD  CONSTRAINT [FK_PagoPolizas_Empleado] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleado] ([Id])
GO
ALTER TABLE [dbo].[PagoPolizas] CHECK CONSTRAINT [FK_PagoPolizas_Empleado]
GO
ALTER TABLE [dbo].[PagoPolizas]  WITH CHECK ADD  CONSTRAINT [FK_PagoPolizas_emPoliza] FOREIGN KEY([idPolizaEm])
REFERENCES [dbo].[emPoliza] ([id])
GO
ALTER TABLE [dbo].[PagoPolizas] CHECK CONSTRAINT [FK_PagoPolizas_emPoliza]
GO
ALTER TABLE [dbo].[PagoPolizas]  WITH CHECK ADD  CONSTRAINT [FK_PagoPolizas_inPoliza1] FOREIGN KEY([idPolizaIn])
REFERENCES [dbo].[inPoliza] ([id])
GO
ALTER TABLE [dbo].[PagoPolizas] CHECK CONSTRAINT [FK_PagoPolizas_inPoliza1]
GO
ALTER TABLE [dbo].[PagoPolizas]  WITH CHECK ADD  CONSTRAINT [FK_PagoPolizas_PolizaDeSeguros] FOREIGN KEY([idPolizaDeSeguro])
REFERENCES [dbo].[PolizaDeSeguros] ([id])
GO
ALTER TABLE [dbo].[PagoPolizas] CHECK CONSTRAINT [FK_PagoPolizas_PolizaDeSeguros]
GO
ALTER TABLE [dbo].[PagoPolizas]  WITH CHECK ADD  CONSTRAINT [FK_PagoPolizas_vdPoliza1] FOREIGN KEY([idPolizaVd])
REFERENCES [dbo].[vdPoliza] ([id])
GO
ALTER TABLE [dbo].[PagoPolizas] CHECK CONSTRAINT [FK_PagoPolizas_vdPoliza1]
GO
ALTER TABLE [dbo].[PagoPolizas]  WITH CHECK ADD  CONSTRAINT [FK_PagoPolizas_vhPoliza] FOREIGN KEY([idPolizaVh])
REFERENCES [dbo].[vhPoliza] ([id])
GO
ALTER TABLE [dbo].[PagoPolizas] CHECK CONSTRAINT [FK_PagoPolizas_vhPoliza]
GO
ALTER TABLE [dbo].[Siniestro_Reclamos]  WITH CHECK ADD  CONSTRAINT [FK_Siniestro_Reclamos_emReclamos] FOREIGN KEY([id_emReclamo])
REFERENCES [dbo].[emReclamos] ([id])
GO
ALTER TABLE [dbo].[Siniestro_Reclamos] CHECK CONSTRAINT [FK_Siniestro_Reclamos_emReclamos]
GO
ALTER TABLE [dbo].[Siniestro_Reclamos]  WITH CHECK ADD  CONSTRAINT [FK_Siniestro_Reclamos_inReclamos] FOREIGN KEY([id_inReclamo])
REFERENCES [dbo].[inReclamos] ([id])
GO
ALTER TABLE [dbo].[Siniestro_Reclamos] CHECK CONSTRAINT [FK_Siniestro_Reclamos_inReclamos]
GO
ALTER TABLE [dbo].[Siniestro_Reclamos]  WITH CHECK ADD  CONSTRAINT [FK_Siniestro_Reclamos_Siniestros] FOREIGN KEY([id_Siniestro])
REFERENCES [dbo].[Siniestros] ([id])
GO
ALTER TABLE [dbo].[Siniestro_Reclamos] CHECK CONSTRAINT [FK_Siniestro_Reclamos_Siniestros]
GO
ALTER TABLE [dbo].[Siniestro_Reclamos]  WITH CHECK ADD  CONSTRAINT [FK_Siniestro_Reclamos_vdReclamos] FOREIGN KEY([id_vdReclamo])
REFERENCES [dbo].[vdReclamos] ([id])
GO
ALTER TABLE [dbo].[Siniestro_Reclamos] CHECK CONSTRAINT [FK_Siniestro_Reclamos_vdReclamos]
GO
ALTER TABLE [dbo].[Siniestro_Reclamos]  WITH CHECK ADD  CONSTRAINT [FK_Siniestro_Reclamos_vhReclamos] FOREIGN KEY([id_vhReclamo])
REFERENCES [dbo].[vhReclamos] ([id])
GO
ALTER TABLE [dbo].[Siniestro_Reclamos] CHECK CONSTRAINT [FK_Siniestro_Reclamos_vhReclamos]
GO
ALTER TABLE [dbo].[Siniestros]  WITH CHECK ADD  CONSTRAINT [FK_Siniestros_Cliente] FOREIGN KEY([id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Siniestros] CHECK CONSTRAINT [FK_Siniestros_Cliente]
GO
ALTER TABLE [dbo].[Siniestros]  WITH CHECK ADD  CONSTRAINT [FK_Siniestros_Empleado] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[Empleado] ([Id])
GO
ALTER TABLE [dbo].[Siniestros] CHECK CONSTRAINT [FK_Siniestros_Empleado]
GO
ALTER TABLE [dbo].[vdEvidencia]  WITH CHECK ADD  CONSTRAINT [FK_vdEvidencia_vdReclamos] FOREIGN KEY([id_vdReclamos])
REFERENCES [dbo].[vdReclamos] ([id])
GO
ALTER TABLE [dbo].[vdEvidencia] CHECK CONSTRAINT [FK_vdEvidencia_vdReclamos]
GO
ALTER TABLE [dbo].[vdPoliza]  WITH CHECK ADD  CONSTRAINT [FK_vdPoliza_Cliente] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[vdPoliza] CHECK CONSTRAINT [FK_vdPoliza_Cliente]
GO
ALTER TABLE [dbo].[vdPoliza]  WITH CHECK ADD  CONSTRAINT [FK_vdPoliza_PolizaDeSeguros] FOREIGN KEY([IdPolizaDeSeguro])
REFERENCES [dbo].[PolizaDeSeguros] ([id])
GO
ALTER TABLE [dbo].[vdPoliza] CHECK CONSTRAINT [FK_vdPoliza_PolizaDeSeguros]
GO
ALTER TABLE [dbo].[vdReclamos]  WITH CHECK ADD  CONSTRAINT [FK_vdReclamos_Cliente] FOREIGN KEY([id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[vdReclamos] CHECK CONSTRAINT [FK_vdReclamos_Cliente]
GO
ALTER TABLE [dbo].[vhEvidencia]  WITH CHECK ADD  CONSTRAINT [FK_vhEvidencia_vhReclamos] FOREIGN KEY([id_vhReclamos])
REFERENCES [dbo].[vhReclamos] ([id])
GO
ALTER TABLE [dbo].[vhEvidencia] CHECK CONSTRAINT [FK_vhEvidencia_vhReclamos]
GO
ALTER TABLE [dbo].[vhPoliza]  WITH CHECK ADD  CONSTRAINT [FK_vhPoliza_Cliente] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[vhPoliza] CHECK CONSTRAINT [FK_vhPoliza_Cliente]
GO
ALTER TABLE [dbo].[vhPoliza]  WITH CHECK ADD  CONSTRAINT [FK_vhPoliza_PolizaDeSeguros] FOREIGN KEY([IdPolizaDeSeguro])
REFERENCES [dbo].[PolizaDeSeguros] ([id])
GO
ALTER TABLE [dbo].[vhPoliza] CHECK CONSTRAINT [FK_vhPoliza_PolizaDeSeguros]
GO
ALTER TABLE [dbo].[vhReclamos]  WITH CHECK ADD  CONSTRAINT [FK_vhReclamos_Cliente] FOREIGN KEY([id_Cliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[vhReclamos] CHECK CONSTRAINT [FK_vhReclamos_Cliente]
GO
USE [master]
GO
ALTER DATABASE [AseguradoraBD] SET  READ_WRITE 
GO
