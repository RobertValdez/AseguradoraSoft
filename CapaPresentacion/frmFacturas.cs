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
using PerlaDelSur_Entity.ResumenSolicitud;
using CapaNegocio.ResumenSolicitud;

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

        E_ResumenSolicitud E_ResumenSolicitud = new E_ResumenSolicitud();
        B_ResumenSolicitud B_ResumenSolicitud = new B_ResumenSolicitud();

        public int varIdEmpleado;

        public byte[] imgCopiaEstatutos = null;
        public byte[] imgCopiaActaAsignacionRNC = null;
        public byte[] imgCopiaCedulaPresidente_RepresAut = null;
        public string strTelefonoEntAut;

        public string CorreoElectronicoEntidadAutorizada;

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
            try
            {
                Solicitar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Solicitar()
        {
            E_ResumenSolicitud.IdCliente = Convert.ToInt32(txtId.Text);
            E_ResumenSolicitud.IdEmpleado = varIdEmpleado;
            E_ResumenSolicitud.Total = Convert.ToDecimal(txtTotalA_Pagar.Text);

            E_ResumenSolicitud.Fecha = DateTime.Now.Date;
            E_ResumenSolicitud.NombreEmpresa = txtEfectoA_Asegurar.Text;
            E_ResumenSolicitud.CopiaEstatutos = imgCopiaEstatutos;
            E_ResumenSolicitud.CopiaActaDeAsignacionRNC = imgCopiaActaAsignacionRNC;
            E_ResumenSolicitud.CopiaCedulaPres_RepreAutorizado = imgCopiaCedulaPresidente_RepresAut;
            E_ResumenSolicitud.TelefonoEntidadAutorizada = strTelefonoEntAut;

            E_ResumenSolicitud.CorreoElectronicoEntidadAutorizada = CorreoElectronicoEntidadAutorizada;

            E_ResumenSolicitud.FechaHora = DateTime.Now;
            E_ResumenSolicitud.Tipo = txtCategoria.Text;

            E_ResumenSolicitud.Imagen1 = imgImagen1;
            E_ResumenSolicitud.Imagen2 = imgImagen2;
            E_ResumenSolicitud.Imagen3 = imgImagen3;
            E_ResumenSolicitud.Imagen4 = imgImagen4;
            E_ResumenSolicitud.Imagen5 = imgImagen5;

            if (MessageBox.Show("Se creará una solicitud para el cliente actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ResumenSolicitud.B_CrearSolicitud(E_ResumenSolicitud) >= 3)
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
