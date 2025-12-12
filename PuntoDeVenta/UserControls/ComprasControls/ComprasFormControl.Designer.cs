namespace PuntoDeVenta.UserControls.ComprasControls
{
    partial class ComprasFormControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprasFormControl));
            labelTotalEfectivo = new Label();
            panel1 = new Panel();
            btnMercadoPago = new Button();
            btnEfectivo = new Button();
            labelTotalMercadoPago = new Label();
            btnGuardar = new Button();
            lblNuevoGasto = new Label();
            labelFormaPago = new Label();
            comboFormaPago = new ComboBox();
            labelTipoMovimiento = new Label();
            comboTipoMovimiento = new ComboBox();
            labelValor = new Label();
            txtValor = new NumericUpDown();
            txtDescripcion = new TextBox();
            labelDescripcion = new Label();
            panelGrid = new Panel();
            panelDataGrid = new Panel();
            labelSinResultados = new Label();
            dvMovimientos = new DataGridView();
            panelHeaderGrid = new Panel();
            labelPago = new Label();
            comboFiltroFormaPago = new ComboBox();
            linkLabelMes = new LinkLabel();
            linkLabelSemana = new LinkLabel();
            linkLabelHoy = new LinkLabel();
            label1 = new Label();
            btnExportar = new Button();
            btnBuscar = new Button();
            labelHasta = new Label();
            labelDesde = new Label();
            dateHasta = new DateTimePicker();
            dateDesde = new DateTimePicker();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtValor).BeginInit();
            panelGrid.SuspendLayout();
            panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvMovimientos).BeginInit();
            panelHeaderGrid.SuspendLayout();
            SuspendLayout();
            // 
            // labelTotalEfectivo
            // 
            labelTotalEfectivo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTotalEfectivo.BackColor = Color.White;
            labelTotalEfectivo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalEfectivo.ForeColor = SystemColors.ActiveCaptionText;
            labelTotalEfectivo.Location = new Point(96, 311);
            labelTotalEfectivo.Name = "labelTotalEfectivo";
            labelTotalEfectivo.Size = new Size(180, 48);
            labelTotalEfectivo.TabIndex = 13;
            labelTotalEfectivo.Text = "$ 0.00";
            labelTotalEfectivo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 66, 82);
            panel1.Controls.Add(btnMercadoPago);
            panel1.Controls.Add(btnEfectivo);
            panel1.Controls.Add(labelTotalMercadoPago);
            panel1.Controls.Add(labelTotalEfectivo);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(lblNuevoGasto);
            panel1.Controls.Add(labelFormaPago);
            panel1.Controls.Add(comboFormaPago);
            panel1.Controls.Add(labelTipoMovimiento);
            panel1.Controls.Add(comboTipoMovimiento);
            panel1.Controls.Add(labelValor);
            panel1.Controls.Add(txtValor);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(labelDescripcion);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 3, 8, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 565);
            panel1.TabIndex = 1;
            // 
            // btnMercadoPago
            // 
            btnMercadoPago.BackColor = Color.FromArgb(0, 80, 200);
            btnMercadoPago.BackgroundImage = Properties.Resources.payment_mercadopago;
            btnMercadoPago.BackgroundImageLayout = ImageLayout.Stretch;
            btnMercadoPago.FlatAppearance.BorderColor = Color.Black;
            btnMercadoPago.FlatAppearance.BorderSize = 0;
            btnMercadoPago.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnMercadoPago.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnMercadoPago.FlatStyle = FlatStyle.Popup;
            btnMercadoPago.Font = new Font("Segoe UI", 8.25F);
            btnMercadoPago.ForeColor = SystemColors.ButtonHighlight;
            btnMercadoPago.ImeMode = ImeMode.NoControl;
            btnMercadoPago.Location = new Point(19, 375);
            btnMercadoPago.Name = "btnMercadoPago";
            btnMercadoPago.Size = new Size(48, 48);
            btnMercadoPago.TabIndex = 36;
            btnMercadoPago.TextAlign = ContentAlignment.BottomCenter;
            btnMercadoPago.TextImageRelation = TextImageRelation.TextAboveImage;
            btnMercadoPago.UseVisualStyleBackColor = false;
            btnMercadoPago.Click += btnMercadoPago_Click;
            // 
            // btnEfectivo
            // 
            btnEfectivo.BackColor = Color.FromArgb(0, 80, 200);
            btnEfectivo.BackgroundImage = Properties.Resources.payment_cash;
            btnEfectivo.BackgroundImageLayout = ImageLayout.Stretch;
            btnEfectivo.FlatAppearance.BorderColor = Color.Black;
            btnEfectivo.FlatAppearance.BorderSize = 0;
            btnEfectivo.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnEfectivo.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnEfectivo.FlatStyle = FlatStyle.Popup;
            btnEfectivo.Font = new Font("Segoe UI", 8.25F);
            btnEfectivo.ForeColor = SystemColors.ButtonHighlight;
            btnEfectivo.ImeMode = ImeMode.NoControl;
            btnEfectivo.Location = new Point(19, 311);
            btnEfectivo.Name = "btnEfectivo";
            btnEfectivo.Size = new Size(48, 48);
            btnEfectivo.TabIndex = 35;
            btnEfectivo.TextAlign = ContentAlignment.BottomCenter;
            btnEfectivo.TextImageRelation = TextImageRelation.TextAboveImage;
            btnEfectivo.UseVisualStyleBackColor = false;
            btnEfectivo.Click += btnEfectivo_Click;
            // 
            // labelTotalMercadoPago
            // 
            labelTotalMercadoPago.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTotalMercadoPago.BackColor = Color.White;
            labelTotalMercadoPago.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalMercadoPago.ForeColor = SystemColors.ActiveCaptionText;
            labelTotalMercadoPago.Location = new Point(96, 375);
            labelTotalMercadoPago.Name = "labelTotalMercadoPago";
            labelTotalMercadoPago.Size = new Size(181, 48);
            labelTotalMercadoPago.TabIndex = 34;
            labelTotalMercadoPago.Text = "$ 0.00";
            labelTotalMercadoPago.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 80, 200);
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.FlatAppearance.BorderColor = Color.Silver;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(76, 217);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(136, 35);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblNuevoGasto
            // 
            lblNuevoGasto.AutoSize = true;
            lblNuevoGasto.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNuevoGasto.ForeColor = SystemColors.ButtonHighlight;
            lblNuevoGasto.Location = new Point(62, 10);
            lblNuevoGasto.Name = "lblNuevoGasto";
            lblNuevoGasto.Size = new Size(168, 25);
            lblNuevoGasto.TabIndex = 3;
            lblNuevoGasto.Text = "NUEVO REGISTRO";
            // 
            // labelFormaPago
            // 
            labelFormaPago.AutoSize = true;
            labelFormaPago.Font = new Font("Segoe UI", 10F);
            labelFormaPago.ForeColor = SystemColors.ButtonHighlight;
            labelFormaPago.Location = new Point(9, 164);
            labelFormaPago.Name = "labelFormaPago";
            labelFormaPago.Size = new Size(43, 19);
            labelFormaPago.TabIndex = 32;
            labelFormaPago.Text = "Pago:";
            // 
            // comboFormaPago
            // 
            comboFormaPago.FormattingEnabled = true;
            comboFormaPago.Location = new Point(108, 160);
            comboFormaPago.Name = "comboFormaPago";
            comboFormaPago.Size = new Size(168, 23);
            comboFormaPago.TabIndex = 31;
            // 
            // labelTipoMovimiento
            // 
            labelTipoMovimiento.AutoSize = true;
            labelTipoMovimiento.Font = new Font("Segoe UI", 10F);
            labelTipoMovimiento.ForeColor = SystemColors.ButtonHighlight;
            labelTipoMovimiento.Location = new Point(9, 128);
            labelTipoMovimiento.Name = "labelTipoMovimiento";
            labelTipoMovimiento.Size = new Size(38, 19);
            labelTipoMovimiento.TabIndex = 28;
            labelTipoMovimiento.Text = "Tipo:";
            // 
            // comboTipoMovimiento
            // 
            comboTipoMovimiento.FormattingEnabled = true;
            comboTipoMovimiento.Location = new Point(108, 124);
            comboTipoMovimiento.Name = "comboTipoMovimiento";
            comboTipoMovimiento.Size = new Size(168, 23);
            comboTipoMovimiento.TabIndex = 27;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Segoe UI", 10F);
            labelValor.ForeColor = SystemColors.ButtonHighlight;
            labelValor.Location = new Point(9, 93);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(43, 19);
            labelValor.TabIndex = 29;
            labelValor.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(109, 89);
            txtValor.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(168, 23);
            txtValor.TabIndex = 26;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(109, 55);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(168, 23);
            txtDescripcion.TabIndex = 25;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Segoe UI", 10F);
            labelDescripcion.ForeColor = SystemColors.ButtonHighlight;
            labelDescripcion.Location = new Point(9, 56);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(86, 19);
            labelDescripcion.TabIndex = 30;
            labelDescripcion.Text = "Descripción: ";
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.FromArgb(49, 66, 82);
            panelGrid.BorderStyle = BorderStyle.FixedSingle;
            panelGrid.Controls.Add(panelDataGrid);
            panelGrid.Controls.Add(panelHeaderGrid);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(290, 0);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(808, 565);
            panelGrid.TabIndex = 2;
            // 
            // panelDataGrid
            // 
            panelDataGrid.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelDataGrid.Controls.Add(labelSinResultados);
            panelDataGrid.Controls.Add(dvMovimientos);
            panelDataGrid.Dock = DockStyle.Fill;
            panelDataGrid.Location = new Point(0, 126);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(806, 437);
            panelDataGrid.TabIndex = 31;
            // 
            // labelSinResultados
            // 
            labelSinResultados.AutoSize = true;
            labelSinResultados.Font = new Font("Segoe UI", 16F);
            labelSinResultados.ForeColor = SystemColors.ButtonHighlight;
            labelSinResultados.Location = new Point(6, 13);
            labelSinResultados.Name = "labelSinResultados";
            labelSinResultados.Size = new Size(298, 30);
            labelSinResultados.TabIndex = 24;
            labelSinResultados.Text = "No se encontraron resultados";
            labelSinResultados.Visible = false;
            // 
            // dvMovimientos
            // 
            dvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvMovimientos.BackgroundColor = Color.FromArgb(49, 66, 82);
            dvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvMovimientos.Dock = DockStyle.Fill;
            dvMovimientos.Location = new Point(0, 0);
            dvMovimientos.Name = "dvMovimientos";
            dvMovimientos.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dvMovimientos.Size = new Size(806, 437);
            dvMovimientos.TabIndex = 23;
            // 
            // panelHeaderGrid
            // 
            panelHeaderGrid.Controls.Add(labelPago);
            panelHeaderGrid.Controls.Add(comboFiltroFormaPago);
            panelHeaderGrid.Controls.Add(linkLabelMes);
            panelHeaderGrid.Controls.Add(linkLabelSemana);
            panelHeaderGrid.Controls.Add(linkLabelHoy);
            panelHeaderGrid.Controls.Add(label1);
            panelHeaderGrid.Controls.Add(btnExportar);
            panelHeaderGrid.Controls.Add(btnBuscar);
            panelHeaderGrid.Controls.Add(labelHasta);
            panelHeaderGrid.Controls.Add(labelDesde);
            panelHeaderGrid.Controls.Add(dateHasta);
            panelHeaderGrid.Controls.Add(dateDesde);
            panelHeaderGrid.Controls.Add(label2);
            panelHeaderGrid.Dock = DockStyle.Top;
            panelHeaderGrid.Location = new Point(0, 0);
            panelHeaderGrid.Name = "panelHeaderGrid";
            panelHeaderGrid.Size = new Size(806, 126);
            panelHeaderGrid.TabIndex = 30;
            // 
            // labelPago
            // 
            labelPago.AutoSize = true;
            labelPago.Font = new Font("Segoe UI", 10F);
            labelPago.ForeColor = SystemColors.ButtonHighlight;
            labelPago.Location = new Point(517, 75);
            labelPago.Name = "labelPago";
            labelPago.Size = new Size(43, 19);
            labelPago.TabIndex = 33;
            labelPago.Text = "Pago:";
            // 
            // comboFiltroFormaPago
            // 
            comboFiltroFormaPago.FormattingEnabled = true;
            comboFiltroFormaPago.Location = new Point(517, 97);
            comboFiltroFormaPago.Name = "comboFiltroFormaPago";
            comboFiltroFormaPago.Size = new Size(192, 23);
            comboFiltroFormaPago.TabIndex = 32;
            // 
            // linkLabelMes
            // 
            linkLabelMes.AutoSize = true;
            linkLabelMes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelMes.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabelMes.Location = new Point(226, 45);
            linkLabelMes.Name = "linkLabelMes";
            linkLabelMes.Size = new Size(88, 21);
            linkLabelMes.TabIndex = 27;
            linkLabelMes.TabStop = true;
            linkLabelMes.Text = "Mes actual";
            linkLabelMes.LinkClicked += linkLabelMes_LinkClicked;
            // 
            // linkLabelSemana
            // 
            linkLabelSemana.AutoSize = true;
            linkLabelSemana.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelSemana.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabelSemana.Location = new Point(81, 45);
            linkLabelSemana.Name = "linkLabelSemana";
            linkLabelSemana.Size = new Size(116, 21);
            linkLabelSemana.TabIndex = 26;
            linkLabelSemana.TabStop = true;
            linkLabelSemana.Text = "Última semana";
            linkLabelSemana.LinkClicked += linkLabelSemana_LinkClicked;
            // 
            // linkLabelHoy
            // 
            linkLabelHoy.AutoSize = true;
            linkLabelHoy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelHoy.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabelHoy.Location = new Point(10, 45);
            linkLabelHoy.Name = "linkLabelHoy";
            linkLabelHoy.Size = new Size(40, 21);
            linkLabelHoy.TabIndex = 25;
            linkLabelHoy.TabStop = true;
            linkLabelHoy.Text = "Hoy";
            linkLabelHoy.LinkClicked += linkLabelHoy_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1862, 87);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 24;
            label1.Text = "TOTAL: $0";
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(0, 80, 200);
            btnExportar.BackgroundImageLayout = ImageLayout.None;
            btnExportar.FlatAppearance.BorderColor = Color.Silver;
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnExportar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = SystemColors.ButtonHighlight;
            btnExportar.Image = (Image)resources.GetObject("btnExportar.Image");
            btnExportar.Location = new Point(679, 10);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(114, 35);
            btnExportar.TabIndex = 23;
            btnExportar.Text = "Exportar";
            btnExportar.TextAlign = ContentAlignment.MiddleRight;
            btnExportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 80, 200);
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.FlatAppearance.BorderColor = Color.Silver;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(556, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(103, 35);
            btnBuscar.TabIndex = 22;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // labelHasta
            // 
            labelHasta.AutoSize = true;
            labelHasta.Font = new Font("Segoe UI", 10F);
            labelHasta.ForeColor = SystemColors.ButtonHighlight;
            labelHasta.Location = new Point(261, 75);
            labelHasta.Name = "labelHasta";
            labelHasta.Size = new Size(47, 19);
            labelHasta.TabIndex = 21;
            labelHasta.Text = "Hasta:";
            // 
            // labelDesde
            // 
            labelDesde.AutoSize = true;
            labelDesde.Font = new Font("Segoe UI", 10F);
            labelDesde.ForeColor = SystemColors.ButtonHighlight;
            labelDesde.Location = new Point(10, 75);
            labelDesde.Name = "labelDesde";
            labelDesde.Size = new Size(54, 19);
            labelDesde.TabIndex = 20;
            labelDesde.Text = "Desde: ";
            // 
            // dateHasta
            // 
            dateHasta.Location = new Point(261, 97);
            dateHasta.Name = "dateHasta";
            dateHasta.Size = new Size(227, 23);
            dateHasta.TabIndex = 4;
            // 
            // dateDesde
            // 
            dateDesde.Location = new Point(10, 97);
            dateDesde.Name = "dateDesde";
            dateDesde.Size = new Size(227, 23);
            dateDesde.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(228, 25);
            label2.TabIndex = 2;
            label2.Text = "REPORTE MOVIMIENTOS";
            // 
            // ComprasFormControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            Controls.Add(panelGrid);
            Controls.Add(panel1);
            Name = "ComprasFormControl";
            Size = new Size(1098, 565);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtValor).EndInit();
            panelGrid.ResumeLayout(false);
            panelDataGrid.ResumeLayout(false);
            panelDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvMovimientos).EndInit();
            panelHeaderGrid.ResumeLayout(false);
            panelHeaderGrid.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label lblNuevoGasto;
        private Label labelFormaPago;
        private ComboBox comboFormaPago;
        private Label labelTipoMovimiento;
        private ComboBox comboTipoMovimiento;
        private Label labelValor;
        private NumericUpDown txtValor;
        private TextBox txtDescripcion;
        private Label labelDescripcion;
        public Button btnGuardar;
        private Panel panelGrid;
        private Label labelTotalEfectivo;
        private Panel panelHeaderGrid;
        private LinkLabel linkLabelMes;
        private LinkLabel linkLabelSemana;
        private LinkLabel linkLabelHoy;
        private Label label1;
        public Button btnExportar;
        public Button btnBuscar;
        private Label labelHasta;
        private Label labelDesde;
        private DateTimePicker dateHasta;
        private DateTimePicker dateDesde;
        private Label label2;
        private Panel panelDataGrid;
        private Label labelSinResultados;
        private DataGridView dvMovimientos;
        private Label labelTotalMercadoPago;
        public Button btnMercadoPago;
        public Button btnEfectivo;
        private Label labelPago;
        private ComboBox comboFiltroFormaPago;
    }
}
