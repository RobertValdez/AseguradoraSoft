


create proc CargarId_detalleSeguroObligatorio
as
if Exists(select * from detalleSeguroObligatorio)
	SELECT IDENT_CURRENT ('detalleSeguroObligatorio') + 1 
ELSE	
	SELECT 1	
