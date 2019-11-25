﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PerlaDelSur_Entity.Clientes;
using CapaNegocio.Clientes;
using CapaNegocio.Siniestro;
using PerlaDelSur_Entity.Siniestro;
using CapaNegocio.RegistroReclamos;
using PerlaDelSur_Entity.RegistroReclamos;
using System.IO;

namespace CapaPresentacion
{
    public partial class frmRegistroDeReclamos : Form
    {
        E_Clientes E_Clientes = new E_Clientes();
        B_Clientes B_Clientes = new B_Clientes();

        B_Siniestro B_Siniestro = new B_Siniestro();

        E_RegistroReclamos E_RegistroReclamos = new E_RegistroReclamos();
        B_RegistroReclamos B_RegistroReclamos = new B_RegistroReclamos();

        int BusquedaDatos = 0;
        int idCliente = 0;
        string strArea = "";

        byte[] imgActaPolicial = null;
        byte[] imgCopiaMatricula = null;
        byte[] imgCopiaCedula = null;

        public frmRegistroDeReclamos()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            lblRegistroReclamos.Text = "Buscar Cliente";
            BusquedaDatos = 1;

            txtBuscarCliente.Visible = true;
            txtBuscarPoliza.Visible = false;
            txtBuscarSiniestro.Visible = false;

            BuscarDatos();
            pnlBuscarDatos.Visible = true;
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            lblRegistroReclamos.Text = "Registro de Reclamos";
            pnlBuscarDatos.Visible = false;
        }

        private void BuscarDatos()
        {
            dgvBuscarDatos.DataSource = null;
            dgvBuscarDatos.DataSource = B_Clientes.B_MostrarClientes();
        }

