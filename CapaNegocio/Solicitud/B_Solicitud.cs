using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos.Solicitud;
using PerlaDelSur_Entity.SeguroVida;


namespace CapaNegocio.Solicitud
{
    public class B_Solicitud
    {
        private D_Solicitud D_Solicitud = new D_Solicitud();

        public int B_CargarIdDetalleEmpresaNegocio()
        {
            return D_Solicitud.D_Cargar_id_detalleSeguroEmpresaNegocio();
        }

        public int B_CargarIdDetalleSeguroEdificaciones()
        {
            return D_Solicitud.D_Cargar_id_detalleSeguroEdificaciones();
        }

        public int B_CargarId_Factura()
        {
            return D_Solicitud.D_CargarId_Factura();
        }

        public int B_CargarIdDetalleSeguroVehiculoVoluntario()
        {
            return D_Solicitud.D_Cargar_id_detalleSeguroVehiculoVoluntario();
        }

        public int B_CargarIdDetalleSeguroVehiculoTodoRiesgo()
        {
            return D_Solicitud.D_Cargar_id_detalleSeguroVehiculoTodoRiesgo();
        }
        public int B_CargarIdDetalleSeguroVehiculoObligatorio()
        {
            return D_Solicitud.D_Cargar_id_detalleSeguroVehiculoObligatorio();
        }
    }
}
