
use AseguradoraBD

go

create proc CargarId_detalleSeguroContenido
as
if Exists(select * from detalleSeguroContenido)
	SELECT IDENT_CURRENT ('detalleSeguroContenido') + 1 
ELSE	
	SELECT 1	

