using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DataTable D_MostrarSegurooEdificaciones()
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
        //public DataTable D_MostrarSeguroVoluntario()
        //{
        //    SqlConnection strCon = new SqlConnection();
        //    strCon.ConnectionString = Conexion.Conexion.SqlConex;
        //    SqlCommand cmd = new SqlCommand("MostrarDetalleSeguroVoluntario", strCon);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    strCon.Close();
        //    return dt;
        //}
        //public DataTable D_MostrarSeguroVoluntario()
        //{
        //    SqlConnection strCon = new SqlConnection();
        //    strCon.ConnectionString = Conexion.Conexion.SqlConex;
        //    SqlCommand cmd = new SqlCommand("MostrarDetalleSeguroVoluntario", strCon);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    strCon.Close();
        //    return dt;
        //}
        //public DataTable D_MostrarSeguroVoluntario()
        //{
        //    SqlConnection strCon = new SqlConnection();
        //    strCon.ConnectionString = Conexion.Conexion.SqlConex;
        //    SqlCommand cmd = new SqlCommand("MostrarDetalleSeguroVoluntario", strCon);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    strCon.Close();
        //    return dt;
        //}
        //public DataTable D_MostrarSeguroVoluntario()
        //{
        //    SqlConnection strCon = new SqlConnection();
        //    strCon.ConnectionString = Conexion.Conexion.SqlConex;
        //    SqlCommand cmd = new SqlCommand("MostrarDetalleSeguroVoluntario", strCon);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    strCon.Close();
        //    return dt;
        //}
    }
}
