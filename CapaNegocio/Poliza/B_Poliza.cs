using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using PerlaDelSur_Entity.Poliza;
using CapaDatos.Poliza;

namespace CapaNegocio.Poliza
{
    public class B_Poliza
    {
        private D_Poliza D_Poliza = new D_Poliza();

        public int B_RenovarPoliza(E_Poliza ePol)
        {
            return D_Poliza.RenovarPoliza(ePol);
        }

        public int B_CancelarPoliza(E_Poliza ePol)
        {
            return D_Poliza.CancelarPoliza(ePol);
        }
    }
}
