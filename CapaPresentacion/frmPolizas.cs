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
using PerlaDelSur_Entity.Poliza;

namespace CapaPresentacion
{
    public partial class frmPolizas : Form
    {
        clSoloNumero cs = new clSoloNumero();

        private E_Poliza E_Poliza = new E_Poliza();
        private B_VerPoliza B_VerPolizas = new B_VerPoliza();

        int idEmpleado = 0;
        DataTable dtMostrarPolizas = new DataTable();

        string Poliza = "";

        bool blParcial = false;
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
                txtPagoParcial_Renovar.Visible = false;
            }
            else
            {
                lblParcial.Visible = true;
                txtPagoParcial_Renovar.Visible = true;
                blParcial = true;
            }
            
        }

        private void frmPolizas_Load(object sender, EventArgs e)
        {
            MostrarPolizas();
            dgvMostrarPolizas_Renovar.DataSource = dtMostrarPolizas;
            dgvMostrarPoliza_Cancelar.DataSource = dtMostrarPolizas;
        }
        private void MostrarPolizas()
        {
            dtMostrarPolizas = B_VerPolizas.B_vd_VerPoliza();
        }

        private void dgvMostrarPoliza_Cancelar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMostrarPolizas_Pagar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvMostrarPolizas_Renovar.CurrentRow;
                dgvMostrarPolizas_Renovar.Rows[row.Index].Selected = true;

                txtCedulaCliente_Renovar.Text = row.Cells[11].Value.ToString();
                txtNumPoliza_Renovar.Text = row.Cells[1].Value.ToString();

                txtEstado_Renovar.Text = row.Cells[6].Value.ToString();
                txtPrecio_Renovar.Text = row.Cells[5].Value.ToString();
                txtTotalAPagar_Renovar.Text = row.Cells[5].Value.ToString();

                string a = row.Cells[8].Value.ToString();

                txtVencimiento_Renovar.Text = a.Remove(11, 8);
                
            }
            catch (Exception) { }
        }

        public void CargarEmpleado()
        {
           idEmpleado = 1;

        }

        private void btnPagar_Renovar_Click(object sender, EventArgs e)
        {
            RenovarPoliza();
        }
        public void RenovarPoliza()
        {
            try
            {
                if ((string.IsNullOrEmpty(txtCedulaCliente_Renovar.Text) || string.IsNullOrWhiteSpace(txtCedulaCliente_Renovar.Text))
                    || ((string.IsNullOrEmpty(txtNumPoliza_Renovar.Text) || string.IsNullOrWhiteSpace(txtNumPoliza_Renovar.Text)))
                    || (string.IsNullOrEmpty(cmbTPago.Text) || string.IsNullOrWhiteSpace(cmbTPago.Text)) || (blParcial == true))
                {
                    MessageBox.Show("Seleccione una Poliza de Seguro para preceder a su pago y renovación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ValidarCamposPagar();
                }
                else
                {
                    E_Poliza.IdPoliza = Convert.ToInt32(txtNumPoliza_Renovar.Text);
                    E_Poliza.IdCliente = Convert.ToInt32(txtCedulaCliente_Renovar);
                    E_Poliza.IdEmpleado = idEmpleado;
                    E_Poliza.Poliza = strPoliza();
                    E_Poliza.Precio = Convert.ToDecimal(txtPrecio_Renovar.Text);
                    E_Poliza.TPago = Convert.ToDecimal(txtTotalAPagar_Renovar.Text);



                    E_Poliza.Parcial = Parcial(txtPagoParcial_Renovar.Text);
                    E_Poliza.FechaHora = DateTime.Now;
                    E_Poliza.Vencimiento = DateTime.Now.Date;

                    MessageBox.Show("Todo Correcto");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public string strPoliza()
        {
         return Poliza = "ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg" +
            "dghdr;oghkdr'tlkhe;lhtrd;lhter';tlkhret;lkher;hk;erhtdr'lkhdf;lh,gdl,hdf;'h;lgdf" + txtCedulaCliente_Renovar.Text +
            "ffffffffffffffffffffgsfhgsrlkyjreskwl;hjrs;lkhjdflhjd;flhjfd;lkhgdfkhgdfkhgdfg" + txtNumPoliza_Renovar.Text+
            "dghdr;oghkdr'tlkhe;lhtrd;lhter';tlkhret;lkher;hk;erhtdr'lkhdf;lh,gdl,hdf;'h;lgdf" + txtTotalAPagar_Renovar.Text +
            "aslkdfj;slarjgs;lgkfdhj;lfdkhgjfdl;khfdhj;lfdhj;ldfkhjl;kdfhj;lkdfhkdfhkdfhglkdfjh" + 
            "sldkfjgsdhj;ldkfjgl;fdkhj;lfj;lfdhj;lfdhj;lfdhj;lkfdhj;lfdhj;lkfdhj;lfdhjl;dkfjh";
    }
        public decimal Parcial(string parcial)
        {
            decimal value = 0.00m;
            if (string.IsNullOrEmpty(parcial) || string.IsNullOrWhiteSpace(parcial))
            {
                return 0.00m;
            }
            else
            {
                value = Convert.ToDecimal(parcial);
            }
            return value;
        }

        private bool ValidarCamposPagar()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtNumPoliza_Renovar.Text) || string.IsNullOrWhiteSpace(txtNumPoliza_Renovar.Text))
            {
                ok = false;
                errorProvider1.SetError(dgvMostrarPolizas_Renovar, "Seleccione una Póliza");
            }

            if (string.IsNullOrEmpty(cmbTPago.Text) || string.IsNullOrWhiteSpace(cmbTPago.Text))
            {
                ok = false;
                errorProvider1.SetError(cmbTPago, "Indique la forma de pago");
            }
            if (blParcial == true)
            {
                ok = false;
                errorProvider1.SetError(txtPagoParcial_Renovar, "Escriba valor a abonar");
            }

            return ok;
        }
        private void QuitarErrorProviderCliente()
        {
            errorProvider1.SetError(dgvMostrarPolizas_Renovar, "");
            errorProvider1.SetError(cmbTPago, "");
            errorProvider1.SetError(txtPagoParcial_Renovar, "");
        }



        private void txtParcial_Renovar_TextChanged(object sender, EventArgs e)
        {


            txtPagoParcial_Renovar.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c)) || (c == '.')).ToArray());
            };





            if (txtPagoParcial_Renovar.Text == "")
            {
                blParcial = true;
            }
            else
            {
                blParcial = false;
                errorProvider1.SetError(txtPagoParcial_Renovar, "");
            }
        }

        private void txtParcial_Renovar_KeyPress(object sender, KeyPressEventArgs e)
        {
           //cs.SoloNumeros(e);
        }
    }
}
