using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using PerlaDelSur_Entity.Poliza;
using CapaDatos.Poliza;

namespace CapaNegocio.Poliza
{
    public class B_Poliza
    {
        private D_Poliza D_Poliza = new D_Poliza();
        
        public int B_RenovarPoliza(E_Poliza ePol)
        {
            return D_Poliza.RenovarPoliza(ePol);
        }
        public int B_CancelarPoliza(E_Poliza ePol)
        {
            return D_Poliza.CancelarPoliza(ePol);
        }


        public DataTable B_MostrarSeguroContenido()
        {
            return D_Poliza.D_MostrarSeguroContenido();
        }
        public DataTable B_MostrarSeguroEdificaciones()
        {
            return D_Poliza.D_MostrarSeguroEdificaciones();
        }
        public DataTable B_MostrarSeguroEmpresasNegocios()
        {
            return D_Poliza.D_MostrarSeguroEmpresasNegocios();
        }
        public DataTable B_MostrarSeguroTodoRiesgo()
        {
            return D_Poliza.D_MostrarSeguroTodoRiesgo();
        }
        public DataTable B_MostrarSeguroObligatorio()
        {
            return D_Poliza.D_MostrarSeguroObligatorio();
        }
        public DataTable B_MostrarSeguroVoluntario()
        {
            return D_Poliza.D_MostrarSeguroVoluntario();
        }


        public int B_CrearPolizaContenido(E_Poliza ePol)
        {
            return D_Poliza.CrearPolizaSeguroContenido(ePol);
        }
        public int B_CrearPolizaEdificaciones(E_Poliza ePol)
        {
            return D_Poliza.CrearPolizaSeguroEdificaciones(ePol);
        }
        public int B_CrearPolizaSeguroEmpresasNegocio(E_Poliza ePol)
        {
            return D_Poliza.CrearPolizaSeguroEmpresasNegocios(ePol);
        }
        public int B_CrearPolizaSeguroTodoRiesgo(E_Poliza ePol)
        {
            return D_Poliza.CrearPolizaSeguroTodoRiesgo(ePol);
        }
        public int B_CrearPolizaSeguroObligatorio(E_Poliza ePol)
        {
            return D_Poliza.CrearPolizaSeguroObligatorio(ePol);
        }
        public int B_CrearPolizaSeguroVoluntario(E_Poliza ePol)
        {
            return D_Poliza.CrearPolizaSeguroVoluntario(ePol);
        }
    }
}
