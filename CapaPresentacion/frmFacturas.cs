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
        static string Id, nombreApellido, cedula, seguroA_Adquirir, efectoA_Asegurar, Categoria;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,
            int wmsg, int wparam, int lparam);

        public frmFacturas()
        {
            InitializeComponent();

            RecibirDatos();
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

        public void RecibirDatos()
        {
            txtId.Text = Id;
            txtCliente.Text = nombreApellido;
            txtCedula.Text = cedula;
            txtSeguroA_Adquirir.Text = seguroA_Adquirir;
            txtEfectoA_Asegurar.Text = efectoA_Asegurar;
            txtCategoria.Text = Categoria;
        }

        public frmFacturas(string id, string NombreApellido,
            string Cedula, string SeguroA_Adquirir, string efectoAsegurar, string categoria)
        {
            Id = id;
            nombreApellido = NombreApellido;
            cedula = Cedula;
            seguroA_Adquirir = SeguroA_Adquirir;
            efectoA_Asegurar = efectoAsegurar;
            Categoria = categoria;
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
    }
}