        private void dgvBuscarClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MostrarDatos(BusquedaDatos);
        }
        private void MostrarDatos(int poliza_cliente)
        {
            if (BusquedaDatos == 1)
            {
                // Cliente
                var row = dgvBuscarDatos.CurrentRow;
                idCliente = Convert.ToInt32(row.Cells[0].Value.ToString());
                txtCedula.Text = row.Cells[4].Value.ToString();

                pnlBuscarDatos.Visible = false;
                lblRegistroReclamos.Text = "Registro de Reclamos";
            }
            else if (BusquedaDatos == 2)
            {
                // Poliza
                var row = dgvBuscarDatos.CurrentRow;
                txtNumPoliza.Text = row.Cells[0].Value.ToString();
                strArea = row.Cells[2].Value.ToString();

                pnlBuscarDatos.Visible = false;
                lblRegistroReclamos.Text = "Registro de Reclamos";
            }
            else if (BusquedaDatos == 3)
            {
                var row = dgvBuscarDatos.CurrentRow;
                txtIdSinietro.Text = row.Cells[0].Value.ToString();

                pnlBuscarDatos.Visible = false;
                lblRegistroReclamos.Text = "Registro de Reclamos";
            }

        }

        private void btnBuscarPoliza_Click(object sender, EventArgs e)
        {
            txtBuscarPoliza.Visible = true;
            txtBuscarSiniestro.Visible = false;
            txtBuscarCliente.Visible = false;

            BuscarPoliza();
        }
        private void BuscarPoliza()
        {
            if (!string.IsNullOrEmpty(txtCedula.Text) || !string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                BusquedaDatos = 2;
                lblRegistroReclamos.Text = "Buscar Póliza";

                dgvBuscarDatos.DataSource = null;

                E_RegistroReclamos.IdCliente = idCliente;
                dgvBuscarDatos.DataSource = B_RegistroReclamos.B_CargarPolizaCliente(E_RegistroReclamos);

                if (dgvBuscarDatos.Rows.Count > 0)
                {
                    pnlBuscarDatos.Visible = true;
                }
                else
                {
                    MessageBox.Show("El Cliente seleccionado no tiene polizas activas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Cliente para poder mostrar sus polizas activas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnIdSiniestro_Click(object sender, EventArgs e)
        {
            BusquedaDatos = 3;
            lblRegistroReclamos.Text = "Buscar Póliza";

            txtBuscarSiniestro.Visible = true;
            txtBuscarPoliza.Visible = false;
            txtBuscarCliente.Visible = false;

            BuscarSiniestro();

        }
        private void BuscarSiniestro()
        {
            dgvBuscarDatos.DataSource = null;

            dgvBuscarDatos.DataSource = B_Siniestro.B_MostrarSiniestro();
            pnlBuscarDatos.Visible = true;
        }

        private void btnBuscar_ftcCopiaActaPolicial_Click_1(object sender, EventArgs e)
        {
            string strFotoCopia = BuscarFotoCopia();
            if (!strFotoCopia.Equals(""))
            {
                txtActaPolicial.Text = strFotoCopia;
                imgActaPolicial = ImageConvert(txtActaPolicial.Text);
            }
        }
        private string BuscarFotoCopia()
        {
            string directory = "";
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png|Imagenes BMP|*.bmp|Imagenes GIF|*.gif|Imagenes TIFF|*.tif|Todo |*.*";
            OFD.FilterIndex = 1;

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                directory = OFD.FileName;
                picPreviewImg.LoadAsync(directory);
            }
            return directory;
        }

        private void btnBuscar_ftcCopiaCedula_Click(object sender, EventArgs e)
        {
            string strFotoCopia = BuscarFotoCopia();
            if (!strFotoCopia.Equals(""))
            {
                txtCopiaCedula.Text = strFotoCopia;
                imgCopiaCedula = ImageConvert(txtCopiaCedula.Text);
            }
        }

        private void btnBuscar_ftcCopiaDeLaMatricula_Click(object sender, EventArgs e)
        {
            string strFotoCopia = BuscarFotoCopia();
            if (!strFotoCopia.Equals(""))
            {
                txtCopiaMatricula.Text = strFotoCopia;
                imgCopiaMatricula = ImageConvert(txtCopiaMatricula.Text);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarReclamacion();
        }
        
        private void GuardarReclamacion()
        {
            E_RegistroReclamos.Area = strArea;

            E_RegistroReclamos.IdCliente = idCliente;
            E_RegistroReclamos.IdSiniestro = Convert.ToInt32(txtIdSinietro.Text);
            E_RegistroReclamos.IdPoliza = Convert.ToInt32(txtNumPoliza.Text);
            E_RegistroReclamos.ActaPolicial = imgActaPolicial;
            E_RegistroReclamos.CopiaMatricula = imgCopiaMatricula;
            E_RegistroReclamos.CopiaCedula = imgCopiaCedula;
            E_RegistroReclamos.CostoEstimado = CostoEstimado(txtCostoEstimado.Text);
            E_RegistroReclamos.FechaHora = DateTime.Now;

            if (B_RegistroReclamos.B_GuardarReclamo(E_RegistroReclamos) == 1)
            {
                MessageBox.Show("Reclamo guardado satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private decimal CostoEstimado(string costEstimado)
        {
            decimal value = 0.0m;
            if (!string.IsNullOrEmpty(costEstimado) || !string.IsNullOrWhiteSpace(costEstimado))
            {
                value = Convert.ToDecimal(costEstimado);
            }

            return value;
        }

        private byte[] ImageConvert(string ImagLoc)
        {
            byte[] img = null;
            FileStream fs = new FileStream(ImagLoc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            return img;
        }

       

        private void txtBuscarSiniestro_TextChanged(object sender, EventArgs e)
        {
            BuscarSiniestroB();
        }

        private void txtBuscarPoliza_TextChanged(object sender, EventArgs e)
        {
            BuscarPolizaB();
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            BuscarClienteB();
        }
        public void BuscarClienteB()
        {
            try
            {
                if (chkSoloId.Checked)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvBuscarDatos.DataSource;
                    bs.Filter = "CONVERT(id, 'System.String') like '%" + txtBuscarCliente.Text + "%'";
                    dgvBuscarDatos.DataSource = bs;
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvBuscarDatos.DataSource;
                    bs.Filter = "CONVERT(id, 'System.String') like '%" + txtBuscarCliente.Text + "%' OR Nombre like '%" +
                        txtBuscarCliente.Text + "%' OR Apellido like '%" + txtBuscarCliente.Text +
                        "%' OR Direccion like '%" + txtBuscarCliente.Text + "%' OR Cedula like '%" + txtBuscarCliente.Text +
                        "%' OR Telefono like '%" + txtBuscarCliente.Text + "%' OR [Correo Electronico] like '%" + txtBuscarCliente.Text + "%'";
                    dgvBuscarDatos.DataSource = bs;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void BuscarSiniestroB()
        {
            try
            {
                if (chkSoloId.Checked)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvBuscarDatos.DataSource;
                    bs.Filter = "CONVERT(id, 'System.String') like '%" + txtBuscarSiniestro.Text + "%'";
                    dgvBuscarDatos.DataSource = bs;
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvBuscarDatos.DataSource;
                    bs.Filter = "CONVERT(id, 'System.String') like '%" + txtBuscarSiniestro.Text + "%' OR CONVERT(id_Cliente, 'System.String') like '%" +
                        txtBuscarSiniestro.Text + "%' OR CONVERT(id_Empleado, 'System.String') like '%" + txtBuscarSiniestro.Text +
                        "%' OR Siniestro like '%" + txtBuscarSiniestro.Text + "%' OR CONVERT(FechaHora, 'System.String') like '%" + txtBuscarSiniestro.Text +
                        "%'";
                    dgvBuscarDatos.DataSource = bs;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void BuscarPolizaB()
        {
            try
            {
                if (chkSoloId.Checked)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvBuscarDatos.DataSource;
                    bs.Filter = "CONVERT(id, 'System.String') like '%" + txtBuscarPoliza.Text + "%'";
                    dgvBuscarDatos.DataSource = bs;
                }
                else
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dgvBuscarDatos.DataSource;
                    bs.Filter = "CONVERT([Núm Poliza], 'System.String') like '%" + txtBuscarPoliza.Text + "%' OR [Nombre del Seguro] like '%" +
                        txtBuscarPoliza.Text + "%' OR Area like '%" + txtBuscarPoliza.Text + "%'";
                    dgvBuscarDatos.DataSource = bs;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            csLimpiar L = new csLimpiar();
            L.BorrarCamposGBx(groupBox1);

            BusquedaDatos = 0;
            idCliente = 0;
            strArea = "";

            imgActaPolicial = null;
            imgCopiaMatricula = null;
            imgCopiaCedula = null;
            picPreviewImg.Image = null;
        }
    }
}
