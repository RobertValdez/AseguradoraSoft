using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PerlaDelSur_Entity.Clientes;
using CapaNegocio.Clientes;
using CapaNegocio.SeguroVida;
using PerlaDelSur_Entity.SeguroVida;
using System.IO;
using CapaNegocio.Solicitud;

namespace CapaPresentacion
{
    public partial class frmSolicitud : Form
    {
        B_Solicitud B_Solicitud = new B_Solicitud();

        B_SeguroVida B_SeguroVida = new B_SeguroVida();
        E_SeguroVida E_SegVida = new E_SeguroVida();

        E_Clientes E_Clientes = new E_Clientes();
        B_Clientes B_Clientes = new B_Clientes();

        DataTable dtPolizaDeSeguros = new DataTable();

        static string _Categoria = "";

        int idCodigoEm = 0;

        int idCodigoEdif = 0;

        int idCodigoFact = 0;

        int idCodigoVol = 0;

        int idCodigoTR = 0;

        int idCodigoObl = 0;

        decimal Precio = 0;
        int varIdEmpleado = 0;

        int idProductoSeguro = 0;

        byte[] imgCopiaEstatutos = null;
        byte[] imgCopiaActaAsignacionRNC = null;
        byte[] imgCopiaPresidenteReprAut = null;


        byte[] imgImagen1 = null;
        string strImagen1 = "";

        byte[] imgImagen2 = null;
        string strImagen2 = "";

        byte[] imgImagen3 = null;
        string strImagen3 = "";

        byte[] imgImagen4 = null;
        string strImagen4 = "";

        byte[] imgImagen5 = null;
        string strImagen5 = "";

        public frmSolicitud()
        {
            InitializeComponent();
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            pnlVehiculo.Visible = true;
        }

        private void btnSeguroVoluntario_Click(object sender, EventArgs e)
        {

        }

        private void lblCerrarVeh_Click(object sender, EventArgs e)
        {
            pnlVehiculo.Visible = false;
        }

        private void lblCerrarSV_Click(object sender, EventArgs e)
        {
            pnlVEHSeguroVoluntario.Visible = false;
        }

        private void btnSeguroVoluntario_Click_1(object sender, EventArgs e)
        {
            pnlVehiculo.Visible = false;
            _DescrepcionValue = false;

            if (!cancelarDescripcionSeguros(lblSeguroVoluntario.Text))
            {
                DataView dv = new DataView(dtPolizaDeSeguros);

                dv.RowFilter = "[Nombre del Seguro] = 'Seguro Voluntario'";


                idProductoSeguro = (int)dv[0]["id"];
                Precio = (decimal)dv[0]["Precio"];

                pnlVEHSeguroVoluntario.Visible = true;
            }
        }

        private string LlenarDescripcion()
        {
            DataView dv = new DataView(dtPolizaDeSeguros);

            dv.RowFilter = "[Nombre del Seguro] = 'Seguro Voluntario'";


           return (string)dv[0]["Descripcion"];
        }

