namespace PuntoDeVenta
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            labelTitulo = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnFacturas = new Button();
            btnConfiguracion = new Button();
            btnCompras = new Button();
            btnInventario = new Button();
            btnProductos = new Button();
            btnClientes = new Button();
            btnCreditos = new Button();
            btnVentas = new Button();
            imageList = new ImageList(components);
            btnCorte = new Button();
            btnReportes = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1438, 44);
            panel1.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Bauhaus 93", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(47, 8);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(214, 30);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "PUNTO DE VENTA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_bedaqui;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnReportes);
            panel2.Controls.Add(btnCorte);
            panel2.Controls.Add(btnFacturas);
            panel2.Controls.Add(btnConfiguracion);
            panel2.Controls.Add(btnCompras);
            panel2.Controls.Add(btnInventario);
            panel2.Controls.Add(btnProductos);
            panel2.Controls.Add(btnClientes);
            panel2.Controls.Add(btnCreditos);
            panel2.Controls.Add(btnVentas);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(1438, 51);
            panel2.TabIndex = 1;
            // 
            // btnFacturas
            // 
            btnFacturas.BackColor = SystemColors.ButtonHighlight;
            btnFacturas.BackgroundImageLayout = ImageLayout.None;
            btnFacturas.FlatAppearance.BorderSize = 0;
            btnFacturas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFacturas.Image = (Image)resources.GetObject("btnFacturas.Image");
            btnFacturas.Location = new Point(899, 1);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(122, 45);
            btnFacturas.TabIndex = 7;
            btnFacturas.Text = "Facturas";
            btnFacturas.TextAlign = ContentAlignment.MiddleRight;
            btnFacturas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFacturas.UseVisualStyleBackColor = false;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = SystemColors.ButtonHighlight;
            btnConfiguracion.BackgroundImageLayout = ImageLayout.None;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfiguracion.Image = (Image)resources.GetObject("btnConfiguracion.Image");
            btnConfiguracion.Location = new Point(771, 1);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(122, 45);
            btnConfiguracion.TabIndex = 6;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.TextAlign = ContentAlignment.MiddleRight;
            btnConfiguracion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracion.UseVisualStyleBackColor = false;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = SystemColors.ButtonHighlight;
            btnCompras.BackgroundImageLayout = ImageLayout.None;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompras.Image = (Image)resources.GetObject("btnCompras.Image");
            btnCompras.Location = new Point(643, 1);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(122, 45);
            btnCompras.TabIndex = 5;
            btnCompras.Text = "Compras";
            btnCompras.TextAlign = ContentAlignment.MiddleRight;
            btnCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCompras.UseVisualStyleBackColor = false;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = SystemColors.ButtonHighlight;
            btnInventario.BackgroundImageLayout = ImageLayout.None;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.Location = new Point(387, 1);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(122, 45);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "F4 Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleRight;
            btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = SystemColors.ButtonHighlight;
            btnProductos.BackgroundImageLayout = ImageLayout.None;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.Location = new Point(259, 1);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(122, 45);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "F3 Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleRight;
            btnProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductos.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = SystemColors.ButtonHighlight;
            btnClientes.BackgroundImageLayout = ImageLayout.None;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.Location = new Point(515, 1);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(122, 45);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleRight;
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnCreditos
            // 
            btnCreditos.BackColor = SystemColors.ButtonHighlight;
            btnCreditos.BackgroundImageLayout = ImageLayout.None;
            btnCreditos.FlatAppearance.BorderSize = 0;
            btnCreditos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreditos.Image = (Image)resources.GetObject("btnCreditos.Image");
            btnCreditos.Location = new Point(131, 1);
            btnCreditos.Name = "btnCreditos";
            btnCreditos.Size = new Size(122, 45);
            btnCreditos.TabIndex = 1;
            btnCreditos.Text = "F2 Créditos";
            btnCreditos.TextAlign = ContentAlignment.MiddleRight;
            btnCreditos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreditos.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = SystemColors.ButtonHighlight;
            btnVentas.BackgroundImageLayout = ImageLayout.None;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.Location = new Point(3, 1);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(122, 45);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "F1 Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleRight;
            btnVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "basket.png");
            // 
            // btnCorte
            // 
            btnCorte.BackColor = SystemColors.ButtonHighlight;
            btnCorte.BackgroundImageLayout = ImageLayout.None;
            btnCorte.FlatAppearance.BorderSize = 0;
            btnCorte.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCorte.Image = new Bitmap(Properties.Resources.list_01, new Size(24, 24));
            btnCorte.Location = new Point(1027, 1);
            btnCorte.Name = "btnCorte";
            btnCorte.Size = new Size(122, 45);
            btnCorte.TabIndex = 8;
            btnCorte.Text = "Corte";
            btnCorte.TextAlign = ContentAlignment.MiddleRight;
            btnCorte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCorte.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = SystemColors.ButtonHighlight;
            btnReportes.BackgroundImageLayout = ImageLayout.None;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.Image = new Bitmap(Properties.Resources.report_02, new Size(24, 24));
            btnReportes.Location = new Point(1155, 1);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(122, 45);
            btnReportes.TabIndex = 9;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleRight;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1438, 766);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Main";
            ShowIcon = false;
            Text = "PuntoDeVenta - Bedaqui";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label labelTitulo;
        private PictureBox pictureBox1;
        public Button btnVentas;
        private ImageList imageList;
        public Button btnCreditos;
        public Button btnClientes;
        public Button btnProductos;
        public Button btnInventario;
        public Button btnCompras;
        public Button btnConfiguracion;
        public Button btnFacturas;
        public Button btnReportes;
        public Button btnCorte;
    }
}