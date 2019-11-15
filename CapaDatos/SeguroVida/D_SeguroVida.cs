using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PerlaDelSur_Entity.SeguroVida;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.SeguroVida
{
    public class D_SeguroVida
    {
        public DataTable D_MostrarSegurosDePolizas()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("MostrarSegurosDePolizas", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            strCon.Close();
            return dt;
        }
        public DataTable D_CargarNombreEmpleado(E_SeguroVida eSegVida)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CargarNombreEmpleado";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parId = new SqlParameter();
            parId.ParameterName = "@id";
            parId.SqlDbType = SqlDbType.Int;
            parId.Value = eSegVida.Id;
            cmd.Parameters.Add(parId);

            SqlParameter parNombre = new SqlParameter();
            parNombre.ParameterName = "@Nombre";
            parNombre.SqlDbType = SqlDbType.VarChar;
            parNombre.Size = 50;
            parNombre.Direction = ParameterDirection.Output;
            parNombre.Value = eSegVida.NombreEmpleado;
            cmd.Parameters.Add(parNombre);

            SqlParameter parCedula = new SqlParameter();
            parCedula.ParameterName = "@Cedula";
            parCedula.SqlDbType = SqlDbType.VarChar;
            parCedula.Size = 30;
            parCedula.Direction = ParameterDirection.Output;
            parCedula.Value = eSegVida.Cedula;
            cmd.Parameters.Add(parCedula);

            DataTable Dt = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Dt.Rows.Add(String.Format("{0}", reader[0]));
            }

            SqlParameter parNombreReturn = cmd.Parameters["@Nombre"];
            SqlParameter parCedulaReturn = cmd.Parameters["@Cedula"];

            return Dt;
        }
    }
}
