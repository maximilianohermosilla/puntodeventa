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
            panelHeader.SuspendLayout();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelHeader.BackColor = Color.FromArgb(50, 50, 50);
            panelHeader.Controls.Add(title);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1458, 28);
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
            panelNavbar.BackColor = Color.FromArgb(49, 66, 82);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(btnMostrarOpciones);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.ForeColor = SystemColors.ButtonHighlight;
            panelNavbar.Location = new Point(0, 28);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1458, 48);
            panelNavbar.TabIndex = 18;
            // 
            // btnMostrarOpciones
            // 
            btnMostrarOpciones.BackColor = Color.FromArgb(0, 80, 200);
            btnMostrarOpciones.BackgroundImageLayout = ImageLayout.None;
            btnMostrarOpciones.FlatAppearance.BorderColor = Color.Silver;
            btnMostrarOpciones.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnMostrarOpciones.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnMostrarOpciones.FlatStyle = FlatStyle.Popup;
            btnMostrarOpciones.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrarOpciones.ForeColor = SystemColors.ButtonHighlight;
            btnMostrarOpciones.Image = (Image)resources.GetObject("btnMostrarOpciones.Image");
            btnMostrarOpciones.Location = new Point(3, 3);
            btnMostrarOpciones.Name = "btnMostrarOpciones";
            btnMostrarOpciones.Size = new Size(193, 35);
            btnMostrarOpciones.TabIndex = 3;
            btnMostrarOpciones.Text = "Mostrar Opciones";
            btnMostrarOpciones.TextAlign = ContentAlignment.MiddleRight;
            btnMostrarOpciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMostrarOpciones.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(49, 66, 82);
            panelMain.Dock = DockStyle.Fill;
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Location = new Point(0, 76);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1458, 514);
            panelMain.TabIndex = 19;
            // 
            // Configuracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            Controls.Add(panelMain);
            Controls.Add(panelNavbar);
            Controls.Add(panelHeader);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Configuracion";
            Size = new Size(1458, 590);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label title;
        private Panel panelNavbar;
        public Button btnMostrarOpciones;
        private Panel panelMain;
    }
}
