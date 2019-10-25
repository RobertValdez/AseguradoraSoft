using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaEntidad.Empleados;
using CapaDatos.Empleados;

namespace CapaNegocio.Empleados
{
    public class B_Empleados
    {
        private D_Empleados D_Empleados = new D_Empleados();

        public int B_InsertarEmpleado(E_Empleados eEmp)
        {
            return D_Empleados.InsertarEmpleado(eEmp);
        }
        public DataTable B_MostrarSolares()
        {
           return D_Empleados.D_MostrarEmpleados();
        }
        public int B_ModificarEmpleado(E_Empleados eEmpl)
        {
            return D_Empleados.ModificarEmpleado(eEmpl);
        }
    }
}
