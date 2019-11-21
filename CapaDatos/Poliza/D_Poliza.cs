using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using PerlaDelSur_Entity.Poliza;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Poliza
{
    public class D_Poliza
    {
        public int RenovarPoliza(E_Poliza ePol)
        {

            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "RenovacionPoliza";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdPoliza = new SqlParameter();
            parIdPoliza.ParameterName = "@IdPoliza";
            parIdPoliza.SqlDbType = SqlDbType.Int;
            parIdPoliza.Value = ePol.IdPoliza;
            cmd.Parameters.Add(parIdPoliza);

            SqlParameter parIdCliente = new SqlParameter();
            parIdCliente.ParameterName = "@IdCliente";
            parIdCliente.SqlDbType = SqlDbType.Int;
            parIdCliente.Value = ePol.IdCliente;
            cmd.Parameters.Add(parIdCliente);

            SqlParameter parIdEmpleado = new SqlParameter();
            parIdEmpleado.ParameterName = "@IdEmpleado";
            parIdEmpleado.SqlDbType = SqlDbType.Int;
            parIdEmpleado.Value = ePol.IdEmpleado;
            cmd.Parameters.Add(parIdEmpleado);

            SqlParameter parPoliza = new SqlParameter();
            parPoliza.ParameterName = "@Poliza";
            parPoliza.SqlDbType = SqlDbType.VarChar;
            parPoliza.Value = ePol.Poliza;
            cmd.Parameters.Add(parPoliza);

            SqlParameter parPrecio = new SqlParameter();
            parPrecio.ParameterName = "@Precio";
            parPrecio.SqlDbType = SqlDbType.Decimal;
            parPrecio.Value = ePol.Precio;
            cmd.Parameters.Add(parPrecio);

            SqlParameter parTPago = new SqlParameter();
            parTPago.ParameterName = "@T_Pago";
            parTPago.SqlDbType = SqlDbType.Decimal;
            parTPago.Value = ePol.TPago;
            cmd.Parameters.Add(parTPago);

            SqlParameter parParcial = new SqlParameter();
            parParcial.ParameterName = "@Parcial";
            parParcial.SqlDbType = SqlDbType.Decimal;
            parParcial.Value = ePol.Parcial;
            cmd.Parameters.Add(parParcial);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parVencimiento = new SqlParameter();
            parVencimiento.ParameterName = "@Vencimiento";
            parVencimiento.SqlDbType = SqlDbType.Date;
            parVencimiento.Value = ePol.Vencimiento;
            cmd.Parameters.Add(parVencimiento);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int CancelarPoliza(E_Poliza ePol)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CancelarPoliza";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdPoliza = new SqlParameter();
            parIdPoliza.ParameterName = "@IdPoliza";
            parIdPoliza.SqlDbType = SqlDbType.Int;
            parIdPoliza.Value = ePol.IdPoliza;
            cmd.Parameters.Add(parIdPoliza);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = ePol.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }
    }
}