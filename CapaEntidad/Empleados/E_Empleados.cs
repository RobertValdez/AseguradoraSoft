using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Empleados
{
    public class E_Empleados
    {
        private int _id;
        private string _Nombre;
        private string _Apellido;
        private string _Direccion;
        private string _Cedula;
        private string _Telefono;
        private string _CorreoElectronico;
        private int _idCargo;
        private string _Sexo;
        private DateTime _Fecha;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string CorreoElectronico { get => _CorreoElectronico; set => _CorreoElectronico = value; }
        public int IdCargo { get => _idCargo; set => _idCargo = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        

        public E_Empleados()
        {

        }
        public E_Empleados(int Id, string Nombre, string Apellido, string Direccion,
            string Cedula, string Telefono, string CorreoElectronico, int IdCargo, string Sexo, DateTime Fecha)
        {
            _id = Id;
            _Nombre = Nombre;
            _Apellido = Apellido;
            _Direccion = Direccion;
            _Cedula = Cedula;
            _Telefono = Telefono;
            _CorreoElectronico = CorreoElectronico;
            _idCargo = IdCargo;
            _Sexo = Sexo;
            _Fecha = Fecha;
        }
    }
}
