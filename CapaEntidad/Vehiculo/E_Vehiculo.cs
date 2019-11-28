using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaDelSur_Entity.Vehiculo
{
    public class E_Vehiculo
    {
        private int _IdCliente;
        private int _idEmpleado;
        private decimal _Total;
        private DateTime _Fecha;

        private string _MarcaVehiculo;
        private string _Modelo;
        private string _Matricula;
        private int _Ano;
        private int _Cilindros;
        private string _Carroceria;
        private string _Categoria;
        private string _Uso;

        private DateTime _FechaHora;
        private string _Tipo;

        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public decimal Total { get => _Total; set => _Total = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string MarcaVehiculo { get => _MarcaVehiculo; set => _MarcaVehiculo = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public string Matricula { get => _Matricula; set => _Matricula = value; }
        public int Ano { get => _Ano; set => _Ano = value; }
        public int Cilindros { get => _Cilindros; set => _Cilindros = value; }
        public string Carroceria { get => _Carroceria; set => _Carroceria = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value; }
        public string Uso { get => _Uso; set => _Uso = value; }
        public DateTime FechaHora { get => _FechaHora; set => _FechaHora = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }

        public E_Vehiculo()
        {

        }

        public E_Vehiculo(int IdCliente, int idEmpleado, decimal Total, DateTime Fecha,
            string MarcaVehiculo, string Modelo, string Matricula, int Ano, int Cilindros,
            string Carroceria, string Categoria, string Uso, DateTime FechaHora,
            string Tipo)
        {
            _IdCliente = IdCliente;
            _idEmpleado = idEmpleado;
            _Total = Total;
            _Fecha = Fecha;
            _MarcaVehiculo = MarcaVehiculo;
            _Modelo = Modelo;
            _Matricula = Matricula;
            _Ano = Ano;
            _Cilindros = Cilindros;
            _Carroceria = Carroceria;
            _Categoria = Categoria;
            _Uso = Uso;
            _FechaHora = FechaHora;
            _Tipo = Tipo;
        }
    }
}
