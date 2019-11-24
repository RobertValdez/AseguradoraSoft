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
using CapaNegocio.Siniestro;

namespace CapaPresentacion
{
    public partial class frmRegistroDeReclamos : Form
    {
        E_Clientes E_Clientes = new E_Clientes();
        B_Clientes B_Clientes = new B_Clientes();
        B_Siniestro B_Siniestro = new B_Siniestro();

        string[,] Prueba;

        public frmRegistroDeReclamos()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            lblRegistroReclamos.Text = "Buscar Cliente";
            pnlBuscarClientes.Visible = true;
        } 

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            lblRegistroReclamos.Text = "Registro de Reclamos";
            pnlBuscarClientes.Visible = false;
        }

        private void frmRegistroDeReclamos_Load(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void BuscarCliente()
        {
            dgvBuscarClientes.DataSource = B_Clientes.B_MostrarClientes();
            dgvSiniestros.DataSource = B_Siniestro.B_MostrarSiniestro();
            Prueba = B_Siniestro.B_CargarPolizasDeSeguros();
        }

        private void dgvBuscarClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var row = dgvBuscarClientes.CurrentRow;
            txtCedula.Text = row.Cells[0].Value.ToString();
            txtIdSiniestro.Text = row.Cells[1].Value.ToString();

            pnlBuscarClientes.Visible = false;
            lblRegistroReclamos.Text = "Registro de Reclamos";
        }
    }
}
