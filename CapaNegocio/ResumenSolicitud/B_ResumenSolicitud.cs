using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos.ResumenSolicitud;
using PerlaDelSur_Entity.ResumenSolicitud;
using PerlaDelSur_Entity.Vehiculo;


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
        public int B_CrearSolicitudContendio(E_ResumenSolicitudEdificaciones eSc)
        {
            return D_ResumenSolicitud.CrearSolicitudContenido(eSc);
        }
        public int B_CrearSolicitudVEHvoluntario(E_Vehiculo eVv)
        {
            return D_ResumenSolicitud.CrearSolicitudVEHvoluntario(eVv);
        }

        public int B_CrearSolicitudVEHtodoRiesgo(E_Vehiculo eVr)
        {
            return D_ResumenSolicitud.CrearSolicitudVEHtodoRiesgo(eVr);
        }
    }
}
