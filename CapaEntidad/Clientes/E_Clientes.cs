using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaDelSur_Entity.Clientes
{
    public class E_Clientes
    {
        private int _id;
        private string _Nombre;
        private string _Apellido;
        private string _Direccion;
        private string _Cedula;
        private string _Nacionalidad;
        private string _Telefono;
        private string _CorreoElectronico;
        private string _RNC;
        private string _Sexo;
        private DateTime _FechaHora;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Nacionalidad { get => _Nacionalidad; set => _Nacionalidad = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string CorreoElectronico { get => _CorreoElectronico; set => _CorreoElectronico = value; }
        public string RNC { get => _RNC; set => _RNC = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public DateTime FechaHora { get => _FechaHora; set => _FechaHora = value; }

        public E_Clientes()
        {

        }

        public E_Clientes(int id, string nombre, string Apellido, string Direccion,
            string cedula, string nacionalidad, string telefono, string correoElectronico,
            string RNC, string Sexo, DateTime FechaHora)
        {
            _id = id;
            _Nombre = nombre;
            _Apellido = Apellido;
            _Direccion = Direccion;
            _Cedula = cedula;
            _Nacionalidad = nacionalidad;
            _Telefono = telefono;
            _CorreoElectronico = correoElectronico;
            _RNC = RNC;
            _Sexo = Sexo;
            _FechaHora = FechaHora;
        }
    }
}
