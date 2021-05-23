using CapaNegocio.B_ResumenVentaPoliza;
using CapaNegocio.Poliza;
using PerlaDelSur_Entity.Poliza;
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
        string DatosYContratoDePolizaDeSeguro = " Le mostramos a continuación, a modo de ejemplo, una poliza de Seguro de Vida Individual, incluyendo las Condiciones Generales y Especiales."
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

        public bool formValue = true;
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
            cmbTipoPago.SelectedIndex = 0;
        }

        private void frmResumenVentaPoliza_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cmbTipo_Pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPago.Text == "Parcial")
            {
                lblParcial.Visible = true;
                txtParcial.Visible = true;
            }
            else
            {
                lblParcial.Visible = false;
                txtParcial.Visible = false;
            }
        }


        private bool ValueParcial()
        {
            bool value = true;

            if (cmbTipoPago.Text == "Parcial")
            {
                if (!string.IsNullOrEmpty(txtParcial.Text) ||
                    !string.IsNullOrWhiteSpace(txtParcial.Text))
                {
                    decimal Total = Convert.ToDecimal(txtTotalA_Pagar.Text);
                    decimal Parcial = Convert.ToDecimal(txtParcial.Text);
                    if (Parcial > Total)
                    {
                        MessageBox.Show("No se puede pagar de manera parcial un valor igual o mayor que el precio total."
                            + " Por favor, intentelo de nuevo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        value = false;
                        txtParcial.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Completar el campo Parcial.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    value = false;
                }
            }

            return value;
        }

        bool PolizaCreada = false;
        private void btnPagarCrearPoliza_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValueParcial() && formValue)
                {
                    Pagar_y_CrearPoliza();
                }
                if (!formValue)
                {
                    if (PolizaCreada == false)
                    {
                        CrearPolizaSolicitud();
                    }
                    else
                    {
                        MessageBox.Show("La poliza actual ya ha sido creada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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
            E_ResumenVentaPoliza.Total = Convert.ToDecimal(txtTotalA_Pagar.Text);

            E_ResumenVentaPoliza.InstitutoDondeLabora = strInstitutoDondeLabora;
            E_ResumenVentaPoliza.FechaHora = DateTime.Now;
            E_ResumenVentaPoliza.AntecedentesPersonales = strAntecedentesPersonales;
            E_ResumenVentaPoliza.Fecha = DateTime.Now.Date;
            E_ResumenVentaPoliza.Tipo = txtCategoria.Text.Trim();
            E_ResumenVentaPoliza.Poliza = DatosYContratoDePolizaDeSeguro;
            E_ResumenVentaPoliza.EstadoPoliza = 1;

            E_ResumenVentaPoliza.IdSolicitud = Convert.ToInt32(txtCodigo.Text);
            E_ResumenVentaPoliza.IdSeguro = Convert.ToInt32(txtIdSeguro.Text);
            E_ResumenVentaPoliza.T_Pago = cmbTipoPago.Text;


            if (string.IsNullOrEmpty(txtParcial.Text) ||
                    string.IsNullOrWhiteSpace(txtParcial.Text))
            {
                E_ResumenVentaPoliza.PagoParcial = 0.0m;
            }
            else
            {
                E_ResumenVentaPoliza.PagoParcial = Convert.ToDecimal(txtParcial.Text);
            }
            if (string.IsNullOrEmpty(txtDescuento.Text) ||
                string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                E_ResumenVentaPoliza.Descuento = 0.0m;
            }
            else
            {
                E_ResumenVentaPoliza.Descuento = Convert.ToDecimal(txtDescuento.Text);
            }

            E_ResumenVentaPoliza.Vencimiento = strVencimiento();

            if (MessageBox.Show("¿Está seguro que desea realizar el pago y crear una póliza de seguro para el cliente actual?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ResumenVentaPoliza.CrearPoliza(E_ResumenVentaPoliza) >= 3)
                {
                    MessageBox.Show("Poliza creada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error inesperado.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
            }
        }
        private DateTime strVencimiento()
        {
            DateTime dt = DateTime.Now.Date;
            dt = dt.AddMonths(6);
            return dt;
        }

        private void btnDescontar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDescontar.Text) ||
                    !string.IsNullOrWhiteSpace(txtDescontar.Text))
                {
                    string strPorCiento = "";

                    decimal CantidadTotal = Convert.ToDecimal(txtSubTotal.Text);

                    strPorCiento = "0." + txtDescontar.Text;
                    decimal PorCiento = Convert.ToDecimal(strPorCiento, CultureInfo.InvariantCulture);

                    decimal C = CantidadTotal * PorCiento;

                    decimal P = CantidadTotal - C;

                    decimal Round_A = Math.Round(C, 2);
                    txtDescuento.Text = Round_A.ToString();


                    txtTotalA_Pagar.Text = Math.Round(P, 2).ToString();
                }
            }
            catch (Exception)
            { }
        }

        private void txtDescontar_TextChanged(object sender, EventArgs e)
        {
            txtDescontar.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };
        }

        private void txtParcial_TextChanged(object sender, EventArgs e)
        {
            txtParcial.TextChanged += delegate (System.Object o, System.EventArgs r)
            {
                TextBox _tbox = o as TextBox;
                _tbox.Text = new string(_tbox.Text.Where(c => (char.IsDigit(c))).ToArray());
            };
        }

        E_Poliza E_Poliza = new E_Poliza();
        B_Poliza B_Poliza = new B_Poliza();

        public string strPoliza;
        public DateTime Vencimiento;


        int idPoliza = 0;

        private void CrearPolizaSolicitud()
        {
            E_Poliza.IdCliente = Convert.ToInt32(txtId.Text);
            E_Poliza.Poliza = strPoliza;
            E_Poliza.IdPolizaSeguro = Convert.ToInt32(txtIdSeguro.Text);
            E_Poliza.FechaHora = DateTime.Now;
            E_Poliza.Vencimiento = Vencimiento;
           // E_Poliza.Parcial = Convert.ToDecimal(txtParcial.Text);


            switch (txtSeguroA_Adquirir.Text)
            {
                case "Seguro Contenido":
                    if (MessageBox.Show("Se creará una Póliza del Seguro para el Cliente y la Solicitud actual." + Environment.NewLine + "Desea continuar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (B_Poliza.B_CrearPolizaContenido(E_Poliza) == 1)
                        {
                            MessageBox.Show("Se ha creado la Póliza de Seguro satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;
                case "Seguro Edificaciones":
                    if (MessageBox.Show("Se creará una Póliza del Seguro para el Cliente y la Solicitud actual.", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (B_Poliza.B_CrearPolizaEdificaciones(E_Poliza) == 1)
                        {
                            MessageBox.Show("Se ha creado la Póliza de Seguro satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;
                case "Seguro para Empresas y Negocios":
                    if (MessageBox.Show("Se creará una Póliza del Seguro para el Cliente y la Solicitud actual.", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (B_Poliza.B_CrearPolizaSeguroEmpresasNegocio(E_Poliza) == 1)
                        {
                            MessageBox.Show("Se ha creado la Póliza de Seguro satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    break;
                case "Seguro a Todo Riesgo":
                    if (MessageBox.Show("Se creará una Póliza del Seguro para el Cliente y la Solicitud actual.", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        idPoliza = B_Poliza.B_CrearPolizaSeguroTodoRiesgo(E_Poliza);
                        if (idPoliza >= 1)
                        {
                            MessageBox.Show("Se ha creado la Póliza de Seguro satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PolizaCreada = true;
                            btnImprimir.Visible = true;
                        }
                    }
                    break;
                case "Seguro Obligatorio":
                    if (MessageBox.Show("Se creará una Póliza del Seguro para el Cliente y la Solicitud actual.", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        idPoliza = B_Poliza.B_CrearPolizaSeguroObligatorio(E_Poliza);
                        if (idPoliza >= 1)
                        {
                            MessageBox.Show("Se ha creado la Póliza de Seguro satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PolizaCreada = true;
                            btnImprimir.Visible = true;
                        }
                    }
                    break;
                case "Seguro Voluntario":
                    if (MessageBox.Show("Se creará una Póliza del Seguro para el Cliente y la Solicitud actual.", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        idPoliza = B_Poliza.B_CrearPolizaSeguroVoluntario(E_Poliza);
                        if (idPoliza >= 1)
                        {
                            MessageBox.Show("Se ha creado la Póliza de Seguro satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PolizaCreada = true;
                            btnImprimir.Visible = true;
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmPreviewFactura fP = new frmPreviewFactura();
            fP.idCliente = Convert.ToInt32(txtId.Text);
            fP.idPoliza = idPoliza;
            fP.strTipoPago = cmbTipoPago.Text;
            fP.Total = Convert.ToDecimal(txtTotalA_Pagar.Text);
            fP.ShowDialog();
        }
    }
}
