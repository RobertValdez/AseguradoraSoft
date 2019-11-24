



alter proc InsertarCliente
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
go

declare @A int
exec InsertarCliente @A output,'maniga','qwe','qwe','qwe','qwe','qwe','qwe','qwe','qwe', '12-12-2019'
select @A int
select * from Cliente

go
alter proc ModificarCliente
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
go


alter proc MostrarClientes
as
select * from Cliente

create proc EliminarCliente
@Id int
as
delete from Cliente where id=@Id


create proc ComprobarAcceso
@NombreUsuario varchar(20),
@Contrasena varchar(30)
as
if exists(select NombreUsuario,Contrasena from Usuarios where NombreUsuario = @NombreUsuario and Contrasena = @Contrasena)
	return 1
else
	return 0
