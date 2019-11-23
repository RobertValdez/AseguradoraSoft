using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PerlaDelSur_Entity.Siniestro;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Siniestro
{
    public class D_Siniestro
    {
        public int GuardarSiniestro(E_Siniestro eSin)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "GuardarSiniestro";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parId_Cliente = new SqlParameter();
            parId_Cliente.ParameterName = "@Id_Cliente";
            parId_Cliente.SqlDbType = SqlDbType.Int;
            parId_Cliente.Value = eSin.IdCliente;
            cmd.Parameters.Add(parId_Cliente);

            SqlParameter parIdEmpleado = new SqlParameter();
            parIdEmpleado.ParameterName = "@Id_Empleado";
            parIdEmpleado.SqlDbType = SqlDbType.Int;
            parIdEmpleado.Value = eSin.IdEmpleado;
            cmd.Parameters.Add(parIdEmpleado);

            SqlParameter parSiniestro = new SqlParameter();
            parSiniestro.ParameterName = "@Siniestro";
            parSiniestro.SqlDbType = SqlDbType.VarChar;
            parSiniestro.Value = eSin.Siniestro;
            cmd.Parameters.Add(parSiniestro);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = eSin.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            int a = cmd.ExecuteNonQuery();
            strcon.Close();
            return a;
        }
    }
}