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

namespace CapaPresentacion
{
    public partial class frmFacturas : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,
            int wmsg, int wparam, int lparam);

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

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {

        }

        private void btnDescontar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescontar.Text) || string.IsNullOrWhiteSpace(txtDescontar.Text))
            {
            //    MessageBox.Show("ma");
            }
        }

        private void txtDescontar_Validating(object sender, CancelEventArgs e)
        {
            MessageBox.Show("ma");
        }
    }
}
