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
            this.tabMenuPrincipal = new System.Windows.Forms.TabPage();
            this.tabRegistrar = new System.Windows.Forms.TabPage();
            this.tabBitacora = new System.Windows.Forms.TabPage();
            this.btnFiltrarBitacora = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtAuditoriaId = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblUsuarioId = new System.Windows.Forms.Label();
            this.lblAuditoriaId = new System.Windows.Forms.Label();
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabGeneral.SuspendLayout();
            this.tabRegistrar.SuspendLayout();
            this.tabBitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 417);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(108, 23);
            this.btnCerrarSesion.TabIndex = 0;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(274, 56);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(213, 59);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(213, 99);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(274, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(213, 137);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 7;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(274, 134);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 6;
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(160, 163);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(108, 13);
            this.lblConfirmarContraseña.TabIndex = 9;
            this.lblConfirmarContraseña.Text = "Confirmar Contraseña";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(274, 160);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmarContraseña.TabIndex = 8;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(274, 186);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(95, 17);
            this.chkActivo.TabIndex = 11;
            this.chkActivo.Text = "Usuario Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(265, 255);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(423, 255);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
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
            this.clbRoles.Location = new System.Drawing.Point(380, 56);
            this.clbRoles.Name = "clbRoles";
            this.clbRoles.Size = new System.Drawing.Size(136, 124);
            this.clbRoles.TabIndex = 14;
            // 
            // chkMostrarContraseña
            // 
            this.chkMostrarContraseña.AutoSize = true;
            this.chkMostrarContraseña.Location = new System.Drawing.Point(274, 209);
            this.chkMostrarContraseña.Name = "chkMostrarContraseña";
            this.chkMostrarContraseña.Size = new System.Drawing.Size(118, 17);
            this.chkMostrarContraseña.TabIndex = 15;
            this.chkMostrarContraseña.Text = "Mostrar Contraseña";
            this.chkMostrarContraseña.UseVisualStyleBackColor = true;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabMenuPrincipal);
            this.tabGeneral.Controls.Add(this.tabRegistrar);
            this.tabGeneral.Controls.Add(this.tabBitacora);
            this.tabGeneral.Location = new System.Drawing.Point(9, 2);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(768, 409);
            this.tabGeneral.TabIndex = 17;
            this.tabGeneral.SelectedIndexChanged += new System.EventHandler(this.TabGeneral_SelectedIndexChanged);
            // 
            // tabMenuPrincipal
            // 
            this.tabMenuPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabMenuPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMenuPrincipal.Name = "tabMenuPrincipal";
            this.tabMenuPrincipal.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMenuPrincipal.Size = new System.Drawing.Size(760, 383);
            this.tabMenuPrincipal.TabIndex = 2;
            this.tabMenuPrincipal.Text = "Menu Principal";
            this.tabMenuPrincipal.UseVisualStyleBackColor = true;
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
            this.tabRegistrar.Location = new System.Drawing.Point(4, 22);
            this.tabRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRegistrar.Name = "tabRegistrar";
            this.tabRegistrar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabRegistrar.Size = new System.Drawing.Size(760, 383);
            this.tabRegistrar.TabIndex = 0;
            this.tabRegistrar.Text = "Registrar";
            this.tabRegistrar.UseVisualStyleBackColor = true;
            // 
            // tabBitacora
            // 
            this.tabBitacora.Controls.Add(this.lblFecha);
            this.tabBitacora.Controls.Add(this.lblDetalle);
            this.tabBitacora.Controls.Add(this.lblEvento);
            this.tabBitacora.Controls.Add(this.lblAuditoriaId);
            this.tabBitacora.Controls.Add(this.lblUsuarioId);
            this.tabBitacora.Controls.Add(this.btnLimpiar);
            this.tabBitacora.Controls.Add(this.txtAuditoriaId);
            this.tabBitacora.Controls.Add(this.btnFiltrarBitacora);
            this.tabBitacora.Controls.Add(this.dtpHasta);
            this.tabBitacora.Controls.Add(this.dtpDesde);
            this.tabBitacora.Controls.Add(this.cmbEvento);
            this.tabBitacora.Controls.Add(this.txtTexto);
            this.tabBitacora.Controls.Add(this.txtId);
            this.tabBitacora.Controls.Add(this.dgvBitacora);
            this.tabBitacora.Location = new System.Drawing.Point(4, 22);
            this.tabBitacora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBitacora.Name = "tabBitacora";
            this.tabBitacora.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBitacora.Size = new System.Drawing.Size(760, 383);
            this.tabBitacora.TabIndex = 1;
            this.tabBitacora.Text = "Bitacora";
            this.tabBitacora.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarBitacora
            // 
            this.btnFiltrarBitacora.Location = new System.Drawing.Point(610, 347);
            this.btnFiltrarBitacora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrarBitacora.Name = "btnFiltrarBitacora";
            this.btnFiltrarBitacora.Size = new System.Drawing.Size(56, 19);
            this.btnFiltrarBitacora.TabIndex = 10;
            this.btnFiltrarBitacora.Text = "Filtrar";
            this.btnFiltrarBitacora.UseVisualStyleBackColor = true;
            this.btnFiltrarBitacora.Click += new System.EventHandler(this.btnFiltrarBitacora_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(605, 311);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(151, 20);
            this.dtpHasta.TabIndex = 9;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(605, 287);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(151, 20);
            this.dtpDesde.TabIndex = 8;
            // 
            // cmbEvento
            // 
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Location = new System.Drawing.Point(605, 148);
            this.cmbEvento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(92, 21);
            this.cmbEvento.TabIndex = 6;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(605, 209);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(92, 20);
            this.txtTexto.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(605, 45);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(92, 20);
            this.txtId.TabIndex = 1;
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.AllowUserToOrderColumns = true;
            this.dgvBitacora.AllowUserToResizeColumns = false;
            this.dgvBitacora.AllowUserToResizeRows = false;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Location = new System.Drawing.Point(20, 14);
            this.dgvBitacora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.RowHeadersWidth = 51;
            this.dgvBitacora.RowTemplate.Height = 24;
            this.dgvBitacora.Size = new System.Drawing.Size(569, 352);
            this.dgvBitacora.TabIndex = 0;
            this.dgvBitacora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtAuditoriaId
            // 
            this.txtAuditoriaId.Location = new System.Drawing.Point(603, 102);
            this.txtAuditoriaId.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuditoriaId.Name = "txtAuditoriaId";
            this.txtAuditoriaId.Size = new System.Drawing.Size(94, 20);
            this.txtAuditoriaId.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(684, 347);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(56, 19);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblUsuarioId
            // 
            this.lblUsuarioId.AutoSize = true;
            this.lblUsuarioId.Location = new System.Drawing.Point(604, 14);
            this.lblUsuarioId.Name = "lblUsuarioId";
            this.lblUsuarioId.Size = new System.Drawing.Size(55, 13);
            this.lblUsuarioId.TabIndex = 14;
            this.lblUsuarioId.Text = "Usuario Id";
            // 
            // lblAuditoriaId
            // 
            this.lblAuditoriaId.AutoSize = true;
            this.lblAuditoriaId.Location = new System.Drawing.Point(604, 77);
            this.lblAuditoriaId.Name = "lblAuditoriaId";
            this.lblAuditoriaId.Size = new System.Drawing.Size(60, 13);
            this.lblAuditoriaId.TabIndex = 15;
            this.lblAuditoriaId.Text = "Auditoria Id";
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(604, 133);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(41, 13);
            this.lblEvento.TabIndex = 16;
            this.lblEvento.Text = "Evento";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(604, 185);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblDetalle.TabIndex = 17;
            this.lblDetalle.Text = "Detalle";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(604, 258);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Fecha";
            // 
            // FormPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabGeneral);
            this.Controls.Add(this.btnCerrarSesion);
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
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.ComboBox cmbEvento;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnFiltrarBitacora;
        private System.Windows.Forms.TextBox txtAuditoriaId;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblUsuarioId;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblAuditoriaId;
    }
}