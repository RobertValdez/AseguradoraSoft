namespace CapaPresentacion
{
    partial class frmVerPolizas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerPolizas));
            this.label16 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.dgvVerPolizas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPolizas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerPolizas)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label16.Location = new System.Drawing.Point(99, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 56);
            this.label16.TabIndex = 170;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(168, 77);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(500, 33);
            this.textBox15.TabIndex = 169;
            // 
            // dgvVerPolizas
            // 
            this.dgvVerPolizas.AllowUserToAddRows = false;
            this.dgvVerPolizas.AllowUserToDeleteRows = false;
            this.dgvVerPolizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvVerPolizas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVerPolizas.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvVerPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerPolizas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVerPolizas.Location = new System.Drawing.Point(0, 132);
            this.dgvVerPolizas.Name = "dgvVerPolizas";
            this.dgvVerPolizas.ReadOnly = true;
            this.dgvVerPolizas.Size = new System.Drawing.Size(899, 389);
            this.dgvVerPolizas.TabIndex = 168;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 44);
            this.label1.TabIndex = 172;
            this.label1.Text = "Buscar Polizas de Seguros";
            // 
            // cmbPolizas
            // 
            this.cmbPolizas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPolizas.FormattingEnabled = true;
            this.cmbPolizas.Items.AddRange(new object[] {
            "Vida",
            "Vehiculo",
            "Negocios e Empresas",
            "Muebles e Inmuebles"});
            this.cmbPolizas.Location = new System.Drawing.Point(513, 77);
            this.cmbPolizas.Name = "cmbPolizas";
            this.cmbPolizas.Size = new System.Drawing.Size(297, 32);
            this.cmbPolizas.TabIndex = 188;
            this.cmbPolizas.Visible = false;
            this.cmbPolizas.SelectedIndexChanged += new System.EventHandler(this.cmbPolizas_SelectedIndexChanged);
            // 
            // frmVerPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.dgvVerPolizas);
            this.Controls.Add(this.cmbPolizas);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmVerPolizas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerPolizas";
            this.Load += new System.EventHandler(this.frmVerPolizas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerPolizas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.DataGridView dgvVerPolizas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPolizas;
    }
}