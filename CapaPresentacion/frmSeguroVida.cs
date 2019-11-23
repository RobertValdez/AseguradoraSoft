using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PerlaDelSur_Entity.SeguroVida;
using PerlaDelSur_Entity.Clientes;
using CapaNegocio.Clientes;
using CapaNegocio.SeguroVida;

namespace CapaPresentacion
{
    public partial class frmSeguroVida : Form
    {
        E_SeguroVida E_SegVida = new E_SeguroVida();
        E_Clientes E_Clientes = new E_Clientes();
        B_Clientes B_Clientes = new B_Clientes();
        B_SeguroVida B_SeguroVida = new B_SeguroVida();

        DataTable dtPolizaDeSeguros = new DataTable();
        DataTable dtEmpleado = new DataTable();
        DataTable dtId_detalleSegVida = new DataTable();

        int idProductoSeguroVidaSalud = 0;

        int idCodigo = 0;
        decimal Precio = 0;
        int varIdEmpleado = 0;

        static string _Categoria = "";

        public frmSeguroVida()
        {
            InitializeComponent();
        }

        private void btnRiesgoMuerte_Click(object sender, EventArgs e)
        {
            _DescrepcionValue = false;
            if (!cancelarDescripcionSeguros())
            {
                pnlVidaRiesgoMuerte.Visible = true;
            }
        }

        private void btnRiesgosLaborales_Click(object sender, EventArgs e)
        {
            _DescrepcionValue = false;
            if (!cancelarDescripcionSeguros())
            {
                pnlVidaRiesgosLaborales.Visible = true;
            }
        }

        private void btnSeguroSalud_Click(object sender, EventArgs e)
        {
            _DescrepcionValue = false;
            if (!cancelarDescripcionSeguros())
            {
                DataView dv = new DataView(dtPolizaDeSeguros);

                dv.RowFilter = "[Nombre del Seguro] = 'Seguro de Salud'";

                idProductoSeguroVidaSalud = (int)dv[0]["id"];
                Precio = (decimal)dv[0]["Precio"];

                pnlVidaSalud.Visible = true;
            }
        }

        private void btnDependientes_Click(object sender, EventArgs e)
        {
            _DescrepcionValue = false;
            if (!cancelarDescripcionSeguros())
            {
                pnlVidaSaludDependientes.Visible = true;
            }
        }

        private void lblCerrarRiesgoMuerte_Click(object sender, EventArgs e)
        {
            pnlVidaRiesgoMuerte.Visible = false;
        }

        private void lblCerrar_pnlRiesgoLab_Click(object sender, EventArgs e)
        {
            pnlVidaRiesgosLaborales.Visible = false;
        }

        private void lblVidaRLab_BuscarEmpresaCerrar_Click(object sender, EventArgs e)
        {
            pnlVidaRiesgosLaborales_BuscarEmpresa.Visible = false;
            lblSeguroRiesgosLaborales.Text = "Seguro Riesgos Laborales";
            lblCerrar_pnlRiesgoLab.Visible = true;
        }

        private void lblCerrar_pnlVidaSalud_Click(object sender, EventArgs e)
        {
            pnlVidaSalud.Visible = false;
        }

