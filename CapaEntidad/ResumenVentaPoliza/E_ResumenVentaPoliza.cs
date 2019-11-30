using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlaDelSur_Entity.ResumenVentaPoliza
{
    public class E_ResumenVentaPoliza
    {
        private int _idSolicitud;
        private int _idSeguro;
        private string _T_Pago;
        private decimal _PagoParcial;
        private decimal _Descuento;

        private int _idCliente;
        private int _idEmpleado;
        private decimal _Total;                      // Entidad: ctVida
        private int _Estado;
        private DateTime _FechaHora;

        //private int _id_ctVida;
        private string _InstitutoDondeLabora;
        private string _AntecedentesPersonales;     //Entidad: detalleSeguroVida
        private DateTime _Fecha;
       // private string _Nota;
        private string _Tipo;

        private string _Poliza;
        private int _EstadoPoliza;                  //Entidad: vdPoliza
        private DateTime _Vencimiento;

        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdEmpleado { get => _idEmpleado; set => _idEmpleado = value; }
        public decimal Total { get => _Total; set => _Total = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public DateTime FechaHora { get => _FechaHora; set => _FechaHora = value; }

      //  public int Id_ctVida { get => _id_ctVida; set => _id_ctVida = value; }
        public string InstitutoDondeLabora { get => _InstitutoDondeLabora; set => _InstitutoDondeLabora = value; }
        public string AntecedentesPersonales { get => _AntecedentesPersonales; set => _AntecedentesPersonales = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
       // public string Nota { get => _Nota; set => _Nota = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }

        public string Poliza { get => _Poliza; set => _Poliza = value; }
        public int EstadoPoliza { get => _EstadoPoliza; set => _EstadoPoliza = value; }
        public DateTime Vencimiento { get => _Vencimiento; set => _Vencimiento = value; }
        public int IdSolicitud { get => _idSolicitud; set => _idSolicitud = value; }
        public int IdSeguro { get => _idSeguro; set => _idSeguro = value; }
        public string T_Pago { get => _T_Pago; set => _T_Pago = value; }
        public decimal PagoParcial { get => _PagoParcial; set => _PagoParcial = value; }
        public decimal Descuento { get => _Descuento; set => _Descuento = value; }

        public E_ResumenVentaPoliza()
        {

        }
        public E_ResumenVentaPoliza(int idCliente, int IdEmpleado, decimal Total, int Estado,
             DateTime FechaHora)
        {
            _idCliente = idCliente;
            _idEmpleado = IdEmpleado;
            _Total = Total;
            _Estado = Estado;
            _FechaHora = FechaHora;
        }

        public E_ResumenVentaPoliza( string InstitutoDondeLabora,
            string AntecedentesPersonales, DateTime Fecha, string Tipo, int idSolicitud, int idSeguro, string T_Pago, decimal PagoParcial, decimal Descuento)
        {
            
            _idSolicitud = idSolicitud;
            _idSeguro = idSeguro;
            _T_Pago = T_Pago;
            _PagoParcial = PagoParcial;
            _Descuento = Descuento;

            // _id_ctVida = Id_ctVida;
            _InstitutoDondeLabora = InstitutoDondeLabora;
            _AntecedentesPersonales = AntecedentesPersonales;
            _Fecha = Fecha;
         //   _Nota = Nota;
            _Tipo = Tipo;
        }
        public E_ResumenVentaPoliza(string Poliza, int estadoPoliza, DateTime Vencimiento)
        {
            _Poliza = Poliza;
            _EstadoPoliza = estadoPoliza;
            _Vencimiento = Vencimiento;
        }
    }
}