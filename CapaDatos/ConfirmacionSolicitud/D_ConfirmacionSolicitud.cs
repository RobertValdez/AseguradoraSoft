using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PerlaDelSur_Entity.ConfirmacionSolicitud;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.ConfirmacionSolicitud
{
    public class D_ConfirmacionSolicitud
    {
        public DataTable D_MostrarSeguroVoluntario()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("MostrarDetalleSeguroVoluntario", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            strCon.Close();
            return dt;
        }
        public DataTable D_MostrarSeguroTodoRiesgo()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("MostrarDetalleSeguroTodoRiesgo", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            strCon.Close();
            return dt;
        }
        public DataTable D_MostrarSeguroSeguroObligatorio()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("MostrarDetalleSeguroObligatorio", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            strCon.Close();
            return dt;
        }
        public DataTable D_MostrarSeguroContenido()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("MostrarDetalleSeguroContenido", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            strCon.Close();
            return dt;
        }
        public DataTable D_MostrarSeguroEdificaciones()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("MostrarDetalleSeguroEdificaciones", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            strCon.Close();
            return dt;
        }
        public DataTable D_MostrarSeguroEmpresaNegocios()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("MostrarSeguroEmpresaNegocios", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            strCon.Close();
            return dt;
        }


        public int D_AprobarSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "AprobarSolicitud";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paridSolicitud = new SqlParameter();
            paridSolicitud.ParameterName = "@idSolicitud";
            paridSolicitud.SqlDbType = SqlDbType.Int;
            paridSolicitud.Value = eCon.IdSolicitud;
            cmd.Parameters.Add(paridSolicitud);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.Int;
            parEstado.Value = eCon.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = eCon.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int D_RechazarSolicitudSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "RechazarSolicitud";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paridSolicitud = new SqlParameter();
            paridSolicitud.ParameterName = "@idSolicitud";
            paridSolicitud.SqlDbType = SqlDbType.Int;
            paridSolicitud.Value = eCon.IdSolicitud;
            cmd.Parameters.Add(paridSolicitud);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.Int;
            parEstado.Value = eCon.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = eCon.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }



        public int D_AprobarSolicitudContenido(E_ConfirmacionSolicitud eCon)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "AprobarSolicitudContenido";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paridSolicitud = new SqlParameter();
            paridSolicitud.ParameterName = "@idSolicitud";
            paridSolicitud.SqlDbType = SqlDbType.Int;
            paridSolicitud.Value = eCon.IdSolicitud;
            cmd.Parameters.Add(paridSolicitud);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.Int;
            parEstado.Value = eCon.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = eCon.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int D_RechazarSolicitudContenido(E_ConfirmacionSolicitud eCon)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "RechazarSolicitud";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paridSolicitud = new SqlParameter();
            paridSolicitud.ParameterName = "@idSolicitud";
            paridSolicitud.SqlDbType = SqlDbType.Int;
            paridSolicitud.Value = eCon.IdSolicitud;
            cmd.Parameters.Add(paridSolicitud);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.Int;
            parEstado.Value = eCon.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = eCon.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }



        public int D_AprobarSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "AprobarSolicitud";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paridSolicitud = new SqlParameter();
            paridSolicitud.ParameterName = "@idSolicitud";
            paridSolicitud.SqlDbType = SqlDbType.Int;
            paridSolicitud.Value = eCon.IdSolicitud;
            cmd.Parameters.Add(paridSolicitud);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.Int;
            parEstado.Value = eCon.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = eCon.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int D_RechazarSolicitudSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "RechazarSolicitud";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paridSolicitud = new SqlParameter();
            paridSolicitud.ParameterName = "@idSolicitud";
            paridSolicitud.SqlDbType = SqlDbType.Int;
            paridSolicitud.Value = eCon.IdSolicitud;
            cmd.Parameters.Add(paridSolicitud);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.Int;
            parEstado.Value = eCon.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = eCon.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }



        public int D_AprobarSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "AprobarSolicitud";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paridSolicitud = new SqlParameter();
            paridSolicitud.ParameterName = "@idSolicitud";
            paridSolicitud.SqlDbType = SqlDbType.Int;
            paridSolicitud.Value = eCon.IdSolicitud;
            cmd.Parameters.Add(paridSolicitud);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.Int;
            parEstado.Value = eCon.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = eCon.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int D_RechazarSolicitudSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "RechazarSolicitud";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paridSolicitud = new SqlParameter();
            paridSolicitud.ParameterName = "@idSolicitud";
            paridSolicitud.SqlDbType = SqlDbType.Int;
            paridSolicitud.Value = eCon.IdSolicitud;
            cmd.Parameters.Add(paridSolicitud);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.Int;
            parEstado.Value = eCon.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = eCon.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }



        public int D_AprobarSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "AprobarSolicitud";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paridSolicitud = new SqlParameter();
            paridSolicitud.ParameterName = "@idSolicitud";
            paridSolicitud.SqlDbType = SqlDbType.Int;
            paridSolicitud.Value = eCon.IdSolicitud;
            cmd.Parameters.Add(paridSolicitud);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.Int;
            parEstado.Value = eCon.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = eCon.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int D_RechazarSolicitudSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "RechazarSolicitud";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paridSolicitud = new SqlParameter();
            paridSolicitud.ParameterName = "@idSolicitud";
            paridSolicitud.SqlDbType = SqlDbType.Int;
            paridSolicitud.Value = eCon.IdSolicitud;
            cmd.Parameters.Add(paridSolicitud);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.Int;
            parEstado.Value = eCon.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = eCon.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }



        public int D_AprobarSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "AprobarSolicitud";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paridSolicitud = new SqlParameter();
            paridSolicitud.ParameterName = "@idSolicitud";
            paridSolicitud.SqlDbType = SqlDbType.Int;
            paridSolicitud.Value = eCon.IdSolicitud;
            cmd.Parameters.Add(paridSolicitud);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.Int;
            parEstado.Value = eCon.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = eCon.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int D_RechazarSolicitudSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "RechazarSolicitud";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paridSolicitud = new SqlParameter();
            paridSolicitud.ParameterName = "@idSolicitud";
            paridSolicitud.SqlDbType = SqlDbType.Int;
            paridSolicitud.Value = eCon.IdSolicitud;
            cmd.Parameters.Add(paridSolicitud);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.Int;
            parEstado.Value = eCon.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = eCon.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }



        public int D_AprobarSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "AprobarSolicitud";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paridSolicitud = new SqlParameter();
            paridSolicitud.ParameterName = "@idSolicitud";
            paridSolicitud.SqlDbType = SqlDbType.Int;
            paridSolicitud.Value = eCon.IdSolicitud;
            cmd.Parameters.Add(paridSolicitud);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.Int;
            parEstado.Value = eCon.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = eCon.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int D_RechazarSolicitudSolicitudSeguroVoluntario(E_ConfirmacionSolicitud eCon)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "RechazarSolicitud";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter paridSolicitud = new SqlParameter();
            paridSolicitud.ParameterName = "@idSolicitud";
            paridSolicitud.SqlDbType = SqlDbType.Int;
            paridSolicitud.Value = eCon.IdSolicitud;
            cmd.Parameters.Add(paridSolicitud);

            SqlParameter parEstado = new SqlParameter();
            parEstado.ParameterName = "@Estado";
            parEstado.SqlDbType = SqlDbType.Int;
            parEstado.Value = eCon.Estado;
            cmd.Parameters.Add(parEstado);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = eCon.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

    }
}
