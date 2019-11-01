using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PerlaDelSur_Entity.Usuarios;
using CapaDatos.Usuarios;

namespace CapaNegocio.Usuarios
{
    public class B_Usuarios
    {
        private D_Usuarios D_Usuarios = new D_Usuarios();

        public int ComprobarAcceso(E_Usuarios eUser)
        {
            return D_Usuarios.ComprobarAcceso(eUser);
        }
    }
}
