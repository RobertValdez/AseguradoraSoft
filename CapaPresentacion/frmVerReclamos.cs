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
                bs.Filter = "Nombre like '%" +
                    txtBuscar.Text + "%' OR Apellido like '%" + txtBuscar.Text +
                    "%' OR [Nombre del Seguro] like '%" + txtBuscar.Text + "%' OR Cedula like '%" + txtBuscar.Text +
                    "%'";
                dgvVer.DataSource = bs;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
