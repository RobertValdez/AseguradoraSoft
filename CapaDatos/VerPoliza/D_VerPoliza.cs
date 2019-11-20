using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PerlaDelSur_Entity; //
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.VerPoliza
{
    public class D_VerPoliza
    {
        public DataTable D_vd_MostrarPolizas()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("vd_MostrarPolizas", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            strCon.Close();
            return dt;
        }
    }
}
