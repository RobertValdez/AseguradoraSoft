namespace CapaPresentacion
{
    partial class rptFacturasDelMes
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
            this.FacturasMensuales = new CapaPresentacion.FacturasMensuales();
            this.FacturasDelMesActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturasDelMesActualTableAdapter = new CapaPresentacion.FacturasMensualesTableAdapters.FacturasDelMesActualTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasMensuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDelMesActualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FacturasDelMesActualBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReporteMensual.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturasMensuales
            // 
            this.FacturasMensuales.DataSetName = "FacturasMensuales";
            this.FacturasMensuales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturasDelMesActualBindingSource
            // 
            this.FacturasDelMesActualBindingSource.DataMember = "FacturasDelMesActual";
            this.FacturasDelMesActualBindingSource.DataSource = this.FacturasMensuales;
            // 
            // FacturasDelMesActualTableAdapter
            // 
            this.FacturasDelMesActualTableAdapter.ClearBeforeFill = true;
            // 
            // rptFacturasDelMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptFacturasDelMes";
            this.Text = "rptFacturasDelMes";
            this.Load += new System.EventHandler(this.rptFacturasDelMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturasMensuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDelMesActualBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturasDelMesActualBindingSource;
        private FacturasMensuales FacturasMensuales;
        private FacturasMensualesTableAdapters.FacturasDelMesActualTableAdapter FacturasDelMesActualTableAdapter;
    }
}