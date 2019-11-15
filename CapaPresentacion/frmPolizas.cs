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
    public partial class frmPolizas : Form
    {
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
                txtParcial.Visible = false;
            }
            else
            {
                lblParcial.Visible = true;
                txtParcial.Visible = true;
            }
            
        }
    }
}
