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
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            pnlBuscarCliente.Visible = false;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            InsertarCliente();
        }
        public void InsertarCliente()
        {
            try
            {
                if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || mskCedula.Text == "" || mskTelefono.Text == "" || txtCorreoElectronico.Text == "" || txtNacionalidad.Text == "" || cmbSexo.Text == "")
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
    }
}
