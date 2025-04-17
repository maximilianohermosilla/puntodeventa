namespace PuntoDeVenta.UserControls
{
    partial class Corte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Corte));
            panelHeader = new Panel();
            title = new Label();
            panelNavbar = new Panel();
            btnCorteCajero = new Button();
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
            panelHeader.Size = new Size(1463, 28);
            panelHeader.TabIndex = 4;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.ButtonHighlight;
            title.Location = new Point(3, 0);
            title.Name = "title";
            title.Size = new Size(70, 25);
            title.TabIndex = 0;
            title.Text = "CORTE";
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BackColor = Color.FromArgb(49, 66, 82);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(btnCorteCajero);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.ForeColor = SystemColors.ButtonHighlight;
            panelNavbar.Location = new Point(0, 28);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1463, 48);
            panelNavbar.TabIndex = 19;
            // 
            // btnCorteCajero
            // 
            btnCorteCajero.BackColor = Color.FromArgb(0, 80, 200);
            btnCorteCajero.BackgroundImageLayout = ImageLayout.None;
            btnCorteCajero.FlatAppearance.BorderColor = Color.Silver;
            btnCorteCajero.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnCorteCajero.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnCorteCajero.FlatStyle = FlatStyle.Popup;
            btnCorteCajero.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCorteCajero.ForeColor = SystemColors.ButtonHighlight;
            btnCorteCajero.Image = (Image)resources.GetObject("btnCorteCajero.Image");
            btnCorteCajero.Location = new Point(3, 3);
            btnCorteCajero.Name = "btnCorteCajero";
            btnCorteCajero.Size = new Size(193, 35);
            btnCorteCajero.TabIndex = 3;
            btnCorteCajero.Text = "Corte Cajero";
            btnCorteCajero.TextAlign = ContentAlignment.MiddleRight;
            btnCorteCajero.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCorteCajero.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(49, 66, 82);
            panelMain.Dock = DockStyle.Fill;
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Location = new Point(0, 76);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1463, 515);
            panelMain.TabIndex = 20;
            // 
            // Corte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            Controls.Add(panelMain);
            Controls.Add(panelNavbar);
            Controls.Add(panelHeader);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Corte";
            Size = new Size(1463, 591);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label title;
        private Panel panelNavbar;
        public Button btnCorteCajero;
        private Panel panelMain;
    }
}
