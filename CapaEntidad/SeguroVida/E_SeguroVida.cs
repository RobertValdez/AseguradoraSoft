using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaDelSur_Entity.SeguroVida
{
    public class E_SeguroVida
    {
        private int _id;
        private string _NombreEmpleado;
        private string _Cedula;

        public int Id { get => _id; set => _id = value; }
        public string NombreEmpleado { get => _NombreEmpleado; set => _NombreEmpleado = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        
        public E_SeguroVida()
        {

        }

        public E_SeguroVida(int id, string NomEmpleado, string cedula)
        {
            _id = id;
            _NombreEmpleado = NomEmpleado;
            _Cedula = cedula;
        }
    }
}
