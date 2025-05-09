﻿namespace PuntoDeVenta.UserControls.ProductosControls
{
    partial class NuevoProductoControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoProductoControl));
            labelTitle = new Label();
            panelFooter = new Panel();
            btnGuardarProducto = new Button();
            panelNuevoProducto = new Panel();
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
            panelFooter.SuspendLayout();
            panelNuevoProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidadMinima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidadActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioMayor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioCosto).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ButtonHighlight;
            labelTitle.Location = new Point(5, 3);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(180, 25);
            labelTitle.TabIndex = 20;
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
            panelFooter.TabIndex = 10;
            // 
            // btnGuardarProducto
            // 
            btnGuardarProducto.BackColor = Color.FromArgb(0, 80, 200);
            btnGuardarProducto.BackgroundImageLayout = ImageLayout.None;
            btnGuardarProducto.FlatAppearance.BorderColor = Color.Silver;
            btnGuardarProducto.FlatAppearance.BorderSize = 0;
            btnGuardarProducto.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnGuardarProducto.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnGuardarProducto.FlatStyle = FlatStyle.Flat;
            btnGuardarProducto.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarProducto.ForeColor = SystemColors.ButtonHighlight;
            btnGuardarProducto.Image = (Image)resources.GetObject("btnGuardarProducto.Image");
            btnGuardarProducto.Location = new Point(5, 6);
            btnGuardarProducto.Name = "btnGuardarProducto";
            btnGuardarProducto.Size = new Size(136, 35);
            btnGuardarProducto.TabIndex = 11;
            btnGuardarProducto.Text = "Guardar Producto";
            btnGuardarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnGuardarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarProducto.UseVisualStyleBackColor = false;
            btnGuardarProducto.Click += btnGuardarProducto_Click;
            // 
            // panelNuevoProducto
            // 
            panelNuevoProducto.BackColor = Color.FromArgb(49, 66, 82);
            panelNuevoProducto.Controls.Add(panelFooter);
            panelNuevoProducto.Controls.Add(labelInventario);
            panelNuevoProducto.Controls.Add(checkInventario);
            panelNuevoProducto.Controls.Add(labelCantidadMinima);
            panelNuevoProducto.Controls.Add(txtCantidadMinima);
            panelNuevoProducto.Controls.Add(labelCantidadActual);
            panelNuevoProducto.Controls.Add(txtCantidadActual);
            panelNuevoProducto.Controls.Add(labelCategoria);
            panelNuevoProducto.Controls.Add(comboCategoria);
            panelNuevoProducto.Controls.Add(labelPrecioMayor);
            panelNuevoProducto.Controls.Add(txtPrecioMayor);
            panelNuevoProducto.Controls.Add(labelPrecioVenta);
            panelNuevoProducto.Controls.Add(txtPrecioVenta);
            panelNuevoProducto.Controls.Add(labelPrecioCosto);
            panelNuevoProducto.Controls.Add(txtPrecioCosto);
            panelNuevoProducto.Controls.Add(txtDescripcion);
            panelNuevoProducto.Controls.Add(labelDescripcion);
            panelNuevoProducto.Controls.Add(txtCodigo);
            panelNuevoProducto.Controls.Add(labelCodigo);
            panelNuevoProducto.Controls.Add(labelTitle);
            panelNuevoProducto.Dock = DockStyle.Fill;
            panelNuevoProducto.ForeColor = SystemColors.ButtonHighlight;
            panelNuevoProducto.Location = new Point(0, 0);
            panelNuevoProducto.Name = "panelNuevoProducto";
            panelNuevoProducto.Size = new Size(1449, 584);
            panelNuevoProducto.TabIndex = 0;
            // 
            // labelInventario
            // 
            labelInventario.AutoSize = true;
            labelInventario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInventario.ForeColor = SystemColors.ButtonHighlight;
            labelInventario.Location = new Point(6, 259);
            labelInventario.Name = "labelInventario";
            labelInventario.Size = new Size(103, 21);
            labelInventario.TabIndex = 11;
            labelInventario.Text = "INVENTARIO";
            // 
            // checkInventario
            // 
            checkInventario.AutoSize = true;
            checkInventario.Location = new Point(11, 287);
            checkInventario.Name = "checkInventario";
            checkInventario.Size = new Size(177, 19);
            checkInventario.TabIndex = 7;
            checkInventario.Text = "El producto utiliza inventario";
            checkInventario.UseVisualStyleBackColor = true;
            checkInventario.CheckedChanged += checkInventario_CheckedChanged_1;
            // 
            // labelCantidadMinima
            // 
            labelCantidadMinima.AutoSize = true;
            labelCantidadMinima.Font = new Font("Segoe UI", 10F);
            labelCantidadMinima.Location = new Point(5, 359);
            labelCantidadMinima.Name = "labelCantidadMinima";
            labelCantidadMinima.Size = new Size(116, 19);
            labelCantidadMinima.TabIndex = 12;
            labelCantidadMinima.Text = "Cantidad mínima:";
            // 
            // txtCantidadMinima
            // 
            txtCantidadMinima.Enabled = false;
            txtCantidadMinima.Location = new Point(128, 355);
            txtCantidadMinima.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtCantidadMinima.Name = "txtCantidadMinima";
            txtCantidadMinima.Size = new Size(309, 23);
            txtCantidadMinima.TabIndex = 9;
            // 
            // labelCantidadActual
            // 
            labelCantidadActual.AutoSize = true;
            labelCantidadActual.Font = new Font("Segoe UI", 10F);
            labelCantidadActual.Location = new Point(5, 322);
            labelCantidadActual.Name = "labelCantidadActual";
            labelCantidadActual.Size = new Size(107, 19);
            labelCantidadActual.TabIndex = 13;
            labelCantidadActual.Text = "Cantidad actual:";
            // 
            // txtCantidadActual
            // 
            txtCantidadActual.Enabled = false;
            txtCantidadActual.Location = new Point(128, 318);
            txtCantidadActual.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtCantidadActual.Name = "txtCantidadActual";
            txtCantidadActual.Size = new Size(309, 23);
            txtCantidadActual.TabIndex = 8;
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
            comboCategoria.TabIndex = 6;
            // 
            // labelPrecioMayor
            // 
            labelPrecioMayor.AutoSize = true;
            labelPrecioMayor.Font = new Font("Segoe UI", 10F);
            labelPrecioMayor.Location = new Point(5, 177);
            labelPrecioMayor.Name = "labelPrecioMayor";
            labelPrecioMayor.Size = new Size(117, 19);
            labelPrecioMayor.TabIndex = 15;
            labelPrecioMayor.Text = "Precio por mayor:";
            // 
            // txtPrecioMayor
            // 
            txtPrecioMayor.Location = new Point(128, 173);
            txtPrecioMayor.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtPrecioMayor.Name = "txtPrecioMayor";
            txtPrecioMayor.Size = new Size(309, 23);
            txtPrecioMayor.TabIndex = 5;
            // 
            // labelPrecioVenta
            // 
            labelPrecioVenta.AutoSize = true;
            labelPrecioVenta.Font = new Font("Segoe UI", 10F);
            labelPrecioVenta.Location = new Point(5, 142);
            labelPrecioVenta.Name = "labelPrecioVenta";
            labelPrecioVenta.Size = new Size(88, 19);
            labelPrecioVenta.TabIndex = 16;
            labelPrecioVenta.Text = "Precio Venta:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(128, 138);
            txtPrecioVenta.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(309, 23);
            txtPrecioVenta.TabIndex = 4;
            // 
            // labelPrecioCosto
            // 
            labelPrecioCosto.AutoSize = true;
            labelPrecioCosto.Font = new Font("Segoe UI", 10F);
            labelPrecioCosto.Location = new Point(5, 108);
            labelPrecioCosto.Name = "labelPrecioCosto";
            labelPrecioCosto.Size = new Size(89, 19);
            labelPrecioCosto.TabIndex = 17;
            labelPrecioCosto.Text = "Precio Costo:";
            // 
            // txtPrecioCosto
            // 
            txtPrecioCosto.Location = new Point(128, 104);
            txtPrecioCosto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtPrecioCosto.Name = "txtPrecioCosto";
            txtPrecioCosto.Size = new Size(309, 23);
            txtPrecioCosto.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(128, 70);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(309, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Segoe UI", 10F);
            labelDescripcion.Location = new Point(5, 71);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(86, 19);
            labelDescripcion.TabIndex = 18;
            labelDescripcion.Text = "Descripción: ";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(128, 36);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(309, 23);
            txtCodigo.TabIndex = 1;
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Segoe UI", 10F);
            labelCodigo.Location = new Point(5, 37);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(60, 19);
            labelCodigo.TabIndex = 19;
            labelCodigo.Text = "Código: ";
            // 
            // NuevoProductoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelNuevoProducto);
            Name = "NuevoProductoControl";
            Size = new Size(1449, 584);
            panelFooter.ResumeLayout(false);
            panelNuevoProducto.ResumeLayout(false);
            panelNuevoProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidadMinima).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidadActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioMayor).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecioCosto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Panel panelFooter;
        private Panel panelNuevoProducto;
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
