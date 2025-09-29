using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace Proyecto_IS_Sistema_De_Tickets
{
    public partial class FormPrueba : Form
    {
        public FormPrueba()
        {
            InitializeComponent();
        }

        private void FormPrueba_Load(object sender, EventArgs e)
        {
            // Si alguien abre sin login, por seguridad:
            if (SessionManager.Instancia.UsuarioActual == null)
            {
                MessageBox.Show("La sesión no está activa. Volviendo al login.");
                Application.Restart();
                return;
            }

            // Mostrar/ocultar según rol
            bool esAdmin = SessionManager.Instancia.TieneRol("Administrador");
            btnRegistrar.Visible = esAdmin;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Cierra la sesión en DB (marca FinUtc y escribe auditoría)
            AuthService.Instancia.Logout();

            // Volvemos limpio al login (lo más simple para WinForms)
            Application.Restart();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!BL.SessionManager.Instancia.TieneRol("Administrador"))
            {
                MessageBox.Show("Solo un Administrador puede registrar usuarios.");
                return;
            }

            // TODO: Abrir formulario de alta (lo armamos en el próximo paso)
            MessageBox.Show("Pantalla de registro de usuario (pendiente).");
        }
    }
}

