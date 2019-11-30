using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using PerlaDelSur_Entity.Vehiculo;
using PerlaDelSur_Entity.ResumenSolicitud;
using CapaNegocio.ResumenSolicitud;
using System.Globalization;

namespace CapaPresentacion
{
    public partial class frmFacturas : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,
            int wmsg, int wparam, int lparam);

        B_ResumenSolicitud B_ResumenSolicitud = new B_ResumenSolicitud();

        E_Vehiculo E_Vehiculo = new E_Vehiculo();

        public frmFacturas()
        {
            InitializeComponent();
        }

        private void pnlResumenSolicitud_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmFacturas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            cmbTipoPago.SelectedIndex = 0;
        }

        private void btnDescontar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDescontar.Text) ||
                    !string.IsNullOrWhiteSpace(txtDescontar.Text))
                {
                    string strPorCiento = "";

                    decimal CantidadTotal = Convert.ToDecimal(txtSubTotal.Text);

                    strPorCiento = "0." + txtDescontar.Text;
                    decimal PorCiento = Convert.ToDecimal(strPorCiento, CultureInfo.InvariantCulture);

                    decimal C = CantidadTotal * PorCiento;

                    decimal P = CantidadTotal - C;

                    decimal Round_A = Math.Round(C, 2);
                    txtDescuento.Text = Round_A.ToString();


                    txtTotalA_Pagar.Text = Math.Round(P, 2).ToString();
                }
            }
            catch (Exception)
            { }
        }
        private void txtDescontar_Validating(object sender, CancelEventArgs e)
        {

        }

        private void cmbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPago.Text == "Parcial")
            {
                lblParcial.Visible = true;
                txtParcial.Visible = true;
            }
            else
            {
                lblParcial.Visible = false;
                txtParcial.Visible = false;
            }
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSeguroA_Adquirir.Text == "Seguro Negocios y Empresas" && ValueParcial() == true)
                {
                    SolicitarEmpresasNegocios();
                }
                else if (txtSeguroA_Adquirir.Text == "Seguro Edificaciones" && ValueParcial() == true)
                {
                    SolicitarEdificaciones();
                }
                else if (txtSeguroA_Adquirir.Text == "Seguro Contenido" && ValueParcial() == true)
                {
                    SolicitarContenido();
                }
                else if (txtSeguroA_Adquirir.Text == "Seguro Voluntario" && ValueParcial() == true)
                {
                    SolicitarVEHvoluntario();
                }
                else if (txtSeguroA_Adquirir.Text == "Seguro Todo Riesgo" && ValueParcial() == true)
                {
                    SolicitarVEHtodoRiesgo();
                }
                else if (txtSeguroA_Adquirir.Text == "Seguro Obligatorio" && ValueParcial() == true)
                {
                    SolicitarVEHobligatorio();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }





        public string strMarcaVehiculoObl;
        public string strModeloObl;
        public string strMatriculaObl;
        public int intAnoObl;
        public int intCilindrosObl;
        public string strCarroceriaObl;
        public string strCategoriaObl;
        public string strUsoObl;

        private void SolicitarVEHobligatorio()
        {
            E_Vehiculo.IdCliente = Convert.ToInt32(txtId.Text);
            E_Vehiculo.IdEmpleado = varIdEmpleado;
            E_Vehiculo.Total = Convert.ToDecimal(txtTotalA_Pagar.Text);
            E_Vehiculo.Fecha = DateTime.Now.Date;

            E_Vehiculo.MarcaVehiculo = strMarcaVehiculoObl;
            E_Vehiculo.Modelo = strModeloObl;
            E_Vehiculo.Matricula = strMatriculaObl;
            E_Vehiculo.Ano = intAnoObl;
            E_Vehiculo.Cilindros = intCilindrosObl;
            E_Vehiculo.Carroceria = strCarroceriaObl;
            E_Vehiculo.Categoria = strCategoriaObl;
            E_Vehiculo.Uso = strUsoObl;

            E_Vehiculo.IdSolicitud = Convert.ToInt32(txtCodigo.Text);
            E_Vehiculo.IdSeguro = Convert.ToInt32(txtIdSeguro.Text);
            E_Vehiculo.T_Pago = cmbTipoPago.Text;


            if (string.IsNullOrEmpty(txtParcial.Text) ||
                    string.IsNullOrWhiteSpace(txtParcial.Text))
            {
                E_Vehiculo.PagoParcial = 0.0m;
            }
            else
            {
                E_Vehiculo.PagoParcial = Convert.ToDecimal(txtParcial.Text);
            }
            if (string.IsNullOrEmpty(txtDescuento.Text) ||
                string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                E_Vehiculo.Descuento = 0.0m;
            }
            else
            {
                E_Vehiculo.Descuento = Convert.ToDecimal(txtDescuento.Text);
            }

            E_Vehiculo.FechaHora = DateTime.Now;
            E_Vehiculo.Tipo = txtCategoria.Text;


            if (MessageBox.Show("Se creará una solicitud para el cliente actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ResumenSolicitud.B_CrearSolicitudVEHobligatorio(E_Vehiculo) >= 2)
                {
                    MessageBox.Show("Solicitud creada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

















        public string strMarcaVehiculoTR;
        public string strModeloTR;
        public string strMatriculaTR;
        public int intAnoTR;
        public int intCilindrosTR;
        public string strCarroceriaTR;
        public string strCategoriaTR;
        public string strUsoTR;

        private void SolicitarVEHtodoRiesgo()
        {
            E_Vehiculo.IdCliente = Convert.ToInt32(txtId.Text);
            E_Vehiculo.IdEmpleado = varIdEmpleado;
            E_Vehiculo.Total = Convert.ToDecimal(txtTotalA_Pagar.Text);
            E_Vehiculo.Fecha = DateTime.Now.Date;

            E_Vehiculo.MarcaVehiculo = strMarcaVehiculoTR;
            E_Vehiculo.Modelo = strModeloTR;
            E_Vehiculo.Matricula = strMatriculaTR;
            E_Vehiculo.Ano = intAnoTR;
            E_Vehiculo.Cilindros = intCilindrosTR;
            E_Vehiculo.Carroceria = strCarroceriaTR;
            E_Vehiculo.Categoria = strCategoriaTR;
            E_Vehiculo.Uso = strUsoTR;

            E_Vehiculo.IdSolicitud = Convert.ToInt32(txtCodigo.Text);
            E_Vehiculo.IdSeguro = Convert.ToInt32(txtIdSeguro.Text);
            E_Vehiculo.T_Pago = cmbTipoPago.Text;



            if (string.IsNullOrEmpty(txtParcial.Text) ||
                    string.IsNullOrWhiteSpace(txtParcial.Text))
            {
                E_Vehiculo.PagoParcial = 0.0m;
            }
            else
            {
                E_Vehiculo.PagoParcial = Convert.ToDecimal(txtParcial.Text);
            }
            if (string.IsNullOrEmpty(txtDescuento.Text) ||
                string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                E_Vehiculo.Descuento = 0.0m;
            }
            else
            {
                E_Vehiculo.Descuento = Convert.ToDecimal(txtDescuento.Text);
            }

            E_Vehiculo.FechaHora = DateTime.Now;
            E_Vehiculo.Tipo = txtCategoria.Text;


            if (MessageBox.Show("Se creará una solicitud para el cliente actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ResumenSolicitud.B_CrearSolicitudVEHtodoRiesgo(E_Vehiculo) >= 2)
                {
                    MessageBox.Show("Solicitud creada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }




















        public string strMarcaVehiculoVol;
        public string strModeloVol;
        public string strMatriculaVol;
        public int intAnoVol;
        public int intCilindrosVol;
        public string strCarroceriaVol;
        public string strCategoriaVol;
        public string strUsoVol;

        private void SolicitarVEHvoluntario()
        {
            E_Vehiculo.IdCliente = Convert.ToInt32(txtId.Text);
            E_Vehiculo.IdEmpleado = varIdEmpleado;
            E_Vehiculo.Total = Convert.ToDecimal(txtTotalA_Pagar.Text);
            E_Vehiculo.Fecha = DateTime.Now.Date;

            E_Vehiculo.MarcaVehiculo = strMarcaVehiculoVol;
            E_Vehiculo.Modelo = strModeloVol;
            E_Vehiculo.Matricula = strMatriculaVol;
            E_Vehiculo.Ano = intAnoVol;
            E_Vehiculo.Cilindros = intCilindrosVol;
            E_Vehiculo.Carroceria = strCarroceriaVol;
            E_Vehiculo.Categoria = strCategoriaVol;
            E_Vehiculo.Uso = strUsoVol;

            E_Vehiculo.IdSolicitud = Convert.ToInt32(txtCodigo.Text);
            E_Vehiculo.IdSeguro = Convert.ToInt32(txtIdSeguro.Text);
            E_Vehiculo.T_Pago = cmbTipoPago.Text;



            if (string.IsNullOrEmpty(txtParcial.Text) ||
                    string.IsNullOrWhiteSpace(txtParcial.Text))
            {
                E_Vehiculo.PagoParcial = 0.0m;
            }
            else
            {
                E_Vehiculo.PagoParcial = Convert.ToDecimal(txtParcial.Text);
            }
            if (string.IsNullOrEmpty(txtDescuento.Text) ||
                string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                E_Vehiculo.Descuento = 0.0m;
            }
            else
            {
                E_Vehiculo.Descuento = Convert.ToDecimal(txtDescuento.Text);
            }

            E_Vehiculo.FechaHora = DateTime.Now;
            E_Vehiculo.Tipo = txtCategoria.Text;


            if (MessageBox.Show("Se creará una solicitud para el cliente actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ResumenSolicitud.B_CrearSolicitudVEHvoluntario(E_Vehiculo) >= 2)
                {
                    MessageBox.Show("Solicitud creada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


















        public string strTipoViviendaCont;
        public string strSituacionCont;
        public string strPropietarioCont;
        public string strViviendaHabitualCont;
        public string strViviendaAlquiladaCont;
        public string strCodigoPostalCont;
        public string strDeshabitadaPor3MesesAlAnoCont;
        public int intAnoDeCostruccionCont;
        public decimal decM2ViviendaCont;
        public string strDescripcionMueblesCont;
        public int strValorEstimadoMueblesCont;

        private void SolicitarContenido()
        {
            E_ResumenSolicitudEdificaciones.IdCliente = Convert.ToInt32(txtId.Text);
            E_ResumenSolicitudEdificaciones.IdEmpleado = varIdEmpleado;
            E_ResumenSolicitudEdificaciones.Total = Convert.ToDecimal(txtTotalA_Pagar.Text);

            E_ResumenSolicitudEdificaciones.Fecha = DateTime.Now.Date;

            E_ResumenSolicitudEdificaciones.TipoVivienda = strTipoViviendaCont;
            E_ResumenSolicitudEdificaciones.Situacion = strSituacionCont;
            E_ResumenSolicitudEdificaciones.Propietario = strPropietarioCont;
            E_ResumenSolicitudEdificaciones.ViviendaHabitual = strViviendaHabitualCont;
            E_ResumenSolicitudEdificaciones.ViviendaAlquilada = strViviendaAlquiladaCont;
            E_ResumenSolicitudEdificaciones.CodigoPostal = strCodigoPostalCont;
            E_ResumenSolicitudEdificaciones.DeshabitadaPor3MesesAlAno = strDeshabitadaPor3MesesAlAnoCont;
            E_ResumenSolicitudEdificaciones.AnoDeCostruccion = intAnoDeCostruccionCont;
            E_ResumenSolicitudEdificaciones.M2Vivienda = decM2ViviendaCont;
            E_ResumenSolicitudEdificaciones.DescripcionMuebles = strDescripcionMueblesCont;
            E_ResumenSolicitudEdificaciones.ValorEstimadoMuebles = strValorEstimadoMueblesCont;

            E_ResumenSolicitudEdificaciones.IdSolicitud = Convert.ToInt32(txtCodigo.Text);
            E_ResumenSolicitudEdificaciones.IdSeguro = Convert.ToInt32(txtIdSeguro.Text);
            E_ResumenSolicitudEdificaciones.T_Pago = cmbTipoPago.Text;



            if (string.IsNullOrEmpty(txtParcial.Text) ||
                    string.IsNullOrWhiteSpace(txtParcial.Text))
            {
                E_ResumenSolicitudEdificaciones.PagoParcial = 0.0m;
            }
            else
            {
                E_ResumenSolicitudEdificaciones.PagoParcial = Convert.ToDecimal(txtParcial.Text);
            }
            if (string.IsNullOrEmpty(txtDescuento.Text) ||
                string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                E_ResumenSolicitudEdificaciones.Descuento = 0.0m;
            }
            else
            {
                E_ResumenSolicitudEdificaciones.Descuento = Convert.ToDecimal(txtDescuento.Text);
            }


            E_ResumenSolicitudEdificaciones.FechaHora = DateTime.Now;
            E_ResumenSolicitudEdificaciones.Tipo = txtCategoria.Text;


            if (MessageBox.Show("Se creará una solicitud para el cliente actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ResumenSolicitud.B_CrearSolicitudContendio(E_ResumenSolicitudEdificaciones) >= 2)
                {
                    MessageBox.Show("Solicitud creada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }














        E_ResumenSolicitudEdificaciones E_ResumenSolicitudEdificaciones =
            new E_ResumenSolicitudEdificaciones();

        public string strTipoVivienda;
        public string strSituacion;
        public string strPropietario;
        public string strViviendaHabitual;
        public string strViviendaAlquilada;
        public string strCodigoPostal;
        public string strDeshabitadaPor3MesesAlAno;
        public int strAnoDeCostruccion;
        public decimal decM2Vivienda;
        public decimal decM2EdificacionesAnexas;
        public string strCapitalOtrasInstalaciones;

        private void SolicitarEdificaciones()
        {
            E_ResumenSolicitudEdificaciones.IdCliente = Convert.ToInt32(txtId.Text);
            E_ResumenSolicitudEdificaciones.IdEmpleado = varIdEmpleado;
            E_ResumenSolicitudEdificaciones.Total = Convert.ToDecimal(txtTotalA_Pagar.Text);

            E_ResumenSolicitudEdificaciones.Fecha = DateTime.Now.Date;

            E_ResumenSolicitudEdificaciones.TipoVivienda = strTipoVivienda;
            E_ResumenSolicitudEdificaciones.Situacion = strSituacion;
            E_ResumenSolicitudEdificaciones.Propietario = strPropietario;
            E_ResumenSolicitudEdificaciones.ViviendaHabitual = strViviendaHabitual;
            E_ResumenSolicitudEdificaciones.ViviendaAlquilada = strViviendaAlquilada;
            E_ResumenSolicitudEdificaciones.CodigoPostal = strCodigoPostal;
            E_ResumenSolicitudEdificaciones.DeshabitadaPor3MesesAlAno = strDeshabitadaPor3MesesAlAno;
            E_ResumenSolicitudEdificaciones.AnoDeCostruccion = strAnoDeCostruccion;
            E_ResumenSolicitudEdificaciones.M2Vivienda = decM2Vivienda;
            E_ResumenSolicitudEdificaciones.M2EdificacionesAnexas = decM2EdificacionesAnexas;
            E_ResumenSolicitudEdificaciones.CapitalOtrasInstalaciones = strCapitalOtrasInstalaciones;

            E_ResumenSolicitudEdificaciones.IdSolicitud = Convert.ToInt32(txtCodigo.Text);
            E_ResumenSolicitudEdificaciones.IdSeguro = Convert.ToInt32(txtIdSeguro.Text);
            E_ResumenSolicitudEdificaciones.T_Pago = cmbTipoPago.Text;



            if (string.IsNullOrEmpty(txtParcial.Text) ||
                    string.IsNullOrWhiteSpace(txtParcial.Text))
            {
                E_ResumenSolicitudEdificaciones.PagoParcial = 0.0m;
            }
            else
            {
                E_ResumenSolicitudEdificaciones.PagoParcial = Convert.ToDecimal(txtParcial.Text);
            }
            if (string.IsNullOrEmpty(txtDescuento.Text) ||
                string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                E_ResumenSolicitudEdificaciones.Descuento = 0.0m;
            }
            else
            {
                E_ResumenSolicitudEdificaciones.Descuento = Convert.ToDecimal(txtDescuento.Text);
            }


            E_ResumenSolicitudEdificaciones.FechaHora = DateTime.Now;
            E_ResumenSolicitudEdificaciones.Tipo = txtCategoria.Text;


            if (MessageBox.Show("Se creará una solicitud para el cliente actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if ( B_ResumenSolicitud.B_CrearSolicitudEdificaciones(E_ResumenSolicitudEdificaciones) >= 2)
                {
                    MessageBox.Show("Solicitud creada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }






        E_ResumenSolicitud E_ResumenSolicitud = new E_ResumenSolicitud();

        public int varIdEmpleado;

        public byte[] imgCopiaEstatutos = null;
        public byte[] imgCopiaActaAsignacionRNC = null;
        public byte[] imgCopiaCedulaPresidente_RepresAut = null;
        public string strTelefonoEntAut;

        public string CorreoElectronicoEntidadAutorizada;

        public byte[] imgImagen1 = null;
        public byte[] imgImagen2 = null;
        public byte[] imgImagen3 = null;
        public byte[] imgImagen4 = null;
        public byte[] imgImagen5 = null;

        private void SolicitarEmpresasNegocios()
        {
            E_ResumenSolicitud.IdCliente = Convert.ToInt32(txtId.Text);
            E_ResumenSolicitud.IdEmpleado = varIdEmpleado;
            E_ResumenSolicitud.Total = Convert.ToDecimal(txtTotalA_Pagar.Text);

            E_ResumenSolicitud.Fecha = DateTime.Now.Date;
            E_ResumenSolicitud.NombreEmpresa = txtEfectoA_Asegurar.Text;
            E_ResumenSolicitud.CopiaEstatutos = imgCopiaEstatutos;
            E_ResumenSolicitud.CopiaActaDeAsignacionRNC = imgCopiaActaAsignacionRNC;
            E_ResumenSolicitud.CopiaCedulaPres_RepreAutorizado = imgCopiaCedulaPresidente_RepresAut;
            E_ResumenSolicitud.TelefonoEntidadAutorizada = strTelefonoEntAut;

            E_ResumenSolicitud.CorreoElectronicoEntidadAutorizada = CorreoElectronicoEntidadAutorizada;

            E_ResumenSolicitud.FechaHora = DateTime.Now;
            E_ResumenSolicitud.Tipo = txtCategoria.Text;

            E_ResumenSolicitud.Imagen1 = imgImagen1;
            E_ResumenSolicitud.Imagen2 = imgImagen2;
            E_ResumenSolicitud.Imagen3 = imgImagen3;
            E_ResumenSolicitud.Imagen4 = imgImagen4;
            E_ResumenSolicitud.Imagen5 = imgImagen5;

            E_ResumenSolicitud.IdSolicitud = Convert.ToInt32(txtCodigo.Text);
            E_ResumenSolicitud.IdSeguro = Convert.ToInt32(txtIdSeguro.Text);
            E_ResumenSolicitud.T_Pago = cmbTipoPago.Text;



            if (string.IsNullOrEmpty(txtParcial.Text) ||
                    string.IsNullOrWhiteSpace(txtParcial.Text))
            {
                E_ResumenSolicitud.PagoParcial = 0.0m;
            }
            else
            {
                E_ResumenSolicitud.PagoParcial = Convert.ToDecimal(txtParcial.Text);
            }
                if (string.IsNullOrEmpty(txtDescuento.Text) ||
                    string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                E_ResumenSolicitud.Descuento = 0.0m;
            }
            else
            {
                E_ResumenSolicitud.Descuento = Convert.ToDecimal(txtDescuento.Text);
            }
           

            //_idSolicitud = idSolicitud;
            //_idSeguro = idSeguro;
            //_T_Pago = T_Pago;
            //_PagoParcial = PagoParcial;
            //_Descuento = Descuento;

            if (MessageBox.Show("Se creará una solicitud para el cliente actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ResumenSolicitud.B_CrearSolicitud(E_ResumenSolicitud) >= 3)
                {
                    MessageBox.Show("Solicitud creada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private bool ValueParcial()
        {
            bool value = true;

            if (cmbTipoPago.Text == "Parcial")
            {
                if (!string.IsNullOrEmpty(txtParcial.Text) ||
                    !string.IsNullOrWhiteSpace(txtParcial.Text))
                {
                    decimal Total = Convert.ToDecimal(txtTotalA_Pagar.Text);
                    decimal Parcial = Convert.ToDecimal(txtParcial.Text);
                    if (Parcial > Total)
                    {
                        MessageBox.Show("No se puede pagar de manera parcial un valor igual o mayor que el precio total."
                            + " Por favor, intentelo de nuevo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        value = false;
                        txtParcial.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Completar el campo Parcial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    value = false;
                }
            }
            
            return value;
        }
        private void txtParcial_TextChanged(object sender, EventArgs e)
        {
            txtParcial.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };
        }

        private void txtDescontar_TextChanged(object sender, EventArgs e)
        {
            txtDescontar.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };
        }
    }
}
