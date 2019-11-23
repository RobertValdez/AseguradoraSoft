using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaDelSur_Entity.Siniestro
{
    public class E_Siniestro
    {
        private int _idCliente;
        private int _idEmpleado;
        private string _Siniestro;
        private DateTime _FechaHora;

        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public string Siniestro { get => _Siniestro; set => _Siniestro = value; }
        public DateTime FechaHora { get => _FechaHora; set => _FechaHora = value; }

        public E_Siniestro()
        {

        }

        public E_Siniestro(int IdCliente, int IdEmpleado, string Siniestro, DateTime FechaHora)
        {
            _idCliente = IdCliente;
            _idEmpleado = IdEmpleado;
            _Siniestro = Siniestro;
            _FechaHora = FechaHora;
        }
    }
}
