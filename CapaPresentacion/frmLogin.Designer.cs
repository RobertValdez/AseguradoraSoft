namespace CapaPresentacion
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlRegistrarse = new System.Windows.Forms.Panel();
            this.lblCerrarRegistrarse = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnProbarCodigo = new System.Windows.Forms.Button();
            this.btnInfoValidacion = new System.Windows.Forms.Button();
            this.lblComprobarCod = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRegistrarse.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 27);
            this.textBox1.TabIndex = 1;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Crimson;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(236, 218);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(117, 37);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iniciar Sesion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 27);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrarse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarse.ForeColor = System.Drawing.Color.Crimson;
            this.lblRegistrarse.Location = new System.Drawing.Point(9, 435);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(111, 19);
            this.lblRegistrarse.TabIndex = 4;
            this.lblRegistrarse.Text = "Crear cuenta";
            this.lblRegistrarse.Click += new System.EventHandler(this.lblRegistrarse_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(717, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(42, 41);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(477, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 72);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seguros\r\nPerla del Sur";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlRegistrarse
            // 
            this.pnlRegistrarse.Controls.Add(this.btnProbarCodigo);
            this.pnlRegistrarse.Controls.Add(this.btnInfoValidacion);
            this.pnlRegistrarse.Controls.Add(this.lblComprobarCod);
            this.pnlRegistrarse.Controls.Add(this.lblCerrarRegistrarse);
            this.pnlRegistrarse.Controls.Add(this.textBox6);
            this.pnlRegistrarse.Controls.Add(this.textBox5);
            this.pnlRegistrarse.Controls.Add(this.textBox4);
            this.pnlRegistrarse.Controls.Add(this.label9);
            this.pnlRegistrarse.Controls.Add(this.label8);
            this.pnlRegistrarse.Controls.Add(this.textBox3);
            this.pnlRegistrarse.Controls.Add(this.label7);
            this.pnlRegistrarse.Controls.Add(this.btnSalir);
            this.pnlRegistrarse.Controls.Add(this.btnRegistrar);
            this.pnlRegistrarse.Controls.Add(this.label6);
            this.pnlRegistrarse.Controls.Add(this.label5);
            this.pnlRegistrarse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistrarse.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistrarse.Name = "pnlRegistrarse";
            this.pnlRegistrarse.Size = new System.Drawing.Size(372, 480);
            this.pnlRegistrarse.TabIndex = 5;
            this.pnlRegistrarse.Visible = false;
            // 
            // lblCerrarRegistrarse
            // 
            this.lblCerrarRegistrarse.AutoSize = true;
            this.lblCerrarRegistrarse.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCerrarRegistrarse.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrarRegistrarse.Location = new System.Drawing.Point(337, 2);
            this.lblCerrarRegistrarse.Name = "lblCerrarRegistrarse";
            this.lblCerrarRegistrarse.Size = new System.Drawing.Size(35, 36);
            this.lblCerrarRegistrarse.TabIndex = 9;
            this.lblCerrarRegistrarse.Text = "X";
            this.lblCerrarRegistrarse.Click += new System.EventHandler(this.lblCerrarRegistrarse_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(138, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 27);
            this.textBox3.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Crimson;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(175, 406);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(166, 37);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 199);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 27);
            this.textBox4.TabIndex = 1;
            this.textBox4.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 36);
            this.label5.TabIndex = 3;
            this.label5.Text = "Registrarse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 42);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre\r\nde Usuario:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Contraseña:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 42);
            this.label8.TabIndex = 3;
            this.label8.Text = "Repetir\r\ncontraseña:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(138, 248);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(203, 27);
            this.textBox5.TabIndex = 1;
            this.textBox5.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Validación:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(128, 340);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(190, 27);
            this.textBox6.TabIndex = 1;
            this.textBox6.UseSystemPasswordChar = true;
            // 
            // btnProbarCodigo
            // 
            this.btnProbarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProbarCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbarCodigo.ForeColor = System.Drawing.Color.Crimson;
            this.btnProbarCodigo.Location = new System.Drawing.Point(222, 310);
            this.btnProbarCodigo.Name = "btnProbarCodigo";
            this.btnProbarCodigo.Size = new System.Drawing.Size(117, 26);
            this.btnProbarCodigo.TabIndex = 12;
            this.btnProbarCodigo.Text = "Probar código";
            this.btnProbarCodigo.UseVisualStyleBackColor = true;
            // 
            // btnInfoValidacion
            // 
            this.btnInfoValidacion.BackColor = System.Drawing.Color.White;
            this.btnInfoValidacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoValidacion.FlatAppearance.BorderSize = 0;
            this.btnInfoValidacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoValidacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoValidacion.ForeColor = System.Drawing.Color.White;
            this.btnInfoValidacion.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoValidacion.Image")));
            this.btnInfoValidacion.Location = new System.Drawing.Point(322, 340);
            this.btnInfoValidacion.Name = "btnInfoValidacion";
            this.btnInfoValidacion.Size = new System.Drawing.Size(17, 27);
            this.btnInfoValidacion.TabIndex = 11;
            this.btnInfoValidacion.UseVisualStyleBackColor = false;
            // 
            // lblComprobarCod
            // 
            this.lblComprobarCod.AutoSize = true;
            this.lblComprobarCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblComprobarCod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprobarCod.Location = new System.Drawing.Point(179, 370);
            this.lblComprobarCod.Name = "lblComprobarCod";
            this.lblComprobarCod.Size = new System.Drawing.Size(160, 19);
            this.lblComprobarCod.TabIndex = 10;
            this.lblComprobarCod.Text = "Correcto/Incorrecto";
            this.lblComprobarCod.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(29, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 37);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.lblCerrarRegistrarse_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 480);
            this.Controls.Add(this.pnlRegistrarse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRegistrarse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRegistrarse.ResumeLayout(false);
            this.pnlRegistrarse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlRegistrarse;
        private System.Windows.Forms.Label lblCerrarRegistrarse;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProbarCodigo;
        private System.Windows.Forms.Button btnInfoValidacion;
        private System.Windows.Forms.Label lblComprobarCod;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalir;
    }
}

