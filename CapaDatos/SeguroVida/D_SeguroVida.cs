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
        public int D_Cargar_id_detalleSeguroSalud()
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CargarId";
            cmd.CommandType = CommandType.StoredProcedure;

            int rsp= Convert.ToInt32(cmd.ExecuteScalar());
            return rsp;
        }

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
        public void D_CargarNombreEmpleado(E_SeguroVida eSegVida)
        {

            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("CargarNombreEmpleado", strCon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parId = new SqlParameter
            {
                ParameterName = "@id",
                SqlDbType = SqlDbType.Int,
                Value = eSegVida.Id
            };
            cmd.Parameters.Add(parId);

            SqlParameter parNombre = new SqlParameter();
            parNombre.ParameterName = "@Nombre";
            parNombre.SqlDbType = SqlDbType.VarChar;
            parNombre.Size = 50;
            parNombre.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parNombre);

            SqlParameter parCedula = new SqlParameter();
            parCedula.ParameterName = "@Cedula";
            parCedula.SqlDbType = SqlDbType.VarChar;
            parCedula.Size = 30;
            parCedula.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(parCedula);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.Rows[0];

            eSegVida.NombreEmpleado = dr[1].ToString();
            eSegVida.Cedula = dr[0].ToString();
            strCon.Close();
        }
    }
}
