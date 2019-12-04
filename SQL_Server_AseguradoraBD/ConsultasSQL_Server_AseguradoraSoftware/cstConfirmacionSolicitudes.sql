


use AseguradoraBD

go

alter proc MostrarDetalleSeguroVoluntario
as
select C.Id as "Id Cliente", dSV.id_ctVehiculo as "Id Solicitud", C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Marca de Vehiculo], dSV.Modelo, dSV.Matricula,
dSV.Ano as "Año", dSV.Cilindros, dSV.Carroceria, dSV.Categoria, dSV.Uso, dSV.Nota, dSV.id_ctVehiculo as "Id Solicitud",cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleSeguroVoluntario dSV on ctv.id = dSV.id_ctVehiculo join cEstado cE on dSV.Estado = cE.idEstado

 go
 
alter proc MostrarDetalleSeguroTodoRiesgo
as
select C.Id, C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Marca de Vehiculo], dSV.Modelo, dSV.Matricula,
dSV.Ano as "Año", dSV.Cilindros, dSV.Carroceria, dSV.Categoria, dSV.Uso, dSV.id_ctVehiculo as "Id Solicitud", dSV.Nota, cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleSeguroTodoRiesgo dSV on ctv.id = dSV.id_ctVehiculo join cEstado cE on dSV.Estado = cE.idEstado

 go

 alter proc MostrarDetalleSeguroObligatorio
as
select C.Id, C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Marca de Vehiculo], dSV.Modelo, dSV.Matricula,
dSV.Ano as "Año", dSV.Cilindros, dSV.Carroceria, dSV.Categoria, dSV.Uso, dSV.Nota,dSV.id_ctVehiculo as "Id Solicitud", cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleSeguroObligatorio dSV on ctv.id = dSV.id_ctVehiculo join cEstado cE on dSV.Estado = cE.idEstado
go

alter proc MostrarDetalleSeguroContenido
as
select C.Id, C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Tipo de Vivienda], dSV.Situacion, dSV.Propietario,
dSV.[Vivienda habitual], dSV.[Vivienda Alquilada], dSV.[Codigo Postal], dSV.[Deshabitada por mas de tres meses al ano],
dSV.[Ano de Construccion], dSV.[M2 de la Vivienda], dSV.[DescripcionMuebles],
dSV.[ValorEstimadoMuebles], dSV.id_ctMueblesInmuebles as "Id Solicitud", dSV.Nota, cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleSeguroContenido dSV on ctv.id = dSV.id_ctMueblesInmuebles join cEstado cE on dSV.Estado = cE.idEstado

 go
 alter	 proc MostrarDetalleSeguroEdificaciones
as
select C.Id, C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Tipo de Vivienda], dSV.Situacion, dSV.Propietario,
dSV.[Vivienda habitual], dSV.[Vivienda Alquilada], dSV.[Codigo Postal], dSV.[Deshabitada por mas de tres meses al ano],
dSV.[Ano de Construccion], dSV.[M2 de la Vivienda], dSV.[M2 de edificaciones anexas],
dSV.[Capital de otras instalaciones], dSV.Nota, dSV.Tipo, dSV.id_ctMueblesInmuebles as "Id Solicitud", cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleEdificaciones dSV on ctv.id = dSV.id_ctMueblesInmuebles join cEstado cE on dSV.Estado = cE.idEstado

 go
  
alter proc MostrarSeguroEmpresaNegocios
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
	  ,cE.Estado, dSV.Tipo, dSV.id_ctEmpresasNegocios as "Id Solicitud", dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleSeguroEmpresaNegocio dSV on ctv.id = dSV.id_ctEmpresasNegocios join cEstado cE on dSV.Estado = cE.idEstado



 select * from detalleSeguroEmpresaNegocio


 alter proc AprobarSolicitud
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as
 
 update detalleSeguroVoluntario set Estado =  @Estado, Nota = @Nota where id_ctVehiculo = @idSolicitud
 update ctVehiculo set idEstado =  @Estado where Id = @idSolicitud


 go
 alter proc RechazarSolicitud
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as

update detalleSeguroVoluntario set Estado =  @Estado, Nota = @Nota where id_ctVehiculo = @idSolicitud
update ctVehiculo set idEstado =  @Estado where id = @idSolicitud

go

 create proc AprobarSolicitudContenido
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as
 
 update detalleSeguroContenido set Estado =  @Estado, Nota = @Nota where id_ctMueblesInmuebles = @idSolicitud
 update ctMueblesInmuebles set idEstado = @Estado where Id = @idSolicitud


 go
 alter proc RechazarSolicitudContenido
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as

update detalleSeguroContenido set Estado =  @Estado, Nota = @Nota where id_ctMueblesInmuebles = @idSolicitud
update ctMueblesInmuebles set idEstado =  @Estado where id = @idSolicitud

go

 create proc AprobarSolicitudEdificaciones
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as
 
 update detalleEdificaciones set Estado =  @Estado, Nota = @Nota where id_ctMueblesInmuebles = @idSolicitud
 update ctMueblesInmuebles set idEstado =  @Estado where Id = @idSolicitud


 go
 create proc RechazarSolicitudEdificaciones
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as

update detalleEdificaciones set Estado =  @Estado, Nota = @Nota where id_ctMueblesInmuebles = @idSolicitud
update ctMueblesInmuebles set idEstado =  @Estado where id = @idSolicitud

go
 create proc AprobarSolicitudEmpresasNegocio
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as
 
 update detalleSeguroEmpresaNegocio set Estado =  @Estado, Nota = @Nota where id_ctEmpresasNegocios = @idSolicitud
 update ctEmpresasNegocios set idEstado =  @Estado where Id = @idSolicitud


 go
 create proc RechazarSolicitudEmpresasNegocio
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as

update detalleSeguroEmpresaNegocio set Estado =  @Estado, Nota = @Nota where id_ctEmpresasNegocios = @idSolicitud
update ctEmpresasNegocios set idEstado =  @Estado where id = @idSolicitud

go
 create proc AprobarSolicitudTodoRiesgo
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as
 
 update detalleSeguroTodoRiesgo set Estado =  @Estado, Nota = @Nota where id_ctVehiculo = @idSolicitud
 update ctVehiculo set idEstado =  @Estado where Id = @idSolicitud


 go
 create proc RechazarSolicitudTodoRiesgo
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as

update detalleSeguroTodoRiesgo set Estado =  @Estado, Nota = @Nota where id_ctVehiculo = @idSolicitud
update ctVehiculo set idEstado =  @Estado where id = @idSolicitud

go
 create proc AprobarSolicitudObligatorio
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as
 
 update detalleSeguroObligatorio set Estado =  @Estado, Nota = @Nota where id_ctVehiculo = @idSolicitud
 update ctVehiculo set idEstado =  @Estado where Id = @idSolicitud


 go
 create proc RechazarSolicitudObligatorio
 @idSolicitud int,
 @Estado int,
 @Nota varchar(max)
 as

update detalleSeguroObligatorio set Estado =  @Estado, Nota = @Nota where id_ctVehiculo = @idSolicitud
update ctVehiculo set idEstado =  @Estado where id = @idSolicitud






