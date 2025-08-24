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
            btnMostrarOpciones = new Button();
            panelMain = new Panel();
            btnUpdate = new Button();
            btnSubirImagen = new Button();
            labelLogo = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            labelNombre = new Label();
            panelHeader.SuspendLayout();
            panelNavbar.SuspendLayout();
            panelMain.SuspendLayout();
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
            panelNavbar.Controls.Add(btnMostrarOpciones);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.ForeColor = SystemColors.ButtonHighlight;
            panelNavbar.Location = new Point(0, 28);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1456, 48);
            panelNavbar.TabIndex = 18;
            // 
            // btnMostrarOpciones
            // 
            btnMostrarOpciones.BackColor = Color.FromArgb(0, 80, 200);
            btnMostrarOpciones.BackgroundImageLayout = ImageLayout.None;
            btnMostrarOpciones.FlatAppearance.BorderColor = Color.Silver;
            btnMostrarOpciones.FlatAppearance.BorderSize = 0;
            btnMostrarOpciones.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnMostrarOpciones.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnMostrarOpciones.FlatStyle = FlatStyle.Flat;
            btnMostrarOpciones.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrarOpciones.ForeColor = SystemColors.ButtonHighlight;
            btnMostrarOpciones.Image = (Image)resources.GetObject("btnMostrarOpciones.Image");
            btnMostrarOpciones.Location = new Point(3, 5);
            btnMostrarOpciones.Name = "btnMostrarOpciones";
            btnMostrarOpciones.Size = new Size(193, 35);
            btnMostrarOpciones.TabIndex = 3;
            btnMostrarOpciones.Text = "Mostrar Opciones";
            btnMostrarOpciones.TextAlign = ContentAlignment.MiddleRight;
            btnMostrarOpciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMostrarOpciones.UseVisualStyleBackColor = false;
            btnMostrarOpciones.Click += btnMostrarOpciones_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(49, 66, 82);
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(btnUpdate);
            panelMain.Controls.Add(btnSubirImagen);
            panelMain.Controls.Add(labelLogo);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(txtNombre);
            panelMain.Controls.Add(labelNombre);
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
            btnUpdate.Location = new Point(338, 48);
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
            btnSubirImagen.Location = new Point(80, 77);
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
            labelLogo.Location = new Point(12, 84);
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
            label1.Location = new Point(9, 11);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 1;
            label1.Text = "EMPRESA";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 48);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 23);
            txtNombre.TabIndex = 21;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 10F);
            labelNombre.ImeMode = ImeMode.NoControl;
            labelNombre.Location = new Point(12, 49);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(62, 19);
            labelNombre.TabIndex = 22;
            labelNombre.Text = "Nombre:";
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
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label title;
        private Panel panelNavbar;
        public Button btnMostrarOpciones;
        private Panel panelMain;
        private Label label1;
        public TextBox txtNombre;
        private Label labelNombre;
        public Button btnSubirImagen;
        private Label labelLogo;
        public Button btnUpdate;
    }
}
