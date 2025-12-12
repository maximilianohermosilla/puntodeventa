namespace PuntoDeVenta.UserControls
{
    partial class ConfiguracionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracionControl));
            panelHeader = new Panel();
            title = new Label();
            panelNavbar = new Panel();
            btnUsuarios = new Button();
            panelMain = new Panel();
            btnUpdate = new Button();
            btnSubirImagen = new Button();
            labelLogo = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            labelNombre = new Label();
            btnGeneral = new Button();
            panelGeneral = new Panel();
            panelHeader.SuspendLayout();
            panelNavbar.SuspendLayout();
            panelMain.SuspendLayout();
            panelGeneral.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelHeader.BackColor = Color.DimGray;
            panelHeader.BorderStyle = BorderStyle.FixedSingle;
            panelHeader.Controls.Add(title);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1456, 28);
            panelHeader.TabIndex = 3;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.ButtonHighlight;
            title.Location = new Point(3, 0);
            title.Name = "title";
            title.Size = new Size(167, 25);
            title.TabIndex = 0;
            title.Text = "CONFIGURACIÓN";
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BackColor = Color.FromArgb(26, 32, 40);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(btnGeneral);
            panelNavbar.Controls.Add(btnUsuarios);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.ForeColor = SystemColors.ButtonHighlight;
            panelNavbar.Location = new Point(0, 28);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1456, 48);
            panelNavbar.TabIndex = 18;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(0, 80, 200);
            btnUsuarios.BackgroundImageLayout = ImageLayout.None;
            btnUsuarios.FlatAppearance.BorderColor = Color.Silver;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = SystemColors.ButtonHighlight;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.Location = new Point(165, 6);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(147, 35);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(49, 66, 82);
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(panelGeneral);
            panelMain.Dock = DockStyle.Fill;
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Location = new Point(0, 76);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1456, 512);
            panelMain.TabIndex = 19;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 80, 200);
            btnUpdate.BackgroundImageLayout = ImageLayout.None;
            btnUpdate.FlatAppearance.BorderColor = Color.Silver;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 8.25F);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImeMode = ImeMode.NoControl;
            btnUpdate.Location = new Point(332, 48);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(29, 23);
            btnUpdate.TabIndex = 25;
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSubirImagen
            // 
            btnSubirImagen.BackColor = Color.FromArgb(0, 80, 200);
            btnSubirImagen.BackgroundImageLayout = ImageLayout.None;
            btnSubirImagen.FlatAppearance.BorderColor = Color.Silver;
            btnSubirImagen.FlatAppearance.BorderSize = 0;
            btnSubirImagen.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnSubirImagen.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnSubirImagen.FlatStyle = FlatStyle.Flat;
            btnSubirImagen.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubirImagen.ForeColor = SystemColors.ButtonHighlight;
            btnSubirImagen.Image = (Image)resources.GetObject("btnSubirImagen.Image");
            btnSubirImagen.Location = new Point(74, 77);
            btnSubirImagen.Name = "btnSubirImagen";
            btnSubirImagen.Size = new Size(287, 31);
            btnSubirImagen.TabIndex = 4;
            btnSubirImagen.Text = "Seleccione una imagen";
            btnSubirImagen.TextAlign = ContentAlignment.MiddleRight;
            btnSubirImagen.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSubirImagen.UseVisualStyleBackColor = false;
            btnSubirImagen.Click += btnSubirImagen_Click;
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.Font = new Font("Segoe UI", 10F);
            labelLogo.ImeMode = ImeMode.NoControl;
            labelLogo.Location = new Point(6, 84);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(43, 19);
            labelLogo.TabIndex = 24;
            labelLogo.Text = "Logo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 1;
            label1.Text = "EMPRESA";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(74, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 23);
            txtNombre.TabIndex = 21;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 10F);
            labelNombre.ImeMode = ImeMode.NoControl;
            labelNombre.Location = new Point(6, 49);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(62, 19);
            labelNombre.TabIndex = 22;
            labelNombre.Text = "Nombre:";
            // 
            // btnGeneral
            // 
            btnGeneral.BackColor = Color.FromArgb(0, 80, 200);
            btnGeneral.BackgroundImageLayout = ImageLayout.None;
            btnGeneral.FlatAppearance.BorderColor = Color.Silver;
            btnGeneral.FlatAppearance.BorderSize = 0;
            btnGeneral.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnGeneral.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnGeneral.FlatStyle = FlatStyle.Flat;
            btnGeneral.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGeneral.ForeColor = SystemColors.ButtonHighlight;
            btnGeneral.Image = (Image)resources.GetObject("btnGeneral.Image");
            btnGeneral.Location = new Point(3, 6);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new Size(156, 35);
            btnGeneral.TabIndex = 10;
            btnGeneral.Text = "General";
            btnGeneral.TextAlign = ContentAlignment.MiddleRight;
            btnGeneral.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGeneral.UseVisualStyleBackColor = false;
            btnGeneral.Click += btnGeneral_Click;
            // 
            // panelGeneral
            // 
            panelGeneral.Controls.Add(btnUpdate);
            panelGeneral.Controls.Add(btnSubirImagen);
            panelGeneral.Controls.Add(labelLogo);
            panelGeneral.Controls.Add(label1);
            panelGeneral.Controls.Add(txtNombre);
            panelGeneral.Controls.Add(labelNombre);
            panelGeneral.Location = new Point(2, -1);
            panelGeneral.Name = "panelGeneral";
            panelGeneral.Size = new Size(381, 509);
            panelGeneral.TabIndex = 26;
            // 
            // ConfiguracionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panelMain);
            Controls.Add(panelNavbar);
            Controls.Add(panelHeader);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "ConfiguracionControl";
            Size = new Size(1456, 588);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavbar.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelGeneral.ResumeLayout(false);
            panelGeneral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label title;
        private Panel panelNavbar;
        public Button btnUsuarios;
        private Panel panelMain;
        private Label label1;
        public TextBox txtNombre;
        private Label labelNombre;
        public Button btnSubirImagen;
        private Label labelLogo;
        public Button btnUpdate;
        public Button btnGeneral;
        private Panel panelGeneral;
        public UserControls.ConfiguracionControls.UsuariosControl usuarioControl;
    }
}
