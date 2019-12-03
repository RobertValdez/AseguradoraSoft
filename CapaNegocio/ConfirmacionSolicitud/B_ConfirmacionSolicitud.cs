using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PerlaDelSur_Entity.ConfirmacionSolicitud;
using System.Data;
using CapaDatos.ConfirmacionSolicitud;

namespace CapaNegocio.ConfirmacionSolicitud
{
    public class B_ConfirmacionSolicitud
    {
        private D_ConfirmacionSolicitud D_ConfirmacionSolicitud = new D_ConfirmacionSolicitud();

        public DataTable B_MostrarSeguroVoluntario()
        {
            return D_ConfirmacionSolicitud.D_MostrarSeguroVoluntario();
        }
        public DataTable B_MostrarSeguroTodoRiesgo()
        {
            return D_ConfirmacionSolicitud.D_MostrarSeguroTodoRiesgo();
        }
        public DataTable B_MostrarSeguroSeguroObligatorio()
        {
            return D_ConfirmacionSolicitud.D_MostrarSeguroSeguroObligatorio();
        }
        public DataTable B_MostrarSeguroContenido()
        {
            return D_ConfirmacionSolicitud.D_MostrarSeguroContenido();
        }
        public DataTable B_MostrarSeguroEdificaciones()
        {
            return D_ConfirmacionSolicitud.D_MostrarSeguroEdificaciones();
        }
        public DataTable B_MostrarSeguroEmpresaNegocios()
        {
            return D_ConfirmacionSolicitud.D_MostrarSeguroEmpresaNegocios();
        }





        public int B_AprobarSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            return D_ConfirmacionSolicitud.D_AprobarSolicitudSeguroVoluntario(eCon);
        }

        public int B_RechazarSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            return D_ConfirmacionSolicitud.D_RechazarSolicitudSolicitudSeguroVoluntario(eCon);
        }



        public int B_AprobarSolicitudContenido(E_ConfirmacionSolicitud eCon)
        {
            return D_ConfirmacionSolicitud.D_AprobarSolicitudContenido(eCon);
        }

        public int B_RechazarSolicitudContenido(E_ConfirmacionSolicitud eCon)
        {
            return D_ConfirmacionSolicitud.D_RechazarSolicitudContenido(eCon);
        }


        public int B_AprobarSolicitudEdificaciones(E_ConfirmacionSolicitud eCon)
        {
            return D_ConfirmacionSolicitud.D_AprobarSolicitudEdificaciones(eCon);
        }

        public int B_RechazarSolicitudEdificaciones(E_ConfirmacionSolicitud eCon)
        {
            return D_ConfirmacionSolicitud.D_RechazarSolicitudEdificaciones(eCon);
        }


        public int B_AprobarSolicitudEmpresasNegocio(E_ConfirmacionSolicitud eCon)
        {
            return D_ConfirmacionSolicitud.D_AprobarSolicitudEmpresasNegocio(eCon);
        }

        public int B_RechazarSolicitudEmpresasNegocio(E_ConfirmacionSolicitud eCon)
        {
            return D_ConfirmacionSolicitud.D_RechazarSolicitudEmpresasNegocio(eCon);
        }


        public int B_AprobarSolicitudTodoRiesgo(E_ConfirmacionSolicitud eCon)
        {
            return D_ConfirmacionSolicitud.D_AprobarSolicitudTodoRiesgo(eCon);
        }

        public int B_RechazarSolicitudTodoRiesgo(E_ConfirmacionSolicitud eCon)
        {
            return D_ConfirmacionSolicitud.D_RechazarSolicitudTodoRiesgo(eCon);
        }


        public int B_AprobarSolicitudObligatorio(E_ConfirmacionSolicitud eCon)
        {
            return D_ConfirmacionSolicitud.D_AprobarSolicitudObligatorio(eCon);
        }

        public int B_RechazarSolicitudObligatorio(E_ConfirmacionSolicitud eCon)
        {
            return D_ConfirmacionSolicitud.D_RechazarSolicitudObligatorio(eCon);
        }
    }
}
