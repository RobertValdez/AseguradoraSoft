
	
use AseguradoraBD
go

ALTER proc CargarId
as
if Exists(select * from detalleSeguroSalud)
	SELECT IDENT_CURRENT ('detalleSeguroSalud') + 1 
ELSE	
	SELECT 1		
go

exec CargarId 