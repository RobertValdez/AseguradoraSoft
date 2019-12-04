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

        public int GuardarReclamo(E_RegistroReclamos eReg)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "GuardarReclamo";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter par_Area = new SqlParameter();
            par_Area.ParameterName = "@_Area";
            par_Area.SqlDbType = SqlDbType.Int;
            par_Area.Value = eReg.Area;
            cmd.Parameters.Add(par_Area);

            SqlParameter parIdCliente = new SqlParameter();
            parIdCliente.ParameterName = "@IdCliente";
            parIdCliente.SqlDbType = SqlDbType.Int;
            parIdCliente.Value = eReg.IdCliente;
            cmd.Parameters.Add(parIdCliente);

            SqlParameter parIdSiniestro = new SqlParameter();
            parIdSiniestro.ParameterName = "@IdSiniestro";
            parIdSiniestro.SqlDbType = SqlDbType.Int;
            parIdSiniestro.Value = eReg.IdSiniestro;
            cmd.Parameters.Add(parIdSiniestro);

            SqlParameter parIdPoliza = new SqlParameter();
            parIdPoliza.ParameterName = "@IdPoliza";
            parIdPoliza.SqlDbType = SqlDbType.VarChar;
            parIdPoliza.Value = eReg.IdSiniestro;
            cmd.Parameters.Add(parIdPoliza);

            SqlParameter parActaPolicial = new SqlParameter();
            parActaPolicial.ParameterName = "@ActaPolicial";
            parActaPolicial.SqlDbType = SqlDbType.Image;
            parActaPolicial.Value = eReg.ActaPolicial;
            cmd.Parameters.Add(parActaPolicial);

            SqlParameter parCopiaMatricula = new SqlParameter();
            parCopiaMatricula.ParameterName = "@CopiaMatricula";
            parCopiaMatricula.SqlDbType = SqlDbType.Image;
            parCopiaMatricula.Value = eReg.CopiaMatricula;
            cmd.Parameters.Add(parCopiaMatricula);

            SqlParameter parCopiaCedula = new SqlParameter();
            parCopiaCedula.ParameterName = "@CopiaCedula";
            parCopiaCedula.SqlDbType = SqlDbType.Image;
            parCopiaCedula.Value = eReg.CopiaCedula;
            cmd.Parameters.Add(parCopiaCedula);

            SqlParameter parCostoEstimado = new SqlParameter();
            parCostoEstimado.ParameterName = "@CostoEstimado";
            parCostoEstimado.SqlDbType = SqlDbType.Decimal;
            parCostoEstimado.Value = eReg.CostoEstimado;
            cmd.Parameters.Add(parCostoEstimado);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = eReg.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            int a = cmd.ExecuteNonQuery();
            strcon.Close();
            return a;
        }
    }
}
