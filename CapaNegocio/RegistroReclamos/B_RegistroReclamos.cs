using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos.RegistroReclamos;
using PerlaDelSur_Entity.RegistroReclamos;


namespace CapaNegocio.RegistroReclamos
{
    public class B_RegistroReclamos
    {
        D_RegistroReclamos D_RegistroReclamos = new D_RegistroReclamos();

        public DataTable B_CargarPolizaCliente(E_RegistroReclamos eReg)
        {
            return D_RegistroReclamos.CargarPolizasActivas(eReg);
        }
    }
}
