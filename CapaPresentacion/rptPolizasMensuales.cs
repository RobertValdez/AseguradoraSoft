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
    public partial class rptPolizasMensuales : Form
    {
        public rptPolizasMensuales()
        {
            InitializeComponent();
        }

        private void rptPolizasMensuales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSPolizasEmitidasPorMes.PolizasEmitidasAlMes' Puede moverla o quitarla según sea necesario.
            this.PolizasEmitidasAlMesTableAdapter.Fill(this.DSPolizasEmitidasPorMes.PolizasEmitidasAlMes);

            this.reportViewer1.RefreshReport();
        }
    }
}
