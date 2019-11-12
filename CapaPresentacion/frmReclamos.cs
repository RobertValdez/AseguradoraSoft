using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmRegistroDeReclamos : Form
    {
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
    }
}
