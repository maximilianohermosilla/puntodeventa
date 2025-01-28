namespace PuntoDeVenta.UserControls
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            panelHeader = new Panel();
            ventasTitle = new Label();
            panelNavbar = new Panel();
            btnVarios = new Button();
            btnComun = new Button();
            btnBuscar = new Button();
            btnEntradas = new Button();
            btnVerificador = new Button();
            btnSalidas = new Button();
            btnAsignarCliente = new Button();
            labelTitle = new Label();
            panelFooter = new Panel();
            btnGuardarProducto = new Button();
            panel1 = new Panel();
            labelInventario = new Label();
            checkInventario = new CheckBox();
            labelCantidadMinima = new Label();
            txtCantidadMinima = new NumericUpDown();
            labelCantidadActual = new Label();
            txtCantidadActual = new NumericUpDown();
            labelCategoria = new Label();
            comboCategoria = new ComboBox();
            labelPrecioMayor = new Label();
            txtPrecioMayor = new NumericUpDown();
            labelPrecioVenta = new Label();
            txtPrecioVenta = new NumericUpDown();
            labelPrecioCosto = new Label();
            txtPrecioCosto = new NumericUpDown();
            txtDescripcion = new TextBox();
            labelDescripcion = new Label();
            txtCodigo = new TextBox();
            labelCodigo = new Label();
            panelHeader.SuspendLayout();
            panelNavbar.SuspendLayout();
            panelFooter.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidadMinima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidadActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioMayor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioCosto).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(ventasTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1449, 28);
            panelHeader.TabIndex = 1;
            // 
            // ventasTitle
            // 
            ventasTitle.AutoSize = true;
            ventasTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ventasTitle.ForeColor = SystemColors.ButtonHighlight;
            ventasTitle.Location = new Point(3, 0);
            ventasTitle.Name = "ventasTitle";
            ventasTitle.Size = new Size(121, 25);
            ventasTitle.TabIndex = 0;
            ventasTitle.Text = "PRODUCTOS";
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(btnVarios);
            panelNavbar.Controls.Add(btnComun);
            panelNavbar.Controls.Add(btnBuscar);
            panelNavbar.Controls.Add(btnEntradas);
            panelNavbar.Controls.Add(btnVerificador);
            panelNavbar.Controls.Add(btnSalidas);
            panelNavbar.Controls.Add(btnAsignarCliente);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(0, 28);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1449, 48);
            panelNavbar.TabIndex = 16;
            // 
            // btnVarios
            // 
            btnVarios.BackColor = SystemColors.ButtonHighlight;
            btnVarios.BackgroundImageLayout = ImageLayout.None;
            btnVarios.FlatAppearance.BorderColor = Color.Black;
            btnVarios.FlatAppearance.BorderSize = 0;
            btnVarios.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVarios.Image = (Image)resources.GetObject("btnVarios.Image");
            btnVarios.Location = new Point(3, 5);
            btnVarios.Name = "btnVarios";
            btnVarios.Size = new Size(122, 35);
            btnVarios.TabIndex = 3;
            btnVarios.Text = "F1 Ventas";
            btnVarios.TextAlign = ContentAlignment.MiddleRight;
            btnVarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVarios.UseVisualStyleBackColor = false;
            // 
            // btnComun
            // 
            btnComun.BackColor = SystemColors.ButtonHighlight;
            btnComun.BackgroundImageLayout = ImageLayout.None;
            btnComun.FlatAppearance.BorderColor = Color.Black;
            btnComun.FlatAppearance.BorderSize = 0;
            btnComun.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComun.Image = (Image)resources.GetObject("btnComun.Image");
            btnComun.Location = new Point(131, 5);
            btnComun.Name = "btnComun";
            btnComun.Size = new Size(122, 35);
            btnComun.TabIndex = 4;
            btnComun.Text = "F1 Ventas";
            btnComun.TextAlign = ContentAlignment.MiddleRight;
            btnComun.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComun.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ButtonHighlight;
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.FlatAppearance.BorderColor = Color.Black;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(259, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(122, 35);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "F1 Ventas";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEntradas
            // 
            btnEntradas.BackColor = SystemColors.ButtonHighlight;
            btnEntradas.BackgroundImageLayout = ImageLayout.None;
            btnEntradas.FlatAppearance.BorderColor = Color.Black;
            btnEntradas.FlatAppearance.BorderSize = 0;
            btnEntradas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntradas.Image = (Image)resources.GetObject("btnEntradas.Image");
            btnEntradas.Location = new Point(387, 5);
            btnEntradas.Name = "btnEntradas";
            btnEntradas.Size = new Size(122, 35);
            btnEntradas.TabIndex = 6;
            btnEntradas.Text = "F1 Ventas";
            btnEntradas.TextAlign = ContentAlignment.MiddleRight;
            btnEntradas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEntradas.UseVisualStyleBackColor = false;
            // 
            // btnVerificador
            // 
            btnVerificador.BackColor = SystemColors.ButtonHighlight;
            btnVerificador.BackgroundImageLayout = ImageLayout.None;
            btnVerificador.FlatAppearance.BorderColor = Color.Black;
            btnVerificador.FlatAppearance.BorderSize = 0;
            btnVerificador.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerificador.Image = (Image)resources.GetObject("btnVerificador.Image");
            btnVerificador.Location = new Point(771, 5);
            btnVerificador.Name = "btnVerificador";
            btnVerificador.Size = new Size(122, 35);
            btnVerificador.TabIndex = 9;
            btnVerificador.Text = "F1 Ventas";
            btnVerificador.TextAlign = ContentAlignment.MiddleRight;
            btnVerificador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVerificador.UseVisualStyleBackColor = false;
            // 
            // btnSalidas
            // 
            btnSalidas.BackColor = SystemColors.ButtonHighlight;
            btnSalidas.BackgroundImageLayout = ImageLayout.None;
            btnSalidas.FlatAppearance.BorderColor = Color.Black;
            btnSalidas.FlatAppearance.BorderSize = 0;
            btnSalidas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalidas.Image = (Image)resources.GetObject("btnSalidas.Image");
            btnSalidas.Location = new Point(515, 5);
            btnSalidas.Name = "btnSalidas";
            btnSalidas.Size = new Size(122, 35);
            btnSalidas.TabIndex = 7;
            btnSalidas.Text = "F1 Ventas";
            btnSalidas.TextAlign = ContentAlignment.MiddleRight;
            btnSalidas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalidas.UseVisualStyleBackColor = false;
            // 
            // btnAsignarCliente
            // 
            btnAsignarCliente.BackColor = SystemColors.ButtonHighlight;
            btnAsignarCliente.BackgroundImageLayout = ImageLayout.None;
            btnAsignarCliente.FlatAppearance.BorderColor = Color.Black;
            btnAsignarCliente.FlatAppearance.BorderSize = 0;
            btnAsignarCliente.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsignarCliente.Image = (Image)resources.GetObject("btnAsignarCliente.Image");
            btnAsignarCliente.Location = new Point(643, 5);
            btnAsignarCliente.Name = "btnAsignarCliente";
            btnAsignarCliente.Size = new Size(122, 35);
            btnAsignarCliente.TabIndex = 8;
            btnAsignarCliente.Text = "F1 Ventas";
            btnAsignarCliente.TextAlign = ContentAlignment.MiddleRight;
            btnAsignarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAsignarCliente.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ActiveCaptionText;
            labelTitle.Location = new Point(5, 3);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(180, 25);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "NUEVO PRODUCTO";
            // 
            // panelFooter
            // 
            panelFooter.BorderStyle = BorderStyle.FixedSingle;
            panelFooter.Controls.Add(btnGuardarProducto);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 533);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1449, 51);
            panelFooter.TabIndex = 17;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.BackColor = SystemColors.ButtonHighlight;
            btnGuardarProducto.BackgroundImageLayout = ImageLayout.None;
            btnGuardarProducto.FlatAppearance.BorderColor = Color.Black;
            btnGuardarProducto.FlatAppearance.BorderSize = 0;
            btnGuardarProducto.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarProducto.Image = (Image)resources.GetObject("btnGuardarProducto.Image");
            btnGuardarProducto.Location = new Point(5, 6);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(226, 35);
            btnGuardarProducto.TabIndex = 10;
            btnGuardarProducto.Text = "Guardar Producto";
            btnGuardarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnGuardarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarProducto.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelInventario);
            panel1.Controls.Add(checkInventario);
            panel1.Controls.Add(labelCantidadMinima);
            panel1.Controls.Add(txtCantidadMinima);
            panel1.Controls.Add(labelCantidadActual);
            panel1.Controls.Add(txtCantidadActual);
            panel1.Controls.Add(labelCategoria);
            panel1.Controls.Add(comboCategoria);
            panel1.Controls.Add(labelPrecioMayor);
            panel1.Controls.Add(txtPrecioMayor);
            panel1.Controls.Add(labelPrecioVenta);
            panel1.Controls.Add(txtPrecioVenta);
            panel1.Controls.Add(labelPrecioCosto);
            panel1.Controls.Add(txtPrecioCosto);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(labelDescripcion);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(labelCodigo);
            panel1.Controls.Add(labelTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(1449, 457);
            panel1.TabIndex = 18;
            // 
            // labelInventario
            // 
            labelInventario.AutoSize = true;
            labelInventario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInventario.ForeColor = SystemColors.ActiveCaptionText;
            labelInventario.Location = new Point(6, 259);
            labelInventario.Name = "labelInventario";
            labelInventario.Size = new Size(103, 21);
            labelInventario.TabIndex = 20;
            labelInventario.Text = "INVENTARIO";
            // 
            // checkInventario
            // 
            checkInventario.AutoSize = true;
            checkInventario.Location = new Point(11, 287);
            checkInventario.Name = "checkInventario";
            checkInventario.Size = new Size(177, 19);
            checkInventario.TabIndex = 19;
            checkInventario.Text = "El producto utiliza inventario";
            checkInventario.UseVisualStyleBackColor = true;
            // 
            // labelCantidadMinima
            // 
            labelCantidadMinima.AutoSize = true;
            labelCantidadMinima.Font = new Font("Segoe UI", 10F);
            labelCantidadMinima.Location = new Point(5, 359);
            labelCantidadMinima.Name = "labelCantidadMinima";
            labelCantidadMinima.Size = new Size(116, 19);
            labelCantidadMinima.TabIndex = 18;
            labelCantidadMinima.Text = "Cantidad mínima:";
            // 
            // txtCantidadMinima
            // 
            txtCantidadMinima.Location = new Point(128, 355);
            txtCantidadMinima.Name = "txtCantidadMinima";
            txtCantidadMinima.Size = new Size(309, 23);
            txtCantidadMinima.TabIndex = 17;
            // 
            // labelCantidadActual
            // 
            labelCantidadActual.AutoSize = true;
            labelCantidadActual.Font = new Font("Segoe UI", 10F);
            labelCantidadActual.Location = new Point(5, 322);
            labelCantidadActual.Name = "labelCantidadActual";
            labelCantidadActual.Size = new Size(107, 19);
            labelCantidadActual.TabIndex = 16;
            labelCantidadActual.Text = "Cantidad actual:";
            // 
            // txtCantidadActual
            // 
            txtCantidadActual.Location = new Point(128, 318);
            txtCantidadActual.Name = "txtCantidadActual";
            txtCantidadActual.Size = new Size(309, 23);
            txtCantidadActual.TabIndex = 15;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Segoe UI", 10F);
            labelCategoria.Location = new Point(5, 212);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(71, 19);
            labelCategoria.TabIndex = 14;
            labelCategoria.Text = "Categoría:";
            // 
            // comboCategoria
            // 
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(128, 211);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(309, 23);
            comboCategoria.TabIndex = 13;
            // 
            // labelPrecioMayor
            // 
            labelPrecioMayor.AutoSize = true;
            labelPrecioMayor.Font = new Font("Segoe UI", 10F);
            labelPrecioMayor.Location = new Point(5, 177);
            labelPrecioMayor.Name = "labelPrecioMayor";
            labelPrecioMayor.Size = new Size(117, 19);
            labelPrecioMayor.TabIndex = 12;
            labelPrecioMayor.Text = "Precio por mayor:";
            // 
            // txtPrecioMayor
            // 
            txtPrecioMayor.Location = new Point(128, 173);
            txtPrecioMayor.Name = "txtPrecioMayor";
            txtPrecioMayor.Size = new Size(309, 23);
            txtPrecioMayor.TabIndex = 11;
            // 
            // labelPrecioVenta
            // 
            labelPrecioVenta.AutoSize = true;
            labelPrecioVenta.Font = new Font("Segoe UI", 10F);
            labelPrecioVenta.Location = new Point(5, 142);
            labelPrecioVenta.Name = "labelPrecioVenta";
            labelPrecioVenta.Size = new Size(88, 19);
            labelPrecioVenta.TabIndex = 10;
            labelPrecioVenta.Text = "Precio Venta:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(128, 138);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(309, 23);
            txtPrecioVenta.TabIndex = 9;
            // 
            // labelPrecioCosto
            // 
            labelPrecioCosto.AutoSize = true;
            labelPrecioCosto.Font = new Font("Segoe UI", 10F);
            labelPrecioCosto.Location = new Point(5, 108);
            labelPrecioCosto.Name = "labelPrecioCosto";
            labelPrecioCosto.Size = new Size(89, 19);
            labelPrecioCosto.TabIndex = 8;
            labelPrecioCosto.Text = "Precio Costo:";
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(128, 104);
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(309, 23);
            txtPrecioCosto.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(128, 70);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(309, 23);
            txtDescripcion.TabIndex = 6;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Segoe UI", 10F);
            labelDescripcion.Location = new Point(5, 71);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(86, 19);
            labelDescripcion.TabIndex = 5;
            labelDescripcion.Text = "Descripción: ";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(128, 36);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(309, 23);
            txtCodigo.TabIndex = 4;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Segoe UI", 10F);
            labelCodigo.Location = new Point(5, 37);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(60, 19);
            labelCodigo.TabIndex = 3;
            labelCodigo.Text = "Código: ";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panelFooter);
            Controls.Add(panelNavbar);
            Controls.Add(panelHeader);
            Name = "Productos";
            Size = new Size(1449, 584);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavbar.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidadMinima).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidadActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioMayor).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioCosto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label ventasTitle;
        private Panel panelNavbar;
        public Button btnVarios;
        public Button btnComun;
        public Button btnBuscar;
        public Button btnEntradas;
        public Button btnVerificador;
        public Button btnSalidas;
        public Button btnAsignarCliente;
        private Label labelTitle;
        private Panel panelFooter;
        private Panel panel1;
        private TextBox txtDescripcion;
        private Label labelDescripcion;
        private TextBox txtCodigo;
        private Label labelCodigo;
        private Label labelCategoria;
        private ComboBox comboCategoria;
        private Label labelPrecioMayor;
        private NumericUpDown txtPrecioMayor;
        private Label labelPrecioVenta;
        private NumericUpDown txtPrecioVenta;
        private Label labelPrecioCosto;
        private NumericUpDown txtPrecioCosto;
        public Button btnGuardarProducto;
        private Label labelCantidadMinima;
        private NumericUpDown txtCantidadMinima;
        private Label labelCantidadActual;
        private NumericUpDown txtCantidadActual;
        private Label labelInventario;
        private CheckBox checkInventario;
    }
}
