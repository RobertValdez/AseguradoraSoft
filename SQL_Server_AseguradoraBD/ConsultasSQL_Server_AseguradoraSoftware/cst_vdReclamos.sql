
use AseguradoraBD
go

create proc GuardarReclamo
@IdCliente int,
@Siniestro int,
@Poliza int,
@ActaPolicial image,
@CopiaMatricula image,
@CopiaCedula image,
@Estado int,
@CostoEstimado decimal(18,2),
@FechaHora datetime
as
declare @Deducible decimal
set @Deducible = @CostoEstimado * 0.15

insert into vhReclamos(Id_Cliente, Siniestro, Poliza, [Acta Policial],
[Copia matricula], [Copia cedula], Estado, Deducible, [Costo estimado], FechaHora)
values (@IdCliente, @Siniestro, @Poliza, @ActaPolicial, @CopiaMatricula,
@CopiaCedula, @Estado, @Deducible, @CostoEstimado, @FechaHora)

