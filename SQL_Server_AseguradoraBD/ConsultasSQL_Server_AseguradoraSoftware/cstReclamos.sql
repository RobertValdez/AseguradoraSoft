
use AseguradoraBD
go

alter proc GuardarReclamo
@_Area varchar,
@IdCliente int,
@IdSiniestro int,
@IdPoliza int,
@ActaPolicial image,
@CopiaMatricula image,
@CopiaCedula image,
@CostoEstimado decimal(18,2),
@FechaHora datetime
as
declare @Deducible decimal
set @Deducible = @CostoEstimado * 0.15

--if(@_Area = 'Vida')
	insert into vdReclamos(Id_Cliente, Id_Siniestro, Id_Poliza, [Acta Policial],
	[Copia matricula], [Copia cedula], Estado, Deducible, [Costo estimado], FechaHora)
	values (@IdCliente, @IdSiniestro, @IdPoliza, @ActaPolicial, @CopiaMatricula,
	@CopiaCedula, 1, @Deducible, @CostoEstimado, @FechaHora)


else if(@_Area = 'Vehiculo')
	insert into vhReclamos(Id_Cliente, Id_Siniestro, Id_Poliza, [Acta Policial],
	[Copia matricula], [Copia cedula], Estado, Deducible, [Costo estimado], FechaHora)
	values (@IdCliente, @IdSiniestro, @IdPoliza, @ActaPolicial, @CopiaMatricula,
	@CopiaCedula, 1, @Deducible, @CostoEstimado, @FechaHora)


else if(@_Area = 'Negocios e Empresas')
	insert into emReclamos(Id_Cliente, Id_Siniestro, Id_Poliza, [Acta Policial],
	[Copia matricula], [Copia cedula], Estado, Deducible, [Costo estimado], FechaHora)
	values (@IdCliente, @IdSiniestro, @IdPoliza, @ActaPolicial, @CopiaMatricula,
	@CopiaCedula, 1, @Deducible, @CostoEstimado, @FechaHora)

else if(@_Area = 'Muebles e Inmuebles')
	insert into inReclamos(Id_Cliente, Id_Siniestro, Id_Poliza, [Acta Policial],
	[Copia matricula], [Copia cedula], Estado, Deducible, [Costo estimado], FechaHora)
	values (@IdCliente, @IdSiniestro, @IdPoliza, @ActaPolicial, @CopiaMatricula,
	@CopiaCedula, 1, @Deducible, @CostoEstimado, @FechaHora)

go


