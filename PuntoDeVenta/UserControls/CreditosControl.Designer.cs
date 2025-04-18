using PuntoDeVenta.Properties;

namespace PuntoDeVenta.UserControls
{
    partial class CreditosControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditosControl));
            panelHeader = new Panel();
            ventasTitle = new Label();
            panelNavbar = new Panel();
            btnEstadoCuenta = new Button();
            btnReporteSaldo = new Button();
            panelMain = new Panel();
            panelHeader.SuspendLayout();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelHeader.BackColor = Color.Teal;
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
            ventasTitle.Size = new Size(194, 25);
            ventasTitle.TabIndex = 0;
            ventasTitle.Text = "CREDITO A CLIENTES";
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(btnEstadoCuenta);
            panelNavbar.Controls.Add(btnReporteSaldo);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(0, 28);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1449, 48);
            panelNavbar.TabIndex = 16;
            // 
            // btnEstadoCuenta
            // 
            btnEstadoCuenta.BackColor = Color.FromArgb(0, 80, 200);
            btnEstadoCuenta.BackgroundImageLayout = ImageLayout.None;
            btnEstadoCuenta.FlatAppearance.BorderColor = Color.Silver;
            btnEstadoCuenta.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnEstadoCuenta.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnEstadoCuenta.FlatStyle = FlatStyle.Flat;
            btnEstadoCuenta.FlatAppearance.BorderSize = 0;
            btnEstadoCuenta.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstadoCuenta.ForeColor = SystemColors.ButtonHighlight;
            btnEstadoCuenta.Image = (Image)resources.GetObject("btnEstadoCuenta.Image");
            btnEstadoCuenta.Location = new Point(3, 5);
            btnEstadoCuenta.Name = "btnEstadoCuenta";
            btnEstadoCuenta.Size = new Size(167, 35);
            btnEstadoCuenta.TabIndex = 3;
            btnEstadoCuenta.Text = "Estado de Cuenta";
            btnEstadoCuenta.TextAlign = ContentAlignment.MiddleRight;
            btnEstadoCuenta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstadoCuenta.UseVisualStyleBackColor = false;
            btnEstadoCuenta.Click += btnEstadoCuenta_Click;
            // 
            // btnReporteSaldo
            // 
            btnReporteSaldo.BackColor = Color.FromArgb(0, 80, 200);
            btnReporteSaldo.BackgroundImageLayout = ImageLayout.None;
            btnReporteSaldo.FlatAppearance.BorderColor = Color.Silver;
            btnReporteSaldo.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnReporteSaldo.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnReporteSaldo.FlatStyle = FlatStyle.Flat;
            btnReporteSaldo.FlatAppearance.BorderSize = 0;
            btnReporteSaldo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporteSaldo.ForeColor = SystemColors.ButtonHighlight;
            btnReporteSaldo.Image = (Image)resources.GetObject("btnReporteSaldo.Image");
            btnReporteSaldo.Location = new Point(176, 5);
            btnReporteSaldo.Name = "btnReporteSaldo";
            btnReporteSaldo.Size = new Size(145, 35);
            btnReporteSaldo.TabIndex = 4;
            btnReporteSaldo.Text = "Reporte de Saldos";
            btnReporteSaldo.TextAlign = ContentAlignment.MiddleRight;
            btnReporteSaldo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporteSaldo.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 76);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1449, 508);
            panelMain.TabIndex = 17;
            // 
            // Creditos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            Controls.Add(panelMain);
            Controls.Add(panelNavbar);
            Controls.Add(panelHeader);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Creditos";
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
        public Button btnEstadoCuenta;
        public Button btnReporteSaldo;
        private Panel panelMain;
    }
}
