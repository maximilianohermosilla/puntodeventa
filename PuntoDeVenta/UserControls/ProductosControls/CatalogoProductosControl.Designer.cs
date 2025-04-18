namespace PuntoDeVenta.UserControls.ProductosControls
{
    partial class CatalogoProductosControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoProductosControl));
            labelTitle = new Label();
            panelFooter = new Panel();
            btnExportar = new Button();
            btnModificar = new Button();
            btnActualizar = new Button();
            panelCatalogoProductosControl = new Panel();
            dvCatalogo = new DataGridView();
            labelCategoria = new Label();
            comboCategoria = new ComboBox();
            panelDataGrid = new Panel();
            panelFooter.SuspendLayout();
            panelCatalogoProductosControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvCatalogo).BeginInit();
            panelDataGrid.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ButtonHighlight;
            labelTitle.Location = new Point(5, 3);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(250, 25);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "CATÁLOGO DE PRODUCTOS";
            // 
            // panelFooter
            // 
            panelFooter.BorderStyle = BorderStyle.FixedSingle;
            panelFooter.Controls.Add(btnExportar);
            panelFooter.Controls.Add(btnModificar);
            panelFooter.Controls.Add(btnActualizar);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 533);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1449, 51);
            panelFooter.TabIndex = 17;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(0, 80, 200);
            btnExportar.BackgroundImageLayout = ImageLayout.None;
            btnExportar.FlatAppearance.BorderColor = Color.Silver;
            btnExportar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnExportar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnExportar.FlatStyle = FlatStyle.Popup;
            btnExportar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = SystemColors.ButtonHighlight;
            btnExportar.Image = (Image)resources.GetObject("btnExportar.Image");
            btnExportar.Location = new Point(312, 6);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(136, 35);
            btnExportar.TabIndex = 12;
            btnExportar.Text = "Exportar";
            btnExportar.TextAlign = ContentAlignment.MiddleRight;
            btnExportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(0, 80, 200);
            btnModificar.BackgroundImageLayout = ImageLayout.None;
            btnModificar.FlatAppearance.BorderColor = Color.Silver;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = SystemColors.ButtonHighlight;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.Location = new Point(157, 6);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(136, 35);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(0, 80, 200);
            btnActualizar.BackgroundImageLayout = ImageLayout.None;
            btnActualizar.FlatAppearance.BorderColor = Color.Silver;
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonHighlight;
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.Location = new Point(5, 6);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(136, 35);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleRight;
            btnActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnGuardarProducto_Click;
            // 
            // panelCatalogoProductosControl
            // 
            panelCatalogoProductosControl.BackColor = Color.FromArgb(49, 66, 82);
            panelCatalogoProductosControl.Controls.Add(panelDataGrid);
            panelCatalogoProductosControl.Controls.Add(panelFooter);
            panelCatalogoProductosControl.Controls.Add(labelCategoria);
            panelCatalogoProductosControl.Controls.Add(comboCategoria);
            panelCatalogoProductosControl.Controls.Add(labelTitle);
            panelCatalogoProductosControl.Dock = DockStyle.Fill;
            panelCatalogoProductosControl.ForeColor = SystemColors.ButtonHighlight;
            panelCatalogoProductosControl.Location = new Point(0, 0);
            panelCatalogoProductosControl.Name = "panelCatalogoProductosControl";
            panelCatalogoProductosControl.Size = new Size(1449, 584);
            panelCatalogoProductosControl.TabIndex = 18;
            // 
            // dvCatalogo
            // 
            dvCatalogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvCatalogo.BackgroundColor = Color.FromArgb(26, 32, 40);
            dvCatalogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvCatalogo.Location = new Point(0, 0);
            dvCatalogo.Name = "dvCatalogo";
            dvCatalogo.Size = new Size(1446, 434);
            dvCatalogo.TabIndex = 18;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Segoe UI", 10F);
            labelCategoria.Location = new Point(6, 46);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(71, 19);
            labelCategoria.TabIndex = 14;
            labelCategoria.Text = "Categoría:";
            // 
            // comboCategoria
            // 
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(5, 68);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(250, 23);
            comboCategoria.TabIndex = 13;
            comboCategoria.SelectedIndexChanged += comboCategoria_SelectedIndexChanged;
            // 
            // panelDataGrid
            // 
            panelDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDataGrid.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelDataGrid.Controls.Add(dvCatalogo);
            panelDataGrid.ForeColor = SystemColors.ActiveCaptionText;
            panelDataGrid.Location = new Point(0, 97);
            panelDataGrid.Name = "panelDataGrid";
            panelDataGrid.Size = new Size(1449, 437);
            panelDataGrid.TabIndex = 19;
            // 
            // CatalogoProductosControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelCatalogoProductosControl);
            Name = "CatalogoProductosControl";
            Size = new Size(1449, 584);
            panelFooter.ResumeLayout(false);
            panelCatalogoProductosControl.ResumeLayout(false);
            panelCatalogoProductosControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvCatalogo).EndInit();
            panelDataGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Panel panelFooter;
        private Panel panelCatalogoProductosControl;
        private TextBox txtDescripcion;
        private Label labelDescripcion;
        private TextBox txtCodigo;
        private Label labelCodigo;
        private Label labelPrecioMayor;
        private NumericUpDown txtPrecioMayor;
        private Label labelPrecioVenta;
        private NumericUpDown txtPrecioVenta;
        private Label labelPrecioCosto;
        private NumericUpDown txtPrecioCosto;
        public Button btnActualizar;
        private Label labelCategoria;
        private ComboBox comboCategoria;
        public Button btnModificar;
        public Button btnExportar;
        private DataGridView dvCatalogo;
        private Label labelCantidadMinima;
        private NumericUpDown txtCantidadMinima;
        private Label labelCantidadActual;
        private NumericUpDown txtCantidadActual;
        private Label labelInventario;
        private CheckBox checkInventario;
        private Panel panelDataGrid;
    }
}
