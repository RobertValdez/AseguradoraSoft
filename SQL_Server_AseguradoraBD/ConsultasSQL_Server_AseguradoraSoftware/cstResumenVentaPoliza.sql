

use AseguradoraBD
go

ALTER proc CrearPoliza
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
 exec CrearPoliza  1,1, 1.0, 1, '10-10-2019', /**/'qwedasdasd','sdfsdf', '10-10-2019', 'eqwr',
 'sdfsafsadf',1, '10-10-2020'

 --16

 select * from ctVida
 select * from detalleSeguroSalud
 select * from vdPoliza

 select Cliente.Nombre from Cliente where Id = 32