namespace PuntoDeVenta.UserControls
{
    partial class CorteControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorteControl));
            panelHeader = new Panel();
            title = new Label();
            panelNavbar = new Panel();
            btnCorteCajero = new Button();
            panelMain = new Panel();
            panel4 = new Panel();
            labelTotal = new Label();
            labelTotalEfectivo = new Label();
            txtTotalFinal = new Label();
            txtTotalEfectivo = new Label();
            labelTotalFinal = new Label();
            labelTotalTransferencia = new Label();
            txtTotalTransferencia = new Label();
            panel3 = new Panel();
            labelSalidas = new Label();
            labelSalidasEfectivo = new Label();
            txtSalidasTotal = new Label();
            txtSalidasEfectivo = new Label();
            labelSalidasTotal = new Label();
            labelSalidasTransferencia = new Label();
            txtSalidasTransferencia = new Label();
            panel2 = new Panel();
            labelEntradas = new Label();
            labelEntradasEfectivo = new Label();
            txtEntradasTotal = new Label();
            txtEntradasEfectivo = new Label();
            labelEntradasTotal = new Label();
            labelEntradasTransferencia = new Label();
            txtEntradasTransferencia = new Label();
            panel1 = new Panel();
            labelVentas = new Label();
            labelVentasEfectivo = new Label();
            txtVentasTotal = new Label();
            txtVentasEfectivo = new Label();
            labelVentasTotal = new Label();
            labelVentasTransferencia = new Label();
            txtVentasTransferencia = new Label();
            txtTurnoInicio = new Label();
            labelTurnoInicio = new Label();
            panelHeader.SuspendLayout();
            panelNavbar.SuspendLayout();
            panelMain.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            title.Size = new Size(70, 25);
            title.TabIndex = 0;
            title.Text = "CORTE";
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BackColor = Color.FromArgb(26, 32, 40);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(btnCorteCajero);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.ForeColor = SystemColors.ButtonHighlight;
            panelNavbar.Location = new Point(0, 28);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1461, 48);
            panelNavbar.TabIndex = 19;
            // 
            // btnCorteCajero
            // 
            btnCorteCajero.BackColor = Color.FromArgb(0, 80, 200);
            btnCorteCajero.BackgroundImageLayout = ImageLayout.None;
            btnCorteCajero.FlatAppearance.BorderColor = Color.Silver;
            btnCorteCajero.FlatAppearance.BorderSize = 0;
            btnCorteCajero.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnCorteCajero.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCorteCajero.FlatStyle = FlatStyle.Flat;
            btnCorteCajero.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCorteCajero.ForeColor = SystemColors.ButtonHighlight;
            btnCorteCajero.Image = (Image)resources.GetObject("btnCorteCajero.Image");
            btnCorteCajero.Location = new Point(3, 6);
            btnCorteCajero.Name = "btnCorteCajero";
            btnCorteCajero.Size = new Size(193, 35);
            btnCorteCajero.TabIndex = 3;
            btnCorteCajero.Text = "Corte Cajero";
            btnCorteCajero.TextAlign = ContentAlignment.MiddleRight;
            btnCorteCajero.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCorteCajero.UseVisualStyleBackColor = false;
            btnCorteCajero.Click += btnCorteCajero_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(49, 66, 82);
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(panel4);
            panelMain.Controls.Add(panel3);
            panelMain.Controls.Add(panel2);
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(txtTurnoInicio);
            panelMain.Controls.Add(labelTurnoInicio);
            panelMain.Dock = DockStyle.Fill;
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Location = new Point(0, 76);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1461, 513);
            panelMain.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(26, 32, 40);
            panel4.Controls.Add(labelTotal);
            panel4.Controls.Add(labelTotalEfectivo);
            panel4.Controls.Add(txtTotalFinal);
            panel4.Controls.Add(txtTotalEfectivo);
            panel4.Controls.Add(labelTotalFinal);
            panel4.Controls.Add(labelTotalTransferencia);
            panel4.Controls.Add(txtTotalTransferencia);
            panel4.Location = new Point(6, 395);
            panel4.Name = "panel4";
            panel4.Size = new Size(265, 103);
            panel4.TabIndex = 29;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTotal.Location = new Point(3, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(56, 21);
            labelTotal.TabIndex = 26;
            labelTotal.Text = "TOTAL";
            // 
            // labelTotalEfectivo
            // 
            labelTotalEfectivo.AutoSize = true;
            labelTotalEfectivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelTotalEfectivo.Location = new Point(3, 30);
            labelTotalEfectivo.Name = "labelTotalEfectivo";
            labelTotalEfectivo.Size = new Size(73, 21);
            labelTotalEfectivo.TabIndex = 2;
            labelTotalEfectivo.Text = "Efectivo:";
            // 
            // txtTotalFinal
            // 
            txtTotalFinal.AutoSize = true;
            txtTotalFinal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalFinal.ForeColor = SystemColors.ActiveBorder;
            txtTotalFinal.Location = new Point(176, 72);
            txtTotalFinal.Name = "txtTotalFinal";
            txtTotalFinal.Size = new Size(54, 21);
            txtTotalFinal.TabIndex = 7;
            txtTotalFinal.Text = "$ 0,00";
            // 
            // txtTotalEfectivo
            // 
            txtTotalEfectivo.AutoSize = true;
            txtTotalEfectivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalEfectivo.ForeColor = SystemColors.ActiveBorder;
            txtTotalEfectivo.Location = new Point(176, 30);
            txtTotalEfectivo.Name = "txtTotalEfectivo";
            txtTotalEfectivo.Size = new Size(54, 21);
            txtTotalEfectivo.TabIndex = 3;
            txtTotalEfectivo.Text = "$ 0,00";
            // 
            // labelTotalFinal
            // 
            labelTotalFinal.AutoSize = true;
            labelTotalFinal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelTotalFinal.Location = new Point(3, 72);
            labelTotalFinal.Name = "labelTotalFinal";
            labelTotalFinal.Size = new Size(49, 21);
            labelTotalFinal.TabIndex = 6;
            labelTotalFinal.Text = "Total:";
            // 
            // labelTotalTransferencia
            // 
            labelTotalTransferencia.AutoSize = true;
            labelTotalTransferencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelTotalTransferencia.Location = new Point(3, 51);
            labelTotalTransferencia.Name = "labelTotalTransferencia";
            labelTotalTransferencia.Size = new Size(111, 21);
            labelTotalTransferencia.TabIndex = 4;
            labelTotalTransferencia.Text = "Transferencia:";
            // 
            // txtTotalTransferencia
            // 
            txtTotalTransferencia.AutoSize = true;
            txtTotalTransferencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalTransferencia.ForeColor = SystemColors.ActiveBorder;
            txtTotalTransferencia.Location = new Point(176, 51);
            txtTotalTransferencia.Name = "txtTotalTransferencia";
            txtTotalTransferencia.Size = new Size(54, 21);
            txtTotalTransferencia.TabIndex = 5;
            txtTotalTransferencia.Text = "$ 0,00";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 32, 40);
            panel3.Controls.Add(labelSalidas);
            panel3.Controls.Add(labelSalidasEfectivo);
            panel3.Controls.Add(txtSalidasTotal);
            panel3.Controls.Add(txtSalidasEfectivo);
            panel3.Controls.Add(labelSalidasTotal);
            panel3.Controls.Add(labelSalidasTransferencia);
            panel3.Controls.Add(txtSalidasTransferencia);
            panel3.Location = new Point(6, 277);
            panel3.Name = "panel3";
            panel3.Size = new Size(265, 103);
            panel3.TabIndex = 29;
            // 
            // labelSalidas
            // 
            labelSalidas.AutoSize = true;
            labelSalidas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelSalidas.Location = new Point(3, 0);
            labelSalidas.Name = "labelSalidas";
            labelSalidas.Size = new Size(75, 21);
            labelSalidas.TabIndex = 26;
            labelSalidas.Text = "SALIDAS";
            // 
            // labelSalidasEfectivo
            // 
            labelSalidasEfectivo.AutoSize = true;
            labelSalidasEfectivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelSalidasEfectivo.Location = new Point(3, 30);
            labelSalidasEfectivo.Name = "labelSalidasEfectivo";
            labelSalidasEfectivo.Size = new Size(73, 21);
            labelSalidasEfectivo.TabIndex = 2;
            labelSalidasEfectivo.Text = "Efectivo:";
            // 
            // txtSalidasTotal
            // 
            txtSalidasTotal.AutoSize = true;
            txtSalidasTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSalidasTotal.ForeColor = SystemColors.ActiveBorder;
            txtSalidasTotal.Location = new Point(176, 72);
            txtSalidasTotal.Name = "txtSalidasTotal";
            txtSalidasTotal.Size = new Size(54, 21);
            txtSalidasTotal.TabIndex = 7;
            txtSalidasTotal.Text = "$ 0,00";
            // 
            // txtSalidasEfectivo
            // 
            txtSalidasEfectivo.AutoSize = true;
            txtSalidasEfectivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSalidasEfectivo.ForeColor = SystemColors.ActiveBorder;
            txtSalidasEfectivo.Location = new Point(176, 30);
            txtSalidasEfectivo.Name = "txtSalidasEfectivo";
            txtSalidasEfectivo.Size = new Size(54, 21);
            txtSalidasEfectivo.TabIndex = 3;
            txtSalidasEfectivo.Text = "$ 0,00";
            // 
            // labelSalidasTotal
            // 
            labelSalidasTotal.AutoSize = true;
            labelSalidasTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelSalidasTotal.Location = new Point(3, 72);
            labelSalidasTotal.Name = "labelSalidasTotal";
            labelSalidasTotal.Size = new Size(49, 21);
            labelSalidasTotal.TabIndex = 6;
            labelSalidasTotal.Text = "Total:";
            // 
            // labelSalidasTransferencia
            // 
            labelSalidasTransferencia.AutoSize = true;
            labelSalidasTransferencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelSalidasTransferencia.Location = new Point(3, 51);
            labelSalidasTransferencia.Name = "labelSalidasTransferencia";
            labelSalidasTransferencia.Size = new Size(111, 21);
            labelSalidasTransferencia.TabIndex = 4;
            labelSalidasTransferencia.Text = "Transferencia:";
            // 
            // txtSalidasTransferencia
            // 
            txtSalidasTransferencia.AutoSize = true;
            txtSalidasTransferencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSalidasTransferencia.ForeColor = SystemColors.ActiveBorder;
            txtSalidasTransferencia.Location = new Point(176, 51);
            txtSalidasTransferencia.Name = "txtSalidasTransferencia";
            txtSalidasTransferencia.Size = new Size(54, 21);
            txtSalidasTransferencia.TabIndex = 5;
            txtSalidasTransferencia.Text = "$ 0,00";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Controls.Add(labelEntradas);
            panel2.Controls.Add(labelEntradasEfectivo);
            panel2.Controls.Add(txtEntradasTotal);
            panel2.Controls.Add(txtEntradasEfectivo);
            panel2.Controls.Add(labelEntradasTotal);
            panel2.Controls.Add(labelEntradasTransferencia);
            panel2.Controls.Add(txtEntradasTransferencia);
            panel2.Location = new Point(6, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 103);
            panel2.TabIndex = 28;
            // 
            // labelEntradas
            // 
            labelEntradas.AutoSize = true;
            labelEntradas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelEntradas.Location = new Point(3, 0);
            labelEntradas.Name = "labelEntradas";
            labelEntradas.Size = new Size(94, 21);
            labelEntradas.TabIndex = 26;
            labelEntradas.Text = "ENTRADAS";
            // 
            // labelEntradasEfectivo
            // 
            labelEntradasEfectivo.AutoSize = true;
            labelEntradasEfectivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelEntradasEfectivo.Location = new Point(3, 30);
            labelEntradasEfectivo.Name = "labelEntradasEfectivo";
            labelEntradasEfectivo.Size = new Size(73, 21);
            labelEntradasEfectivo.TabIndex = 2;
            labelEntradasEfectivo.Text = "Efectivo:";
            // 
            // txtEntradasTotal
            // 
            txtEntradasTotal.AutoSize = true;
            txtEntradasTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEntradasTotal.ForeColor = SystemColors.ActiveBorder;
            txtEntradasTotal.Location = new Point(176, 72);
            txtEntradasTotal.Name = "txtEntradasTotal";
            txtEntradasTotal.Size = new Size(54, 21);
            txtEntradasTotal.TabIndex = 7;
            txtEntradasTotal.Text = "$ 0,00";
            // 
            // txtEntradasEfectivo
            // 
            txtEntradasEfectivo.AutoSize = true;
            txtEntradasEfectivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEntradasEfectivo.ForeColor = SystemColors.ActiveBorder;
            txtEntradasEfectivo.Location = new Point(176, 30);
            txtEntradasEfectivo.Name = "txtEntradasEfectivo";
            txtEntradasEfectivo.Size = new Size(54, 21);
            txtEntradasEfectivo.TabIndex = 3;
            txtEntradasEfectivo.Text = "$ 0,00";
            // 
            // labelEntradasTotal
            // 
            labelEntradasTotal.AutoSize = true;
            labelEntradasTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelEntradasTotal.Location = new Point(3, 72);
            labelEntradasTotal.Name = "labelEntradasTotal";
            labelEntradasTotal.Size = new Size(49, 21);
            labelEntradasTotal.TabIndex = 6;
            labelEntradasTotal.Text = "Total:";
            // 
            // labelEntradasTransferencia
            // 
            labelEntradasTransferencia.AutoSize = true;
            labelEntradasTransferencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelEntradasTransferencia.Location = new Point(3, 51);
            labelEntradasTransferencia.Name = "labelEntradasTransferencia";
            labelEntradasTransferencia.Size = new Size(111, 21);
            labelEntradasTransferencia.TabIndex = 4;
            labelEntradasTransferencia.Text = "Transferencia:";
            // 
            // txtEntradasTransferencia
            // 
            txtEntradasTransferencia.AutoSize = true;
            txtEntradasTransferencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEntradasTransferencia.ForeColor = SystemColors.ActiveBorder;
            txtEntradasTransferencia.Location = new Point(176, 51);
            txtEntradasTransferencia.Name = "txtEntradasTransferencia";
            txtEntradasTransferencia.Size = new Size(54, 21);
            txtEntradasTransferencia.TabIndex = 5;
            txtEntradasTransferencia.Text = "$ 0,00";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Controls.Add(labelVentas);
            panel1.Controls.Add(labelVentasEfectivo);
            panel1.Controls.Add(txtVentasTotal);
            panel1.Controls.Add(txtVentasEfectivo);
            panel1.Controls.Add(labelVentasTotal);
            panel1.Controls.Add(labelVentasTransferencia);
            panel1.Controls.Add(txtVentasTransferencia);
            panel1.Location = new Point(6, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 103);
            panel1.TabIndex = 27;
            // 
            // labelVentas
            // 
            labelVentas.AutoSize = true;
            labelVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelVentas.Location = new Point(3, 0);
            labelVentas.Name = "labelVentas";
            labelVentas.Size = new Size(71, 21);
            labelVentas.TabIndex = 26;
            labelVentas.Text = "VENTAS";
            // 
            // labelVentasEfectivo
            // 
            labelVentasEfectivo.AutoSize = true;
            labelVentasEfectivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelVentasEfectivo.Location = new Point(3, 30);
            labelVentasEfectivo.Name = "labelVentasEfectivo";
            labelVentasEfectivo.Size = new Size(73, 21);
            labelVentasEfectivo.TabIndex = 2;
            labelVentasEfectivo.Text = "Efectivo:";
            // 
            // txtVentasTotal
            // 
            txtVentasTotal.AutoSize = true;
            txtVentasTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVentasTotal.ForeColor = SystemColors.ActiveBorder;
            txtVentasTotal.Location = new Point(176, 72);
            txtVentasTotal.Name = "txtVentasTotal";
            txtVentasTotal.Size = new Size(54, 21);
            txtVentasTotal.TabIndex = 7;
            txtVentasTotal.Text = "$ 0,00";
            // 
            // txtVentasEfectivo
            // 
            txtVentasEfectivo.AutoSize = true;
            txtVentasEfectivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVentasEfectivo.ForeColor = SystemColors.ActiveBorder;
            txtVentasEfectivo.Location = new Point(176, 30);
            txtVentasEfectivo.Name = "txtVentasEfectivo";
            txtVentasEfectivo.Size = new Size(54, 21);
            txtVentasEfectivo.TabIndex = 3;
            txtVentasEfectivo.Text = "$ 0,00";
            // 
            // labelVentasTotal
            // 
            labelVentasTotal.AutoSize = true;
            labelVentasTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelVentasTotal.Location = new Point(3, 72);
            labelVentasTotal.Name = "labelVentasTotal";
            labelVentasTotal.Size = new Size(49, 21);
            labelVentasTotal.TabIndex = 6;
            labelVentasTotal.Text = "Total:";
            // 
            // labelVentasTransferencia
            // 
            labelVentasTransferencia.AutoSize = true;
            labelVentasTransferencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelVentasTransferencia.Location = new Point(3, 51);
            labelVentasTransferencia.Name = "labelVentasTransferencia";
            labelVentasTransferencia.Size = new Size(111, 21);
            labelVentasTransferencia.TabIndex = 4;
            labelVentasTransferencia.Text = "Transferencia:";
            // 
            // txtVentasTransferencia
            // 
            txtVentasTransferencia.AutoSize = true;
            txtVentasTransferencia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVentasTransferencia.ForeColor = SystemColors.ActiveBorder;
            txtVentasTransferencia.Location = new Point(176, 51);
            txtVentasTransferencia.Name = "txtVentasTransferencia";
            txtVentasTransferencia.Size = new Size(54, 21);
            txtVentasTransferencia.TabIndex = 5;
            txtVentasTransferencia.Text = "$ 0,00";
            // 
            // txtTurnoInicio
            // 
            txtTurnoInicio.AutoSize = true;
            txtTurnoInicio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTurnoInicio.ForeColor = SystemColors.ActiveBorder;
            txtTurnoInicio.Location = new Point(126, 2);
            txtTurnoInicio.Name = "txtTurnoInicio";
            txtTurnoInicio.Size = new Size(104, 21);
            txtTurnoInicio.TabIndex = 1;
            txtTurnoInicio.Text = "dd/mm/yyyy";
            // 
            // labelTurnoInicio
            // 
            labelTurnoInicio.AutoSize = true;
            labelTurnoInicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTurnoInicio.Location = new Point(3, 2);
            labelTurnoInicio.Name = "labelTurnoInicio";
            labelTurnoInicio.Size = new Size(128, 21);
            labelTurnoInicio.TabIndex = 0;
            labelTurnoInicio.Text = "Turno Iniciado: ";
            // 
            // CorteControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panelMain);
            Controls.Add(panelNavbar);
            Controls.Add(panelHeader);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "CorteControl";
            Size = new Size(1461, 589);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavbar.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label title;
        private Panel panelNavbar;
        public Button btnCorteCajero;
        private Panel panelMain;
        private Label txtTurnoInicio;
        private Label labelTurnoInicio;
        private Label txtVentasEfectivo;
        private Label labelVentasEfectivo;
        private Label labelVentas;
        private Label txtVentasTotal;
        private Label labelVentasTotal;
        private Label txtVentasTransferencia;
        private Label labelVentasTransferencia;
        private Panel panel1;
        private Panel panel4;
        private Label labelTotal;
        private Label labelTotalEfectivo;
        private Label txtTotalFinal;
        private Label txtTotalEfectivo;
        private Label labelTotalFinal;
        private Label labelTotalTransferencia;
        private Label txtTotalTransferencia;
        private Panel panel3;
        private Label labelSalidas;
        private Label labelSalidasEfectivo;
        private Label txtSalidasTotal;
        private Label txtSalidasEfectivo;
        private Label labelSalidasTotal;
        private Label labelSalidasTransferencia;
        private Label txtSalidasTransferencia;
        private Panel panel2;
        private Label labelEntradas;
        private Label labelEntradasEfectivo;
        private Label txtEntradasTotal;
        private Label txtEntradasEfectivo;
        private Label labelEntradasTotal;
        private Label labelEntradasTransferencia;
        private Label txtEntradasTransferencia;
    }
}
