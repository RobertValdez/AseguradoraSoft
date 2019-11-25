using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PerlaDelSur_Entity.RegistroReclamos;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.RegistroReclamos
{
    public class D_RegistroReclamos
    {
        public DataTable CargarPolizasActivas(E_RegistroReclamos eReg)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CargarPolizasActivas";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parId_Cliente = new SqlParameter();
            parId_Cliente.ParameterName = "@IdCliente";
            parId_Cliente.SqlDbType = SqlDbType.Int;
            parId_Cliente.Value = eReg.IdCliente;
            cmd.Parameters.Add(parId_Cliente);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            strcon.Close();
            return dt;
        }
    }
}
