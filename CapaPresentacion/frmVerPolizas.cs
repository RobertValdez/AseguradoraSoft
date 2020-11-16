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
        DataTable dt_vdPoliza = new DataTable();
        DataTable dt_vhPoliza = new DataTable();
        DataTable dt_inPoliza = new DataTable();
        DataTable dt_emPoliza = new DataTable();

        private B_VerPoliza verPoliza = new B_VerPoliza();
        public frmVerPolizas()
        {
            InitializeComponent();
        }

        private void frmVerPolizas_Load(object sender, EventArgs e)
        {
            CargarPolizas();
        }

        private void CargarPolizas()
        {
           // dt_vdPoliza = verPoliza.B_vd_VerPoliza();
            dt_vhPoliza = verPoliza.B_vh_MostrarPolizas();
            dgvVerPolizas.DataSource = dt_vhPoliza;

            //dt_inPoliza = verPoliza.B_in_MostrarPolizas();
            //dt_emPoliza = verPoliza.B_em_MostrarPolizas();
        }

        private void cmbPolizas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (cmbPolizas.Text)
            //{
            //    case "Vida":
            //        dgvVerPolizas.DataSource = dt_vdPoliza;
            //        break;
            //    case "Muebles e Inmuebles":
            //        dgvVerPolizas.DataSource = dt_inPoliza;
            //        break;
            //    case "Negocios e Empresas":
            //        dgvVerPolizas.DataSource = dt_emPoliza;
            //        break;
            //    case "Vehiculo":
            //        dgvVerPolizas.DataSource = dt_vhPoliza;
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
