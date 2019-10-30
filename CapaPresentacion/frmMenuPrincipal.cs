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
    public partial class frmMenuPrincipal : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,
            int wmsg, int wparam, int lparam);
        public frmMenuPrincipal()
        {
            InitializeComponent();
            FechaHora.Start();
        }

        private void MenuPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpl = new frmEmpleados();
            frmEmpl.MdiParent = this;
            frmEmpl.Show();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void solicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSolicitud com = new frmSolicitud();
            com.MdiParent = this;
            com.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCliente Clie = new frmCliente();
            Clie.MdiParent = this;
            Clie.Show();
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString(); 
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios U = new frmUsuarios();
            U.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVenta v = new frmVenta();
            v.Show();
        }

        private void reclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroDeReclamos RdR = new frmRegistroDeReclamos();
            RdR.Show();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevoluciones dv = new frmDevoluciones();
            dv.Show();
        }

        private void polizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPolizas p = new frmPolizas();
            p.Show();
        }

        private void seguroParaEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeguroEmpresas sEmp = new frmSeguroEmpresas();
            sEmp.Show();
        }

        private void siniestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSiniestro S = new frmSiniestro();
            S.Show();
        }
    }
}
