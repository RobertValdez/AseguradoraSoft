using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaDatos.Clientes;
using PerlaDelSur_Entity.Clientes;

namespace CapaNegocio.Clientes
{
    public class B_Clientes
    {
        private D_Clientes D_Clientes = new D_Clientes();

        public int B_InsertarCliente(E_Clientes eClie)
        {
            return D_Clientes.InsertarCliente(eClie);
        }
        public int B_ModificarCliente(E_Clientes eClie)
        {
            return D_Clientes.ModificarEmpleado(eClie);
        }
        public DataTable B_MostrarClientes()
        {
            return D_Clientes.D_MostrarClientes();
        }
        public int B_EliminarCliente(E_Clientes eClie)
        {
            return D_Clientes.EliminarCliente(eClie);
        }

    }
}
