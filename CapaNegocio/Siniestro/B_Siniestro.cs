using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos.Siniestro;
using PerlaDelSur_Entity.Siniestro;

namespace CapaNegocio.Siniestro
{
    public class B_Siniestro
    {
        D_Siniestro D_Siniestro = new D_Siniestro();

        public int B_GuardarSiniestro(E_Siniestro eSin)
        {
            return D_Siniestro.GuardarSiniestro(eSin);
        }
    }
}
