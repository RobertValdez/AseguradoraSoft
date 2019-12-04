
use AseguradoraBD
go

ALTER proc [dbo].[GuardarReclamo]
@_Area int,
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

if(@_Area = 1)
begin
	insert into vdReclamos(Id_Cliente, Id_Siniestro, Id_Poliza, [Acta Policial],
	[Copia matricula], [Copia cedula], Estado, Deducible, [Costo estimado], FechaHora)
	values (@IdCliente, @IdSiniestro, @IdPoliza, @ActaPolicial, @CopiaMatricula,
	@CopiaCedula, 1, @Deducible, @CostoEstimado, @FechaHora)
end

else if(@_Area = 2)
begin
	insert into vhReclamos(Id_Cliente, Id_Siniestro, Id_Poliza, [Acta Policial],
	[Copia matricula], [Copia cedula], Estado, Deducible, [Costo estimado], FechaHora)
	values (@IdCliente, @IdSiniestro, @IdPoliza, @ActaPolicial, @CopiaMatricula,
	@CopiaCedula, 1, @Deducible, @CostoEstimado, @FechaHora)
end

else if(@_Area = 3)
begin
	insert into emReclamos(Id_Cliente, Id_Siniestro, Id_Poliza, [Acta Policial],
	[Copia matricula], [Copia cedula], Estado, Deducible, [Costo estimado], FechaHora)
	values (@IdCliente, @IdSiniestro, @IdPoliza, @ActaPolicial, @CopiaMatricula,
	@CopiaCedula, 1, @Deducible, @CostoEstimado, @FechaHora)
end

else if(@_Area = 4)
begin
	insert into inReclamos(Id_Cliente, Id_Siniestro, Id_Poliza, [Acta Policial],
	[Copia matricula], [Copia cedula], Estado, Deducible, [Costo estimado], FechaHora)
	values (@IdCliente, @IdSiniestro, @IdPoliza, @ActaPolicial, @CopiaMatricula,
	@CopiaCedula, 1, @Deducible, @CostoEstimado, @FechaHora)
end
go


