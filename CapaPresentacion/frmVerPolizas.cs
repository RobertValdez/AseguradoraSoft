using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.VerPoliza;

namespace CapaPresentacion
{
    public partial class frmVerPolizas : Form
    {
        private B_VerPoliza verPoliza = new B_VerPoliza();
        public frmVerPolizas()
        {
            InitializeComponent();
        }

        private void frmVerPolizas_Load(object sender, EventArgs e)
        {
            dgvVerPolizas.DataSource = verPoliza.B_vd_VerPoliza();
        }
    }
}
