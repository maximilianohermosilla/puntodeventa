using System.Windows.Forms;

namespace PuntoDeVenta.UserControls.ProductosControls
{
    partial class CategoriaProductoControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaProductoControl));
            labelTitle = new Label();
            panelNavbar = new Panel();
            txtBuscar = new TextBox();
            btnGuardar = new Button();
            panelCategoriaProducto = new Panel();
            panelMain = new Panel();
            panelSubCategoria = new Panel();
            labelSubCategoria = new Label();
            panelAsideSubCategoria = new Panel();
            listSubCategorias = new ListBox();
            panelFooterSubCategoria = new Panel();
            btnEliminarSubCategoria = new Button();
            btnNuevaSubCategoria = new Button();
            txtBuscarSubCategoria = new TextBox();
            label1 = new Label();
            labelDescripcionSubCategoria = new Label();
            comboCategoria = new ComboBox();
            txtDescripcionSubCategoria = new TextBox();
            checkHabilitadoSubCategoria = new CheckBox();
            btnGuardarSubCategoria = new Button();
            panelPrincipal = new Panel();
            labelCategoria = new Label();
            panelAside = new Panel();
            panel1 = new Panel();
            listCategorias = new ListBox();
            panelFooterCategoria = new Panel();
            btnEliminarCategoria = new Button();
            btnNuevaCategoria = new Button();
            checkHabilitado = new CheckBox();
            txtDescripcion = new TextBox();
            labelDescripcion = new Label();
            panelNavbar.SuspendLayout();
            panelCategoriaProducto.SuspendLayout();
            panelMain.SuspendLayout();
            panelSubCategoria.SuspendLayout();
            panelAsideSubCategoria.SuspendLayout();
            panelFooterSubCategoria.SuspendLayout();
            panelPrincipal.SuspendLayout();
            panelAside.SuspendLayout();
            panel1.SuspendLayout();
            panelFooterCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ButtonHighlight;
            labelTitle.Location = new Point(3, 0);
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
            txtBuscar.Location = new Point(18, 0);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar...";
            txtBuscar.Size = new Size(280, 23);
            txtBuscar.TabIndex = 7;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
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
            btnGuardar.Location = new Point(350, 141);
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
            panelCategoriaProducto.Size = new Size(1449, 800);
            panelCategoriaProducto.TabIndex = 18;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelMain.BackColor = Color.FromArgb(49, 66, 82);
            panelMain.Controls.Add(panelSubCategoria);
            panelMain.Controls.Add(panelPrincipal);
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Location = new Point(0, 29);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1449, 771);
            panelMain.TabIndex = 22;
            // 
            // panelSubCategoria
            // 
            panelSubCategoria.Controls.Add(labelSubCategoria);
            panelSubCategoria.Controls.Add(panelAsideSubCategoria);
            panelSubCategoria.Controls.Add(label1);
            panelSubCategoria.Controls.Add(labelDescripcionSubCategoria);
            panelSubCategoria.Controls.Add(comboCategoria);
            panelSubCategoria.Controls.Add(txtDescripcionSubCategoria);
            panelSubCategoria.Controls.Add(checkHabilitadoSubCategoria);
            panelSubCategoria.Controls.Add(btnGuardarSubCategoria);
            panelSubCategoria.Dock = DockStyle.Bottom;
            panelSubCategoria.Location = new Point(0, 471);
            panelSubCategoria.Name = "panelSubCategoria";
            panelSubCategoria.Size = new Size(1449, 300);
            panelSubCategoria.TabIndex = 27;
            // 
            // labelSubCategoria
            // 
            labelSubCategoria.AutoSize = true;
            labelSubCategoria.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSubCategoria.ForeColor = SystemColors.ButtonHighlight;
            labelSubCategoria.Location = new Point(347, 11);
            labelSubCategoria.Name = "labelSubCategoria";
            labelSubCategoria.Size = new Size(188, 25);
            labelSubCategoria.TabIndex = 22;
            labelSubCategoria.Text = "Nueva SubCategoría";
            // 
            // panelAsideSubCategoria
            // 
            panelAsideSubCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelAsideSubCategoria.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelAsideSubCategoria.BackColor = Color.FromArgb(29, 32, 40);
            panelAsideSubCategoria.Controls.Add(listSubCategorias);
            panelAsideSubCategoria.Controls.Add(panelFooterSubCategoria);
            panelAsideSubCategoria.Controls.Add(txtBuscarSubCategoria);
            panelAsideSubCategoria.ForeColor = SystemColors.ButtonHighlight;
            panelAsideSubCategoria.Location = new Point(3, 11);
            panelAsideSubCategoria.Name = "panelAsideSubCategoria";
            panelAsideSubCategoria.Size = new Size(326, 286);
            panelAsideSubCategoria.TabIndex = 23;
            // 
            // listSubCategorias
            // 
            listSubCategorias.FormattingEnabled = true;
            listSubCategorias.ItemHeight = 15;
            listSubCategorias.Location = new Point(20, 53);
            listSubCategorias.Name = "listSubCategorias";
            listSubCategorias.Size = new Size(277, 169);
            listSubCategorias.TabIndex = 23;
            // 
            // panelFooterSubCategoria
            // 
            panelFooterSubCategoria.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFooterSubCategoria.Controls.Add(btnEliminarSubCategoria);
            panelFooterSubCategoria.Controls.Add(btnNuevaSubCategoria);
            panelFooterSubCategoria.Dock = DockStyle.Bottom;
            panelFooterSubCategoria.Location = new Point(0, 238);
            panelFooterSubCategoria.Name = "panelFooterSubCategoria";
            panelFooterSubCategoria.Size = new Size(326, 48);
            panelFooterSubCategoria.TabIndex = 22;
            // 
            // btnEliminarSubCategoria
            // 
            btnEliminarSubCategoria.BackColor = Color.FromArgb(0, 80, 200);
            btnEliminarSubCategoria.BackgroundImageLayout = ImageLayout.None;
            btnEliminarSubCategoria.FlatAppearance.BorderColor = Color.Silver;
            btnEliminarSubCategoria.FlatAppearance.BorderSize = 0;
            btnEliminarSubCategoria.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnEliminarSubCategoria.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnEliminarSubCategoria.FlatStyle = FlatStyle.Flat;
            btnEliminarSubCategoria.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarSubCategoria.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarSubCategoria.Image = (Image)resources.GetObject("btnEliminarSubCategoria.Image");
            btnEliminarSubCategoria.Location = new Point(168, 0);
            btnEliminarSubCategoria.Name = "btnEliminarSubCategoria";
            btnEliminarSubCategoria.Size = new Size(130, 35);
            btnEliminarSubCategoria.TabIndex = 21;
            btnEliminarSubCategoria.Text = "Eliminar";
            btnEliminarSubCategoria.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarSubCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarSubCategoria.UseVisualStyleBackColor = false;
            btnEliminarSubCategoria.Click += btnEliminarSubCategoria_Click;
            // 
            // btnNuevaSubCategoria
            // 
            btnNuevaSubCategoria.BackColor = Color.FromArgb(0, 80, 200);
            btnNuevaSubCategoria.BackgroundImageLayout = ImageLayout.None;
            btnNuevaSubCategoria.FlatAppearance.BorderColor = Color.Silver;
            btnNuevaSubCategoria.FlatAppearance.BorderSize = 0;
            btnNuevaSubCategoria.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnNuevaSubCategoria.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnNuevaSubCategoria.FlatStyle = FlatStyle.Flat;
            btnNuevaSubCategoria.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaSubCategoria.ForeColor = SystemColors.ButtonHighlight;
            btnNuevaSubCategoria.Image = (Image)resources.GetObject("btnNuevaSubCategoria.Image");
            btnNuevaSubCategoria.Location = new Point(20, 0);
            btnNuevaSubCategoria.Name = "btnNuevaSubCategoria";
            btnNuevaSubCategoria.Size = new Size(127, 35);
            btnNuevaSubCategoria.TabIndex = 20;
            btnNuevaSubCategoria.Text = "Nuevo";
            btnNuevaSubCategoria.TextAlign = ContentAlignment.MiddleRight;
            btnNuevaSubCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevaSubCategoria.UseVisualStyleBackColor = false;
            btnNuevaSubCategoria.Click += btnNuevaSubCategoria_Click;
            // 
            // txtBuscarSubCategoria
            // 
            txtBuscarSubCategoria.Location = new Point(18, 17);
            txtBuscarSubCategoria.Name = "txtBuscarSubCategoria";
            txtBuscarSubCategoria.PlaceholderText = "Buscar...";
            txtBuscarSubCategoria.Size = new Size(280, 23);
            txtBuscarSubCategoria.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(350, 101);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 26;
            label1.Text = "Categoría:";
            // 
            // labelDescripcionSubCategoria
            // 
            labelDescripcionSubCategoria.AutoSize = true;
            labelDescripcionSubCategoria.Font = new Font("Segoe UI", 10F);
            labelDescripcionSubCategoria.Location = new Point(350, 61);
            labelDescripcionSubCategoria.Name = "labelDescripcionSubCategoria";
            labelDescripcionSubCategoria.Size = new Size(86, 19);
            labelDescripcionSubCategoria.TabIndex = 20;
            labelDescripcionSubCategoria.Text = "Descripción: ";
            // 
            // comboCategoria
            // 
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(470, 100);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(308, 23);
            comboCategoria.TabIndex = 25;
            // 
            // txtDescripcionSubCategoria
            // 
            txtDescripcionSubCategoria.Location = new Point(470, 60);
            txtDescripcionSubCategoria.Name = "txtDescripcionSubCategoria";
            txtDescripcionSubCategoria.Size = new Size(309, 23);
            txtDescripcionSubCategoria.TabIndex = 21;
            // 
            // checkHabilitadoSubCategoria
            // 
            checkHabilitadoSubCategoria.AutoSize = true;
            checkHabilitadoSubCategoria.CheckAlign = ContentAlignment.MiddleRight;
            checkHabilitadoSubCategoria.Checked = true;
            checkHabilitadoSubCategoria.CheckState = CheckState.Checked;
            checkHabilitadoSubCategoria.Font = new Font("Segoe UI", 10F);
            checkHabilitadoSubCategoria.Location = new Point(350, 142);
            checkHabilitadoSubCategoria.Name = "checkHabilitadoSubCategoria";
            checkHabilitadoSubCategoria.Size = new Size(133, 23);
            checkHabilitadoSubCategoria.TabIndex = 24;
            checkHabilitadoSubCategoria.Text = "Habilitado:          ";
            checkHabilitadoSubCategoria.UseVisualStyleBackColor = true;
            // 
            // btnGuardarSubCategoria
            // 
            btnGuardarSubCategoria.BackColor = Color.FromArgb(0, 80, 200);
            btnGuardarSubCategoria.BackgroundImageLayout = ImageLayout.None;
            btnGuardarSubCategoria.FlatAppearance.BorderColor = Color.Silver;
            btnGuardarSubCategoria.FlatAppearance.BorderSize = 0;
            btnGuardarSubCategoria.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnGuardarSubCategoria.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnGuardarSubCategoria.FlatStyle = FlatStyle.Flat;
            btnGuardarSubCategoria.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarSubCategoria.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarSubCategoria.Image = (Image)resources.GetObject("btnGuardarSubCategoria.Image");
            btnGuardarSubCategoria.Location = new Point(350, 188);
            btnGuardarSubCategoria.Name = "btnGuardarSubCategoria";
            btnGuardarSubCategoria.Size = new Size(136, 35);
            btnGuardarSubCategoria.TabIndex = 23;
            btnGuardarSubCategoria.Text = "Guardar";
            btnGuardarSubCategoria.TextAlign = ContentAlignment.MiddleRight;
            btnGuardarSubCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarSubCategoria.UseVisualStyleBackColor = false;
            btnGuardarSubCategoria.Click += btnGuardarSubCategoria_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelPrincipal.BackColor = Color.FromArgb(49, 66, 82);
            panelPrincipal.Controls.Add(labelCategoria);
            panelPrincipal.Controls.Add(panelAside);
            panelPrincipal.Controls.Add(btnGuardar);
            panelPrincipal.Controls.Add(checkHabilitado);
            panelPrincipal.Controls.Add(txtDescripcion);
            panelPrincipal.Controls.Add(labelDescripcion);
            panelPrincipal.Dock = DockStyle.Top;
            panelPrincipal.ForeColor = SystemColors.ButtonHighlight;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1449, 465);
            panelPrincipal.TabIndex = 20;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCategoria.ForeColor = SystemColors.ButtonHighlight;
            labelCategoria.Location = new Point(350, 10);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(181, 25);
            labelCategoria.TabIndex = 8;
            labelCategoria.Text = "NUEVA CATEGORIA";
            // 
            // panelAside
            // 
            panelAside.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelAside.BackColor = Color.FromArgb(29, 32, 40);
            panelAside.Controls.Add(panel1);
            panelAside.Controls.Add(panelFooterCategoria);
            panelAside.ForeColor = SystemColors.ButtonHighlight;
            panelAside.Location = new Point(3, 15);
            panelAside.Name = "panelAside";
            panelAside.Size = new Size(326, 352);
            panelAside.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(listCategorias);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 291);
            panel1.TabIndex = 23;
            // 
            // listCategorias
            // 
            listCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listCategorias.FormattingEnabled = true;
            listCategorias.ItemHeight = 15;
            listCategorias.Location = new Point(20, 37);
            listCategorias.Name = "listCategorias";
            listCategorias.Size = new Size(280, 244);
            listCategorias.TabIndex = 8;
            listCategorias.SelectedIndexChanged += listCategorias_SelectedIndexChanged;
            // 
            // panelFooterCategoria
            // 
            panelFooterCategoria.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFooterCategoria.Controls.Add(btnEliminarCategoria);
            panelFooterCategoria.Controls.Add(btnNuevaCategoria);
            panelFooterCategoria.Dock = DockStyle.Bottom;
            panelFooterCategoria.Location = new Point(0, 304);
            panelFooterCategoria.Name = "panelFooterCategoria";
            panelFooterCategoria.Size = new Size(326, 48);
            panelFooterCategoria.TabIndex = 22;
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.BackColor = Color.FromArgb(0, 80, 200);
            btnEliminarCategoria.BackgroundImageLayout = ImageLayout.None;
            btnEliminarCategoria.FlatAppearance.BorderColor = Color.Silver;
            btnEliminarCategoria.FlatAppearance.BorderSize = 0;
            btnEliminarCategoria.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnEliminarCategoria.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnEliminarCategoria.FlatStyle = FlatStyle.Flat;
            btnEliminarCategoria.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarCategoria.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarCategoria.Image = (Image)resources.GetObject("btnEliminarCategoria.Image");
            btnEliminarCategoria.Location = new Point(168, 0);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(130, 35);
            btnEliminarCategoria.TabIndex = 21;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarCategoria.UseVisualStyleBackColor = false;
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // btnNuevaCategoria
            // 
            btnNuevaCategoria.BackColor = Color.FromArgb(0, 80, 200);
            btnNuevaCategoria.BackgroundImageLayout = ImageLayout.None;
            btnNuevaCategoria.FlatAppearance.BorderColor = Color.Silver;
            btnNuevaCategoria.FlatAppearance.BorderSize = 0;
            btnNuevaCategoria.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnNuevaCategoria.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnNuevaCategoria.FlatStyle = FlatStyle.Flat;
            btnNuevaCategoria.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaCategoria.ForeColor = SystemColors.ButtonHighlight;
            btnNuevaCategoria.Image = (Image)resources.GetObject("btnNuevaCategoria.Image");
            btnNuevaCategoria.Location = new Point(20, 0);
            btnNuevaCategoria.Name = "btnNuevaCategoria";
            btnNuevaCategoria.Size = new Size(127, 35);
            btnNuevaCategoria.TabIndex = 20;
            btnNuevaCategoria.Text = "Nuevo";
            btnNuevaCategoria.TextAlign = ContentAlignment.MiddleRight;
            btnNuevaCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevaCategoria.UseVisualStyleBackColor = false;
            btnNuevaCategoria.Click += btnNuevaCategoria_Click;
            // 
            // checkHabilitado
            // 
            checkHabilitado.AutoSize = true;
            checkHabilitado.CheckAlign = ContentAlignment.MiddleRight;
            checkHabilitado.Checked = true;
            checkHabilitado.CheckState = CheckState.Checked;
            checkHabilitado.Font = new Font("Segoe UI", 10F);
            checkHabilitado.Location = new Point(350, 98);
            checkHabilitado.Name = "checkHabilitado";
            checkHabilitado.Size = new Size(133, 23);
            checkHabilitado.TabIndex = 19;
            checkHabilitado.Text = "Habilitado:          ";
            checkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(472, 59);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(309, 23);
            txtDescripcion.TabIndex = 6;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Segoe UI", 10F);
            labelDescripcion.Location = new Point(350, 60);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(86, 19);
            labelDescripcion.TabIndex = 5;
            labelDescripcion.Text = "Descripción: ";
            // 
            // CategoriaProductoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelCategoriaProducto);
            Name = "CategoriaProductoControl";
            Size = new Size(1449, 800);
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            panelCategoriaProducto.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelSubCategoria.ResumeLayout(false);
            panelSubCategoria.PerformLayout();
            panelAsideSubCategoria.ResumeLayout(false);
            panelAsideSubCategoria.PerformLayout();
            panelFooterSubCategoria.ResumeLayout(false);
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            panelAside.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelFooterCategoria.ResumeLayout(false);
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
        public Button btnNuevaCategoria;
        public Button btnEliminarCategoria;
        private Panel panelFooterCategoria;
        private Label labelSubCategoria;
        public Button btnGuardarSubCategoria;
        private CheckBox checkHabilitadoSubCategoria;
        private TextBox txtDescripcionSubCategoria;
        private Label labelDescripcionSubCategoria;
        private Panel panelAsideSubCategoria;
        private Panel panelFooterSubCategoria;
        public Button btnEliminarSubCategoria;
        public Button btnNuevaSubCategoria;
        private TextBox txtBuscarSubCategoria;
        private Label label1;
        private Panel panelSubCategoria;
        private Panel panel1;
        private ListBox listSubCategorias;
    }
}
