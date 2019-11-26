using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace CapaPresentacion
{
    public partial class frmDescripcionSeguros : Form
    {
            [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();
            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            private extern static void SendMessage(System.IntPtr hwnd,
                int wmsg, int wparam, int lparam);

        public bool DescrepcionValue = false;

        public frmDescripcionSeguros()
        {
            InitializeComponent();
        }

        private void frmDescripcionSeguros_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            frmSeguroVida sv = new frmSeguroVida(true);
            frmSolicitud st = new frmSolicitud(true);
            Close();
        }

        private void lblDescripcion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        string strBotonSelected = "";

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FrmSeguroVida();
            FrmSolicitud();
        }

        public void FrmSeguroVida()
        {
            frmSeguroVida dv;
            switch (strBotonSelected)
            {
                case "Básico - A":
                    dv = new frmSeguroVida(strBotonSelected);
                    Close();
                    break;
                case "Básico - B":
                    dv = new frmSeguroVida(strBotonSelected);
                    Close();
                    break;
                case "Básico - C":
                    dv = new frmSeguroVida(strBotonSelected);
                    Close();
                    break;

                case "Semi Full - A":
                    dv = new frmSeguroVida(strBotonSelected);
                    Close();
                    break;
                case "Semi Full - B":
                    dv = new frmSeguroVida(strBotonSelected);
                    Close();
                    break;
                case "Semi Full - C":
                    dv = new frmSeguroVida(strBotonSelected);
                    Close();
                    break;

                case "Full - A":
                    dv = new frmSeguroVida(strBotonSelected);
                    Close();
                    break;
                case "Full - B":
                    dv = new frmSeguroVida(strBotonSelected);
                    Close();
                    break;
                case "Full - C":
                    dv = new frmSeguroVida(strBotonSelected);
                    Close();
                    break;

                default:
                    MessageBox.Show("Seleccione un Tipo de seguro y vuelva a intentarlo.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

            }
        }

        public void FrmSolicitud()
        {
            frmSolicitud Sd;
            switch (strBotonSelected)
            {
                case "Básico - A":
                    Sd = new frmSolicitud(strBotonSelected);
                    Close();
                    break;
                case "Básico - B":
                    Sd = new frmSolicitud(strBotonSelected);
                    Close();
                    break;
                case "Básico - C":
                    Sd = new frmSolicitud(strBotonSelected);
                    Close();
                    break;

                case "Semi Full - A":
                    Sd = new frmSolicitud(strBotonSelected);
                    Close();
                    break;
                case "Semi Full - B":
                    Sd = new frmSolicitud(strBotonSelected);
                    Close();
                    break;
                case "Semi Full - C":
                    Sd = new frmSolicitud(strBotonSelected);
                    Close();
                    break;

                case "Full - A":
                    Sd = new frmSolicitud(strBotonSelected);
                    Close();
                    break;
                case "Full - B":
                    Sd = new frmSolicitud(strBotonSelected);
                    Close();
                    break;
                case "Full - C":
                    Sd = new frmSolicitud(strBotonSelected);
                    Close();
                    break;

                default:
                    MessageBox.Show("Seleccione un Tipo de seguro y vuelva a intentarlo.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        public void ResetPanls()
        {
            pnlBasico.BackColor = Color.White;
            BasicoA.BackColor = Color.White;
            BasicoB.BackColor = Color.White;
            BasicoC.BackColor = Color.White;

            pnlSemiFull.BackColor = Color.White;
            SemiFullA.BackColor = Color.White;
            SemiFullB.BackColor = Color.White;
            SemiFullC.BackColor = Color.White;

            pnlFull.BackColor = Color.White;
            FullA.BackColor = Color.White;
            FullB.BackColor = Color.White;
            FullC.BackColor = Color.White;
        }

        public void Basico(string categoria)
        {
            ResetPanls();

            if (categoria == "A")
            {
                strBotonSelected = "Básico - A";
                pnlBasico.BackColor = Color.Azure;
                BasicoA.BackColor = Color.LightSkyBlue;
            }
            else if (categoria == "B")
            {
                strBotonSelected = "Básico - B";
                pnlBasico.BackColor = Color.Azure;
                BasicoB.BackColor = Color.LightSkyBlue;
            }
            else if (categoria == "C")
            {
                strBotonSelected = "Básico - C";
                pnlBasico.BackColor = Color.Azure;
                BasicoC.BackColor = Color.LightSkyBlue;
            }
        }

        private void BasicoA_Click(object sender, EventArgs e)
        {
            Basico("A");
        }

        private void BasicoB_Click(object sender, EventArgs e)
        {
            Basico("B");
        }

        private void BasicoC_Click(object sender, EventArgs e)
        {
            Basico("C");
        }

        public void SemiFull(string categoria)
        {
            ResetPanls();

            if (categoria == "A")
            {
                strBotonSelected = "Semi Full - A";
                pnlSemiFull.BackColor = Color.Azure;
                SemiFullA.BackColor = Color.LightSkyBlue;
            }
            else if (categoria == "B")
            {
                strBotonSelected = "Semi Full - B";
                pnlSemiFull.BackColor = Color.Azure;
                SemiFullB.BackColor = Color.LightSkyBlue;
            }
            else if (categoria == "C")
            {
                strBotonSelected = "Semi Full - C";
                pnlSemiFull.BackColor = Color.Azure;
                SemiFullC.BackColor = Color.LightSkyBlue;
            }
        }

        private void SemiFullA_Click(object sender, EventArgs e)
        {
            SemiFull("A");
        }

        private void SemiFullB_Click(object sender, EventArgs e)
        {
            SemiFull("B");
        }

        private void SemiFullC_Click(object sender, EventArgs e)
        {
            SemiFull("C");
        }

        public void Full(string categoria)
        {
            ResetPanls();

            if (categoria == "A")
            {
                strBotonSelected = "Full - A";
                pnlFull.BackColor = Color.Azure;
                FullA.BackColor = Color.LightSkyBlue;
            }
            else if (categoria == "B")
            {
                strBotonSelected = "Full - B";
                pnlFull.BackColor = Color.Azure;
                FullB.BackColor = Color.LightSkyBlue;
            }
            else if (categoria == "C")
            {
                strBotonSelected = "Full - C";
                pnlFull.BackColor = Color.Azure;
                FullC.BackColor = Color.LightSkyBlue;
            }
        }


        private void FullA_Click(object sender, EventArgs e)
        {
            Full("A");
        }

        private void FullB_Click(object sender, EventArgs e)
        {
            Full("B");
        }

        private void FullC_Click(object sender, EventArgs e)
        {
            Full("C");
        }
    }
}
