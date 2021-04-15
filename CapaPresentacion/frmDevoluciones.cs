using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio.Siniestro;
using CapaNegocio.Clientes;
using PerlaDelSur_Entity.Devoluciones;
using CapaNegocio.Devoluciones;
using PerlaDelSur_Entity.Siniestro;
using CapaNegocio.SeguroVida;

namespace CapaPresentacion
{
    public partial class frmDevoluciones : Form
    {
        E_Devoluciones E_Devoluciones = new E_Devoluciones();

        B_SeguroVida E_PolizaSeguro = new B_SeguroVida();

        B_Devoluciones B_Devoluciones = new B_Devoluciones();
        B_Clientes B_Clientes = new B_Clientes();
        B_Siniestro B_siniestro = new B_Siniestro();
        E_Siniestro E_Siniestro = new E_Siniestro();


        int idCliente;

        public frmDevoluciones()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            lblDevoluciones.Text = "Buscar Cliente";
            pnlBuscarClientes.Visible = true;
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            lblDevoluciones.Text = "Devoluciones";
            pnlBuscarClientes.Visible = false;
        }

        private void frmDevoluciones_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            cargarPolizaDeSeguro();
        }

        private void cargarPolizaDeSeguro()
        {
            dtPolizasSeguro = E_PolizaSeguro.B_MostrarSegurosDePolizas();
        }

        private void CargarPolizas()
        {
            E_Siniestro.IdCliente = idCliente;
            dgvDatos.DataSource = B_siniestro.B_CargarPolizasDeSegurosDev(E_Siniestro);

            E_Devoluciones.IdCliente = idCliente;
            dgvReclamacion.DataSource = B_Devoluciones.B_ReclamacionesIdCliente(E_Devoluciones);
        }

        private void MostrarClientes()
        {
            dgvBuscarClientes.DataSource = B_Clientes.B_MostrarClientes();
        }

        private void dgvBuscarClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvBuscarClientes.CurrentRow;

            idCliente = Convert.ToInt32(row.Cells[0].Value.ToString());
            txtCedula.Text = row.Cells[4].Value.ToString();

            CargarPolizas();

            pnlBuscarClientes.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCedula.Text)
                || string.IsNullOrWhiteSpace(txtCedula.Text)
                || string.IsNullOrEmpty(txtIdReclamaciones.Text)
                || string.IsNullOrWhiteSpace(txtIdReclamaciones.Text)
                || string.IsNullOrEmpty(txtidPoliza.Text)
                || string.IsNullOrWhiteSpace(txtidPoliza.Text))
                {
                    MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Está a punto de realizar una devolución al cliente actual."
                        +Environment.NewLine+"Desea Continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        E_Devoluciones.IdCliente = idCliente;
                        E_Devoluciones.IdReclamaciones = Convert.ToInt32(txtIdReclamaciones.Text.Trim());
                        E_Devoluciones.IdPoliza = Convert.ToInt32(txtidPoliza.Text.Trim());
                        E_Devoluciones.A_Devolver = Convert.ToDecimal(txtADevolver.Text);
                        E_Devoluciones.Motivo = txtMotivo.Text;
                        E_Devoluciones.FechaHora = DateTime.Now;

                        if (B_Devoluciones.B_Devoluviones(E_Devoluciones) >= 1)
                        {
                            MessageBox.Show("Se ha realizado la devolución correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se han insertado los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        List<string> list = new List<string>();

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        DataTable dtPolizasSeguro = new DataTable();

        private void txtADevolver_TextChanged(object sender, EventArgs e)
        {
            txtADevolver.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };
        }

        private void dgvBuscarClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvDatos.CurrentRow;

            txtidPoliza.Text = row.Cells[0].Value.ToString();
        }

        private void dgvReclamacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvReclamacion.CurrentRow;

            txtIdReclamaciones.Text = row.Cells[0].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            dgvReclamacion.DataSource = null;

            foreach (var txt in Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
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
                    //MessageBox.Show(bs.SupportsFiltering + "");

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
