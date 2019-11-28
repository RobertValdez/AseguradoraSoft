
use AseguradoraBD

go

create proc CargarId_detalleSeguroTodoRiesgo
as
if Exists(select * from detalleSeguroTodoRiesgo)
	SELECT IDENT_CURRENT ('detalleSeguroTodoRiesgo') + 1 
ELSE	
	SELECT 1	

