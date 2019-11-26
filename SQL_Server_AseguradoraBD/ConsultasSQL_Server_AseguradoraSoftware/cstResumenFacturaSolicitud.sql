



use AseguradoraBD

go

alter proc CrearSolicitud

@IdCliente int,

@idEmpleado int,
@Total decimal(18,2),
@Estado_ctEmpresasNegocios int,         
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
values (@IdCliente, @idEmpleado, @Total, @Estado_ctEmpresasNegocios, @FechaHora)


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


--		@NombreEmpresa varchar(80),
--		@CopiaEstatutos image,
--	@CopiaActaAsignacionRNC image,
--	@CopiaCedulaPres_RepreAut image,
--	@TelefonoEntAutorizada varchar(30),
--@CorreoElectronicoEntAutorizada varchar(50),
--@InspeccionLocal varchar(50),
--@Estado int,
--@FechaHora datetime,
--@Tipo varchar(50)


      --[id_ctEmpresasNegocios]
     -- ,[Nombre Empresa]
    --  ,[Copia de los Estatutos]
      --,[Copia Acta Asignacion RNC]
      --,[Copia Cedula Presidente y Representante autorizado]
     -- ,[Telefono de Entidad Autorizada]
     -- ,[Correo electronico de Entidad Autorizada]
      --,[Inspeccion del Local]
    --  ,[Estado]
     --,[FechaHora]
     --,[Nota]
 --     ,[Tipo]