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
    public partial class Cargos : Form
    {
        E_Empleados E_Empleados = new E_Empleados();
        B_Empleados B_Empleados = new B_Empleados();
        public Cargos()
        {
            InitializeComponent();
        }

        private void Cargos_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            // TODO: esta línea de código carga datos en la tabla 'aseguradoraBDDataSetCargos.CargoEmp' Puede moverla o quitarla según sea necesario.
            this.cargoEmpTableAdapter.Fill(this.aseguradoraBDDataSetCargos.CargoEmp);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void Agregar()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCargo.Text) || string.IsNullOrWhiteSpace(txtCargo.Text))
                {
                    MessageBox.Show("Complete el campo faltante.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    E_Empleados.Cargo = txtCargo.Text;

                    if (B_Empleados.InssertarCargo(E_Empleados) >= 1)
                    {
                        MessageBox.Show("Cargo añadido satisfactoriamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
