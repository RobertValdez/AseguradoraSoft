using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PerlaDelSur_Entity.Usuarios;

namespace CapaDatos.Usuarios
{
    public class D_Usuarios
    {
        public int ComprobarAcceso(E_Usuarios eUser)
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;

            SqlCommand cmd = new SqlCommand("ComprobarAcceso", strCon);

            SqlParameter parReturn = new SqlParameter();
            parReturn.ParameterName = "@Return";
            parReturn.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(parReturn);

            SqlParameter parNombreUsuario = new SqlParameter();
            parNombreUsuario.ParameterName = "@NombreUsuario";
            parNombreUsuario.SqlDbType = SqlDbType.VarChar;
            parNombreUsuario.Size = 20;
            parNombreUsuario.Value = eUser.NombreUsuario;
            cmd.Parameters.Add(parNombreUsuario);

            SqlParameter parContrasena = new SqlParameter();
            parContrasena.ParameterName = "@Contrasena";
            parContrasena.SqlDbType = SqlDbType.VarChar;
            parContrasena.Size = 30;
            parContrasena.Value = eUser.Contrasena;
            cmd.Parameters.Add(parContrasena);

            strCon.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            strCon.Close();

            return Convert.ToInt16(cmd.Parameters["@Return"].Value);
        }
    }
}
