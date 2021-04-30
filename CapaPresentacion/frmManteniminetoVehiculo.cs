using CapaNegocio.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmManteniminetoVehiculo : Form
    {
        public frmManteniminetoVehiculo()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            pnlBuscarCliente.Visible = true;

            idCliente = 0;
            idDetalleVehiculo = 0;
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            pnlBuscarCliente.Visible = false;
        }

        private void frmManteniminetoVehiculo_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        B_Clientes B_Clientes = new B_Clientes();
        private int idCliente;

        private void MostrarClientes()
        {
            dgvBuscarClientes.DataSource = B_Clientes.B_MostrarClientes();
        }

        private void Buscar_MostrarDatosVehiculo()
        {
            using (AseguradoraBDEntities db = new AseguradoraBDEntities())
            {
                dgvVehiculos.DataSource = db.MostrarDetalleSegurosVehiculosCliente(idCliente);
            }
        }

        private void dgvBuscarClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvBuscarClientes.CurrentRow;

            idCliente = Convert.ToInt32(row.Cells[0].Value.ToString());
            txtCliente.Text = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();

            Buscar_MostrarDatosVehiculo();

            pnlBuscarCliente.Visible = false;
        }

        string strNombreSeguro = "";
        int idDetalleVehiculo = 0;
        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvVehiculos.CurrentRow;

            idDetalleVehiculo = (int)row.Cells[0].Value;
            strNombreSeguro = row.Cells[1].Value.ToString();

            txtMarca.Text = row.Cells[2].Value.ToString();
            txtModelo.Text = row.Cells[3].Value.ToString();
            txtMatricula.Text = row.Cells[4].Value.ToString();
            txtAno.Text = row.Cells[5].Value.ToString();
            txtCilindros.Text = row.Cells[6].Value.ToString();
            txtCarroceria.Text = row.Cells[7].Value.ToString();
            txtCategoria.Text = row.Cells[8].Value.ToString();
            txtUso.Text = row.Cells[9].Value.ToString();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (idDetalleVehiculo == 0)
                {
                    MessageBox.Show("Seleccione un Vehiculo e intentelo de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    switch (strNombreSeguro)
                    {
                        case "Seguro a Todo Riesgo":
                            ModificarVehiculoTodoRiesgo();
                            break;
                        case "Seguro Obligatorio":
                            ModificarVehiculoObligatorio();
                            break;
                        case "Seguro Voluntario":
                            ModificarVehiculoVoluntario();
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (Exception) { }
        }

        private void ModificarVehiculoTodoRiesgo()
        {
            using (AseguradoraBDEntities db = new AseguradoraBDEntities())
            {
                detalleSeguroTodoRiesgo dST = db.detalleSeguroTodoRiesgo.Where(d => d.id == idDetalleVehiculo).First();    
                dST.Marca_de_Vehiculo = txtMarca.Text;
                dST.Modelo = txtModelo.Text;
                dST.Matricula = txtMatricula.Text;
                dST.Ano = Convert.ToInt32(txtAno.Text);
                dST.Cilindros = Convert.ToInt32(txtCilindros.Text);
                dST.Carroceria = txtCarroceria.Text;
                dST.Categoria = txtCategoria.Text;
                dST.Uso = txtUso.Text;

                db.Entry(dST).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Datos del vehículo modificados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Buscar_MostrarDatosVehiculo();
        }

        private void ModificarVehiculoObligatorio()
        {
            using (AseguradoraBDEntities db = new AseguradoraBDEntities())
            {
                detalleSeguroObligatorio dST = db.detalleSeguroObligatorio.Where(d => d.id == idDetalleVehiculo).First();
                dST.Marca_de_Vehiculo = txtMarca.Text;
                dST.Modelo = txtModelo.Text;
                dST.Matricula = txtMatricula.Text;
                dST.Ano = Convert.ToInt32(txtAno.Text);
                dST.Cilindros = Convert.ToInt32(txtCilindros.Text);
                dST.Carroceria = txtCarroceria.Text;
                dST.Categoria = txtCategoria.Text;
                dST.Uso = txtUso.Text;

                db.Entry(dST).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Datos del vehículo modificados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
            Buscar_MostrarDatosVehiculo();
        }

        private void ModificarVehiculoVoluntario()
        {
            using (AseguradoraBDEntities db = new AseguradoraBDEntities())
            {
                detalleSeguroVoluntario dST = db.detalleSeguroVoluntario.Where(d => d.Id == idDetalleVehiculo).First();
                dST.Marca_de_Vehiculo = txtMarca.Text;
                dST.Modelo = txtModelo.Text;
                dST.Matricula = txtMatricula.Text;
                dST.Ano = Convert.ToInt32(txtAno.Text);
                dST.Cilindros = Convert.ToInt32(txtCilindros.Text);
                dST.Carroceria = txtCarroceria.Text;
                dST.Categoria = txtCategoria.Text;
                dST.Uso = txtUso.Text;

                db.Entry(dST).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Datos del vehículo modificados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Buscar_MostrarDatosVehiculo();
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
    }
}