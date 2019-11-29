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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAprobarSolicitud = new System.Windows.Forms.Button();
            this.btnRechazarSolicitud = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarSolicitudes
            // 
            this.dgvMostrarSolicitudes.AllowUserToAddRows = false;
            this.dgvMostrarSolicitudes.AllowUserToDeleteRows = false;
            this.dgvMostrarSolicitudes.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvMostrarSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarSolicitudes.Location = new System.Drawing.Point(20, 146);
            this.dgvMostrarSolicitudes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvMostrarSolicitudes.Name = "dgvMostrarSolicitudes";
            this.dgvMostrarSolicitudes.ReadOnly = true;
            this.dgvMostrarSolicitudes.Size = new System.Drawing.Size(895, 481);
            this.dgvMostrarSolicitudes.TabIndex = 26;
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Muebles e Inmuebles",
            "Empresas y negocios",
            "Vehiculos"});
            this.comboBox1.Location = new System.Drawing.Point(293, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(384, 32);
            this.comboBox1.TabIndex = 29;
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
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(1024, 88);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(116, 33);
            this.textBox1.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.Location = new System.Drawing.Point(838, 77);
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
            this.label1.Location = new System.Drawing.Point(942, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Estado:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(1024, 137);
            this.textBox2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(116, 33);
            this.textBox2.TabIndex = 24;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Firebrick;
            this.radioButton1.Location = new System.Drawing.Point(146, 109);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(141, 28);
            this.radioButton1.TabIndex = 32;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Aprobados";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Firebrick;
            this.radioButton2.Location = new System.Drawing.Point(146, 77);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(140, 28);
            this.radioButton2.TabIndex = 32;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pendientes";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(924, 413);
            this.textBox3.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(216, 214);
            this.textBox3.TabIndex = 24;
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
            // frmConfirmacionSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 635);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnRechazarSolicitud);
            this.Controls.Add(this.btnAprobarSolicitud);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvMostrarSolicitudes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAprobarSolicitud;
        private System.Windows.Forms.Button btnRechazarSolicitud;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
    }
}