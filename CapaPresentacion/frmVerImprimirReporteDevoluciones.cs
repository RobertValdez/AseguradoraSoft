using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmVerImprimirReporteDevoluciones : Form
    {
        public int NumPoliza;
        public int NumReclamo;

        public DateTime FechaDesembolso;
        public string Descripcion;

        public decimal TotalDesembolso;

        public frmVerImprimirReporteDevoluciones()
        {
            InitializeComponent();
        }

        private void frmVerImprimirReporteDevoluciones_Load(object sender, EventArgs e)
        {
            ReportParameterCollection parNumPoliza = new ReportParameterCollection();
            parNumPoliza.Add(new ReportParameter("NumPoliza", NumPoliza.ToString()));
            reportViewer1.LocalReport.SetParameters(parNumPoliza);

            ReportParameterCollection parNumReclamo = new ReportParameterCollection();
            parNumReclamo.Add(new ReportParameter("NumReclamo", NumReclamo.ToString()));
            reportViewer1.LocalReport.SetParameters(parNumReclamo);

            ReportParameterCollection parDescripcion = new ReportParameterCollection();
            parDescripcion.Add(new ReportParameter("parDescripcion", Descripcion.ToString()));
            reportViewer1.LocalReport.SetParameters(parDescripcion);

            ReportParameterCollection parFecha = new ReportParameterCollection();
            parFecha.Add(new ReportParameter("FechaDev", FechaDesembolso.ToString()));
            reportViewer1.LocalReport.SetParameters(parFecha);

            ReportParameterCollection parTotal = new ReportParameterCollection();
            parTotal.Add(new ReportParameter("parTotal", TotalDesembolso.ToString("N2")));
            reportViewer1.LocalReport.SetParameters(parTotal);

            this.reportViewer1.RefreshReport();
        }
    }
}
