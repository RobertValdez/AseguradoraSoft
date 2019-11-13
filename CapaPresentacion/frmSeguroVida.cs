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
    public partial class frmSeguroVida : Form
    {
        E_Clientes E_Clientes = new E_Clientes();
        B_Clientes B_Clientes = new B_Clientes();

        public frmSeguroVida()
        {
            InitializeComponent();
        }

        private void btnRiesgoMuerte_Click(object sender, EventArgs e)
        {
            pnlVidaRiesgoMuerte.Visible = true;
        }

        private void btnRiesgosLaborales_Click(object sender, EventArgs e)
        {
            pnlVidaRiesgosLaborales.Visible = true;
        }

        private void btnSeguroSalud_Click(object sender, EventArgs e)
        {
            pnlVidaSalud.Visible = true;
        }

        private void btnDependientes_Click(object sender, EventArgs e)
        {
            pnlVidaSaludDependientes.Visible = true;
        }

        private void lblCerrarRiesgoMuerte_Click(object sender, EventArgs e)
        {
            pnlVidaRiesgoMuerte.Visible = false;
        }

        private void lblCerrar_pnlRiesgoLab_Click(object sender, EventArgs e)
        {
            pnlVidaRiesgosLaborales.Visible = false;
        }

        private void lblVidaRLab_BuscarEmpresaCerrar_Click(object sender, EventArgs e)
        {
            pnlVidaRiesgosLaborales_BuscarEmpresa.Visible = false;
        }

        private void lblCerrar_pnlVidaSalud_Click(object sender, EventArgs e)
        {
            pnlVidaSalud.Visible = false;
        }

        private void lblCerrarSDepend_Click(object sender, EventArgs e)
        {
            pnlVidaSaludDependientes.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pnlBuscarCliente.Visible = true;
            MostrarClientes();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            pnlBuscarCliente.Visible = false;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            QuitarErrorProvider();
            ValidarCamposCliente();
            InsertarCliente();
        }
        public void InsertarCliente()
        {
            try
            {

                if (!txtId.Text.Equals(""))
                {
                    MessageBox.Show("El Cliente ya existe. Haga clic en Nuevo para añadir a otro cliente.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || mskCedula.Text == "   -       -" || mskTelefono.Text == "" || txtCorreoElectronico.Text == "" || txtNacionalidad.Text == "" || cmbSexo.Text == "")
                    {
                        MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        E_Clientes.Nombre = txtNombre.Text;
                        E_Clientes.Apellido = txtApellido.Text;
                        E_Clientes.Cedula = mskCedula.Text;
                        E_Clientes.Direccion = txtDireccion.Text;
                        E_Clientes.Telefono = mskTelefono.Text;
                        E_Clientes.Nacionalidad = txtNacionalidad.Text;
                        E_Clientes.CorreoElectronico = txtCorreoElectronico.Text;
                        E_Clientes.Sexo = cmbSexo.Text;
                        E_Clientes.RNC = txtRNC.Text;
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
                            InhabilitarTxT();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmSeguroVida_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }
        public void MostrarClientes()
        {
            dgvBuscarClientes.DataSource = B_Clientes.B_MostrarClientes();
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

        private void AC_SeguroSalud_Click(object sender, EventArgs e)
        {
            frmDescripcionSeguros frm = new frmDescripcionSeguros();
            frm.ShowDialog();
        }

        private void btnSIGUIENTEpnlVidaSalud_Click(object sender, EventArgs e)
        {
            try
            {
                QuitarErrorProviderSegSalud();
                ValidarCamposSegSalud();
                if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || mskCedula.Text == "   -       -" || mskTelefono.Text == "" || txtCorreoElectronico.Text == "" || txtNacionalidad.Text == "" || cmbSexo.Text == ""
                    || txtAntecedentesPersonales.Text == "" || txtInstitutoDondeLabora.Text == "" || (rbBasicoSegSalud.Checked == false && rbSemiFullSegSalud.Checked == false && rbFullSegSalud.Checked == false))
                {
                    MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNombre.ReadOnly == true) // False aquí: Significa que está añadido como cliente en la Base de Datos
                {
                    string strRb_Categoria = "";
                    if (rbBasicoSegSalud.Checked == true)
                    {
                        strRb_Categoria = "Básico";
                    }
                    else if (rbSemiFullSegSalud.Checked == true)
                    {
                        strRb_Categoria = "Semi Full";
                    }
                    else if (rbFullSegSalud.Checked == true)
                    {
                        strRb_Categoria = "Full";
                    }
                    frmFacturas frmFac = new frmFacturas();

                    frmFac.txtId.Text = txtId.Text;
                    frmFac.txtCliente.Text = txtNombre.Text + " " + txtApellido.Text;
                    frmFac.txtCedula.Text = mskCedula.Text;
                    frmFac.txtSeguroA_Adquirir.Text = lblSeguroSalud.Text;
                    frmFac.txtEfectoA_Asegurar.Text = "N/A";
                    frmFac.txtCategoria.Text = strRb_Categoria;

                    frmFac.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Añada el Cliente actual para poder continuar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private bool ValidarCamposSegSalud()
        {
            bool ok = true;

            if (txtInstitutoDondeLabora.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtInstitutoDondeLabora, "Campo obligatorio");
            }
            if (txtAntecedentesPersonales.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtAntecedentesPersonales, "Campo obligatorio");
            }

            return ok;
        }

        private void QuitarErrorProviderSegSalud()
        {
            errorProvider1.SetError(txtInstitutoDondeLabora, "");
            errorProvider1.SetError(txtAntecedentesPersonales, "");
        }

        private void dgvBuscarClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvBuscarClientes.CurrentRow;
            txtId.Text = row.Cells[0].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
            txtApellido.Text = row.Cells[2].Value.ToString();
            txtDireccion.Text = row.Cells[3].Value.ToString();
            mskCedula.Text = row.Cells[4].Value.ToString();
            txtNacionalidad.Text = row.Cells[5].Value.ToString();
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
            InhabilitarTxT();
        }

        public void InhabilitarTxT()
        {
            lblId.Visible = true;
            txtId.Visible = true;

            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            mskCedula.ReadOnly = true;
            mskTelefono.ReadOnly = true;
            txtCorreoElectronico.ReadOnly = true;
            txtNacionalidad.ReadOnly = true;
            cmbSexo.Enabled = false;
            txtRNC.ReadOnly = true;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            csLimpiar L = new csLimpiar();
            L.BorrarCampos(pnlCliente);

            lblId.Visible = false;
            txtId.Visible = false;

            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            mskCedula.ReadOnly = false;
            mskTelefono.ReadOnly = false;
            txtCorreoElectronico.ReadOnly = false;
            txtNacionalidad.ReadOnly = false;
            cmbSexo.Enabled = true;
            txtRNC.ReadOnly = false;

            QuitarErrorProvider();
        }

        private bool ValidarCamposCliente()
        {
            bool ok = true;

            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Escriba el Nombre");
            }

            if (txtApellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApellido, "Escriba el Apellido");
            }
            if (txtDireccion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDireccion, "Escriba la Dirección");
            }
            if (mskCedula.Text == "   -       -")
            {
                ok = false;
                errorProvider1.SetError(mskCedula, "Escriba la Cédula");
            }
            if (mskTelefono.Text == "(   )-   -")
            {
                ok = false;
                errorProvider1.SetError(mskTelefono, "Escriba el Telefono");
            }
            if (txtNacionalidad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNacionalidad, "Escriba la Nacionalidad");
            }
            if (txtCorreoElectronico.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCorreoElectronico, "Escriba el Correo Electrónico");
            }
            if (cmbSexo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cmbSexo, "Indique el Sexo");
            }

            return ok;
        }
        private void QuitarErrorProvider()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(mskCedula, "");
            errorProvider1.SetError(mskTelefono, "");
            errorProvider1.SetError(txtNacionalidad, "");
            errorProvider1.SetError(txtCorreoElectronico, "");
            errorProvider1.SetError(cmbSexo, "");
        }
    }
}
