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
    public partial class frmDevoluciones : Form
    {
        public frmDevoluciones()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            pnlBuscarClientes.Visible = true;
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            pnlBuscarClientes.Visible = false;
        }
    }
}
