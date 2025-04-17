using PuntoDeVenta.Properties;

namespace PuntoDeVenta.UserControls
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            panelHeader = new Panel();
            ventasTitle = new Label();
            panelNavbar = new Panel();
            btnAdministracionClientes = new Button();
            panelMain = new Panel();
            panelHeader.SuspendLayout();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelHeader.BackColor = Color.LightSlateGray;
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
            ventasTitle.Size = new Size(94, 25);
            ventasTitle.TabIndex = 0;
            ventasTitle.Text = "CLIENTES";
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BackColor = Color.FromArgb(49, 66, 82);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(btnAdministracionClientes);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.ForeColor = SystemColors.ButtonHighlight;
            panelNavbar.Location = new Point(0, 28);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1449, 48);
            panelNavbar.TabIndex = 16;
            // 
            // btnAdministracionClientes
            // 
            btnAdministracionClientes.BackColor = Color.FromArgb(0, 80, 200);
            btnAdministracionClientes.BackgroundImageLayout = ImageLayout.None;
            btnAdministracionClientes.FlatAppearance.BorderColor = Color.Silver;
            btnAdministracionClientes.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnAdministracionClientes.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAdministracionClientes.FlatStyle = FlatStyle.Popup;
            btnAdministracionClientes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdministracionClientes.ForeColor = SystemColors.ButtonHighlight;
            btnAdministracionClientes.Image = (Image)resources.GetObject("btnAdministracionClientes.Image");
            btnAdministracionClientes.Location = new Point(3, 3);
            btnAdministracionClientes.Name = "btnAdministracionClientes";
            btnAdministracionClientes.Size = new Size(193, 35);
            btnAdministracionClientes.TabIndex = 3;
            btnAdministracionClientes.Text = "Administración de clientes";
            btnAdministracionClientes.TextAlign = ContentAlignment.MiddleRight;
            btnAdministracionClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdministracionClientes.UseVisualStyleBackColor = false;
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
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Controls.Add(panelNavbar);
            Controls.Add(panelHeader);
            Name = "Clientes";
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
        public Button btnAdministracionClientes;
        private Panel panelMain;
    }
}
