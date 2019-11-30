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
    public partial class frmVerSiniestros : Form
    {
        private B_Consultas b_Consultas = new B_Consultas();
        public frmVerSiniestros()
        {
            InitializeComponent();
        }

        private void frmVerSiniestros_Load(object sender, EventArgs e)
        {
            dgvVer.DataSource = b_Consultas.B_ConsultaSini();
        }
    }
}
