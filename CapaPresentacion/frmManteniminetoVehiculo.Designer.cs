namespace CapaPresentacion
{
    partial class frmManteniminetoVehiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManteniminetoVehiculo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlModificar = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlBuscarCliente = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBuscarClientes = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUso = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtCarroceria = new System.Windows.Forms.TextBox();
            this.txtCilindros = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.mostrarDetalleSegurosVehiculosClienteResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombredelSeguroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcadeVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.añoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cilindrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carroceriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSoloId = new System.Windows.Forms.CheckBox();
            this.pnlModificar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlBuscarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarDetalleSegurosVehiculosClienteResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlModificar
            // 
            this.pnlModificar.Controls.Add(this.groupBox2);
            this.pnlModificar.Location = new System.Drawing.Point(14, 15);
            this.pnlModificar.Name = "pnlModificar";
            this.pnlModificar.Size = new System.Drawing.Size(1166, 582);
            this.pnlModificar.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlBuscarCliente);
            this.groupBox2.Controls.Add(this.dgvVehiculos);
            this.groupBox2.Controls.Add(this.btnGuardarCambios);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtUso);
            this.groupBox2.Controls.Add(this.txtCategoria);
            this.groupBox2.Controls.Add(this.txtCarroceria);
            this.groupBox2.Controls.Add(this.txtCilindros);
            this.groupBox2.Controls.Add(this.txtAno);
            this.groupBox2.Controls.Add(this.txtMatricula);
            this.groupBox2.Controls.Add(this.txtModelo);
            this.groupBox2.Controls.Add(this.txtMarca);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1145, 567);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // pnlBuscarCliente
            // 
            this.pnlBuscarCliente.Controls.Add(this.chkSoloId);
            this.pnlBuscarCliente.Controls.Add(this.lblCerrar);
            this.pnlBuscarCliente.Controls.Add(this.label1);
            this.pnlBuscarCliente.Controls.Add(this.dgvBuscarClientes);
            this.pnlBuscarCliente.Controls.Add(this.txtBuscar);
            this.pnlBuscarCliente.Controls.Add(this.label2);
            this.pnlBuscarCliente.Location = new System.Drawing.Point(6, 42);
            this.pnlBuscarCliente.Name = "pnlBuscarCliente";
            this.pnlBuscarCliente.Size = new System.Drawing.Size(636, 514);
            this.pnlBuscarCliente.TabIndex = 210;
            this.pnlBuscarCliente.Visible = false;
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCerrar.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.Location = new System.Drawing.Point(601, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(35, 36);
            this.lblCerrar.TabIndex = 107;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 56);
            this.label1.TabIndex = 104;
            // 
            // dgvBuscarClientes
            // 
            this.dgvBuscarClientes.AllowUserToAddRows = false;
            this.dgvBuscarClientes.AllowUserToDeleteRows = false;
            this.dgvBuscarClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBuscarClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBuscarClientes.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvBuscarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBuscarClientes.Location = new System.Drawing.Point(0, 92);
            this.dgvBuscarClientes.Name = "dgvBuscarClientes";
            this.dgvBuscarClientes.ReadOnly = true;
            this.dgvBuscarClientes.Size = new System.Drawing.Size(636, 422);
            this.dgvBuscarClientes.TabIndex = 0;
            this.dgvBuscarClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarClientes_CellDoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(82, 43);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(336, 43);
            this.txtBuscar.TabIndex = 103;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(23, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar Cliente";
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.AutoGenerateColumns = false;
            this.dgvVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVehiculos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVehiculos.BackgroundColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColum,
            this.nombredelSeguroDataGridViewTextBoxColumn,
            this.marcadeVehiculoDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.añoDataGridViewTextBoxColumn,
            this.cilindrosDataGridViewTextBoxColumn,
            this.carroceriaDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.usoDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dgvVehiculos.DataSource = this.mostrarDetalleSegurosVehiculosClienteResultBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehiculos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVehiculos.Location = new System.Drawing.Point(6, 96);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVehiculos.Size = new System.Drawing.Size(636, 460);
            this.dgvVehiculos.TabIndex = 12;
            this.dgvVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculos_CellClick);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.White;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.Crimson;
            this.btnGuardarCambios.Location = new System.Drawing.Point(844, 485);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(282, 74);
            this.btnGuardarCambios.TabIndex = 10;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label20.Location = new System.Drawing.Point(657, 372);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(170, 36);
            this.label20.TabIndex = 13;
            this.label20.Text = "Categoria:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label19.Location = new System.Drawing.Point(657, 323);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(177, 36);
            this.label19.TabIndex = 13;
            this.label19.Text = "Carroceria:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label17.Location = new System.Drawing.Point(657, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 36);
            this.label17.TabIndex = 13;
            this.label17.Text = "Cilindros:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label16.Location = new System.Drawing.Point(657, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 36);
            this.label16.TabIndex = 13;
            this.label16.Text = "Año:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label15.Location = new System.Drawing.Point(657, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 36);
            this.label15.TabIndex = 13;
            this.label15.Text = "Matricula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(44, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cliente:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label14.Location = new System.Drawing.Point(657, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 36);
            this.label14.TabIndex = 13;
            this.label14.Text = "Modelo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label13.Location = new System.Drawing.Point(657, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 72);
            this.label13.TabIndex = 13;
            this.label13.Text = "Marca del\r\nVehiculo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(216, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(465, 36);
            this.label10.TabIndex = 11;
            this.label10.Text = "Modificar Vehiculos de Cliente:";
            // 
            // txtUso
            // 
            this.txtUso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUso.Location = new System.Drawing.Point(844, 418);
            this.txtUso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUso.Name = "txtUso";
            this.txtUso.Size = new System.Drawing.Size(282, 43);
            this.txtUso.TabIndex = 7;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoria.Location = new System.Drawing.Point(844, 368);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(282, 43);
            this.txtCategoria.TabIndex = 3;
            // 
            // txtCarroceria
            // 
            this.txtCarroceria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarroceria.Location = new System.Drawing.Point(844, 318);
            this.txtCarroceria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCarroceria.Name = "txtCarroceria";
            this.txtCarroceria.Size = new System.Drawing.Size(282, 43);
            this.txtCarroceria.TabIndex = 3;
            // 
            // txtCilindros
            // 
            this.txtCilindros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCilindros.Location = new System.Drawing.Point(844, 268);
            this.txtCilindros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCilindros.Name = "txtCilindros";
            this.txtCilindros.Size = new System.Drawing.Size(282, 43);
            this.txtCilindros.TabIndex = 3;
            // 
            // txtAno
            // 
            this.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAno.Location = new System.Drawing.Point(844, 218);
            this.txtAno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(282, 43);
            this.txtAno.TabIndex = 3;
            // 
            // txtMatricula
            // 
            this.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatricula.Location = new System.Drawing.Point(844, 168);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(282, 43);
            this.txtMatricula.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModelo.Location = new System.Drawing.Point(844, 118);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(282, 43);
            this.txtModelo.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarca.Location = new System.Drawing.Point(844, 65);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(282, 43);
            this.txtMarca.TabIndex = 0;
            // 
            // txtCliente
            // 
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.Location = new System.Drawing.Point(176, 45);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(278, 43);
            this.txtCliente.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label18.Location = new System.Drawing.Point(657, 424);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 36);
            this.label18.TabIndex = 13;
            this.label18.Text = "Uso:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Crimson;
            this.btnBuscarCliente.Location = new System.Drawing.Point(462, 45);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(180, 43);
            this.btnBuscarCliente.TabIndex = 211;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // mostrarDetalleSegurosVehiculosClienteResultBindingSource
            // 
            this.mostrarDetalleSegurosVehiculosClienteResultBindingSource.DataSource = typeof(CapaNegocio.MostrarDetalleSegurosVehiculosCliente_Result);
            // 
            // IdColum
            // 
            this.IdColum.DataPropertyName = "Id";
            this.IdColum.HeaderText = "id";
            this.IdColum.Name = "IdColum";
            this.IdColum.ReadOnly = true;
            this.IdColum.Visible = false;
            this.IdColum.Width = 49;
            // 
            // nombredelSeguroDataGridViewTextBoxColumn
            // 
            this.nombredelSeguroDataGridViewTextBoxColumn.DataPropertyName = "Nombre_del_Seguro";
            this.nombredelSeguroDataGridViewTextBoxColumn.HeaderText = "Nombre del Seguro";
            this.nombredelSeguroDataGridViewTextBoxColumn.Name = "nombredelSeguroDataGridViewTextBoxColumn";
            this.nombredelSeguroDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombredelSeguroDataGridViewTextBoxColumn.Width = 120;
            // 
            // marcadeVehiculoDataGridViewTextBoxColumn
            // 
            this.marcadeVehiculoDataGridViewTextBoxColumn.DataPropertyName = "Marca_de_Vehiculo";
            this.marcadeVehiculoDataGridViewTextBoxColumn.HeaderText = "Marca de Vehiculo";
            this.marcadeVehiculoDataGridViewTextBoxColumn.Name = "marcadeVehiculoDataGridViewTextBoxColumn";
            this.marcadeVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcadeVehiculoDataGridViewTextBoxColumn.Width = 167;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn.Width = 93;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.ReadOnly = true;
            this.matriculaDataGridViewTextBoxColumn.Width = 107;
            // 
            // añoDataGridViewTextBoxColumn
            // 
            this.añoDataGridViewTextBoxColumn.DataPropertyName = "Año";
            this.añoDataGridViewTextBoxColumn.HeaderText = "Año";
            this.añoDataGridViewTextBoxColumn.Name = "añoDataGridViewTextBoxColumn";
            this.añoDataGridViewTextBoxColumn.ReadOnly = true;
            this.añoDataGridViewTextBoxColumn.Width = 66;
            // 
            // cilindrosDataGridViewTextBoxColumn
            // 
            this.cilindrosDataGridViewTextBoxColumn.DataPropertyName = "Cilindros";
            this.cilindrosDataGridViewTextBoxColumn.HeaderText = "Cilindros";
            this.cilindrosDataGridViewTextBoxColumn.Name = "cilindrosDataGridViewTextBoxColumn";
            this.cilindrosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carroceriaDataGridViewTextBoxColumn
            // 
            this.carroceriaDataGridViewTextBoxColumn.DataPropertyName = "Carroceria";
            this.carroceriaDataGridViewTextBoxColumn.HeaderText = "Carroceria";
            this.carroceriaDataGridViewTextBoxColumn.Name = "carroceriaDataGridViewTextBoxColumn";
            this.carroceriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.carroceriaDataGridViewTextBoxColumn.Width = 117;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoriaDataGridViewTextBoxColumn.Width = 112;
            // 
            // usoDataGridViewTextBoxColumn
            // 
            this.usoDataGridViewTextBoxColumn.DataPropertyName = "Uso";
            this.usoDataGridViewTextBoxColumn.HeaderText = "Uso";
            this.usoDataGridViewTextBoxColumn.Name = "usoDataGridViewTextBoxColumn";
            this.usoDataGridViewTextBoxColumn.ReadOnly = true;
            this.usoDataGridViewTextBoxColumn.Width = 60;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "Nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaDataGridViewTextBoxColumn.Width = 71;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Visible = false;
            this.estadoDataGridViewTextBoxColumn.Width = 84;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 66;
            // 
            // chkSoloId
            // 
            this.chkSoloId.AutoSize = true;
            this.chkSoloId.BackColor = System.Drawing.Color.White;
            this.chkSoloId.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoloId.ForeColor = System.Drawing.Color.Crimson;
            this.chkSoloId.Location = new System.Drawing.Point(425, 52);
            this.chkSoloId.Name = "chkSoloId";
            this.chkSoloId.Size = new System.Drawing.Size(108, 32);
            this.chkSoloId.TabIndex = 108;
            this.chkSoloId.Text = "solo Id";
            this.chkSoloId.UseVisualStyleBackColor = false;
            // 
            // frmManteniminetoVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1188, 605);
            this.Controls.Add(this.pnlModificar);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmManteniminetoVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mantenimiento Vehiculo";
            this.Load += new System.EventHandler(this.frmManteniminetoVehiculo_Load);
            this.pnlModificar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlBuscarCliente.ResumeLayout(false);
            this.pnlBuscarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarDetalleSegurosVehiculosClienteResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlModificar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUso;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtCarroceria;
        private System.Windows.Forms.TextBox txtCilindros;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Panel pnlBuscarCliente;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBuscarClientes;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.BindingSource mostrarDetalleSegurosVehiculosClienteResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredelSeguroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcadeVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn añoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cilindrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carroceriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chkSoloId;
    }
}