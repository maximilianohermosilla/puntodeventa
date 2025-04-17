namespace PuntoDeVenta.UserControls.ProductosControls
{
    partial class CategoriaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaProducto));
            labelTitle = new Label();
            panelNavbar = new Panel();
            txtBuscar = new TextBox();
            btnGuardar = new Button();
            panelCategoriaProducto = new Panel();
            panelMain = new Panel();
            panelPrincipal = new Panel();
            labelCategoria = new Label();
            checkHabilitado = new CheckBox();
            txtDescripcion = new TextBox();
            labelDescripcion = new Label();
            panelAside = new Panel();
            listCategorias = new ListBox();
            panelNavbar.SuspendLayout();
            panelCategoriaProducto.SuspendLayout();
            panelMain.SuspendLayout();
            panelPrincipal.SuspendLayout();
            panelAside.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ButtonHighlight;
            labelTitle.Location = new Point(3, 6);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(218, 25);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "CATEGORIA PRODUCTO";
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.Controls.Add(labelTitle);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1449, 38);
            panelNavbar.TabIndex = 17;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(18, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar...";
            txtBuscar.Size = new Size(279, 23);
            txtBuscar.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 80, 200);
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.FlatAppearance.BorderColor = Color.Silver;
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new Point(16, 142);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(136, 35);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardarProducto_Click;
            // 
            // panelCategoriaProducto
            // 
            panelCategoriaProducto.BackColor = Color.FromArgb(49, 66, 82);
            panelCategoriaProducto.Controls.Add(panelNavbar);
            panelCategoriaProducto.Controls.Add(panelMain);
            panelCategoriaProducto.Dock = DockStyle.Fill;
            panelCategoriaProducto.ForeColor = SystemColors.ButtonHighlight;
            panelCategoriaProducto.Location = new Point(0, 0);
            panelCategoriaProducto.Name = "panelCategoriaProducto";
            panelCategoriaProducto.Size = new Size(1449, 584);
            panelCategoriaProducto.TabIndex = 18;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelMain.BackColor = Color.FromArgb(49, 66, 82);
            panelMain.Controls.Add(panelPrincipal);
            panelMain.Controls.Add(panelAside);
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Location = new Point(0, 29);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1449, 555);
            panelMain.TabIndex = 22;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelPrincipal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelPrincipal.BackColor = Color.FromArgb(49, 66, 82);
            panelPrincipal.Controls.Add(labelCategoria);
            panelPrincipal.Controls.Add(btnGuardar);
            panelPrincipal.Controls.Add(checkHabilitado);
            panelPrincipal.Controls.Add(txtDescripcion);
            panelPrincipal.Controls.Add(labelDescripcion);
            panelPrincipal.ForeColor = SystemColors.ButtonHighlight;
            panelPrincipal.Location = new Point(351, 5);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1098, 533);
            panelPrincipal.TabIndex = 20;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategoria.ForeColor = SystemColors.ButtonHighlight;
            labelCategoria.Location = new Point(15, 12);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(181, 25);
            labelCategoria.TabIndex = 8;
            labelCategoria.Text = "NUEVA CATEGORIA";
            // 
            // checkHabilitado
            // 
            checkHabilitado.AutoSize = true;
            checkHabilitado.CheckAlign = ContentAlignment.MiddleRight;
            checkHabilitado.Checked = true;
            checkHabilitado.CheckState = CheckState.Checked;
            checkHabilitado.Font = new Font("Segoe UI", 10F);
            checkHabilitado.Location = new Point(16, 96);
            checkHabilitado.Name = "checkHabilitado";
            checkHabilitado.Size = new Size(133, 23);
            checkHabilitado.TabIndex = 19;
            checkHabilitado.Text = "Habilitado:          ";
            checkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(138, 61);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(309, 23);
            txtDescripcion.TabIndex = 6;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Segoe UI", 10F);
            labelDescripcion.Location = new Point(15, 62);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(86, 19);
            labelDescripcion.TabIndex = 5;
            labelDescripcion.Text = "Descripción: ";
            // 
            // panelAside
            // 
            panelAside.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelAside.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelAside.BackColor = Color.FromArgb(29, 32, 40);
            panelAside.Controls.Add(listCategorias);
            panelAside.Controls.Add(txtBuscar);
            panelAside.ForeColor = SystemColors.ButtonHighlight;
            panelAside.Location = new Point(19, 5);
            panelAside.Name = "panelAside";
            panelAside.Size = new Size(326, 533);
            panelAside.TabIndex = 21;
            // 
            // listCategorias
            // 
            listCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listCategorias.FormattingEnabled = true;
            listCategorias.ItemHeight = 15;
            listCategorias.Location = new Point(20, 55);
            listCategorias.Name = "listCategorias";
            listCategorias.Size = new Size(278, 454);
            listCategorias.TabIndex = 8;
            // 
            // CategoriaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelCategoriaProducto);
            Name = "CategoriaProducto";
            Size = new Size(1449, 584);
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            panelCategoriaProducto.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            panelAside.ResumeLayout(false);
            panelAside.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Panel panelNavbar;
        private Panel panelCategoriaProducto;
        private TextBox txtDescripcion;
        private Label labelDescripcion;
        private Label labelCategoria;
        private ComboBox comboCategoria;
        private Label labelPrecioMayor;
        private NumericUpDown txtPrecioMayor;
        private Label labelPrecioVenta;
        private NumericUpDown txtPrecioVenta;
        public Button btnGuardar;
        private CheckBox checkHabilitado;
        private Label labelCantidadMinima;
        private NumericUpDown txtCantidadMinima;
        private Label labelCantidadActual;
        private NumericUpDown txtCantidadActual;
        private Label labelInventario;
        private TextBox txtBuscar;
        private Panel panelAside;
        private Panel panelPrincipal;
        private Panel panelMain;
        private ListBox listCategorias;
    }
}
