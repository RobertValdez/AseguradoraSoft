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
    public partial class frmVerReclamos : Form
    {
        B_Consultas B_Consultas = new B_Consultas();

        public frmVerReclamos()
        {
            InitializeComponent();
        }

        private void frmVerReclamos_Load(object sender, EventArgs e)
        {
            dgvVer.DataSource = B_Consultas.B_ConsultaRecla();  
        }
    }
}
