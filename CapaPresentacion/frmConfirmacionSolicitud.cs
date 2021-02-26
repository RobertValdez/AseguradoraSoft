using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PerlaDelSur_Entity.ConfirmacionSolicitud;
using CapaNegocio.ConfirmacionSolicitud;

namespace CapaPresentacion
{
    public partial class frmConfirmacionSolicitud : Form
    {
        DataTable dtSeguroContenido = new DataTable();
        DataTable dtSeguroEdificaciones = new DataTable();
        DataTable dtSeguroEmpresasNegocios = new DataTable();
        DataTable dtSeguroTodoRiesgo = new DataTable();
        DataTable dtSeguroObligatorio = new DataTable();
        DataTable dtSeguroVoluntario = new DataTable();

        E_ConfirmacionSolicitud E_Confirmacion = new E_ConfirmacionSolicitud();
        B_ConfirmacionSolicitud B_ConfirmacionSolicitud = new B_ConfirmacionSolicitud();

        public frmConfirmacionSolicitud()
        {
            InitializeComponent();
        }

        private void frmConfirmacionSolicitud_Load(object sender, EventArgs e)
        {
            MostrarDetalleVoluntario();
        }

        private void MostrarDetalleVoluntario()
        {
            //dtSeguroContenido = B_ConfirmacionSolicitud.B_MostrarSeguroContenido();
            //dtSeguroEdificaciones = B_ConfirmacionSolicitud.B_MostrarSeguroEdificaciones();
            //dtSeguroEmpresasNegocios = B_ConfirmacionSolicitud.B_MostrarSeguroEmpresaNegocios();
            dtSeguroTodoRiesgo = B_ConfirmacionSolicitud.B_MostrarSeguroTodoRiesgo();
            dtSeguroObligatorio = B_ConfirmacionSolicitud.B_MostrarSeguroSeguroObligatorio();
            dtSeguroVoluntario = B_ConfirmacionSolicitud.B_MostrarSeguroVoluntario();
        }

