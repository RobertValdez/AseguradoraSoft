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
            Size = new Size(715, 701);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            pnlNuevo.Visible = false;
            pnlModificar.Visible = true;
            this.Size = new Size(1234, 732);

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            Size = new Size(715, 701);

            MostrarEmpleados();
            CargarCargos();
            CargarCargosMod();
        }

        private void CargarCargos()
        {
            dtCargos = B_Empleados.B_CargarCargos();

            List<string> list = new List<string>();

            foreach (DataRow dr in dtCargos.Rows)
            {
                list.Add(dr[1].ToString());
            }

            cmbCargo.DataSource = list;
        }

        private void CargarCargosMod()
        {
            dtCargos = B_Empleados.B_CargarCargos();

            List<string> list = new List<string>();

            foreach (DataRow dr in dtCargos.Rows)
            {
                list.Add(dr[1].ToString());
            }

            cmbCargoMod.DataSource = list;
        }

        DataTable dtCargos = new DataTable();
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
            QuitarErrorProviderNuevo();

            mskTelefonoValidar();
            mskCedulaValidar();
            ValidarCamposNuevo();

            if (string.IsNullOrEmpty(txtNombre.Text) || mskCedula.MaskFull == false || mskTelefono.MaskFull == false
              || string.IsNullOrWhiteSpace(txtNombre.Text)
              || (string.IsNullOrEmpty(txtApellido.Text)
              || string.IsNullOrWhiteSpace(txtApellido.Text))
              || (string.IsNullOrEmpty(txtDireccion.Text)
              || string.IsNullOrWhiteSpace(txtDireccion.Text))
              || (string.IsNullOrEmpty(txtCorreoElectronico.Text)
              || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text))
              || (string.IsNullOrEmpty(cmbCargo.Text)
              || string.IsNullOrWhiteSpace(cmbCargo.Text))
              || (string.IsNullOrEmpty(cmbSexo.Text)
              || string.IsNullOrWhiteSpace(cmbSexo.Text)))
            {
                MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataView dv = new DataView(dtCargos);

                dv.RowFilter = "[Cargo] = '"+cmbCargo.Text+"'";

               int idCargos = (int)dv[0]["id"];

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
                E_Empleados.Cedula = mskCedula.Text;
                E_Empleados.Telefono = mskTelefono.Text;
                E_Empleados.CorreoElectronico = txtCorreoElectronico.Text;
                E_Empleados.IdCargo = idCargos;
                E_Empleados.Sexo = strSexo;
                E_Empleados.Fecha = DateTime.Now.Date;

                if (B_Empleados.B_InsertarEmpleado(E_Empleados) == 1)
                {
                    MessageBox.Show("Nuevo Empleado creado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool ValidarCamposMod()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtNombreMod.Text)
               || string.IsNullOrWhiteSpace(txtNombreMod.Text))
            {
                ok = false;
                errorProvider1.SetError(txtNombreMod, "Campo obligatorio");
                txtNombreMod.Text = "";
            }

            if (string.IsNullOrEmpty(txtApellidoMod.Text)
                || string.IsNullOrWhiteSpace(txtApellidoMod.Text))
            {
                ok = false;
                errorProvider1.SetError(txtApellidoMod, "Campo obligatorio");
                txtApellidoMod.Text = "";
            }

            if (string.IsNullOrEmpty(txtDireccionMod.Text)
                || string.IsNullOrWhiteSpace(txtDireccionMod.Text))
            {
                ok = false;
                errorProvider1.SetError(txtDireccionMod, "Campo obligatorio");
                txtDireccionMod.Text = "";
            }

            if (string.IsNullOrEmpty(txtCorreoElectronicoMod.Text)
                || string.IsNullOrWhiteSpace(txtCorreoElectronicoMod.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCorreoElectronicoMod, "Campo obligatorio");
                txtCorreoElectronicoMod.Text = "";
            }

            if (string.IsNullOrEmpty(cmbCargoMod.Text)
                || string.IsNullOrWhiteSpace(cmbCargoMod.Text))
            {
                ok = false;
                errorProvider1.SetError(cmbCargoMod, "Campo obligatorio");
                cmbCargoMod.Text = "";
            }

            if (string.IsNullOrEmpty(cmbSexoMod.Text)
               || string.IsNullOrWhiteSpace(cmbSexoMod.Text))
            {
                ok = false;
                errorProvider1.SetError(cmbSexoMod, "Campo obligatorio");
                cmbSexoMod.Text = "";
            }

            return ok;
        }


        private void QuitarErrorProviderNuevo()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(txtCorreoElectronico, "");
            errorProvider1.SetError(cmbCargo, "");
            errorProvider1.SetError(cmbSexo, "");
            errorProvider1.SetError(mskCedula, "");
            errorProvider1.SetError(mskTelefono, "");
        }

        private void mskCedula_Validating_1(object sender, CancelEventArgs e)
        {
            mskCedulaValidar();
        }

        private bool mskCedulaValidar() 
        {
            bool valor = false;
            if (mskCedula.MaskFull == false)
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

        private void mskTelefono_Validating(object sender, CancelEventArgs e)
        {
            mskTelefonoValidar();
        }

        private bool mskTelefonoValidar()
        {
            bool valor = false;

            if (mskTelefono.MaskFull == false)
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

        private bool ValidarCamposNuevo()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txtNombre.Text)
               || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Campo obligatorio");
                txtNombre.Text = "";
            }

            if (string.IsNullOrEmpty(txtApellido.Text)
                || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                ok = false;
                errorProvider1.SetError(txtApellido, "Campo obligatorio");
                txtApellido.Text = "";
            }

            if (string.IsNullOrEmpty(txtDireccion.Text)
                || string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                ok = false;
                errorProvider1.SetError(txtDireccion, "Campo obligatorio");
                txtDireccion.Text = "";
            }

            if (string.IsNullOrEmpty(txtCorreoElectronico.Text)
                || string.IsNullOrWhiteSpace(txtCorreoElectronico.Text))
            {
                ok = false;
                errorProvider1.SetError(txtCorreoElectronico, "Campo obligatorio");
                txtCorreoElectronico.Text = "";
            }

            if (string.IsNullOrEmpty(cmbCargo.Text)
                || string.IsNullOrWhiteSpace(cmbCargo.Text))
            {
                ok = false;
                errorProvider1.SetError(cmbCargo, "Campo obligatorio");
                cmbCargo.Text = "";
            }

            if (string.IsNullOrEmpty(cmbSexo.Text)
               || string.IsNullOrWhiteSpace(cmbSexo.Text))
            {
                ok = false;
                errorProvider1.SetError(cmbSexo, "Campo obligatorio");
                cmbSexo.Text = "";
            }

            return ok;
        }


        private void QuitarErrorProviderMod()
        {
            errorProvider1.SetError(txtNombreMod, "");
            errorProvider1.SetError(txtApellidoMod, "");
            errorProvider1.SetError(txtDireccionMod, "");
            errorProvider1.SetError(txtCorreoElectronicoMod, "");
            errorProvider1.SetError(cmbCargoMod, "");
            errorProvider1.SetError(cmbSexoMod, "");
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
            QuitarErrorProviderMod();
            ValidarCamposMod();
            mskCedulaModValidar();
            mskTelefonoModValidar();

            if (string.IsNullOrEmpty(txtNombreMod.Text) || txtCedulaMod.MaskFull == false || txtTelefonoMod.MaskFull == false
              || string.IsNullOrWhiteSpace(txtNombreMod.Text)
              || (string.IsNullOrEmpty(txtApellidoMod.Text)
              || string.IsNullOrWhiteSpace(txtApellidoMod.Text))
              || (string.IsNullOrEmpty(txtDireccionMod.Text)
              || string.IsNullOrWhiteSpace(txtDireccionMod.Text))
              || (string.IsNullOrEmpty(txtCorreoElectronicoMod.Text)
              || string.IsNullOrWhiteSpace(txtCorreoElectronicoMod.Text))
              || (string.IsNullOrEmpty(cmbCargoMod.Text)
              || string.IsNullOrWhiteSpace(cmbCargoMod.Text))
              || (string.IsNullOrEmpty(cmbSexoMod.Text)
              || string.IsNullOrWhiteSpace(cmbSexoMod.Text)))
            {
                MessageBox.Show("Complete los campos faltantes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataView dv = new DataView(dtCargos);

                dv.RowFilter = "[Cargo] = '" + cmbCargoMod.Text + "'";

                int idCargos = (int)dv[0]["id"];

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
            E_Empleados.IdCargo = idCargos;
            E_Empleados.Sexo = strSexo;
            E_Empleados.Fecha = DateTime.Now.Date;

                if (B_Empleados.B_ModificarEmpleado(E_Empleados) == 1)
                {
                    MessageBox.Show("Empleado Modificado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

            dtCargos = B_Empleados.B_CargarCargos();
            DataView dv = new DataView(dtCargos);

            dv.RowFilter = "id = '" + row.Cells[7].Value.ToString() + "'";
            string strCargos = (string)dv[0]["Cargo"];

            cmbCargoMod.Text = strCargos;

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
                chkSoloId.ForeColor = Color.Crimson;
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

        private void txtCedulaMod_Validating(object sender, CancelEventArgs e)
        {
            mskCedulaModValidar();
        }
        private bool mskCedulaModValidar()
        {
            bool valor = false;
            if (txtCedulaMod.MaskFull == false)
            {
                valor = false;
                errorProvider1.SetError(txtCedulaMod, "Complete la Cédula");
            }
            else
            {
                valor = true;
            }

            return valor;
        }

        private void txtTelefonoMod_Validating(object sender, CancelEventArgs e)
        {
            mskTelefonoModValidar();
        }
        private bool mskTelefonoModValidar()
        {
            bool valor = false;

            if (txtTelefonoMod.MaskFull == false)
            {
                valor = false;
                errorProvider1.SetError(txtTelefonoMod, "Complete el Telefono");
            }
            else
            {
                valor = true;
            }
            return valor;
        }
    }
}
