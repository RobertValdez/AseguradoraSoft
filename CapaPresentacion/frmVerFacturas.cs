using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio.Consultas;

namespace CapaPresentacion
{
    public partial class frmVerFacturas : Form
    {
        B_Consultas B_Consultas = new B_Consultas();
        public frmVerFacturas()
        {
            InitializeComponent();
        }

        private void frmVerFacturasSolicitud_Load(object sender, EventArgs e)
        {
            dgvVer.DataSource = B_Consultas.B_ConsultaSol();
        }
    }
}
