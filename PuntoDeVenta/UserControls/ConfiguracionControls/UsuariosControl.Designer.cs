namespace PuntoDeVenta.UserControls.ConfiguracionControls
{
    partial class UsuariosControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosControl));
            labelTitle = new Label();
            panelMain = new Panel();
            panelUsuarios = new Panel();
            labelTitleGrid = new Label();
            panelDatosUsuario = new Panel();
            checkHabilitado = new CheckBox();
            txtPassword = new TextBox();
            labelPassword = new Label();
            txtUsuario = new TextBox();
            labelUsuario = new Label();
            txtApellido = new TextBox();
            labelApellido = new Label();
            txtNombre = new TextBox();
            labelNombre = new Label();
            txtEmail = new TextBox();
            labelEmail = new Label();
            btnGuardar = new Button();
            labelPerfil = new Label();
            comboPerfil = new ComboBox();
            panelHeader = new Panel();
            panelDataGrid = new Panel();
            labelSinResultados = new Label();
            dvUsuarios = new DataGridView();
            panelMain.SuspendLayout();
            panelUsuarios.SuspendLayout();
            panelDatosUsuario.SuspendLayout();
            panelHeader.SuspendLayout();
            panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ButtonHighlight;
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(162, 25);
            labelTitle.TabIndex = 27;
            labelTitle.Text = "NUEVO USUARIO";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelUsuarios);
            panelMain.Controls.Add(panelDatosUsuario);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1061, 645);
            panelMain.TabIndex = 28;
            // 
            // panelUsuarios
            // 
            panelUsuarios.Controls.Add(panelDataGrid);
            panelUsuarios.Controls.Add(panelHeader);
            panelUsuarios.Dock = DockStyle.Fill;
            panelUsuarios.Location = new Point(302, 0);
            panelUsuarios.Name = "panelUsuarios";
            panelUsuarios.Size = new Size(759, 645);
            panelUsuarios.TabIndex = 29;
            // 
            // labelTitleGrid
            // 
            labelTitleGrid.AutoSize = true;
            labelTitleGrid.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitleGrid.ForeColor = SystemColors.ButtonHighlight;
            labelTitleGrid.Location = new Point(3, 9);
            labelTitleGrid.Name = "labelTitleGrid";
            labelTitleGrid.Size = new Size(103, 25);
            labelTitleGrid.TabIndex = 28;
            labelTitleGrid.Text = "USUARIOS";
            // 
            // panelDatosUsuario
            // 
            panelDatosUsuario.BackColor = Color.FromArgb(26, 32, 40);
            panelDatosUsuario.Controls.Add(checkHabilitado);
            panelDatosUsuario.Controls.Add(txtPassword);
            panelDatosUsuario.Controls.Add(labelPassword);
            panelDatosUsuario.Controls.Add(txtUsuario);
            panelDatosUsuario.Controls.Add(labelUsuario);
            panelDatosUsuario.Controls.Add(txtApellido);
            panelDatosUsuario.Controls.Add(labelApellido);
            panelDatosUsuario.Controls.Add(txtNombre);
            panelDatosUsuario.Controls.Add(labelNombre);
            panelDatosUsuario.Controls.Add(txtEmail);
            panelDatosUsuario.Controls.Add(labelEmail);
            panelDatosUsuario.Controls.Add(labelTitle);
            panelDatosUsuario.Controls.Add(btnGuardar);
            panelDatosUsuario.Controls.Add(labelPerfil);
            panelDatosUsuario.Controls.Add(comboPerfil);
            panelDatosUsuario.Dock = DockStyle.Left;
            panelDatosUsuario.ForeColor = SystemColors.ButtonHighlight;
            panelDatosUsuario.Location = new Point(0, 0);
            panelDatosUsuario.Margin = new Padding(3, 3, 8, 3);
            panelDatosUsuario.Name = "panelDatosUsuario";
            panelDatosUsuario.Size = new Size(302, 645);
            panelDatosUsuario.TabIndex = 28;
            // 
            // checkHabilitado
            // 
            checkHabilitado.AutoSize = true;
            checkHabilitado.CheckAlign = ContentAlignment.MiddleRight;
            checkHabilitado.Checked = true;
            checkHabilitado.CheckState = CheckState.Checked;
            checkHabilitado.Font = new Font("Segoe UI", 10F);
            checkHabilitado.Location = new Point(12, 275);
            checkHabilitado.Name = "checkHabilitado";
            checkHabilitado.Size = new Size(113, 23);
            checkHabilitado.TabIndex = 6;
            checkHabilitado.Text = "Habilitado:     ";
            checkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(111, 195);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(168, 23);
            txtPassword.PasswordChar = '*';
            txtPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10F);
            labelPassword.ForeColor = SystemColors.ButtonHighlight;
            labelPassword.Location = new Point(11, 196);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 19);
            labelPassword.TabIndex = 49;
            labelPassword.Text = "Password:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(111, 160);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(168, 23);
            txtUsuario.TabIndex = 3;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 10F);
            labelUsuario.ForeColor = SystemColors.ButtonHighlight;
            labelUsuario.Location = new Point(11, 161);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(59, 19);
            labelUsuario.TabIndex = 47;
            labelUsuario.Text = "Usuario:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(110, 91);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(168, 23);
            txtApellido.TabIndex = 1;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 10F);
            labelApellido.ForeColor = SystemColors.ButtonHighlight;
            labelApellido.Location = new Point(10, 92);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(61, 19);
            labelApellido.TabIndex = 45;
            labelApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(168, 23);
            txtNombre.TabIndex = 0;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 10F);
            labelNombre.ForeColor = SystemColors.ButtonHighlight;
            labelNombre.Location = new Point(10, 59);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(62, 19);
            labelNombre.TabIndex = 43;
            labelNombre.Text = "Nombre:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(111, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 23);
            txtEmail.TabIndex = 2;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10F);
            labelEmail.ForeColor = SystemColors.ButtonHighlight;
            labelEmail.Location = new Point(11, 126);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 19);
            labelEmail.TabIndex = 41;
            labelEmail.Text = "Email:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 80, 200);
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.FlatAppearance.BorderColor = Color.Silver;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(72, 359);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(136, 35);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // labelPerfil
            // 
            labelPerfil.AutoSize = true;
            labelPerfil.Font = new Font("Segoe UI", 10F);
            labelPerfil.ForeColor = SystemColors.ButtonHighlight;
            labelPerfil.Location = new Point(12, 235);
            labelPerfil.Name = "labelPerfil";
            labelPerfil.Size = new Size(41, 19);
            labelPerfil.TabIndex = 32;
            labelPerfil.Text = "Perfil:";
            // 
            // comboPerfil
            // 
            comboPerfil.FormattingEnabled = true;
            comboPerfil.Location = new Point(111, 231);
            comboPerfil.Name = "comboPerfil";
            comboPerfil.Size = new Size(168, 23);
            comboPerfil.TabIndex = 5;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(labelTitleGrid);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(759, 57);
            panelHeader.TabIndex = 29;
            // 
            // panelDataGrid
            // 
            panelDataGrid.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelDataGrid.Controls.Add(labelSinResultados);
            panelDataGrid.Controls.Add(dvUsuarios);
            panelDataGrid.Dock = DockStyle.Fill;
            panelDataGrid.Location = new Point(0, 57);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(759, 588);
            panelDataGrid.TabIndex = 30;
            // 
            // labelSinResultados
            // 
            labelSinResultados.AutoSize = true;
            labelSinResultados.Font = new Font("Segoe UI", 16F);
            labelSinResultados.ForeColor = SystemColors.ButtonHighlight;
            labelSinResultados.Location = new Point(6, 13);
            labelSinResultados.Name = "labelSinResultados";
            labelSinResultados.Size = new Size(298, 30);
            labelSinResultados.TabIndex = 24;
            labelSinResultados.Text = "No se encontraron resultados";
            labelSinResultados.Visible = false;
            // 
            // dvUsuarios
            // 
            dvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvUsuarios.BackgroundColor = Color.FromArgb(49, 66, 82);
            dvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvUsuarios.Dock = DockStyle.Fill;
            dvUsuarios.Location = new Point(0, 0);
            dvUsuarios.Name = "dvUsuarios";
            dvUsuarios.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dvUsuarios.Size = new Size(759, 588);
            dvUsuarios.TabIndex = 23;
            dvUsuarios.CellDoubleClick += dvUsuarios_CellDoubleClick;
            // 
            // UsuariosControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            Controls.Add(panelMain);
            Name = "UsuariosControl";
            Size = new Size(1061, 645);
            panelMain.ResumeLayout(false);
            panelUsuarios.ResumeLayout(false);
            panelDatosUsuario.ResumeLayout(false);
            panelDatosUsuario.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelDataGrid.ResumeLayout(false);
            panelDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Panel panelMain;
        private Panel panelDatosUsuario;
        public Button btnGuardar;
        private Label labelPerfil;
        private ComboBox comboPerfil;
        private TextBox txtEmail;
        private Label labelEmail;
        private TextBox txtApellido;
        private Label labelApellido;
        private TextBox txtNombre;
        private Label labelNombre;
        private TextBox txtPassword;
        private Label labelPassword;
        private TextBox txtUsuario;
        private Label labelUsuario;
        private CheckBox checkHabilitado;
        private Panel panelUsuarios;
        private Label labelTitleGrid;
        private Panel panelHeader;
        private Panel panelDataGrid;
        private Label labelSinResultados;
        private DataGridView dvUsuarios;
    }
}
