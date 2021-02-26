namespace CapaPresentacion
{
    partial class frmFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturas));
            this.pnlResumenSolicitud = new System.Windows.Forms.Panel();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.lblParcial = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtIdSeguro = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtSeguroA_Adquirir = new System.Windows.Forms.TextBox();
            this.txtEfectoA_Asegurar = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescontar = new System.Windows.Forms.TextBox();
            this.btnDescontar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.txtTotalA_Pagar = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.pnlResumenSolicitud.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlResumenSolicitud
            // 
            this.pnlResumenSolicitud.BackColor = System.Drawing.Color.White;
            this.pnlResumenSolicitud.Controls.Add(this.txtParcial);
            this.pnlResumenSolicitud.Controls.Add(this.lblParcial);
            this.pnlResumenSolicitud.Controls.Add(this.groupBox1);
            this.pnlResumenSolicitud.Controls.Add(this.btnImprimir);
            this.pnlResumenSolicitud.Controls.Add(this.btnAtras);
            this.pnlResumenSolicitud.Controls.Add(this.btnSolicitar);
            this.pnlResumenSolicitud.Controls.Add(this.groupBox2);
            this.pnlResumenSolicitud.Controls.Add(this.button3);
            this.pnlResumenSolicitud.Controls.Add(this.cmbTipoPago);
            this.pnlResumenSolicitud.Controls.Add(this.txtTotalA_Pagar);
            this.pnlResumenSolicitud.Controls.Add(this.txtDescuento);
            this.pnlResumenSolicitud.Controls.Add(this.label28);
            this.pnlResumenSolicitud.Controls.Add(this.txtSubTotal);
            this.pnlResumenSolicitud.Controls.Add(this.txtCodigo);
            this.pnlResumenSolicitud.Controls.Add(this.label22);
            this.pnlResumenSolicitud.Controls.Add(this.label27);
            this.pnlResumenSolicitud.Controls.Add(this.label23);
            this.pnlResumenSolicitud.Controls.Add(this.button1);
            this.pnlResumenSolicitud.Controls.Add(this.label29);
            this.pnlResumenSolicitud.Controls.Add(this.label30);
            this.pnlResumenSolicitud.Location = new System.Drawing.Point(22, 36);
            this.pnlResumenSolicitud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlResumenSolicitud.Name = "pnlResumenSolicitud";
            this.pnlResumenSolicitud.Size = new System.Drawing.Size(829, 550);
            this.pnlResumenSolicitud.TabIndex = 7;
            this.pnlResumenSolicitud.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlResumenSolicitud_MouseDown);
            // 
            // txtParcial
            // 
            this.txtParcial.Location = new System.Drawing.Point(683, 268);
            this.txtParcial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtParcial.MaxLength = 20;
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(134, 33);
            this.txtParcial.TabIndex = 1;
            this.txtParcial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtParcial.TextChanged += new System.EventHandler(this.txtParcial_TextChanged);
            // 
            // lblParcial
            // 
            this.lblParcial.AutoSize = true;
            this.lblParcial.ForeColor = System.Drawing.Color.Firebrick;
            this.lblParcial.Location = new System.Drawing.Point(592, 271);
            this.lblParcial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Size = new System.Drawing.Size(83, 24);
            this.lblParcial.TabIndex = 0;
            this.lblParcial.Text = "Parcial:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label51);
            this.groupBox1.Controls.Add(this.label60);
            this.groupBox1.Controls.Add(this.label69);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.txtIdSeguro);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.txtSeguroA_Adquirir);
            this.groupBox1.Controls.Add(this.txtEfectoA_Asegurar);
            this.groupBox1.Controls.Add(this.txtCategoria);
            this.groupBox1.Location = new System.Drawing.Point(29, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 358);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(137, 35);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(111, 33);
            this.txtId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(35, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cliente:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.ForeColor = System.Drawing.Color.Firebrick;
            this.label42.Location = new System.Drawing.Point(22, 82);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(105, 24);
            this.label42.TabIndex = 0;
            this.label42.Text = "IdSeguro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(95, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.ForeColor = System.Drawing.Color.Firebrick;
            this.label51.Location = new System.Drawing.Point(37, 177);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(92, 24);
            this.label51.TabIndex = 0;
            this.label51.Text = "Cédula:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.ForeColor = System.Drawing.Color.Firebrick;
            this.label60.Location = new System.Drawing.Point(22, 208);
            this.label60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(107, 48);
            this.label60.TabIndex = 0;
            this.label60.Text = "Seguro a \r\nadquirir:";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.ForeColor = System.Drawing.Color.Firebrick;
            this.label69.Location = new System.Drawing.Point(25, 262);
            this.label69.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(104, 48);
            this.label69.TabIndex = 0;
            this.label69.Text = "Efecto a \r\nasegurar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(9, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoría:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(137, 124);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(239, 33);
            this.txtCliente.TabIndex = 1;
            // 
            // txtIdSeguro
            // 
            this.txtIdSeguro.Location = new System.Drawing.Point(137, 79);
            this.txtIdSeguro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIdSeguro.Name = "txtIdSeguro";
            this.txtIdSeguro.ReadOnly = true;
            this.txtIdSeguro.Size = new System.Drawing.Size(239, 33);
            this.txtIdSeguro.TabIndex = 1;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(137, 173);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(239, 33);
            this.txtCedula.TabIndex = 1;
            // 
            // txtSeguroA_Adquirir
            // 
            this.txtSeguroA_Adquirir.Location = new System.Drawing.Point(137, 218);
            this.txtSeguroA_Adquirir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSeguroA_Adquirir.Name = "txtSeguroA_Adquirir";
            this.txtSeguroA_Adquirir.ReadOnly = true;
            this.txtSeguroA_Adquirir.Size = new System.Drawing.Size(239, 33);
            this.txtSeguroA_Adquirir.TabIndex = 1;
            // 
            // txtEfectoA_Asegurar
            // 
            this.txtEfectoA_Asegurar.Location = new System.Drawing.Point(137, 263);
            this.txtEfectoA_Asegurar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEfectoA_Asegurar.Name = "txtEfectoA_Asegurar";
            this.txtEfectoA_Asegurar.ReadOnly = true;
            this.txtEfectoA_Asegurar.Size = new System.Drawing.Size(239, 33);
            this.txtEfectoA_Asegurar.TabIndex = 1;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(137, 308);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(239, 33);
            this.txtCategoria.TabIndex = 1;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Gray;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(218, 485);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 57);
            this.btnImprimir.TabIndex = 107;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Visible = false;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.White;
            this.btnAtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.Crimson;
            this.btnAtras.Location = new System.Drawing.Point(4, 493);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(153, 49);
            this.btnAtras.TabIndex = 107;
            this.btnAtras.Text = "<< Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.BackColor = System.Drawing.Color.Crimson;
            this.btnSolicitar.FlatAppearance.BorderSize = 0;
            this.btnSolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitar.ForeColor = System.Drawing.Color.White;
            this.btnSolicitar.Location = new System.Drawing.Point(323, 485);
            this.btnSolicitar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(494, 57);
            this.btnSolicitar.TabIndex = 14;
            this.btnSolicitar.Text = "Solicitar";
            this.btnSolicitar.UseVisualStyleBackColor = false;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescontar);
            this.groupBox2.Controls.Add(this.btnDescontar);
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(625, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 171);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descontar:";
            // 
            // txtDescontar
            // 
            this.txtDescontar.Location = new System.Drawing.Point(35, 52);
            this.txtDescontar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescontar.MaxLength = 2;
            this.txtDescontar.Name = "txtDescontar";
            this.txtDescontar.Size = new System.Drawing.Size(144, 33);
            this.txtDescontar.TabIndex = 1;
            this.txtDescontar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescontar.TextChanged += new System.EventHandler(this.txtDescontar_TextChanged);
            this.txtDescontar.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescontar_Validating);
            // 
            // btnDescontar
            // 
            this.btnDescontar.BackColor = System.Drawing.Color.White;
            this.btnDescontar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnDescontar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescontar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescontar.ForeColor = System.Drawing.Color.Crimson;
            this.btnDescontar.Location = new System.Drawing.Point(39, 93);
            this.btnDescontar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDescontar.Name = "btnDescontar";
            this.btnDescontar.Size = new System.Drawing.Size(140, 42);
            this.btnDescontar.TabIndex = 12;
            this.btnDescontar.Text = "Descontar";
            this.btnDescontar.UseVisualStyleBackColor = false;
            this.btnDescontar.Click += new System.EventHandler(this.btnDescontar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(40, 592);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 57);
            this.button3.TabIndex = 12;
            this.button3.Text = "<< Atrás";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "Al contado",
            "Parcial"});
            this.cmbTipoPago.Location = new System.Drawing.Point(666, 211);
            this.cmbTipoPago.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(151, 32);
            this.cmbTipoPago.TabIndex = 5;
            this.cmbTipoPago.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPago_SelectedIndexChanged);
            // 
            // txtTotalA_Pagar
            // 
            this.txtTotalA_Pagar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.txtTotalA_Pagar.BackColor = System.Drawing.Color.LightPink;
            this.txtTotalA_Pagar.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalA_Pagar.Location = new System.Drawing.Point(566, 420);
            this.txtTotalA_Pagar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalA_Pagar.Name = "txtTotalA_Pagar";
            this.txtTotalA_Pagar.ReadOnly = true;
            this.txtTotalA_Pagar.Size = new System.Drawing.Size(251, 53);
            this.txtTotalA_Pagar.TabIndex = 4;
            this.txtTotalA_Pagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.Color.LightPink;
            this.txtDescuento.Location = new System.Drawing.Point(683, 380);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(134, 33);
            this.txtDescuento.TabIndex = 4;
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(549, 383);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(126, 25);
            this.label28.TabIndex = 0;
            this.label28.Text = "Descuento:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.LightPink;
            this.txtSubTotal.Location = new System.Drawing.Point(683, 341);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(134, 33);
            this.txtSubTotal.TabIndex = 4;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.LightPink;
            this.txtCodigo.Location = new System.Drawing.Point(524, 3);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(94, 33);
            this.txtCodigo.TabIndex = 4;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(570, 344);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 25);
            this.label22.TabIndex = 0;
            this.label22.Text = "SubTotal:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(662, 183);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(150, 24);
            this.label27.TabIndex = 0;
            this.label27.Text = "Tipo de pago:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(316, 425);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(252, 41);
            this.label23.TabIndex = 0;
            this.label23.Text = "Total a pagar:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(513, 592);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Solicitar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(413, 6);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(91, 24);
            this.label29.TabIndex = 0;
            this.label29.Text = "Código:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(52, 6);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(317, 36);
            this.label30.TabIndex = 0;
            this.label30.Text = "Resumen de Solicitud";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(-42, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 10);
            this.panel1.TabIndex = 108;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(864, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 601);
            this.panel2.TabIndex = 108;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Location = new System.Drawing.Point(-1, 590);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(912, 10);
            this.panel3.TabIndex = 108;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Location = new System.Drawing.Point(0, -115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 714);
            this.panel4.TabIndex = 108;
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCerrar.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.Location = new System.Drawing.Point(827, 4);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(35, 36);
            this.lblCerrar.TabIndex = 108;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 598);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlResumenSolicitud);
            this.Controls.Add(this.lblCerrar);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmFacturas_MouseDown);
            this.pnlResumenSolicitud.ResumeLayout(false);
            this.pnlResumenSolicitud.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlResumenSolicitud;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescontar;
        private System.Windows.Forms.Button btnDescontar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtEfectoA_Asegurar;
        public System.Windows.Forms.TextBox txtSeguroA_Adquirir;
        public System.Windows.Forms.TextBox txtCedula;
        public System.Windows.Forms.TextBox txtIdSeguro;
        public System.Windows.Forms.TextBox txtCategoria;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblParcial;
        public System.Windows.Forms.TextBox txtTotalA_Pagar;
        public System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtDescuento;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCliente;
        public System.Windows.Forms.TextBox txtParcial;
    }
}