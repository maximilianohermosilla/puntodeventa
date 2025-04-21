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
            btnEliminar = new Button();
            panelCatalogoProductosControl = new Panel();
            panelDataGrid = new Panel();
            dvCatalogo = new DataGridView();
            labelCategoria = new Label();
            comboCategoria = new ComboBox();
            panelFooter.SuspendLayout();
            panelCatalogoProductosControl.SuspendLayout();
            panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvCatalogo).BeginInit();
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
            panelFooter.Controls.Add(btnEliminar);
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
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnExportar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = SystemColors.ButtonHighlight;
            btnExportar.Image = (Image)resources.GetObject("btnExportar.Image");
            btnExportar.Location = new Point(289, 6);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(136, 35);
            btnExportar.TabIndex = 12;
            btnExportar.Text = "Exportar";
            btnExportar.TextAlign = ContentAlignment.MiddleRight;
            btnExportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(0, 80, 200);
            btnModificar.BackgroundImageLayout = ImageLayout.None;
            btnModificar.FlatAppearance.BorderColor = Color.Silver;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = SystemColors.ButtonHighlight;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.Location = new Point(5, 6);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(136, 35);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(0, 80, 200);
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.FlatAppearance.BorderColor = Color.Silver;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.Location = new Point(147, 6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 35);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            dvCatalogo.CellClick += dvCatalogo_CellContentClick;
            dvCatalogo.CellDoubleClick += dvCatalogo_CellDoubleClick;
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
            panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvCatalogo).EndInit();
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
        public Button btnEliminar;
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
