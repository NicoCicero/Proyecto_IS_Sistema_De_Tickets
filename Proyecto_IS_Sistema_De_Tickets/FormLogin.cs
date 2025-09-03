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
using BL;

namespace Proyecto_IS_Sistema_De_Tickets
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        #region Diseño
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_Usuario_Enter(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "USUARIO")
            {
                txt_Usuario.Text = "";
            }
        }

        private void txt_Usuario_Leave(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "")
            {
                txt_Usuario.Text = "USUARIO";
            }
        }

        private void txt_Contraseña_Enter(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text == "CONTRASEÑA")
            {
                txt_Contraseña.Text = "";
                txt_Contraseña.UseSystemPasswordChar = true;
            }
        }

        private void txt_Contraseña_Leave(object sender, EventArgs e)
        {
            if (txt_Contraseña.Text == "")
            {
                txt_Contraseña.Text = "CONTRASEÑA";
                txt_Contraseña.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        private void btn_Acceder_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text != "USUARIO")
            {
                if (txt_Contraseña.Text != "CONTRASEÑA")
                {
                    UserLoginBL user = new UserLoginBL();
                    var validLogin = user.LoginUser(txt_Usuario.Text, txt_Contraseña.Text);
                    if (validLogin)
                    {
                        this.Hide();
                        FormPrueba main = new FormPrueba();
                        main.Show();
                    }
                    else
                    {
                        MsgError("Usuario o Contraseña incorrecta");
                        txt_Contraseña.Clear();
                        txt_Usuario.Focus();
                    }
                }
                else
                {
                    MsgError("Por favor ingrese una contraseña");
                }
            }
            else
            {
                MsgError("Por favor ingrese un usuario");
            }
        }
        private void MsgError(string msg)
        {
            lblError.Text = "     " + msg;
            lblError.Visible = true;
        }
    }
}
