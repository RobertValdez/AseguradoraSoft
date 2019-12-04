namespace CapaPresentacion
{
    partial class frmVerSiniestros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerSiniestros));
            this.dgvVer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVer
            // 
            this.dgvVer.AllowUserToAddRows = false;
            this.dgvVer.AllowUserToDeleteRows = false;
            this.dgvVer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVer.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVer.Location = new System.Drawing.Point(0, 143);
            this.dgvVer.Margin = new System.Windows.Forms.Padding(8);
            this.dgvVer.Name = "dgvVer";
            this.dgvVer.ReadOnly = true;
            this.dgvVer.Size = new System.Drawing.Size(973, 412);
            this.dgvVer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 44);
            this.label1.TabIndex = 175;
            this.label1.Text = "Ver Siniestros";
            // 
            // label16
            // 
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
            this.label16.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label16.Location = new System.Drawing.Point(241, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 56);
            this.label16.TabIndex = 174;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(310, 79);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(338, 43);
            this.textBox15.TabIndex = 173;
            // 
            // frmVerSiniestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.dgvVer);
            this.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frmVerSiniestros";
            this.Text = "frmVerSiniestros";
            this.Load += new System.EventHandler(this.frmVerSiniestros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox15;
    }
}