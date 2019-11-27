using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaDelSur_Entity.ResumenSolicitud
{
    public class E_ResumenSolicitudEdificaciones
    {
        private int _idCliente;
        private int _idEmpleado;
        private decimal _Total;
        private DateTime _Fecha;

        private string _TipoVivienda;
        private string _Situacion;
        private string _Propietario;
        private string _ViviendaHabitual;
        private string _ViviendaAlquilada;
        private string _CodigoPostal;
        private string _DeshabitadaPor3MesesAlAno;
        private int _AnoDeCostruccion;
        private decimal _M2Vivienda;
        private decimal _M2EdificacionesAnexas;
        private string _CapitalOtrasInstalaciones;
        private DateTime _FechaHora;
        private string _Tipo;


        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public decimal Total { get => _Total; set => _Total = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public string TipoVivienda { get => _TipoVivienda; set => _TipoVivienda = value; }
        public string Situacion { get => _Situacion; set => _Situacion = value; }
        public string Propietario { get => _Propietario; set => _Propietario = value; }
        public string ViviendaHabitual { get => _ViviendaHabitual; set => _ViviendaHabitual = value; }
        public string ViviendaAlquilada { get => _ViviendaAlquilada; set => _ViviendaAlquilada = value; }
        public string CodigoPostal { get => _CodigoPostal; set => _CodigoPostal = value; }
        public string DeshabitadaPor3MesesAlAno { get => _DeshabitadaPor3MesesAlAno; set => _DeshabitadaPor3MesesAlAno = value; }
        public int AnoDeCostruccion { get => _AnoDeCostruccion; set => _AnoDeCostruccion = value; }
        public decimal M2Vivienda { get => _M2Vivienda; set => _M2Vivienda = value; }
        public decimal M2EdificacionesAnexas { get => _M2EdificacionesAnexas; set => _M2EdificacionesAnexas = value; }
        public string CapitalOtrasInstalaciones { get => _CapitalOtrasInstalaciones; set => _CapitalOtrasInstalaciones = value; }
        public DateTime FechaHora { get => _FechaHora; set => _FechaHora = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }

        public E_ResumenSolicitudEdificaciones()
        {

        }


        public E_ResumenSolicitudEdificaciones(int idCliente, int idEmpleado, decimal Total,
            DateTime Fecha, string TipoVivienda, string Situacion, string Propietario,
            string ViviendaHabitual, string ViviendaAlquilada, string CodigoPostal,
            string DeshabitadaPor3MesesAlAno, int AnoDeCostruccion, decimal M2Vivienda,
            decimal M2EdificacionesAnexas, string CapitalOtrasInstalaciones, DateTime fechaHora,
            string tipo)
        {
            _idCliente = idCliente;
            _idEmpleado = idEmpleado;
            _Total = Total;
            _Fecha = Fecha;
            _TipoVivienda = TipoVivienda;
            _Situacion = Situacion;
            _Propietario = Propietario;
            _ViviendaHabitual = ViviendaHabitual;
            _ViviendaAlquilada = ViviendaAlquilada;
            _CodigoPostal = CodigoPostal;
            _DeshabitadaPor3MesesAlAno = DeshabitadaPor3MesesAlAno;
            _AnoDeCostruccion = AnoDeCostruccion;
            _M2Vivienda = M2Vivienda;
            _M2EdificacionesAnexas = M2EdificacionesAnexas;
            _CapitalOtrasInstalaciones = CapitalOtrasInstalaciones;
            FechaHora = fechaHora;
            Tipo = tipo;
        }



    }
}
