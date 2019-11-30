using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos.Consultas;

namespace CapaNegocio.Consultas
{
    public class B_Consultas
    {
        private D_Consultas D_Consultas = new D_Consultas();

        public DataTable B_ConsultaSol()
        {
            return D_Consultas.D_FacturasSolicitud();
        }
        public DataTable B_ConsultaRecla()
        {
            return D_Consultas.D_Reclamos();
        }
        public DataTable B_ConsultaSini()
        {
            return D_Consultas.D_Siniestros();
        }

    }
}
