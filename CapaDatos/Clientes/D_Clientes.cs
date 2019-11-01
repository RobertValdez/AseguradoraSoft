using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using PerlaDelSur_Entity.Clientes;

namespace CapaDatos.Clientes
{
    public class D_Clientes
    {
        public DataTable D_MostrarClientes()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("MostrarClientes", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            strCon.Close();
            return dt;
        }

        public int InsertarCliente(E_Clientes eClie)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "InsertarCliente";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parNombre = new SqlParameter();
            parNombre.ParameterName = "@Nombre";
            parNombre.SqlDbType = SqlDbType.VarChar;
            parNombre.Size = 50;
            parNombre.Value = eClie.Nombre;
            cmd.Parameters.Add(parNombre);

            SqlParameter parApellido = new SqlParameter();
            parApellido.ParameterName = "@Apellido";
            parApellido.SqlDbType = SqlDbType.VarChar;
            parApellido.Size = 50;
            parApellido.Value = eClie.Apellido;
            cmd.Parameters.Add(parApellido);

            SqlParameter parDireccion = new SqlParameter();
            parDireccion.ParameterName = "@Direccion";
            parDireccion.SqlDbType = SqlDbType.VarChar;
            parDireccion.Size = 100;
            parDireccion.Value = eClie.Direccion;
            cmd.Parameters.Add(parDireccion);

            SqlParameter parCedula = new SqlParameter();
            parCedula.ParameterName = "@Cedula";
            parCedula.SqlDbType = SqlDbType.VarChar;
            parCedula.Size = 30;
            parCedula.Value = eClie.Cedula;
            cmd.Parameters.Add(parCedula);

            SqlParameter parNacionalidad = new SqlParameter();
            parNacionalidad.ParameterName = "@Nacionalidad";
            parNacionalidad.SqlDbType = SqlDbType.VarChar;
            parNacionalidad.Size = 50;
            parNacionalidad.Value = eClie.Nacionalidad;
            cmd.Parameters.Add(parNacionalidad);

            SqlParameter parTelefono = new SqlParameter();
            parTelefono.ParameterName = "@Telefono";
            parTelefono.SqlDbType = SqlDbType.VarChar;
            parTelefono.Size = 15;
            parTelefono.Value = eClie.Telefono;
            cmd.Parameters.Add(parTelefono);

            SqlParameter parCorreoElectronico = new SqlParameter();
            parCorreoElectronico.ParameterName = "@CorreoElectronico";
            parCorreoElectronico.SqlDbType = SqlDbType.VarChar;
            parCorreoElectronico.Size = 50;
            parCorreoElectronico.Value = eClie.CorreoElectronico;
            cmd.Parameters.Add(parCorreoElectronico);

            SqlParameter parSexo = new SqlParameter();
            parSexo.ParameterName = "@Sexo";
            parSexo.SqlDbType = SqlDbType.VarChar;
            parSexo.Size = 1;
            parSexo.Value = eClie.Sexo;
            cmd.Parameters.Add(parSexo);

            SqlParameter parRNC = new SqlParameter();
            parRNC.ParameterName = "@RNC";
            parRNC.SqlDbType = SqlDbType.VarChar;
            parRNC.Size = 15;
            parRNC.Value = eClie.RNC;
            cmd.Parameters.Add(parRNC);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = eClie.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int ModificarEmpleado(E_Clientes eClie)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "ModificarCliente";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parId = new SqlParameter();
            parId.ParameterName = "@Id";
            parId.SqlDbType = SqlDbType.Int;
            parId.Value = eClie.Id;
            cmd.Parameters.Add(parId);

            SqlParameter parNombre = new SqlParameter();
            parNombre.ParameterName = "@Nombre";
            parNombre.SqlDbType = SqlDbType.VarChar;
            parNombre.Size = 50;
            parNombre.Value = eClie.Nombre;
            cmd.Parameters.Add(parNombre);

            SqlParameter parApellido = new SqlParameter();
            parApellido.ParameterName = "@Apellido";
            parApellido.SqlDbType = SqlDbType.VarChar;
            parApellido.Size = 50;
            parApellido.Value = eClie.Apellido;
            cmd.Parameters.Add(parApellido);

            SqlParameter parDireccion = new SqlParameter();
            parDireccion.ParameterName = "@Direccion";
            parDireccion.SqlDbType = SqlDbType.VarChar;
            parDireccion.Size = 100;
            parDireccion.Value = eClie.Direccion;
            cmd.Parameters.Add(parDireccion);

            SqlParameter parCedula = new SqlParameter();
            parCedula.ParameterName = "@Cedula";
            parCedula.SqlDbType = SqlDbType.VarChar;
            parCedula.Size = 30;
            parCedula.Value = eClie.Cedula;
            cmd.Parameters.Add(parCedula);

            SqlParameter parNacionalidad = new SqlParameter();
            parNacionalidad.ParameterName = "@Nacionalidad";
            parNacionalidad.SqlDbType = SqlDbType.VarChar;
            parNacionalidad.Size = 50;
            parNacionalidad.Value = eClie.Nacionalidad;
            cmd.Parameters.Add(parNacionalidad);

            SqlParameter parTelefono = new SqlParameter();
            parTelefono.ParameterName = "@Telefono";
            parTelefono.SqlDbType = SqlDbType.VarChar;
            parTelefono.Size = 15;
            parTelefono.Value = eClie.Telefono;
            cmd.Parameters.Add(parTelefono);

            SqlParameter parCorreoElectronico = new SqlParameter();
            parCorreoElectronico.ParameterName = "@CorreoElectronico";
            parCorreoElectronico.SqlDbType = SqlDbType.VarChar;
            parCorreoElectronico.Size = 50;
            parCorreoElectronico.Value = eClie.CorreoElectronico;
            cmd.Parameters.Add(parCorreoElectronico);

            SqlParameter parSexo = new SqlParameter();
            parSexo.ParameterName = "@Sexo";
            parSexo.SqlDbType = SqlDbType.VarChar;
            parSexo.Size = 1;
            parSexo.Value = eClie.Sexo;
            cmd.Parameters.Add(parSexo);

            SqlParameter parRNC = new SqlParameter();
            parRNC.ParameterName = "@RNC";
            parRNC.SqlDbType = SqlDbType.VarChar;
            parRNC.Size = 15;
            parRNC.Value = eClie.RNC;
            cmd.Parameters.Add(parRNC);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = eClie.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }
        public int EliminarCliente(E_Clientes eClie)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "EliminarCliente";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parId = new SqlParameter();
            parId.ParameterName = "@Id";
            parId.SqlDbType = SqlDbType.Int;
            parId.Value = eClie.Id;
            cmd.Parameters.Add(parId);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }
    }
}
