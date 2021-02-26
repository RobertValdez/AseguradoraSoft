using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PerlaDelSur_Entity.Devoluciones;
using CapaDatos.Devoluciones;
using System.Data;

namespace CapaNegocio.Devoluciones
{
    public class B_Devoluciones
    {
        private D_Devoluciones D_Devoluciones = new D_Devoluciones();

        public int B_Devoluviones(E_Devoluciones eD)
        {
            return D_Devoluciones.CrearDevolucion(eD);
        }

        public DataTable B_ReclamacionesIdCliente(E_Devoluciones eD)
        {
            return D_Devoluciones.CargarReclamacionesCliente(eD);
        }
    }
}
