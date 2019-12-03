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
        public DataTable B_em_MostrarPolizas()
        {
            return D_VerPoliza.D_em_MostrarPolizas();
        }
        public DataTable B_in_MostrarPolizas()
        {
            return D_VerPoliza.D_in_MostrarPolizas();
        }
        public DataTable B_vh_MostrarPolizas()
        {
            return D_VerPoliza.D_vh_MostrarPolizas();
        }
    }
}
