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
    public partial class frmPreviewFactura : Form
    {
        public int idPoliza = 0;
        public int idCliente = 0;

        public decimal Total = 0;

        public string strTipoPago = "";

        public frmPreviewFactura()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //try
            //{


            //    e.Graphics.DrawString("LAVANDERIA GENARO", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(28, 11));
            //    e.Graphics.DrawString("CALLE SANCHEZ #2", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(34, 23));
            //    e.Graphics.DrawString("TEL. 809-524-3199", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(38, 35));
            //    e.Graphics.DrawString("SANTA CRUZ DE BARAHONA", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(13, 47));
            //    e.Graphics.DrawString("   R.D", new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(68, 59));

            //    e.Graphics.DrawString("Cliente: " + obtenerNombreCliente + "", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(5, 75));

            //    e.Graphics.DrawString("FACTURA: " + obtenerId + "", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(5, 85));
            //    e.Graphics.DrawString("=========================================================================================================",
            //        new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(5, 95));

            //    e.Graphics.DrawString("" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(5, 105));

            //    e.Graphics.DrawString("=========================================================================================================",
            //        new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(5, 115));

            //    e.Graphics.DrawString("DESCRIPCION                  IMPORTE", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(5, 125));

            //    //Valores que permiten que los datos desciendan
            //    Int32 B = 0;

            //    int C = 0;

            //    //RectangleF Parameters
            //    int x = 5;
            //    int y = 138;

            //    int Bottom = 0;

            //    int Height = 0;

            //    int count = 0;
            //    int countNumPiezaDuplicate = 0;

            //    List<string> listNomPiezas = new List<string>(obtenerNomPiezas.Split(new string[] { "  ■" }, StringSplitOptions.RemoveEmptyEntries));
            //    List<string> NumPiezaDuplicate = new List<string>();


            //    var X = from obj in listNomPiezas group obj by obj into g select new { Name = g.Key, Duplicatecount = g.Count() };
            //    foreach (var m in X)
            //    {
            //        NumPiezaDuplicate.Add("" + m.Duplicatecount);
            //    }

            //    listNomPiezas = listNomPiezas.Distinct().ToList<string>();


            //    foreach (string item in listNomPiezas)
            //    {
                    
            //        RectangleF drawRect = new RectangleF();

            //        if (count > 0)
            //        {
            //            drawRect.Location = new Point(x, Bottom);
            //            C = Bottom;
            //        }
            //        else
            //        {
            //            drawRect.Location = new Point(x, y);
            //            C = y;
            //        }

            //        Height = Convert.ToInt16(e.Graphics.MeasureString("■ " + Text + " x" + NumPiezaDuplicate.ElementAt(countNumPiezaDuplicate), new Font("Arial", 8, FontStyle.Bold), 125).Height);
            //        drawRect.Size = new Size(125, Height);

            //        e.Graphics.DrawString("■ " + Text + " x" + NumPiezaDuplicate.ElementAt(countNumPiezaDuplicate), new Font("Arial", 8, FontStyle.Bold), Brushes.Black, drawRect);
            //        e.Graphics.DrawString("" + 5000 + "", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(155, C));


            //        Bottom = (int)drawRect.Bottom;
            //        count++;
            //        countNumPiezaDuplicate++;

            //        B = Bottom;

            //        //Bajar RectangleF 
            //        y += 25;
            //    }

            //    B += 10;
            //    e.Graphics.DrawString("=========================================================================================================",
            //        new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(5, B));

            //    B += 11;
            //    e.Graphics.DrawString("               Total Piezas:          " + obtenerTotalPiezas,
            //        new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(5, B));


            //    B += 13;
            //    e.Graphics.DrawString("               SubTotal:            " + obtenerSubTotal,
            //        new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(5, B));

            //    B += 14;
            //    e.Graphics.DrawString("               Descuento:         " + obtenerDescuento,
            //        new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(5, B));

            //    B += 15;
            //    e.Graphics.DrawString("               Abono:              " + obtenerAbono,
            //        new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(5, B));

            //    B += 16;
            //    e.Graphics.DrawString("               Total:            " + obtenerPrecioTotal,
            //        new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(5, B));

            //    B += 17;
            //    e.Graphics.DrawString("               Pagado:            " + strPagado,
            //        new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(5, B));

            //    B += 18;
            //    e.Graphics.DrawString("               Entregado:       " + strEntregado,
            //        new Font("Arial", 9, FontStyle.Bold), Brushes.Black, new Point(5, B));

            //    B += 31;

            //    Point p = new Point(5, B);
            //    SizeF sf = new SizeF(210, 100);
            //    RectangleF drawRect0 = new RectangleF(p, sf);

            //    e.Graphics.DrawString("Por favor, retire su pieza antes de los 30 dias de recibida para evitar perderla." + Environment.NewLine + Environment.NewLine + "GRACIAS POR PREFERIRNOS",             //////// ////////////////
            //        new Font("Arial", 9, FontStyle.Bold), Brushes.Black, drawRect0);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void frmPreviewFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsFacturaPoliza.ReporteDatosPolizaCliente' Puede moverla o quitarla según sea necesario.
            this.ReporteDatosPolizaClienteTableAdapter.Fill(this.DsFacturaPoliza.ReporteDatosPolizaCliente, idCliente);
            // TODO: esta línea de código carga datos en la tabla 'DsFacturaPoliza.ReporteDatosPolizaCliente_vhPoliza' Puede moverla o quitarla según sea necesario.
            this.ReporteDatosPolizaCliente_vhPolizaTableAdapter.Fill(this.DsFacturaPoliza.ReporteDatosPolizaCliente_vhPoliza, idPoliza);


            ReportParameterCollection parTotal = new ReportParameterCollection();
            parTotal.Add(new ReportParameter("parTotal", Total.ToString()));
            reportViewer1.LocalReport.SetParameters(parTotal);

            ReportParameterCollection parAseguradoParcial = new ReportParameterCollection();
            parAseguradoParcial.Add(new ReportParameter("parAseguradoParcial", strTipoPago));
            reportViewer1.LocalReport.SetParameters(parAseguradoParcial);

            this.reportViewer1.RefreshReport();
        }
    }
}