        private void btnAprobarSolicitud_Click(object sender, EventArgs e)
        {
            AprobarSolicitud();
        }
        private void AprobarSolicitud()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdSolicitud.Text)
                  || !string.IsNullOrWhiteSpace(txtIdSolicitud.Text))
                {
                    if (txtEstado.Text == "En proceso")
                    {
                        E_Confirmacion.IdSolicitud = Convert.ToInt32(txtIdSolicitud.Text);

                        E_Confirmacion.Estado = 1;

                        E_Confirmacion.Nota = txtNota.Text;

                        switch (cmbSeguros.Text)
                        {
                            case "Seguro Contenido":
                                AprobarSeguroContenido();
                                break;
                            case "Seguro Edificaciones":
                                AprobarSeguroEdificaciones();
                                break;
                            case "Seguro para Empresas y Negocios":
                                AprobarEmpresasNegocios();
                                break;
                            case "Seguro a Todo Riesgo":
                                AprobarTodoRiesgo();
                                break;
                            case "Seguro Obligatorio":
                                AprobarSeguroObligatorio();
                                break;
                            case "Seguro Voluntario":
                                AprobarSeguroVoluntario();
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una solicitud En Proceso para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void AprobarSeguroVoluntario()
        {
            if (MessageBox.Show("Se confirmará la aprobación de la solicitud actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ConfirmacionSolicitud.B_AprobarSolicitudSeguroVoluntario(E_Confirmacion) > 1)
                {
                    MessageBox.Show("Confirmación de solicitud aprobada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDetalleVoluntario();
                    cmbSeguros_DropDownClosed_1(null, null);
                }
            }
        }
        private void AprobarSeguroEdificaciones()
        {
            if (MessageBox.Show("Se confirmará la aprobación de la solicitud actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ConfirmacionSolicitud.B_AprobarSolicitudEdificaciones(E_Confirmacion) > 1)
                {
                    MessageBox.Show("Confirmación de solicitud aprobada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDetalleVoluntario();
                }
            }
        }
        private void AprobarEmpresasNegocios()
        {
            if (MessageBox.Show("Se confirmará la aprobación de la solicitud actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ConfirmacionSolicitud.B_AprobarSolicitudEmpresasNegocio(E_Confirmacion) > 1)
                {
                    MessageBox.Show("Confirmación de solicitud aprobada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDetalleVoluntario();
                }
            }
        }
        private void AprobarTodoRiesgo()
        {
            if (MessageBox.Show("Se confirmará la aprobación de la solicitud actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ConfirmacionSolicitud.B_AprobarSolicitudTodoRiesgo(E_Confirmacion) > 1)
                {
                    MessageBox.Show("Confirmación de solicitud aprobada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDetalleVoluntario();
                    cmbSeguros_DropDownClosed_1(null, null);
                }
            }
        }
        private void AprobarSeguroObligatorio()
        {
            if (MessageBox.Show("Se confirmará la aprobación de la solicitud actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ConfirmacionSolicitud.B_AprobarSolicitudObligatorio(E_Confirmacion) > 1)
                {
                    MessageBox.Show("Confirmación de solicitud aprobada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDetalleVoluntario();
                    cmbSeguros_DropDownClosed_1(null, null);
                }
            }
        }
        private void AprobarSeguroContenido()
        {
            if (MessageBox.Show("Se confirmará la aprobación de la solicitud actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ConfirmacionSolicitud.B_AprobarSolicitudContenido(E_Confirmacion) > 1)
                {
                    MessageBox.Show("Confirmación de solicitud aprobada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDetalleVoluntario();
                }
            }
        }

        private void btnRechazarSolicitud_Click(object sender, EventArgs e)
        {
            RechazarSolicitud();
        }
        private void RechazarSolicitud()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIdSolicitud.Text)
                  && !string.IsNullOrWhiteSpace(txtIdSolicitud.Text)
                  &&  !string.IsNullOrEmpty(txtNota.Text)
                  && !string.IsNullOrWhiteSpace(txtNota.Text))
                {
                    if (txtEstado.Text == "En proceso")
                    {
                        E_Confirmacion.IdSolicitud = Convert.ToInt32(txtIdSolicitud.Text);

                        E_Confirmacion.Estado = 2;

                        E_Confirmacion.Nota = txtNota.Text;

                        switch (cmbSeguros.Text)
                        {
                            case "Seguro Contenido":
                                RechazarContenido();
                                break;
                            case "Seguro Edificaciones":
                                RechazarSeguroEdificaciones();
                                break;
                            case "Seguro para Empresas y Negocios":
                                RechazarEmpresasNegocios();
                                break;
                            case "Seguro a Todo Riesgo":
                                RechazarTodoRiesgo();
                                break;
                            case "Seguro Obligatorio":
                                RechazarrSeguroObligatorio();
                                break;
                            case "Seguro Voluntario":
                                RechazarSeguroVoluntario();
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una solicitud En proceso para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Complete el campo Nota para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void RechazarSeguroVoluntario()
        {
            if (MessageBox.Show("Está a punto de rechazar la solicitud actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ConfirmacionSolicitud.B_RechazarSolicitudSeguroVoluntario(E_Confirmacion) > 1)
                {
                    MessageBox.Show("Solicitud rechazada correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDetalleVoluntario();
                }
            }
        }
        private void RechazarSeguroEdificaciones()
        {
            if (MessageBox.Show("Está a punto de rechazar la solicitud actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ConfirmacionSolicitud.B_RechazarSolicitudEdificaciones(E_Confirmacion) > 1)
                {
                    MessageBox.Show("Solicitud rechazada correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDetalleVoluntario();
                }
            }
        }
        private void RechazarEmpresasNegocios()
        {
            if (MessageBox.Show("Está a punto de rechazar la solicitud actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ConfirmacionSolicitud.B_RechazarSolicitudEmpresasNegocio(E_Confirmacion) > 1)
                {
                    MessageBox.Show("Solicitud rechazada correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDetalleVoluntario();
                }
            }
        }
        private void RechazarrSeguroObligatorio()
        {
            if (MessageBox.Show("Está a punto de rechazar la solicitud actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ConfirmacionSolicitud.B_RechazarSolicitudObligatorio(E_Confirmacion) > 1)
                {
                    MessageBox.Show("Solicitud rechazada correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDetalleVoluntario();
                }
            }
        }
        private void RechazarContenido()
        {
            if (MessageBox.Show("Está a punto de rechazar la solicitud actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ConfirmacionSolicitud.B_RechazarSolicitudContenido(E_Confirmacion) > 1)
                {
                    MessageBox.Show("Solicitud rechazada correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDetalleVoluntario();
                }
            }
        }
        private void RechazarTodoRiesgo()
        {
            if (MessageBox.Show("Está a punto de rechazar la solicitud actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_ConfirmacionSolicitud.B_RechazarSolicitudTodoRiesgo(E_Confirmacion) > 1)
                {
                    MessageBox.Show("Solicitud rechazada correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MostrarDetalleVoluntario();
                }
            }
        }

        private void dgvMostrarSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvMostrarSolicitudes.CurrentRow;

            txtIdSolicitud.Text = row.Cells["Id Solicitud"].Value.ToString();
            txtEstado.Text = row.Cells["Estado"].Value.ToString();
            txtNota.Text = row.Cells["Nota"].Value.ToString();
        }

        private void cmbSeguros_DropDownClosed_1(object sender, EventArgs e)
        {
            switch (cmbSeguros.Text)
            {
                case "Seguro Contenido":
                    dgvMostrarSolicitudes.DataSource = dtSeguroContenido;
                    break;
                case "Seguro Edificaciones":
                    dgvMostrarSolicitudes.DataSource = dtSeguroEdificaciones;
                    break;
                case "Seguro para Empresas y Negocios":
                    dgvMostrarSolicitudes.DataSource = dtSeguroEmpresasNegocios;
                    break;
                case "Seguro a Todo Riesgo":
                    dgvMostrarSolicitudes.DataSource = dtSeguroTodoRiesgo;
                    break;
                case "Seguro Obligatorio":
                    dgvMostrarSolicitudes.DataSource = dtSeguroObligatorio;
                    break;
                case "Seguro Voluntario":
                    dgvMostrarSolicitudes.DataSource = dtSeguroVoluntario;
                    break;
                default:
                    break;
            }
            Filtrar();
        }

        private void rbEnProceso_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
        private void rbAprobados_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void Filtrar()
        {
            try
            {
                if (rbAceptada.Checked)
                {
                    if (!cmbSeguros.Text.Equals(""))
                    {
                        BindingSource bs = new BindingSource();
                        bs.DataSource = dgvMostrarSolicitudes.DataSource;
                        bs.Filter = "Estado like '%" + rbAceptada.Text + "%'";
                        dgvMostrarSolicitudes.DataSource = bs;
                    }
                }
                else if (rbEnProceso.Checked)
                {
                    if (!cmbSeguros.Text.Equals(""))
                    {
                        BindingSource bs = new BindingSource();
                        bs.DataSource = dgvMostrarSolicitudes.DataSource;
                        bs.Filter = "Estado like '%" + rbEnProceso.Text + "%'";
                        dgvMostrarSolicitudes.DataSource = bs;
                    }
                }
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void dgvMostrarSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    var row = dgvMostrarSolicitudes.CurrentRow;
                    frm_detalleConfirmarSolicitud dC = new frm_detalleConfirmarSolicitud();

                    dC.txtIdMod.Text = row.Cells[1].Value.ToString();
                    dC.txtIdSolicitud.Text = row.Cells[2].Value.ToString();
                    dC.txtNombreMod.Text = row.Cells[3].Value.ToString();
                    dC.txtApellidoMod.Text = row.Cells[4].Value.ToString();
                    dC.txtDireccionMod.Text = row.Cells[5].Value.ToString();
                    dC.mskCedulaMod.Text = row.Cells[6].Value.ToString();
                    dC.txtNacionalidad.Text = row.Cells[7].Value.ToString();
                    dC.txtTelefonoMod.Text = row.Cells[8].Value.ToString();
                    dC.txtCorreoElectronicoMod.Text = row.Cells[9].Value.ToString();
                    dC.txtSexo.Text = row.Cells[10].Value.ToString();
                    dC.txtRNC_Mod.Text = row.Cells[11].Value.ToString();
                    dC.txtMarcaVehiculoVol.Text = row.Cells[12].Value.ToString();
                    dC.txtModeloVol.Text = row.Cells[13].Value.ToString();
                    dC.txtMatriculaVol.Text = row.Cells[14].Value.ToString();
                    dC.txtAnoVol.Text = row.Cells[15].Value.ToString();

                    dC.txtCilindrosVol.Text = row.Cells[16].Value.ToString();
                    dC.txtCarroceriaVol.Text = row.Cells[17].Value.ToString();

                    dC.txtCategoriaVol.Text = row.Cells[18].Value.ToString();
                    dC.txtUsoVol.Text = row.Cells[19].Value.ToString();

                    dC.txtEstado.Text = row.Cells[21].Value.ToString();
                    dC.txtTipo.Text = row.Cells[22].Value.ToString();
                    dC.txtFechaHora.Text = row.Cells[23].Value.ToString();

                    dC.ShowDialog();
                }
                catch (Exception) { }
            }

        }
    }
}