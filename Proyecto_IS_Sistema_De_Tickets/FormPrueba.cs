using BE;
using BL;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_IS_Sistema_De_Tickets
{
    public partial class FormPrueba : Form
    {
        private bool _registroVisible = false;   // estado del bloque de registro
        private bool _regRolesCargados = false;  // ya lo tenés: lo dejamos 
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
            var roles = string.Join(", ", SessionManager.Instancia.UsuarioActual.Roles.Select(r => r.Nombre));
            this.Text = $"FormPrueba - {SessionManager.Instancia.UsuarioActual.Email} [{roles}]";

            // Ocultar bloque de registro al iniciar
            SetRegistrarVisible(false);

            // Asegurar modo contraseña y toggle “Mostrar contraseña”
            txtContraseña.UseSystemPasswordChar = true;
            txtConfirmarContraseña.UseSystemPasswordChar = true;
            chkMostrarContraseña.CheckedChanged += (s, ev) =>
            {
                bool ver = chkMostrarContraseña.Checked;
                txtContraseña.UseSystemPasswordChar = !ver;
                txtConfirmarContraseña.UseSystemPasswordChar = !ver;
            };

        }
        private void ResetRegistrarForm()
        {
            txtEmail.Text = "";
            txtNombre.Text = "";
            txtContraseña.Text = "";
            txtConfirmarContraseña.Text = "";
            chkMostrarContraseña.Checked = false;
            chkActivo.Checked = true;

            // si ya agregaste ErrorProvider, también podés limpiar acá:
            // errorProviderReg.Clear();

            // desmarcar roles si hubiera
            for (int i = 0; i < clbRoles.Items.Count; i++)
                clbRoles.SetItemChecked(i, false);

            // password oculto
            txtContraseña.UseSystemPasswordChar = true;
            txtConfirmarContraseña.UseSystemPasswordChar = true;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Cierra la sesión en DB (marca FinUtc y escribe auditoría)
            AuthService.Instancia.Logout();

            // Volvemos limpio al login (lo más simple para WinForms)
            Application.Restart();
        }
        private void SetRegistrarVisible(bool v)
        {
            // Labels (ajustá los nombres si tenés otros)
            lblEmail.Visible = v;
            lblNombre.Visible = v;
            lblContraseña.Visible = v;
            lblConfirmarContraseña.Visible = v;

            // Inputs
            txtEmail.Visible = v;
            txtNombre.Visible = v;
            txtContraseña.Visible = v;
            txtConfirmarContraseña.Visible = v;
            clbRoles.Visible = v;

            // Checks
            chkMostrarContraseña.Visible = v;
            chkActivo.Visible = v;

            // Botones del bloque de registro
            btnGuardar.Visible = v;   // ← este es el “Guardar” que se ve en tu captura
            btnCancelar.Visible = v;
        }

        private void CargarRolesDesdeBD()
        {
            try
            {
                clbRoles.CheckOnClick = true;
                clbRoles.Items.Clear();

                var roles = UserAdminService.Instancia.ListarRoles();  // BL → DAL → BD
                foreach (var r in roles)
                    clbRoles.Items.Add(r, false);  // BE.Rol.ToString() => Nombre
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tenés permisos de Administrador.");
                _registroVisible = false;
                SetRegistrarVisible(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message);
                _registroVisible = false;
                SetRegistrarVisible(false);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _registroVisible = false;
            SetRegistrarVisible(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones simples en UI
            string email = txtEmail.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string pass1 = txtContraseña.Text;
            string pass2 = txtConfirmarContraseña.Text;
            bool activo = chkActivo.Checked;

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                MessageBox.Show("Email inválido."); txtEmail.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Nombre requerido."); txtNombre.Focus(); return;
            }
            if (pass1.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres."); txtContraseña.Focus(); return;
            }
            if (pass1 != pass2)
            {
                MessageBox.Show("Las contraseñas no coinciden."); txtConfirmarContraseña.Focus(); return;
            }
            if (clbRoles.CheckedItems.Count == 0)
            {
                MessageBox.Show("Seleccioná al menos un rol."); clbRoles.Focus(); return;
            }

            var rolesIds = clbRoles.CheckedItems.Cast<BE.Rol>().Select(r => r.Id).ToList();

            try
            {
                int nuevoId = UserAdminService.Instancia.CrearUsuario(email, nombre, pass1, activo, rolesIds);
                MessageBox.Show("Usuario creado. Id=" + nuevoId);

                // Limpiar u ocultar la sección (como prefieras)
                _registroVisible = false;
                SetRegistrarVisible(false);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex) // email duplicado
            {
                MessageBox.Show(ex.Message);
                txtEmail.Focus();
            }
            catch (ArgumentException ex) // alguna validación de BL
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void TabGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabGeneral.SelectedIndex)
            {
                case 0: // Primera pestaña "Menu Principal"
                        // Lógica para la primera tab
                    MessageBox.Show("Estás en Menu Principal");
                    break;
                case 1:
                    if (!BL.SessionManager.Instancia.TieneRol("Administrador"))
                    {
                        MessageBox.Show("Solo un Administrador puede registrar usuarios.");
                        // Volvemos a la pestaña anterior
                        tabGeneral.SelectedIndex = 0;
                        return;
                    }

                    _registroVisible = true;
                    SetRegistrarVisible(true);

                    ResetRegistrarForm();
                    if (!_regRolesCargados)
                    {
                        CargarRolesDesdeBD();   // ahora trae de la BD
                        _regRolesCargados = true;
                    }
                    break;
                case 2:
                    if (!BL.SessionManager.Instancia.TieneRol("Administrador"))
                    {
                        MessageBox.Show("Solo un Administrador puede ver la Bitácora.");
                        tabGeneral.SelectedIndex = 0;
                        return;
                    }

                    CargarEventosBitacoraHardcoded();

                    // defaults de fechas (sin “limitar”)
                    dtpDesde.Value = new DateTime(2000, 1, 1);
                    dtpHasta.Value = DateTime.Today.AddDays(1);

                    // carga inicial (sin filtros de texto)
                    var repoInit = new AuditoriaRepository();
                    dgvBitacora.AutoGenerateColumns = true;
                    dgvBitacora.DataSource = repoInit.FiltrarAuditoria(
                        id: null,
                        usuarioId: null,
                        evento: null,
                        texto: null,
                        desdeUtc: DateTime.SpecifyKind(dtpDesde.Value.Date, DateTimeKind.Local).ToUniversalTime(),
                        hastaUtcExcl: DateTime.SpecifyKind(dtpHasta.Value.Date.AddDays(1), DateTimeKind.Local).ToUniversalTime()
                    );

                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFiltrarBitacora_Click(object sender, EventArgs e)
        {
            int? id = int.TryParse(txtAuditoriaId.Text, out var vId) ? vId : (int?)null;
            int? usuarioId = int.TryParse(txtId.Text, out var vUid) ? vUid : (int?)null;

            string evento = string.IsNullOrWhiteSpace(cmbEvento.Text)
                ? null
                : cmbEvento.Text.Trim().ToUpperInvariant();

            string texto = string.IsNullOrWhiteSpace(txtTexto.Text)
                ? null
                : txtTexto.Text.Trim();

            var desdeUtc = DateTime.SpecifyKind(dtpDesde.Value.Date, DateTimeKind.Local).ToUniversalTime();
            var hastaUtcExcl = DateTime.SpecifyKind(dtpHasta.Value.Date.AddDays(1), DateTimeKind.Local).ToUniversalTime();

            var repo = new AuditoriaRepository();
            var datos = repo.FiltrarAuditoria(id, usuarioId, evento, texto, desdeUtc, hastaUtcExcl);

            dgvBitacora.AutoGenerateColumns = true;
            dgvBitacora.DataSource = datos;

            if (dgvBitacora.Columns["FechaUtc"] != null)
                dgvBitacora.Columns["FechaUtc"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            if (dgvBitacora.Columns["Detalle"] != null)
                dgvBitacora.Columns["Detalle"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAuditoriaId.Clear();
            txtId.Clear();
            cmbEvento.SelectedIndex = -1; // vacío
            txtTexto.Clear();
            dtpDesde.Value = new DateTime(2000, 1, 1);
            dtpHasta.Value = DateTime.Today.AddDays(1);

            // defaults de fechas (sin “limitar”)
            dtpDesde.Value = new DateTime(2000, 1, 1);
            dtpHasta.Value = DateTime.Today.AddDays(1);

            // carga inicial (sin filtros de texto)
            var repoInit = new AuditoriaRepository();
            dgvBitacora.AutoGenerateColumns = true;
            dgvBitacora.DataSource = repoInit.FiltrarAuditoria(
                id: null,
                usuarioId: null,
                evento: null,
                texto: null,
                desdeUtc: DateTime.SpecifyKind(dtpDesde.Value.Date, DateTimeKind.Local).ToUniversalTime(),
                hastaUtcExcl: DateTime.SpecifyKind(dtpHasta.Value.Date.AddDays(1), DateTimeKind.Local).ToUniversalTime()
            );

        }
        private bool _eventosCargados = false;

        private void CargarEventosBitacoraHardcoded()
        {
            if (_eventosCargados) return;

            cmbEvento.Items.Clear();
            cmbEvento.Items.Add(""); // = “Todos”
            cmbEvento.Items.AddRange(new object[] {
        "APP_START","APP_EXIT","LOGIN_OK","LOGIN_FAIL","LOGIN_BLOQUEADO",
        "LOGOUT","PERMISO_DENEGADO","CAMBIO_PASSWORD",
        "ALTA_USUARIO","BAJA_USUARIO","MODIFICACION_USUARIO"
    });
            cmbEvento.SelectedIndex = 0;
            _eventosCargados = true;
        }
    }
}


