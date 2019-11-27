using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaDelSur_Entity.ResumenSolicitud
{
    public class E_ResumenSolicitud
    {
        private int _idCliente;
        private int _idEmpleado;
        private decimal _Total;
        private DateTime _Fecha;
        private string _NombreEmpresa;
        private byte[] _CopiaEstatutos;
        private byte[] _CopiaActaDeAsignacionRNC;
        private byte[] _CopiaCedulaPres_RepreAutorizado;
        private string _TelefonoEntidadAutorizada;
        private string _CorreoElectronicoEntidadAutorizada;
        private DateTime _FechaHora;
        private string _Tipo;

        private byte[] _Imagen1;
        private byte[] _Imagen2;
        private byte[] _Imagen3;
        private byte[] _Imagen4;
        private byte[] _Imagen5;


        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public decimal Total { get => _Total; set => _Total = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string NombreEmpresa { get => _NombreEmpresa; set => _NombreEmpresa = value; }
        public byte[] CopiaEstatutos { get => _CopiaEstatutos; set => _CopiaEstatutos = value; }
        public byte[] CopiaActaDeAsignacionRNC { get => _CopiaActaDeAsignacionRNC; set => _CopiaActaDeAsignacionRNC = value; }
        public byte[] CopiaCedulaPres_RepreAutorizado { get => _CopiaCedulaPres_RepreAutorizado; set => _CopiaCedulaPres_RepreAutorizado = value; }
        public string TelefonoEntidadAutorizada { get => _TelefonoEntidadAutorizada; set => _TelefonoEntidadAutorizada = value; }
        public string CorreoElectronicoEntidadAutorizada { get => _CorreoElectronicoEntidadAutorizada; set => _CorreoElectronicoEntidadAutorizada = value; }
        public DateTime FechaHora { get => _FechaHora; set => _FechaHora = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }

        public byte[] Imagen1 { get => _Imagen1; set => _Imagen1 = value; }
        public byte[] Imagen2 { get => _Imagen2; set => _Imagen2 = value; }
        public byte[] Imagen3 { get => _Imagen3; set => _Imagen3 = value; }
        public byte[] Imagen4 { get => _Imagen4; set => _Imagen4 = value; }
        public byte[] Imagen5 { get => _Imagen5; set => _Imagen5 = value; }


        public E_ResumenSolicitud()
        {

        }

        public E_ResumenSolicitud(int idCliente, int idEmpleado, decimal Total,
            DateTime Fecha, string NombreEmpresa,
            byte[] CopiaEstatutos, byte[] CopiaActaDeAsignacionRNC,
            byte[] CopiaCedulaPres_RepreAutorizado, string TelefonoEntidadAutorizada, 
            string CorreoElectronicoEntidadAutorizada, DateTime FechaHora,
            string Tipo, byte[] Imagen1, byte[] Imagen2, byte[] Imagen3, byte[] Imagen4,
            byte[] Imagen5)
        {
            _idCliente = idCliente;
            _idEmpleado = idEmpleado;
            _Total = Total;
            _Fecha = Fecha;
            _NombreEmpresa = NombreEmpresa;
            _CopiaEstatutos = CopiaEstatutos;
            _CopiaActaDeAsignacionRNC = CopiaActaDeAsignacionRNC;
            _CopiaCedulaPres_RepreAutorizado = CopiaCedulaPres_RepreAutorizado;
            _TelefonoEntidadAutorizada = TelefonoEntidadAutorizada;
            _CorreoElectronicoEntidadAutorizada = CorreoElectronicoEntidadAutorizada;
            _FechaHora = FechaHora;
            _Tipo = Tipo;

            _Imagen1 = Imagen1;
            _Imagen2 = Imagen2;
            _Imagen3 = Imagen3;
            _Imagen4 = Imagen4;
            _Imagen5 = Imagen5;
        }
    }
}
