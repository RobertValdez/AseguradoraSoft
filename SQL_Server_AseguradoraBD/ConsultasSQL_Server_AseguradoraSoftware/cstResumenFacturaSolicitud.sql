



use AseguradoraBD

go


alter proc CrearSolicitud

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


go

alter proc CrearSolicitudSeguroEdificaciones

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
      

	  go
	  
alter proc CrearSolicitudSeguroContenido

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
      




	go


	
alter proc CrearSolicitudSeguroVEH_Voluntario

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
go


	  
alter proc CrearSolicitudSeguroVEH_TodoRiesgo

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

go
	  
	  
alter proc CrearSolicitudSeguroVEH_Obligatorio

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
