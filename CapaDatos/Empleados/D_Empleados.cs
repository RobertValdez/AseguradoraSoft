using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad.Empleados;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos.Empleados
{
    public class D_Empleados
    {
        public DataTable D_MostrarEmpleados() 
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("MostrarEmpleados", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int InsertarEmpleado(E_Empleados eEmpl)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "InsertarEmpleado";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parNombre = new SqlParameter();
            parNombre.ParameterName = "@Nombre";
            parNombre.SqlDbType = SqlDbType.VarChar;
            parNombre.Size = 50;
            parNombre.Value = eEmpl.Nombre;
            cmd.Parameters.Add(parNombre);

            SqlParameter parApellido = new SqlParameter();
            parApellido.ParameterName = "@Apellido";
            parApellido.SqlDbType = SqlDbType.VarChar;
            parApellido.Size = 50;
            parApellido.Value = eEmpl.Apellido;
            cmd.Parameters.Add(parApellido);

            SqlParameter parDireccion = new SqlParameter();
            parDireccion.ParameterName = "@Direccion";
            parDireccion.SqlDbType = SqlDbType.VarChar;
            parDireccion.Size = 100;
            parDireccion.Value = eEmpl.Direccion;
            cmd.Parameters.Add(parDireccion);

            SqlParameter parCedula = new SqlParameter();
            parCedula.ParameterName = "@Cedula";
            parCedula.SqlDbType = SqlDbType.VarChar;
            parCedula.Size = 30;
            parCedula.Value = eEmpl.Cedula;
            cmd.Parameters.Add(parCedula);

            SqlParameter parTelefono = new SqlParameter();
            parTelefono.ParameterName = "@Telefono";
            parTelefono.SqlDbType = SqlDbType.VarChar;
            parTelefono.Size = 15;
            parTelefono.Value = eEmpl.Telefono;
            cmd.Parameters.Add(parTelefono);

            SqlParameter parCorreoElectronico = new SqlParameter();
            parCorreoElectronico.ParameterName = "@CorreoElectronico";
            parCorreoElectronico.SqlDbType = SqlDbType.VarChar;
            parCorreoElectronico.Size = 50;
            parCorreoElectronico.Value = eEmpl.CorreoElectronico;
            cmd.Parameters.Add(parCorreoElectronico);

            SqlParameter parIdCargo = new SqlParameter();
            parIdCargo.ParameterName = "@idCargo";
            parIdCargo.SqlDbType = SqlDbType.Int;
            parIdCargo.Value = eEmpl.IdCargo;
            cmd.Parameters.Add(parIdCargo);

            SqlParameter parSexo = new SqlParameter();
            parSexo.ParameterName = "@Sexo";
            parSexo.SqlDbType = SqlDbType.VarChar;
            parSexo.Size = 1;
            parSexo.Value = eEmpl.Sexo;
            cmd.Parameters.Add(parSexo);

            SqlParameter parFecha= new SqlParameter();
            parFecha.ParameterName = "@Fecha";
            parFecha.SqlDbType = SqlDbType.Date;
            parFecha.Value = eEmpl.Fecha;
            cmd.Parameters.Add(parFecha);


            return cmd.ExecuteNonQuery();
        }

        public int ModificarEmpleado(E_Empleados eEmpl)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "ModificarEmpleado";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parId = new SqlParameter();
            parId.ParameterName = "@Id";
            parId.SqlDbType = SqlDbType.Int;
            parId.Value = eEmpl.Id;
            cmd.Parameters.Add(parId);

            SqlParameter parNombre = new SqlParameter();
            parNombre.ParameterName = "@Nombre";
            parNombre.SqlDbType = SqlDbType.VarChar;
            parNombre.Size = 50;
            parNombre.Value = eEmpl.Nombre;
            cmd.Parameters.Add(parNombre);

            SqlParameter parApellido = new SqlParameter();
            parApellido.ParameterName = "@Apellido";
            parApellido.SqlDbType = SqlDbType.VarChar;
            parApellido.Size = 50;
            parApellido.Value = eEmpl.Apellido;
            cmd.Parameters.Add(parApellido);

            SqlParameter parDireccion = new SqlParameter();
            parDireccion.ParameterName = "@Direccion";
            parDireccion.SqlDbType = SqlDbType.VarChar;
            parDireccion.Size = 100;
            parDireccion.Value = eEmpl.Direccion;
            cmd.Parameters.Add(parDireccion);

            SqlParameter parCedula = new SqlParameter();
            parCedula.ParameterName = "@Cedula";
            parCedula.SqlDbType = SqlDbType.VarChar;
            parCedula.Size = 30;
            parCedula.Value = eEmpl.Cedula;
            cmd.Parameters.Add(parCedula);

            SqlParameter parTelefono = new SqlParameter();
            parTelefono.ParameterName = "@Telefono";
            parTelefono.SqlDbType = SqlDbType.VarChar;
            parTelefono.Size = 15;
            parTelefono.Value = eEmpl.Telefono;
            cmd.Parameters.Add(parTelefono);

            SqlParameter parCorreoElectronico = new SqlParameter();
            parCorreoElectronico.ParameterName = "@CorreoElectronico";
            parCorreoElectronico.SqlDbType = SqlDbType.VarChar;
            parCorreoElectronico.Size = 50;
            parCorreoElectronico.Value = eEmpl.CorreoElectronico;
            cmd.Parameters.Add(parCorreoElectronico);

            SqlParameter parIdCargo = new SqlParameter();
            parIdCargo.ParameterName = "@idCargo";
            parIdCargo.SqlDbType = SqlDbType.Int;
            parIdCargo.Value = eEmpl.IdCargo;
            cmd.Parameters.Add(parIdCargo);

            SqlParameter parSexo = new SqlParameter();
            parSexo.ParameterName = "@Sexo";
            parSexo.SqlDbType = SqlDbType.VarChar;
            parSexo.Size = 1;
            parSexo.Value = eEmpl.Sexo;
            cmd.Parameters.Add(parSexo);

            SqlParameter parFecha = new SqlParameter();
            parFecha.ParameterName = "@Fecha";
            parFecha.SqlDbType = SqlDbType.Date;
            parFecha.Value = eEmpl.Fecha;
            cmd.Parameters.Add(parFecha);


            return cmd.ExecuteNonQuery();
        }
    }
}
