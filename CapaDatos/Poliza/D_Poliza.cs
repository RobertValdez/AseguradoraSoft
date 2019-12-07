using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using PerlaDelSur_Entity.Poliza;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.Poliza
{
    public class D_Poliza
    {
       

        public int RenovarPoliza(E_Poliza ePol)
        {

            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "RenovacionPoliza";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdPoliza = new SqlParameter();
            parIdPoliza.ParameterName = "@IdPoliza";
            parIdPoliza.SqlDbType = SqlDbType.Int;
            parIdPoliza.Value = ePol.IdPoliza;
            cmd.Parameters.Add(parIdPoliza);

            SqlParameter parIdCliente = new SqlParameter();
            parIdCliente.ParameterName = "@IdCliente";
            parIdCliente.SqlDbType = SqlDbType.Int;
            parIdCliente.Value = ePol.IdCliente;
            cmd.Parameters.Add(parIdCliente);

            SqlParameter parIdEmpleado = new SqlParameter();
            parIdEmpleado.ParameterName = "@IdEmpleado";
            parIdEmpleado.SqlDbType = SqlDbType.Int;
            parIdEmpleado.Value = ePol.IdEmpleado;
            cmd.Parameters.Add(parIdEmpleado);

            SqlParameter parPoliza = new SqlParameter();
            parPoliza.ParameterName = "@Poliza";
            parPoliza.SqlDbType = SqlDbType.VarChar;
            parPoliza.Value = ePol.Poliza;
            cmd.Parameters.Add(parPoliza);

            SqlParameter parPrecio = new SqlParameter();
            parPrecio.ParameterName = "@Precio";
            parPrecio.SqlDbType = SqlDbType.Decimal;
            parPrecio.Value = ePol.Precio;
            cmd.Parameters.Add(parPrecio);

            SqlParameter parTPago = new SqlParameter();
            parTPago.ParameterName = "@T_Pago";
            parTPago.SqlDbType = SqlDbType.Decimal;
            parTPago.Value = ePol.TPago;
            cmd.Parameters.Add(parTPago);

            SqlParameter parParcial = new SqlParameter();
            parParcial.ParameterName = "@Parcial";
            parParcial.SqlDbType = SqlDbType.Decimal;
            parParcial.Value = ePol.Parcial;
            cmd.Parameters.Add(parParcial);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parVencimiento = new SqlParameter();
            parVencimiento.ParameterName = "@Vencimiento";
            parVencimiento.SqlDbType = SqlDbType.Date;
            parVencimiento.Value = ePol.Vencimiento;
            cmd.Parameters.Add(parVencimiento);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int CancelarPoliza(E_Poliza ePol)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CancelarPoliza";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdPoliza = new SqlParameter();
            parIdPoliza.ParameterName = "@IdPoliza";
            parIdPoliza.SqlDbType = SqlDbType.Int;
            parIdPoliza.Value = ePol.IdPoliza;
            cmd.Parameters.Add(parIdPoliza);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = ePol.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }


        public int RenovarPolizaEmpresaNegocio(E_Poliza ePol)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "RenovacionPolizaEmpresaNegocio";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdPoliza = new SqlParameter();
            parIdPoliza.ParameterName = "@IdPoliza";
            parIdPoliza.SqlDbType = SqlDbType.Int;
            parIdPoliza.Value = ePol.IdPoliza;
            cmd.Parameters.Add(parIdPoliza);

            SqlParameter parIdCliente = new SqlParameter();
            parIdCliente.ParameterName = "@IdCliente";
            parIdCliente.SqlDbType = SqlDbType.Int;
            parIdCliente.Value = ePol.IdCliente;
            cmd.Parameters.Add(parIdCliente);

            SqlParameter parIdEmpleado = new SqlParameter();
            parIdEmpleado.ParameterName = "@IdEmpleado";
            parIdEmpleado.SqlDbType = SqlDbType.Int;
            parIdEmpleado.Value = ePol.IdEmpleado;
            cmd.Parameters.Add(parIdEmpleado);

            SqlParameter parPoliza = new SqlParameter();
            parPoliza.ParameterName = "@Poliza";
            parPoliza.SqlDbType = SqlDbType.VarChar;
            parPoliza.Value = ePol.Poliza;
            cmd.Parameters.Add(parPoliza);

            SqlParameter parPrecio = new SqlParameter();
            parPrecio.ParameterName = "@Precio";
            parPrecio.SqlDbType = SqlDbType.Decimal;
            parPrecio.Value = ePol.Precio;
            cmd.Parameters.Add(parPrecio);

            SqlParameter parTPago = new SqlParameter();
            parTPago.ParameterName = "@T_Pago";
            parTPago.SqlDbType = SqlDbType.Decimal;
            parTPago.Value = ePol.TPago;
            cmd.Parameters.Add(parTPago);

            SqlParameter parParcial = new SqlParameter();
            parParcial.ParameterName = "@Parcial";
            parParcial.SqlDbType = SqlDbType.Decimal;
            parParcial.Value = ePol.Parcial;
            cmd.Parameters.Add(parParcial);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parVencimiento = new SqlParameter();
            parVencimiento.ParameterName = "@Vencimiento";
            parVencimiento.SqlDbType = SqlDbType.Date;
            parVencimiento.Value = ePol.Vencimiento;
            cmd.Parameters.Add(parVencimiento);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int CancelarPolizaEmpresaNegocio(E_Poliza ePol)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CancelarPolizaEmpresaNegocio";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdPoliza = new SqlParameter();
            parIdPoliza.ParameterName = "@IdPoliza";
            parIdPoliza.SqlDbType = SqlDbType.Int;
            parIdPoliza.Value = ePol.IdPoliza;
            cmd.Parameters.Add(parIdPoliza);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = ePol.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }


        public int RenovarPolizaVehiculo(E_Poliza ePol)
        {

            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "RenovacionPolizaVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdPoliza = new SqlParameter();
            parIdPoliza.ParameterName = "@IdPoliza";
            parIdPoliza.SqlDbType = SqlDbType.Int;
            parIdPoliza.Value = ePol.IdPoliza;
            cmd.Parameters.Add(parIdPoliza);

            SqlParameter parIdCliente = new SqlParameter();
            parIdCliente.ParameterName = "@IdCliente";
            parIdCliente.SqlDbType = SqlDbType.Int;
            parIdCliente.Value = ePol.IdCliente;
            cmd.Parameters.Add(parIdCliente);

            SqlParameter parIdEmpleado = new SqlParameter();
            parIdEmpleado.ParameterName = "@IdEmpleado";
            parIdEmpleado.SqlDbType = SqlDbType.Int;
            parIdEmpleado.Value = ePol.IdEmpleado;
            cmd.Parameters.Add(parIdEmpleado);

            SqlParameter parPoliza = new SqlParameter();
            parPoliza.ParameterName = "@Poliza";
            parPoliza.SqlDbType = SqlDbType.VarChar;
            parPoliza.Value = ePol.Poliza;
            cmd.Parameters.Add(parPoliza);

            SqlParameter parPrecio = new SqlParameter();
            parPrecio.ParameterName = "@Precio";
            parPrecio.SqlDbType = SqlDbType.Decimal;
            parPrecio.Value = ePol.Precio;
            cmd.Parameters.Add(parPrecio);

            SqlParameter parTPago = new SqlParameter();
            parTPago.ParameterName = "@T_Pago";
            parTPago.SqlDbType = SqlDbType.Decimal;
            parTPago.Value = ePol.TPago;
            cmd.Parameters.Add(parTPago);

            SqlParameter parParcial = new SqlParameter();
            parParcial.ParameterName = "@Parcial";
            parParcial.SqlDbType = SqlDbType.Decimal;
            parParcial.Value = ePol.Parcial;
            cmd.Parameters.Add(parParcial);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parVencimiento = new SqlParameter();
            parVencimiento.ParameterName = "@Vencimiento";
            parVencimiento.SqlDbType = SqlDbType.Date;
            parVencimiento.Value = ePol.Vencimiento;
            cmd.Parameters.Add(parVencimiento);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int CancelarPolizaVehiculo(E_Poliza ePol)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CancelarPolizaVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdPoliza = new SqlParameter();
            parIdPoliza.ParameterName = "@IdPoliza";
            parIdPoliza.SqlDbType = SqlDbType.Int;
            parIdPoliza.Value = ePol.IdPoliza;
            cmd.Parameters.Add(parIdPoliza);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = ePol.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }


        public int RenovarPolizaInmuebles(E_Poliza ePol)
        {

            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "RenovacionPolizaInmuebles";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdPoliza = new SqlParameter();
            parIdPoliza.ParameterName = "@IdPoliza";
            parIdPoliza.SqlDbType = SqlDbType.Int;
            parIdPoliza.Value = ePol.IdPoliza;
            cmd.Parameters.Add(parIdPoliza);

            SqlParameter parIdCliente = new SqlParameter();
            parIdCliente.ParameterName = "@IdCliente";
            parIdCliente.SqlDbType = SqlDbType.Int;
            parIdCliente.Value = ePol.IdCliente;
            cmd.Parameters.Add(parIdCliente);

            SqlParameter parIdEmpleado = new SqlParameter();
            parIdEmpleado.ParameterName = "@IdEmpleado";
            parIdEmpleado.SqlDbType = SqlDbType.Int;
            parIdEmpleado.Value = ePol.IdEmpleado;
            cmd.Parameters.Add(parIdEmpleado);

            SqlParameter parPoliza = new SqlParameter();
            parPoliza.ParameterName = "@Poliza";
            parPoliza.SqlDbType = SqlDbType.VarChar;
            parPoliza.Value = ePol.Poliza;
            cmd.Parameters.Add(parPoliza);

            SqlParameter parPrecio = new SqlParameter();
            parPrecio.ParameterName = "@Precio";
            parPrecio.SqlDbType = SqlDbType.Decimal;
            parPrecio.Value = ePol.Precio;
            cmd.Parameters.Add(parPrecio);

            SqlParameter parTPago = new SqlParameter();
            parTPago.ParameterName = "@T_Pago";
            parTPago.SqlDbType = SqlDbType.Decimal;
            parTPago.Value = ePol.TPago;
            cmd.Parameters.Add(parTPago);

            SqlParameter parParcial = new SqlParameter();
            parParcial.ParameterName = "@Parcial";
            parParcial.SqlDbType = SqlDbType.Decimal;
            parParcial.Value = ePol.Parcial;
            cmd.Parameters.Add(parParcial);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parVencimiento = new SqlParameter();
            parVencimiento.ParameterName = "@Vencimiento";
            parVencimiento.SqlDbType = SqlDbType.Date;
            parVencimiento.Value = ePol.Vencimiento;
            cmd.Parameters.Add(parVencimiento);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int CancelarPolizaInmuebles(E_Poliza ePol)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CancelarPolizaInmuebles";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdPoliza = new SqlParameter();
            parIdPoliza.ParameterName = "@IdPoliza";
            parIdPoliza.SqlDbType = SqlDbType.Int;
            parIdPoliza.Value = ePol.IdPoliza;
            cmd.Parameters.Add(parIdPoliza);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parNota = new SqlParameter();
            parNota.ParameterName = "@Nota";
            parNota.SqlDbType = SqlDbType.VarChar;
            parNota.Value = ePol.Nota;
            cmd.Parameters.Add(parNota);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }



        public int CrearPolizaSeguroContenido(E_Poliza ePol)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CrearPolizaSeguroContenido";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdCliente = new SqlParameter();
            parIdCliente.ParameterName = "@IdCliente";
            parIdCliente.SqlDbType = SqlDbType.Int;
            parIdCliente.Value = ePol.IdCliente;
            cmd.Parameters.Add(parIdCliente);

            SqlParameter parIdPolizaSeguro = new SqlParameter();
            parIdPolizaSeguro.ParameterName = "@IdPolizaSeguro";
            parIdPolizaSeguro.SqlDbType = SqlDbType.Int;
            parIdPolizaSeguro.Value = ePol.IdPolizaSeguro;
            cmd.Parameters.Add(parIdPolizaSeguro);

            SqlParameter parPoliza = new SqlParameter();
            parPoliza.ParameterName = "@Poliza";
            parPoliza.SqlDbType = SqlDbType.VarChar;
            parPoliza.Value = ePol.Poliza;
            cmd.Parameters.Add(parPoliza);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parVencimiento = new SqlParameter();
            parVencimiento.ParameterName = "@Vencimiento";
            parVencimiento.SqlDbType = SqlDbType.Date;
            parVencimiento.Value = ePol.Vencimiento;
            cmd.Parameters.Add(parVencimiento);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int CrearPolizaSeguroEdificaciones(E_Poliza ePol)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CrearPolizaSeguroEdificaciones";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdCliente = new SqlParameter();
            parIdCliente.ParameterName = "@IdCliente";
            parIdCliente.SqlDbType = SqlDbType.Int;
            parIdCliente.Value = ePol.IdCliente;
            cmd.Parameters.Add(parIdCliente);

            SqlParameter parIdPolizaSeguro = new SqlParameter();
            parIdPolizaSeguro.ParameterName = "@IdPolizaSeguro";
            parIdPolizaSeguro.SqlDbType = SqlDbType.Int;
            parIdPolizaSeguro.Value = ePol.IdPolizaSeguro;
            cmd.Parameters.Add(parIdPolizaSeguro);

            SqlParameter parPoliza = new SqlParameter();
            parPoliza.ParameterName = "@Poliza";
            parPoliza.SqlDbType = SqlDbType.VarChar;
            parPoliza.Value = ePol.Poliza;
            cmd.Parameters.Add(parPoliza);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parVencimiento = new SqlParameter();
            parVencimiento.ParameterName = "@Vencimiento";
            parVencimiento.SqlDbType = SqlDbType.Date;
            parVencimiento.Value = ePol.Vencimiento;
            cmd.Parameters.Add(parVencimiento);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int CrearPolizaSeguroEmpresasNegocios(E_Poliza ePol)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CrearPolizaSeguroEmpresaNegocio";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdCliente = new SqlParameter();
            parIdCliente.ParameterName = "@IdCliente";
            parIdCliente.SqlDbType = SqlDbType.Int;
            parIdCliente.Value = ePol.IdCliente;
            cmd.Parameters.Add(parIdCliente);

            SqlParameter parIdPolizaSeguro = new SqlParameter();
            parIdPolizaSeguro.ParameterName = "@IdPolizaSeguro";
            parIdPolizaSeguro.SqlDbType = SqlDbType.Int;
            parIdPolizaSeguro.Value = ePol.IdPolizaSeguro;
            cmd.Parameters.Add(parIdPolizaSeguro);

            SqlParameter parPoliza = new SqlParameter();
            parPoliza.ParameterName = "@Poliza";
            parPoliza.SqlDbType = SqlDbType.VarChar;
            parPoliza.Value = ePol.Poliza;
            cmd.Parameters.Add(parPoliza);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parVencimiento = new SqlParameter();
            parVencimiento.ParameterName = "@Vencimiento";
            parVencimiento.SqlDbType = SqlDbType.Date;
            parVencimiento.Value = ePol.Vencimiento;
            cmd.Parameters.Add(parVencimiento);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        } 

        public int CrearPolizaSeguroTodoRiesgo(E_Poliza ePol)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CrearPolizaSeguroTodoRiesgo";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdCliente = new SqlParameter();
            parIdCliente.ParameterName = "@IdCliente";
            parIdCliente.SqlDbType = SqlDbType.Int;
            parIdCliente.Value = ePol.IdCliente;
            cmd.Parameters.Add(parIdCliente);

            SqlParameter parIdPolizaSeguro = new SqlParameter();
            parIdPolizaSeguro.ParameterName = "@IdPolizaSeguro";
            parIdPolizaSeguro.SqlDbType = SqlDbType.Int;
            parIdPolizaSeguro.Value = ePol.IdPolizaSeguro;
            cmd.Parameters.Add(parIdPolizaSeguro);

            SqlParameter parPoliza = new SqlParameter();
            parPoliza.ParameterName = "@Poliza";
            parPoliza.SqlDbType = SqlDbType.VarChar;
            parPoliza.Value = ePol.Poliza;
            cmd.Parameters.Add(parPoliza);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parVencimiento = new SqlParameter();
            parVencimiento.ParameterName = "@Vencimiento";
            parVencimiento.SqlDbType = SqlDbType.Date;
            parVencimiento.Value = ePol.Vencimiento;
            cmd.Parameters.Add(parVencimiento);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int CrearPolizaSeguroObligatorio(E_Poliza ePol)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CrearPolizaSeguroObligatorio";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdCliente = new SqlParameter();
            parIdCliente.ParameterName = "@IdCliente";
            parIdCliente.SqlDbType = SqlDbType.Int;
            parIdCliente.Value = ePol.IdCliente;
            cmd.Parameters.Add(parIdCliente);

            SqlParameter parIdPolizaSeguro = new SqlParameter();
            parIdPolizaSeguro.ParameterName = "@IdPolizaSeguro";
            parIdPolizaSeguro.SqlDbType = SqlDbType.Int;
            parIdPolizaSeguro.Value = ePol.IdPolizaSeguro;
            cmd.Parameters.Add(parIdPolizaSeguro);

            SqlParameter parPoliza = new SqlParameter();
            parPoliza.ParameterName = "@Poliza";
            parPoliza.SqlDbType = SqlDbType.VarChar;
            parPoliza.Value = ePol.Poliza;
            cmd.Parameters.Add(parPoliza);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parVencimiento = new SqlParameter();
            parVencimiento.ParameterName = "@Vencimiento";
            parVencimiento.SqlDbType = SqlDbType.Date;
            parVencimiento.Value = ePol.Vencimiento;
            cmd.Parameters.Add(parVencimiento);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public int CrearPolizaSeguroVoluntario(E_Poliza ePol)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CrearPolizaSeguroVoluntario";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdCliente = new SqlParameter();
            parIdCliente.ParameterName = "@IdCliente";
            parIdCliente.SqlDbType = SqlDbType.Int;
            parIdCliente.Value = ePol.IdCliente;
            cmd.Parameters.Add(parIdCliente);

            SqlParameter parIdSeguro = new SqlParameter();
            parIdSeguro.ParameterName = "@IdPolizaSeguro";
            parIdSeguro.SqlDbType = SqlDbType.Int;
            parIdSeguro.Value = ePol.IdPolizaSeguro;
            cmd.Parameters.Add(parIdSeguro);

            SqlParameter parPoliza = new SqlParameter();
            parPoliza.ParameterName = "@Poliza";
            parPoliza.SqlDbType = SqlDbType.VarChar;
            parPoliza.Value = ePol.Poliza;
            cmd.Parameters.Add(parPoliza);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = ePol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parVencimiento = new SqlParameter();
            parVencimiento.ParameterName = "@Vencimiento";
            parVencimiento.SqlDbType = SqlDbType.Date;
            parVencimiento.Value = ePol.Vencimiento;
            cmd.Parameters.Add(parVencimiento);

            int rsp = cmd.ExecuteNonQuery();
            strcon.Close();
            return rsp;
        }

        public DataTable D_MostrarSeguroContenido()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("SeguroContenido", strCon);
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
            SqlCommand cmd = new SqlCommand("SeguroEdificaciones", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            strCon.Close();
            return dt;
        }
        public DataTable D_MostrarSeguroEmpresasNegocios()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("SeguroEmpresasNegocios", strCon);
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
            SqlCommand cmd = new SqlCommand("SeguroTodoRiesgo", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            strCon.Close();
            return dt;
        }
        public DataTable D_MostrarSeguroObligatorio()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("SeguroObligatorio", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            strCon.Close();
            return dt;
        }
        public DataTable D_MostrarSeguroVoluntario()
        {
            SqlConnection strCon = new SqlConnection();
            strCon.ConnectionString = Conexion.Conexion.SqlConex;
            SqlCommand cmd = new SqlCommand("SeguroVoluntario", strCon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            strCon.Close();
            return dt;
        }
    }
}