using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PerlaDelSur_Entity.ResumenVentaPoliza;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.ResumenVentaPoliza
{
    public class D_ResumenVentaPoliza
    {
        public int CrearPoliza(E_ResumenVentaPoliza rVPoliza)
        {
            /*
              exec CrearPoliza     1,1, 1.0, 1, '10-10-2019',
              'qwedasdasd','sdfsdf', '10-10-2019', 'eqwr',
                'sdfsafsadf',1, '10-10-2020'
                */


            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CrearPoliza";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdCliente = new SqlParameter();
            parIdCliente.ParameterName = "@IdCliente";
            parIdCliente.SqlDbType = SqlDbType.Int;
            parIdCliente.Value = rVPoliza.IdCliente;
            cmd.Parameters.Add(parIdCliente);

            SqlParameter parIdEmpleado = new SqlParameter();
            parIdEmpleado.ParameterName = "@idEmpleado";
            parIdEmpleado.SqlDbType = SqlDbType.Int;
            parIdEmpleado.Value = rVPoliza.IdEmpleado;
            cmd.Parameters.Add(parIdEmpleado);

            SqlParameter parTotal = new SqlParameter();
            parTotal.ParameterName = "@Total";
            parTotal.SqlDbType = SqlDbType.Decimal;
            parTotal.Size = 18;
            parTotal.Value = rVPoliza.Total;
            cmd.Parameters.Add(parTotal);

            SqlParameter parEstado_ctVida = new SqlParameter();
            parEstado_ctVida.ParameterName = "@Estado_ctVida";
            parEstado_ctVida.SqlDbType = SqlDbType.Int;
            parEstado_ctVida.Value = rVPoliza.EstadoPoliza;
            cmd.Parameters.Add(parEstado_ctVida);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Size = 50;
            parFechaHora.Value = rVPoliza.FechaHora;
            cmd.Parameters.Add(parFechaHora);


            SqlParameter parInstitutoDondeLabora = new SqlParameter();
            parInstitutoDondeLabora.ParameterName = "@InstitutoDondeLabora";
            parInstitutoDondeLabora.SqlDbType = SqlDbType.VarChar;
            parInstitutoDondeLabora.Size = 50;
            parInstitutoDondeLabora.Value = rVPoliza.InstitutoDondeLabora;
            cmd.Parameters.Add(parInstitutoDondeLabora);

            SqlParameter parAntecedentesPersonales = new SqlParameter();
            parAntecedentesPersonales.ParameterName = "@AntecedentesPersonales";
            parAntecedentesPersonales.SqlDbType = SqlDbType.VarChar;
            parAntecedentesPersonales.Value = rVPoliza.AntecedentesPersonales; ;
            cmd.Parameters.Add(parAntecedentesPersonales);

            SqlParameter parFecha = new SqlParameter();
            parFecha.ParameterName = "@Fecha";
            parFecha.SqlDbType = SqlDbType.Date;
            parFecha.Value = rVPoliza.Fecha;
            cmd.Parameters.Add(parFecha);

            SqlParameter parTipo = new SqlParameter();
            parTipo.ParameterName = "@Tipo";
            parTipo.SqlDbType = SqlDbType.VarChar;
            parTipo.Value = rVPoliza.Tipo;
            cmd.Parameters.Add(parTipo);

            SqlParameter parPoliza = new SqlParameter();
            parPoliza.ParameterName = "@Poliza";
            parPoliza.SqlDbType = SqlDbType.VarChar;
            parPoliza.Value = rVPoliza.Poliza;
            cmd.Parameters.Add(parPoliza);

            SqlParameter parEstadoPoliza = new SqlParameter();
            parEstadoPoliza.ParameterName = "@EstadoPoliza";
            parEstadoPoliza.SqlDbType = SqlDbType.Int;
            parEstadoPoliza.Size = 50;
            parEstadoPoliza.Value = rVPoliza.EstadoPoliza;
            cmd.Parameters.Add(parEstadoPoliza);

            SqlParameter parVencimiento = new SqlParameter();
            parVencimiento.ParameterName = "@Vencimiento";
            parVencimiento.SqlDbType = SqlDbType.Date;
            parVencimiento.Value = rVPoliza.Vencimiento;
            cmd.Parameters.Add(parVencimiento);


            int a = cmd.ExecuteNonQuery();
            cmd.Clone();
            return a;

        }
    }
}
