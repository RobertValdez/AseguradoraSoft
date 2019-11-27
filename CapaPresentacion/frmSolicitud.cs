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

        int idCodigo = 0;
        decimal Precio = 0;
        int varIdEmpleado = 0;

        int idProductoSeguroVidaSalud = 0;

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

            if (!cancelarDescripcionSeguros())
            {
                pnlVEHSeguroVoluntario.Visible = true;
            }
        }

        private void btnSeguroObligatorio_Click(object sender, EventArgs e)
        {
            pnlVehiculo.Visible = false;

            if (!cancelarDescripcionSeguros())
            {
                pnlVEHSeguroObligatorio.Visible = true;
            }
        }

        private void btnSeguroTodoRiesgo_Click(object sender, EventArgs e)
        {
            pnlVehiculo.Visible = false;

            if (!cancelarDescripcionSeguros())
            {
                pnlVEHSeguroTodoRiesgo.Visible = true;
            }
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

            pnlInmuebles.Visible = false;

            if (!cancelarDescripcionSeguros())
            {
                pnlMueblesInmContenido.Visible = true;
            }
        }

        private void btnInmEdificaciones_Click(object sender, EventArgs e)
        {
            pnlInmuebles.Visible = false;

            if (!cancelarDescripcionSeguros())
            {
                DataView dv = new DataView(dtPolizaDeSeguros);

                dv.RowFilter = "[Nombre del Seguro] = 'Seguro Edificaciones'";

                idProductoSeguroVidaSalud = (int)dv[0]["id"];
                Precio = (decimal)dv[0]["Precio"];
                pnlMueblesInmEdificaciones.Visible = true;
            }
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
            if (!cancelarDescripcionSeguros())
            {
                DataView dv = new DataView(dtPolizaDeSeguros);

                dv.RowFilter = "[Nombre del Seguro] = 'Seguro Negocios y Empresas'";

                idProductoSeguroVidaSalud = (int)dv[0]["id"];
                Precio = (decimal)dv[0]["Precio"];


                pnlNegociosEmpresas.Visible = true;
            }
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

        private void btnVidaRLab_BuscarEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void lblVidaRLab_BuscarEmpresaCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguientepnlVEHSeguroObligatorio_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
        }

        private void btnSIGUIENTEpnlVEHSeguroTodoRiesgo_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
        }

        private void btnSIGUIENTEpnlVEHSeguroVoluntario_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
        }

        private void btnSIGUIENTEpnlMueblesInmContenido_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
        }

        private void btnSIGUIENTEpnlMueblesInmEdificaciones_Click(object sender, EventArgs e)
        {
            try
            {
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
                    frmFac.txtSeguroA_Adquirir.Text = lblSeguroNEmpresa.Text;
                    frmFac.txtEfectoA_Asegurar.Text = txtNombreEmpresa.Text;
                    frmFac.txtCategoria.Text = _Categoria;
                    frmFac.txtIdSeguro.Text = idProductoSeguroVidaSalud.ToString();

                    frmFac.txtCodigo.Text = idCodigo.ToString();
                    frmFac.txtSubTotal.Text = Precio.ToString();
                    frmFac.txtTotalA_Pagar.Text = Precio.ToString();






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
                    frmFac.txtIdSeguro.Text = idProductoSeguroVidaSalud.ToString();

                    frmFac.txtCodigo.Text = idCodigo.ToString();
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

        private void btnSIGUIENTEpnlVidaSalud_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
        }

        private void btnSIGUIENTEpnlVidaRiesgoMuerte_Click(object sender, EventArgs e)
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

        public bool cancelarDescripcionSeguros()
        {
            bool value = false;
            frmDescripcionSeguros frm = new frmDescripcionSeguros();
            frm.ShowDialog();

            if (_DescrepcionValue.Equals(true))
            {
                value = true;
            }
            return value;
        }

        private void frmSolicitud_Load(object sender, EventArgs e)
        {
            Cargar_idCodigo_detalleSeguroSalud();
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

        private void Cargar_idCodigo_detalleSeguroSalud()
        {
            try
            {
                idCodigo = B_Solicitud.B_CargarIdDetalleEmpresaNegocio();
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
    }
}
