


use AseguradoraBD

go

alter proc MostrarDetalleSeguroVoluntario
as
select C.Id, C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Marca de Vehiculo], dSV.Modelo, dSV.Matricula,
dSV.Ano as "Año", dSV.Cilindros, dSV.Carroceria, dSV.Categoria, dSV.Uso, dSV.Nota, cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleSeguroVoluntario dSV on ctv.id = dSV.id_ctVehiculo join cEstado cE on dSV.Estado = cE.idEstado

 go
 
create proc MostrarDetalleSeguroTodoRiesgo
as
select C.Id, C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Marca de Vehiculo], dSV.Modelo, dSV.Matricula,
dSV.Ano as "Año", dSV.Cilindros, dSV.Carroceria, dSV.Categoria, dSV.Uso, dSV.Nota, cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleSeguroTodoRiesgo dSV on ctv.id = dSV.id_ctVehiculo join cEstado cE on dSV.Estado = cE.idEstado

 go

 create proc MostrarDetalleSeguroObligatorio
as
select C.Id, C.Nombre, C.Apellido, C.Direccion, C.Cedula, C.Nacionalidad, C.Telefono,
C.[Correo Electronico], C.Sexo, C.RNC, dSV.[Marca de Vehiculo], dSV.Modelo, dSV.Matricula,
dSV.Ano as "Año", dSV.Cilindros, dSV.Carroceria, dSV.Categoria, dSV.Uso, dSV.Nota, cE.Estado, dSV.Tipo, dSV.FechaHora from Cliente C join ctVehiculo ctv on C.Id = ctv.id_Cliente
 join detalleSeguroObligatorio dSV on ctv.id = dSV.id_ctVehiculo join cEstado cE on dSV.Estado = cE.idEstado

