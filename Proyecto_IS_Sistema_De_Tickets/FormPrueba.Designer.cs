namespace Proyecto_IS_Sistema_De_Tickets
{
    partial class FormPrueba
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
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.clbRoles = new System.Windows.Forms.CheckedListBox();
            this.chkMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabRegistrar = new System.Windows.Forms.TabPage();
            this.tabBitacora = new System.Windows.Forms.TabPage();
            this.tabMenuPrincipal = new System.Windows.Forms.TabPage();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.chkId = new System.Windows.Forms.CheckBox();
            this.chkEvento = new System.Windows.Forms.CheckBox();
            this.chkTexto = new System.Windows.Forms.CheckBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrarBitacora = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabGeneral.SuspendLayout();
            this.tabRegistrar.SuspendLayout();
            this.tabBitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(16, 513);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(144, 28);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(365, 69);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(284, 73);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(284, 122);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(365, 118);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(284, 169);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 16);
            this.lblContraseña.TabIndex = 7;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(365, 165);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(132, 22);
            this.txtContraseña.TabIndex = 6;
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(213, 201);
            this.lblConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(136, 16);
            this.lblConfirmarContraseña.TabIndex = 9;
            this.lblConfirmarContraseña.Text = "Confirmar Contraseña";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(365, 197);
            this.txtConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(132, 22);
            this.txtConfirmarContraseña.TabIndex = 8;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(365, 229);
            this.chkActivo.Margin = new System.Windows.Forms.Padding(4);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(116, 20);
            this.chkActivo.TabIndex = 11;
            this.chkActivo.Text = "Usuario Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(353, 314);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(564, 314);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // clbRoles
            // 
            this.clbRoles.CheckOnClick = true;
            this.clbRoles.FormattingEnabled = true;
            this.clbRoles.Location = new System.Drawing.Point(507, 69);
            this.clbRoles.Margin = new System.Windows.Forms.Padding(4);
            this.clbRoles.Name = "clbRoles";
            this.clbRoles.Size = new System.Drawing.Size(180, 157);
            this.clbRoles.TabIndex = 14;
            // 
            // chkMostrarContraseña
            // 
            this.chkMostrarContraseña.AutoSize = true;
            this.chkMostrarContraseña.Location = new System.Drawing.Point(365, 257);
            this.chkMostrarContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.chkMostrarContraseña.Name = "chkMostrarContraseña";
            this.chkMostrarContraseña.Size = new System.Drawing.Size(146, 20);
            this.chkMostrarContraseña.TabIndex = 15;
            this.chkMostrarContraseña.Text = "Mostrar Contraseña";
            this.chkMostrarContraseña.UseVisualStyleBackColor = true;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabMenuPrincipal);
            this.tabGeneral.Controls.Add(this.tabRegistrar);
            this.tabGeneral.Controls.Add(this.tabBitacora);
            this.tabGeneral.Location = new System.Drawing.Point(12, 3);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(1024, 503);
            this.tabGeneral.TabIndex = 17;
            this.tabGeneral.SelectedIndexChanged += new System.EventHandler(this.TabGeneral_SelectedIndexChanged);
            // 
            // tabRegistrar
            // 
            this.tabRegistrar.Controls.Add(this.clbRoles);
            this.tabRegistrar.Controls.Add(this.chkMostrarContraseña);
            this.tabRegistrar.Controls.Add(this.txtEmail);
            this.tabRegistrar.Controls.Add(this.lblEmail);
            this.tabRegistrar.Controls.Add(this.btnCancelar);
            this.tabRegistrar.Controls.Add(this.txtNombre);
            this.tabRegistrar.Controls.Add(this.btnGuardar);
            this.tabRegistrar.Controls.Add(this.lblNombre);
            this.tabRegistrar.Controls.Add(this.chkActivo);
            this.tabRegistrar.Controls.Add(this.txtContraseña);
            this.tabRegistrar.Controls.Add(this.lblConfirmarContraseña);
            this.tabRegistrar.Controls.Add(this.lblContraseña);
            this.tabRegistrar.Controls.Add(this.txtConfirmarContraseña);
            this.tabRegistrar.Location = new System.Drawing.Point(4, 25);
            this.tabRegistrar.Name = "tabRegistrar";
            this.tabRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistrar.Size = new System.Drawing.Size(1016, 474);
            this.tabRegistrar.TabIndex = 0;
            this.tabRegistrar.Text = "Registrar";
            this.tabRegistrar.UseVisualStyleBackColor = true;
            // 
            // tabBitacora
            // 
            this.tabBitacora.Controls.Add(this.btnFiltrarBitacora);
            this.tabBitacora.Controls.Add(this.dtpHasta);
            this.tabBitacora.Controls.Add(this.dtpDesde);
            this.tabBitacora.Controls.Add(this.chkFecha);
            this.tabBitacora.Controls.Add(this.cmbEvento);
            this.tabBitacora.Controls.Add(this.txtTexto);
            this.tabBitacora.Controls.Add(this.chkTexto);
            this.tabBitacora.Controls.Add(this.chkEvento);
            this.tabBitacora.Controls.Add(this.chkId);
            this.tabBitacora.Controls.Add(this.txtId);
            this.tabBitacora.Controls.Add(this.dgvBitacora);
            this.tabBitacora.Location = new System.Drawing.Point(4, 25);
            this.tabBitacora.Name = "tabBitacora";
            this.tabBitacora.Padding = new System.Windows.Forms.Padding(3);
            this.tabBitacora.Size = new System.Drawing.Size(1016, 474);
            this.tabBitacora.TabIndex = 1;
            this.tabBitacora.Text = "Bitacora";
            this.tabBitacora.UseVisualStyleBackColor = true;
            // 
            // tabMenuPrincipal
            // 
            this.tabMenuPrincipal.Location = new System.Drawing.Point(4, 25);
            this.tabMenuPrincipal.Name = "tabMenuPrincipal";
            this.tabMenuPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenuPrincipal.Size = new System.Drawing.Size(1016, 452);
            this.tabMenuPrincipal.TabIndex = 2;
            this.tabMenuPrincipal.Text = "Menu Principal";
            this.tabMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AllowUserToOrderColumns = true;
            this.dgvBitacora.AllowUserToResizeColumns = false;
            this.dgvBitacora.AllowUserToResizeRows = false;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Location = new System.Drawing.Point(26, 17);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.RowHeadersWidth = 51;
            this.dgvBitacora.RowTemplate.Height = 24;
            this.dgvBitacora.Size = new System.Drawing.Size(759, 433);
            this.dgvBitacora.TabIndex = 0;
            this.dgvBitacora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(825, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(103, 22);
            this.txtId.TabIndex = 1;
            // 
            // chkId
            // 
            this.chkId.AutoSize = true;
            this.chkId.Location = new System.Drawing.Point(825, 30);
            this.chkId.Name = "chkId";
            this.chkId.Size = new System.Drawing.Size(87, 20);
            this.chkId.TabIndex = 2;
            this.chkId.Text = "UsuarioId";
            this.chkId.UseVisualStyleBackColor = true;
            // 
            // chkEvento
            // 
            this.chkEvento.AutoSize = true;
            this.chkEvento.Location = new System.Drawing.Point(825, 103);
            this.chkEvento.Name = "chkEvento";
            this.chkEvento.Size = new System.Drawing.Size(71, 20);
            this.chkEvento.TabIndex = 3;
            this.chkEvento.Text = "Evento";
            this.chkEvento.UseVisualStyleBackColor = true;
            // 
            // chkTexto
            // 
            this.chkTexto.AutoSize = true;
            this.chkTexto.Location = new System.Drawing.Point(825, 129);
            this.chkTexto.Name = "chkTexto";
            this.chkTexto.Size = new System.Drawing.Size(63, 20);
            this.chkTexto.TabIndex = 4;
            this.chkTexto.Text = "Texto";
            this.chkTexto.UseVisualStyleBackColor = true;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(825, 155);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(103, 22);
            this.txtTexto.TabIndex = 5;
            // 
            // cmbEvento
            // 
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Location = new System.Drawing.Point(825, 195);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(121, 24);
            this.cmbEvento.TabIndex = 6;
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Location = new System.Drawing.Point(825, 248);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(67, 20);
            this.chkFecha.TabIndex = 7;
            this.chkFecha.Text = "Fecha";
            this.chkFecha.UseVisualStyleBackColor = true;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(813, 290);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 22);
            this.dtpDesde.TabIndex = 8;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(813, 329);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 22);
            this.dtpHasta.TabIndex = 9;
            // 
            // btnFiltrarBitacora
            // 
            this.btnFiltrarBitacora.Location = new System.Drawing.Point(825, 384);
            this.btnFiltrarBitacora.Name = "btnFiltrarBitacora";
            this.btnFiltrarBitacora.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarBitacora.TabIndex = 10;
            this.btnFiltrarBitacora.Text = "Filtrar";
            this.btnFiltrarBitacora.UseVisualStyleBackColor = true;
            this.btnFiltrarBitacora.Click += new System.EventHandler(this.btnFiltrarBitacora_Click);
            // 
            // FormPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabGeneral);
            this.Controls.Add(this.btnCerrarSesion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrueba";
            this.Text = "FormPrueba";
            this.Load += new System.EventHandler(this.FormPrueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabGeneral.ResumeLayout(false);
            this.tabRegistrar.ResumeLayout(false);
            this.tabRegistrar.PerformLayout();
            this.tabBitacora.ResumeLayout(false);
            this.tabBitacora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckedListBox clbRoles;
        private System.Windows.Forms.CheckBox chkMostrarContraseña;
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabRegistrar;
        private System.Windows.Forms.TabPage tabBitacora;
        private System.Windows.Forms.TabPage tabMenuPrincipal;
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chkId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox chkTexto;
        private System.Windows.Forms.CheckBox chkEvento;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.ComboBox cmbEvento;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnFiltrarBitacora;
    }
}