using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos.ResumenVentaPoliza;
using PerlaDelSur_Entity.ResumenVentaPoliza;

namespace CapaNegocio.B_ResumenVentaPoliza
{
    public class B_ResumenVentaPoliza
    {
        D_ResumenVentaPoliza D_ResumenVentaPoliza = new D_ResumenVentaPoliza();
        public int CrearPoliza(E_ResumenVentaPoliza ervPoliza)
        {
           return D_ResumenVentaPoliza.CrearPoliza(ervPoliza);
        }
    }
}
