using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PerlaDelSur_Entity.ResumenSolicitud;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.ResumenSolicitud
{
    public class D_ResumenSolicitud
    {
        public int CrearSolicitudEmpresas(E_ResumenSolicitud eSol)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CrearSolicitud";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdCliente = new SqlParameter();
            parIdCliente.ParameterName = "@IdCliente";
            parIdCliente.SqlDbType = SqlDbType.Int;
            parIdCliente.Value = eSol.IdCliente;
            cmd.Parameters.Add(parIdCliente);

            SqlParameter parIdEmpleado = new SqlParameter();
            parIdEmpleado.ParameterName = "@idEmpleado";
            parIdEmpleado.SqlDbType = SqlDbType.Int;
            parIdEmpleado.Value = eSol.IdEmpleado;
            cmd.Parameters.Add(parIdEmpleado);

            SqlParameter parTotal = new SqlParameter();
            parTotal.ParameterName = "@Total";
            parTotal.SqlDbType = SqlDbType.Decimal;
            parTotal.Size = 18;
            parTotal.Value = eSol.Total;
            cmd.Parameters.Add(parTotal);

            SqlParameter parFecha = new SqlParameter();
            parFecha.ParameterName = "@Fecha";
            parFecha.SqlDbType = SqlDbType.Date;
            parFecha.Value = eSol.Fecha;
            cmd.Parameters.Add(parFecha);


            SqlParameter parNombreEmpresa = new SqlParameter();
            parNombreEmpresa.ParameterName = "@NombreEmpresa";
            parNombreEmpresa.SqlDbType = SqlDbType.VarChar;
            parNombreEmpresa.Size = 80;
            parNombreEmpresa.Value = eSol.NombreEmpresa;
            cmd.Parameters.Add(parNombreEmpresa);

            SqlParameter parCopiaEstatutos = new SqlParameter();
            parCopiaEstatutos.ParameterName = "@CopiaEstatutos";
            parCopiaEstatutos.SqlDbType = SqlDbType.Image;
            parCopiaEstatutos.Value = eSol.CopiaEstatutos;
            cmd.Parameters.Add(parCopiaEstatutos);

            SqlParameter parCopiaActaAsignacionRNC = new SqlParameter();
            parCopiaActaAsignacionRNC.ParameterName = "@CopiaActaAsignacionRNC";
            parCopiaActaAsignacionRNC.SqlDbType = SqlDbType.Image;
            parCopiaActaAsignacionRNC.Value = eSol.CopiaActaDeAsignacionRNC;
            cmd.Parameters.Add(parCopiaActaAsignacionRNC);

            SqlParameter parCopiaCedulaPres_RepreAut = new SqlParameter();
            parCopiaCedulaPres_RepreAut.ParameterName = "@CopiaCedulaPres_RepreAut";
            parCopiaCedulaPres_RepreAut.SqlDbType = SqlDbType.Image;
            parCopiaCedulaPres_RepreAut.Value = eSol.CopiaCedulaPres_RepreAutorizado;
            cmd.Parameters.Add(parCopiaCedulaPres_RepreAut);

            SqlParameter parTelefonoEntAutorizadas = new SqlParameter();
            parTelefonoEntAutorizadas.ParameterName = "@TelefonoEntAutorizada";
            parTelefonoEntAutorizadas.SqlDbType = SqlDbType.VarChar;
            parTelefonoEntAutorizadas.Value = eSol.TelefonoEntidadAutorizada;
            cmd.Parameters.Add(parTelefonoEntAutorizadas);

            SqlParameter parCorreoElectronicoEntAutorizada = new SqlParameter();
            parCorreoElectronicoEntAutorizada.ParameterName = "@CorreoElectronicoEntAutorizada";
            parCorreoElectronicoEntAutorizada.SqlDbType = SqlDbType.VarChar;
            parCorreoElectronicoEntAutorizada.Value = eSol.CorreoElectronicoEntidadAutorizada;
            cmd.Parameters.Add(parCorreoElectronicoEntAutorizada);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = eSol.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parTipo = new SqlParameter();
            parTipo.ParameterName = "@Tipo";
            parTipo.SqlDbType = SqlDbType.VarChar;
            parTipo.Size = 50;
            parTipo.Value = eSol.Tipo;
            cmd.Parameters.Add(parTipo);


            SqlParameter parImagen1 = new SqlParameter();
            parImagen1.ParameterName = "@Imagen1";
            parImagen1.SqlDbType = SqlDbType.Image;
            parImagen1.Value = eSol.Imagen1;
            cmd.Parameters.Add(parImagen1);

            SqlParameter parImagen2 = new SqlParameter();
            parImagen2.ParameterName = "@Imagen2";
            parImagen2.SqlDbType = SqlDbType.Image;
            parImagen2.Value = eSol.Imagen2;
            cmd.Parameters.Add(parImagen2);

            SqlParameter parImagen3 = new SqlParameter();
            parImagen3.ParameterName = "@Imagen3";
            parImagen3.SqlDbType = SqlDbType.Image;
            parImagen3.Value = eSol.Imagen3;
            cmd.Parameters.Add(parImagen3);

            SqlParameter parImagen4 = new SqlParameter();
            parImagen4.ParameterName = "@Imagen4";
            parImagen4.SqlDbType = SqlDbType.Image;
            parImagen4.Value = eSol.Imagen4;
            cmd.Parameters.Add(parImagen4);

            SqlParameter parImagen5 = new SqlParameter();
            parImagen5.ParameterName = "@Imagen5";
            parImagen5.SqlDbType = SqlDbType.Image;
            parImagen5.Value = eSol.Imagen5;
            cmd.Parameters.Add(parImagen5);


            int a = cmd.ExecuteNonQuery();
            strcon.Close();
            return a;
        }

        public int CrearSolicitudEdificaciones(E_ResumenSolicitudEdificaciones eSd)
        {
            SqlConnection strcon = new SqlConnection();
            strcon.ConnectionString = Conexion.Conexion.SqlConex;
            strcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = strcon;
            cmd.CommandText = "CrearSolicitudSeguroEdificaciones";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdCliente = new SqlParameter();
            parIdCliente.ParameterName = "@IdCliente";
            parIdCliente.SqlDbType = SqlDbType.Int;
            parIdCliente.Value = eSd.IdCliente;
            cmd.Parameters.Add(parIdCliente);

            SqlParameter parIdEmpleado = new SqlParameter();
            parIdEmpleado.ParameterName = "@idEmpleado";
            parIdEmpleado.SqlDbType = SqlDbType.Int;
            parIdEmpleado.Value = eSd.IdEmpleado;
            cmd.Parameters.Add(parIdEmpleado);

            SqlParameter parTotal = new SqlParameter();
            parTotal.ParameterName = "@Total";
            parTotal.SqlDbType = SqlDbType.Decimal;
            parTotal.Size = 18;
            parTotal.Value = eSd.Total;
            cmd.Parameters.Add(parTotal);

            SqlParameter parFecha = new SqlParameter();
            parFecha.ParameterName = "@Fecha";
            parFecha.SqlDbType = SqlDbType.Date;
            parFecha.Value = eSd.Fecha;
            cmd.Parameters.Add(parFecha);


            SqlParameter parTipoVivienda = new SqlParameter();
            parTipoVivienda.ParameterName = "TipoVivienda";
            parTipoVivienda.SqlDbType = SqlDbType.VarChar;
            parTipoVivienda.Size = 50;
            parTipoVivienda.Value = eSd.TipoVivienda;
            cmd.Parameters.Add(parTipoVivienda);

            SqlParameter parSituacion = new SqlParameter();
            parSituacion.ParameterName = "@Situacion";
            parSituacion.SqlDbType = SqlDbType.VarChar;
            parSituacion.Size = 50;
            parSituacion.Value = eSd.Situacion;
            cmd.Parameters.Add(parSituacion);

            SqlParameter parPropietario = new SqlParameter();
            parPropietario.ParameterName = "@Propietario";
            parPropietario.SqlDbType = SqlDbType.VarChar;
            parPropietario.Size = 50;
            parPropietario.Value = eSd.Propietario;
            cmd.Parameters.Add(parPropietario);

            SqlParameter parViviendaHabitual = new SqlParameter();
            parViviendaHabitual.ParameterName = "@ViviendaHabitual";
            parViviendaHabitual.SqlDbType = SqlDbType.VarChar;
            parViviendaHabitual.Size = 4;
            parViviendaHabitual.Value = eSd.ViviendaHabitual;
            cmd.Parameters.Add(parViviendaHabitual);

            SqlParameter parViviendaAlquilada = new SqlParameter();
            parViviendaAlquilada.ParameterName = "@ViviendaAlquilada";
            parViviendaAlquilada.SqlDbType = SqlDbType.VarChar;
            parViviendaAlquilada.Size = 4;
            parViviendaAlquilada.Value = eSd.ViviendaAlquilada;
            cmd.Parameters.Add(parViviendaAlquilada);

            SqlParameter parCodigoPostal = new SqlParameter();
            parCodigoPostal.ParameterName = "@CodigoPostal";
            parCodigoPostal.SqlDbType = SqlDbType.VarChar;
            parCodigoPostal.Size = 15;
            parCodigoPostal.Value = eSd.CodigoPostal;
            cmd.Parameters.Add(parCodigoPostal);

            SqlParameter parDesabitadaPor3MesesAlAno = new SqlParameter();
            parDesabitadaPor3MesesAlAno.ParameterName = "@DesabitadaPor3MesesAlAno";
            parDesabitadaPor3MesesAlAno.SqlDbType = SqlDbType.VarChar;
            parDesabitadaPor3MesesAlAno.Size = 50;
            parDesabitadaPor3MesesAlAno.Value = eSd.DeshabitadaPor3MesesAlAno;
            cmd.Parameters.Add(parDesabitadaPor3MesesAlAno);

            SqlParameter parAnoConstruccion = new SqlParameter();
            parAnoConstruccion.ParameterName = "@AnoConstruccion";
            parAnoConstruccion.SqlDbType = SqlDbType.Int;
            parAnoConstruccion.Value = eSd.AnoDeCostruccion;
            cmd.Parameters.Add(parAnoConstruccion);

            SqlParameter parM2Vivienda = new SqlParameter();
            parM2Vivienda.ParameterName = "@M2Vivienda";
            parM2Vivienda.SqlDbType = SqlDbType.Decimal;
            parM2Vivienda.Size = 18;
            parM2Vivienda.Value = eSd.M2Vivienda;
            cmd.Parameters.Add(parM2Vivienda);

            SqlParameter parM2EdificacionesAnexas = new SqlParameter();
            parM2EdificacionesAnexas.ParameterName = "@M2EdificacionesAnexas";
            parM2EdificacionesAnexas.SqlDbType = SqlDbType.Decimal;
            parM2EdificacionesAnexas.Value = eSd.M2EdificacionesAnexas;
            cmd.Parameters.Add(parM2EdificacionesAnexas);

            SqlParameter parCapitalOtrasInstalaciones = new SqlParameter();
            parCapitalOtrasInstalaciones.ParameterName = "@CapitalOtrasInstalaciones";
            parCapitalOtrasInstalaciones.SqlDbType = SqlDbType.VarChar;
            parCapitalOtrasInstalaciones.Value = eSd.CapitalOtrasInstalaciones;
            cmd.Parameters.Add(parCapitalOtrasInstalaciones);

            SqlParameter parFechaHora = new SqlParameter();
            parFechaHora.ParameterName = "@FechaHora";
            parFechaHora.SqlDbType = SqlDbType.DateTime;
            parFechaHora.Value = eSd.FechaHora;
            cmd.Parameters.Add(parFechaHora);

            SqlParameter parTipo = new SqlParameter();
            parTipo.ParameterName = "@Tipo";
            parTipo.SqlDbType = SqlDbType.VarChar;
            parTipo.Size = 50;
            parTipo.Value = eSd.Tipo;
            cmd.Parameters.Add(parTipo);

            int a = cmd.ExecuteNonQuery();
            strcon.Close();
            return a;
        }
    }
}