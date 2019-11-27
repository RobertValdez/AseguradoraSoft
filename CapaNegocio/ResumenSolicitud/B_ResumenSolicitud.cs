using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos.ResumenSolicitud;
using PerlaDelSur_Entity.ResumenSolicitud;


namespace CapaNegocio.ResumenSolicitud
{
    public class B_ResumenSolicitud
    {
        private D_ResumenSolicitud D_ResumenSolicitud = new D_ResumenSolicitud();

        public int B_CrearSolicitud(E_ResumenSolicitud eSol)
        {
            return D_ResumenSolicitud.CrearSolicitudEmpresas(eSol);
        }

        public int B_CrearSolicitudEdificaciones(E_ResumenSolicitudEdificaciones eSd)
        {
            return D_ResumenSolicitud.CrearSolicitudEdificaciones(eSd);
        }
    }
}
