USE [master]
GO
/****** Object:  Database [AseguradoraBD]    Script Date: 23/11/2019 11:14:08 ******/
CREATE DATABASE [AseguradoraBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AseguradoraBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\AseguradoraBD.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AseguradoraBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\AseguradoraBD_log.ldf' , SIZE = 5824KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  StoredProcedure [dbo].[CancelarPoliza]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  StoredProcedure [dbo].[CargarId]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  StoredProcedure [dbo].[CargarNombreEmpleado]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  StoredProcedure [dbo].[CargarPolizasActivas]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[CargarPolizasActivas]
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
/****** Object:  StoredProcedure [dbo].[CargarPolizasDeSeguros]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[CargarPolizasDeSeguros]
as
select PS.id, PS.[Nombre del Seguro] from PolizaDeSeguros PS
GO
/****** Object:  StoredProcedure [dbo].[ComprobarAcceso]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  StoredProcedure [dbo].[CrearPoliza]    Script Date: 23/11/2019 11:14:08 ******/
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

insert into vdPoliza(Id_Cliente, Poliza, Estado,
FechaHora, Vencimiento) values (@IdCliente,@Poliza, @EstadoPoliza, @FechaHora, @Vencimiento)

END	

GO
/****** Object:  StoredProcedure [dbo].[EliminarCliente]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarCliente]
@Id int
as
delete from Cliente where id=@Id
GO
/****** Object:  StoredProcedure [dbo].[EliminarEmpleado]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarEmpleado]
@Id int
as
delete from Empleado where id=@Id

GO
/****** Object:  StoredProcedure [dbo].[em_MostrarPolizas]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[em_MostrarPolizas]
as
select * from emPoliza
GO
/****** Object:  StoredProcedure [dbo].[GuardarReclamo]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GuardarReclamo]
@IdCliente int,
@Siniestro int,
@Poliza int,
@ActaPolicial image,
@CopiaMatricula image,
@CopiaCedula image,
@Estado int,
@CostoEstimado decimal(18,2),
@FechaHora datetime
as
declare @Deducible decimal
set @Deducible = @CostoEstimado * 0.15

insert into vhReclamos(Id_Cliente, Siniestro, Poliza, [Acta Policial],
[Copia matricula], [Copia cedula], Estado, Deducible, [Costo estimado], FechaHora)
values (@IdCliente, @Siniestro, @Poliza, @ActaPolicial, @CopiaMatricula,
@CopiaCedula, @Estado, @Deducible, @CostoEstimado, @FechaHora)
GO
/****** Object:  StoredProcedure [dbo].[GuardarSiniestro]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  StoredProcedure [dbo].[in_MostrarPolizas]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[in_MostrarPolizas]
as
select * from inPoliza
GO
/****** Object:  StoredProcedure [dbo].[InsertarCliente]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  StoredProcedure [dbo].[InsertarEmpleado]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  StoredProcedure [dbo].[ModificarCliente]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  StoredProcedure [dbo].[ModificarEmpleado]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  StoredProcedure [dbo].[MostrarClientes]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MostrarClientes]
as
select * from Cliente

GO
/****** Object:  StoredProcedure [dbo].[MostrarEmpleados]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarEmpleados]
as
select * from Empleado


GO
/****** Object:  StoredProcedure [dbo].[MostrarSegurosDePolizas]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarSegurosDePolizas]
as
select * from PolizaDeSeguros
GO
/****** Object:  StoredProcedure [dbo].[MostrarSiniestros]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarSiniestros]
as
select * from Siniestros
GO
/****** Object:  StoredProcedure [dbo].[RenovacionPoliza]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  StoredProcedure [dbo].[vd_MostrarPolizas]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  StoredProcedure [dbo].[vh_MostrarPolizas]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[vh_MostrarPolizas]
as
select * from vhPoliza
GO
/****** Object:  Table [dbo].[CargoEmp]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[CategoriaPolizas]    Script Date: 23/11/2019 11:14:08 ******/
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
 CONSTRAINT [PK_CategoriaPolizas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cEstado]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[Cliente]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[ctEmpresasNegocios]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ctEmpresasNegocios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NULL,
	[id_Empleado] [int] NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[idEstado] [int] NOT NULL,
 CONSTRAINT [PK_ctEmpresasNegocios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ctMueblesInmuebles]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[ctVehiculo]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[ctVida]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[dependientesSeguroSalud]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[detalleEdificaciones]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleEdificaciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_ctMueblesInmuebles] [int] NULL,
	[Tipo de Vivienda] [varchar](50) NULL,
	[Situacion] [varchar](50) NULL,
	[Propietario] [nchar](4) NULL,
	[Vivienda habitual] [nchar](4) NULL,
	[Vivienda Alquilada] [nchar](4) NULL,
	[Codigo Postal] [varchar](50) NULL,
	[Deshabitada por mas de tres meses al ano] [nchar](4) NULL,
	[Ano de Construccion] [int] NULL,
	[M2 de la Vivienda] [varchar](50) NULL,
	[M2 de edificaciones anexas] [varchar](max) NULL,
	[Capital de otras instalaciones] [varchar](max) NULL,
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
/****** Object:  Table [dbo].[detalleSeguroContenido]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleSeguroContenido](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_ctMueblesInmuebles] [int] NULL,
	[Tipo de Vivienda] [varchar](50) NULL,
	[Situacion] [varchar](50) NULL,
	[Propietario] [nchar](4) NULL,
	[Vivienda habitual] [nchar](4) NULL,
	[Vivienda Alquilada] [nchar](4) NULL,
	[Codigo Postal] [varchar](50) NULL,
	[Tiempo deshabitada] [nchar](4) NULL,
	[Ano de Construccion] [int] NULL,
	[M2 de la Vivienda] [varchar](50) NULL,
	[Estado] [int] NOT NULL,
	[FechaHora] [datetime] NULL,
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
/****** Object:  Table [dbo].[detalleSeguroEmpresaNegocio]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleSeguroEmpresaNegocio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_ctEmpresasNegocios] [int] NULL,
	[Copia de los Estatutos] [image] NULL,
	[Copia Acta Asignacion RNC] [image] NULL,
	[Copia Cedula Presidente y Representante autorizado] [nchar](10) NULL,
	[Telefono de Entidad Autorizada] [varchar](30) NULL,
	[Correo electronico de Entidad Autorizada] [varchar](50) NULL,
	[Inspeccion del Local] [nchar](15) NULL,
	[Estado] [int] NOT NULL,
	[FechaHora] [date] NOT NULL,
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
/****** Object:  Table [dbo].[detalleSeguroObligatorio]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleSeguroObligatorio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_ctVehiculo] [int] NULL,
	[MarcaVehiculo] [varchar](50) NULL,
	[Modelo] [varchar](50) NULL,
	[Ano] [varchar](10) NULL,
	[Cilindros] [varchar](50) NULL,
	[Carroceria] [varchar](50) NULL,
	[Categoria] [varchar](50) NULL,
	[Uso] [varchar](50) NULL,
	[Nota] [nvarchar](max) NOT NULL,
	[Estado] [int] NOT NULL,
	[FechaHora] [datetime] NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SeguroObligatorio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalleSeguroRiesgoMuerte]    Script Date: 23/11/2019 11:14:08 ******/
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
 CONSTRAINT [PK_detalleSeguroRiesgoMuerte] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalleSeguroRiesgosLaborales]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[detalleSeguroSalud]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[detalleSeguroTodoRiesgo]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleSeguroTodoRiesgo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_ctVehiculo] [int] NULL,
	[Marca Vehiculo] [varchar](50) NULL,
	[Modelo] [varchar](50) NULL,
	[Ano] [varchar](10) NULL,
	[Cilindros] [varchar](50) NULL,
	[Carroceria] [varchar](50) NULL,
	[Categoria] [varchar](50) NULL,
	[Uso] [varchar](50) NULL,
	[Nota] [nvarchar](max) NULL,
	[Estado] [int] NOT NULL,
	[FechaHora] [datetime] NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SeguroTodoRiesgo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalleSeguroVoluntario]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[detalleSeguroVoluntario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[id_ctVehiculo] [int] NULL,
	[Marca de Vehiculo] [varchar](50) NULL,
	[Modelo] [varchar](50) NULL,
	[Ano] [varchar](10) NULL,
	[Cilindros] [varchar](50) NULL,
	[Carrocería] [varchar](50) NULL,
	[Categoria] [varchar](50) NULL,
	[Uso] [varchar](50) NULL,
	[Nota] [nvarchar](max) NULL,
	[Estado] [int] NOT NULL,
	[FechaHora] [datetime] NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Devoluciones]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Devoluciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NOT NULL,
	[id_Solicitud] [int] NOT NULL,
	[id_Poliza] [int] NULL,
	[A Devolver] [decimal](18, 2) NOT NULL,
	[Motivo] [varchar](max) NOT NULL,
	[FechaHora] [datetime] NOT NULL,
 CONSTRAINT [PK_Devoluciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[emEvidencia]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[Empleado]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[emPoliza]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[EmpSeguroRiesgosLaborales]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmpSeguroRiesgosLaborales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_detalleSeguroRiesgosLab] [int] NULL,
	[Nomina Empleado] [image] NULL,
	[Carta de Solicitud Repres y Prop] [image] NULL,
	[Copia Cedula Propietario] [image] NULL,
	[Copia Cedula Representante] [image] NULL,
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
/****** Object:  Table [dbo].[emReclamos]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emReclamos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NOT NULL,
	[Siniestro] [int] NOT NULL,
	[Poliza] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Facturas]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[imagenesCotenidoInspSeguroEmpresas]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[imagenesCotenidoInspSeguroEmpresas](
	[id] [int] NOT NULL,
	[Imagen] [image] NULL,
	[id_detallesSeguroEmpresasN] [int] NULL,
 CONSTRAINT [PK_imagenesCotenidoInspSeguroEmpresas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[inEvidencia]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inEvidencia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Imagen] [image] NOT NULL,
	[id_inReclamos] [int] NOT NULL,
 CONSTRAINT [PK_inEvidencia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[inPoliza]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[inReclamos]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inReclamos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NOT NULL,
	[Siniestro] [int] NOT NULL,
	[Poliza] [int] NOT NULL,
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
/****** Object:  Table [dbo].[PagoPolizas]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[PolizaDeSeguros]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[Siniestro_Reclamos]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[Siniestros]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[vdEvidencia]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vdEvidencia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Imagen] [image] NOT NULL,
	[id_vdReclamos] [int] NOT NULL,
 CONSTRAINT [PK_vdEvidencia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vdPoliza]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[vdReclamos]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vdReclamos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NOT NULL,
	[Siniestro] [int] NOT NULL,
	[Poliza] [int] NOT NULL,
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
/****** Object:  Table [dbo].[vhEvidencia]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vhEvidencia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Imagen] [image] NULL,
	[id_vhReclamos] [int] NOT NULL,
 CONSTRAINT [PK_vhEvidencia_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[vhPoliza]    Script Date: 23/11/2019 11:14:08 ******/
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
/****** Object:  Table [dbo].[vhReclamos]    Script Date: 23/11/2019 11:14:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vhReclamos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_Cliente] [int] NOT NULL,
	[Siniestro] [int] NOT NULL,
	[Poliza] [int] NOT NULL,
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
SET IDENTITY_INSERT [dbo].[CargoEmp] ON 

INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (1, N'Servicio al cliente')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (2, N'Gerente')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (3, N'Emisor de Póliza')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (4, N'Digitador')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (5, N'Agente de Negocio')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (6, N'Administrador Contable')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (7, N'Sub Gerente')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (8, N'Presidente')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (9, N'Secretario')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (10, N'Analista de políticas')
INSERT [dbo].[CargoEmp] ([id], [Cargo]) VALUES (12, N'')
SET IDENTITY_INSERT [dbo].[CargoEmp] OFF
SET IDENTITY_INSERT [dbo].[CategoriaPolizas] ON 

INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria]) VALUES (1, 1, N'Básico')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria]) VALUES (2, 1, N'Semi Full')
INSERT [dbo].[CategoriaPolizas] ([id], [id_SeguroPoliza], [Categoria]) VALUES (3, 1, N'Full')
SET IDENTITY_INSERT [dbo].[CategoriaPolizas] OFF
SET IDENTITY_INSERT [dbo].[cEstado] ON 

INSERT [dbo].[cEstado] ([idEstado], [Validacion], [Estado]) VALUES (1, N'Activo', N'Aceptada')
INSERT [dbo].[cEstado] ([idEstado], [Validacion], [Estado]) VALUES (2, N'Inactivo', N'Rechazada')
INSERT [dbo].[cEstado] ([idEstado], [Validacion], [Estado]) VALUES (3, N'Eliminado', N'En proceso')
SET IDENTITY_INSERT [dbo].[cEstado] OFF
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (1, N'Juan', N'Pelao', N'Centro del Hogar', N'324-2332143-4', N'Peruana', N'42134', N'asdasd@sdf', N'M', N'3', CAST(0x0000AAF8000E9C57 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (3, N'Fulanito', N'deTal', N'Perensejo Esq. mirador #6', N'123-1231232-1', N'Mexicana', N'809-555-5555', N'EstadosCiviles@outlook.com', N'M', N'1', CAST(0x0000AAF8000EC35E AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (5, N'Luis', N'Peña', N'Britolito', N'234-3242342-3', N'cubana', N'354354', N'asasdfs@qwewqe', N'M', N'3425534', CAST(0x0000AAF800122E56 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (6, N'CPU', N'Z', N'qsdfsf', N'123-1232321-2', N'qweasd', N'21313', N'sadasd@asdasd', N'F', N'2323', CAST(0x0000AAF8001279C9 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (7, N'asd', N'e2', N'qweq', N'123-1232321-2', N'qweasd', N'21313', N'sadasd@asdasd', N'F', N'123', CAST(0x0000AAF800E09B8C AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (8, N'ergb', N'456', N'qweq', N'123-1232321-2', N'qweasd', N'dfh', N'wa4tasd@asdasd', N'F', N'687', CAST(0x0000AAF8001293EE AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (9, N'ergb', N'456', N'qweq', N'123-1232321-2', N'32432', N'dfh', N'wa4tasd@asdasd', N'F', N'687', CAST(0x0000AAF800129AB0 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (12, N'ghj', N'ghj', N'3434', N'121-2312   -', N'gf', N'324', N'fg', N'M', N'ghj', CAST(0x0000AAF800E0CA2D AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (13, N'Pedro', N'Kuchno', N'ASeneamiento', N'657-4546546-5', N'Polaco', N'(829)-686-8999', N'pioterelPio@gmail.com', N'M', N'46546546', CAST(0x0000AB030165964C AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (14, N'asdasd', N'asdasd', N'aq2eqwd', N'   -  21231-2', N'qadsd', N'(231)-231-2123', N'qwedas', N'M', N'21323', CAST(0x0000AB03018A711E AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (15, N'Panelope', N'Mansano', N'sdasdqewqwe', N'131-2312313-2', N'sadfsgasg', N'(123)-413-2423', N'erfwaert', N'M', N'234234234', CAST(0x0000AB040007FCC2 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (16, N'qwe', N'qwe', N'qwe', N'qwe', N'qwe', N'qwe', N'qwe', N'q', N'qwe', CAST(0x0000AB2100000000 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (17, N'qwe', N'qwe', N'qwe', N'qwe', N'qwe', N'qwe', N'qwe', N'q', N'qwe', CAST(0x0000AB2100000000 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (18, N'maniga', N'qwe', N'qwe', N'qwe', N'qwe', N'qwe', N'qwe', N'q', N'qwe', CAST(0x0000AB2100000000 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (19, N'awdasd', N'asdsad', N'asdasd', N'132-1321231-2', N'asdasdasd', N'(132)-123-1231', N'asdqwdasd', N'M', N'31123', CAST(0x0000AB04001CE724 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (20, N'qwe', N'qwe', N'qwe1', N'231-2312312-3', N'weqwe', N'(123)-123-1232', N'qweqw', N'M', N'', CAST(0x0000AB04001DCB96 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (21, N'qwe', N'qwe', N'qwe1', N'231-2312312-3', N'weqwe', N'(123)-123-1232', N'qweqw', N'M', N'qwe', CAST(0x0000AB04001DD6B1 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (22, N'qwe', N'qweqwe', N'qweqwe', N'234-2342342-3', N'wrwer', N'(234)-234-2342', N'werwer', N'M', N'', CAST(0x0000AB04001FA936 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (23, N'qwe', N'qweqwe', N'qweqwe', N'234-2342342-3', N'wrwer', N'(234)-234-2342', N'werwer', N'M', N'', CAST(0x0000AB04001FA936 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (24, N'qewrt', N'ewrt', N'2ewrwqe', N'123-4321423-4', N'erwere', N'(234)-234-2342', N'qwerwer', N'M', N'', CAST(0x0000AB0400238406 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (25, N'asdfasdf', N'243rterg', N'4wtfgerga', N'234-2342342-3', N'thgdfh', N'(345)-345-3453', N'ersgtsert', N'M', N'', CAST(0x0000AB040023D38B AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (26, N'xdvsv', N'xcv', N'zxcvxzcv', N'   -234423 -', N'234aw', N'(   )-   -   2', N'sdfsdf', N'M', N'qwe2', CAST(0x0000AB0400A57FEC AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (27, N'sadas', N'asd', N'asd', N'  1-234    -', N'q34r', N'(   )-234-', N'ewr', N'F', N'wqer', CAST(0x0000AB0400A8295B AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (28, N'asdd', N'asd', N'asd', N' 23-4234   -', N'asf', N'( 23)-423-42', N'qwer', N'M', N'23rwer', CAST(0x0000AB0400AE226B AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (29, N'asd', N'asd', N'asdasd', N' 34-3453453-2', N'weqr23', N'(345)-345-3453', N'rewatert', N'M', N'', CAST(0x0000AB0400CFD6EE AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (30, N'Nahum', N'Matos Matos', N'Jaquimelles City', N'402-2809228-0', N'dominicana', N'(849)-785-256', N'nahumelfuerte@hotmailcom', N'M', N'', CAST(0x0000AB050102A5BD AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (31, N'asd', N'asd', N'asd', N'234-2312312-2', N'dominicana', N'(123)-112-3132', N'qwe', N'M', N'', CAST(0x0000AB05017DDB7B AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (32, N'Onesimo', N'Estrella', N'Sanchez #13', N'234-2343243-2', N'extranjera', N'(234)-234-2342', N'Caewqe@Hotmail.com', N'M', N'', CAST(0x0000AB05017E1610 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (33, N'PAran', N'Love', N'asdfasf', N'234-124    -', N'extranjera', N'(234)-234-', N'qwe', N'M', N'', CAST(0x0000AB05017E2F43 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (34, N'qweqwe', N'qweqwe', N'qweqwe', N'213-1231   -', N'dominicana', N'(123)-123-32', N'123123', N'M', N'', CAST(0x0000AB050185A03F AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (35, N'', N'', N'', N'-       -', N'', N'(   )-   -', N'', N'', N'', CAST(0x0000AB050186912E AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (36, N'Eliezer', N'Montero', N'Calle El Derricadero #10', N'231-4232342-3', N'dominicana', N'(234)-234-2342', N'EliezerElMan@hotmail.com', N'M', N'', CAST(0x0000AB06011601F9 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (37, N'Gregory', N'ASd', N'hglkjh', N'234-2342342-3', N'extranjera', N'(234)-234-2234', N'asasd%^Y45ysad', N'M', N'', CAST(0x0000AB06012C4534 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (38, N'sds', N'sd', N'sd', N'112-1212121-2', N'dominicana', N'(121)-212-121', N'222', N'M', N'', CAST(0x0000AB060169FE05 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (39, N'qwe', N'qwe', N'qwe', N'123-1231231-2', N'dominicana', N'(123)-123-123', N'23', N'F', N'', CAST(0x0000AB06016A264D AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (40, N'dasda', N'asdasd', N'asdasd', N'123-1231233-', N'dominicana', N'(333)-333-3333', N'232323', N'F', N'2', CAST(0x0000AB06016A5E29 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (41, N'dca', N'jhh', N'ihuiu', N'342-4234234-', N'dominicana', N'(234)-234-234', N'3434', N'M', N'', CAST(0x0000AB060170C0C1 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (42, N'dsasd', N'asd', N'asd', N'123-1242342-3', N'dominicana', N'(234)-234-2342', N'234', N'M', N'', CAST(0x0000AB0601712927 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (43, N'rtyrt', N'rty', N'456', N'234-2342342-2', N'dominicana', N'(234)-234-2343', N'23rewf', N'M', N'', CAST(0x0000AB0601719315 AS DateTime))
INSERT [dbo].[Cliente] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Nacionalidad], [Telefono], [Correo Electronico], [Sexo], [RNC], [FechaHora]) VALUES (44, N'Isabel', N'Perez Berroa', N'Ecuartillos el Man', N'123-1231231-2', N'dominicana', N'(343)-434-2234', N'sdfsdff@gmail.com', N'M', N'qweqwe', CAST(0x0000AB0A01573CFA AS DateTime))
SET IDENTITY_INSERT [dbo].[Cliente] OFF
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
SET IDENTITY_INSERT [dbo].[ctVida] OFF
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
SET IDENTITY_INSERT [dbo].[detalleSeguroSalud] OFF
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (1, N'Javier', N'Perez Cuevas', N'Calle Benjamin Matos #4', N'402-1509373-9', N'8496371170', N'Robert003-@hotmail.com', 1, N'M', CAST(0x4B400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (3, N'ASDASD', N'ASD', N'ASDASD', N'123-1231213-1', N'123123213', N'QADSASD', 1, N'F', CAST(0x4B400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (4, N'Francisco', N'Peña Suaso', N'Los Rios de Venezuela', N'123-1231213-1', N'5525', N'MeGustaElVerde@Mucho.com', 1, N'M', CAST(0x4C400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (5, N'Fulanito', N'De Tal', N'780', N'123-1231231-2', N'456456', N'PerezPerez', 1, N'M', CAST(0x53400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (8, N'Nahum', N'Matoss', N'Jaquimelles', N'224-3236467-5', N'32423463', N'Nahummatos@Gmail.com', 2, N'F', CAST(0x53400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (9, N'Gaby', N'Perez', N'Pley Grande #14', N'686-8656565-6', N'6565656', N'ewfweasd@asiEs.ORg', 2, N'F', CAST(0x4C400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (10, N'Rodrigo', N'De triana', N'El Jaimito 23 esq. duarte #14', N'686-8656565-6', N'6565656', N'ewfweasd@asiEs.ORg', 2, N'M', CAST(0x4C400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (13, N'ad', N'ad', N'', N'   -       -', N'', N'', 1, N'M', CAST(0x53400B00 AS Date))
INSERT [dbo].[Empleado] ([Id], [Nombre], [Apellido], [Direccion], [Cedula], [Telefono], [Correo Electronico], [idCargo], [Sexo], [Fecha]) VALUES (14, N'asd', N'asd', N'asd', N'223-       -', N'324', N'asd', 1, N'M', CAST(0x53400B00 AS Date))
SET IDENTITY_INSERT [dbo].[Empleado] OFF
SET IDENTITY_INSERT [dbo].[PagoPolizas] ON 

INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (1, 32, 1, 5, 3, NULL, NULL, NULL, CAST(0x0000AB0B017F5701 AS DateTime), CAST(90000.00 AS Decimal(18, 2)), CAST(90000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (2, 44, 1, 1, 9, NULL, NULL, NULL, CAST(0x0000AB0B017F93D4 AS DateTime), CAST(80000.00 AS Decimal(18, 2)), CAST(80000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (3, 36, 1, 2, 7, NULL, NULL, NULL, CAST(0x0000AB0B0180F681 AS DateTime), CAST(100000.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (4, 1, 1, 2, 2, NULL, NULL, NULL, CAST(0x0000AB0B01813009 AS DateTime), CAST(100000.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (5, 31, 1, 1, 4, NULL, NULL, NULL, CAST(0x0000AB0B01813497 AS DateTime), CAST(80000.00 AS Decimal(18, 2)), CAST(80000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (7, 36, 1, 2, 7, NULL, NULL, NULL, CAST(0x0000AB0B018AC429 AS DateTime), CAST(100000.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[PagoPolizas] ([id], [id_Cliente], [id_Empleado], [idPolizaDeSeguro], [idPolizaVd], [idPolizaEm], [idPolizaVh], [idPolizaIn], [FechaHora], [Precio], [T_Pago], [Pago Parcial], [Nota]) VALUES (8, 36, 1, 2, 7, NULL, NULL, NULL, CAST(0x0000AB0C001822E3 AS DateTime), CAST(100000.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
SET IDENTITY_INSERT [dbo].[PagoPolizas] OFF
SET IDENTITY_INSERT [dbo].[PolizaDeSeguros] ON 

INSERT [dbo].[PolizaDeSeguros] ([id], [Nombre del Seguro], [Area], [Descripcion], [Precio], [Fecha]) VALUES (1, N'Seguro a Todo Riesgo', N'Vehiculo', N'.kjdsfgkljhgjssrdjgrshjfhdljvrtgj hdrgfrlekuthdsaflkjgshlgsjgjkshfdgkjfdghkjsjgkrtbhkjs;lerkmgrstlg  kjh hjlkj  hhj fgkjbfdkvf b jbk hj hj n gkh vhj vhj ', CAST(80000.00 AS Decimal(18, 2)), CAST(0x60400B00 AS Date))
INSERT [dbo].[PolizaDeSeguros] ([id], [Nombre del Seguro], [Area], [Descripcion], [Precio], [Fecha]) VALUES (2, N'Seguro de Salud', N'Vida', N'li4wkjrew;lkjerhlkwjerhtlkejrgtkrelhgklurehgkrlejt hklrje hlkre hglkretg lkrehgrlke hjrelk gjrelkgt jrkt jrelk tjrlekt jl;rektj hkhtj ;l hjle''rk hjtlh tl;kt m', CAST(100000.00 AS Decimal(18, 2)), CAST(0xBB3F0B00 AS Date))
INSERT [dbo].[PolizaDeSeguros] ([id], [Nombre del Seguro], [Area], [Descripcion], [Precio], [Fecha]) VALUES (5, N'Seguro Riesgos Laborales', N'Vida', N'lkewjrf;elrkjelrk;jgre;ohjoehjtlreknblkrentb;klrntb;lwkreng;lwreknb;lwrknb;lwrkng;lwrekng;lrewkbn;lkresgn;lerwknbl;reknbl;rskenbl;re;lfdksmbl;mb;lfskbml''fksmb;lfkmblbgmrl;kbnmrl;gbknrlknrl;ktnhr;lkhnbl;fdkbml;kfm', CAST(90000.00 AS Decimal(18, 2)), CAST(0x853F0B00 AS Date))
SET IDENTITY_INSERT [dbo].[PolizaDeSeguros] OFF
SET IDENTITY_INSERT [dbo].[Siniestro_Reclamos] ON 

INSERT [dbo].[Siniestro_Reclamos] ([id], [id_Siniestro], [id_vhReclamo], [id_vdReclamo], [id_inReclamo], [id_emReclamo]) VALUES (1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Siniestro_Reclamos] ([id], [id_Siniestro], [id_vhReclamo], [id_vdReclamo], [id_inReclamo], [id_emReclamo]) VALUES (2, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Siniestro_Reclamos] ([id], [id_Siniestro], [id_vhReclamo], [id_vdReclamo], [id_inReclamo], [id_emReclamo]) VALUES (3, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[Siniestro_Reclamos] ([id], [id_Siniestro], [id_vhReclamo], [id_vdReclamo], [id_inReclamo], [id_emReclamo]) VALUES (4, 4, NULL, NULL, NULL, NULL)
INSERT [dbo].[Siniestro_Reclamos] ([id], [id_Siniestro], [id_vhReclamo], [id_vdReclamo], [id_inReclamo], [id_emReclamo]) VALUES (5, 5, NULL, NULL, NULL, NULL)
INSERT [dbo].[Siniestro_Reclamos] ([id], [id_Siniestro], [id_vhReclamo], [id_vdReclamo], [id_inReclamo], [id_emReclamo]) VALUES (6, 6, NULL, NULL, NULL, NULL)
INSERT [dbo].[Siniestro_Reclamos] ([id], [id_Siniestro], [id_vhReclamo], [id_vdReclamo], [id_inReclamo], [id_emReclamo]) VALUES (7, 7, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Siniestro_Reclamos] OFF
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
SET IDENTITY_INSERT [dbo].[Siniestros] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id], [NombreUsuario], [Contrasena], [Privilegio], [Fecha]) VALUES (1, N'RVM', N'03dea', N'nocturno', CAST(0xC73A0B00 AS Date))
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
SET IDENTITY_INSERT [dbo].[vdPoliza] ON 

INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (1, 1, 1, N'lkuewrs', 2, CAST(0x0000AB0C0013EEF5 AS DateTime), CAST(0xAB410B00 AS Date), N'')
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (2, 1, 2, N'ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfgdghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf324-2332143-4ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg2dghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf100000.00aslkdfj;slarjgs;lgkfdhj;lfdkhgjfdl;khfdhj;lfdhj;ldfkhjl;kdfhj;lkdfhkdfhkdfhglkdfjhsldkfjgsdhj;ldkfjgl;fdkhj;lfj;lfdhj;lfdhj;lfdhj;lkfdhj;lfdhj;lkfdhj;lfdhjl;dkfjh', 3, CAST(0x0000AB0B01813009 AS DateTime), CAST(0x66400B00 AS Date), NULL)
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (3, 32, 5, N'ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfgdghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf234-2343243-2ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg3dghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf90000.00aslkdfj;slarjgs;lgkfdhj;lfdkhgjfdl;khfdhj;lfdhj;ldfkhjl;kdfhj;lkdfhkdfhkdfhglkdfjhsldkfjgsdhj;ldkfjgl;fdkhj;lfj;lfdhj;lfdhj;lfdhj;lkfdhj;lfdhj;lkfdhj;lfdhjl;dkfjh', 3, CAST(0x0000AB0B017F5701 AS DateTime), CAST(0x66400B00 AS Date), NULL)
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (4, 31, 1, N'ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfgdghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf234-2312312-2ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg4dghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf80000.00aslkdfj;slarjgs;lgkfdhj;lfdkhgjfdl;khfdhj;lfdhj;ldfkhjl;kdfhj;lkdfhkdfhkdfhglkdfjhsldkfjgsdhj;ldkfjgl;fdkhj;lfj;lfdhj;lfdhj;lfdhj;lkfdhj;lfdhj;lkfdhj;lfdhjl;dkfjh', 2, CAST(0x0000AB0B01813497 AS DateTime), CAST(0x66400B00 AS Date), NULL)
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (5, 36, 5, N'ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfgdghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf231-4232342-3ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg5dghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf90000.00aslkdfj;slarjgs;lgkfdhj;lfdkhgjfdl;khfdhj;lfdhj;ldfkhjl;kdfhj;lkdfhkdfhkdfhglkdfjhsldkfjgsdhj;ldkfjgl;fdkhj;lfj;lfdhj;lfdhj;lfdhj;lkfdhj;lfdhj;lkfdhj;lfdhjl;dkfjh', 2, CAST(0x0000AB0B017A8B9F AS DateTime), CAST(0x66400B00 AS Date), NULL)
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (6, 37, 1, N'ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfgdghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf234-2342342-3ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg6dghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf80000.00aslkdfj;slarjgs;lgkfdhj;lfdkhgjfdl;khfdhj;lfdhj;ldfkhjl;kdfhj;lkdfhkdfhkdfhglkdfjhsldkfjgsdhj;ldkfjgl;fdkhj;lfj;lfdhj;lfdhj;lfdhj;lkfdhj;lfdhj;lkfdhj;lfdhjl;dkfjh', 2, CAST(0x0000AB0B017940F9 AS DateTime), CAST(0x66400B00 AS Date), NULL)
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (7, 36, 2, N'ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfgdghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf231-4232342-3ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg7dghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf100000.00aslkdfj;slarjgs;lgkfdhj;lfdkhgjfdl;khfdhj;lfdhj;ldfkhjl;kdfhj;lkdfhkdfhkdfhglkdfjhsldkfjgsdhj;ldkfjgl;fdkhj;lfj;lfdhj;lfdhj;lfdhj;lkfdhj;lfdhj;lkfdhj;lfdhjl;dkfjh', 1, CAST(0x0000AB0C001822E3 AS DateTime), CAST(0x67400B00 AS Date), N'')
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (8, 37, 2, N'ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfgdghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf234-2342342-3ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg8dghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf100000.00aslkdfj;slarjgs;lgkfdhj;lfdkhgjfdl;khfdhj;lfdhj;ldfkhjl;kdfhj;lkdfhkdfhkdfhglkdfjhsldkfjgsdhj;ldkfjgl;fdkhj;lfj;lfdhj;lfdhj;lfdhj;lkfdhj;lfdhj;lkfdhj;lfdhjl;dkfjh', 2, CAST(0x0000AB0C0014F80B AS DateTime), CAST(0x66400B00 AS Date), N'')
INSERT [dbo].[vdPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (9, 44, 1, N'ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfgdghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf123-1231231-2ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg9dghdr;oghkdr''tlkhe;lhtrd;lhter'';tlkhret;lkher;hk;erhtdr''lkhdf;lh,gdl,hdf;''h;lgdf80000.00aslkdfj;slarjgs;lgkfdhj;lfdkhgjfdl;khfdhj;lfdhj;ldfkhjl;kdfhj;lkdfhkdfhkdfhglkdfjhsldkfjgsdhj;ldkfjgl;fdkhj;lfj;lfdhj;lfdhj;lfdhj;lkfdhj;lfdhj;lkfdhj;lfdhjl;dkfjh', 2, CAST(0x0000AB0C00183674 AS DateTime), CAST(0x66400B00 AS Date), N'')
SET IDENTITY_INSERT [dbo].[vdPoliza] OFF
SET IDENTITY_INSERT [dbo].[vhPoliza] ON 

INSERT [dbo].[vhPoliza] ([id], [Id_Cliente], [IdPolizaDeSeguro], [Poliza], [Estado], [FechaHora], [Vencimiento], [Nota]) VALUES (1, 1, 5, N'wer[oiueproijt', 1, CAST(0x0000A9C800533B08 AS DateTime), CAST(0xBA3F0B00 AS Date), NULL)
SET IDENTITY_INSERT [dbo].[vhPoliza] OFF
SET IDENTITY_INSERT [dbo].[vhReclamos] ON 

INSERT [dbo].[vhReclamos] ([id], [id_Cliente], [Siniestro], [Poliza], [Acta Policial], [Copia matricula], [Copia cedula], [Estado], [Deducible], [Costo estimado], [FechaHora]) VALUES (3, 1, 1, 1, NULL, NULL, NULL, 1, CAST(11.00 AS Decimal(18, 2)), NULL, CAST(0x0000AB2100000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[vhReclamos] OFF
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
ALTER TABLE [dbo].[Devoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Devoluciones_ctEmpresasNegocios] FOREIGN KEY([id_Solicitud])
REFERENCES [dbo].[ctEmpresasNegocios] ([id])
GO
ALTER TABLE [dbo].[Devoluciones] CHECK CONSTRAINT [FK_Devoluciones_ctEmpresasNegocios]
GO
ALTER TABLE [dbo].[Devoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Devoluciones_ctMueblesInmuebles] FOREIGN KEY([id_Solicitud])
REFERENCES [dbo].[ctMueblesInmuebles] ([id])
GO
ALTER TABLE [dbo].[Devoluciones] CHECK CONSTRAINT [FK_Devoluciones_ctMueblesInmuebles]
GO
ALTER TABLE [dbo].[Devoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Devoluciones_ctVehiculo] FOREIGN KEY([id_Solicitud])
REFERENCES [dbo].[ctVehiculo] ([id])
GO
ALTER TABLE [dbo].[Devoluciones] CHECK CONSTRAINT [FK_Devoluciones_ctVehiculo]
GO
ALTER TABLE [dbo].[Devoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Devoluciones_ctVida] FOREIGN KEY([id_Solicitud])
REFERENCES [dbo].[ctVida] ([id])
GO
ALTER TABLE [dbo].[Devoluciones] CHECK CONSTRAINT [FK_Devoluciones_ctVida]
GO
ALTER TABLE [dbo].[Devoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Devoluciones_emPoliza] FOREIGN KEY([id_Poliza])
REFERENCES [dbo].[emPoliza] ([id])
GO
ALTER TABLE [dbo].[Devoluciones] CHECK CONSTRAINT [FK_Devoluciones_emPoliza]
GO
ALTER TABLE [dbo].[Devoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Devoluciones_inPoliza] FOREIGN KEY([id_Poliza])
REFERENCES [dbo].[inPoliza] ([id])
GO
ALTER TABLE [dbo].[Devoluciones] CHECK CONSTRAINT [FK_Devoluciones_inPoliza]
GO
ALTER TABLE [dbo].[Devoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Devoluciones_vdPoliza] FOREIGN KEY([id_Poliza])
REFERENCES [dbo].[vdPoliza] ([id])
GO
ALTER TABLE [dbo].[Devoluciones] CHECK CONSTRAINT [FK_Devoluciones_vdPoliza]
GO
ALTER TABLE [dbo].[Devoluciones]  WITH CHECK ADD  CONSTRAINT [FK_Devoluciones_vhPoliza] FOREIGN KEY([id_Poliza])
REFERENCES [dbo].[vhPoliza] ([id])
GO
ALTER TABLE [dbo].[Devoluciones] CHECK CONSTRAINT [FK_Devoluciones_vhPoliza]
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
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_ctEmpresasNegocios] FOREIGN KEY([id_Solicitud])
REFERENCES [dbo].[ctEmpresasNegocios] ([id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_ctEmpresasNegocios]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_ctMueblesInmuebles] FOREIGN KEY([id_Solicitud])
REFERENCES [dbo].[ctMueblesInmuebles] ([id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_ctMueblesInmuebles]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_ctVehiculo] FOREIGN KEY([id_Solicitud])
REFERENCES [dbo].[ctVehiculo] ([id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_ctVehiculo]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_ctVida] FOREIGN KEY([id_Solicitud])
REFERENCES [dbo].[ctVida] ([id])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_ctVida]
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
