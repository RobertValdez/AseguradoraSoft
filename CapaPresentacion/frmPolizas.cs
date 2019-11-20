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
using CapaNegocio.Empleados;
using CapaNegocio.SeguroVida;
using PerlaDelSur_Entity.SeguroVida;

namespace CapaPresentacion
{
    public partial class frmPolizas : Form
    {
       // private E_SeguroVida E_SegVida = new E_SeguroVida();
        private B_VerPoliza B_VerPolizas = new B_VerPoliza();
        //   private B_SeguroVida B_SeguroVida = new B_SeguroVida();

        int idEmpleado = 0;
        DataTable dtMostrarPolizas = new DataTable();
        public frmPolizas()
        {
            InitializeComponent();
        }

        private void btnPagoP_Click(object sender, EventArgs e)
        {
            tabGestionarPolizas.Visible = false;
            pnlPagoPolizas.Visible = true;///

            btnPagoP.BackColor = Color.LightPink;
            btnGestionarP.BackColor = Color.White;
        }

        private void btnGestionarP_Click(object sender, EventArgs e)
        {
            tabGestionarPolizas.Visible = true;
            pnlPagoPolizas.Visible = true; ///

            btnGestionarP.BackColor = Color.LightPink;
            btnPagoP.BackColor = Color.White;
        }

        private void cmbTPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTPago.Text == "Al contado")
            {
                lblParcial.Visible = false;
                txtParcial_Renovar.Visible = false;
            }
            else
            {
                lblParcial.Visible = true;
                txtParcial_Renovar.Visible = true;
            }
            
        }

        private void frmPolizas_Load(object sender, EventArgs e)
        {
            MostrarPolizas();
            dgvMostrarPolizas_Pagar.DataSource = dtMostrarPolizas;
            dgvMostrarPoliza_Cancelar.DataSource = dtMostrarPolizas;
        }
        private void MostrarPolizas()
        {
            dtMostrarPolizas = B_VerPolizas.B_vd_VerPoliza();
        }

        private void dgvMostrarPoliza_Cancelar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvMostrarPoliza_Cancelar.CurrentRow;
                dgvMostrarPoliza_Cancelar.Rows[row.Index].Selected = true;

                txtCliente_Renovar.Text = row.Cells[0].Value.ToString();
                txtNumPoliza_Renovar.Text = row.Cells[1].Value.ToString();

                txtEstado_Renovar.Text = row.Cells[3].Value.ToString();
                txtPrecio_Renovar.Text = row.Cells[0].Value.ToString();
                txtParcial_Renovar.Text = row.Cells[0].Value.ToString();
                txtVencimiento_Renovar.Text = row.Cells[0].Value.ToString();
                txtNota_Cancelar.Text = row.Cells[0].Value.ToString();
            }
            catch (Exception) { }
        }

        private void dgvMostrarPolizas_Pagar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvMostrarPolizas_Pagar.CurrentRow;
                dgvMostrarPolizas_Pagar.Rows[row.Index].Selected = true;
            }
            catch (Exception) { }
        }

        public void CargarEmpleado()
        {
           idEmpleado = 1;

        }
    }
}
