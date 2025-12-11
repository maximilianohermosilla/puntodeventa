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
            panelHeader = new Panel();
            labelTotal = new Label();
            labelTitle = new Label();
            panel1 = new Panel();
            btnGuardar = new Button();
            lblNuevoGasto = new Label();
            labelFormaPago = new Label();
            comboSubCategoria = new ComboBox();
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
            panelHeader.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtValor).BeginInit();
            panelGrid.SuspendLayout();
            panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvMovimientos).BeginInit();
            panelHeaderGrid.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(26, 32, 40);
            panelHeader.Controls.Add(labelTotal);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1098, 45);
            panelHeader.TabIndex = 0;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotal.BackColor = Color.White;
            labelTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.ForeColor = SystemColors.ActiveCaptionText;
            labelTotal.Location = new Point(925, 5);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(160, 34);
            labelTotal.TabIndex = 13;
            labelTotal.Text = "$ 0.00";
            labelTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ButtonHighlight;
            labelTitle.Location = new Point(3, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(102, 25);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "COMPRAS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 66, 82);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(lblNuevoGasto);
            panel1.Controls.Add(labelFormaPago);
            panel1.Controls.Add(comboSubCategoria);
            panel1.Controls.Add(labelTipoMovimiento);
            panel1.Controls.Add(comboTipoMovimiento);
            panel1.Controls.Add(labelValor);
            panel1.Controls.Add(txtValor);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(labelDescripcion);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 45);
            panel1.Margin = new Padding(3, 3, 8, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 520);
            panel1.TabIndex = 1;
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
            btnGuardar.Location = new Point(75, 244);
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
            labelFormaPago.Size = new Size(86, 19);
            labelFormaPago.TabIndex = 32;
            labelFormaPago.Text = "Forma Pago:";
            // 
            // comboSubCategoria
            // 
            comboSubCategoria.FormattingEnabled = true;
            comboSubCategoria.Location = new Point(108, 160);
            comboSubCategoria.Name = "comboSubCategoria";
            comboSubCategoria.Size = new Size(168, 23);
            comboSubCategoria.TabIndex = 31;
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
            panelGrid.Location = new Point(290, 45);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(808, 520);
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
            panelDataGrid.Size = new Size(806, 392);
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
            dvMovimientos.Size = new Size(806, 392);
            dvMovimientos.TabIndex = 23;
            // 
            // panelHeaderGrid
            // 
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
            btnExportar.Location = new Point(629, 85);
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
            btnBuscar.Location = new Point(511, 85);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(93, 35);
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
            label2.Size = new Size(186, 25);
            label2.TabIndex = 2;
            label2.Text = "REPORTE COMPRAS";
            // 
            // ComprasFormControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            Controls.Add(panelGrid);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            Name = "ComprasFormControl";
            Size = new Size(1098, 565);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
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

        private Panel panelHeader;
        private Label labelTitle;
        private Panel panel1;
        private Label lblNuevoGasto;
        private Label labelFormaPago;
        private ComboBox comboSubCategoria;
        private Label labelTipoMovimiento;
        private ComboBox comboTipoMovimiento;
        private Label labelValor;
        private NumericUpDown txtValor;
        private TextBox txtDescripcion;
        private Label labelDescripcion;
        public Button btnGuardar;
        private Panel panelGrid;
        private Label labelTotal;
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
    }
}
