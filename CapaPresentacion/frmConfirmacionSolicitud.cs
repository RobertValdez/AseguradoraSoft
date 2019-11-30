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
           dgvMostrarSolicitudes.DataSource = B_ConfirmacionSolicitud.B_MostrarSeguroVoluntario();
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

                        if (MessageBox.Show("Se confirmará la aprobación de la solicitud actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (B_ConfirmacionSolicitud.B_AprobarSolicitudSeguroVoluntario(E_Confirmacion) > 1)
                            {
                                MessageBox.Show("Confirmación de solicitud aprobada satisfactoriamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MostrarDetalleVoluntario();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una solicitud En proceso para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)  { MessageBox.Show(ex.Message); }
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
                  || !string.IsNullOrWhiteSpace(txtIdSolicitud.Text) )
                {
                    if (txtEstado.Text == "En proceso")
                    {
                        E_Confirmacion.IdSolicitud = Convert.ToInt32(txtIdSolicitud.Text);

                        E_Confirmacion.Estado = 2;

                        E_Confirmacion.Nota = txtNota.Text;

                        if (MessageBox.Show("Está a punto de rechazar la solicitud actual. Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (B_ConfirmacionSolicitud.B_RechazarSolicitudSeguroVoluntario(E_Confirmacion) > 1)
                            {
                                MessageBox.Show("Solicitud rechazada correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MostrarDetalleVoluntario();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una solicitud En proceso para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvMostrarSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvMostrarSolicitudes.CurrentRow;

            txtIdSolicitud.Text = row.Cells[1].Value.ToString();
            txtEstado.Text = row.Cells[20].Value.ToString();
            txtNota.Text = row.Cells[19].Value.ToString();
        }
    }
}
