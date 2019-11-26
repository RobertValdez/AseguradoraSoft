using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using PerlaDelSur_Entity.ResumenVentaPoliza;
using CapaNegocio.B_ResumenVentaPoliza;

namespace CapaPresentacion
{
    public partial class frmFacturas : Form
    {
        string DatosYContratoDePolizaDeSeguro = "lkuaewhfcneufgslkfgesl gsdflkgsf hgdfhgdf" +
               "hg fgt" +
               "hj dt" +
               "hj d" +
               " hj" +
               "hj d" +
               " hjdfhg df" +
               "hg df" +
               "hg df" +
               "hg dfhg" +
               "dfh g" +
               "df" +
               "hg dfhgdf" +
               "hg dfhg df " +                     /// Simulación de la Descripcion
            "hdfhg " +
               "dfs fgsfd gsdf g+sdf gs" +
               "df g" +
               "sd gfsdf" +
               "g" +
               "sdf g";

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,
            int wmsg, int wparam, int lparam);

        E_ResumenVentaPoliza E_ResumenVentaPoliza = new E_ResumenVentaPoliza();
        B_ResVentaPoliza B_ResumenVentaPoliza = new B_ResumenVentaPoliza();

        public int varIdEmpleado;

        public string strCopiaEstatutos;
        public string strCopiaActaAsignacionRNC;
        public string strCopiaCedulaPresidente_RepresAut;
        public string strTelefonoEntAut;


        public byte[] imgImagen1 = null;
        public byte[] imgImagen2 = null;
        public byte[] imgImagen3 = null;
        public byte[] imgImagen4 = null;
        public byte[] imgImagen5 = null;

        public frmFacturas()
        {
            InitializeComponent();
        }

        private void pnlResumenSolicitud_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmFacturas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            cmbTipoPago.SelectedIndex = 0;
        }

        private void btnDescontar_Click(object sender, EventArgs e)
        {
        }

        private void txtDescontar_Validating(object sender, CancelEventArgs e)
        {

        }

        private void cmbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPago.Text == "Parcial")
            {
                lblParcial.Visible = true;
                mskParcial.Visible = true;
            }
            else
            {
                lblParcial.Visible = false;
                mskParcial.Visible = false;
            }
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {

        }

        private void Solicitar()
        {
            E_ResumenVentaPoliza.IdCliente = Convert.ToInt32(txtId.Text);
            E_ResumenVentaPoliza.IdEmpleado = varIdEmpleado;
            E_ResumenVentaPoliza.Total = Convert.ToDecimal(txtTotal_A_Pagar.Text);

            E_ResumenVentaPoliza.InstitutoDondeLabora = strInstitutoDondeLabora;
            E_ResumenVentaPoliza.FechaHora = DateTime.Now;
            E_ResumenVentaPoliza.AntecedentesPersonales = strAntecedentesPersonales;
            E_ResumenVentaPoliza.Fecha = DateTime.Now.Date;
            E_ResumenVentaPoliza.Tipo = txtCategoria.Text.Trim();
            E_ResumenVentaPoliza.Poliza = DatosYContratoDePolizaDeSeguro;
            E_ResumenVentaPoliza.EstadoPoliza = 1;

            E_ResumenVentaPoliza.Vencimiento = DateTime.Parse("13-05-2020");

            if (MessageBox.Show("Se creará una solicitud para el cliente actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BackColor?  CrearPoliza(E_ResumenVentaPoliza) == 3)
                {
                    MessageBox.Show("Poliza creada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error inesperado.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
