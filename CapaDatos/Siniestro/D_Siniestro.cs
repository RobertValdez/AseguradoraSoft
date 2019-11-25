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
        public DataTable MostrarSiniestros()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("MostrarSiniestros", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            strCon.Close();
            return dt;
        }

        public string[,] CargarPolizasDeSeguros()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("CargarPolizasDeSeguros", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            strCon.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            string[,] strPolizas = new string[10,2];
            int count = 0;
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    strPolizas[count, 0] = Convert.ToString(reader.GetInt32(0));
                    strPolizas[count, 1] = reader.GetString(1);
                    count++;
                }
                reader.NextResult();
            }
            return strPolizas;
        }

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
        public string CargarPolizasActivas(E_Siniestro eSin)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CargarPolizasActivasEInactivas";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parId_Cliente = new SqlParameter();
            parId_Cliente.ParameterName = "@IdCliente";
            parId_Cliente.SqlDbType = SqlDbType.Int;
            parId_Cliente.Value = eSin.IdCliente;
            cmd.Parameters.Add(parId_Cliente);

            SqlDataReader reader = cmd.ExecuteReader();

            string strPolizas = "";
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    strPolizas += Environment.NewLine + " Número de Póliza:" + Environment.NewLine + 
                        "      "+reader.GetInt32(0) + Environment.NewLine + Environment.NewLine +
                        " Nombre del Seguro: " + Environment.NewLine +
                        "      " + reader.GetString(1) + Environment.NewLine + Environment.NewLine +
                        " Estado: " + Environment.NewLine +
                        "      " + reader.GetString(2) + Environment.NewLine + Environment.NewLine 
                        + "-----------------";
                }
                reader.NextResult();
            }

            strcon.Close();
            
            return strPolizas;
        }
    }
}