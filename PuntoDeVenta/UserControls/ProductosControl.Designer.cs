﻿using PuntoDeVenta.UserControls.ProductosControls;

namespace PuntoDeVenta.UserControls
{
    partial class ProductosControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosControl));
            panelHeader = new Panel();
            ventasTitle = new Label();
            panelNavbar = new Panel();
            btnCatalogo = new Button();
            btnNuevoProducto = new Button();
            btnModificarProducto = new Button();
            btnEliminarProducto = new Button();
            btnCategorias = new Button();
            btnImportar = new Button();
            btnVentasPeriodo = new Button();
            btnPromociones = new Button();
            panelMain = new Panel();
            categoriaProducto1 = new CategoriaProductoControl(categoriaProductos);
            nuevoProducto1 = new NuevoProductoControl(categoriaProductos);
            catalogoProductos1 = new CatalogoProductosControl(categoriaProductos, this);
            panelHeader.SuspendLayout();
            panelNavbar.SuspendLayout();
            panelMain.SuspendLayout();
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
            panelNavbar.BackColor = Color.FromArgb(49, 66, 82);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(btnCatalogo);
            panelNavbar.Controls.Add(btnNuevoProducto);
            panelNavbar.Controls.Add(btnModificarProducto);
            panelNavbar.Controls.Add(btnEliminarProducto);
            panelNavbar.Controls.Add(btnCategorias);
            panelNavbar.Controls.Add(btnImportar);
            panelNavbar.Controls.Add(btnVentasPeriodo);
            panelNavbar.Controls.Add(btnPromociones);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.ForeColor = SystemColors.ButtonHighlight;
            panelNavbar.Location = new Point(0, 28);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1449, 48);
            panelNavbar.TabIndex = 16;
            // 
            // btnCatalogo
            // 
            btnCatalogo.BackColor = Color.FromArgb(0, 80, 200);
            btnCatalogo.BackgroundImageLayout = ImageLayout.None;
            btnCatalogo.FlatAppearance.BorderColor = Color.Silver;
            btnCatalogo.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnCatalogo.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCatalogo.FlatStyle = FlatStyle.Flat;
            btnCatalogo.FlatAppearance.BorderSize = 0;
            btnCatalogo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCatalogo.ForeColor = SystemColors.ButtonHighlight;
            btnCatalogo.Image = (Image)resources.GetObject("btnCatalogo.Image");
            btnCatalogo.Location = new Point(925, 5);
            btnCatalogo.Name = "btnCatalogo";
            btnCatalogo.Size = new Size(122, 35);
            btnCatalogo.TabIndex = 10;
            btnCatalogo.Text = "Catálogo";
            btnCatalogo.TextAlign = ContentAlignment.MiddleRight;
            btnCatalogo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCatalogo.UseVisualStyleBackColor = false;
            btnCatalogo.Click += btnCatalogo_Click;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.BackColor = Color.FromArgb(0, 80, 200);
            btnNuevoProducto.BackgroundImageLayout = ImageLayout.None;
            btnNuevoProducto.FlatAppearance.BorderColor = Color.Silver;
            btnNuevoProducto.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnNuevoProducto.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnNuevoProducto.FlatStyle = FlatStyle.Flat;
            btnNuevoProducto.FlatAppearance.BorderSize = 0;
            btnNuevoProducto.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoProducto.ForeColor = SystemColors.ButtonHighlight;
            btnNuevoProducto.Image = (Image)resources.GetObject("btnNuevoProducto.Image");
            btnNuevoProducto.Location = new Point(3, 5);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(122, 35);
            btnNuevoProducto.TabIndex = 3;
            btnNuevoProducto.Text = "Nuevo";
            btnNuevoProducto.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevoProducto.UseVisualStyleBackColor = false;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.BackColor = Color.FromArgb(0, 80, 200);
            btnModificarProducto.BackgroundImageLayout = ImageLayout.None;
            btnModificarProducto.FlatAppearance.BorderColor = Color.Silver;
            btnModificarProducto.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnModificarProducto.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnModificarProducto.FlatStyle = FlatStyle.Flat;
            btnModificarProducto.FlatAppearance.BorderSize = 0;
            btnModificarProducto.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificarProducto.ForeColor = SystemColors.ButtonHighlight;
            btnModificarProducto.Image = (Image)resources.GetObject("btnModificarProducto.Image");
            btnModificarProducto.Location = new Point(131, 5);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(122, 35);
            btnModificarProducto.TabIndex = 4;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnModificarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModificarProducto.UseVisualStyleBackColor = false;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.FromArgb(0, 80, 200);
            btnEliminarProducto.BackgroundImageLayout = ImageLayout.None;
            btnEliminarProducto.FlatAppearance.BorderColor = Color.Silver;
            btnEliminarProducto.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnEliminarProducto.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnEliminarProducto.FlatStyle = FlatStyle.Flat;
            btnEliminarProducto.FlatAppearance.BorderSize = 0;
            btnEliminarProducto.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarProducto.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarProducto.Image = (Image)resources.GetObject("btnEliminarProducto.Image");
            btnEliminarProducto.Location = new Point(259, 5);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(122, 35);
            btnEliminarProducto.TabIndex = 5;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.FromArgb(0, 80, 200);
            btnCategorias.BackgroundImageLayout = ImageLayout.None;
            btnCategorias.FlatAppearance.BorderColor = Color.Silver;
            btnCategorias.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnCategorias.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategorias.ForeColor = SystemColors.ButtonHighlight;
            btnCategorias.Image = (Image)resources.GetObject("btnCategorias.Image");
            btnCategorias.Location = new Point(387, 5);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(122, 35);
            btnCategorias.TabIndex = 6;
            btnCategorias.Text = "Categorias";
            btnCategorias.TextAlign = ContentAlignment.MiddleRight;
            btnCategorias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnImportar
            // 
            btnImportar.BackColor = Color.FromArgb(0, 80, 200);
            btnImportar.BackgroundImageLayout = ImageLayout.None;
            btnImportar.FlatAppearance.BorderColor = Color.Silver;
            btnImportar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnImportar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnImportar.FlatStyle = FlatStyle.Flat;
            btnImportar.FlatAppearance.BorderSize = 0;
            btnImportar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImportar.ForeColor = SystemColors.ButtonHighlight;
            btnImportar.Image = (Image)resources.GetObject("btnImportar.Image");
            btnImportar.Location = new Point(797, 5);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(122, 35);
            btnImportar.TabIndex = 9;
            btnImportar.Text = "Importar";
            btnImportar.TextAlign = ContentAlignment.MiddleRight;
            btnImportar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnImportar.UseVisualStyleBackColor = false;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnVentasPeriodo
            // 
            btnVentasPeriodo.BackColor = Color.FromArgb(0, 80, 200);
            btnVentasPeriodo.BackgroundImageLayout = ImageLayout.None;
            btnVentasPeriodo.FlatAppearance.BorderColor = Color.Silver;
            btnVentasPeriodo.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnVentasPeriodo.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnVentasPeriodo.FlatStyle = FlatStyle.Flat;
            btnVentasPeriodo.FlatAppearance.BorderSize = 0;
            btnVentasPeriodo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentasPeriodo.ForeColor = SystemColors.ButtonHighlight;
            btnVentasPeriodo.Image = (Image)resources.GetObject("btnVentasPeriodo.Image");
            btnVentasPeriodo.Location = new Point(515, 5);
            btnVentasPeriodo.Name = "btnVentasPeriodo";
            btnVentasPeriodo.Size = new Size(148, 35);
            btnVentasPeriodo.TabIndex = 7;
            btnVentasPeriodo.Text = "Ventas por Periodo";
            btnVentasPeriodo.TextAlign = ContentAlignment.MiddleRight;
            btnVentasPeriodo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVentasPeriodo.UseVisualStyleBackColor = false;
            btnVentasPeriodo.Click += btnVentasPeriodo_Click;
            // 
            // btnPromociones
            // 
            btnPromociones.BackColor = Color.FromArgb(0, 80, 200);
            btnPromociones.BackgroundImageLayout = ImageLayout.None;
            btnPromociones.FlatAppearance.BorderColor = Color.Silver;
            btnPromociones.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnPromociones.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnPromociones.FlatStyle = FlatStyle.Flat;
            btnPromociones.FlatAppearance.BorderSize = 0;
            btnPromociones.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPromociones.ForeColor = SystemColors.ButtonHighlight;
            btnPromociones.Image = (Image)resources.GetObject("btnPromociones.Image");
            btnPromociones.Location = new Point(669, 5);
            btnPromociones.Name = "btnPromociones";
            btnPromociones.Size = new Size(122, 35);
            btnPromociones.TabIndex = 8;
            btnPromociones.Text = "Promociones";
            btnPromociones.TextAlign = ContentAlignment.MiddleRight;
            btnPromociones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPromociones.UseVisualStyleBackColor = false;
            btnPromociones.Click += btnPromociones_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(categoriaProducto1);
            panelMain.Controls.Add(nuevoProducto1);
            panelMain.Controls.Add(catalogoProductos1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 76);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1449, 508);
            panelMain.TabIndex = 17;
            // 
            // categoriaProducto1
            // 
            categoriaProducto1.Dock = DockStyle.Fill;
            categoriaProducto1.Location = new Point(0, 0);
            categoriaProducto1.Name = "categoriaProducto1";
            categoriaProducto1.Size = new Size(1449, 508);
            categoriaProducto1.TabIndex = 9;
            // 
            // nuevoProducto1
            // 
            nuevoProducto1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nuevoProducto1.BackColor = Color.FromArgb(49, 66, 82);
            nuevoProducto1.Dock = DockStyle.Fill;
            nuevoProducto1.ForeColor = SystemColors.ButtonHighlight;
            nuevoProducto1.Location = new Point(0, 0);
            nuevoProducto1.Name = "nuevoProducto1";
            nuevoProducto1.Size = new Size(1449, 508);
            nuevoProducto1.TabIndex = 8;
            // 
            // catalogoProductos1
            // 
            catalogoProductos1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            catalogoProductos1.BackColor = Color.FromArgb(49, 66, 82);
            catalogoProductos1.Dock = DockStyle.Fill;
            catalogoProductos1.ForeColor = SystemColors.ButtonHighlight;
            catalogoProductos1.Location = new Point(0, 0);
            catalogoProductos1.Name = "nuevoProducto1";
            catalogoProductos1.Size = new Size(1449, 508);
            catalogoProductos1.TabIndex = 8;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Controls.Add(panelNavbar);
            Controls.Add(panelHeader);
            Name = "Productos";
            Size = new Size(1449, 584);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelNavbar.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label ventasTitle;
        private Panel panelNavbar;
        public Button btnNuevoProducto;
        public Button btnModificarProducto;
        public Button btnEliminarProducto;
        public Button btnCategorias;
        public Button btnImportar;
        public Button btnVentasPeriodo;
        public Button btnPromociones;
        private Panel panelMain;
        private NuevoProductoControl nuevoProducto1;
        public Button btnCatalogo;
        private CategoriaProductoControl categoriaProducto1;
        private CatalogoProductosControl catalogoProductos1;
    }
}
