


use AseguradoraBD



alter proc CargarPolizasActivas
@IdCliente int
as
select vh.Id as "Núm Poliza", PS.[Nombre del Seguro], PS.Area, cE.Validacion as "Estado" from vdPoliza vh join PolizaDeSeguros PS
on vh.IdPolizaDeSeguro = Ps.id join cEstado cE on vh.Estado = cE.idEstado where Id_Cliente = @IdCliente and cE.idEstado = 1
 UNION  
select em.Id as "Núm Poliza", PS.[Nombre del Seguro], PS.Area, cE.Validacion as "Estado" from emPoliza em join PolizaDeSeguros PS
on em.IdPolizaDeSeguro = Ps.id join cEstado cE on em.Estado = cE.idEstado where Id_Cliente =  @IdCliente and cE.idEstado = 1
 UNION  
select vh.Id as "Núm Poliza", PS.[Nombre del Seguro], PS.Area, cE.Validacion as "Estado" from vhPoliza vh join PolizaDeSeguros PS
on vh.IdPolizaDeSeguro = Ps.id join cEstado cE on vh.Estado = cE.idEstado where Id_Cliente =  @IdCliente and cE.idEstado = 1
 UNION  
select _in.Id as "Núm Poliza", PS.[Nombre del Seguro], PS.Area, cE.Validacion as "Estado" from inPoliza _in join PolizaDeSeguros PS
on _in.IdPolizaDeSeguro = Ps.id join cEstado cE on _in.Estado = cE.idEstado where Id_Cliente =  @IdCliente and cE.idEstado = 1

CargarPolizasActivas 1


go


create proc CargarPolizasActivasEInactivas
@IdCliente int
as
select vh.Id as "Núm Poliza", PS.[Nombre del Seguro], cE.Validacion as "Estado" from vdPoliza vh join PolizaDeSeguros PS
on vh.IdPolizaDeSeguro = Ps.id join cEstado cE on vh.Estado = cE.idEstado where Id_Cliente = @IdCliente
 UNION  
select em.Id as "Núm Poliza", PS.[Nombre del Seguro], cE.Validacion as "Estado" from emPoliza em join PolizaDeSeguros PS
on em.IdPolizaDeSeguro = Ps.id join cEstado cE on em.Estado = cE.idEstado where Id_Cliente =  @IdCliente
 UNION  
select vh.Id as "Núm Poliza", PS.[Nombre del Seguro], cE.Validacion as "Estado" from vhPoliza vh join PolizaDeSeguros PS
on vh.IdPolizaDeSeguro = Ps.id join cEstado cE on vh.Estado = cE.idEstado where Id_Cliente =  @IdCliente
 UNION  
select _in.Id as "Núm Poliza", PS.[Nombre del Seguro], cE.Validacion as "Estado" from inPoliza _in join PolizaDeSeguros PS
on _in.IdPolizaDeSeguro = Ps.id join cEstado cE on _in.Estado = cE.idEstado where Id_Cliente =  @IdCliente


CargarPolizasActivasEInactivas 1

go

alter proc GuardarSiniestro
@Id_Cliente int,
@Id_Empleado int,
@Siniestro varchar(max),
@FechaHora datetime
as
insert into Siniestros(id_Cliente, id_Empleado, Siniestro, FechaHora)
values (@Id_Cliente, @Id_Empleado, @Siniestro, @FechaHora)

insert into Siniestro_Reclamos(id_Siniestro) values
(SCOPE_IDENTITY())

go

exec GuardarSiniestro 1, 1, '.sjkfhskjdhfk;ljsd;hgldkgh', '21-11-2019'

select * from Siniestro_Reclamos
select * from Siniestros

go


create proc MostrarSiniestros
as
select * from Siniestros

go

alter proc CargarPolizasDeSeguros
as
select PS.id, PS.[Nombre del Seguro] from PolizaDeSeguros PS