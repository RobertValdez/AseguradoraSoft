namespace CapaPresentacion
{
    partial class frmSiniestro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiniestro));
            this.pnlBuscarCliente = new System.Windows.Forms.Panel();
            this.chkSoloId = new System.Windows.Forms.CheckBox();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.dgvBuscarClientes = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlNuevo = new System.Windows.Forms.Panel();
            this.gbxSiniestro = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblRegistroSiniestros = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSiniestro = new System.Windows.Forms.TextBox();
            this.txtPolizasActivas = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlBuscarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarClientes)).BeginInit();
            this.pnlNuevo.SuspendLayout();
            this.gbxSiniestro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBuscarCliente
            // 
            this.pnlBuscarCliente.Controls.Add(this.chkSoloId);
            this.pnlBuscarCliente.Controls.Add(this.lblCerrar);
            this.pnlBuscarCliente.Controls.Add(this.dgvBuscarClientes);
            this.pnlBuscarCliente.Controls.Add(this.txtBuscar);
            this.pnlBuscarCliente.Controls.Add(this.label6);
            this.pnlBuscarCliente.Location = new System.Drawing.Point(12, 60);
            this.pnlBuscarCliente.Name = "pnlBuscarCliente";
            this.pnlBuscarCliente.Size = new System.Drawing.Size(969, 541);
            this.pnlBuscarCliente.TabIndex = 23;
            this.pnlBuscarCliente.Visible = false;
            // 
            // chkSoloId
            // 
            this.chkSoloId.AutoSize = true;
            this.chkSoloId.BackColor = System.Drawing.Color.White;
            this.chkSoloId.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoloId.ForeColor = System.Drawing.Color.Crimson;
            this.chkSoloId.Location = new System.Drawing.Point(568, 30);
            this.chkSoloId.Name = "chkSoloId";
            this.chkSoloId.Size = new System.Drawing.Size(108, 32);
            this.chkSoloId.TabIndex = 109;
            this.chkSoloId.Text = "solo Id";
            this.chkSoloId.UseVisualStyleBackColor = false;
            this.chkSoloId.CheckedChanged += new System.EventHandler(this.chkSoloId_CheckedChanged);
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCerrar.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.Location = new System.Drawing.Point(870, 4);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(35, 36);
            this.lblCerrar.TabIndex = 15;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click_1);
            // 
            // dgvBuscarClientes
            // 
            this.dgvBuscarClientes.AllowUserToAddRows = false;
            this.dgvBuscarClientes.AllowUserToDeleteRows = false;
            this.dgvBuscarClientes.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvBuscarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBuscarClientes.Location = new System.Drawing.Point(0, 73);
            this.dgvBuscarClientes.Name = "dgvBuscarClientes";
            this.dgvBuscarClientes.ReadOnly = true;
            this.dgvBuscarClientes.Size = new System.Drawing.Size(969, 468);
            this.dgvBuscarClientes.TabIndex = 0;
            this.dgvBuscarClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarClientes_CellDoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(203, 30);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(348, 31);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label6.Location = new System.Drawing.Point(129, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 56);
            this.label6.TabIndex = 14;
            // 
            // pnlNuevo
            // 
            this.pnlNuevo.Controls.Add(this.gbxSiniestro);
            this.pnlNuevo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNuevo.Location = new System.Drawing.Point(12, 12);
            this.pnlNuevo.Name = "pnlNuevo";
            this.pnlNuevo.Size = new System.Drawing.Size(1003, 589);
            this.pnlNuevo.TabIndex = 24;
            // 
            // gbxSiniestro
            // 
            this.gbxSiniestro.Controls.Add(this.btnBuscarCliente);
            this.gbxSiniestro.Controls.Add(this.lblRegistroSiniestros);
            this.gbxSiniestro.Controls.Add(this.btnLimpiar);
            this.gbxSiniestro.Controls.Add(this.btnGuardar);
            this.gbxSiniestro.Controls.Add(this.label1);
            this.gbxSiniestro.Controls.Add(this.label14);
            this.gbxSiniestro.Controls.Add(this.label2);
            this.gbxSiniestro.Controls.Add(this.label4);
            this.gbxSiniestro.Controls.Add(this.label3);
            this.gbxSiniestro.Controls.Add(this.label7);
            this.gbxSiniestro.Controls.Add(this.txtSiniestro);
            this.gbxSiniestro.Controls.Add(this.txtPolizasActivas);
            this.gbxSiniestro.Controls.Add(this.txtTelefono);
            this.gbxSiniestro.Controls.Add(this.txtCedula);
            this.gbxSiniestro.Controls.Add(this.txtApellido);
            this.gbxSiniestro.Controls.Add(this.txtNombre);
            this.gbxSiniestro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxSiniestro.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.gbxSiniestro.ForeColor = System.Drawing.Color.Black;
            this.gbxSiniestro.Location = new System.Drawing.Point(19, 3);
            this.gbxSiniestro.Name = "gbxSiniestro";
            this.gbxSiniestro.Size = new System.Drawing.Size(971, 572);
            this.gbxSiniestro.TabIndex = 13;
            this.gbxSiniestro.TabStop = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.White;
            this.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.Crimson;
            this.errorProvider1.SetIconAlignment(this.btnBuscarCliente, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.errorProvider1.SetIconPadding(this.btnBuscarCliente, 1);
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(55, 94);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(141, 58);
            this.btnBuscarCliente.TabIndex = 23;
            this.btnBuscarCliente.Text = "Buscar\r\nCliente";
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click_1);
            // 
            // lblRegistroSiniestros
            // 
            this.lblRegistroSiniestros.AutoSize = true;
            this.lblRegistroSiniestros.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroSiniestros.ForeColor = System.Drawing.Color.Crimson;
            this.lblRegistroSiniestros.Location = new System.Drawing.Point(103, -3);
            this.lblRegistroSiniestros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistroSiniestros.Name = "lblRegistroSiniestros";
            this.lblRegistroSiniestros.Size = new System.Drawing.Size(308, 36);
            this.lblRegistroSiniestros.TabIndex = 11;
            this.lblRegistroSiniestros.Text = "Registro de Siniestros";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Crimson;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(509, 500);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(194, 60);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Crimson;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(708, 500);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(194, 60);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(42, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pólizas del Cliente:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(407, 169);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 30);
            this.label14.TabIndex = 9;
            this.label14.Text = "Siniestro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(207, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(729, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(555, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cédula:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(378, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Apellido:";
            // 
            // txtSiniestro
            // 
            this.txtSiniestro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSiniestro.Location = new System.Drawing.Point(291, 204);
            this.txtSiniestro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSiniestro.Multiline = true;
            this.txtSiniestro.Name = "txtSiniestro";
            this.txtSiniestro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSiniestro.Size = new System.Drawing.Size(659, 285);
            this.txtSiniestro.TabIndex = 1;
            // 
            // txtPolizasActivas
            // 
            this.txtPolizasActivas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPolizasActivas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPolizasActivas.Location = new System.Drawing.Point(11, 204);
            this.txtPolizasActivas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPolizasActivas.Multiline = true;
            this.txtPolizasActivas.Name = "txtPolizasActivas";
            this.txtPolizasActivas.ReadOnly = true;
            this.txtPolizasActivas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPolizasActivas.Size = new System.Drawing.Size(272, 356);
            this.txtPolizasActivas.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Location = new System.Drawing.Point(726, 119);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(166, 33);
            this.txtTelefono.TabIndex = 1;
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.Location = new System.Drawing.Point(552, 119);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(166, 33);
            this.txtCedula.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Location = new System.Drawing.Point(378, 119);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(166, 33);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(204, 119);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(166, 33);
            this.txtNombre.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSiniestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 613);
            this.Controls.Add(this.pnlBuscarCliente);
            this.Controls.Add(this.pnlNuevo);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "frmSiniestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSiniestro";
            this.Load += new System.EventHandler(this.frmSiniestro_Load);
            this.pnlBuscarCliente.ResumeLayout(false);
            this.pnlBuscarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarClientes)).EndInit();
            this.pnlNuevo.ResumeLayout(false);
            this.gbxSiniestro.ResumeLayout(false);
            this.gbxSiniestro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBuscarCliente;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.DataGridView dgvBuscarClientes;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlNuevo;
        private System.Windows.Forms.GroupBox gbxSiniestro;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblRegistroSiniestros;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSiniestro;
        private System.Windows.Forms.TextBox txtPolizasActivas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkSoloId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}