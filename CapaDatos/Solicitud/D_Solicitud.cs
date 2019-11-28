using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Solicitud
{
    public class D_Solicitud
    {
        public int D_Cargar_id_detalleSeguroEmpresaNegocio()
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CargarId_detalleSeguroEmpresa";
            cmd.CommandType = CommandType.StoredProcedure;

            int rsp = Convert.ToInt32(cmd.ExecuteScalar());
            return rsp;
        }

        public int D_Cargar_id_detalleSeguroEdificaciones()
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CargarId_detalleSeguroEdificaciones";
            cmd.CommandType = CommandType.StoredProcedure;

            int rsp = Convert.ToInt32(cmd.ExecuteScalar());
            return rsp;
        }

        public int D_Cargar_id_detalleSeguroContenido()
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CargarId_detalleSeguroContenido";
            cmd.CommandType = CommandType.StoredProcedure;

            int rsp = Convert.ToInt32(cmd.ExecuteScalar());
            return rsp;
        }
        public int D_Cargar_id_detalleSeguroVehiculoVoluntario()
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CargarId_detalleSeguroVoluntario";
            cmd.CommandType = CommandType.StoredProcedure;

            int rsp = Convert.ToInt32(cmd.ExecuteScalar());
            return rsp;
        }

        public int D_Cargar_id_detalleSeguroVehiculoTodoRiesgo()
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CargarId_detalleSeguroTodoRiesgo";
            cmd.CommandType = CommandType.StoredProcedure;
            
            int rsp = Convert.ToInt32(cmd.ExecuteScalar());
            return rsp;
        }
        public int D_Cargar_id_detalleSeguroVehiculoObligatorio()
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CargarId_detalleSeguroObligatorio";
            cmd.CommandType = CommandType.StoredProcedure;

            int rsp = Convert.ToInt32(cmd.ExecuteScalar());
            return rsp;
        }
    }
}
