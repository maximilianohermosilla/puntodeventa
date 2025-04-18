namespace PuntoDeVenta.UserControls
{
    partial class FacturasControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturasControl));
            panelHeader = new Panel();
            title = new Label();
            panelNavbar = new Panel();
            btnFacturaPorVentas = new Button();
            btnFacturasGlobales = new Button();
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
            panelHeader.Size = new Size(1451, 28);
            panelHeader.TabIndex = 5;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.ButtonHighlight;
            title.Location = new Point(3, 0);
            title.Name = "title";
            title.Size = new Size(141, 25);
            title.TabIndex = 0;
            title.Text = "FACTURACIÓN";
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(btnFacturaPorVentas);
            panelNavbar.Controls.Add(btnFacturasGlobales);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(0, 28);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1451, 48);
            panelNavbar.TabIndex = 17;
            // 
            // btnFacturaPorVentas
            // 
            btnFacturaPorVentas.BackColor = Color.FromArgb(0, 80, 200);
            btnFacturaPorVentas.BackgroundImageLayout = ImageLayout.None;
            btnFacturaPorVentas.FlatAppearance.BorderColor = Color.Silver;
            btnFacturaPorVentas.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnFacturaPorVentas.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnFacturaPorVentas.FlatStyle = FlatStyle.Popup;
            btnFacturaPorVentas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFacturaPorVentas.ForeColor = SystemColors.ButtonHighlight;
            btnFacturaPorVentas.Image = (Image)resources.GetObject("btnFacturaPorVentas.Image");
            btnFacturaPorVentas.Location = new Point(3, 5);
            btnFacturaPorVentas.Name = "btnFacturaPorVentas";
            btnFacturaPorVentas.Size = new Size(167, 35);
            btnFacturaPorVentas.TabIndex = 3;
            btnFacturaPorVentas.Text = "Factura por Ventas";
            btnFacturaPorVentas.TextAlign = ContentAlignment.MiddleRight;
            btnFacturaPorVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFacturaPorVentas.UseVisualStyleBackColor = false;
            // 
            // btnFacturasGlobales
            // 
            btnFacturasGlobales.BackColor = Color.FromArgb(0, 80, 200);
            btnFacturasGlobales.BackgroundImageLayout = ImageLayout.None;
            btnFacturasGlobales.FlatAppearance.BorderColor = Color.Silver;
            btnFacturasGlobales.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnFacturasGlobales.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnFacturasGlobales.FlatStyle = FlatStyle.Popup;
            btnFacturasGlobales.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFacturasGlobales.ForeColor = SystemColors.ButtonHighlight;
            btnFacturasGlobales.Image = (Image)resources.GetObject("btnFacturasGlobales.Image");
            btnFacturasGlobales.Location = new Point(176, 5);
            btnFacturasGlobales.Name = "btnFacturasGlobales";
            btnFacturasGlobales.Size = new Size(145, 35);
            btnFacturasGlobales.TabIndex = 4;
            btnFacturasGlobales.Text = "Facturas Globales";
            btnFacturasGlobales.TextAlign = ContentAlignment.MiddleRight;
            btnFacturasGlobales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFacturasGlobales.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 76);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1451, 503);
            panelMain.TabIndex = 18;
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            Controls.Add(panelMain);
            Controls.Add(panelNavbar);
            Controls.Add(panelHeader);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Facturas";
            Size = new Size(1451, 579);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label title;
        private Panel panelNavbar;
        public Button btnFacturaPorVentas;
        public Button btnFacturasGlobales;
        private Panel panelMain;
    }
}
