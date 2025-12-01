namespace PuntoDeVenta.UserControls
{
    partial class TurnosControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurnosControl));
            panelHeader = new Panel();
            title = new Label();
            panelNavbar = new Panel();
            btnReporteTurnos = new Button();
            btnTurnoActual = new Button();
            panelMain = new Panel();
            panelHeader.SuspendLayout();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelHeader.BackColor = Color.Brown;
            panelHeader.BorderStyle = BorderStyle.FixedSingle;
            panelHeader.Controls.Add(title);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1461, 28);
            panelHeader.TabIndex = 4;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.ButtonHighlight;
            title.Location = new Point(3, 0);
            title.Name = "title";
            title.Size = new Size(86, 25);
            title.TabIndex = 0;
            title.Text = "TURNOS";
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BackColor = Color.FromArgb(26, 32, 40);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(btnReporteTurnos);
            panelNavbar.Controls.Add(btnTurnoActual);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.ForeColor = SystemColors.ButtonHighlight;
            panelNavbar.Location = new Point(0, 28);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1461, 48);
            panelNavbar.TabIndex = 19;
            // 
            // btnReporteTurnos
            // 
            btnReporteTurnos.BackColor = Color.FromArgb(0, 80, 200);
            btnReporteTurnos.BackgroundImageLayout = ImageLayout.None;
            btnReporteTurnos.FlatAppearance.BorderColor = Color.Silver;
            btnReporteTurnos.FlatAppearance.BorderSize = 0;
            btnReporteTurnos.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnReporteTurnos.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnReporteTurnos.FlatStyle = FlatStyle.Flat;
            btnReporteTurnos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReporteTurnos.ForeColor = SystemColors.ButtonHighlight;
            btnReporteTurnos.Image = (Image)resources.GetObject("btnReporteTurnos.Image");
            btnReporteTurnos.Location = new Point(202, 6);
            btnReporteTurnos.Name = "btnReporteTurnos";
            btnReporteTurnos.Size = new Size(182, 35);
            btnReporteTurnos.TabIndex = 5;
            btnReporteTurnos.Text = "Ver Turnos";
            btnReporteTurnos.TextAlign = ContentAlignment.MiddleRight;
            btnReporteTurnos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporteTurnos.UseVisualStyleBackColor = false;
            btnReporteTurnos.Click += btnReporteTurnos_Click;
            // 
            // btnTurnoActual
            // 
            btnTurnoActual.BackColor = Color.FromArgb(0, 80, 200);
            btnTurnoActual.BackgroundImageLayout = ImageLayout.None;
            btnTurnoActual.FlatAppearance.BorderColor = Color.Silver;
            btnTurnoActual.FlatAppearance.BorderSize = 0;
            btnTurnoActual.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnTurnoActual.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnTurnoActual.FlatStyle = FlatStyle.Flat;
            btnTurnoActual.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTurnoActual.ForeColor = SystemColors.ButtonHighlight;
            btnTurnoActual.Image = (Image)resources.GetObject("btnTurnoActual.Image");
            btnTurnoActual.Location = new Point(3, 6);
            btnTurnoActual.Name = "btnTurnoActual";
            btnTurnoActual.Size = new Size(193, 35);
            btnTurnoActual.TabIndex = 3;
            btnTurnoActual.Text = "Turno Actual";
            btnTurnoActual.TextAlign = ContentAlignment.MiddleRight;
            btnTurnoActual.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTurnoActual.UseVisualStyleBackColor = false;
            btnTurnoActual.Click += btnTurnoActualCajero_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(49, 66, 82);
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Dock = DockStyle.Fill;
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Location = new Point(0, 76);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1461, 513);
            panelMain.TabIndex = 20;
            // 
            // TurnosControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panelMain);
            Controls.Add(panelNavbar);
            Controls.Add(panelHeader);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "TurnosControl";
            Size = new Size(1461, 589);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label title;
        private Panel panelNavbar;
        public Button btnTurnoActual;
        private Panel panelMain;
        private TurnosControls.TurnoControl turnoControl;
        public Button btnReporteTurnos;
    }
}
