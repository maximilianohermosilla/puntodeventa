namespace PuntoDeVenta.UserControls
{
    partial class ComprasControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprasControl));
            panelHeader = new Panel();
            comprasTitle = new Label();
            panelNavbar = new Panel();
            btnCompras = new Button();
            panelMain = new Panel();
            panelHeader.SuspendLayout();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelHeader.BackColor = Color.FromArgb(50, 50, 50);
            panelHeader.Controls.Add(comprasTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1460, 28);
            panelHeader.TabIndex = 2;
            // 
            // comprasTitle
            // 
            comprasTitle.AutoSize = true;
            comprasTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comprasTitle.ForeColor = SystemColors.ButtonHighlight;
            comprasTitle.Location = new Point(3, 0);
            comprasTitle.Name = "comprasTitle";
            comprasTitle.Size = new Size(102, 25);
            comprasTitle.TabIndex = 0;
            comprasTitle.Text = "COMPRAS";
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BackColor = Color.FromArgb(49, 66, 82);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(btnCompras);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.ForeColor = SystemColors.ButtonHighlight;
            panelNavbar.Location = new Point(0, 28);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1460, 48);
            panelNavbar.TabIndex = 17;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.FromArgb(0, 80, 200);
            btnCompras.BackgroundImageLayout = ImageLayout.None;
            btnCompras.FlatAppearance.BorderColor = Color.Silver;
            btnCompras.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnCompras.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompras.ForeColor = SystemColors.ButtonHighlight;
            btnCompras.Image = (Image)resources.GetObject("btnCompras.Image");
            btnCompras.Location = new Point(3, 3);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(193, 35);
            btnCompras.TabIndex = 3;
            btnCompras.Text = "Compras";
            btnCompras.TextAlign = ContentAlignment.MiddleRight;
            btnCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCompras.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(49, 66, 82);
            panelMain.Dock = DockStyle.Fill;
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Location = new Point(0, 76);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1460, 504);
            panelMain.TabIndex = 18;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            Controls.Add(panelMain);
            Controls.Add(panelNavbar);
            Controls.Add(panelHeader);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Compras";
            Size = new Size(1460, 580);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label comprasTitle;
        private Panel panelNavbar;
        public Button btnCompras;
        private Panel panelMain;
    }
}
