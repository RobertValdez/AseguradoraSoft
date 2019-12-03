namespace CapaPresentacion
{
    partial class frmConfirmacionSolicitud
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
            this.dgvMostrarSolicitudes = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAprobarSolicitud = new System.Windows.Forms.Button();
            this.btnRechazarSolicitud = new System.Windows.Forms.Button();
            this.txtIdSolicitud = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.rbAceptada = new System.Windows.Forms.RadioButton();
            this.rbEnProceso = new System.Windows.Forms.RadioButton();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSeguros = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarSolicitudes
            // 
            this.dgvMostrarSolicitudes.AllowUserToAddRows = false;
            this.dgvMostrarSolicitudes.AllowUserToDeleteRows = false;
            this.dgvMostrarSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMostrarSolicitudes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMostrarSolicitudes.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvMostrarSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarSolicitudes.Location = new System.Drawing.Point(20, 146);
            this.dgvMostrarSolicitudes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvMostrarSolicitudes.Name = "dgvMostrarSolicitudes";
            this.dgvMostrarSolicitudes.ReadOnly = true;
            this.dgvMostrarSolicitudes.Size = new System.Drawing.Size(895, 481);
            this.dgvMostrarSolicitudes.TabIndex = 26;
            this.dgvMostrarSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarSolicitudes_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(365, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(502, 38);
            this.label10.TabIndex = 25;
            this.label10.Text = "Confirmación de las Solicitudes";
            // 
            // btnAprobarSolicitud
            // 
            this.btnAprobarSolicitud.BackColor = System.Drawing.Color.Crimson;
            this.btnAprobarSolicitud.FlatAppearance.BorderSize = 0;
            this.btnAprobarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprobarSolicitud.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAprobarSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnAprobarSolicitud.Location = new System.Drawing.Point(924, 201);
            this.btnAprobarSolicitud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAprobarSolicitud.Name = "btnAprobarSolicitud";
            this.btnAprobarSolicitud.Size = new System.Drawing.Size(199, 57);
            this.btnAprobarSolicitud.TabIndex = 30;
            this.btnAprobarSolicitud.Text = "Aprobar solicitud";
            this.btnAprobarSolicitud.UseVisualStyleBackColor = false;
            this.btnAprobarSolicitud.Click += new System.EventHandler(this.btnAprobarSolicitud_Click);
            // 
            // btnRechazarSolicitud
            // 
            this.btnRechazarSolicitud.BackColor = System.Drawing.Color.Crimson;
            this.btnRechazarSolicitud.FlatAppearance.BorderSize = 0;
            this.btnRechazarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazarSolicitud.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazarSolicitud.ForeColor = System.Drawing.Color.White;
            this.btnRechazarSolicitud.Location = new System.Drawing.Point(924, 281);
            this.btnRechazarSolicitud.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRechazarSolicitud.Name = "btnRechazarSolicitud";
            this.btnRechazarSolicitud.Size = new System.Drawing.Size(199, 57);
            this.btnRechazarSolicitud.TabIndex = 30;
            this.btnRechazarSolicitud.Text = "Rechazar solicitud";
            this.btnRechazarSolicitud.UseVisualStyleBackColor = false;
            this.btnRechazarSolicitud.Click += new System.EventHandler(this.btnRechazarSolicitud_Click);
            // 
            // txtIdSolicitud
            // 
            this.txtIdSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdSolicitud.Location = new System.Drawing.Point(1004, 88);
            this.txtIdSolicitud.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtIdSolicitud.Name = "txtIdSolicitud";
            this.txtIdSolicitud.ReadOnly = true;
            this.txtIdSolicitud.Size = new System.Drawing.Size(136, 33);
            this.txtIdSolicitud.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.Location = new System.Drawing.Point(825, 77);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 48);
            this.label11.TabIndex = 31;
            this.label11.Text = "id de la Solicitud\r\nseleccionada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(917, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Location = new System.Drawing.Point(1004, 137);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(136, 33);
            this.txtEstado.TabIndex = 24;
            // 
            // rbAceptada
            // 
            this.rbAceptada.AutoSize = true;
            this.rbAceptada.ForeColor = System.Drawing.Color.Firebrick;
            this.rbAceptada.Location = new System.Drawing.Point(146, 109);
            this.rbAceptada.Name = "rbAceptada";
            this.rbAceptada.Size = new System.Drawing.Size(134, 28);
            this.rbAceptada.TabIndex = 32;
            this.rbAceptada.TabStop = true;
            this.rbAceptada.Text = "Aceptada";
            this.rbAceptada.UseVisualStyleBackColor = true;
            this.rbAceptada.CheckedChanged += new System.EventHandler(this.rbAprobados_CheckedChanged);
            // 
            // rbEnProceso
            // 
            this.rbEnProceso.AutoSize = true;
            this.rbEnProceso.ForeColor = System.Drawing.Color.Firebrick;
            this.rbEnProceso.Location = new System.Drawing.Point(146, 77);
            this.rbEnProceso.Name = "rbEnProceso";
            this.rbEnProceso.Size = new System.Drawing.Size(140, 28);
            this.rbEnProceso.TabIndex = 32;
            this.rbEnProceso.TabStop = true;
            this.rbEnProceso.Text = "En Proceso";
            this.rbEnProceso.UseVisualStyleBackColor = true;
            this.rbEnProceso.CheckedChanged += new System.EventHandler(this.rbEnProceso_CheckedChanged);
            // 
            // txtNota
            // 
            this.txtNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNota.Location = new System.Drawing.Point(924, 413);
            this.txtNota.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(216, 214);
            this.txtNota.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(924, 381);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nota:";
            // 
            // cmbSeguros
            // 
            this.cmbSeguros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeguros.FormattingEnabled = true;
            this.cmbSeguros.Items.AddRange(new object[] {
            "Seguro Contenido",
            "Seguro Edificaciones",
            "Seguro para Empresas y Negocios",
            "Seguro a Todo Riesgo",
            "Seguro Obligatorio",
            "Seguro Voluntario"});
            this.cmbSeguros.Location = new System.Drawing.Point(293, 105);
            this.cmbSeguros.Name = "cmbSeguros";
            this.cmbSeguros.Size = new System.Drawing.Size(395, 32);
            this.cmbSeguros.TabIndex = 208;
            this.cmbSeguros.DropDownClosed += new System.EventHandler(this.cmbSeguros_DropDownClosed_1);
            // 
            // frmConfirmacionSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 635);
            this.Controls.Add(this.cmbSeguros);
            this.Controls.Add(this.rbEnProceso);
            this.Controls.Add(this.rbAceptada);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnRechazarSolicitud);
            this.Controls.Add(this.btnAprobarSolicitud);
            this.Controls.Add(this.dgvMostrarSolicitudes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtIdSolicitud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "frmConfirmacionSolicitud";
            this.Text = "Confirmación Solicitud";
            this.Load += new System.EventHandler(this.frmConfirmacionSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMostrarSolicitudes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAprobarSolicitud;
        private System.Windows.Forms.Button btnRechazarSolicitud;
        private System.Windows.Forms.TextBox txtIdSolicitud;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.RadioButton rbAceptada;
        private System.Windows.Forms.RadioButton rbEnProceso;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSeguros;
    }
}