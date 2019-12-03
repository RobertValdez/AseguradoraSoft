using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaDelSur_Entity.Poliza
{
    public class E_Poliza
    {
        private int _idPolizaSeguro;
        private int _IdPoliza;
        private int _IdCliente;
        private int _IdEmpleado;
        private string _Poliza;
        private decimal _Precio;
        private decimal _TPago;
        private decimal _Parcial;
        private DateTime _FechaHora;
        private DateTime _Vencimiento;
        private string _Nota;

        public int IdPoliza { get => _IdPoliza; set => _IdPoliza = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public int IdEmpleado { get => _IdEmpleado; set => _IdEmpleado = value; }
        public string Poliza { get => _Poliza; set => _Poliza = value; }
        public decimal Precio { get => _Precio; set => _Precio = value; }
        public decimal TPago { get => _TPago; set => _TPago = value; }
        public decimal Parcial { get => _Parcial; set => _Parcial = value; }
        public DateTime FechaHora { get => _FechaHora; set => _FechaHora = value; }
        public DateTime Vencimiento { get => _Vencimiento; set => _Vencimiento = value; }
        public string Nota { get => _Nota; set => _Nota = value; }
        public int IdPolizaSeguro { get => _idPolizaSeguro; set => _idPolizaSeguro = value; }

        public E_Poliza()
        {

        }

        public E_Poliza(int IdPoliza, int IdCliente, int IdEmpleado,
            string Poliza, decimal Precio, decimal TPago, decimal Parcial, DateTime FechaHora,
            DateTime Vencimiento, string Nota, int idSeguro)
        {
            _IdPoliza = IdPoliza;
            _IdCliente = IdCliente;
            _IdEmpleado = IdEmpleado;
            _Poliza = Poliza;
            _Precio = Precio;
            _TPago = TPago;
            _Parcial = Parcial;
            _FechaHora = FechaHora;
            _Vencimiento = Vencimiento;
            _Nota = Nota;
            _idPolizaSeguro = idSeguro;
        }
    }
}
