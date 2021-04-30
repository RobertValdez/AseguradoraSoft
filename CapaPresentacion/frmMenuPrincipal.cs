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

            sdfsdfToolStripMenuItem.ForeColor = Color.White;
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void solicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCompras.ForeColor = Color.White;

            frmSolicitud com = new frmSolicitud();
            com.MdiParent = this;
            com.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sdfsdfToolStripMenuItem.ForeColor = Color.White;

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
            U.MdiParent = this;
            U.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConfirmacionSolicitud v = new frmConfirmacionSolicitud();
            v.MdiParent = this;
            v.Show();
        }

        private void reclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCompras.ForeColor = Color.White;

            frmRegistroDeReclamos RdR = new frmRegistroDeReclamos();
            RdR.MdiParent = this;
            RdR.Show();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCompras.ForeColor = Color.White;

            frmDevoluciones dv = new frmDevoluciones();
            dv.MdiParent = this;
            dv.Show();
        }

        private void seguroParaEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sdfsdfToolStripMenuItem.ForeColor = Color.White;

            frmSeguroEmpresas sEmp = new frmSeguroEmpresas();
            sEmp.MdiParent = this;
            sEmp.Show();
        }

        private void siniestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCompras.ForeColor = Color.White;

            frmSiniestro S = new frmSiniestro();
            S.MdiParent = this;
            S.Show();
        }

        private void seguroDeVidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeguroVida frmVida = new frmSeguroVida();
            frmVida.MdiParent = this;
            frmVida.Show();
        }

        private void toolStripMenuItem1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sdfsdfToolStripMenuItem_ForeColorChanged(object sender, EventArgs e)
        {
            sdfsdfToolStripMenuItem.ForeColor = Color.Black;
        }

        private void verSiniestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.ForeColor = Color.White;

            frmVerSiniestros vs = new frmVerSiniestros();
            vs.MdiParent = this;
            vs.Show();
        }

        private void verReclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.ForeColor = Color.White;

            frmVerReclamos vr = new frmVerReclamos();
            vr.MdiParent = this;
            vr.Show();
        }

        private void verFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.ForeColor = Color.White;

            frmVerFacturas vf = new frmVerFacturas();
            vf.MdiParent = this;
            vf.Show();
        }

        private void verPolizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.ForeColor = Color.White;

            frmVerPolizas vp = new frmVerPolizas();
            vp.MdiParent = this;
            vp.Show();
        }

        private void polizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCompras.ForeColor = Color.White;

            frmPolizas p = new frmPolizas();
            p.MdiParent = this;
            p.Show();
        }

        private void verPólizasALaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.ForeColor = Color.White;

            frmVerPolizasDisponibles fd = new frmVerPolizasDisponibles();
            fd.MdiParent = this;
            fd.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.ForeColor = Color.White;

            rptFacturasDelMes ef = new rptFacturasDelMes();
            ef.MdiParent = this;
            ef.Show();
        }

        private void siniestrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.ForeColor = Color.White;

            rptPolizasMensuales eP = new rptPolizasMensuales();
            eP.MdiParent = this;
            eP.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sdfsdfToolStripMenuItem.ForeColor = Color.White;

            Cargos c = new Cargos();
            c.MdiParent = this;
            c.Show();
        }

        private void confirmaciónSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCompras.ForeColor = Color.White;

            frmConfirmacionSolicitud cs = new frmConfirmacionSolicitud();
            cs.MdiParent = this;
            cs.Show();
        }

        private void toolStripMenuItem2_DropDownOpening(object sender, EventArgs e)
        {
            toolStripMenuItem2.ForeColor = Color.Black;
        }

        private void toolStripMenuItem2_DropDownClosed(object sender, EventArgs e)
        {
            toolStripMenuItem2.ForeColor = Color.White;
            if (!facturasToolStripMenuItem.Visible)
            {
                toolStripMenuItem2.ForeColor = Color.Black;
            }
        }

        private void toolStripMenuItem2_MouseEnter(object sender, EventArgs e)
        {
            toolStripMenuItem2.ForeColor = Color.Black;
        }

        private void toolStripMenuItem2_MouseLeave(object sender, EventArgs e)
        {
            if (!toolStripMenuItem2.Pressed)
            {
                toolStripMenuItem2.ForeColor = Color.White;
            }
        }


        /// ---------
        private void btnCompras_DropDownOpening(object sender, EventArgs e)
        {
            btnCompras.ForeColor = Color.Black;
        }

        private void btnCompras_DropDownClosed(object sender, EventArgs e)
        {
            btnCompras.ForeColor = Color.White;
            if (!solicitudToolStripMenuItem.Visible)
            {
                btnCompras.ForeColor = Color.Black;
            }
        }

        private void btnCompras_MouseEnter(object sender, EventArgs e)
        {
            btnCompras.ForeColor = Color.Black;
        }

        private void btnCompras_MouseLeave(object sender, EventArgs e)
        {
            if (!btnCompras.Pressed)
            {
                btnCompras.ForeColor = Color.White;
            }
        }

        private void devolucionesToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            devolucionesToolStripMenuItem.ForeColor = Color.Black;
        }

        private void devolucionesToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            devolucionesToolStripMenuItem.ForeColor = Color.White;
        }

        private void solicitudToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            solicitudToolStripMenuItem.ForeColor = Color.Black;
        }

        private void solicitudToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            solicitudToolStripMenuItem.ForeColor = Color.White;
        }

        private void reclamosToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            reclamosToolStripMenuItem.ForeColor = Color.Black;
        }

        private void reclamosToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            reclamosToolStripMenuItem.ForeColor = Color.White;
        }

        private void siniestrosToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            siniestrosToolStripMenuItem.ForeColor = Color.Black;
        }

        private void siniestrosToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            siniestrosToolStripMenuItem.ForeColor = Color.White;
        }

        private void polizasToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            polizasToolStripMenuItem.ForeColor = Color.Black;
        }

        private void polizasToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            polizasToolStripMenuItem.ForeColor = Color.White;
        }

        private void confirmaciónSolicitudToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            confirmaciónSolicitudToolStripMenuItem.ForeColor = Color.Black;
        }

        private void confirmaciónSolicitudToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            confirmaciónSolicitudToolStripMenuItem.ForeColor = Color.White;
        }

        private void cargoToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            cargoToolStripMenuItem.ForeColor = Color.Black;
        }

        private void cargoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            cargoToolStripMenuItem.ForeColor = Color.White;
        }

        private void empleadosToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            empleadosToolStripMenuItem.ForeColor = Color.Black;
        }

        private void empleadosToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (!cargoToolStripMenuItem.Visible)
            {
                empleadosToolStripMenuItem.ForeColor = Color.White;
            }
        }

        private void clientesToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            clientesToolStripMenuItem1.ForeColor = Color.Black;
            empleadosToolStripMenuItem.ForeColor = Color.White;
        }

        private void clientesToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            clientesToolStripMenuItem1.ForeColor = Color.White;
        }

        private void seguroParaEmpresasToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            seguroParaEmpresasToolStripMenuItem.ForeColor = Color.Black;
        }

        private void seguroParaEmpresasToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            seguroParaEmpresasToolStripMenuItem.ForeColor = Color.White;
        }

        private void verSiniestrosToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            verSiniestrosToolStripMenuItem.ForeColor = Color.Black;
        }

        private void verSiniestrosToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            verSiniestrosToolStripMenuItem.ForeColor = Color.White;
        }

        private void verReclamosToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            verReclamosToolStripMenuItem.ForeColor = Color.Black;
        }

        private void verReclamosToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            verReclamosToolStripMenuItem.ForeColor = Color.White;
        }

        private void verFacturaToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            verFacturaToolStripMenuItem.ForeColor = Color.Black;
        }

        private void verFacturaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            verFacturaToolStripMenuItem.ForeColor = Color.White;
        }

        private void verPolizasToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            verPolizasToolStripMenuItem.ForeColor = Color.Black;
        }

        private void verPolizasToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            verPolizasToolStripMenuItem.ForeColor = Color.White;
        }

        private void verPólizasALaVentaToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            verPólizasALaVentaToolStripMenuItem.ForeColor = Color.Black;
        }

        private void verPólizasALaVentaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            verPólizasALaVentaToolStripMenuItem.ForeColor = Color.White;
        }

        private void facturasToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            facturasToolStripMenuItem.ForeColor = Color.Black;
        }

        private void facturasToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            facturasToolStripMenuItem.ForeColor = Color.White;
        }

        private void siniestrosToolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            siniestrosToolStripMenuItem1.ForeColor = Color.Black;
        }

        private void siniestrosToolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            siniestrosToolStripMenuItem1.ForeColor = Color.White;
        }

        private void sdfsdfToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            sdfsdfToolStripMenuItem.ForeColor = Color.Black;
            empleadosToolStripMenuItem_MouseLeave(null, null);
        }

        private void sdfsdfToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            sdfsdfToolStripMenuItem.ForeColor = Color.White;
            if (!empleadosToolStripMenuItem.Visible)
            {
                sdfsdfToolStripMenuItem.ForeColor = Color.Black;
            }
        }

        private void sdfsdfToolStripMenuItem_MouseEnter_1(object sender, EventArgs e)
        {
            sdfsdfToolStripMenuItem.ForeColor = Color.Black;
        }

        private void sdfsdfToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (!sdfsdfToolStripMenuItem.Pressed)
            {
                sdfsdfToolStripMenuItem.ForeColor = Color.White;
            }
        }




        private void toolStripMenuItem1_DropDownOpening(object sender, EventArgs e)
        {
            toolStripMenuItem1.ForeColor = Color.Black;
        }

        private void toolStripMenuItem1_DropDownClosed(object sender, EventArgs e)
        {
            toolStripMenuItem1.ForeColor = Color.White;
            if (!verSiniestrosToolStripMenuItem.Visible)
            {
                toolStripMenuItem1.ForeColor = Color.Black;
            }
        }

        private void toolStripMenuItem1_MouseEnter(object sender, EventArgs e)
        {
            toolStripMenuItem1.ForeColor = Color.Black;
        }

        private void toolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            if (!toolStripMenuItem1.Pressed)
            {
                toolStripMenuItem1.ForeColor = Color.White;
            }
        }

        private void ventasToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ventasToolStripMenuItem.ForeColor = Color.Black;
        }

        private void ventasToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ventasToolStripMenuItem.ForeColor = Color.White;
        }

        private void menuStrip1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void vehiculosDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManteniminetoVehiculo frmV = new frmManteniminetoVehiculo();
            frmV.MdiParent = this;
            frmV.Show();
        }
    }
}
