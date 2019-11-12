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
    public partial class frmSiniestro : Form
    {
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
    }
}
