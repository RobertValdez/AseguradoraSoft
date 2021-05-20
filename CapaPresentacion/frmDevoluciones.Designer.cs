namespace CapaPresentacion
{
    partial class frmDevoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevoluciones));
            this.pnlBuscarClientes = new System.Windows.Forms.Panel();
            this.chkSoloId = new System.Windows.Forms.CheckBox();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.dgvBuscarClientes = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDevoluciones = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtADevolver = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidPoliza = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReclamacion = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdReclamaciones = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pnlBuscarClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReclamacion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBuscarClientes
            // 
            this.pnlBuscarClientes.Controls.Add(this.chkSoloId);
            this.pnlBuscarClientes.Controls.Add(this.lblCerrar);
            this.pnlBuscarClientes.Controls.Add(this.dgvBuscarClientes);
            this.pnlBuscarClientes.Controls.Add(this.txtBuscar);
            this.pnlBuscarClientes.Controls.Add(this.label6);
            this.pnlBuscarClientes.Location = new System.Drawing.Point(12, 56);
            this.pnlBuscarClientes.Name = "pnlBuscarClientes";
            this.pnlBuscarClientes.Size = new System.Drawing.Size(819, 527);
            this.pnlBuscarClientes.TabIndex = 24;
            this.pnlBuscarClientes.Visible = false;
            // 
            // chkSoloId
            // 
            this.chkSoloId.AutoSize = true;
            this.chkSoloId.BackColor = System.Drawing.Color.White;
            this.chkSoloId.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoloId.ForeColor = System.Drawing.Color.Crimson;
            this.chkSoloId.Location = new System.Drawing.Point(537, 24);
            this.chkSoloId.Name = "chkSoloId";
            this.chkSoloId.Size = new System.Drawing.Size(108, 32);
            this.chkSoloId.TabIndex = 110;
            this.chkSoloId.Text = "solo Id";
            this.chkSoloId.UseVisualStyleBackColor = false;
            this.chkSoloId.CheckedChanged += new System.EventHandler(this.chkSoloId_CheckedChanged);
            // 
            // lblCerrar
            // 
            this.lblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCerrar.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.Location = new System.Drawing.Point(780, 2);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(35, 36);
            this.lblCerrar.TabIndex = 16;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
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
            this.dgvBuscarClientes.Location = new System.Drawing.Point(0, 69);
            this.dgvBuscarClientes.Name = "dgvBuscarClientes";
            this.dgvBuscarClientes.ReadOnly = true;
            this.dgvBuscarClientes.Size = new System.Drawing.Size(819, 458);
            this.dgvBuscarClientes.TabIndex = 0;
            this.dgvBuscarClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarClientes_CellClick);
            this.dgvBuscarClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarClientes_CellDoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(186, 23);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(344, 33);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label6.Location = new System.Drawing.Point(99, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 56);
            this.label6.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(561, 224);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 33);
            this.button2.TabIndex = 31;
            this.button2.Text = "Buscar Fotocopia";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.White;
            this.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Crimson;
            this.btnBuscarCliente.Location = new System.Drawing.Point(520, 64);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(147, 44);
            this.btnBuscarCliente.TabIndex = 32;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label13
            // 
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label13.Location = new System.Drawing.Point(454, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 56);
            this.label13.TabIndex = 30;
            // 
            // lblDevoluciones
            // 
            this.lblDevoluciones.AutoSize = true;
            this.lblDevoluciones.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevoluciones.ForeColor = System.Drawing.Color.Crimson;
            this.lblDevoluciones.Location = new System.Drawing.Point(370, 9);
            this.lblDevoluciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDevoluciones.Name = "lblDevoluciones";
            this.lblDevoluciones.Size = new System.Drawing.Size(200, 36);
            this.lblDevoluciones.TabIndex = 29;
            this.lblDevoluciones.Text = "Desembolsos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(135, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cédula del Cliente:";
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.Location = new System.Drawing.Point(353, 112);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(314, 33);
            this.txtCedula.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(273, 195);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 24);
            this.label14.TabIndex = 28;
            this.label14.Text = "Acta policial:";
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Location = new System.Drawing.Point(261, 224);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(295, 33);
            this.txtApellido.TabIndex = 26;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 153);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(819, 179);
            this.dgvDatos.TabIndex = 33;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // txtADevolver
            // 
            this.txtADevolver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtADevolver.Location = new System.Drawing.Point(953, 151);
            this.txtADevolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtADevolver.MaxLength = 10;
            this.txtADevolver.Name = "txtADevolver";
            this.txtADevolver.Size = new System.Drawing.Size(223, 33);
            this.txtADevolver.TabIndex = 25;
            this.txtADevolver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtADevolver.TextChanged += new System.EventHandler(this.txtADevolver_TextChanged);
            // 
            // txtMotivo
            // 
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotivo.Location = new System.Drawing.Point(863, 225);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(314, 219);
            this.txtMotivo.TabIndex = 25;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Crimson;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(959, 523);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(217, 60);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Desembolsar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(863, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Motivo o Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(934, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Monto a Desembolsar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(894, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "RD$";
            // 
            // txtidPoliza
            // 
            this.txtidPoliza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidPoliza.Location = new System.Drawing.Point(879, 79);
            this.txtidPoliza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtidPoliza.Name = "txtidPoliza";
            this.txtidPoliza.ReadOnly = true;
            this.txtidPoliza.Size = new System.Drawing.Size(95, 33);
            this.txtidPoliza.TabIndex = 25;
            this.txtidPoliza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(877, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Id Poliza:";
            // 
            // dgvReclamacion
            // 
            this.dgvReclamacion.AllowUserToAddRows = false;
            this.dgvReclamacion.AllowUserToDeleteRows = false;
            this.dgvReclamacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReclamacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReclamacion.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvReclamacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReclamacion.Location = new System.Drawing.Point(15, 364);
            this.dgvReclamacion.Name = "dgvReclamacion";
            this.dgvReclamacion.ReadOnly = true;
            this.dgvReclamacion.Size = new System.Drawing.Size(816, 219);
            this.dgvReclamacion.TabIndex = 33;
            this.dgvReclamacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReclamacion_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(143, 335);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Reclamaciones del Cliente:";
            // 
            // txtIdReclamaciones
            // 
            this.txtIdReclamaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdReclamaciones.Location = new System.Drawing.Point(982, 79);
            this.txtIdReclamaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdReclamaciones.Name = "txtIdReclamaciones";
            this.txtIdReclamaciones.ReadOnly = true;
            this.txtIdReclamaciones.Size = new System.Drawing.Size(194, 33);
            this.txtIdReclamaciones.TabIndex = 25;
            this.txtIdReclamaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(980, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Id Reclamación:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(1050, 474);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 41);
            this.btnLimpiar.TabIndex = 34;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Gray;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(879, 526);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(71, 57);
            this.btnImprimir.TabIndex = 254;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 597);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pnlBuscarClientes);
            this.Controls.Add(this.dgvReclamacion);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblDevoluciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtIdReclamaciones);
            this.Controls.Add(this.txtidPoliza);
            this.Controls.Add(this.txtADevolver);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desembolsos";
            this.Load += new System.EventHandler(this.frmDevoluciones_Load);
            this.pnlBuscarClientes.ResumeLayout(false);
            this.pnlBuscarClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReclamacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBuscarClientes;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.DataGridView dgvBuscarClientes;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDevoluciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtADevolver;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidPoliza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvReclamacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdReclamaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox chkSoloId;
        private System.Windows.Forms.Button btnImprimir;
    }
}