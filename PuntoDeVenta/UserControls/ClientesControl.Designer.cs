using PuntoDeVenta.Properties;

namespace PuntoDeVenta.UserControls
{
    partial class ClientesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesControl));
            panelHeader = new Panel();
            clientesTitle = new Label();
            panelNavbar = new Panel();
            labelTitle = new Label();
            panelMain = new Panel();
            panelPrincipal = new Panel();
            checkHabilitado = new CheckBox();
            btnGuardarCliente = new Button();
            txtTelefono = new TextBox();
            labelTelefono = new Label();
            txtEmail = new TextBox();
            labelEmail = new Label();
            txtApellido = new TextBox();
            labelApellido = new Label();
            txtNombre = new TextBox();
            labelNombre = new Label();
            labelTitleCliente = new Label();
            panelAside = new Panel();
            panel2 = new Panel();
            btnEliminarCliente = new Button();
            btnNuevoCliente = new Button();
            listClientes = new ListBox();
            txtBuscar = new TextBox();
            panelHeader.SuspendLayout();
            panelNavbar.SuspendLayout();
            panelMain.SuspendLayout();
            panelPrincipal.SuspendLayout();
            panelAside.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelHeader.BackColor = Color.LightSlateGray;
            panelHeader.Controls.Add(clientesTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1449, 28);
            panelHeader.TabIndex = 2;
            // 
            // clientesTitle
            // 
            clientesTitle.AutoSize = true;
            clientesTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientesTitle.ForeColor = SystemColors.ButtonHighlight;
            clientesTitle.Location = new Point(3, 0);
            clientesTitle.Name = "clientesTitle";
            clientesTitle.Size = new Size(94, 25);
            clientesTitle.TabIndex = 0;
            clientesTitle.Text = "CLIENTES";
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BackColor = Color.FromArgb(49, 66, 82);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(labelTitle);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.ForeColor = SystemColors.ButtonHighlight;
            panelNavbar.Location = new Point(0, 28);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1449, 48);
            panelNavbar.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ButtonHighlight;
            labelTitle.Location = new Point(3, 8);
            labelTitle.Margin = new Padding(3, 6, 3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(238, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Administración de clientes";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(49, 66, 82);
            panelMain.Controls.Add(panelPrincipal);
            panelMain.Controls.Add(panelAside);
            panelMain.Dock = DockStyle.Fill;
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Location = new Point(0, 76);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1449, 508);
            panelMain.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPrincipal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelPrincipal.Controls.Add(checkHabilitado);
            panelPrincipal.Controls.Add(btnGuardarCliente);
            panelPrincipal.Controls.Add(txtTelefono);
            panelPrincipal.Controls.Add(labelTelefono);
            panelPrincipal.Controls.Add(txtEmail);
            panelPrincipal.Controls.Add(labelEmail);
            panelPrincipal.Controls.Add(txtApellido);
            panelPrincipal.Controls.Add(labelApellido);
            panelPrincipal.Controls.Add(txtNombre);
            panelPrincipal.Controls.Add(labelNombre);
            panelPrincipal.Controls.Add(labelTitleCliente);
            panelPrincipal.Location = new Point(323, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1123, 505);
            panelPrincipal.TabIndex = 0;
            // 
            // checkHabilitado
            // 
            checkHabilitado.AutoSize = true;
            checkHabilitado.CheckAlign = ContentAlignment.MiddleRight;
            checkHabilitado.Checked = true;
            checkHabilitado.CheckState = CheckState.Checked;
            checkHabilitado.Font = new Font("Segoe UI", 10F);
            checkHabilitado.Location = new Point(22, 205);
            checkHabilitado.Name = "checkHabilitado";
            checkHabilitado.Size = new Size(133, 23);
            checkHabilitado.TabIndex = 5;
            checkHabilitado.Text = "Habilitado:          ";
            checkHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.BackColor = Color.FromArgb(0, 80, 200);
            btnGuardarCliente.BackgroundImageLayout = ImageLayout.None;
            btnGuardarCliente.FlatAppearance.BorderColor = Color.Silver;
            btnGuardarCliente.FlatAppearance.BorderSize = 0;
            btnGuardarCliente.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnGuardarCliente.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnGuardarCliente.FlatStyle = FlatStyle.Flat;
            btnGuardarCliente.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarCliente.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarCliente.Image = (Image)resources.GetObject("btnGuardarCliente.Image");
            btnGuardarCliente.Location = new Point(21, 260);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(136, 35);
            btnGuardarCliente.TabIndex = 6;
            btnGuardarCliente.Text = "Guardar";
            btnGuardarCliente.TextAlign = ContentAlignment.MiddleRight;
            btnGuardarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarCliente.UseVisualStyleBackColor = false;
            btnGuardarCliente.Click += btnGuardarCliente_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(144, 167);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(309, 23);
            txtTelefono.TabIndex = 4;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Segoe UI", 10F);
            labelTelefono.Location = new Point(22, 168);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(63, 19);
            labelTelefono.TabIndex = 7;
            labelTelefono.Text = "Teléfono:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(144, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 23);
            txtEmail.TabIndex = 3;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10F);
            labelEmail.Location = new Point(21, 131);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 19);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(144, 97);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(309, 23);
            txtApellido.TabIndex = 2;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 10F);
            labelApellido.Location = new Point(21, 98);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(61, 19);
            labelApellido.TabIndex = 9;
            labelApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(144, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(309, 23);
            txtNombre.TabIndex = 1;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 10F);
            labelNombre.Location = new Point(21, 64);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(62, 19);
            labelNombre.TabIndex = 10;
            labelNombre.Text = "Nombre:";
            // 
            // labelTitleCliente
            // 
            labelTitleCliente.AutoSize = true;
            labelTitleCliente.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitleCliente.ForeColor = SystemColors.ButtonHighlight;
            labelTitleCliente.Location = new Point(16, 15);
            labelTitleCliente.Name = "labelTitleCliente";
            labelTitleCliente.Size = new Size(153, 25);
            labelTitleCliente.TabIndex = 11;
            labelTitleCliente.Text = "NUEVO CLIENTE";
            // 
            // panelAside
            // 
            panelAside.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelAside.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelAside.BackColor = Color.FromArgb(29, 32, 40);
            panelAside.Controls.Add(panel2);
            panelAside.Controls.Add(listClientes);
            panelAside.Controls.Add(txtBuscar);
            panelAside.ForeColor = SystemColors.ButtonHighlight;
            panelAside.Location = new Point(0, 0);
            panelAside.Name = "panelAside";
            panelAside.Size = new Size(317, 505);
            panelAside.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(btnEliminarCliente);
            panel2.Controls.Add(btnNuevoCliente);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 457);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 48);
            panel2.TabIndex = 0;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.BackColor = Color.FromArgb(0, 80, 200);
            btnEliminarCliente.BackgroundImageLayout = ImageLayout.None;
            btnEliminarCliente.FlatAppearance.BorderColor = Color.Silver;
            btnEliminarCliente.FlatAppearance.BorderSize = 0;
            btnEliminarCliente.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnEliminarCliente.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnEliminarCliente.FlatStyle = FlatStyle.Flat;
            btnEliminarCliente.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarCliente.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarCliente.Image = (Image)resources.GetObject("btnEliminarCliente.Image");
            btnEliminarCliente.Location = new Point(168, 0);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(130, 35);
            btnEliminarCliente.TabIndex = 11;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarCliente.UseVisualStyleBackColor = false;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.FromArgb(0, 80, 200);
            btnNuevoCliente.BackgroundImageLayout = ImageLayout.None;
            btnNuevoCliente.FlatAppearance.BorderColor = Color.Silver;
            btnNuevoCliente.FlatAppearance.BorderSize = 0;
            btnNuevoCliente.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnNuevoCliente.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnNuevoCliente.FlatStyle = FlatStyle.Flat;
            btnNuevoCliente.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoCliente.ForeColor = SystemColors.ButtonHighlight;
            btnNuevoCliente.Image = (Image)resources.GetObject("btnNuevoCliente.Image");
            btnNuevoCliente.Location = new Point(20, 0);
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.Size = new Size(127, 35);
            btnNuevoCliente.TabIndex = 10;
            btnNuevoCliente.Text = "Nuevo";
            btnNuevoCliente.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click;
            // 
            // listClientes
            // 
            listClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 15;
            listClientes.Location = new Point(18, 48);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(280, 394);
            listClientes.TabIndex = 9;
            listClientes.SelectedIndexChanged += listClientes_SelectedIndexChanged;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(18, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar...";
            txtBuscar.Size = new Size(280, 23);
            txtBuscar.TabIndex = 8;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // ClientesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Controls.Add(panelNavbar);
            Controls.Add(panelHeader);
            Name = "ClientesControl";
            Size = new Size(1449, 584);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            panelMain.ResumeLayout(false);
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            panelAside.ResumeLayout(false);
            panelAside.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label clientesTitle;
        private Panel panelNavbar;
        private Panel panelMain;
        private Panel panelPrincipal;
        private Panel panelAside;
        private Panel panel2;
        public Button btnEliminarCliente;
        public Button btnNuevoCliente;
        private ListBox listClientes;
        private TextBox txtBuscar;
        private Label labelTitle;
        private TextBox txtApellido;
        private Label labelApellido;
        private TextBox txtNombre;
        private Label labelNombre;
        private Label labelTitleCliente;
        private TextBox txtTelefono;
        private Label labelTelefono;
        private TextBox txtEmail;
        private Label labelEmail;
        public Button btnGuardarCliente;
        private CheckBox checkHabilitado;
    }
}
