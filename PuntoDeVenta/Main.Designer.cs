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
            panelHeader = new Panel();
            labelTitulo = new Label();
            pictureBox1 = new PictureBox();
            panelNavbar = new Panel();
            btnReportes = new Button();
            btnCorte = new Button();
            btnFacturas = new Button();
            btnConfiguracion = new Button();
            btnCompras = new Button();
            btnInventario = new Button();
            btnProductos = new Button();
            btnClientes = new Button();
            btnCreditos = new Button();
            btnVentas = new Button();
            imageList = new ImageList(components);
            panelMain = new Panel();
            ventas1 = new Ventas();
            reportes1 = new UserControls.Reportes();
            productos1 = new UserControls.Productos();
            inventario1 = new UserControls.Inventario();
            facturas1 = new UserControls.Facturas();
            creditos1 = new UserControls.Creditos();
            corte1 = new UserControls.Corte();
            configuracion1 = new UserControls.Configuracion();
            compras1 = new UserControls.Compras();
            clientes1 = new UserControls.Clientes();
            panelFooter = new Panel();
            txtDatetime = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            timer1 = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelNavbar.SuspendLayout();
            panelMain.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelHeader.BackColor = SystemColors.ButtonHighlight;
            panelHeader.BorderStyle = BorderStyle.FixedSingle;
            panelHeader.Controls.Add(labelTitulo);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1438, 44);
            panelHeader.TabIndex = 0;
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
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BackColor = SystemColors.ButtonFace;
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(btnReportes);
            panelNavbar.Controls.Add(btnCorte);
            panelNavbar.Controls.Add(btnFacturas);
            panelNavbar.Controls.Add(btnConfiguracion);
            panelNavbar.Controls.Add(btnCompras);
            panelNavbar.Controls.Add(btnInventario);
            panelNavbar.Controls.Add(btnProductos);
            panelNavbar.Controls.Add(btnClientes);
            panelNavbar.Controls.Add(btnCreditos);
            panelNavbar.Controls.Add(btnVentas);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(0, 44);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1438, 54);
            panelNavbar.TabIndex = 1;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = SystemColors.ButtonHighlight;
            btnReportes.BackgroundImageLayout = ImageLayout.None;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.Location = new Point(1155, 3);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(122, 45);
            btnReportes.TabIndex = 9;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleRight;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnCorte
            // 
            btnCorte.BackColor = SystemColors.ButtonHighlight;
            btnCorte.BackgroundImageLayout = ImageLayout.None;
            btnCorte.FlatAppearance.BorderSize = 0;
            btnCorte.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCorte.Image = (Image)resources.GetObject("btnCorte.Image");
            btnCorte.Location = new Point(1027, 3);
            btnCorte.Name = "btnCorte";
            btnCorte.Size = new Size(122, 45);
            btnCorte.TabIndex = 8;
            btnCorte.Text = "Corte";
            btnCorte.TextAlign = ContentAlignment.MiddleRight;
            btnCorte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCorte.UseVisualStyleBackColor = false;
            btnCorte.Click += btnCorte_Click;
            // 
            // btnFacturas
            // 
            btnFacturas.BackColor = SystemColors.ButtonHighlight;
            btnFacturas.BackgroundImageLayout = ImageLayout.None;
            btnFacturas.FlatAppearance.BorderSize = 0;
            btnFacturas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFacturas.Image = (Image)resources.GetObject("btnFacturas.Image");
            btnFacturas.Location = new Point(899, 3);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(122, 45);
            btnFacturas.TabIndex = 7;
            btnFacturas.Text = "Facturas";
            btnFacturas.TextAlign = ContentAlignment.MiddleRight;
            btnFacturas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFacturas.UseVisualStyleBackColor = false;
            btnFacturas.Click += btnFacturas_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = SystemColors.ButtonHighlight;
            btnConfiguracion.BackgroundImageLayout = ImageLayout.None;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfiguracion.Image = (Image)resources.GetObject("btnConfiguracion.Image");
            btnConfiguracion.Location = new Point(771, 3);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(122, 45);
            btnConfiguracion.TabIndex = 6;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.TextAlign = ContentAlignment.MiddleRight;
            btnConfiguracion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracion.UseVisualStyleBackColor = false;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = SystemColors.ButtonHighlight;
            btnCompras.BackgroundImageLayout = ImageLayout.None;
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompras.Image = (Image)resources.GetObject("btnCompras.Image");
            btnCompras.Location = new Point(643, 3);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(122, 45);
            btnCompras.TabIndex = 5;
            btnCompras.Text = "Compras";
            btnCompras.TextAlign = ContentAlignment.MiddleRight;
            btnCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCompras.UseVisualStyleBackColor = false;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = SystemColors.ButtonHighlight;
            btnInventario.BackgroundImageLayout = ImageLayout.None;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.Location = new Point(387, 3);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(122, 45);
            btnInventario.TabIndex = 4;
            btnInventario.Text = "F4 Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleRight;
            btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = SystemColors.ButtonHighlight;
            btnProductos.BackgroundImageLayout = ImageLayout.None;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.Location = new Point(259, 3);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(122, 45);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "F3 Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleRight;
            btnProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = SystemColors.ButtonHighlight;
            btnClientes.BackgroundImageLayout = ImageLayout.None;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.Location = new Point(515, 3);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(122, 45);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleRight;
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnCreditos
            // 
            btnCreditos.BackColor = SystemColors.ButtonHighlight;
            btnCreditos.BackgroundImageLayout = ImageLayout.None;
            btnCreditos.FlatAppearance.BorderSize = 0;
            btnCreditos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreditos.Image = (Image)resources.GetObject("btnCreditos.Image");
            btnCreditos.Location = new Point(131, 3);
            btnCreditos.Name = "btnCreditos";
            btnCreditos.Size = new Size(122, 45);
            btnCreditos.TabIndex = 1;
            btnCreditos.Text = "F2 Créditos";
            btnCreditos.TextAlign = ContentAlignment.MiddleRight;
            btnCreditos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreditos.UseVisualStyleBackColor = false;
            btnCreditos.Click += btnCreditos_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = SystemColors.ButtonHighlight;
            btnVentas.BackgroundImageLayout = ImageLayout.None;
            btnVentas.FlatAppearance.BorderColor = Color.Black;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.Location = new Point(3, 3);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(122, 45);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "F1 Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleRight;
            btnVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "basket.png");
            // 
            // panelMain
            // 
            panelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelMain.BackColor = SystemColors.ActiveBorder;
            panelMain.Controls.Add(ventas1);
            panelMain.Controls.Add(reportes1);
            panelMain.Controls.Add(productos1);
            panelMain.Controls.Add(inventario1);
            panelMain.Controls.Add(facturas1);
            panelMain.Controls.Add(creditos1);
            panelMain.Controls.Add(corte1);
            panelMain.Controls.Add(configuracion1);
            panelMain.Controls.Add(compras1);
            panelMain.Controls.Add(clientes1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 98);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1438, 634);
            panelMain.TabIndex = 2;
            // 
            // ventas1
            // 
            ventas1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ventas1.BackColor = Color.Honeydew;
            ventas1.Dock = DockStyle.Fill;
            ventas1.Location = new Point(0, 0);
            ventas1.Name = "ventas1";
            ventas1.Size = new Size(1438, 634);
            ventas1.TabIndex = 9;
            // 
            // reportes1
            // 
            reportes1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            reportes1.Dock = DockStyle.Fill;
            reportes1.Location = new Point(0, 0);
            reportes1.Name = "reportes1";
            reportes1.Size = new Size(1438, 634);
            reportes1.TabIndex = 8;
            // 
            // productos1
            // 
            productos1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            productos1.Dock = DockStyle.Fill;
            productos1.Location = new Point(0, 0);
            productos1.Name = "productos1";
            productos1.Size = new Size(1438, 634);
            productos1.TabIndex = 7;
            // 
            // inventario1
            // 
            inventario1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            inventario1.Dock = DockStyle.Fill;
            inventario1.Location = new Point(0, 0);
            inventario1.Name = "inventario1";
            inventario1.Size = new Size(1438, 634);
            inventario1.TabIndex = 6;
            // 
            // facturas1
            // 
            facturas1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            facturas1.Dock = DockStyle.Fill;
            facturas1.Location = new Point(0, 0);
            facturas1.Name = "facturas1";
            facturas1.Size = new Size(1438, 634);
            facturas1.TabIndex = 5;
            // 
            // creditos1
            // 
            creditos1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            creditos1.BackColor = SystemColors.ActiveCaptionText;
            creditos1.Dock = DockStyle.Fill;
            creditos1.Location = new Point(0, 0);
            creditos1.Name = "creditos1";
            creditos1.Size = new Size(1438, 634);
            creditos1.TabIndex = 4;
            // 
            // corte1
            // 
            corte1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            corte1.Dock = DockStyle.Fill;
            corte1.Location = new Point(0, 0);
            corte1.Name = "corte1";
            corte1.Size = new Size(1438, 634);
            corte1.TabIndex = 3;
            // 
            // configuracion1
            // 
            configuracion1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            configuracion1.Dock = DockStyle.Fill;
            configuracion1.Location = new Point(0, 0);
            configuracion1.Name = "configuracion1";
            configuracion1.Size = new Size(1438, 634);
            configuracion1.TabIndex = 2;
            // 
            // compras1
            // 
            compras1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            compras1.Dock = DockStyle.Fill;
            compras1.Location = new Point(0, 0);
            compras1.Name = "compras1";
            compras1.Size = new Size(1438, 634);
            compras1.TabIndex = 1;
            // 
            // clientes1
            // 
            clientes1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clientes1.Dock = DockStyle.Fill;
            clientes1.Location = new Point(0, 0);
            clientes1.Name = "clientes1";
            clientes1.Size = new Size(1438, 634);
            clientes1.TabIndex = 0;
            // 
            // panelFooter
            // 
            panelFooter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFooter.BackColor = SystemColors.ButtonHighlight;
            panelFooter.BorderStyle = BorderStyle.FixedSingle;
            panelFooter.Controls.Add(txtDatetime);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 732);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1438, 34);
            panelFooter.TabIndex = 3;
            // 
            // txtDatetime
            // 
            txtDatetime.AutoSize = true;
            txtDatetime.Dock = DockStyle.Right;
            txtDatetime.Font = new Font("Segoe UI Light", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDatetime.Location = new Point(1239, 0);
            txtDatetime.Name = "txtDatetime";
            txtDatetime.Size = new Size(197, 30);
            txtDatetime.TabIndex = 1;
            txtDatetime.Text = "22/1/2025 21:17:39";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1438, 766);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelNavbar);
            Controls.Add(panelHeader);
            Name = "Main";
            ShowIcon = false;
            Text = "PuntoDeVenta - Bedaqui";
            WindowState = FormWindowState.Maximized;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelNavbar.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelNavbar;
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
        private Panel panelMain;
        public void InitializeUserControls()
        {
            var clientesUserControl = new PuntoDeVenta.UserControls.Clientes();

            panelMain.Controls.Add(clientesUserControl);
        }

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Ventas ventas1;
        private UserControls.Reportes reportes1;
        private UserControls.Productos productos1;
        private UserControls.Inventario inventario1;
        private UserControls.Facturas facturas1;
        private UserControls.Creditos creditos1;
        private UserControls.Corte corte1;
        private UserControls.Configuracion configuracion1;
        private UserControls.Compras compras1;
        private UserControls.Clientes clientes1;
        private Panel panelFooter;
        private Label txtDatetime;
        private System.Windows.Forms.Timer timer1;
    }    
}