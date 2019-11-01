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
                if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || mskCedula.Text == "" || txtTelefono.Text == "" || txtCorreoElectronico.Text == "" || txtNacionalidad.Text == "" || cmbSexo.Text == "")
                {
                    MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    E_Clientes.Nombre = txtNombre.Text;
                    E_Clientes.Apellido = txtApellido.Text;
                    E_Clientes.Cedula = mskCedula.Text;
                    E_Clientes.Direccion = txtDireccion.Text;
                    E_Clientes.Telefono = txtTelefono.Text;
                    E_Clientes.Nacionalidad = txtNacionalidad.Text;
                    E_Clientes.CorreoElectronico = txtCorreoElectronico.Text;
                    E_Clientes.Sexo = cmbSexo.Text;
                    E_Clientes.RNC = txtRNC.Text;
                    E_Clientes.FechaHora = DateTime.Now;

                    if (B_Clientes.B_InsertarCliente(E_Clientes) == 1)
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
                if (txtNombreMod.Text == "" || txtApellidoMod.Text == "" || txtDireccionMod.Text == "" || mskCedulaMod.Text == "" || txtTelefonoMod.Text == "" || txtCorreoElectronicoMod.Text == "" || txtNacionalidadMod.Text == "" || cmbSexoMod.Text == "")
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
                    MessageBox.Show("No se pudo eliminar el Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
