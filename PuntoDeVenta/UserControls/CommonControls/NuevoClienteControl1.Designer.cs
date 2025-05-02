using PuntoDeVenta.Properties;

namespace PuntoDeVenta.UserControls.CommonControls
{
    partial class NuevoClienteControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoClienteControl1));
            panelMain = new Panel();
            checkHabilitado = new CheckBox();
            btnGuardarCliente = new Button();
            labelTitleCliente = new Label();
            txtTelefono = new TextBox();
            labelNombre = new Label();
            labelTelefono = new Label();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            labelApellido = new Label();
            labelEmail = new Label();
            txtApellido = new TextBox();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelMain.BackColor = Color.FromArgb(49, 66, 82);
            panelMain.Controls.Add(checkHabilitado);
            panelMain.Controls.Add(btnGuardarCliente);
            panelMain.Controls.Add(labelTitleCliente);
            panelMain.Controls.Add(txtTelefono);
            panelMain.Controls.Add(labelNombre);
            panelMain.Controls.Add(labelTelefono);
            panelMain.Controls.Add(txtNombre);
            panelMain.Controls.Add(txtEmail);
            panelMain.Controls.Add(labelApellido);
            panelMain.Controls.Add(labelEmail);
            panelMain.Controls.Add(txtApellido);
            panelMain.Dock = DockStyle.Fill;
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(500, 340);
            panelMain.TabIndex = 0;
            // 
            // checkHabilitado
            // 
            checkHabilitado.AutoSize = true;
            checkHabilitado.CheckAlign = ContentAlignment.MiddleRight;
            checkHabilitado.Checked = true;
            checkHabilitado.CheckState = CheckState.Checked;
            checkHabilitado.Font = new Font("Segoe UI", 10F);
            checkHabilitado.Location = new Point(27, 210);
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
            btnGuardarCliente.Location = new Point(26, 265);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(136, 35);
            btnGuardarCliente.TabIndex = 6;
            btnGuardarCliente.Text = "Guardar";
            btnGuardarCliente.TextAlign = ContentAlignment.MiddleRight;
            btnGuardarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarCliente.UseVisualStyleBackColor = false;
            btnGuardarCliente.Click += btnGuardarCliente_Click;
            // 
            // labelTitleCliente
            // 
            labelTitleCliente.AutoSize = true;
            labelTitleCliente.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitleCliente.ForeColor = SystemColors.ButtonHighlight;
            labelTitleCliente.Location = new Point(21, 20);
            labelTitleCliente.Name = "labelTitleCliente";
            labelTitleCliente.Size = new Size(153, 25);
            labelTitleCliente.TabIndex = 11;
            labelTitleCliente.Text = "NUEVO CLIENTE";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(149, 172);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(309, 23);
            txtTelefono.TabIndex = 4;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 10F);
            labelNombre.Location = new Point(26, 69);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(62, 19);
            labelNombre.TabIndex = 10;
            labelNombre.Text = "Nombre:";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Segoe UI", 10F);
            labelTelefono.Location = new Point(27, 173);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(63, 19);
            labelTelefono.TabIndex = 7;
            labelTelefono.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(149, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(309, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(309, 23);
            txtEmail.TabIndex = 3;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 10F);
            labelApellido.Location = new Point(26, 103);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(61, 19);
            labelApellido.TabIndex = 9;
            labelApellido.Text = "Apellido:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10F);
            labelEmail.Location = new Point(26, 136);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 19);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(149, 102);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(309, 23);
            txtApellido.TabIndex = 2;
            // 
            // NuevoClienteControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(panelMain);
            Name = "NuevoClienteControl1";
            Size = new Size(500, 340);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMain;
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
