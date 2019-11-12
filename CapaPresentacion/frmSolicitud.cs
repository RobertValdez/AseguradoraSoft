﻿using System;
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
    public partial class frmSolicitud : Form
    {
        public frmSolicitud()
        {
            InitializeComponent();
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            pnlVehiculo.Visible = true;
        }

        private void btnSeguroVoluntario_Click(object sender, EventArgs e)
        {

        }

        private void lblCerrarVeh_Click(object sender, EventArgs e)
        {
            pnlVehiculo.Visible = false;
        }

        private void lblCerrarSV_Click(object sender, EventArgs e)
        {
            pnlVEHSeguroVoluntario.Visible = false;
        }

        private void btnVida_Click(object sender, EventArgs e)
        {

        }

        private void btnDependientes_Click(object sender, EventArgs e)
        {

        }

        private void lblCerrarSDepend_Click(object sender, EventArgs e)
        {

        }

        private void lblCerrar_pnlVida_Click(object sender, EventArgs e)
        {

        }

        private void btnSeguroSalud_Click(object sender, EventArgs e)
        {

        }

        private void lblCerrar_pnlVidaSalud_Click(object sender, EventArgs e)
        {

        }

        private void lblCerrar_pnlRiesgoLab_Click(object sender, EventArgs e)
        {

        }

        private void btnRiesgosLaborales_Click(object sender, EventArgs e)
        {
          
        }

        private void lblCerrarRiesgoMuerte_Click(object sender, EventArgs e)
        {

        }

        private void btnSeguroVoluntario_Click_1(object sender, EventArgs e)
        {
            pnlVehiculo.Visible = false;
            pnlVEHSeguroVoluntario.Visible = true;
        }

        private void btnSeguroObligatorio_Click(object sender, EventArgs e)
        {
            pnlVehiculo.Visible = false;
            pnlVEHSeguroObligatorio.Visible = true; //////////////
        }

        private void btnSeguroTodoRiesgo_Click(object sender, EventArgs e)
        {
            pnlVehiculo.Visible = false;
            pnlVEHSeguroTodoRiesgo.Visible = true;  /////////////
        }

        private void lblCerrarTodoRiesgo_Click(object sender, EventArgs e)
        {
            pnlVEHSeguroTodoRiesgo.Visible = false;
        }

        private void lblCerrarSeguroOb_Click(object sender, EventArgs e)
        {
            pnlVEHSeguroObligatorio.Visible = false;
        }

        private void btnInmContenido_Click(object sender, EventArgs e)
        {
            pnlInmuebles.Visible = false;
            pnlMueblesInmContenido.Visible = true;
        }

        private void btnInmEdificaciones_Click(object sender, EventArgs e)
        {
            pnlInmuebles.Visible = false;
            pnlMueblesInmEdificaciones.Visible = true;
        }

        private void lblCerrarInmContenido_Click(object sender, EventArgs e)
        {
            pnlMueblesInmContenido.Visible = false;
        }

        private void lblCerrarSegInmEdif_Click(object sender, EventArgs e)
        {
            pnlMueblesInmEdificaciones.Visible = false;
        }

        private void btnMueblesEInmuebles_Click(object sender, EventArgs e)
        {
            pnlInmuebles.Visible = true;
        }

        private void lblCerrar_pnlInmuebles_Click(object sender, EventArgs e)
        {
            pnlInmuebles.Visible = false;
        }

        private void btnNegocioEmpresa_Click(object sender, EventArgs e)
        {
            pnlNegociosEmpresas.Visible = true;
        }

        private void lblCerrarNegocioEmp_Click(object sender, EventArgs e)
        {
            pnlNegociosEmpresas.Visible = false;
        }

        private void btnVidaRLab_BuscarEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void lblVidaRLab_BuscarEmpresaCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguientepnlVEHSeguroObligatorio_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
        }

        private void btnSIGUIENTEpnlVEHSeguroTodoRiesgo_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
        }

        private void btnSIGUIENTEpnlVEHSeguroVoluntario_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
        }

        private void btnSIGUIENTEpnlMueblesInmContenido_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
        }

        private void btnSIGUIENTEpnlMueblesInmEdificaciones_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
        }

        private void btnSIGUIENTEpnlNegociosEmpresas_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
        }

        private void btnSIGUIENTEpnlVidaSaludDependientes_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
        }

        private void btnSIGUIENTEpnlVidaSalud_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
        }

        private void btnSIGUIENTEpnlVidaRiesgoMuerte_Click(object sender, EventArgs e)
        {
            MostrarFormFactura();
        }
        
        public void MostrarFormFactura()
        {
            frmFacturas f = new frmFacturas();
            f.ShowDialog();
        }
    }
}
