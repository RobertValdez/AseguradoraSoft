using CapaNegocio.B_ResumenVentaPoliza;
using PerlaDelSur_Entity.ResumenVentaPoliza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmResumenVentaPoliza : Form
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
        B_ResumenVentaPoliza B_ResumenVentaPoliza = new B_ResumenVentaPoliza();

        public int varIdEmpleado;
        public string strInstitutoDondeLabora = "";
        public string strAntecedentesPersonales = "";
        public frmResumenVentaPoliza()
        {
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmResumenVentaPoliza_Load(object sender, EventArgs e)
        {
            cmbTipo_Pago.SelectedIndex = 0;
        }

        private void frmResumenVentaPoliza_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmbTipo_Pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo_Pago.Text == "Parcial")
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

        private void btnPagarCrearPoliza_Click(object sender, EventArgs e)
        {
            try
            {
                Pagar_y_CrearPoliza();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void Pagar_y_CrearPoliza()
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

            if (MessageBox.Show("¿Está seguro que desea realizar el pago y crear una póliza de seguro para el cliente actual?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ResumenVentaPoliza.CrearPoliza(E_ResumenVentaPoliza) == 3)
                {
                    MessageBox.Show("Poliza creada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error inesperado.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
            }
        }
        public DateTime FechaA_Vencer(DateTime FechaActual)
        {

            string strFechaActual = Convert.ToString(FechaActual);
            DateTime fecha = Convert.ToDateTime(strFechaActual, new CultureInfo("es-ES"));

            return fecha = fecha.AddDays(180);

        }
    }
}
