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
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnBuscar = new Button();
            labelHasta = new Label();
            labelDesde = new Label();
            dateHasta = new DateTimePicker();
            dateDesde = new DateTimePicker();
            labelTitle = new Label();
            panelMain.SuspendLayout();
            panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvMovimientos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(49, 66, 82);
            panelMain.Controls.Add(panelDataGrid);
            panelMain.Controls.Add(chart1);
            panelMain.Controls.Add(btnBuscar);
            panelMain.Controls.Add(labelHasta);
            panelMain.Controls.Add(labelDesde);
            panelMain.Controls.Add(dateHasta);
            panelMain.Controls.Add(dateDesde);
            panelMain.Controls.Add(labelTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1447, 582);
            panelMain.TabIndex = 0;
            // 
            // panelDataGrid
            // 
            panelDataGrid.Controls.Add(labelSinResultados);
            panelDataGrid.Controls.Add(dvMovimientos);
            panelDataGrid.Location = new Point(13, 114);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(978, 455);
            panelDataGrid.TabIndex = 25;
            // 
            // labelSinResultados
            // 
            labelSinResultados.AutoSize = true;
            labelSinResultados.Font = new Font("Segoe UI", 16F);
            labelSinResultados.Location = new Point(125, 175);
            labelSinResultados.Name = "labelSinResultados";
            labelSinResultados.Size = new Size(298, 30);
            labelSinResultados.TabIndex = 24;
            labelSinResultados.Text = "No se encontraron resultados";
            labelSinResultados.Visible = false;
            // 
            // dvMovimientos
            // 
            dvMovimientos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvMovimientos.BackgroundColor = Color.FromArgb(26, 32, 40);
            dvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvMovimientos.Location = new Point(3, 0);
            dvMovimientos.Name = "dvMovimientos";
            dvMovimientos.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dvMovimientos.Size = new Size(975, 455);
            dvMovimientos.TabIndex = 23;
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chart1.Location = new Point(997, 114);
            chart1.Name = "chart1";
            chart1.Size = new Size(438, 455);
            chart1.TabIndex = 24;
            chart1.Text = "chart1";
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
            btnBuscar.Location = new Point(525, 57);
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
            labelHasta.Location = new Point(270, 47);
            labelHasta.Name = "labelHasta";
            labelHasta.Size = new Size(47, 19);
            labelHasta.TabIndex = 21;
            labelHasta.Text = "Hasta:";
            // 
            // labelDesde
            // 
            labelDesde.AutoSize = true;
            labelDesde.Font = new Font("Segoe UI", 10F);
            labelDesde.Location = new Point(13, 47);
            labelDesde.Name = "labelDesde";
            labelDesde.Size = new Size(54, 19);
            labelDesde.TabIndex = 20;
            labelDesde.Text = "Desde: ";
            // 
            // dateHasta
            // 
            dateHasta.Location = new Point(270, 69);
            dateHasta.Name = "dateHasta";
            dateHasta.Size = new Size(227, 23);
            dateHasta.TabIndex = 4;
            // 
            // dateDesde
            // 
            dateDesde.Location = new Point(13, 69);
            dateDesde.Name = "dateDesde";
            dateDesde.Size = new Size(227, 23);
            dateDesde.TabIndex = 3;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ButtonHighlight;
            labelTitle.Location = new Point(13, 12);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(194, 25);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "REPORTE DE VENTAS";
            // 
            // ReporteVentasControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(panelMain);
            Name = "ReporteVentasControl";
            Size = new Size(1447, 582);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelDataGrid.ResumeLayout(false);
            panelDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvMovimientos).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panelDataGrid;
        private Label labelSinResultados;
    }
}
