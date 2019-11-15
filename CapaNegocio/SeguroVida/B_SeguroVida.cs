using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos.SeguroVida;
using PerlaDelSur_Entity.SeguroVida;

namespace CapaNegocio.SeguroVida
{
    public class B_SeguroVida
    {
        private D_SeguroVida D_SeguroVida = new D_SeguroVida();

        public DataTable B_MostrarSegurosDePolizas()
        {
            return D_SeguroVida.D_MostrarSegurosDePolizas();
        }
        public DataTable B_CargarNombreEmpleado(E_SeguroVida e_SegVida)
        {
           return D_SeguroVida.D_CargarNombreEmpleado(e_SegVida);
        }
    }
}
