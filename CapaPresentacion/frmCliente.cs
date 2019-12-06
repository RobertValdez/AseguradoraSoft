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
    public partial class frmCliente : Form
    {
        E_Clientes E_Clientes = new E_Clientes();
        B_Clientes B_Clientes = new B_Clientes();
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlNuevo.Visible = true;
            pnlModificar.Visible = false;
            Size = new Size(640, 578);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            pnlNuevo.Visible = false;
            pnlModificar.Visible = true;
            this.Size = new Size(1234, 732);
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Size = new Size(640, 578);
            MostrarClientes();
        }
        public void MostrarClientes()
        {
            dgvClientes.DataSource = B_Clientes.B_MostrarClientes();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            InsertarCliente();
            MostrarClientes();
        }

        public void InsertarCliente()
        {
            try
            {
                QuitarErrorProviderCliente();

                mskTelefonoValidar();
                mskCedulaValidar();
                ValidarCamposCliente();

                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text)
                     || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrWhiteSpace(txtApellido.Text)
                     || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || mskCedula.MaskFull == false || mskTelefono.MaskFull == false
                     || string.IsNullOrEmpty(txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text)
                     || string.IsNullOrEmpty(txtNacionalidad.Text) || string.IsNullOrWhiteSpace(txtNacionalidad.Text)
                     || string.IsNullOrEmpty(cmbSexo.Text) || string.IsNullOrWhiteSpace(cmbSexo.Text))
                {
                    MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string strSexo = "";
                    switch (cmbSexo.Text)
                    {
                        case "Masculino":
                            strSexo = "M";
                            break;

                        case "Femenino":
                            strSexo = "F";
                            break;
                    }

                    E_Clientes.Nombre = txtNombre.Text;
                    E_Clientes.Apellido = txtApellido.Text;
                    E_Clientes.Cedula = mskCedula.Text;
                    E_Clientes.Direccion = txtDireccion.Text;
                    E_Clientes.Telefono = mskTelefono.Text;
                    E_Clientes.Nacionalidad = txtNacionalidad.Text;
                    E_Clientes.CorreoElectronico = txtCorreoElectronico.Text;
                    E_Clientes.Sexo = strSexo;
                    E_Clientes.RNC = txtRNC.Text;
                    E_Clientes.FechaHora = DateTime.Now;


                    if (B_Clientes.B_InsertarCliente(E_Clientes) >= 1)
                    {
                        MessageBox.Show("Se ha añadido el Cliente correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se añadió el Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvClientes.CurrentRow;
            txtIdMod.Text = row.Cells[0].Value.ToString();
            txtNombreMod.Text = row.Cells[1].Value.ToString();
            txtApellidoMod.Text = row.Cells[2].Value.ToString();
            txtDireccionMod.Text = row.Cells[3].Value.ToString();
            mskCedulaMod.Text = row.Cells[4].Value.ToString();
            txtNacionalidadMod.Text = row.Cells[5].Value.ToString();
            txtTelefonoMod.Text = row.Cells[6].Value.ToString();
            txtCorreoElectronicoMod.Text = row.Cells[7].Value.ToString();

            txtRNC_Mod.Text = row.Cells[9].Value.ToString();

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
            cmbSexoMod.Text = strSexo;
        }

        private void btnGuardarCambiosMod_Click(object sender, EventArgs e)
        {
            ModificarCliente();
            MostrarClientes();
        }
        public void ModificarCliente()
        {
            try
            {

                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text)
                     || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrWhiteSpace(txtApellido.Text)
                     || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || mskCedula.MaskFull == false || mskTelefono.MaskFull == false
                     || string.IsNullOrEmpty(txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text)
                     || string.IsNullOrEmpty(txtNacionalidad.Text) || string.IsNullOrWhiteSpace(txtNacionalidad.Text)
                     || string.IsNullOrEmpty(cmbSexo.Text) || string.IsNullOrWhiteSpace(cmbSexo.Text))
                {
                    MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    E_Clientes.Id = Convert.ToInt32(txtIdMod.Text);
                    E_Clientes.Nombre = txtNombreMod.Text;
                    E_Clientes.Apellido = txtApellidoMod.Text;
                    E_Clientes.Cedula = mskCedulaMod.Text;
                    E_Clientes.Direccion = txtDireccionMod.Text;
                    E_Clientes.Telefono = txtTelefonoMod.Text;
                    E_Clientes.Nacionalidad = txtNacionalidadMod.Text;
                    E_Clientes.CorreoElectronico = txtCorreoElectronicoMod.Text;
                    E_Clientes.Sexo = cmbSexoMod.Text;
                    E_Clientes.RNC = txtRNC_Mod.Text;
                    E_Clientes.FechaHora = DateTime.Now;

                    if (B_Clientes.B_ModificarCliente(E_Clientes) == 1)
                    {
                        MessageBox.Show("Se ha modificado el Cliente correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



        private void btnEliminarMod_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarCliente();
                MostrarClientes();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void EliminarCliente()
        {
            E_Clientes.Id = Convert.ToInt32(txtIdMod.Text);
            if (MessageBox.Show("Está seguro de eliminar a el Cliente seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_Clientes.B_EliminarCliente(E_Clientes) == 1)
                {
                    MessageBox.Show("Cliente Eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede añadir varios clientes con una misma cédula.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
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
                    bs.DataSource = dgvClientes.DataSource;
                    bs.Filter = "CONVERT(id, 'System.String') like '%" + txtBuscarCliente.Text + "%'";
                    dgvClientes.DataSource = bs;
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvClientes.DataSource;
                    bs.Filter = "CONVERT(id, 'System.String') like '%" + txtBuscarCliente.Text + "%' OR Nombre like '%" + txtBuscarCliente.Text + "%' OR Apellido like '%" + txtBuscarCliente.Text +
                        "%' OR Direccion like '%" + txtBuscarCliente.Text + "%' OR Cedula like '%" + txtBuscarCliente.Text +
                        "%' OR Telefono like '%" + txtBuscarCliente.Text + "%' OR [Correo Electronico] like '%" + txtBuscarCliente.Text + "%'";
                    dgvClientes.DataSource = bs;
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

        private void txtTelefono_Validating(object sender, CancelEventArgs e)
        {
            mskTelefonoValidar();
        }
        private bool mskTelefonoValidar()
        {
            bool valor = false;

            if (mskTelefono.MaskFull == false)
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

        private void mskCedula_Validating(object sender, CancelEventArgs e)
        {
            mskCedulaValidar();
        }
        private bool mskCedulaValidar()
        {
            bool valor = false;
            if (mskCedula.MaskFull == false)
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

            if (string.IsNullOrEmpty(txtNacionalidad.Text) || string.IsNullOrWhiteSpace(txtNacionalidad.Text))
            {
                ok = false;
                errorProvider1.SetError(txtNacionalidad, "Escriba la Nacionalidad");
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
        private void QuitarErrorProviderCliente()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(txtCorreoElectronico, "");
            errorProvider1.SetError(cmbSexo, "");
            errorProvider1.SetError(mskCedula, "");
            errorProvider1.SetError(mskTelefono, "");
            errorProvider1.SetError(txtNacionalidad, "");
        }

        private void txtLimpiar_Click(object sender, EventArgs e)
        {
            try
            {

                csLimpiar l = new csLimpiar();
                l.BorrarCamposGBx(groupBox1);
            }
            catch (Exception) { }
        }
    }
}
