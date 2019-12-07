using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaDelSur_Entity.Devoluciones
{
    public class E_Devoluciones
    {
        private int _idCliente;
        private int _idSolicitud;
        private int _idPoliza;
        private int _idPolizaDeSeguro;
        private decimal _A_Devolver;
        private string _Motivo;
        private DateTime _FechaHora;

        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdSolicitud { get => _idSolicitud; set => _idSolicitud = value; }
        public int IdPoliza { get => _idPoliza; set => _idPoliza = value; }
        public decimal A_Devolver { get => _A_Devolver; set => _A_Devolver = value; }
        public string Motivo { get => _Motivo; set => _Motivo = value; }
        public DateTime FechaHora { get => _FechaHora; set => _FechaHora = value; }
        public int IdPolizaDeSeguro { get => _idPolizaDeSeguro; set => _idPolizaDeSeguro = value; }

        public E_Devoluciones()
        {

        }

        public E_Devoluciones(int idCliente,
            int idSolicitud, int idPoliza, decimal A_Devolver,
            string Motivo, DateTime FechaHora, int idPolizaDeSeguro)
        {
            _idPolizaDeSeguro = idPolizaDeSeguro;
            _idCliente = idCliente;
            _idSolicitud = idSolicitud;
            _idPoliza = idPoliza;
            _A_Devolver = A_Devolver;
            _Motivo = Motivo;
            _FechaHora = FechaHora;
        }
    }
}
