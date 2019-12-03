using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio.Poliza;
using CapaNegocio.VerPoliza;
using CapaNegocio.Empleados;
using CapaNegocio.SeguroVida;
using PerlaDelSur_Entity.Poliza;
using CapaNegocio.Clientes;
using CapaNegocio.Consultas;

namespace CapaPresentacion
{
    public partial class frmPolizas : Form
    {
        DataTable dtSeguroContenido = new DataTable();
        DataTable dtSeguroEdificaciones = new DataTable();
        DataTable dtSeguroEmpresasNegocios = new DataTable();
        DataTable dtSeguroTodoRiesgo = new DataTable();
        DataTable dtSeguroObligatorio = new DataTable();
        DataTable dtSeguroVoluntario = new DataTable();

        DataTable dt_vdPoliza = new DataTable();
        DataTable dt_vhPoliza = new DataTable();
        DataTable dt_inPoliza = new DataTable();
        DataTable dt_emPoliza = new DataTable();


        clSoloNumero cs = new clSoloNumero();

        B_Clientes B_Clientes = new B_Clientes();

        private E_Poliza E_Poliza = new E_Poliza();
        private B_VerPoliza B_VerPolizas = new B_VerPoliza();
        private B_Poliza B_Poliza = new B_Poliza();

        B_SeguroVida B_PolizasSeguro = new B_SeguroVida();

        int idEmpleado = 1;

        int idCliente_R = 0;
        int idCliente_C = 0;
        DataTable dtMostrarPolizas = new DataTable();

        DataTable dtCargarPolizasDeSeguro = new DataTable();

        string Poliza = "";
        string _Categoria;
        private string idFactura;
        private decimal Precio;
        int idProductoSeguro;

        decimal Descuento = 0;
        string T_Pago;
        private decimal PagoParcial;
        int IdCliente_N = 0;
        int EstadoPoliza_N = 0;

        bool blParcial = false;
        public frmPolizas()
        {
            InitializeComponent();
        }

        private void btnPagoP_Click(object sender, EventArgs e)
        {
            tabGestionarPolizas.Visible = false;
            pnlPagoPolizas.Visible = true;///

            btnPagoP.BackColor = Color.LightPink;
            btnGestionarP.BackColor = Color.White;
            QuitarErrorProviderCliente();
        }

        private void btnGestionarP_Click(object sender, EventArgs e)
        {
            tabGestionarPolizas.Visible = true;
            pnlPagoPolizas.Visible = true; ///

            btnGestionarP.BackColor = Color.LightPink;
            btnPagoP.BackColor = Color.White;
            QuitarErrorProviderCliente();
        }

