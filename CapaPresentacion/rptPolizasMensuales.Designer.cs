namespace CapaPresentacion
{
    partial class rptPolizasMensuales
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSPolizasEmitidasPorMes = new CapaPresentacion.DSPolizasEmitidasPorMes();
            this.PolizasEmitidasAlMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PolizasEmitidasAlMesTableAdapter = new CapaPresentacion.DSPolizasEmitidasPorMesTableAdapters.PolizasEmitidasAlMesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSPolizasEmitidasPorMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolizasEmitidasAlMesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PolizasEmitidasAlMesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteMensualPolizas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSPolizasEmitidasPorMes
            // 
            this.DSPolizasEmitidasPorMes.DataSetName = "DSPolizasEmitidasPorMes";
            this.DSPolizasEmitidasPorMes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PolizasEmitidasAlMesBindingSource
            // 
            this.PolizasEmitidasAlMesBindingSource.DataMember = "PolizasEmitidasAlMes";
            this.PolizasEmitidasAlMesBindingSource.DataSource = this.DSPolizasEmitidasPorMes;
            // 
            // PolizasEmitidasAlMesTableAdapter
            // 
            this.PolizasEmitidasAlMesTableAdapter.ClearBeforeFill = true;
            // 
            // rptPolizasMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptPolizasMensuales";
            this.Text = "rptPolizasMensuales";
            this.Load += new System.EventHandler(this.rptPolizasMensuales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSPolizasEmitidasPorMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PolizasEmitidasAlMesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PolizasEmitidasAlMesBindingSource;
        private DSPolizasEmitidasPorMes DSPolizasEmitidasPorMes;
        private DSPolizasEmitidasPorMesTableAdapters.PolizasEmitidasAlMesTableAdapter PolizasEmitidasAlMesTableAdapter;
    }
}