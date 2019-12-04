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
    public partial class frmVerPolizasDisponibles : Form
    {
        B_Consultas B_Consultas = new B_Consultas();
        public frmVerPolizasDisponibles()
        {
            InitializeComponent();
        }

        private void frmVerPolizasDisponibles_Load(object sender, EventArgs e)
        {
            dgvVer.DataSource = B_Consultas.B_ConsultaPolizasDisponibles();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            Buscar();
        }
        private void Buscar()
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dgvVer.DataSource;
                bs.Filter = "[Nombre del Seguro] like '%" +
                    txtBuscar.Text + "%' OR Categoria like '%" +
                    txtBuscar.Text + "%' OR [Area] like '%" + txtBuscar.Text +
                    "%' OR Convert(Precio, 'System.String') like '%" + txtBuscar.Text + "%'" +
                    "OR [Area] like '%" + txtBuscar.Text +
                    "%'";
                dgvVer.DataSource = bs;

            }
            catch (Exception) {  }
        }
    }
}
