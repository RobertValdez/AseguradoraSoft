namespace CapaPresentacion
{
    partial class frmPreviewFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DsFacturaPoliza = new CapaPresentacion.DsFacturaPoliza();
            this.ReporteDatosPolizaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteDatosPolizaClienteTableAdapter = new CapaPresentacion.DsFacturaPolizaTableAdapters.ReporteDatosPolizaClienteTableAdapter();
            this.ReporteDatosPolizaCliente_vhPolizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteDatosPolizaCliente_vhPolizaTableAdapter = new CapaPresentacion.DsFacturaPolizaTableAdapters.ReporteDatosPolizaCliente_vhPolizaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DsFacturaPoliza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDatosPolizaClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDatosPolizaCliente_vhPolizaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ReporteDatosPolizaClienteBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ReporteDatosPolizaCliente_vhPolizaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.rptFacturaPoliza.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DsFacturaPoliza
            // 
            this.DsFacturaPoliza.DataSetName = "DsFacturaPoliza";
            this.DsFacturaPoliza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteDatosPolizaClienteBindingSource
            // 
            this.ReporteDatosPolizaClienteBindingSource.DataMember = "ReporteDatosPolizaCliente";
            this.ReporteDatosPolizaClienteBindingSource.DataSource = this.DsFacturaPoliza;
            // 
            // ReporteDatosPolizaClienteTableAdapter
            // 
            this.ReporteDatosPolizaClienteTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDatosPolizaCliente_vhPolizaBindingSource
            // 
            this.ReporteDatosPolizaCliente_vhPolizaBindingSource.DataMember = "ReporteDatosPolizaCliente_vhPoliza";
            this.ReporteDatosPolizaCliente_vhPolizaBindingSource.DataSource = this.DsFacturaPoliza;
            // 
            // ReporteDatosPolizaCliente_vhPolizaTableAdapter
            // 
            this.ReporteDatosPolizaCliente_vhPolizaTableAdapter.ClearBeforeFill = true;
            // 
            // frmPreviewFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPreviewFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPreviewFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DsFacturaPoliza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDatosPolizaClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDatosPolizaCliente_vhPolizaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteDatosPolizaClienteBindingSource;
        private DsFacturaPoliza DsFacturaPoliza;
        private System.Windows.Forms.BindingSource ReporteDatosPolizaCliente_vhPolizaBindingSource;
        private DsFacturaPolizaTableAdapters.ReporteDatosPolizaClienteTableAdapter ReporteDatosPolizaClienteTableAdapter;
        private DsFacturaPolizaTableAdapters.ReporteDatosPolizaCliente_vhPolizaTableAdapter ReporteDatosPolizaCliente_vhPolizaTableAdapter;
    }
}