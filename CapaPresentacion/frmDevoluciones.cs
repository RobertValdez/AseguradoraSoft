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

namespace CapaPresentacion
{
    public partial class frmDevoluciones : Form
    {
        B_Clientes B_Clientes = new B_Clientes();

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
        }

        private void MostrarClientes()
        {
            dgvBuscarClientes.DataSource = B_Clientes.B_MostrarClientes();
        }
    }
}
