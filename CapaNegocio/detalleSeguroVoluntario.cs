//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaNegocio
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalleSeguroVoluntario
    {
        public int Id { get; set; }
        public int id_ctVehiculo { get; set; }
        public string Marca_de_Vehiculo { get; set; }
        public string Modelo { get; set; }
        public string Matricula { get; set; }
        public int Ano { get; set; }
        public int Cilindros { get; set; }
        public string Carroceria { get; set; }
        public string Categoria { get; set; }
        public string Uso { get; set; }
        public string Nota { get; set; }
        public int Estado { get; set; }
        public System.DateTime FechaHora { get; set; }
        public string Tipo { get; set; }
        public int idFactura { get; set; }
    }
}