        private void btnSeguroObligatorio_Click(object sender, EventArgs e)
        {
            try
            {
                pnlVehiculo.Visible = false;
                _DescrepcionValue = false;

                if (!cancelarDescripcionSeguros(lblSeguroObligatorio.Text)) 
                {
                    DataView dv = new DataView(dtPolizaDeSeguros);

                    dv.RowFilter = "[Nombre del Seguro] = 'Seguro Obligatorio'";

                    idProductoSeguro = (int)dv[0]["id"];
                    Precio = (decimal)dv[0]["Precio"];

                    pnlVEHSeguroObligatorio.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSeguroTodoRiesgo_Click(object sender, EventArgs e)
        {
            try
            {
                pnlVehiculo.Visible = false;
                _DescrepcionValue = false;

                if (!cancelarDescripcionSeguros(lblSeguroTodoRiesgo.Text))
                {
                    DataView dv = new DataView(dtPolizaDeSeguros);

                    dv.RowFilter = "[Nombre del Seguro] = 'Seguro Todo Riesgo'";

                    idProductoSeguro = (int)dv[0]["id"];
                    Precio = (decimal)dv[0]["Precio"];

                    pnlVEHSeguroTodoRiesgo.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void lblCerrarTodoRiesgo_Click(object sender, EventArgs e)
        {
            pnlVEHSeguroTodoRiesgo.Visible = false;
        }

        private void lblCerrarSeguroOb_Click(object sender, EventArgs e)
        {
            pnlVEHSeguroObligatorio.Visible = false;
        }

        private void btnInmContenido_Click(object sender, EventArgs e)
        {
            try
            {
                pnlInmuebles.Visible = false;
                _DescrepcionValue = false;

                if (!cancelarDescripcionSeguros(lblSeguroContenido.Text))
                {
                    DataView dv = new DataView(dtPolizaDeSeguros);

                    dv.RowFilter = "[Nombre del Seguro] = 'Seguro Contenido'";

                    idProductoSeguro = (int)dv[0]["id"];
                    Precio = (decimal)dv[0]["Precio"];

                    pnlMueblesInmContenido.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
}

        private void btnInmEdificaciones_Click(object sender, EventArgs e)
        {
            try
            {
                pnlInmuebles.Visible = false;
                _DescrepcionValue = false;

                if (!cancelarDescripcionSeguros(lblEdificaciones.Text))
                {
                    DataView dv = new DataView(dtPolizaDeSeguros);

                    dv.RowFilter = "[Nombre del Seguro] = 'Seguro Edificaciones'";

                    idProductoSeguro = (int)dv[0]["id"];
                    Precio = (decimal)dv[0]["Precio"];
                    pnlMueblesInmEdificaciones.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void lblCerrarInmContenido_Click(object sender, EventArgs e)
        {
            pnlMueblesInmContenido.Visible = false;
        }

        private void lblCerrarSegInmEdif_Click(object sender, EventArgs e)
        {
            pnlMueblesInmEdificaciones.Visible = false;
        }

        private void btnMueblesEInmuebles_Click(object sender, EventArgs e)
        {
            pnlInmuebles.Visible = true;
        }

        private void lblCerrar_pnlInmuebles_Click(object sender, EventArgs e)
        {
            pnlInmuebles.Visible = false;
        }

        private void btnNegocioEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cancelarDescripcionSeguros(lblSeguroNEmpresa.Text))
                {
                    DataView dv = new DataView(dtPolizaDeSeguros);

                    dv.RowFilter = "[Nombre del Seguro] = 'Seguro Negocios y Empresas'";

                    idProductoSeguro = (int)dv[0]["id"];
                    Precio = (decimal)dv[0]["Precio"];


                    pnlNegociosEmpresas.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void CargarSegurosDePoliza()
        {
            try
            {
                dtPolizaDeSeguros = B_SeguroVida.B_MostrarSegurosDePolizas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblCerrarNegocioEmp_Click(object sender, EventArgs e)
        {
            pnlNegociosEmpresas.Visible = false;
            pnlPicImagen.Visible = false;
        }


        private void btnSiguientepnlVEHSeguroObligatorio_Click(object sender, EventArgs e)
        {
            SIGUIENTEpnlVEHSeguroObligatorio();
        }

        private void SIGUIENTEpnlVEHSeguroObligatorio()
        {
            QuitarErrorProviderCliente();
            ValidarCamposCliente();
            //------------------------//
            QuitarErrorProviderVehiculoSeguroObligatorio();
            ValidarCamposVehiculoSeguroObligatorio();

            try
            {

                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text)
                    || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrWhiteSpace(txtApellido.Text)
                    || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || mskCedula.Text == "   -       -" || mskTelefono.Text == ""
                    || string.IsNullOrEmpty(txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text)
                    || string.IsNullOrEmpty(cmbNacionalidad.Text) || string.IsNullOrWhiteSpace(cmbNacionalidad.Text)
                    || string.IsNullOrEmpty(cmbSexo.Text) || string.IsNullOrWhiteSpace(cmbSexo.Text)
                    || (string.IsNullOrEmpty(txtMarcaVehiculoObl.Text)
                    || string.IsNullOrWhiteSpace(txtMarcaVehiculoObl.Text))
                    || (string.IsNullOrEmpty(txtMatriculaObl.Text)
                    || string.IsNullOrWhiteSpace(txtMatriculaObl.Text))
                    || (string.IsNullOrEmpty(txtUsoObl.Text)
                    || string.IsNullOrWhiteSpace(txtUsoObl.Text))
                    || (string.IsNullOrEmpty(txtCilindrosObl.Text)
                    || string.IsNullOrWhiteSpace(txtCilindrosObl.Text))
                    || (string.IsNullOrEmpty(txtCategoriaObl.Text)
                    || string.IsNullOrWhiteSpace(txtCategoriaObl.Text))
                    || (string.IsNullOrEmpty(txtCarroceriaObl.Text)
                    || string.IsNullOrWhiteSpace(txtCarroceriaObl.Text))
                    || (string.IsNullOrEmpty(txtModeloObl.Text)
                    || string.IsNullOrWhiteSpace(txtModeloObl.Text)))
                {
                    MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNombre.ReadOnly == true) // True aquí: Significa que está añadido como cliente en la Base de Datos
                {
                    frmFacturas frmFac = new frmFacturas();

                    frmFac.txtId.Text = txtId.Text;
                    frmFac.txtCliente.Text = txtNombre.Text + " " + txtApellido.Text;
                    frmFac.txtCedula.Text = mskCedula.Text;
                    frmFac.txtSeguroA_Adquirir.Text = lblSeguroObligatorio.Text;
                    frmFac.txtEfectoA_Asegurar.Text = txtMarcaVehiculoObl.Text + "  " + txtModeloObl.Text;

                    frmFac.txtCategoria.Text = _Categoria;

                    frmFac.txtIdSeguro.Text = idProductoSeguro.ToString();

                    frmFac.txtCodigo.Text = idCodigoFact.ToString();

                    frmFac.txtSubTotal.Text = Precio.ToString();
                    frmFac.txtTotalA_Pagar.Text = Precio.ToString();


                    frmFac.strMarcaVehiculoObl = txtMarcaVehiculoObl.Text;
                    frmFac.strModeloObl = txtModeloObl.Text;
                    frmFac.strMatriculaObl = txtMatriculaObl.Text;
                    frmFac.intAnoObl = Convert.ToInt32(txtAnoObl.Text);
                    frmFac.intCilindrosObl = Convert.ToInt32(txtCilindrosObl.Text);
                    frmFac.strCarroceriaObl = txtCarroceriaObl.Text;
                    frmFac.strCategoriaObl = txtCategoriaObl.Text;
                    frmFac.strUsoObl = txtUsoObl.Text;


                    frmFac.varIdEmpleado = varIdEmpleado;

                    frmFac.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Añada el Cliente actual para poder continuar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pnlPicImagen.Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }




        private void btnSIGUIENTEpnlVEHSeguroTodoRiesgo_Click(object sender, EventArgs e)
        {
            SIGUIENTEpnlVEHSeguroTodoRiesgo();
        }

        private void SIGUIENTEpnlVEHSeguroTodoRiesgo()
        {
            QuitarErrorProviderCliente();
            ValidarCamposCliente();
            //------------------------//
            QuitarErrorProviderSegVehiculoTodoRiesgo();
            ValidarCamposSeguroVehiculoTodoRiesgo();

            try
            {

                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text)
                    || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrWhiteSpace(txtApellido.Text)
                    || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || mskCedula.Text == "   -       -" || mskTelefono.Text == ""
                    || string.IsNullOrEmpty(txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text)
                    || string.IsNullOrEmpty(cmbNacionalidad.Text) || string.IsNullOrWhiteSpace(cmbNacionalidad.Text)
                    || string.IsNullOrEmpty(cmbSexo.Text) || string.IsNullOrWhiteSpace(cmbSexo.Text)
                    || (string.IsNullOrEmpty(txtMarcaVehiculoTR.Text)
                    || string.IsNullOrWhiteSpace(txtMarcaVehiculoTR.Text))
                    || (string.IsNullOrEmpty(txtMatriculaTR.Text)
                    || string.IsNullOrWhiteSpace(txtMatriculaTR.Text))
                    || (string.IsNullOrEmpty(txtUsoTR.Text)
                    || string.IsNullOrWhiteSpace(txtUsoTR.Text))
                    || (string.IsNullOrEmpty(txtCilindrosTR.Text)
                    || string.IsNullOrWhiteSpace(txtCilindrosTR.Text))
                    || (string.IsNullOrEmpty(txtCategoriaTR.Text)
                    || string.IsNullOrWhiteSpace(txtCategoriaTR.Text))
                    || (string.IsNullOrEmpty(txtCarroceriaTR.Text)
                    || string.IsNullOrWhiteSpace(txtCarroceriaTR.Text))
                    || (string.IsNullOrEmpty(txtModeloTR.Text)
                    || string.IsNullOrWhiteSpace(txtModeloTR.Text)))
                {
                    MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNombre.ReadOnly == true) // True aquí: Significa que está añadido como cliente en la Base de Datos
                {
                    frmFacturas frmFac = new frmFacturas();

                    frmFac.txtId.Text = txtId.Text;
                    frmFac.txtCliente.Text = txtNombre.Text + " " + txtApellido.Text;
                    frmFac.txtCedula.Text = mskCedula.Text;
                    frmFac.txtSeguroA_Adquirir.Text = lblSeguroTodoRiesgo.Text;
                    frmFac.txtEfectoA_Asegurar.Text = txtMarcaVehiculoTR.Text + "  " + txtModeloTR.Text;

                    frmFac.txtCategoria.Text = _Categoria;

                    frmFac.txtIdSeguro.Text = idProductoSeguro.ToString();

                    frmFac.txtCodigo.Text = idCodigoFact.ToString();

                    frmFac.txtSubTotal.Text = Precio.ToString();
                    frmFac.txtTotalA_Pagar.Text = Precio.ToString();


                    frmFac.strMarcaVehiculoTR = txtMarcaVehiculoTR.Text;
                    frmFac.strModeloTR = txtModeloTR.Text;
                    frmFac.strMatriculaTR = txtMatriculaTR.Text;
                    frmFac.intAnoTR = Convert.ToInt32(txtAnoTR.Text);
                    frmFac.intCilindrosTR = Convert.ToInt32(txtCilindrosTR.Text);
                    frmFac.strCarroceriaTR = txtCarroceriaTR.Text;
                    frmFac.strCategoriaTR = txtCategoriaTR.Text;
                    frmFac.strUsoTR = txtUsoTR.Text;


                    frmFac.varIdEmpleado = varIdEmpleado;

                    frmFac.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Añada el Cliente actual para poder continuar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pnlPicImagen.Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSIGUIENTEpnlVEHSeguroVoluntario_Click(object sender, EventArgs e)
        {
            SIGUIENTEpnlVEHSeguroVoluntario();
        }

        private void SIGUIENTEpnlVEHSeguroVoluntario()
        {
            QuitarErrorProviderCliente();
            ValidarCamposCliente();
            //------------------------//
            QuitarErrorProviderSegVehiculoVoluntario();
            ValidarCamposSeguroVehiculoVoluntario();

            try
            {

                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text)
                    || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrWhiteSpace(txtApellido.Text)
                    || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || mskCedula.Text == "   -       -" || mskTelefono.Text == ""
                    || string.IsNullOrEmpty(txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text)
                    || string.IsNullOrEmpty(cmbNacionalidad.Text) || string.IsNullOrWhiteSpace(cmbNacionalidad.Text)
                    || string.IsNullOrEmpty(cmbSexo.Text) || string.IsNullOrWhiteSpace(cmbSexo.Text)
                    || (string.IsNullOrEmpty(txtMarcaVehiculoVol.Text)
                    || string.IsNullOrWhiteSpace(txtMarcaVehiculoVol.Text))
                    || (string.IsNullOrEmpty(txtMatriculaVol.Text)
                    || string.IsNullOrWhiteSpace(txtMatriculaVol.Text))
                    || (string.IsNullOrEmpty(txtUsoVol.Text)
                    || string.IsNullOrWhiteSpace(txtUsoVol.Text))
                    || (string.IsNullOrEmpty(txtCilindrosVol.Text)
                    || string.IsNullOrWhiteSpace(txtCilindrosVol.Text))
                    || (string.IsNullOrEmpty(txtCategoriaVol.Text)
                    || string.IsNullOrWhiteSpace(txtCategoriaVol.Text))
                    || (string.IsNullOrEmpty(txtCarroceriaVol.Text)
                    || string.IsNullOrWhiteSpace(txtCarroceriaVol.Text)) 
                    || (string.IsNullOrEmpty(txtModeloVol.Text)
                    || string.IsNullOrWhiteSpace(txtModeloVol.Text)))
                {
                    MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNombre.ReadOnly == true) // True aquí: Significa que está añadido como cliente en la Base de Datos
                {
                    frmFacturas frmFac = new frmFacturas();

                    frmFac.txtId.Text = txtId.Text;
                    frmFac.txtCliente.Text = txtNombre.Text + " " + txtApellido.Text;
                    frmFac.txtCedula.Text = mskCedula.Text;
                    frmFac.txtSeguroA_Adquirir.Text = lblSeguroVoluntario.Text;
                    frmFac.txtEfectoA_Asegurar.Text = txtMarcaVehiculoVol.Text + "  " + txtModeloVol.Text;

                    frmFac.txtCategoria.Text = _Categoria;

                    frmFac.txtIdSeguro.Text = idProductoSeguro.ToString();

                    frmFac.txtCodigo.Text = idCodigoFact.ToString();

                    frmFac.txtSubTotal.Text = Precio.ToString();
                    frmFac.txtTotalA_Pagar.Text = Precio.ToString();


                    frmFac.strMarcaVehiculoVol = txtMarcaVehiculoVol.Text;
                    frmFac.strModeloVol = txtModeloVol.Text;
                    frmFac.strMatriculaVol = txtMatriculaVol.Text;
                    frmFac.intAnoVol = Convert.ToInt32(txtAnoVol.Text);
                    frmFac.intCilindrosVol = Convert.ToInt32(txtCilindrosVol.Text);
                    frmFac.strCarroceriaVol = txtCarroceriaVol.Text;
                    frmFac.strCategoriaVol = txtCategoriaVol.Text;
                    frmFac.strUsoVol = txtUsoVol.Text;


                    frmFac.varIdEmpleado = varIdEmpleado;

                    frmFac.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Añada el Cliente actual para poder continuar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pnlPicImagen.Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



    private void btnSIGUIENTEpnlMueblesInmContenido_Click(object sender, EventArgs e)
        {
            SIGUIENTEpnlMueblesInmContenido();
        }

        private void SIGUIENTEpnlMueblesInmContenido()
        {
            try
            {

                mskTelefonoValidar();
                mskCedulaValidar();
                
                QuitarErrorProviderCliente();
                ValidarCamposCliente();
                //------------------------//
                QuitarErrorProviderSegContendio();
                ValidarCamposSeguroContenido();

                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text)
                        || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrWhiteSpace(txtApellido.Text)
                        || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || mskCedula.Text == "   -       -" || mskTelefono.Text == ""
                        || string.IsNullOrEmpty(txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text)
                        || string.IsNullOrEmpty(cmbNacionalidad.Text) || string.IsNullOrWhiteSpace(cmbNacionalidad.Text)
                        || string.IsNullOrEmpty(cmbSexo.Text) || string.IsNullOrWhiteSpace(cmbSexo.Text)
                        || (string.IsNullOrEmpty(txtTipoViviendaCont.Text)
                        || string.IsNullOrWhiteSpace(txtTipoViviendaCont.Text))
                        || (string.IsNullOrEmpty(txtSituacionCont.Text)
                        || string.IsNullOrWhiteSpace(txtSituacionCont.Text))
                        || (string.IsNullOrEmpty(txtCodigoPostalCont.Text)
                        || string.IsNullOrWhiteSpace(txtCodigoPostalCont.Text))
                        || (string.IsNullOrEmpty(cmbViviendaHabitualCont.Text)
                        || string.IsNullOrWhiteSpace(cmbViviendaHabitualCont.Text))
                        || (string.IsNullOrEmpty(cmbViviendaAlquiladaCont.Text)
                        || string.IsNullOrWhiteSpace(cmbViviendaAlquiladaCont.Text))
                        || (string.IsNullOrEmpty(txtAnoConstruccionCont.Text)
                        || string.IsNullOrWhiteSpace(txtAnoConstruccionCont.Text))
                        || (string.IsNullOrEmpty(txtM2ViviendaCont.Text)
                        || string.IsNullOrWhiteSpace(txtM2ViviendaCont.Text))
                        || (string.IsNullOrEmpty(cmbDeshabitada3MesesAnoCont.Text)
                        || string.IsNullOrWhiteSpace(cmbDeshabitada3MesesAnoCont.Text))
                        || (string.IsNullOrEmpty(txtDescripcionMueblesCont.Text)
                        || string.IsNullOrWhiteSpace(txtDescripcionMueblesCont.Text))
                        || (string.IsNullOrEmpty(txtValorMuebles.Text)
                        || string.IsNullOrWhiteSpace(txtValorMuebles.Text)))
                {
                    MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNombre.ReadOnly == true) // True aquí: Significa que está añadido como cliente en la Base de Datos
                {
                    frmFacturas frmFac = new frmFacturas();

                    frmFac.txtId.Text = txtId.Text;
                    frmFac.txtCliente.Text = txtNombre.Text + " " + txtApellido.Text;
                    frmFac.txtCedula.Text = mskCedula.Text;
                    frmFac.txtSeguroA_Adquirir.Text = lblSeguroContenido.Text;
                    frmFac.txtEfectoA_Asegurar.Text = "Muebles";
                    frmFac.txtCategoria.Text = _Categoria;
                    frmFac.txtIdSeguro.Text = idProductoSeguro.ToString();

                    frmFac.txtCodigo.Text = idCodigoFact.ToString();

                    frmFac.txtSubTotal.Text = Precio.ToString();
                    frmFac.txtTotalA_Pagar.Text = Precio.ToString();

                    frmFac.strTipoViviendaCont = txtTipoViviendaCont.Text;
                    frmFac.strSituacionCont = txtSituacionCont.Text;
                    frmFac.strPropietarioCont = txtPropietarioCont.Text;
                    frmFac.strViviendaHabitualCont = cmbViviendaHabitualCont.Text;
                    frmFac.strViviendaAlquiladaCont = cmbViviendaAlquiladaCont.Text;
                    frmFac.strCodigoPostalCont = txtCodigoPostalCont.Text;
                    frmFac.strDeshabitadaPor3MesesAlAnoCont = cmbDeshabitada3MesesAnoCont.Text;
                    frmFac.intAnoDeCostruccionCont = Convert.ToInt32(txtAnoConstruccionCont.Text);
                    frmFac.decM2ViviendaCont = Convert.ToDecimal(txtM2ViviendaCont.Text);
                    frmFac.strDescripcionMueblesCont = txtDescripcionMueblesCont.Text;
                    frmFac.strValorEstimadoMueblesCont = Convert.ToInt32(txtValorMuebles.Text);

                    frmFac.varIdEmpleado = varIdEmpleado;

                    frmFac.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Añada el Cliente actual para poder continuar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pnlPicImagen.Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSIGUIENTEpnlMueblesInmEdificaciones_Click(object sender, EventArgs e)
        {
            SIGUIENTEpnlMueblesEdificaciones();
        }

        private void SIGUIENTEpnlMueblesEdificaciones()
        {
            try
            {
                mskTelefonoValidar();
                mskCedulaValidar();

                QuitarErrorProviderCliente();
                ValidarCamposCliente();
                //------------------------//
                QuitarErrorProviderSegEdificaciones();
                ValidarCamposSegSegEdificaciones();

                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text)
                        || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrWhiteSpace(txtApellido.Text)
                        || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || mskCedula.Text == "   -       -" || mskTelefono.Text == ""
                        || string.IsNullOrEmpty(txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text)
                        || string.IsNullOrEmpty(cmbNacionalidad.Text) || string.IsNullOrWhiteSpace(cmbNacionalidad.Text)
                        || string.IsNullOrEmpty(cmbSexo.Text) || string.IsNullOrWhiteSpace(cmbSexo.Text)
                        || (string.IsNullOrEmpty(txtTipoVivienda.Text)
                        || string.IsNullOrWhiteSpace(txtTipoVivienda.Text))
                        || (string.IsNullOrEmpty(txtSituacion.Text)
                        || string.IsNullOrWhiteSpace(txtSituacion.Text))
                        || (string.IsNullOrEmpty(txtCodigoPostal.Text)
                        || string.IsNullOrWhiteSpace(txtCodigoPostal.Text))
                        || (string.IsNullOrEmpty(cmbViviendaHabitual.Text)
                        || string.IsNullOrWhiteSpace(cmbViviendaHabitual.Text))
                        || (string.IsNullOrEmpty(cmbViviendaAlquilada.Text)
                        || string.IsNullOrWhiteSpace(cmbViviendaAlquilada.Text))
                        || (string.IsNullOrEmpty(txtAnoConstruccion.Text)
                        || string.IsNullOrWhiteSpace(txtAnoConstruccion.Text))
                        || (string.IsNullOrEmpty(txtM2Vivienda.Text)
                        || string.IsNullOrWhiteSpace(txtM2Vivienda.Text))
                        || (string.IsNullOrEmpty(cmbDeshabitada3MesesAno.Text)
                        || string.IsNullOrWhiteSpace(cmbDeshabitada3MesesAno.Text))
                        || (string.IsNullOrEmpty(txtM2EdificacionesAnexas.Text)
                        || string.IsNullOrWhiteSpace(txtM2EdificacionesAnexas.Text))
                        || (string.IsNullOrEmpty(txtCapitalOtrasInstalaciones.Text)
                        || string.IsNullOrWhiteSpace(txtCapitalOtrasInstalaciones.Text)))
                {
                    MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNombre.ReadOnly == true) // True aquí: Significa que está añadido como cliente en la Base de Datos
                {
                    frmFacturas frmFac = new frmFacturas();

                    frmFac.txtId.Text = txtId.Text;
                    frmFac.txtCliente.Text = txtNombre.Text + " " + txtApellido.Text;
                    frmFac.txtCedula.Text = mskCedula.Text;
                    frmFac.txtSeguroA_Adquirir.Text = lblEdificaciones.Text;
                    frmFac.txtEfectoA_Asegurar.Text = "Inmueble";
                    frmFac.txtCategoria.Text = _Categoria;
                    frmFac.txtIdSeguro.Text = idProductoSeguro.ToString();

                    frmFac.txtCodigo.Text = idCodigoFact.ToString();

                    frmFac.txtSubTotal.Text = Precio.ToString();
                    frmFac.txtTotalA_Pagar.Text = Precio.ToString();

                    frmFac.strTipoVivienda = txtTipoVivienda.Text;
                    frmFac.strSituacion = txtSituacion.Text;
                    frmFac.strPropietario = txtPropietario.Text;
                    frmFac.strViviendaHabitual = cmbViviendaHabitual.Text;
                    frmFac.strViviendaAlquilada = cmbViviendaAlquilada.Text;
                    frmFac.strCodigoPostal = txtCodigoPostal.Text;
                    frmFac.strDeshabitadaPor3MesesAlAno = cmbDeshabitada3MesesAno.Text;
                    frmFac.strAnoDeCostruccion = Convert.ToInt32(txtAnoConstruccion.Text);
                    frmFac.decM2Vivienda = Convert.ToDecimal(txtM2Vivienda.Text);
                    frmFac.decM2EdificacionesAnexas = Convert.ToDecimal(txtM2EdificacionesAnexas.Text);
                    frmFac.strCapitalOtrasInstalaciones = txtCapitalOtrasInstalaciones.Text;

                    frmFac.varIdEmpleado = varIdEmpleado;

                    frmFac.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Añada el Cliente actual para poder continuar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pnlPicImagen.Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSIGUIENTEpnlNegociosEmpresas_Click(object sender, EventArgs e)
        {
            Siguiente_pnlNegociosEmpresas();
        }

        public void Siguiente_pnlNegociosEmpresas()
        {
            try
            {
                mskTelefonoValidar();
                mskCedulaValidar();

                QuitarErrorProviderCliente();
                ValidarCamposCliente();
                //------------------------//
                QuitarErrorProviderSegEmprNegocios();
                ValidarCamposSegEmprNegocios();

                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text)
                    || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrWhiteSpace(txtApellido.Text)
                    || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || mskCedula.Text == "   -       -" || mskTelefono.Text == ""
                    || string.IsNullOrEmpty(txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text)
                    || string.IsNullOrEmpty(cmbNacionalidad.Text) || string.IsNullOrWhiteSpace(cmbNacionalidad.Text)
                    || string.IsNullOrEmpty(cmbSexo.Text) || string.IsNullOrWhiteSpace(cmbSexo.Text)
                    || (string.IsNullOrEmpty(txtCopiaEstatutos.Text)
                    || string.IsNullOrWhiteSpace(txtCopiaEstatutos.Text))
                    || (string.IsNullOrEmpty(txtCopiaActaAsignacionRNC.Text)
                    || string.IsNullOrWhiteSpace(txtCopiaActaAsignacionRNC.Text))
                    || (string.IsNullOrEmpty(txtCopiaCedulaPresidente_RepresAut.Text)
                    || string.IsNullOrWhiteSpace(txtCopiaCedulaPresidente_RepresAut.Text))
                    || (string.IsNullOrEmpty(txtTelefonoEntAut.Text)
                    || string.IsNullOrWhiteSpace(txtTelefonoEntAut.Text))
                    || (picImagen1.Image == null))
                {
                    MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNombre.ReadOnly == true) // True aquí: Significa que está añadido como cliente en la Base de Datos
                {
                    frmFacturas frmFac = new frmFacturas();

                    frmFac.txtId.Text = txtId.Text;
                    frmFac.txtCliente.Text = txtNombre.Text + " " + txtApellido.Text;
                    frmFac.txtCedula.Text = mskCedula.Text;
                    frmFac.txtSeguroA_Adquirir.Text = lblSeguroNEmpresa.Text;
                    frmFac.txtEfectoA_Asegurar.Text = txtNombreEmpresa.Text;
                    frmFac.txtCategoria.Text = _Categoria;
                    frmFac.txtIdSeguro.Text = idProductoSeguro.ToString();

                    frmFac.txtCodigo.Text = idCodigoFact.ToString();
                    frmFac.txtSubTotal.Text = Precio.ToString();
                    frmFac.txtTotalA_Pagar.Text = Precio.ToString();



                    frmFac.imgCopiaEstatutos = imgCopiaEstatutos;
                    frmFac.imgCopiaActaAsignacionRNC = imgCopiaActaAsignacionRNC;

                    frmFac.imgCopiaCedulaPresidente_RepresAut = imgCopiaPresidenteReprAut;
                    frmFac.strTelefonoEntAut = txtTelefonoEntAut.Text;

                    frmFac.CorreoElectronicoEntidadAutorizada = txtCorreoElectronicoEntAutorizada.Text;
                    


                    frmFac.imgImagen1 = imgImagen1;
                    frmFac.imgImagen2 = imgImagen2;
                    frmFac.imgImagen3 = imgImagen3;
                    frmFac.imgImagen4 = imgImagen4;
                    frmFac.imgImagen5 = imgImagen5;

                    frmFac.varIdEmpleado = varIdEmpleado;

                    frmFac.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Añada el Cliente actual para poder continuar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pnlPicImagen.Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private bool ValidarCamposVehiculoSeguroObligatorio()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtMarcaVehiculoObl.Text)
               || string.IsNullOrWhiteSpace(txtMarcaVehiculoObl.Text))
            {
                ok = false;
                errorProvider1.SetError(txtMarcaVehiculoObl, "Campo obligatorio");
                txtMarcaVehiculoObl.Text = "";
            }

            if (string.IsNullOrEmpty(txtMatriculaObl.Text)
                || string.IsNullOrWhiteSpace(txtMatriculaObl.Text))
            {
                ok = false;
                errorProvider1.SetError(txtMatriculaObl, "Campo obligatorio");
                txtMatriculaObl.Text = "";
            }

            if (string.IsNullOrEmpty(txtUsoObl.Text)
                || string.IsNullOrWhiteSpace(txtUsoObl.Text))
            {
                ok = false;
                errorProvider1.SetError(txtUsoObl, "Campo obligatorio");
                txtUsoObl.Text = "";
            }

            if (string.IsNullOrEmpty(txtAnoObl.Text)
                || string.IsNullOrWhiteSpace(txtAnoObl.Text))
            {
                ok = false;
                errorProvider1.SetError(txtAnoObl, "Campo obligatorio");
                txtAnoObl.Text = "";
            }

            if (string.IsNullOrEmpty(txtCilindrosObl.Text)
                || string.IsNullOrWhiteSpace(txtCilindrosObl.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCilindrosObl, "Campo obligatorio");
                txtCilindrosObl.Text = "";
            }

            if (string.IsNullOrEmpty(txtCategoriaObl.Text)
               || string.IsNullOrWhiteSpace(txtCategoriaObl.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCategoriaObl, "Campo obligatorio");
                txtCategoriaObl.Text = "";
            }
            if (string.IsNullOrEmpty(txtCarroceriaObl.Text)
               || string.IsNullOrWhiteSpace(txtCarroceriaObl.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCarroceriaObl, "Campo obligatorio");
                txtCarroceriaObl.Text = "";
            }

            if (string.IsNullOrEmpty(txtModeloObl.Text)
                    || string.IsNullOrWhiteSpace(txtModeloObl.Text))
            {
                ok = false;
                errorProvider1.SetError(txtModeloObl, "Campo obligatorio");
                txtModeloObl.Text = "";
            }


            return ok;
        }

        private void QuitarErrorProviderVehiculoSeguroObligatorio()
        {
            errorProvider1.SetError(txtMarcaVehiculoObl, "");
            errorProvider1.SetError(txtMatriculaObl, "");
            errorProvider1.SetError(txtUsoObl, "");
            errorProvider1.SetError(txtAnoObl, "");
            errorProvider1.SetError(txtCilindrosObl, "");
            errorProvider1.SetError(txtCategoriaObl, "");
            errorProvider1.SetError(txtCarroceriaObl, "");
            errorProvider1.SetError(txtModeloObl, "");
        }




        private bool ValidarCamposSeguroVehiculoTodoRiesgo()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtMarcaVehiculoTR.Text)
               || string.IsNullOrWhiteSpace(txtMarcaVehiculoTR.Text))
            {
                ok = false;
                errorProvider1.SetError(txtMarcaVehiculoTR, "Campo obligatorio");
                txtMarcaVehiculoTR.Text = "";
            }

            if (string.IsNullOrEmpty(txtMatriculaTR.Text)
                || string.IsNullOrWhiteSpace(txtMatriculaTR.Text))
            {
                ok = false;
                errorProvider1.SetError(txtMatriculaTR, "Campo obligatorio");
                txtMatriculaTR.Text = "";
            }

            if (string.IsNullOrEmpty(txtUsoTR.Text)
                || string.IsNullOrWhiteSpace(txtUsoTR.Text))
            {
                ok = false;
                errorProvider1.SetError(txtUsoTR, "Campo obligatorio");
                txtUsoTR.Text = "";
            }

            if (string.IsNullOrEmpty(txtAnoTR.Text)
                || string.IsNullOrWhiteSpace(txtAnoTR.Text))
            {
                ok = false;
                errorProvider1.SetError(txtAnoTR, "Campo obligatorio");
                txtAnoTR.Text = "";
            }

            if (string.IsNullOrEmpty(txtCilindrosTR.Text)
                || string.IsNullOrWhiteSpace(txtCilindrosTR.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCilindrosTR, "Campo obligatorio");
                txtCilindrosTR.Text = "";
            }

            if (string.IsNullOrEmpty(txtCategoriaTR.Text)
               || string.IsNullOrWhiteSpace(txtCategoriaTR.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCategoriaTR, "Campo obligatorio");
                txtCategoriaTR.Text = "";
            }
            if (string.IsNullOrEmpty(txtCarroceriaTR.Text)
               || string.IsNullOrWhiteSpace(txtCarroceriaTR.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCarroceriaTR, "Campo obligatorio");
                txtCarroceriaTR.Text = "";
            }

            if (string.IsNullOrEmpty(txtModeloTR.Text)
                    || string.IsNullOrWhiteSpace(txtModeloTR.Text))
            {
                ok = false;
                errorProvider1.SetError(txtModeloTR, "Campo obligatorio");
                txtModeloTR.Text = "";
            }


            return ok;
        }

        private void QuitarErrorProviderSegVehiculoTodoRiesgo()
        {
            errorProvider1.SetError(txtMarcaVehiculoTR, "");
            errorProvider1.SetError(txtMatriculaTR, "");
            errorProvider1.SetError(txtUsoTR, "");
            errorProvider1.SetError(txtAnoTR, "");
            errorProvider1.SetError(txtCilindrosTR, "");
            errorProvider1.SetError(txtCategoriaTR, "");
            errorProvider1.SetError(txtCarroceriaTR, "");
            errorProvider1.SetError(txtModeloTR, "");
        }


        private bool ValidarCamposSeguroVehiculoVoluntario()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtMarcaVehiculoVol.Text)
               || string.IsNullOrWhiteSpace(txtMarcaVehiculoVol.Text))
            {
                ok = false;
                errorProvider1.SetError(txtMarcaVehiculoVol, "Campo obligatorio");
                txtMarcaVehiculoVol.Text = "";
            }

            if (string.IsNullOrEmpty(txtMatriculaVol.Text)
                || string.IsNullOrWhiteSpace(txtMatriculaVol.Text))
            {
                ok = false;
                errorProvider1.SetError(txtMatriculaVol, "Campo obligatorio");
                txtMatriculaVol.Text = "";
            }

            if (string.IsNullOrEmpty(txtUsoVol.Text)
                || string.IsNullOrWhiteSpace(txtUsoVol.Text))
            {
                ok = false;
                errorProvider1.SetError(txtUsoVol, "Campo obligatorio");
                txtUsoVol.Text = "";
            }

            if (string.IsNullOrEmpty(txtAnoVol.Text)
                || string.IsNullOrWhiteSpace(txtAnoVol.Text))
            {
                ok = false;
                errorProvider1.SetError(txtAnoVol, "Campo obligatorio");
                txtAnoVol.Text = "";
            }

            if (string.IsNullOrEmpty(txtCilindrosVol.Text)
                || string.IsNullOrWhiteSpace(txtCilindrosVol.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCilindrosVol, "Campo obligatorio");
                txtCilindrosVol.Text = "";
            }

            if (string.IsNullOrEmpty(txtCategoriaVol.Text)
               || string.IsNullOrWhiteSpace(txtCategoriaVol.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCategoriaVol, "Campo obligatorio");
                txtCategoriaVol.Text = "";
            }
            if (string.IsNullOrEmpty(txtCarroceriaVol.Text)
               || string.IsNullOrWhiteSpace(txtCarroceriaVol.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCarroceriaVol, "Campo obligatorio");
                txtCarroceriaVol.Text = "";
            }

            if (string.IsNullOrEmpty(txtModeloVol.Text)
                    || string.IsNullOrWhiteSpace(txtModeloVol.Text))
            {
                ok = false;
                errorProvider1.SetError(txtModeloVol, "Campo obligatorio");
                txtModeloVol.Text = "";
            }


            return ok;
        }

        private void QuitarErrorProviderSegVehiculoVoluntario()
        {
            errorProvider1.SetError(txtMarcaVehiculoVol, "");
            errorProvider1.SetError(txtMatriculaVol, "");
            errorProvider1.SetError(txtUsoVol, "");
            errorProvider1.SetError(txtAnoVol, "");
            errorProvider1.SetError(txtCilindrosVol, "");
            errorProvider1.SetError(txtCategoriaVol, "");
            errorProvider1.SetError(txtCarroceriaVol, "");
            errorProvider1.SetError(txtModeloVol, "");
        }

        private bool ValidarCamposSeguroContenido()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtTipoViviendaCont.Text)
               || string.IsNullOrWhiteSpace(txtTipoViviendaCont.Text))
            {
                ok = false;
                errorProvider1.SetError(txtTipoViviendaCont, "Campo obligatorio");
                txtTipoViviendaCont.Text = "";
            }

            if (string.IsNullOrEmpty(txtSituacionCont.Text)
                || string.IsNullOrWhiteSpace(txtSituacionCont.Text))
            {
                ok = false;
                errorProvider1.SetError(txtSituacionCont, "Campo obligatorio");
                txtSituacionCont.Text = "";
            }

            if (string.IsNullOrEmpty(txtPropietarioCont.Text)
                || string.IsNullOrWhiteSpace(txtPropietarioCont.Text))
            {
                ok = false;
                errorProvider1.SetError(txtPropietarioCont, "Campo obligatorio");
                txtPropietarioCont.Text = "";
            }

            if (string.IsNullOrEmpty(cmbViviendaHabitualCont.Text)
                || string.IsNullOrWhiteSpace(cmbViviendaHabitualCont.Text))
            {
                ok = false;
                errorProvider1.SetError(cmbViviendaHabitualCont, "Campo obligatorio");
                cmbViviendaHabitualCont.Text = "";
            }

            if (string.IsNullOrEmpty(txtCodigoPostalCont.Text)
                || string.IsNullOrWhiteSpace(txtCodigoPostalCont.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCodigoPostalCont, "Campo obligatorio");
                txtCodigoPostalCont.Text = "";
            }

            if (string.IsNullOrEmpty(cmbDeshabitada3MesesAnoCont.Text)
               || string.IsNullOrWhiteSpace(cmbDeshabitada3MesesAnoCont.Text))
            {
                ok = false;
                errorProvider1.SetError(cmbDeshabitada3MesesAnoCont, "Campo obligatorio");
                cmbDeshabitada3MesesAnoCont.Text = "";
            }
            if (string.IsNullOrEmpty(txtAnoConstruccionCont.Text)
               || string.IsNullOrWhiteSpace(txtAnoConstruccionCont.Text))
            {
                ok = false;
                errorProvider1.SetError(txtAnoConstruccionCont, "Campo obligatorio");
                txtAnoConstruccionCont.Text = "";
            }
            if (string.IsNullOrEmpty(txtM2ViviendaCont.Text)
               || string.IsNullOrWhiteSpace(txtM2ViviendaCont.Text))
            {
                ok = false;
                errorProvider1.SetError(txtM2ViviendaCont, "Campo obligatorio");
                txtM2ViviendaCont.Text = "";
            }

            if (string.IsNullOrEmpty(txtDescripcionMueblesCont.Text)
              || string.IsNullOrWhiteSpace(txtDescripcionMueblesCont.Text))
            {
                ok = false;
                errorProvider1.SetError(txtDescripcionMueblesCont, "Campo obligatorio");
                txtDescripcionMueblesCont.Text = "";
            }
            if (string.IsNullOrEmpty(txtValorMuebles.Text)
              || string.IsNullOrWhiteSpace(txtValorMuebles.Text))
            {
                ok = false;
                errorProvider1.SetError(txtValorMuebles, "Campo obligatorio");
                txtValorMuebles.Text = "";
            }

            return ok;
        }


        private void QuitarErrorProviderSegContendio()
        {
            errorProvider1.SetError(txtTipoViviendaCont, "");
            errorProvider1.SetError(txtSituacionCont, "");
            errorProvider1.SetError(txtPropietarioCont, "");
            errorProvider1.SetError(cmbViviendaHabitualCont, "");
            errorProvider1.SetError(txtCodigoPostalCont, "");
            errorProvider1.SetError(cmbDeshabitada3MesesAnoCont, "");
            errorProvider1.SetError(txtAnoConstruccionCont, "");
            errorProvider1.SetError(txtM2ViviendaCont, "");
            errorProvider1.SetError(txtDescripcionMueblesCont, "");
            errorProvider1.SetError(txtValorMuebles, "");
        }

        private bool ValidarCamposSegSegEdificaciones()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtTipoVivienda.Text)
               || string.IsNullOrWhiteSpace(txtTipoVivienda.Text))
            {
                ok = false;
                errorProvider1.SetError(txtTipoVivienda, "Campo obligatorio");
                txtTipoVivienda.Text = "";
            }

            if (string.IsNullOrEmpty(txtSituacion.Text)
                || string.IsNullOrWhiteSpace(txtSituacion.Text))
            {
                ok = false;
                errorProvider1.SetError(txtSituacion, "Campo obligatorio");
                txtSituacion.Text = "";
            }

            if (string.IsNullOrEmpty(txtPropietario.Text)
                || string.IsNullOrWhiteSpace(txtPropietario.Text))
            {
                ok = false;
                errorProvider1.SetError(txtPropietario, "Campo obligatorio");
                txtPropietario.Text = "";
            }

            if (string.IsNullOrEmpty(cmbViviendaHabitual.Text)
                || string.IsNullOrWhiteSpace(cmbViviendaHabitual.Text))
            {
                ok = false;
                errorProvider1.SetError(cmbViviendaHabitual, "Campo obligatorio");
                cmbViviendaHabitual.Text = "";
            }

            if (string.IsNullOrEmpty(txtCodigoPostal.Text)
                || string.IsNullOrWhiteSpace(txtCodigoPostal.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCodigoPostal, "Campo obligatorio");
                txtCodigoPostal.Text = "";
            }

            if (string.IsNullOrEmpty(cmbDeshabitada3MesesAno.Text)
               || string.IsNullOrWhiteSpace(cmbDeshabitada3MesesAno.Text))
            {
                ok = false;
                errorProvider1.SetError(cmbDeshabitada3MesesAno, "Campo obligatorio");
                cmbDeshabitada3MesesAno.Text = "";
            }
            if (string.IsNullOrEmpty(txtAnoConstruccion.Text)
               || string.IsNullOrWhiteSpace(txtAnoConstruccion.Text))
            {
                ok = false;
                errorProvider1.SetError(txtAnoConstruccion, "Campo obligatorio");
                txtAnoConstruccion.Text = "";
            }
            if (string.IsNullOrEmpty(txtM2Vivienda.Text)
               || string.IsNullOrWhiteSpace(txtM2Vivienda.Text))
            {
                ok = false;
                errorProvider1.SetError(txtM2Vivienda, "Campo obligatorio");
                txtM2Vivienda.Text = "";
            }

            if (string.IsNullOrEmpty(txtM2EdificacionesAnexas.Text)
              || string.IsNullOrWhiteSpace(txtM2EdificacionesAnexas.Text))
            {
                ok = false;
                errorProvider1.SetError(txtM2EdificacionesAnexas, "Campo obligatorio");
                txtM2EdificacionesAnexas.Text = "";
            }
            if (string.IsNullOrEmpty(txtCapitalOtrasInstalaciones.Text)
              || string.IsNullOrWhiteSpace(txtCapitalOtrasInstalaciones.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCapitalOtrasInstalaciones, "Campo obligatorio");
                txtCapitalOtrasInstalaciones.Text = "";
            }

            return ok;
        }

        private void QuitarErrorProviderSegEdificaciones()
        {
            errorProvider1.SetError(txtTipoVivienda, "");
            errorProvider1.SetError(txtSituacion, "");
            errorProvider1.SetError(txtPropietario, "");
            errorProvider1.SetError(cmbViviendaHabitual, "");
            errorProvider1.SetError(txtCodigoPostal, "");
            errorProvider1.SetError(cmbDeshabitada3MesesAno, "");
            errorProvider1.SetError(txtAnoConstruccion, "");
            errorProvider1.SetError(txtM2Vivienda, "");
            errorProvider1.SetError(txtM2EdificacionesAnexas, "");
            errorProvider1.SetError(txtCapitalOtrasInstalaciones, "");
        }

        private bool ValidarCamposSegEmprNegocios()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtNombreEmpresa.Text)
               || string.IsNullOrWhiteSpace(txtNombreEmpresa.Text))
            {
                ok = false;
                errorProvider1.SetError(txtNombreEmpresa, "Campo obligatorio");
                txtNombreEmpresa.Text = "";
            }

            if (string.IsNullOrEmpty(txtCopiaEstatutos.Text)
                || string.IsNullOrWhiteSpace(txtCopiaEstatutos.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCopiaEstatutos, "Campo obligatorio");
                txtCopiaEstatutos.Text = "";
            }

            if (string.IsNullOrEmpty(txtCopiaActaAsignacionRNC.Text)
                || string.IsNullOrWhiteSpace(txtCopiaActaAsignacionRNC.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCopiaActaAsignacionRNC, "Campo obligatorio");
                txtCopiaActaAsignacionRNC.Text = "";
            }

            if (string.IsNullOrEmpty(txtCopiaCedulaPresidente_RepresAut.Text)
                || string.IsNullOrWhiteSpace(txtCopiaCedulaPresidente_RepresAut.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCopiaCedulaPresidente_RepresAut, "Campo obligatorio");
                txtCopiaCedulaPresidente_RepresAut.Text = "";
            }

            if (string.IsNullOrEmpty(txtTelefonoEntAut.Text)
                || string.IsNullOrWhiteSpace(txtTelefonoEntAut.Text))
            {
                ok = false;
                errorProvider1.SetError(txtTelefonoEntAut, "Campo obligatorio");
                txtTelefonoEntAut.Text = "";
            }

            if (picImagen1.Image == null)
            {
                ok = false;
                errorProvider1.SetError(picImagen5, "Seleccione las fotos");
            }

            if (string.IsNullOrEmpty(txtCorreoElectronicoEntAutorizada.Text)
               || string.IsNullOrWhiteSpace(txtCorreoElectronicoEntAutorizada.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCorreoElectronicoEntAutorizada, "Campo obligatorio");
                txtCorreoElectronicoEntAutorizada.Text = "";
            }

            return ok;
        }

