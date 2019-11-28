




use AseguradoraBD

go

create proc CargarId_detalleSeguroVoluntario
as
if Exists(select * from detalleSeguroVoluntario)
	SELECT IDENT_CURRENT ('detalleSeguroVoluntario') + 1 
ELSE	
	SELECT 1	

