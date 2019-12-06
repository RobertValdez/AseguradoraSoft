namespace CapaPresentacion
{
    partial class Cargos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aseguradoraBDDataSetCargos = new CapaPresentacion.AseguradoraBDDataSetCargos();
            this.cargoEmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargoEmpTableAdapter = new CapaPresentacion.AseguradoraBDDataSetCargosTableAdapters.CargoEmpTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label124 = new System.Windows.Forms.Label();
            this.lblSeguroNEmpresa = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aseguradoraBDDataSetCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoEmpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cargoEmpBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(829, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // aseguradoraBDDataSetCargos
            // 
            this.aseguradoraBDDataSetCargos.DataSetName = "AseguradoraBDDataSetCargos";
            this.aseguradoraBDDataSetCargos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cargoEmpBindingSource
            // 
            this.cargoEmpBindingSource.DataMember = "CargoEmp";
            this.cargoEmpBindingSource.DataSource = this.aseguradoraBDDataSetCargos;
            // 
            // cargoEmpTableAdapter
            // 
            this.cargoEmpTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 52;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(213, 66);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(337, 33);
            this.txtCargo.TabIndex = 1;
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label124.ForeColor = System.Drawing.Color.Firebrick;
            this.label124.Location = new System.Drawing.Point(116, 69);
            this.label124.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(80, 24);
            this.label124.TabIndex = 98;
            this.label124.Text = "Cargo:";
            // 
            // lblSeguroNEmpresa
            // 
            this.lblSeguroNEmpresa.AutoSize = true;
            this.lblSeguroNEmpresa.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblSeguroNEmpresa.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSeguroNEmpresa.Location = new System.Drawing.Point(288, 9);
            this.lblSeguroNEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeguroNEmpresa.Name = "lblSeguroNEmpresa";
            this.lblSeguroNEmpresa.Size = new System.Drawing.Size(168, 28);
            this.lblSeguroNEmpresa.TabIndex = 99;
            this.lblSeguroNEmpresa.Text = "Nuevo Cargo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Crimson;
            this.btnAgregar.Location = new System.Drawing.Point(581, 66);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 33);
            this.btnAgregar.TabIndex = 100;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Cargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 513);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblSeguroNEmpresa);
            this.Controls.Add(this.label124);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Cargos";
            this.Text = "Cargos";
            this.Load += new System.EventHandler(this.Cargos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aseguradoraBDDataSetCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoEmpBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AseguradoraBDDataSetCargos aseguradoraBDDataSetCargos;
        private AseguradoraBDDataSetCargosTableAdapters.CargoEmpTableAdapter cargoEmpTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Label lblSeguroNEmpresa;
        private System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.BindingSource cargoEmpBindingSource;
    }
}