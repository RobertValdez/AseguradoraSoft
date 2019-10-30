namespace CapaPresentacion
{
    partial class frmPolizas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPolizas));
            this.pnlGestionarPolizas = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPagoP = new System.Windows.Forms.Button();
            this.btnGestionarP = new System.Windows.Forms.Button();
            this.pnlPagoPolizas = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTPago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblParcial = new System.Windows.Forms.Label();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlGestionarPolizas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlPagoPolizas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGestionarPolizas
            // 
            this.pnlGestionarPolizas.Controls.Add(this.label4);
            this.pnlGestionarPolizas.Controls.Add(this.label10);
            this.pnlGestionarPolizas.Controls.Add(this.label8);
            this.pnlGestionarPolizas.Controls.Add(this.label9);
            this.pnlGestionarPolizas.Controls.Add(this.textBox2);
            this.pnlGestionarPolizas.Controls.Add(this.textBox5);
            this.pnlGestionarPolizas.Controls.Add(this.textBox3);
            this.pnlGestionarPolizas.Controls.Add(this.textBox4);
            this.pnlGestionarPolizas.Controls.Add(this.button2);
            this.pnlGestionarPolizas.Controls.Add(this.comboBox1);
            this.pnlGestionarPolizas.Controls.Add(this.label2);
            this.pnlGestionarPolizas.Controls.Add(this.textBox1);
            this.pnlGestionarPolizas.Controls.Add(this.dataGridView1);
            this.pnlGestionarPolizas.Location = new System.Drawing.Point(12, 103);
            this.pnlGestionarPolizas.Name = "pnlGestionarPolizas";
            this.pnlGestionarPolizas.Size = new System.Drawing.Size(1089, 509);
            this.pnlGestionarPolizas.TabIndex = 24;
            this.pnlGestionarPolizas.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seguro de Riesgo de Muerte",
            "Seguro de Salud",
            "Seguro de Riesgos Laborales",
            "Seguro Contenido",
            "Seguro Edificaciones",
            "Seguro para Empresas y Negocios",
            "Seguro a Todo Riesgo",
            "Seguro Obligatorio",
            "Seguro Voluntario"});
            this.comboBox1.Location = new System.Drawing.Point(222, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 29);
            this.comboBox1.TabIndex = 164;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Location = new System.Drawing.Point(153, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 56);
            this.label2.TabIndex = 163;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 64);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 27);
            this.textBox1.TabIndex = 162;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(15, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // btnPagoP
            // 
            this.btnPagoP.BackColor = System.Drawing.Color.LightPink;
            this.btnPagoP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagoP.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagoP.ForeColor = System.Drawing.Color.Crimson;
            this.btnPagoP.Location = new System.Drawing.Point(13, 12);
            this.btnPagoP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPagoP.Name = "btnPagoP";
            this.btnPagoP.Size = new System.Drawing.Size(170, 86);
            this.btnPagoP.TabIndex = 165;
            this.btnPagoP.Text = "Pago de Pólizas";
            this.btnPagoP.UseVisualStyleBackColor = false;
            this.btnPagoP.Click += new System.EventHandler(this.btnPagoP_Click);
            // 
            // btnGestionarP
            // 
            this.btnGestionarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionarP.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarP.ForeColor = System.Drawing.Color.Crimson;
            this.btnGestionarP.Location = new System.Drawing.Point(191, 12);
            this.btnGestionarP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGestionarP.Name = "btnGestionarP";
            this.btnGestionarP.Size = new System.Drawing.Size(170, 86);
            this.btnGestionarP.TabIndex = 165;
            this.btnGestionarP.Text = "Gestionar Pólizas";
            this.btnGestionarP.UseVisualStyleBackColor = false;
            this.btnGestionarP.Click += new System.EventHandler(this.btnGestionarP_Click);
            // 
            // pnlPagoPolizas
            // 
            this.pnlPagoPolizas.Controls.Add(this.label5);
            this.pnlPagoPolizas.Controls.Add(this.label7);
            this.pnlPagoPolizas.Controls.Add(this.label6);
            this.pnlPagoPolizas.Controls.Add(this.textBox7);
            this.pnlPagoPolizas.Controls.Add(this.textBox11);
            this.pnlPagoPolizas.Controls.Add(this.textBox8);
            this.pnlPagoPolizas.Controls.Add(this.button1);
            this.pnlPagoPolizas.Controls.Add(this.cmbTPago);
            this.pnlPagoPolizas.Controls.Add(this.lblParcial);
            this.pnlPagoPolizas.Controls.Add(this.label3);
            this.pnlPagoPolizas.Controls.Add(this.label11);
            this.pnlPagoPolizas.Controls.Add(this.comboBox2);
            this.pnlPagoPolizas.Controls.Add(this.txtParcial);
            this.pnlPagoPolizas.Controls.Add(this.label1);
            this.pnlPagoPolizas.Controls.Add(this.textBox9);
            this.pnlPagoPolizas.Controls.Add(this.textBox10);
            this.pnlPagoPolizas.Controls.Add(this.dataGridView2);
            this.pnlPagoPolizas.Location = new System.Drawing.Point(13, 104);
            this.pnlPagoPolizas.Name = "pnlPagoPolizas";
            this.pnlPagoPolizas.Size = new System.Drawing.Size(1088, 508);
            this.pnlPagoPolizas.TabIndex = 165;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Seguro de Riesgo de Muerte",
            "Seguro de Salud",
            "Seguro de Riesgos Laborales",
            "Seguro Contenido",
            "Seguro Edificaciones",
            "Seguro para Empresas y Negocios",
            "Seguro a Todo Riesgo",
            "Seguro Obligatorio",
            "Seguro Voluntario"});
            this.comboBox2.Location = new System.Drawing.Point(222, 28);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(297, 29);
            this.comboBox2.TabIndex = 164;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(153, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 56);
            this.label1.TabIndex = 163;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(912, 355);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(138, 27);
            this.textBox9.TabIndex = 162;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(222, 64);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(434, 27);
            this.textBox10.TabIndex = 162;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView2.Location = new System.Drawing.Point(15, 109);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(735, 363);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Column4";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Column5";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Column6";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Column7";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.Location = new System.Drawing.Point(908, 258);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 24);
            this.label11.TabIndex = 165;
            this.label11.Text = "Tipo de Pago:";
            // 
            // cmbTPago
            // 
            this.cmbTPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTPago.FormattingEnabled = true;
            this.cmbTPago.Items.AddRange(new object[] {
            "Al contado",
            "Parcial"});
            this.cmbTPago.Location = new System.Drawing.Point(912, 285);
            this.cmbTPago.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbTPago.Name = "cmbTPago";
            this.cmbTPago.Size = new System.Drawing.Size(138, 29);
            this.cmbTPago.TabIndex = 168;
            this.cmbTPago.SelectedIndexChanged += new System.EventHandler(this.cmbTPago_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(757, 355);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 165;
            this.label3.Text = "Total a pagar:";
            // 
            // lblParcial
            // 
            this.lblParcial.AutoSize = true;
            this.lblParcial.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcial.ForeColor = System.Drawing.Color.Firebrick;
            this.lblParcial.Location = new System.Drawing.Point(759, 320);
            this.lblParcial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Size = new System.Drawing.Size(145, 24);
            this.lblParcial.TabIndex = 165;
            this.lblParcial.Text = "Pago parcial:";
            this.lblParcial.Visible = false;
            // 
            // txtParcial
            // 
            this.txtParcial.Location = new System.Drawing.Point(912, 320);
            this.txtParcial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(138, 27);
            this.txtParcial.TabIndex = 162;
            this.txtParcial.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(929, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 57);
            this.button1.TabIndex = 169;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(759, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 172;
            this.label5.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(757, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 173;
            this.label6.Text = "Núm. Póliza:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(912, 108);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(138, 27);
            this.textBox7.TabIndex = 170;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(912, 143);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(138, 27);
            this.textBox8.TabIndex = 171;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(912, 201);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(138, 27);
            this.textBox11.TabIndex = 171;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(757, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 48);
            this.label7.TabIndex = 173;
            this.label7.Text = "Vencimiento\r\nActual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(758, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 184;
            this.label4.Text = "Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(758, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 185;
            this.label8.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Firebrick;
            this.label9.Location = new System.Drawing.Point(758, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 24);
            this.label9.TabIndex = 186;
            this.label9.Text = "Núm. Póliza:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(913, 109);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(138, 27);
            this.textBox2.TabIndex = 181;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(913, 177);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(138, 27);
            this.textBox3.TabIndex = 182;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(913, 144);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(138, 27);
            this.textBox4.TabIndex = 183;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(762, 415);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 57);
            this.button2.TabIndex = 180;
            this.button2.Text = "Cancelar Póliza";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(834, 235);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(217, 145);
            this.textBox5.TabIndex = 182;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Firebrick;
            this.label10.Location = new System.Drawing.Point(758, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 24);
            this.label10.TabIndex = 185;
            this.label10.Text = "Nota:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(-6, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 10);
            this.panel1.TabIndex = 174;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(1171, -40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 730);
            this.panel2.TabIndex = 174;
            // 
            // frmPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPagoPolizas);
            this.Controls.Add(this.btnGestionarP);
            this.Controls.Add(this.btnPagoP);
            this.Controls.Add(this.pnlGestionarPolizas);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPolizas";
            this.Text = "Polizas";
            this.pnlGestionarPolizas.ResumeLayout(false);
            this.pnlGestionarPolizas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlPagoPolizas.ResumeLayout(false);
            this.pnlPagoPolizas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGestionarPolizas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPagoP;
        private System.Windows.Forms.Button btnGestionarP;
        private System.Windows.Forms.Panel pnlPagoPolizas;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbTPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblParcial;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}