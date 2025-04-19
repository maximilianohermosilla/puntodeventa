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
            panelPrincipal = new Panel();
            labelCategoria = new Label();
            checkHabilitado = new CheckBox();
            txtDescripcion = new TextBox();
            labelDescripcion = new Label();
            panelAside = new Panel();
            panel1 = new Panel();
            btnEliminarCategoria = new Button();
            btnNuevaCategoria = new Button();
            listCategorias = new ListBox();
            panelNavbar.SuspendLayout();
            panelCategoriaProducto.SuspendLayout();
            panelMain.SuspendLayout();
            panelPrincipal.SuspendLayout();
            panelAside.SuspendLayout();
            panel1.SuspendLayout();
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
            txtBuscar.Location = new Point(18, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar...";
            txtBuscar.Size = new Size(280, 23);
            txtBuscar.TabIndex = 7;
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
            panelAside.Controls.Add(panel1);
            panelAside.Controls.Add(listCategorias);
            panelAside.Controls.Add(txtBuscar);
            panelAside.ForeColor = SystemColors.ButtonHighlight;
            panelAside.Location = new Point(19, 5);
            panelAside.Name = "panelAside";
            panelAside.Size = new Size(326, 533);
            panelAside.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(btnEliminarCategoria);
            panel1.Controls.Add(btnNuevaCategoria);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 485);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 48);
            panel1.TabIndex = 22;
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
            // listCategorias
            // 
            listCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listCategorias.FormattingEnabled = true;
            listCategorias.ItemHeight = 15;
            listCategorias.Location = new Point(20, 55);
            listCategorias.Name = "listCategorias";
            listCategorias.Size = new Size(278, 424);
            listCategorias.TabIndex = 8;
            listCategorias.SelectedIndexChanged += listCategorias_SelectedIndexChanged;
            // 
            // CategoriaProductoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelCategoriaProducto);
            Name = "CategoriaProductoControl";
            Size = new Size(1449, 584);
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            panelCategoriaProducto.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            panelAside.ResumeLayout(false);
            panelAside.PerformLayout();
            panel1.ResumeLayout(false);
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
        private Panel panel1;
    }
}
