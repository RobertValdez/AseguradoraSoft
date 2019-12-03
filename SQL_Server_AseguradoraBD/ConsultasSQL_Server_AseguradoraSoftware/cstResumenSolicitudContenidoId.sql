
use AseguradoraBD

go

create proc CargarId_Factura
as
if Exists(select * from Facturas)
	SELECT IDENT_CURRENT ('Facturas') + 1 
ELSE	
	SELECT 1	

