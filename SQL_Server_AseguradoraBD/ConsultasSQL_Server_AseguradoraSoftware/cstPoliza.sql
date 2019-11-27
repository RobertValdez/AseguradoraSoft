

use AseguradoraBD


alter proc vd_MostrarPolizas
as
select vdPoliza.Id_Cliente AS "Id Cliente", vdPoliza.id AS "N�m. P�liza", PolizaDeSeguros.[Nombre del Seguro], vdPoliza.Poliza, PolizaDeSeguros.Area, PolizaDeSeguros.Precio, cEstado.Validacion AS "Estado", vdPoliza.FechaHora AS "Fecha Hora",
 vdPoliza.Vencimiento, Cliente.Nombre, Cliente.Apellido,
 Cliente.Cedula AS "C�dula", Cliente.Telefono AS "Tel�fono", Cliente.Sexo, vdPoliza.Nota
  from vdPoliza join PolizaDeSeguros on vdPoliza.idPolizaDeSeguro = PolizaDeSeguros.id  join Cliente on vdPoliza.Id_Cliente = Cliente.Id
join cEstado on vdPoliza.Estado = cEstado.idEstado 





create proc in_MostrarPolizas
as
select * from inPoliza

create proc vh_MostrarPolizas
as
select * from vhPoliza

create proc em_MostrarPolizas
as
select * from emPoliza


Alter proc RenovacionPoliza
@IdPoliza int, --
@IdCliente int, --
@IdEmpleado int, --

@Poliza varchar(MAX), /**/
@Precio decimal(18,2), --
@T_Pago decimal(18,2), --
@Parcial decimal(18,2), --
@FechaHora datetime, --
@Vencimiento date /**/
as
update vdPoliza set Poliza= @Poliza,
Estado= 1, FechaHora= @FechaHora, Vencimiento= @Vencimiento
where id= @IdPoliza

declare @IdPolizaDeSeguro int
set @IdPolizaDeSeguro = (Select vdPoliza.IdPolizaDeSeguro from vdPoliza where vdPoliza.id = @IdPoliza)

insert into PagoPolizas(id_Cliente,id_Empleado, idPolizaDeSeguro,
idPolizaVd,Precio, T_Pago, [Pago Parcial], FechaHora)
values (@IdCliente, @IdEmpleado, @IdPolizaDeSeguro, @IdPoliza, @Precio, @T_Pago, @Parcial,
 @FechaHora)


create proc CancelarPoliza
@idPoliza int,
@FechaHora datetime,
@Nota varchar(max)
as
update vdPoliza set
Estado= 2, FechaHora= @FechaHora, Nota = @Nota
where id= @IdPoliza