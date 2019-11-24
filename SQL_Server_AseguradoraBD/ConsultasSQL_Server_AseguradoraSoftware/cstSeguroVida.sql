


use AseguradoraBD
go

alter proc CargarNombreEmpleado
@id int,
@Nombre varchar output,
@Cedula varchar output
as
select id, Nombre, Cedula from Empleado where @id = id
go

create proc MostrarSegurosDePolizas
as
select * from PolizaDeSeguros

go
declare @Nombre varchar
declare @cedula varchar
exec CargarNombreEmpleado 1, @Nombre output, @cedula output
select @Nombre
select @cedula