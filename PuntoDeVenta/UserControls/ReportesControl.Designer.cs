namespace PuntoDeVenta.UserControls
{
    partial class ReportesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesControl));
            panelHeader = new Panel();
            title = new Label();
            panelNavbar = new Panel();
            btnReporteDeVentas = new Button();
            btnVentasPorCliente = new Button();
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
            panelHeader.Size = new Size(1460, 28);
            panelHeader.TabIndex = 5;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.ButtonHighlight;
            title.Location = new Point(3, 0);
            title.Name = "title";
            title.Size = new Size(101, 25);
            title.TabIndex = 0;
            title.Text = "REPORTES";
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(btnReporteDeVentas);
            panelNavbar.Controls.Add(btnVentasPorCliente);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(0, 28);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1460, 48);
            panelNavbar.TabIndex = 17;
            // 
            // btnReporteDeVentas
            // 
            btnReporteDeVentas.BackColor = Color.FromArgb(0, 80, 200);
            btnReporteDeVentas.BackgroundImageLayout = ImageLayout.None;
            btnReporteDeVentas.FlatAppearance.BorderColor = Color.Silver;
            btnReporteDeVentas.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnReporteDeVentas.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnReporteDeVentas.FlatStyle = FlatStyle.Popup;
            btnReporteDeVentas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporteDeVentas.ForeColor = SystemColors.ButtonHighlight;
            btnReporteDeVentas.Image = (Image)resources.GetObject("btnReporteDeVentas.Image");
            btnReporteDeVentas.Location = new Point(3, 5);
            btnReporteDeVentas.Name = "btnReporteDeVentas";
            btnReporteDeVentas.Size = new Size(167, 35);
            btnReporteDeVentas.TabIndex = 3;
            btnReporteDeVentas.Text = "Reporte de Ventas";
            btnReporteDeVentas.TextAlign = ContentAlignment.MiddleRight;
            btnReporteDeVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporteDeVentas.UseVisualStyleBackColor = false;
            // 
            // btnVentasPorCliente
            // 
            btnVentasPorCliente.BackColor = Color.FromArgb(0, 80, 200);
            btnVentasPorCliente.BackgroundImageLayout = ImageLayout.None;
            btnVentasPorCliente.FlatAppearance.BorderColor = Color.Silver;
            btnVentasPorCliente.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnVentasPorCliente.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnVentasPorCliente.FlatStyle = FlatStyle.Popup;
            btnVentasPorCliente.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentasPorCliente.ForeColor = SystemColors.ButtonHighlight;
            btnVentasPorCliente.Image = (Image)resources.GetObject("btnVentasPorCliente.Image");
            btnVentasPorCliente.Location = new Point(176, 5);
            btnVentasPorCliente.Name = "btnVentasPorCliente";
            btnVentasPorCliente.Size = new Size(145, 35);
            btnVentasPorCliente.TabIndex = 4;
            btnVentasPorCliente.Text = "Ventas Por Cliente";
            btnVentasPorCliente.TextAlign = ContentAlignment.MiddleRight;
            btnVentasPorCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVentasPorCliente.UseVisualStyleBackColor = false;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            Controls.Add(panelNavbar);
            Controls.Add(panelHeader);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Reportes";
            Size = new Size(1460, 610);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label title;
        private Panel panelNavbar;
        public Button btnReporteDeVentas;
        public Button btnVentasPorCliente;
    }
}
