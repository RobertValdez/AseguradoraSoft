





use AseguradoraBD

go

create proc CargarId_detalleSeguroEdificaciones
as
if Exists(select * from detalleEdificaciones)
	SELECT IDENT_CURRENT ('detalleEdificaciones') + 1 
ELSE	
	SELECT 1	
