

use AseguradoraBD

go

alter proc CargarId_detalleSeguroEmpresa
as
if Exists(select * from detalleSeguroEmpresaNegocio)
	SELECT IDENT_CURRENT ('detalleSeguroEmpresaNegocio') + 1 
ELSE	
	SELECT 1	

