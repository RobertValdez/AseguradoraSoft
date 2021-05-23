using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPagosParciales : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,
            int wmsg, int wparam, int lparam);

        public bool blConfirmacion = false;

        public frmPagosParciales()
        {
            InitializeComponent();
        }

        private void MoverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmPagosParciales_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se realizará el pago parcial de la Póliza actual. " + Environment.NewLine
                + "Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                blConfirmacion = true;
                Close();
            }
        }
    }
}
