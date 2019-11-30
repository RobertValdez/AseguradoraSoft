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
        public int B_AprobarSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            return D_ConfirmacionSolicitud.D_AprobarSolicitudSeguroVoluntario(eCon);
        }

        public int B_RechazarSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            return D_ConfirmacionSolicitud.D_RechazarSolicitudSolicitudSeguroVoluntario(eCon);
        }
    }
}
