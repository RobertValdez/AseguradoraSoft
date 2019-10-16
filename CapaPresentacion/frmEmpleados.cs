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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlNuevo.Visible = true;
            pnlModificar.Visible = false;
            Size = new Size(640, 578);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            pnlNuevo.Visible = false;
            pnlModificar.Visible = true;
            this.Size = new Size(1234, 732);
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            Size = new Size(640, 578);
        }
    }
}
