



use AseguradoraBD

go

alter proc CrearSolicitud

@IdCliente int,

@idEmpleado int,
@Total decimal(18,2),       
@Fecha date,		

----------------
 
@NombreEmpresa varchar(80),
@CopiaEstatutos image,
@CopiaActaAsignacionRNC image,
@CopiaCedulaPres_RepreAut image,
@TelefonoEntAutorizada varchar(30),
@CorreoElectronicoEntAutorizada varchar(50),

@FechaHora datetime,
@Tipo varchar(50),

---------------------
@Imagen1 image,
@Imagen2 image,
@Imagen3 image,
@Imagen4 image,
@Imagen5 image
as

insert into ctEmpresasNegocios(id_Cliente, id_Empleado, Total, idEstado, Fecha)
values (@IdCliente, @idEmpleado, @Total, 3, @FechaHora)


declare @id_ctEmpresasNegocios int
set @id_ctEmpresasNegocios = SCOPE_IDENTITY()

insert into detalleSeguroEmpresaNegocio(id_ctEmpresasNegocios, [Nombre Empresa],
[Copia de los Estatutos], [Copia Acta Asignacion RNC], [Copia Cedula Presidente y Representante autorizado]
, [Telefono de Entidad Autorizada], [Correo electronico de Entidad Autorizada], [Inspeccion del Local]
, [Estado], [FechaHora], [Tipo]) values (@id_ctEmpresasNegocios,
@NombreEmpresa, @CopiaEstatutos, @CopiaActaAsignacionRNC, @CopiaCedulaPres_RepreAut, @TelefonoEntAutorizada,
 @CorreoElectronicoEntAutorizada, 'Pendiente', 3, @FechaHora, @Tipo)

insert into imagenesCotenidoInspSeguroEmpresas(id_detallesSeguroEmpresasN, Imagen)
 values (@id_ctEmpresasNegocios, @Imagen1),
		(@id_ctEmpresasNegocios, @Imagen2),
		(@id_ctEmpresasNegocios, @Imagen3),
		(@id_ctEmpresasNegocios, @Imagen4),
		(@id_ctEmpresasNegocios, @Imagen5)


go

create proc CrearSolicitudSeguroEdificaciones

@IdCliente int,

@idEmpleado int,
@Total decimal(18,2),       
@Fecha date,		
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
      ,[FechaHora]
      ,[Tipo]) values (@id_ctMueblesInmuebles,
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
	@FechaHora,
	@Tipo)


      

