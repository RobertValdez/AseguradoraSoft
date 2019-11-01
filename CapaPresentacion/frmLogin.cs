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

using PerlaDelSur_Entity.Usuarios;
using CapaNegocio.Usuarios;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        E_Usuarios E_Usuarios = new E_Usuarios();
        B_Usuarios B_Usuarios = new B_Usuarios();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,
            int wmsg, int wparam, int lparam);
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtUsuario.Text != "" && txtContrasena.Text != "")
                {
                    E_Usuarios.NombreUsuario = txtUsuario.Text;
                    E_Usuarios.Contrasena = txtContrasena.Text;

                    if (B_Usuarios.ComprobarAcceso(E_Usuarios) == 1)
                    {
                        frmMenuPrincipal mp = new frmMenuPrincipal();
                        mp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario o la contraseña no son correctos. Por favor intentelo de nuevo.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtUsuario.Text = "";
                        txtContrasena.Text = "";
                        txtUsuario.Focus();
                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
