﻿using System;
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
    public partial class frmLogin : Form
    {
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
            frmMenuPrincipal mp = new frmMenuPrincipal();
            mp.Show();
            this.Hide();
        }

        private void lblCerrarRegistrarse_Click(object sender, EventArgs e)
        {
            pnlRegistrarse.Visible = false;
        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            pnlRegistrarse.Visible = true;
        }
    }
}
