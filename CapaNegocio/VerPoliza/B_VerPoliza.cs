using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos.VerPoliza;


namespace CapaNegocio.VerPoliza
{
    public class B_VerPoliza
    {
        private D_VerPoliza D_VerPoliza = new D_VerPoliza();

        public DataTable B_vd_VerPoliza()
        {
            return D_VerPoliza.D_vd_MostrarPolizas();
        }
    }
}
