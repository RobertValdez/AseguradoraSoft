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
        int idSolicitud;
        int idPoliza;

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
                if ((string.IsNullOrEmpty(txtCedula.Text)
                || string.IsNullOrWhiteSpace(txtCedula.Text)))
                {
                    MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    E_Devoluciones.IdCliente = idCliente;
                    //E_Devoluciones.IdSolicitud = idSolicitud;
                    E_Devoluciones.IdPoliza = idPoliza;
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
            catch (Exception) { }
        }

        List<string> list = new List<string>();

        private void Cargar()
        {
            foreach (DataRow dr in dtPolizasSeguro.Rows)
            {
                list.Add(dr[2].ToString());
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvDatos.CurrentRow;

            txtidPoliza.Text = row.Cells[0].Value.ToString();
        }

        DataTable dtPolizasSeguro = new DataTable();

        private void Filtrar()
        {
            DataView dv = new DataView(dtPolizasSeguro);

            dv.RowFilter = "[Cargo] = '" + cmbPolizasC + "'";

            int idCargos = (int)dv[0]["id"];

        }

        private void cmbPolizasC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
