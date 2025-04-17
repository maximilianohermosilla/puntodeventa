using PuntoDeVenta.Properties;

namespace PuntoDeVenta.UserControls
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            panelHeader = new Panel();
            ventasTitle = new Label();
            panelNavbar = new Panel();
            btnAgregar = new Button();
            btnAjustes = new Button();
            btnProductosBajos = new Button();
            btnReporteInventario = new Button();
            btnReporteMovimientos = new Button();
            panelMain = new Panel();
            panelHeader.SuspendLayout();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelHeader.BackColor = Color.DarkSlateBlue;
            panelHeader.Controls.Add(ventasTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1449, 28);
            panelHeader.TabIndex = 1;
            // 
            // ventasTitle
            // 
            ventasTitle.AutoSize = true;
            ventasTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ventasTitle.ForeColor = SystemColors.ButtonHighlight;
            ventasTitle.Location = new Point(3, 0);
            ventasTitle.Name = "ventasTitle";
            ventasTitle.Size = new Size(124, 25);
            ventasTitle.TabIndex = 0;
            ventasTitle.Text = "INVENTARIO";
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BackColor = Color.FromArgb(49, 66, 82);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(btnAgregar);
            panelNavbar.Controls.Add(btnAjustes);
            panelNavbar.Controls.Add(btnProductosBajos);
            panelNavbar.Controls.Add(btnReporteInventario);
            panelNavbar.Controls.Add(btnReporteMovimientos);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.ForeColor = SystemColors.ButtonHighlight;
            panelNavbar.Location = new Point(0, 28);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1449, 48);
            panelNavbar.TabIndex = 16;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 80, 200);
            btnAgregar.BackgroundImageLayout = ImageLayout.None;
            btnAgregar.FlatAppearance.BorderColor = Color.Silver;
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.Location = new Point(3, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 35);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnAjustes
            // 
            btnAjustes.BackColor = Color.FromArgb(0, 80, 200);
            btnAjustes.BackgroundImageLayout = ImageLayout.None;
            btnAjustes.FlatAppearance.BorderColor = Color.Silver;
            btnAjustes.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnAjustes.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAjustes.FlatStyle = FlatStyle.Popup;
            btnAjustes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjustes.ForeColor = SystemColors.ButtonHighlight;
            btnAjustes.Image = (Image)resources.GetObject("btnAjustes.Image");
            btnAjustes.Location = new Point(131, 5);
            btnAjustes.Name = "btnAjustes";
            btnAjustes.Size = new Size(122, 35);
            btnAjustes.TabIndex = 4;
            btnAjustes.Text = "Ajustes";
            btnAjustes.TextAlign = ContentAlignment.MiddleRight;
            btnAjustes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAjustes.UseVisualStyleBackColor = false;
            // 
            // btnProductosBajos
            // 
            btnProductosBajos.BackColor = Color.FromArgb(0, 80, 200);
            btnProductosBajos.BackgroundImageLayout = ImageLayout.None;
            btnProductosBajos.FlatAppearance.BorderColor = Color.Silver;
            btnProductosBajos.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnProductosBajos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnProductosBajos.FlatStyle = FlatStyle.Popup;
            btnProductosBajos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductosBajos.ForeColor = SystemColors.ButtonHighlight;
            btnProductosBajos.Image = (Image)resources.GetObject("btnProductosBajos.Image");
            btnProductosBajos.Location = new Point(259, 5);
            btnProductosBajos.Name = "btnProductosBajos";
            btnProductosBajos.Size = new Size(195, 35);
            btnProductosBajos.TabIndex = 5;
            btnProductosBajos.Text = "Productos Bajo Inventario";
            btnProductosBajos.TextAlign = ContentAlignment.MiddleRight;
            btnProductosBajos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductosBajos.UseVisualStyleBackColor = false;
            // 
            // btnReporteInventario
            // 
            btnReporteInventario.BackColor = Color.FromArgb(0, 80, 200);
            btnReporteInventario.BackgroundImageLayout = ImageLayout.None;
            btnReporteInventario.FlatAppearance.BorderColor = Color.Silver;
            btnReporteInventario.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnReporteInventario.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnReporteInventario.FlatStyle = FlatStyle.Popup;
            btnReporteInventario.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporteInventario.ForeColor = SystemColors.ButtonHighlight;
            btnReporteInventario.Image = (Image)resources.GetObject("btnReporteInventario.Image");
            btnReporteInventario.Location = new Point(460, 5);
            btnReporteInventario.Name = "btnReporteInventario";
            btnReporteInventario.Size = new Size(175, 35);
            btnReporteInventario.TabIndex = 6;
            btnReporteInventario.Text = "Reporte de Inventario";
            btnReporteInventario.TextAlign = ContentAlignment.MiddleRight;
            btnReporteInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporteInventario.UseVisualStyleBackColor = false;
            // 
            // btnReporteMovimientos
            // 
            btnReporteMovimientos.BackColor = Color.FromArgb(0, 80, 200);
            btnReporteMovimientos.BackgroundImageLayout = ImageLayout.None;
            btnReporteMovimientos.FlatAppearance.BorderColor = Color.Silver;
            btnReporteMovimientos.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnReporteMovimientos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnReporteMovimientos.FlatStyle = FlatStyle.Popup;
            btnReporteMovimientos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporteMovimientos.ForeColor = SystemColors.ButtonHighlight;
            btnReporteMovimientos.Image = (Image)resources.GetObject("btnReporteMovimientos.Image");
            btnReporteMovimientos.Location = new Point(641, 5);
            btnReporteMovimientos.Name = "btnReporteMovimientos";
            btnReporteMovimientos.Size = new Size(189, 35);
            btnReporteMovimientos.TabIndex = 7;
            btnReporteMovimientos.Text = "Reporte de Movimientos";
            btnReporteMovimientos.TextAlign = ContentAlignment.MiddleRight;
            btnReporteMovimientos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporteMovimientos.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(49, 66, 82);
            panelMain.Dock = DockStyle.Fill;
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Location = new Point(0, 76);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1449, 508);
            panelMain.TabIndex = 17;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Controls.Add(panelNavbar);
            Controls.Add(panelHeader);
            Name = "Inventario";
            Size = new Size(1449, 584);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label ventasTitle;
        private Panel panelNavbar;
        public Button btnAgregar;
        public Button btnAjustes;
        public Button btnProductosBajos;
        public Button btnReporteInventario;
        public Button btnReporteMovimientos;
        private Panel panelMain;
    }
}
