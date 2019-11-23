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

namespace CapaPresentacion
{
    public partial class frmSolicitud : Form
    {

        E_Clientes E_Clientes = new E_Clientes();
        B_Clientes B_Clientes = new B_Clientes();

        static string _Categoria = "";
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
                pnlNegociosEmpresas.Visible = true;
            }
        }

        private void lblCerrarNegocioEmp_Click(object sender, EventArgs e)
        {
            pnlNegociosEmpresas.Visible = false;
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
            MostrarFormFactura();
        }

        private void btnSIGUIENTEpnlNegociosEmpresas_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
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
    }
}
