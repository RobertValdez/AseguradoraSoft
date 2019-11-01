using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad.Empleados;
using CapaNegocio.Empleados;

namespace CapaPresentacion
{
    public partial class frmEmpleados : Form
    {
        E_Empleados E_Empleados = new E_Empleados();
        B_Empleados B_Empleados = new B_Empleados();

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlNuevo.Visible = true;
            pnlModificar.Visible = false;
            Size = new Size(640, 578);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            pnlNuevo.Visible = false;
            pnlModificar.Visible = true;
            this.Size = new Size(1234, 732);
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            Size = new Size(640, 578);

            MostrarEmpleados();
        }

        public void MostrarEmpleados()
        {
            dgvEmpleados.DataSource = B_Empleados.B_MostrarEmpleados();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarEmpleado();
                MostrarEmpleados();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void GuardarEmpleado()
        {
            string strSexo = "";
            switch (cmbSexo.Text)
            {
                case "Masculino":
                    strSexo = "M";
                    break;

                case "Femenino":
                    strSexo = "F";
                    break;
            }

            E_Empleados.Nombre = txtNombre.Text;
            E_Empleados.Apellido = txtApellido.Text;
            E_Empleados.Direccion = txtDireccion.Text;
            E_Empleados.Cedula = txtCedula.Text;
            E_Empleados.Telefono = txtTelefono.Text;
            E_Empleados.CorreoElectronico = txtCorreoElectronico.Text;
            E_Empleados.IdCargo = Convert.ToInt32(txtCargo.Text);
            E_Empleados.Sexo = strSexo;
            E_Empleados.Fecha = DateTime.Now.Date;

            if (B_Empleados.B_InsertarEmpleado(E_Empleados) == 1)
            {
                MessageBox.Show("Nuevo Empleado creado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardarCambiosMod_Click(object sender, EventArgs e)
        {
            try
            {
                ModificarEmpleado();
                MostrarEmpleados();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void ModificarEmpleado()
        {
            string strSexo = "";
            switch (cmbSexoMod.Text)
            {
                case "Masculino":
                    strSexo = "M";
                    break;

                case "Femenino":
                    strSexo = "F";
                    break;
            }

            E_Empleados.Id = Convert.ToInt32(txtIdMod.Text);
            E_Empleados.Nombre = txtNombreMod.Text;
            E_Empleados.Apellido = txtApellidoMod.Text;
            E_Empleados.Direccion = txtDireccionMod.Text;
            E_Empleados.Cedula = txtCedulaMod.Text;
            E_Empleados.Telefono = txtTelefonoMod.Text;
            E_Empleados.CorreoElectronico = txtCorreoElectronicoMod.Text;
            E_Empleados.IdCargo = Convert.ToInt32(txtCargoMod.Text);
            E_Empleados.Sexo = strSexo;
            E_Empleados.Fecha = DateTime.Now.Date;

            if (B_Empleados.B_ModificarEmpleado(E_Empleados) == 1)
            {
                MessageBox.Show("Empleado Modificado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvEmpleados.CurrentRow;
            txtIdMod.Text = row.Cells[0].Value.ToString();
            txtNombreMod.Text = row.Cells[1].Value.ToString();
            txtApellidoMod.Text = row.Cells[2].Value.ToString();
            txtDireccionMod.Text = row.Cells[3].Value.ToString();
            txtCedulaMod.Text = row.Cells[4].Value.ToString();
            txtTelefonoMod.Text = row.Cells[5].Value.ToString();
            txtCorreoElectronicoMod.Text = row.Cells[6].Value.ToString();
            txtCargoMod.Text = row.Cells[7].Value.ToString();

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
            cmbSexoMod.Text = strSexo;
        }

        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpleadoBS();
        }

        public void BuscarEmpleadoBS()  //NOTA: bs.Filter = null  --esto es porque el valor del filtro va a persistir incluso cuando cambie la fuente de datos.
        {
            try
            {
                if (chkSoloId.Checked)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvEmpleados.DataSource;
                    bs.Filter = "CONVERT(id, 'System.String') like '%" + txtBuscarEmpleado.Text + "%'";
                    dgvEmpleados.DataSource = bs;
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvEmpleados.DataSource;
                    bs.Filter = "CONVERT(id, 'System.String') like '%" + txtBuscarEmpleado.Text + "%' OR Nombre like '%" + txtBuscarEmpleado.Text + "%' OR Apellido like '%" + txtBuscarEmpleado.Text +
                        "%' OR Direccion like '%" + txtBuscarEmpleado.Text + "%' OR Cedula like '%" + txtBuscarEmpleado.Text +
                        "%' OR Telefono like '%" + txtBuscarEmpleado.Text + "%' OR [Correo Electronico] like '%" + txtBuscarEmpleado.Text + "%'";
                    dgvEmpleados.DataSource = bs;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void chkSoloId_CheckedChanged(object sender, EventArgs e)
        {
            BuscarEmpleadoBS();
            if (chkSoloId.Checked)
            {
                chkSoloId.BackColor = Color.DarkViolet;
                chkSoloId.ForeColor = Color.White;
            }
            else
            {
                chkSoloId.BackColor = Color.White;
                chkSoloId.ForeColor = Color.Black;
            }
        }

        private void btnEliminarMod_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarEmpleado();
                MostrarEmpleados();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public void EliminarEmpleado()
        {
            E_Empleados.Id = Convert.ToInt32(txtIdMod.Text);
            if (MessageBox.Show("Está seguro de eliminar a el Empleado seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (B_Empleados.B_EliminarEmpleado(E_Empleados) == 1)
                {
                    MessageBox.Show("Empleado Eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Empleado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
