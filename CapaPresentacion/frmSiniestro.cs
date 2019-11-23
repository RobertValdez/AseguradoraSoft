using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio.Clientes;
using CapaNegocio.Siniestro;
using PerlaDelSur_Entity.Siniestro;

namespace CapaPresentacion
{
    public partial class frmSiniestro : Form
    {
        B_Clientes B_Clientes = new B_Clientes();
        B_Siniestro B_Siniestro = new B_Siniestro();
        E_Siniestro E_Siniestro = new E_Siniestro();

        int idEmpleado = 1;
        int idCliente = 0;

        csLimpiar cLimpiar = new csLimpiar();

        public frmSiniestro()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            lblRegistroSiniestros.Text = "Buscar Cliente";
            pnlBuscarCliente.Visible = true;
        }

        private void lblCerrar_Click_1(object sender, EventArgs e)
        {
            lblRegistroSiniestros.Text = "Registro de Siniestros";
            pnlBuscarCliente.Visible = false;
        }

        private void frmSiniestro_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }
        private void MostrarClientes()
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

        private void dgvBuscarClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvBuscarClientes.CurrentRow;

            idCliente = Convert.ToInt32(row.Cells[0].Value.ToString());

            txtNombre.Text = row.Cells[1].Value.ToString();
            txtApellido.Text = row.Cells[2].Value.ToString();
            txtCedula.Text = row.Cells[4].Value.ToString();
            txtTelefono.Text = row.Cells[6].Value.ToString();

            pnlBuscarCliente.Visible = false;
            QuitarErrorProvider();
            lblRegistroSiniestros.Text = "Registro de Siniestros";
        }

        private void CargarPolizasActivas()
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            E_Siniestro.IdCliente = idCliente;
            E_Siniestro.IdEmpleado = idEmpleado;
            E_Siniestro.Siniestro = txtSiniestro.Text;
            E_Siniestro.FechaHora = DateTime.Now;

            if (ValidarCampos())
            {
                QuitarErrorProvider();
                if (MessageBox.Show("Desea guardar los datos del Siniestro actual?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (B_Siniestro.B_GuardarSiniestro(E_Siniestro) == 2)
                    {
                        MessageBox.Show("El siniestro se ha guardado satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Rellene los datos faltantes para continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool ValidarCampos()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                ok = false;
                errorProvider1.SetError(btnBuscarCliente, "Busque y seleccione el Cliente");
            }

            if (string.IsNullOrEmpty(txtSiniestro.Text) || string.IsNullOrWhiteSpace(txtSiniestro.Text))
            {
                ok = false;
                errorProvider1.SetError(txtSiniestro, "Detalle los datos del Siniestro");
            }
            return ok;
        }

        private void QuitarErrorProvider()
        {
            errorProvider1.SetError(btnBuscarCliente, "");
            errorProvider1.SetError(txtSiniestro, "");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mLimpiar();
        }

        private void mLimpiar()
        {
            try
            {
                cLimpiar.BorrarCamposGBx(gbxSiniestro);
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }
    }
}
