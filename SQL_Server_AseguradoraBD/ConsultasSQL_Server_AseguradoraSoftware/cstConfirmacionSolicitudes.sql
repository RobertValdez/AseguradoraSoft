


use AseguradoraBD

go

alter proc MostrarDetalleSeguroVoluntario
as
select C.Id as "Id Cliente", dSV.id_ctVehiculo as "Id Solicitud", C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Marca de Vehiculo], dSV.Modelo, dSV.Matricula,
dSV.Ano as "Año", dSV.Cilindros, dSV.Carroceria, dSV.Categoria, dSV.Uso, dSV.Nota, cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleSeguroVoluntario dSV on ctv.id = dSV.id_ctVehiculo join cEstado cE on dSV.Estado = cE.idEstado

 go
 
alter proc MostrarDetalleSeguroTodoRiesgo
as
select C.Id, C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Marca de Vehiculo], dSV.Modelo, dSV.Matricula,
dSV.Ano as "Año", dSV.Cilindros, dSV.Carroceria, dSV.Categoria, dSV.Uso, dSV.Nota, cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleSeguroTodoRiesgo dSV on ctv.id = dSV.id_ctVehiculo join cEstado cE on dSV.Estado = cE.idEstado

 go

 alter proc MostrarDetalleSeguroObligatorio
as
select C.Id, C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Marca de Vehiculo], dSV.Modelo, dSV.Matricula,
dSV.Ano as "Año", dSV.Cilindros, dSV.Carroceria, dSV.Categoria, dSV.Uso, dSV.Nota, cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleSeguroObligatorio dSV on ctv.id = dSV.id_ctVehiculo join cEstado cE on dSV.Estado = cE.idEstado


  create proc MostrarDetalleSeguroEdificaciones
as
select C.Id, C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Tipo de Vivienda], dSV.Situacion, dSV.Propietario,
dSV.[Vivienda habitual], dSV.[Vivienda Alquilada], dSV.[Codigo Postal], dSV.[Deshabitada por mas de tres meses al ano],
dSV.[Ano de Construccion], dSV.[M2 de la Vivienda], dSV.[M2 de edificaciones anexas],
dSV.[Capital de otras instalaciones], dSV.Nota, dSV.Tipo, cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleEdificaciones dSV on ctv.id = dSV.id_ctMueblesInmuebles join cEstado cE on dSV.Estado = cE.idEstado

 select * from detalleEdificaciones


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
