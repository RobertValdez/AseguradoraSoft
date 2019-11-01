using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaDelSur_Entity.Usuarios
{
    public class E_Usuarios
    {
        

        private string _NombreUsuario;
        private string _Contrasena;
        private string _Privilegio;

        private string _Fecha;

        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
        public string Contrasena { get => _Contrasena; set => _Contrasena = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string Privilegio { get => _Privilegio; set => _Privilegio = value; }

        public E_Usuarios()
        {

        }

        public E_Usuarios(string NombreUsuario, string Contrasena, string Privilegio, string Fecha)
        {
            _NombreUsuario = NombreUsuario;
            _Contrasena = Contrasena;
            _Privilegio = Privilegio;
            _Fecha = Fecha;
        }
    }
}