using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio.ConfirmacionSolicitud;

namespace CapaPresentacion
{
    public partial class frmConfirmacionSolicitud : Form
    {
        B_ConfirmacionSolicitud B_ConfirmacionSolicitud = new B_ConfirmacionSolicitud();

        public frmConfirmacionSolicitud()
        {
            InitializeComponent();
        }

        private void frmConfirmacionSolicitud_Load(object sender, EventArgs e)
        {
            MostrarDetalleVoluntario();
        }

        private void MostrarDetalleVoluntario()
        {
           dgvMostrarSolicitudes.DataSource = B_ConfirmacionSolicitud.B_MostrarSeguroVoluntario();
        }
    }
}
