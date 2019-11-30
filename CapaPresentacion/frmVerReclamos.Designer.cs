namespace CapaPresentacion
{
    partial class frmVerReclamos
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
            this.dgvVer = new System.Windows.Forms.DataGridView();
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
            this.dgvVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVer.Location = new System.Drawing.Point(0, 0);
            this.dgvVer.Margin = new System.Windows.Forms.Padding(23, 22, 23, 22);
            this.dgvVer.Name = "dgvVer";
            this.dgvVer.ReadOnly = true;
            this.dgvVer.Size = new System.Drawing.Size(996, 596);
            this.dgvVer.TabIndex = 2;
            // 
            // frmVerReclamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 596);
            this.Controls.Add(this.dgvVer);
            this.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "frmVerReclamos";
            this.Text = "frmVerReclamos";
            this.Load += new System.EventHandler(this.frmVerReclamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVer;
    }
}