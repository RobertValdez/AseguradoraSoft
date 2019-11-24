




create database AseguradoraBD
use AseguradoraBD
go
create proc InsertarEmpleado
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
go


create proc MostrarEmpleados
as
select * from Empleado

go

create proc ModificarEmpleado
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
go

create proc EliminarEmpleado
@Id int
as
delete from Empleado where id=@Id


truncate table CargoEmp

 sp_who