        private void QuitarErrorProviderSegEmprNegocios()
        {
            errorProvider1.SetError(txtNombreEmpresa, "");
            errorProvider1.SetError(txtCopiaEstatutos, "");
            errorProvider1.SetError(txtCopiaActaAsignacionRNC, "");
            errorProvider1.SetError(txtCopiaCedulaPresidente_RepresAut, "");
            errorProvider1.SetError(txtTelefonoEntAut, "");
            errorProvider1.SetError(picImagen5, "");
            errorProvider1.SetError(txtCorreoElectronicoEntAutorizada, "");
        }

        private void btnSIGUIENTEpnlVidaSaludDependientes_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
        }

      
        public void MostrarFormFactura()
        {
            frmFacturas f = new frmFacturas();
            f.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            csLimpiar L = new csLimpiar();
            L.BorrarCamposPnl(pnlCliente);

            lblId.Visible = false;
            txtId.Visible = false;

            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            mskCedula.ReadOnly = false;
            mskTelefono.ReadOnly = false;
            txtCorreoElectronico.ReadOnly = false;
            cmbNacionalidad.Enabled = true;
            cmbSexo.Enabled = true;
            txtRNC.ReadOnly = false;

            QuitarErrorProviderCliente();
        }

        private void QuitarErrorProviderCliente()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(mskCedula, "");
            errorProvider1.SetError(mskTelefono, "");
            errorProvider1.SetError(cmbNacionalidad, "");
            errorProvider1.SetError(txtCorreoElectronico, "");
            errorProvider1.SetError(cmbSexo, "");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pnlBuscarCliente.Visible = true;
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            dgvBuscarClientes.DataSource = B_Clientes.B_MostrarClientes();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            pnlBuscarCliente.Visible = false;
        }

        private void dgvBuscarClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = dgvBuscarClientes.CurrentRow;
            txtId.Text = row.Cells[0].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
            txtApellido.Text = row.Cells[2].Value.ToString();
            txtDireccion.Text = row.Cells[3].Value.ToString();
            mskCedula.Text = row.Cells[4].Value.ToString();
            cmbNacionalidad.Text = row.Cells[5].Value.ToString();
            mskTelefono.Text = row.Cells[6].Value.ToString();
            txtCorreoElectronico.Text = row.Cells[7].Value.ToString();

            txtRNC.Text = row.Cells[9].Value.ToString();

            string strSexo = "";
            switch (row.Cells[8].Value.ToString())
            {
                case "M":
                    strSexo = "Masculino";
                    break;

                case "F":
                    strSexo = "Femenino";
                    break;
            }
            cmbSexo.Text = strSexo;
            pnlBuscarCliente.Visible = false;
            InhabilitarTxTs();
        }

        private void InhabilitarTxTs()
        {

            lblId.Visible = true;
            txtId.Visible = true;

            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            mskCedula.ReadOnly = true;
            mskTelefono.ReadOnly = true;
            txtCorreoElectronico.ReadOnly = true;
            cmbNacionalidad.Enabled = false;
            cmbSexo.Enabled = false;
            txtRNC.ReadOnly = true;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            QuitarErrorProviderCliente();
            if (ValidarCamposCliente() || mskTelefonoValidar() || mskCedulaValidar())
            {
                InsertarCliente();
            }
        }

        private void InsertarCliente()
        {
            try
            {
                if (!txtId.Text.Equals(""))
                {
                    MessageBox.Show("El Cliente ya existe. Haga clic en Nuevo para añadir a otro cliente.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text)
                    || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrWhiteSpace(txtApellido.Text)
                    || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || !mskTelefonoValidar() || !mskCedulaValidar()
                    || string.IsNullOrEmpty(txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text)
                    || string.IsNullOrEmpty(cmbNacionalidad.Text) || string.IsNullOrWhiteSpace(cmbNacionalidad.Text)
                    || string.IsNullOrEmpty(cmbSexo.Text) || string.IsNullOrWhiteSpace(cmbSexo.Text))
                    {
                        MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        E_Clientes.Nombre = txtNombre.Text.Trim();
                        E_Clientes.Apellido = txtApellido.Text.Trim();
                        E_Clientes.Cedula = mskCedula.Text.Trim();
                        E_Clientes.Direccion = txtDireccion.Text.Trim();
                        E_Clientes.Telefono = mskTelefono.Text.Trim();
                        E_Clientes.Nacionalidad = cmbNacionalidad.Text.Trim();
                        E_Clientes.CorreoElectronico = txtCorreoElectronico.Text.Trim();
                        E_Clientes.Sexo = cmbSexo.Text.Trim();
                        E_Clientes.RNC = txtRNC.Text.Trim();
                        E_Clientes.FechaHora = DateTime.Now;

                        int rsp = B_Clientes.B_InsertarCliente(E_Clientes);
                        if (rsp == 0)
                        {
                            MessageBox.Show("No se añadió el Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Se ha añadido el Cliente correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtId.Text = rsp.ToString();
                            InhabilitarTxTs();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void mskCedula_Validating(object sender, CancelEventArgs e)
        {
            mskCedulaValidar();
        }

        private bool mskCedulaValidar()
        {
            bool valor = false;
            if (!mskCedula.Text.Length.Equals(13))
            {
                valor = false;
                errorProvider1.SetError(mskCedula, "Complete la Cédula");
            }
            else
            {
                valor = true;
            }

            return valor;
        }

        private void mskTelefono_Validating(object sender, CancelEventArgs e)
        {
            mskTelefonoValidar();
        }

        private bool mskTelefonoValidar()
        {
            bool valor = false;

            if (!mskTelefono.Text.Length.Equals(14))
            {
                valor = false;
                errorProvider1.SetError(mskTelefono, "Complete el Telefono");
            }
            else
            {
                valor = true;
            }
            return valor;
        }

        private bool ValidarCamposCliente()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Escriba el Nombre");
            }

            if (string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                ok = false;
                errorProvider1.SetError(txtApellido, "Escriba el Apellido");
            }
            if (string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                ok = false;
                errorProvider1.SetError(txtDireccion, "Escriba la Dirección");
            }

            if (string.IsNullOrEmpty(cmbNacionalidad.Text) || string.IsNullOrWhiteSpace(cmbNacionalidad.Text))
            {
                ok = false;
                errorProvider1.SetError(cmbNacionalidad, "Escriba la Nacionalidad");
            }
            if (string.IsNullOrEmpty(txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCorreoElectronico, "Escriba el Correo Electrónico");
            }
            if (string.IsNullOrEmpty(cmbSexo.Text) || string.IsNullOrWhiteSpace(cmbSexo.Text))
            {
                ok = false;
                errorProvider1.SetError(cmbSexo, "Indique el Sexo");
            }

            return ok;
        }
        static bool _DescrepcionValue = false;
        public frmSolicitud(bool DescrepcionValue)
        {
            _DescrepcionValue = DescrepcionValue;
        }

        public frmSolicitud(string Categoria)
        {
            _Categoria = Categoria; 
        }

        public bool cancelarDescripcionSeguros(string nombreSeguro)
        {
            bool value = false;
            frmDescripcionSeguros frm = new frmDescripcionSeguros();

            frm.lblSeguro.Text = nombreSeguro;
            frm.txtDescripcion.Text = LlenarDescripcion();

            frm.ShowDialog();

            if (_DescrepcionValue.Equals(true))
            {
                value = true;
            }
            return value;
        }

        private void frmSolicitud_Load(object sender, EventArgs e)
        {
            //    Cargar_idCodigo_detalleEmpresaNegocio();
            //    Cargar_idCodigo_detalleSeguroEdificaciones();
            Cargar_CargarId_Factura();
            //Cargar_idCodigo_detalleSeguroVehiculoVoluntario();
            //Cargar_idCodigo_detalleSeguroVehiculoTodoRiesgo();
            //Cargar_idCodigo_detalleSeguroVehiculoObligatorio();


            CargarSegurosDePoliza();
            CargarEmpleado();
            MostrarClientes();
        }

        private void CargarEmpleado()
        {
            E_SegVida.Id = 1;
            varIdEmpleado = 1; /////

            B_SeguroVida.B_CargarNombreEmpleado(E_SegVida);

            lblNombre_empleado.Text = E_SegVida.NombreEmpleado;
            lblCedula.Text = E_SegVida.Cedula;
        }

        private void Cargar_idCodigo_detalleEmpresaNegocio()
        {
            try
            {
                idCodigoEm = B_Solicitud.B_CargarIdDetalleEmpresaNegocio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cargar_idCodigo_detalleSeguroEdificaciones()
        {
            try
            {
                idCodigoEdif = B_Solicitud.B_CargarIdDetalleSeguroEdificaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cargar_CargarId_Factura()
        {
            try
            {
                idCodigoFact = B_Solicitud.B_CargarId_Factura();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cargar_idCodigo_detalleSeguroVehiculoVoluntario()
        {
            try
            {
                idCodigoVol = B_Solicitud.B_CargarIdDetalleSeguroVehiculoVoluntario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cargar_idCodigo_detalleSeguroVehiculoTodoRiesgo()
        {
            try
            {
                idCodigoTR = B_Solicitud.B_CargarIdDetalleSeguroVehiculoTodoRiesgo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cargar_idCodigo_detalleSeguroVehiculoObligatorio()
        {
            try
            {
                idCodigoObl = B_Solicitud.B_CargarIdDetalleSeguroVehiculoObligatorio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImagenesContenido_Click(object sender, EventArgs e)
        {
            CargarImagenesContenido();
        }

        private void CargarImagenesContenido()
        {
            try
            {
                if (FotosContenido() == 5)
                {
                    imgImagen1 = ImageConvert(strImagen1);
                    imgImagen2 = ImageConvert(strImagen2);
                    imgImagen3 = ImageConvert(strImagen3);
                    imgImagen4 = ImageConvert(strImagen4);
                    imgImagen5 = ImageConvert(strImagen5);

                    picImagen1.LoadAsync(strImagen1);
                    picImagen2.LoadAsync(strImagen2);
                    picImagen3.LoadAsync(strImagen3);
                    picImagen4.LoadAsync(strImagen4);
                    picImagen5.LoadAsync(strImagen5);

                    picImagen1.Cursor = Cursors.Hand;
                    picImagen2.Cursor = Cursors.Hand;
                    picImagen3.Cursor = Cursors.Hand;
                    picImagen4.Cursor = Cursors.Hand;
                    picImagen5.Cursor = Cursors.Hand;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private byte[] ImageConvert(string ImagLoc)
        {
            byte[] img = null;
            FileStream fs = new FileStream(ImagLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            return img;
        }

        private void btnBuscarCopiaEstatutos_Click(object sender, EventArgs e)
        {
            string strFotoCopia = BuscarFotoCopia();
            if (!strFotoCopia.Equals(""))
            {
                txtCopiaEstatutos.Text = strFotoCopia;
                imgCopiaEstatutos = ImageConvert(txtCopiaEstatutos.Text);

                btnVERCopiaEstatutos.Enabled = true;
            }
        }

        private string BuscarFotoCopia()
        {
            string directory = "";
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png|Imagenes BMP|*.bmp|Imagenes GIF|*.gif|Imagenes TIFF|*.tif|Todo |*.*";
            OFD.FilterIndex = 1;

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                directory = OFD.FileName;
                picPreviewImg.ImageLocation = (directory);
                pnlPicImagen.Visible = true;
            }
            return directory;
        }

        private int FotosContenido()
        {
            int count = 0;
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Multiselect = true;
            OFD.Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png|Imagenes BMP|*.bmp|Imagenes GIF|*.gif|Imagenes TIFF|*.tif|Todo |*.*";
            OFD.FilterIndex = 1;


            if (OFD.ShowDialog() == DialogResult.OK)
            {
                count = 1;

                IEnumerable<string> str_ofdFileName = OFD.FileNames.Take(5);

                if (str_ofdFileName.LongCount() == 5)
                {
                    foreach (string file in str_ofdFileName)
                    {
                        if (count == 1)
                        {
                            strImagen1 = file;
                            count++;
                        }
                        else if (count == 2)
                        {
                            strImagen2 = file;
                            count++;
                        }
                        else if (count == 3)
                        {
                            strImagen3 = file;
                            count++;
                        }
                        else if (count == 4)
                        {
                            strImagen4 = file;
                            count++;
                        }
                        else if (count == 5)
                        {
                            strImagen5 = file;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Solo puede seleccionar 5 imagenes. Por favor, intentelo de nuevo"
                        , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return count;
        }

        private void btnCopiaActaAsignacionRNC_Click(object sender, EventArgs e)
        {
            string strFotoCopia = BuscarFotoCopia();
            if (!strFotoCopia.Equals(""))
            {
                txtCopiaActaAsignacionRNC.Text = strFotoCopia;
                imgCopiaActaAsignacionRNC = ImageConvert(txtCopiaActaAsignacionRNC.Text);

                btnVERCopiaActaAsignacionRNC.Enabled = true;
            }
        }

        private void btnCopiaCedulaPresidente_RepresAut_Click(object sender, EventArgs e)
        {
            string strFotoCopia = BuscarFotoCopia();
            if (!strFotoCopia.Equals(""))
            {
                txtCopiaCedulaPresidente_RepresAut.Text = strFotoCopia;
                imgCopiaPresidenteReprAut = ImageConvert(txtCopiaCedulaPresidente_RepresAut.Text);

                btnVERCopiaCedulaPresidente_RepresAut.Enabled = true;
            }
        }
         
        private void lblCerrarPicPreview_Click(object sender, EventArgs e)
        {
            picPreviewImg.Image = null;
            pnlPicImagen.Visible = false;
        }

        private void btnVERCopiaEstatutos_Click(object sender, EventArgs e)
        {
            pnlPicImagen.Visible = true;
            picPreviewImg.LoadAsync(txtCopiaEstatutos.Text);
        }

        private void btnVERCopiaActaAsignacionRNC_Click(object sender, EventArgs e)
        {
            pnlPicImagen.Visible = true;
            picPreviewImg.LoadAsync(txtCopiaActaAsignacionRNC.Text);
        }

        private void btnVERCopiaCedulaPresidente_RepresAut_Click(object sender, EventArgs e)
        {
            pnlPicImagen.Visible = true;
            picPreviewImg.LoadAsync(txtCopiaCedulaPresidente_RepresAut.Text);
        }

        private void picImagen1_Click(object sender, EventArgs e)
        {
            if (!(picImagen1.Image == null))
            {
                pnlPicImagen.Visible = true;
                picPreviewImg.LoadAsync(strImagen1);
            }
        }

        private void picImagen2_Click(object sender, EventArgs e)
        {
            if (!(picImagen2.Image == null))
            {
                pnlPicImagen.Visible = true;
                picPreviewImg.LoadAsync(strImagen2);
            }
        }
        private void picImagen3_Click(object sender, EventArgs e)
        {
            if (!(picImagen3.Image == null))
            {
                pnlPicImagen.Visible = true;
                picPreviewImg.LoadAsync(strImagen3);
            }
        }

        private void picImagen4_Click(object sender, EventArgs e)
        {
            if (!(picImagen4.Image == null))
            {
                pnlPicImagen.Visible = true;
                picPreviewImg.LoadAsync(strImagen4);
            }
        }

        private void picImagen5_Click(object sender, EventArgs e)
        {
            if (!(picImagen5.Image == null))
            {
                pnlPicImagen.Visible = true;
                picPreviewImg.LoadAsync(strImagen5);
            }
        }

        private void txtAnoConstruccion_TextChanged(object sender, EventArgs e)
        {
            txtAnoConstruccion.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };
        }

        private void txtM2Vivienda_TextChanged(object sender, EventArgs e)
        {
            txtM2Vivienda.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };
        }

        private void txtM2EdificacionesAnexas_TextChanged(object sender, EventArgs e)
        {
            txtM2EdificacionesAnexas.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };
        }

        private void txtCodigoPostal_TextChanged(object sender, EventArgs e)
        {
            txtCodigoPostal.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }
        public void BuscarClientes()
        {
            try
            {
                if (chkSoloId.Checked)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvBuscarClientes.DataSource;
                    bs.Filter = "CONVERT(id, 'System.String') like '%" + txtBuscar.Text + "%'";
                    dgvBuscarClientes.DataSource = bs;
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvBuscarClientes.DataSource;
                    bs.Filter = "CONVERT(id, 'System.String') like '%" + txtBuscar.Text + "%' OR Nombre like '%" +
                        txtBuscar.Text + "%' OR Apellido like '%" + txtBuscar.Text +
                        "%' OR Direccion like '%" + txtBuscar.Text + "%' OR Cedula like '%" + txtBuscar.Text +
                        "%' OR Telefono like '%" + txtBuscar.Text + "%' OR [Correo Electronico] like '%" + txtBuscar.Text + "%'";
                    dgvBuscarClientes.DataSource = bs;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void chkSoloId_CheckedChanged(object sender, EventArgs e)
        {
            BuscarClientes();
            if (chkSoloId.Checked)
            {
                chkSoloId.BackColor = Color.DarkViolet;
                chkSoloId.ForeColor = Color.White;
            }
            else
            {
                chkSoloId.BackColor = Color.White;
                chkSoloId.ForeColor = Color.Crimson;
            }
        }

        private void txtCodigoPostalCont_TextChanged(object sender, EventArgs e)
        {
            txtCodigoPostalCont.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };
        }

        private void txtAnoConstruccionCont_TextChanged(object sender, EventArgs e)
        {
            txtAnoConstruccionCont.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };
        }

        private void txtM2ViviendaCont_TextChanged(object sender, EventArgs e)
        {
            txtM2ViviendaCont.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };
        }

        private void txtValorMuebles_TextChanged(object sender, EventArgs e)
        {
            txtValorMuebles.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };
        }

        private void txtCilindrosVol_TextChanged(object sender, EventArgs e)
        {
            txtCilindrosVol.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };
        }

        private void txtAnoVol_TextChanged(object sender, EventArgs e)
        {
            txtCilindrosVol.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };
        }

        private void txtCilindrosTR_TextChanged(object sender, EventArgs e)
        {
            txtCilindrosTR.TextChanged += delegate (System.Object o, System.EventArgs r)
             {
                 TextBox _tbox = o as TextBox;
                 _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
             };
        }

        private void txtAnoTR_TextChanged(object sender, EventArgs e)
        {
            txtAnoTR.TextChanged += delegate (System.Object o, System.EventArgs r)
             {
                 TextBox _tbox = o as TextBox;
                 _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
             };
        }

        private void txtCilindrosObl_TextChanged(object sender, EventArgs e)
        {
            txtCilindrosObl.TextChanged += delegate (System.Object o, System.EventArgs r)
             {
                 TextBox _tbox = o as TextBox;
                 _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
             };
        }

        private void txtAnoObl_TextChanged(object sender, EventArgs e)
        {
            txtCilindrosObl.TextChanged += delegate (System.Object o, System.EventArgs r)
             {
                 TextBox _tbox = o as TextBox;
                 _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
             };
        }
    }
}