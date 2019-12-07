using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PerlaDelSur_Entity.Devoluciones;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Devoluciones
{
   public class D_Devoluciones
    {
        public int CrearDevolucion(E_Devoluciones eD)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CrearDevolucion";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paridCliente = new SqlParameter();
            paridCliente.ParameterName = "@idCliente";
            paridCliente.SqlDbType = SqlDbType.Int;
            paridCliente.Value = eD.IdCliente;
            cmd.Parameters.Add(paridCliente);

            SqlParameter parIdSolicitud = new SqlParameter();
            parIdSolicitud.ParameterName = "@idSolicitud";
            parIdSolicitud.SqlDbType = SqlDbType.Int;
            parIdSolicitud.Value = eD.IdSolicitud;
            cmd.Parameters.Add(parIdSolicitud);

            SqlParameter parIdPoliza = new SqlParameter();
            parIdPoliza.ParameterName = "@idPoliza";
            parIdPoliza.SqlDbType = SqlDbType.Int;
            parIdPoliza.Value = eD.IdPoliza;
            cmd.Parameters.Add(parIdPoliza);

            SqlParameter parADevolver = new SqlParameter();
            parADevolver.ParameterName = "@ADevolver";
            parADevolver.SqlDbType = SqlDbType.Decimal;
            parADevolver.Size = 18;
            parADevolver.Value = eD.A_Devolver;
            cmd.Parameters.Add(parADevolver);

            SqlParameter parMotivo = new SqlParameter();
            parMotivo.ParameterName = "@Motivo";
            parMotivo.SqlDbType = SqlDbType.VarChar;
            parMotivo.Value = eD.Motivo;
            cmd.Parameters.Add(parMotivo);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = eD.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            int a = cmd.ExecuteNonQuery();
            strcon.Close();
            return a;
        }
    }
}