        private void lblCerrarSDepend_Click(object sender, EventArgs e)
        {
            pnlVidaSaludDependientes.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pnlBuscarCliente.Visible = true;
            MostrarClientes();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            pnlBuscarCliente.Visible = false;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            QuitarErrorProviderCliente();
            if (ValidarCamposCliente() || mskTelefonoValidar() || mskCedulaValidar())
            {
                InsertarCliente();
            }
        }
        public void InsertarCliente()
        {
            try
            {
                if (!txtId.Text.Equals(""))
                {
                    MessageBox.Show("El Cliente ya existe. Haga clic en Nuevo para añadir a otro cliente.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text)
                    || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrWhiteSpace(txtApellido.Text)      
                    || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || !mskTelefonoValidar() || !mskCedulaValidar() 
                    || string.IsNullOrEmpty(txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text)
                    || string.IsNullOrEmpty(cmbNacionalidad.Text) || string.IsNullOrWhiteSpace(cmbNacionalidad.Text)
                    || string.IsNullOrEmpty(cmbSexo.Text) || string.IsNullOrWhiteSpace(cmbSexo.Text))
                    {
                        MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        E_Clientes.Nombre = txtNombre.Text.Trim();
                        E_Clientes.Apellido = txtApellido.Text.Trim();
                        E_Clientes.Cedula = mskCedula.Text.Trim();
                        E_Clientes.Direccion = txtDireccion.Text.Trim();
                        E_Clientes.Telefono = mskTelefono.Text.Trim();
                        E_Clientes.Nacionalidad = cmbNacionalidad.Text.Trim();
                        E_Clientes.CorreoElectronico = txtCorreoElectronico.Text.Trim();
                        E_Clientes.Sexo = cmbSexo.Text.Trim();
                        E_Clientes.RNC = txtRNC.Text.Trim();
                        E_Clientes.FechaHora = DateTime.Now;

                        int rsp = B_Clientes.B_InsertarCliente(E_Clientes);
                        if (rsp == 0)
                        {
                            MessageBox.Show("No se añadió el Cliente.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Se ha añadido el Cliente correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtId.Text = rsp.ToString();
                            InhabilitarTxTs();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmSeguroVida_Load(object sender, EventArgs e)
        {
            Cargar_idCodigo_detalleSeguroSalud();
            CargarSegurosDePoliza();
            CargarEmpleado();
            MostrarClientes();
        }
        
        public void Cargar_idCodigo_detalleSeguroSalud()
        {
            try
            {
                idCodigo = B_SeguroVida.B_Cargar_id_detalleSeguroSalud(E_SegVida);
            }
            catch (Exception  ex){
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarSegurosDePoliza()
        {
            try
            {
                dtPolizaDeSeguros = B_SeguroVida.B_MostrarSegurosDePolizas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarEmpleado()
        {
            E_SegVida.Id = 1;
            varIdEmpleado = 1; /////

            B_SeguroVida.B_CargarNombreEmpleado(E_SegVida);

            lblNombre_empleado.Text = E_SegVida.NombreEmpleado;
            lblCedula.Text = E_SegVida.Cedula;
        }
        public void MostrarClientes()
        {
            dgvBuscarClientes.DataSource = B_Clientes.B_MostrarClientes();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }
        public void BuscarClientes()
        {
            try
            {
                if (chkSoloId.Checked)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvBuscarClientes.DataSource;
                    bs.Filter = "CONVERT(id, 'System.String') like '%" + txtBuscar.Text + "%'";
                    dgvBuscarClientes.DataSource = bs;
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvBuscarClientes.DataSource;
                    bs.Filter = "CONVERT(id, 'System.String') like '%" + txtBuscar.Text + "%' OR Nombre like '%" +
                        txtBuscar.Text + "%' OR Apellido like '%" + txtBuscar.Text +
                        "%' OR Direccion like '%" + txtBuscar.Text + "%' OR Cedula like '%" + txtBuscar.Text +
                        "%' OR Telefono like '%" + txtBuscar.Text + "%' OR [Correo Electronico] like '%" + txtBuscar.Text + "%'";
                    dgvBuscarClientes.DataSource = bs;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void chkSoloId_CheckedChanged(object sender, EventArgs e)
        {
            BuscarClientes();
            if (chkSoloId.Checked)
            {
                chkSoloId.BackColor = Color.DarkViolet;
                chkSoloId.ForeColor = Color.White;
            }
            else
            {
                chkSoloId.BackColor = Color.White;
                chkSoloId.ForeColor = Color.Crimson;
            }
        }

        static bool _DescrepcionValue = false;
        public frmSeguroVida(bool DescrepcionValue)
        {
            _DescrepcionValue = DescrepcionValue;
        }
        
        public frmSeguroVida(string Categoria)
        {
            _Categoria = Categoria;
        }

        public bool cancelarDescripcionSeguros()
        {
            bool value = false;
            frmDescripcionSeguros frm = new frmDescripcionSeguros();
            frm.ShowDialog();

            if (_DescrepcionValue.Equals(true))
            {
                value = true;
            }
            return value;
        }

        private void btnSIGUIENTEpnlVidaSalud_Click(object sender, EventArgs e)
        {
            Siguiente_pnlVidaSalud();

            mskTelefonoValidar();
            mskCedulaValidar();
        }
        public void Siguiente_pnlVidaSalud()
        {
            try
            {
                mskTelefonoValidar();
                mskCedulaValidar();

                QuitarErrorProviderCliente();
                ValidarCamposCliente();
                //------------------------//
                QuitarErrorProviderSegSalud();
                ValidarCamposSegSalud();

                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text)
                    || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrWhiteSpace(txtApellido.Text)
                    || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || mskCedula.Text == "   -       -" || mskTelefono.Text == ""
                    || string.IsNullOrEmpty(txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text)
                    || string.IsNullOrEmpty(cmbNacionalidad.Text) || string.IsNullOrWhiteSpace(cmbNacionalidad.Text)
                    || string.IsNullOrEmpty(cmbSexo.Text) || string.IsNullOrWhiteSpace(cmbSexo.Text)
                    || string.IsNullOrEmpty(txtInstitutoDondeLabora.Text) || string.IsNullOrWhiteSpace(txtInstitutoDondeLabora.Text)
                    || string.IsNullOrEmpty(txtAntecedentesPersonales.Text) || string.IsNullOrWhiteSpace(txtAntecedentesPersonales.Text))
                {
                    MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNombre.ReadOnly == true) // True aquí: Significa que está añadido como cliente en la Base de Datos
                {
                    frmResumenVentaPoliza frmFac = new frmResumenVentaPoliza();

                    frmFac.txtId.Text = txtId.Text;
                    frmFac.txtCliente.Text = txtNombre.Text + " " + txtApellido.Text;
                    frmFac.txtCedula.Text = mskCedula.Text;
                    frmFac.txtSeguroA_Adquirir.Text = lblSeguroSalud.Text;
                    frmFac.txtEfectoA_Asegurar.Text = "N/A";
                    frmFac.txtCategoria.Text = _Categoria;
                    frmFac.txtIdSeguro.Text = idProductoSeguroVidaSalud.ToString();

                    frmFac.txtCodigo.Text = idCodigo.ToString();
                    frmFac.txtSubTotal.Text = Precio.ToString();
                    frmFac.txtTotal_A_Pagar.Text = Precio.ToString();


                    frmFac.strInstitutoDondeLabora = txtInstitutoDondeLabora.Text.Trim();
                    frmFac.strAntecedentesPersonales = txtAntecedentesPersonales.Text.Trim();
                    frmFac.varIdEmpleado = varIdEmpleado;

                    frmFac.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Añada el Cliente actual para poder continuar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private bool ValidarCamposSegSalud()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtInstitutoDondeLabora.Text)
                || string.IsNullOrWhiteSpace(txtInstitutoDondeLabora.Text))
            {
                ok = false;
                errorProvider1.SetError(txtInstitutoDondeLabora, "Campo obligatorio");
                txtInstitutoDondeLabora.Text = "";
            }

            if (string.IsNullOrEmpty(txtAntecedentesPersonales.Text)
                || string.IsNullOrWhiteSpace(txtAntecedentesPersonales.Text))
            {
                ok = false;
                errorProvider1.SetError(txtAntecedentesPersonales, "Campo obligatorio");
                txtAntecedentesPersonales.Text = "";
            }

            return ok;
        }

        private void QuitarErrorProviderSegSalud()
        {
            errorProvider1.SetError(txtInstitutoDondeLabora, "");
            errorProvider1.SetError(txtAntecedentesPersonales, "");;
        }

        private void dgvBuscarClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvBuscarClientes.CurrentRow;
            txtId.Text = row.Cells[0].Value.ToString();
            txtNombre.Text = row.Cells[1].Value.ToString();
            txtApellido.Text = row.Cells[2].Value.ToString();
            txtDireccion.Text = row.Cells[3].Value.ToString();
            mskCedula.Text = row.Cells[4].Value.ToString();
            cmbNacionalidad.Text = row.Cells[5].Value.ToString();
            mskTelefono.Text = row.Cells[6].Value.ToString();
            txtCorreoElectronico.Text = row.Cells[7].Value.ToString();

            txtRNC.Text = row.Cells[9].Value.ToString();

            string strSexo = "";
            switch (row.Cells[8].Value.ToString())
            {
                case "M":
                    strSexo = "Masculino";
                    break;

                case "F":
                    strSexo = "Femenino";
                    break;
            }
            cmbSexo.Text = strSexo;
            pnlBuscarCliente.Visible = false;
            InhabilitarTxTs();
        }

        public void InhabilitarTxTs()
        {
            lblId.Visible = true;
            txtId.Visible = true;

            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            mskCedula.ReadOnly = true;
            mskTelefono.ReadOnly = true;
            txtCorreoElectronico.ReadOnly = true;
            cmbNacionalidad.Enabled = false;
            cmbSexo.Enabled = false;
            txtRNC.ReadOnly = true;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            csLimpiar L = new csLimpiar();
            L.BorrarCamposPnl(pnlCliente);

            lblId.Visible = false;
            txtId.Visible = false;

            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            mskCedula.ReadOnly = false;
            mskTelefono.ReadOnly = false;
            txtCorreoElectronico.ReadOnly = false;
            cmbNacionalidad.Enabled = true;
            cmbSexo.Enabled = true;
            txtRNC.ReadOnly = false;

            QuitarErrorProviderCliente();
        }

        private bool ValidarCamposCliente()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Escriba el Nombre");
            }

            if (string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                ok = false;
                errorProvider1.SetError(txtApellido, "Escriba el Apellido");
            }
            if (string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                ok = false;
                errorProvider1.SetError(txtDireccion, "Escriba la Dirección");
            }

            if (string.IsNullOrEmpty(cmbNacionalidad.Text) || string.IsNullOrWhiteSpace(cmbNacionalidad.Text))
            {
                ok = false;
                errorProvider1.SetError(cmbNacionalidad, "Escriba la Nacionalidad");
            }
            if (string.IsNullOrEmpty(txtCorreoElectronico.Text) || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCorreoElectronico, "Escriba el Correo Electrónico");
            }
            if (string.IsNullOrEmpty(cmbSexo.Text) || string.IsNullOrWhiteSpace(cmbSexo.Text))
            {
                ok = false;
                errorProvider1.SetError(cmbSexo, "Indique el Sexo");
            }

            return ok;
        }
        private void QuitarErrorProviderCliente()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(mskCedula, "");
            errorProvider1.SetError(mskTelefono, "");
            errorProvider1.SetError(cmbNacionalidad, "");
            errorProvider1.SetError(txtCorreoElectronico, "");
            errorProvider1.SetError(cmbSexo, "");
        }

        private void mskTelefono_Leave(object sender, EventArgs e)
        {
            
        }
        public bool mskTelefonoValidar()
        {
            bool valor = false;

            if (!mskTelefono.Text.Length.Equals(14))
            {
                valor = false;
                errorProvider1.SetError(mskTelefono, "Complete el Telefono");
            }
            else
            {
                valor = true;
            }
            return valor;
        }
        private void mskTelefono_Validating(object sender, CancelEventArgs e)
        {
            mskTelefonoValidar();
        }

        private void mskCedula_Validating(object sender, CancelEventArgs e)
        {
            mskCedulaValidar();
        }
        public bool mskCedulaValidar()
        {
            bool valor = false;
            if (!mskCedula.Text.Length.Equals(13))
            {
                valor = false;
                errorProvider1.SetError(mskCedula, "Complete la Cédula");
            }
            else
            {
                valor = true;
            }

            return valor;
        }

        private void btnVidaRLab_BuscarEmpresa_Click(object sender, EventArgs e)
        {
            pnlVidaRiesgosLaborales_BuscarEmpresa.Visible = true;
            lblSeguroRiesgosLaborales.Text = "Buscar Empresa del Cliente";
            lblCerrar_pnlRiesgoLab.Visible = false;
        }
    }
}