        private void cmbTPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTPago.Text == "Al contado")
            {
                lblParcial.Visible = false;
                txtPagoParcial_Renovar.Visible = false;
            }
            else
            {
                lblParcial.Visible = true;
                txtPagoParcial_Renovar.Visible = true;
                blParcial = true;
            }

        }

        private void frmPolizas_Load(object sender, EventArgs e)
        {
            CargarPolizas();
            MostrarClientes();
            CargarDetalles();
        }

        private void CargarDetalles()
        {
            dtSeguroContenido = B_Poliza.B_MostrarSeguroContenido();
            dtSeguroEdificaciones = B_Poliza.B_MostrarSeguroEdificaciones();
            dtSeguroEmpresasNegocios = B_Poliza.B_MostrarSeguroEmpresasNegocios();
            dtSeguroTodoRiesgo = B_Poliza.B_MostrarSeguroTodoRiesgo();
            dtSeguroObligatorio = B_Poliza.B_MostrarSeguroObligatorio();
            dtSeguroVoluntario = B_Poliza.B_MostrarSeguroVoluntario();
        }

        public void MostrarClientes()
        {
            dgvBuscarClientes.DataSource = B_Clientes.B_MostrarClientes();
        }

        private void CargarPolizas()
        {
            dt_vdPoliza = B_VerPolizas.B_vd_VerPoliza();
            dt_vhPoliza = B_VerPolizas.B_vh_MostrarPolizas();
            dt_inPoliza = B_VerPolizas.B_in_MostrarPolizas();
            dt_emPoliza = B_VerPolizas.B_em_MostrarPolizas();
        }

        string Nombre_C = "";
        string Apellido_C = "";
        string Cedula_C = "";

        private void dgvMostrarPoliza_Cancelar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvMostrarPoliza_Cancelar.CurrentRow;
                dgvMostrarPoliza_Cancelar.Rows[row.Index].Selected = true;

                idCliente_C = Convert.ToInt32(row.Cells[0].Value.ToString());

                txtCliente_Cancelar.Text = row.Cells[11].Value.ToString();
                txtNumPoliza_Cancelar.Text = row.Cells[1].Value.ToString();

                Nombre_C = row.Cells[9].Value.ToString();
                Apellido_C = row.Cells[10].Value.ToString();
                Cedula_C = row.Cells[11].Value.ToString();

                txtEstado_Cancelar.Text = row.Cells[6].Value.ToString();

                BtnPagarEnableEstado_C();

            }
            catch (Exception) { }
        }

        private void BtnPagarEnableEstado_C()
        {
            if (txtEstado_Cancelar.Text == "Activo")
            {
                btnCancelarPoliza.Enabled = true;
            }
            else if (txtEstado_Cancelar.Text == "Inactivo")
            {
                btnCancelarPoliza.Enabled = false;
            }
            else
            {
                btnCancelarPoliza.Enabled = false;
            }
        }

        private void dgvMostrarPolizas_Pagar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvMostrarPolizas_Renovar.CurrentRow;
                dgvMostrarPolizas_Renovar.Rows[row.Index].Selected = true;

                idCliente_R = Convert.ToInt32(row.Cells[0].Value.ToString());

                txtCedulaCliente_Renovar.Text = row.Cells[11].Value.ToString();
                txtNumPoliza_Renovar.Text = row.Cells[1].Value.ToString();


                txtEstado_Renovar.Text = row.Cells[6].Value.ToString();
                txtPrecio_Renovar.Text = row.Cells[5].Value.ToString();
                txtTotalAPagar_Renovar.Text = row.Cells[5].Value.ToString();

                string strVenc = row.Cells[8].Value.ToString();

                txtVencimiento_Renovar.Text = strVenc.Remove(11, 8);
                BtnPagarEnableEstado_R();

            }
            catch (Exception) { }
        }

        public void BtnPagarEnableEstado_R()
        {
            if (txtEstado_Renovar.Text == "Activo")
            {
                btnPagar_Renovar.Enabled = false;
            }
            else if (txtEstado_Renovar.Text == "Inactivo")
            {
                btnPagar_Renovar.Enabled = true;
            }
            else
            {
                btnPagar_Renovar.Enabled = true;
            }
        }

        public void CargarEmpleado()
        {
            idEmpleado = 1;

        }

        private void btnPagar_Renovar_Click(object sender, EventArgs e)
        {
            RenovarPoliza();
        }
        public void RenovarPoliza()
        {
            try
            {
                if ((string.IsNullOrEmpty(txtCedulaCliente_Renovar.Text) || string.IsNullOrWhiteSpace(txtCedulaCliente_Renovar.Text))
                    || ((string.IsNullOrEmpty(txtNumPoliza_Renovar.Text) || string.IsNullOrWhiteSpace(txtNumPoliza_Renovar.Text)))
                    || (string.IsNullOrEmpty(cmbTPago.Text) || string.IsNullOrWhiteSpace(cmbTPago.Text)) || (blParcial == true))
                {
                    MessageBox.Show("Seleccione una Poliza de Seguro para preceder a su pago y renovación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ValidarCamposPagar();
                }
                else
                {
                    E_Poliza.IdPoliza = Convert.ToInt32(txtNumPoliza_Renovar.Text);
                    E_Poliza.IdCliente = idCliente_R;
                    E_Poliza.IdEmpleado = idEmpleado;
                    E_Poliza.Poliza = strPoliza();
                    E_Poliza.Precio = Convert.ToDecimal(txtPrecio_Renovar.Text);
                    E_Poliza.TPago = Convert.ToDecimal(txtTotalAPagar_Renovar.Text);

                    E_Poliza.Parcial = Parcial(txtPagoParcial_Renovar.Text);
                    E_Poliza.FechaHora = DateTime.Now;
                    E_Poliza.Vencimiento = DateTime.Now.Date;

                    if (B_Poliza.B_RenovarPoliza(E_Poliza) >= 2)
                    {
                        MessageBox.Show("Todo Correcto");
                        CargarPolizas();
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public string strPoliza()
        {
            return Poliza = " Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales."
   + "ENTIDAD ASEGURADORA ……………………………………."
   + "NOTA INFORMATIVA AL TOMADOR DEL SEGURO(ASEGURADO)"
   + "La información que se contiene en este documento se ofrece en cumplimiento de lo dispuesto en la Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y de los artículos 104 a 107 de su Reglamento de desarrollo, aprobado por Real Decreto 2486/1998."
   + "LEGISLACIÓN APLICABLE AL CONTRATO DE SEGURO"
   + "Ley 50/1980, de 8 de octubre, de Contrato de Seguro; Ley Orgánica 6/2004 de Ordenación y Supervisión de los Seguros Privados y su Reglamento de desarrollo(Real Decreto nº 2486/1998, de 20 de noviembre). Condiciones Generales, Especiales y Particulares del Contrato."
   + "ENTIDAD ASEGURADORA"
   + "Denominación Social: ………………………………. es el nombre comercial de ……………………………………………………………………………………………………………….. con N.I.F.: ………………………………., con domicilio en ……………………………….."
   + "Corresponde a la Dirección General de Seguros, dependiente del Ministerio de Economía y Hacienda, el control y supervisión de la actividad de dicha Entidad Aseguradora."

   + "INSTANCIAS DE RECLAMACIÓN ………………………………."
   + " 1) Servicio de Atención al Cliente cuyo reglamento se encuentra a disposición de los interesados en las oficinas de ……………………………….."
   + "2) Con carácter general los conflictos se resolverán por los jueces y tribunales competentes."
   + "3) Asimismo puede acudirse, para resolver las controversias que puedan plantearse, al procedimiento administrativo de reclamación ante la Dirección General de Seguros para el cual está legitimado el tomador, asegurado, beneficiario, tercero perjudicado o derechohabiente de cualquiera de ellos."
   + "CONDICIONES GENERALES DEL SEGURO DE VIDA INDIVIDUAL"
   + "El presente contrato de seguro de vida se rige por lo dispuesto en la Ley 50/1980, de 8 de octubre, de contrato de Seguro, T.R de Ordenación y Supervisión de los Seguros Privados, R.D.Leg 6/2004, R.D. 2486/1998 de 20 de Noviembre y por lo convenido en las Condiciones Generales, Especiales y Particulares de este contrato, sin que tengan validez las cláusulas limitativas de los derechos de los asegurados que no sean específicamente aceptadas por el tomador de la póliza.No requerirán dicha aceptación las meras transcripciones o referencias a preceptos legales."
   + "El control de la actividad que desarrolla la Entidad Aseguradora, le corresponde al Ministerio de Economía y Hacienda del Estado español, que lo ejerce a través de la Dirección General de Seguros y Fondos de Pensiones."
   + "ARTÍCULO PRELIMINAR. DEFINICIONES."
   + "Para los efectos de este contrato se entenderá por:";
        }
        public decimal Parcial(string parcial)
        {
            decimal value = 0.00m;
            if (string.IsNullOrEmpty(parcial) || string.IsNullOrWhiteSpace(parcial))
            {
                return 0.00m;
            }
            else
            {
                value = Convert.ToDecimal(parcial);
            }
            return value;
        }

        private bool ValidarCamposPagar()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtNumPoliza_Renovar.Text) || string.IsNullOrWhiteSpace(txtNumPoliza_Renovar.Text))
            {
                ok = false;
                errorProvider1.SetError(dgvMostrarPolizas_Renovar, "Seleccione una Póliza");
            }

            if (string.IsNullOrEmpty(cmbTPago.Text) || string.IsNullOrWhiteSpace(cmbTPago.Text))
            {
                ok = false;
                errorProvider1.SetError(cmbTPago, "Indique la forma de pago");
            }
            if (blParcial == true)
            {
                ok = false;
                errorProvider1.SetError(txtPagoParcial_Renovar, "Escriba valor a abonar");
            }

            return ok;
        }
        private void QuitarErrorProviderCliente()
        {
            errorProvider1.SetError(dgvMostrarPolizas_Renovar, "");
            errorProvider1.SetError(cmbTPago, "");
            errorProvider1.SetError(txtPagoParcial_Renovar, "");
        }

        private void txtPagoParcial_Renovar_TextChanged(object sender, EventArgs e)
        {
            txtPagoParcial_Renovar.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };

            if (txtPagoParcial_Renovar.Text == "")
            {
                blParcial = true;
            }
            else
            {
                blParcial = false;
                errorProvider1.SetError(txtPagoParcial_Renovar, "");
            }
        }

        private void btnCancelarPoliza_Click(object sender, EventArgs e)
        {
            CancelarPoliza();
        }

        private void CancelarPoliza()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNumPoliza_Cancelar.Text) || !string.IsNullOrWhiteSpace(txtNumPoliza_Cancelar.Text))
                {
                    if (MessageBox.Show("Está a punto de Cancelar " + Environment.NewLine + "la Póliza de Seguro Número:    " + txtNumPoliza_Cancelar.Text + Environment.NewLine +
                        "perteneciente al cliente: " + Environment.NewLine + Nombre_C + " " + Apellido_C + ".  De Cédula:   " + Cedula_C + "."
                        + Environment.NewLine + "Desea continuar la cancelación?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        E_Poliza.IdPoliza = Convert.ToInt32(txtNumPoliza_Cancelar.Text);
                        E_Poliza.FechaHora = DateTime.Now;
                        E_Poliza.Nota = txtNota_Cancelar.Text;

                        if (B_Poliza.B_CancelarPoliza(E_Poliza) == 1)
                        {
                            MessageBox.Show("Se ha Cancelado la Poliza Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarPolizas();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una póliza para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            pnlBuscarCliente.Visible = true;
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            pnlBuscarCliente.Visible = false;
        }

        private void dgvBuscarClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvBuscarClientes.CurrentRow;

            IdCliente_N = Convert.ToInt32(row.Cells[0].Value.ToString());
            SolicitudCliente();

            txtCliente.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
            txtCedula.Text = row.Cells[4].Value.ToString();
            pnlBuscarCliente.Visible = false;
        }

        private void txtBuscarDetalles_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dgvSolicitudes.DataSource;
                bs.Filter = "CONVERT([id_Cliente], 'System.String') like '%" + txtBuscarDetalles.Text + "%' OR CONVERT([id Factura], 'System.String') like '%" +
                    txtBuscarDetalles.Text + "%' OR Matricula like '%" + txtBuscarDetalles.Text +
                    "%'";

                dgvSolicitudes.DataSource = bs;
            }
            catch (Exception ex) {  MessageBox.Show(ex.Message);}
        }


        private void dgvSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dgvSolicitudes.CurrentRow;

                dgvSolicitudes.Rows[row.Index].Selected = true;
                txtNoSolicitud.Text = row.Cells[1].Value.ToString();

                _Categoria = row.Cells[18].Value.ToString();
                idFactura = row.Cells[2].Value.ToString();

                Precio = Convert.ToDecimal(row.Cells[14].Value.ToString());
                T_Pago = row.Cells[15].Value.ToString();
                PagoParcial = Convert.ToDecimal(row.Cells[16].Value.ToString());
                Descuento = Convert.ToDecimal(row.Cells[17].Value.ToString());

                idProductoSeguro = Convert.ToInt32(row.Cells[13].Value.ToString());

                IdCliente_N = Convert.ToInt32(row.Cells[0].Value.ToString());
                CargarSeguro();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void SolicitudCliente()
        {
            if (!txtCliente.Text.Equals(""))
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dgvSolicitudes.DataSource;
                bs.Filter = "CONVERT(id_Cliente, 'System.String') like '%" + IdCliente_N + "%'";
                dgvSolicitudes.DataSource = bs;
            }
        }
        B_Consultas B_Consultas = new B_Consultas();
        string Area;
        private void CargarSeguro()
        {
            DataTable dt = B_PolizasSeguro.B_MostrarSegurosDePolizas();
            DataView dv = new DataView(dt);

            dv.RowFilter = "[id] = '" + idProductoSeguro + "'";

            Area = dv[0]["Area"].ToString();
        }

        private void btnProcesoPago_Click(object sender, EventArgs e)
        {
            QuitarErrorProviderNuevo();
            if (ValidarCamposNuevo())
            {
                ProcesoPago();
            }
        }
        private void ProcesoPago()
        {
            try
            {
                QuitarErrorProviderNuevo();

                frmResumenVentaPoliza ReFac = new frmResumenVentaPoliza();

                ReFac.strPoliza = strPoliza();
                ReFac.txtId.Text = Convert.ToString(IdCliente_N);
                ReFac.Vencimiento = strVencimiento();

                ReFac.txtCliente.Text = txtCliente.Text;

                ReFac.txtTotalA_Pagar.Text = totalA_pagar().ToString();
                ReFac.txtSeguroA_Adquirir.Text = cmbSeguros.Text;

                if (Area == "Vehiculo")
                {
                    ReFac.txtEfectoA_Asegurar.Text = "Vehiculo";
                }
                else if (Area == "Vida")
                {
                    ReFac.txtEfectoA_Asegurar.Text = "Vida";
                }
                else if (Area == "Muebles e Inmuebles")
                {
                    ReFac.txtEfectoA_Asegurar.Text = "Muebles e Inmuebles";
                }
                else if (Area == "Negocios e Empresas")
                {
                    ReFac.txtEfectoA_Asegurar.Text = "Negocios e Empresas";
                }

                ReFac.txtCedula.Text = txtCedula.Text;
                ReFac.txtIdSeguro.Text = idProductoSeguro.ToString();
                ReFac.txtCategoria.Text = _Categoria;

                ReFac.txtSubTotal.Text = Precio.ToString();
                ReFac.txtDescuento.Text = Descuento.ToString();

                ReFac.gbxDescontar.Visible = false;
                ReFac.cmbTipoPago.Visible = false;
                ReFac.lbltipodePago.Visible = false;

                ReFac.formValue = false;
                ReFac.ShowDialog();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private bool ValidarCamposNuevo()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtCliente.Text) || string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCliente, "Campo obligatorio");
            }

            if (string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCedula, "Campo obligatorio");
            }
            if (string.IsNullOrEmpty(cmbSeguros.Text) || string.IsNullOrWhiteSpace(cmbSeguros.Text))
            {
                ok = false;
                errorProvider1.SetError(cmbSeguros, "Campo obligatorio");
            }
            if (string.IsNullOrEmpty(txtNoSolicitud.Text) || string.IsNullOrWhiteSpace(txtNoSolicitud.Text))
            {
                ok = false;
                errorProvider1.SetError(txtNoSolicitud, "Campo obligatorio");
            }

            return ok;
        }
        private void QuitarErrorProviderNuevo()
        {
            errorProvider1.SetError(txtCliente, "");
            errorProvider1.SetError(txtCedula, "");
            errorProvider1.SetError(cmbSeguros, "");
            errorProvider1.SetError(txtNoSolicitud, "");
        }

        private DateTime strVencimiento()
        {
            DateTime dt = DateTime.Now.Date;
            dt = dt.AddMonths(6);
            return dt;
        }

        private void cmbSeguros_DropDownClosed(object sender, EventArgs e)
        {
            switch (cmbSeguros.Text)
            {
                case "Seguro Contenido":
                    dgvSolicitudes.DataSource = dtSeguroContenido;
                    SolicitudCliente();
                    break;
                case "Seguro Edificaciones":
                    dgvSolicitudes.DataSource = dtSeguroEdificaciones;
                    SolicitudCliente();
                    break;
                case "Seguro para Empresas y Negocios":
                    dgvSolicitudes.DataSource = dtSeguroEmpresasNegocios;
                    SolicitudCliente();
                    break;
                case "Seguro a Todo Riesgo":
                    dgvSolicitudes.DataSource = dtSeguroTodoRiesgo;
                    SolicitudCliente();
                    break;
                case "Seguro Obligatorio":
                    dgvSolicitudes.DataSource = dtSeguroObligatorio;
                    SolicitudCliente();
                    break;
                case "Seguro Voluntario":
                    dgvSolicitudes.DataSource = dtSeguroVoluntario;
                    SolicitudCliente();
                    break;
                default:
                    break;
            }
        }
        private decimal totalA_pagar()
        {
            decimal precioTotal = 0.0m;
            if (T_Pago == "Al contado")
            {
                if (Descuento > 0)
                {
                    precioTotal = Precio - Descuento;
                }
            }
            else if (T_Pago == "Parcial")
            {
                if (Descuento > 0)
                {
                    precioTotal = Precio - Descuento;
                    precioTotal -= PagoParcial;
                }
                else
                {
                    precioTotal -= PagoParcial;
                }
            }
            return precioTotal;
        }

        private void cmbSegurosRenovar_DropDownClosed(object sender, EventArgs e)
        {
            switch (cmbSegurosRenovar.Text)
            {
                case "Muebles e Inmuebles":
                    dgvMostrarPolizas_Renovar.DataSource = dt_inPoliza;
                    break;
                case "Negocios e Empresas":
                    dgvMostrarPolizas_Renovar.DataSource = dt_emPoliza;
                    break;
                case "Vehiculo":
                    dgvMostrarPolizas_Renovar.DataSource = dt_vhPoliza;
                    break;
                case "Vida":
                    dgvMostrarPolizas_Renovar.DataSource = dt_vdPoliza;
                    break;
                default:
                    break;
            }
        }

        //private void PolizaPorSeguro()
        //{
        //    if (!cmbSegurosRenovar.Text.Equals(""))
        //    {
        //        BindingSource bs = new BindingSource();
        //        bs.DataSource = dgvMostrarPolizas_Renovar.DataSource;
        //        bs.Filter = "[Nombre del Seguro]  like '%" + cmbSegurosRenovar.Text + "%'";
        //        dgvMostrarPolizas_Renovar.DataSource = bs;
        //    }
        //}

        private void txtBuscarPolizasRenovar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dgvMostrarPolizas_Renovar.DataSource;
                bs.Filter = "CONVERT([id Cliente], 'System.String') like '%" + txtBuscarPolizasRenovar.Text + "%' OR Nombre like '%" +
                    txtBuscarPolizasRenovar.Text + "%' OR Apellido like '%" + txtBuscarPolizasRenovar.Text +
                    "%' OR Cédula like '%" + txtBuscarPolizasRenovar.Text +
                    "%' OR Teléfono like '%" + txtBuscarPolizasRenovar.Text + "%' OR [Nombre del Seguro]  like '%" + txtBuscarPolizasRenovar.Text + "%'";
               
                dgvMostrarPolizas_Renovar.DataSource = bs;
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void cmbPolizasC_DropDownClosed(object sender, EventArgs e)
        {
            switch (cmbPolizasC.Text)
            {
                case "Muebles e Inmuebles":
                    dgvMostrarPoliza_Cancelar.DataSource = dt_inPoliza;
                    break;
                case "Negocios e Empresas":
                    dgvMostrarPoliza_Cancelar.DataSource = dt_emPoliza;
                    break;
                case "Vehiculo":
                    dgvMostrarPoliza_Cancelar.DataSource = dt_vhPoliza;
                    break;
                case "Vida":
                    dgvMostrarPoliza_Cancelar.DataSource = dt_vdPoliza;
                    break;
                default:
                    break;
            }
        }

        private void txtBusscarCancelarP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dgvMostrarPoliza_Cancelar.DataSource;
                bs.Filter = "CONVERT([id Cliente], 'System.String') like '%" + txtBusscarCancelarP.Text + "%' OR Nombre like '%" +
                    txtBusscarCancelarP.Text + "%' OR Apellido like '%" + txtBusscarCancelarP.Text +
                    "%' OR Cédula like '%" + txtBusscarCancelarP.Text +
                    "%' OR Teléfono like '%" + txtBusscarCancelarP.Text + "%' OR [Nombre del Seguro]  like '%" + txtBusscarCancelarP.Text + "%'";

                dgvMostrarPoliza_Cancelar.DataSource = bs;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
