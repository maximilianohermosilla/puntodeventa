namespace PuntoDeVenta.FormDialogs
{
    partial class ClientesDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesDialog));
            panelMain = new Panel();
            panelNewClient = new Panel();
            labelTitleCliente = new Label();
            btnCancelar = new Button();
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
            panelFooter = new Panel();
            btnAsignar = new Button();
            btnQuitar = new Button();
            btnNuevoCliente = new Button();
            listClientes = new ListBox();
            txtBuscar = new TextBox();
            panelMain.SuspendLayout();
            panelNewClient.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            resources.ApplyResources(panelMain, "panelMain");
            panelMain.BackColor = Color.FromArgb(29, 32, 40);
            panelMain.Controls.Add(panelFooter);
            panelMain.Controls.Add(listClientes);
            panelMain.Controls.Add(txtBuscar);
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Name = "panelMain";
            // 
            // panelNewClient
            // 
            panelNewClient.Controls.Add(labelTitleCliente);
            panelNewClient.Controls.Add(btnCancelar);
            panelNewClient.Controls.Add(checkHabilitado);
            panelNewClient.Controls.Add(btnGuardarCliente);
            panelNewClient.Controls.Add(txtTelefono);
            panelNewClient.Controls.Add(labelTelefono);
            panelNewClient.Controls.Add(txtEmail);
            panelNewClient.Controls.Add(labelEmail);
            panelNewClient.Controls.Add(txtApellido);
            panelNewClient.Controls.Add(labelApellido);
            panelNewClient.Controls.Add(txtNombre);
            panelNewClient.Controls.Add(labelNombre);
            resources.ApplyResources(panelNewClient, "panelNewClient");
            panelNewClient.Name = "panelNewClient";
            // 
            // labelTitleCliente
            // 
            resources.ApplyResources(labelTitleCliente, "labelTitleCliente");
            labelTitleCliente.ForeColor = SystemColors.ButtonHighlight;
            labelTitleCliente.Name = "labelTitleCliente";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(0, 80, 200);
            resources.ApplyResources(btnCancelar, "btnCancelar");
            btnCancelar.FlatAppearance.BorderColor = Color.Silver;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // checkHabilitado
            // 
            resources.ApplyResources(checkHabilitado, "checkHabilitado");
            checkHabilitado.Checked = true;
            checkHabilitado.CheckState = CheckState.Checked;
            checkHabilitado.Name = "checkHabilitado";
            checkHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.BackColor = Color.FromArgb(0, 80, 200);
            resources.ApplyResources(btnGuardarCliente, "btnGuardarCliente");
            btnGuardarCliente.FlatAppearance.BorderColor = Color.Silver;
            btnGuardarCliente.FlatAppearance.BorderSize = 0;
            btnGuardarCliente.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnGuardarCliente.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnGuardarCliente.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.UseVisualStyleBackColor = false;
            btnGuardarCliente.Click += btnGuardarCliente_Click_1;
            // 
            // txtTelefono
            // 
            resources.ApplyResources(txtTelefono, "txtTelefono");
            txtTelefono.Name = "txtTelefono";
            // 
            // labelTelefono
            // 
            resources.ApplyResources(labelTelefono, "labelTelefono");
            labelTelefono.Name = "labelTelefono";
            // 
            // txtEmail
            // 
            resources.ApplyResources(txtEmail, "txtEmail");
            txtEmail.Name = "txtEmail";
            // 
            // labelEmail
            // 
            resources.ApplyResources(labelEmail, "labelEmail");
            labelEmail.Name = "labelEmail";
            // 
            // txtApellido
            // 
            resources.ApplyResources(txtApellido, "txtApellido");
            txtApellido.Name = "txtApellido";
            // 
            // labelApellido
            // 
            resources.ApplyResources(labelApellido, "labelApellido");
            labelApellido.Name = "labelApellido";
            // 
            // txtNombre
            // 
            resources.ApplyResources(txtNombre, "txtNombre");
            txtNombre.Name = "txtNombre";
            // 
            // labelNombre
            // 
            resources.ApplyResources(labelNombre, "labelNombre");
            labelNombre.Name = "labelNombre";
            // 
            // panelFooter
            // 
            resources.ApplyResources(panelFooter, "panelFooter");
            panelFooter.Controls.Add(btnAsignar);
            panelFooter.Controls.Add(btnQuitar);
            panelFooter.Controls.Add(btnNuevoCliente);
            panelFooter.Name = "panelFooter";
            // 
            // btnAsignar
            // 
            btnAsignar.BackColor = Color.FromArgb(0, 80, 200);
            resources.ApplyResources(btnAsignar, "btnAsignar");
            btnAsignar.FlatAppearance.BorderColor = Color.Silver;
            btnAsignar.FlatAppearance.BorderSize = 0;
            btnAsignar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnAsignar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnAsignar.ForeColor = SystemColors.ButtonHighlight;
            btnAsignar.Name = "btnAsignar";
            btnAsignar.UseVisualStyleBackColor = false;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = Color.FromArgb(0, 80, 200);
            resources.ApplyResources(btnQuitar, "btnQuitar");
            btnQuitar.FlatAppearance.BorderColor = Color.Silver;
            btnQuitar.FlatAppearance.BorderSize = 0;
            btnQuitar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnQuitar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnQuitar.ForeColor = SystemColors.ButtonHighlight;
            btnQuitar.Name = "btnQuitar";
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnNuevoCliente
            // 
            btnNuevoCliente.BackColor = Color.FromArgb(0, 80, 200);
            resources.ApplyResources(btnNuevoCliente, "btnNuevoCliente");
            btnNuevoCliente.FlatAppearance.BorderColor = Color.Silver;
            btnNuevoCliente.FlatAppearance.BorderSize = 0;
            btnNuevoCliente.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnNuevoCliente.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnNuevoCliente.ForeColor = SystemColors.ButtonHighlight;
            btnNuevoCliente.Name = "btnNuevoCliente";
            btnNuevoCliente.UseVisualStyleBackColor = false;
            btnNuevoCliente.Click += btnNuevoCliente_Click_1;
            // 
            // listClientes
            // 
            resources.ApplyResources(listClientes, "listClientes");
            listClientes.FormattingEnabled = true;
            listClientes.Name = "listClientes";
            // 
            // txtBuscar
            // 
            resources.ApplyResources(txtBuscar, "txtBuscar");
            txtBuscar.Name = "txtBuscar";
            // 
            // ClientesDialog
            // 
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            Controls.Add(panelNewClient);
            Controls.Add(panelMain);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ClientesDialog";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelNewClient.ResumeLayout(false);
            panelNewClient.PerformLayout();
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelFooter;
        public Button btnAsignar;
        public Button btnQuitar;
        public Button btnNuevoCliente;
        private ListBox listClientes;
        private TextBox txtBuscar;
        private Panel panelNewClient;
        public Button btnCancelar;
        private CheckBox checkHabilitado;
        public Button btnGuardarCliente;
        private TextBox txtTelefono;
        private Label labelTelefono;
        private TextBox txtEmail;
        private Label labelEmail;
        private TextBox txtApellido;
        private Label labelApellido;
        private TextBox txtNombre;
        private Label labelNombre;
        private Label labelTitleCliente;
    }
}