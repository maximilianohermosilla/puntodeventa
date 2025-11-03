namespace PuntoDeVenta.UserControls.ReportesControls
{
    partial class ReporteVentasControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteVentasControl));
            panelMain = new Panel();
            panelDataGrid = new Panel();
            labelSinResultados = new Label();
            dvMovimientos = new DataGridView();
            panelHeader = new Panel();
            linkLabelMes = new LinkLabel();
            linkLabelSemana = new LinkLabel();
            linkLabelHoy = new LinkLabel();
            labelTotal = new Label();
            btnExportar = new Button();
            btnBuscar = new Button();
            labelHasta = new Label();
            labelDesde = new Label();
            dateHasta = new DateTimePicker();
            dateDesde = new DateTimePicker();
            labelTitle = new Label();
            panelCharts = new Panel();
            chartDias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartCategorias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelMain.SuspendLayout();
            panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvMovimientos).BeginInit();
            panelHeader.SuspendLayout();
            panelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartProductos).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(49, 66, 82);
            panelMain.Controls.Add(panelDataGrid);
            panelMain.Controls.Add(panelHeader);
            panelMain.Controls.Add(panelCharts);
            panelMain.Dock = DockStyle.Fill;
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1447, 800);
            panelMain.TabIndex = 0;
            // 
            // panelDataGrid
            // 
            panelDataGrid.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelDataGrid.Controls.Add(labelSinResultados);
            panelDataGrid.Controls.Add(dvMovimientos);
            panelDataGrid.Dock = DockStyle.Top;
            panelDataGrid.Location = new Point(0, 126);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(1447, 251);
            panelDataGrid.TabIndex = 25;
            // 
            // labelSinResultados
            // 
            labelSinResultados.AutoSize = true;
            labelSinResultados.Font = new Font("Segoe UI", 16F);
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
            dvMovimientos.Size = new Size(1447, 251);
            dvMovimientos.TabIndex = 23;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(linkLabelMes);
            panelHeader.Controls.Add(linkLabelSemana);
            panelHeader.Controls.Add(linkLabelHoy);
            panelHeader.Controls.Add(labelTotal);
            panelHeader.Controls.Add(btnExportar);
            panelHeader.Controls.Add(btnBuscar);
            panelHeader.Controls.Add(labelHasta);
            panelHeader.Controls.Add(labelDesde);
            panelHeader.Controls.Add(dateHasta);
            panelHeader.Controls.Add(dateDesde);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1447, 126);
            panelHeader.TabIndex = 28;
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
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.ForeColor = SystemColors.ButtonHighlight;
            labelTotal.Location = new Point(1256, 87);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(97, 25);
            labelTotal.TabIndex = 24;
            labelTotal.Text = "TOTAL: $0";
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
            btnExportar.Location = new Point(623, 85);
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
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ButtonHighlight;
            labelTitle.Location = new Point(10, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(194, 25);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "REPORTE DE VENTAS";
            // 
            // panelCharts
            // 
            panelCharts.Controls.Add(chartDias);
            panelCharts.Controls.Add(chartCategorias);
            panelCharts.Controls.Add(chartProductos);
            panelCharts.Dock = DockStyle.Fill;
            panelCharts.Location = new Point(0, 0);
            panelCharts.Name = "panelCharts";
            panelCharts.Size = new Size(1447, 800);
            panelCharts.TabIndex = 27;
            // 
            // chartDias
            // 
            chartDias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            chartDias.Location = new Point(948, 375);
            chartDias.Name = "chartDias";
            chartDias.Size = new Size(496, 412);
            chartDias.TabIndex = 27;
            chartDias.Text = "chart2";
            // 
            // chartCategorias
            // 
            chartCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartCategorias.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipXY;
            chartCategorias.Location = new Point(450, 383);
            chartCategorias.Name = "chartCategorias";
            chartCategorias.Size = new Size(472, 404);
            chartCategorias.TabIndex = 24;
            chartCategorias.Text = "chart1";
            // 
            // chartProductos
            // 
            chartProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            chartProductos.Location = new Point(6, 383);
            chartProductos.Name = "chartProductos";
            chartProductos.Size = new Size(415, 404);
            chartProductos.TabIndex = 26;
            chartProductos.Text = "chart2";
            // 
            // ReporteVentasControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panelMain);
            Name = "ReporteVentasControl";
            Size = new Size(1447, 800);
            panelMain.ResumeLayout(false);
            panelDataGrid.ResumeLayout(false);
            panelDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvMovimientos).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDias).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Label labelTitle;
        private DateTimePicker dateHasta;
        private DateTimePicker dateDesde;
        private Label labelHasta;
        private Label labelDesde;
        private DataGridView dvMovimientos;
        public Button btnBuscar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategorias;
        private Panel panelDataGrid;
        private Label labelSinResultados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductos;
        private Panel panelCharts;
        private Panel panelHeader;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDias;
        public Button btnExportar;
        private Label labelTotal;
        private LinkLabel linkLabelHoy;
        private LinkLabel linkLabelMes;
        private LinkLabel linkLabelSemana;
    }
}
