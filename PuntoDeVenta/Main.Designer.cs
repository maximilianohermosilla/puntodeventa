using Microsoft.Extensions.DependencyInjection;
using PuntoDeVenta.Helpers;
using PuntoDeVenta.UserControls;

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
            btnCompras = new Button();
            btnInventario = new Button();
            btnProductos = new Button();
            btnClientes = new Button();
            btnCreditos = new Button();
            btnVentas = new Button();
            btnConfiguracion = new Button();
            imageList = new ImageList(components);
            panelMain = new Panel();
            ventas1 = new Ventas();
            productos1 = new Productos();
            reportes1 = new Reportes();
            inventario1 = new Inventario();
            facturas1 = new Facturas();
            creditos1 = new Creditos();
            corte1 = new Corte();
            configuracion1 = new Configuracion();
            compras1 = new Compras();
            clientes1 = new Clientes();
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
            panelHeader.BackColor = Color.FromArgb(26, 32, 40);
            panelHeader.Controls.Add(labelTitulo);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.ForeColor = SystemColors.ButtonHighlight;
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
            panelNavbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BackColor = Color.FromArgb(26, 32, 40);
            panelNavbar.Controls.Add(btnReportes);
            panelNavbar.Controls.Add(btnCorte);
            panelNavbar.Controls.Add(btnFacturas);
            panelNavbar.Controls.Add(btnCompras);
            panelNavbar.Controls.Add(btnInventario);
            panelNavbar.Controls.Add(btnProductos);
            panelNavbar.Controls.Add(btnClientes);
            panelNavbar.Controls.Add(btnCreditos);
            panelNavbar.Controls.Add(btnVentas);
            panelNavbar.Controls.Add(btnConfiguracion);
            panelNavbar.Location = new Point(0, 44);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(137, 727);
            panelNavbar.TabIndex = 1;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(0, 80, 200);
            btnReportes.BackgroundImageLayout = ImageLayout.None;
            btnReportes.FlatAppearance.BorderColor = Color.Silver;
            btnReportes.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnReportes.FlatStyle = FlatStyle.Popup;
            btnReportes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = SystemColors.ButtonHighlight;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.Location = new Point(4, 516);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(122, 45);
            btnReportes.TabIndex = 8;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleRight;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnCorte
            // 
            btnCorte.BackColor = Color.FromArgb(0, 80, 200);
            btnCorte.BackgroundImageLayout = ImageLayout.None;
            btnCorte.FlatAppearance.BorderColor = Color.Silver;
            btnCorte.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnCorte.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnCorte.FlatStyle = FlatStyle.Popup;
            btnCorte.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCorte.ForeColor = SystemColors.ButtonHighlight;
            btnCorte.Image = (Image)resources.GetObject("btnCorte.Image");
            btnCorte.Location = new Point(4, 465);
            btnCorte.Name = "btnCorte";
            btnCorte.Size = new Size(122, 45);
            btnCorte.TabIndex = 7;
            btnCorte.Text = "Corte";
            btnCorte.TextAlign = ContentAlignment.MiddleRight;
            btnCorte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCorte.UseVisualStyleBackColor = false;
            btnCorte.Click += btnCorte_Click;
            // 
            // btnFacturas
            // 
            btnFacturas.BackColor = Color.FromArgb(0, 80, 200);
            btnFacturas.BackgroundImageLayout = ImageLayout.None;
            btnFacturas.FlatAppearance.BorderColor = Color.Silver;
            btnFacturas.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnFacturas.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnFacturas.FlatStyle = FlatStyle.Popup;
            btnFacturas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFacturas.ForeColor = SystemColors.ButtonHighlight;
            btnFacturas.Image = (Image)resources.GetObject("btnFacturas.Image");
            btnFacturas.Location = new Point(4, 414);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(122, 45);
            btnFacturas.TabIndex = 6;
            btnFacturas.Text = "Facturas";
            btnFacturas.TextAlign = ContentAlignment.MiddleRight;
            btnFacturas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFacturas.UseVisualStyleBackColor = false;
            btnFacturas.Click += btnFacturas_Click;
            // 
            // btnCompras
            // 
            btnCompras.BackColor = Color.FromArgb(0, 80, 200);
            btnCompras.BackgroundImageLayout = ImageLayout.None;
            btnCompras.FlatAppearance.BorderColor = Color.Silver;
            btnCompras.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnCompras.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnCompras.FlatStyle = FlatStyle.Popup;
            btnCompras.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompras.ForeColor = SystemColors.ButtonHighlight;
            btnCompras.Image = (Image)resources.GetObject("btnCompras.Image");
            btnCompras.Location = new Point(4, 363);
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
            btnInventario.BackColor = Color.FromArgb(0, 80, 200);
            btnInventario.BackgroundImageLayout = ImageLayout.None;
            btnInventario.FlatAppearance.BorderColor = Color.Silver;
            btnInventario.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnInventario.FlatStyle = FlatStyle.Popup;
            btnInventario.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = SystemColors.ButtonHighlight;
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.Location = new Point(4, 159);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(122, 45);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "(F2) Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleRight;
            btnInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventario.UseVisualStyleBackColor = false;
            btnInventario.Click += btnInventario_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(0, 80, 200);
            btnProductos.BackgroundImageLayout = ImageLayout.None;
            btnProductos.FlatAppearance.BorderColor = Color.Silver;
            btnProductos.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnProductos.FlatStyle = FlatStyle.Popup;
            btnProductos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = SystemColors.ButtonHighlight;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.Location = new Point(4, 210);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(122, 45);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "(F3) Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleRight;
            btnProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(0, 80, 200);
            btnClientes.BackgroundImageLayout = ImageLayout.None;
            btnClientes.FlatAppearance.BorderColor = Color.Silver;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnClientes.FlatStyle = FlatStyle.Popup;
            btnClientes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = SystemColors.ButtonHighlight;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.Location = new Point(4, 312);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(122, 45);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleRight;
            btnClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnCreditos
            // 
            btnCreditos.BackColor = Color.FromArgb(0, 80, 200);
            btnCreditos.BackgroundImageLayout = ImageLayout.None;
            btnCreditos.FlatAppearance.BorderColor = Color.Silver;
            btnCreditos.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnCreditos.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnCreditos.FlatStyle = FlatStyle.Popup;
            btnCreditos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreditos.ForeColor = SystemColors.ButtonHighlight;
            btnCreditos.Image = (Image)resources.GetObject("btnCreditos.Image");
            btnCreditos.Location = new Point(4, 261);
            btnCreditos.Name = "btnCreditos";
            btnCreditos.Size = new Size(122, 45);
            btnCreditos.TabIndex = 3;
            btnCreditos.Text = "(F4) Créditos";
            btnCreditos.TextAlign = ContentAlignment.MiddleRight;
            btnCreditos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreditos.UseVisualStyleBackColor = false;
            btnCreditos.Click += btnCreditos_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(0, 80, 200);
            btnVentas.BackgroundImageLayout = ImageLayout.None;
            btnVentas.FlatAppearance.BorderColor = Color.Silver;
            btnVentas.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnVentas.FlatStyle = FlatStyle.Popup;
            btnVentas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = SystemColors.ButtonHighlight;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.Location = new Point(4, 108);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(122, 45);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "(F1) Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleRight;
            btnVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = Color.FromArgb(0, 80, 200);
            btnConfiguracion.BackgroundImageLayout = ImageLayout.None;
            btnConfiguracion.FlatAppearance.BorderColor = Color.Silver;
            btnConfiguracion.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnConfiguracion.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnConfiguracion.FlatStyle = FlatStyle.Popup;
            btnConfiguracion.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfiguracion.ForeColor = SystemColors.ButtonHighlight;
            btnConfiguracion.Image = (Image)resources.GetObject("btnConfiguracion.Image");
            btnConfiguracion.Location = new Point(4, 567);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(122, 45);
            btnConfiguracion.TabIndex = 9;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.TextAlign = ContentAlignment.MiddleRight;
            btnConfiguracion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracion.UseVisualStyleBackColor = false;
            btnConfiguracion.Click += btnConfiguracion_Click;
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
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelMain.BackColor = Color.FromArgb(49, 66, 82);
            panelMain.Controls.Add(ventas1);
            panelMain.Controls.Add(productos1);
            panelMain.Controls.Add(reportes1);
            panelMain.Controls.Add(inventario1);
            panelMain.Controls.Add(facturas1);
            panelMain.Controls.Add(creditos1);
            panelMain.Controls.Add(corte1);
            panelMain.Controls.Add(configuracion1);
            panelMain.Controls.Add(compras1);
            panelMain.Controls.Add(clientes1);
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Location = new Point(143, 44);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1295, 727);
            panelMain.TabIndex = 2;
            // 
            // ventas1
            // 
            ventas1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ventas1.BackColor = Color.FromArgb(49, 66, 82);
            ventas1.Dock = DockStyle.Fill;
            ventas1.ForeColor = SystemColors.ButtonHighlight;
            ventas1.Location = new Point(0, 0);
            ventas1.Name = "ventas1";
            ventas1.Size = new Size(1295, 727);
            ventas1.TabIndex = 9;
            // 
            // productos1
            // 
            productos1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            productos1.BackColor = Color.FromArgb(49, 66, 82);
            productos1.Dock = DockStyle.Fill;
            productos1.Location = new Point(0, 0);
            productos1.Name = "productos1";
            productos1.Size = new Size(1295, 727);
            productos1.TabIndex = 9;
            // 
            // reportes1
            // 
            reportes1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            reportes1.BackColor = Color.FromArgb(49, 66, 82);
            reportes1.Dock = DockStyle.Fill;
            reportes1.ForeColor = SystemColors.ButtonHighlight;
            reportes1.Location = new Point(0, 0);
            reportes1.Name = "reportes1";
            reportes1.Size = new Size(1295, 727);
            reportes1.TabIndex = 8;
            // 
            // inventario1
            // 
            inventario1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            inventario1.Dock = DockStyle.Fill;
            inventario1.Location = new Point(0, 0);
            inventario1.Name = "inventario1";
            inventario1.Size = new Size(1295, 727);
            inventario1.TabIndex = 6;
            // 
            // facturas1
            // 
            facturas1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            facturas1.BackColor = Color.FromArgb(49, 66, 82);
            facturas1.Dock = DockStyle.Fill;
            facturas1.ForeColor = SystemColors.ButtonHighlight;
            facturas1.Location = new Point(0, 0);
            facturas1.Name = "facturas1";
            facturas1.Size = new Size(1295, 727);
            facturas1.TabIndex = 5;
            // 
            // creditos1
            // 
            creditos1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            creditos1.BackColor = Color.FromArgb(49, 66, 82);
            creditos1.Dock = DockStyle.Fill;
            creditos1.ForeColor = SystemColors.ButtonHighlight;
            creditos1.Location = new Point(0, 0);
            creditos1.Name = "creditos1";
            creditos1.Size = new Size(1295, 727);
            creditos1.TabIndex = 4;
            // 
            // corte1
            // 
            corte1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            corte1.BackColor = Color.FromArgb(49, 66, 82);
            corte1.Dock = DockStyle.Fill;
            corte1.ForeColor = SystemColors.ButtonHighlight;
            corte1.Location = new Point(0, 0);
            corte1.Name = "corte1";
            corte1.Size = new Size(1295, 727);
            corte1.TabIndex = 3;
            // 
            // configuracion1
            // 
            configuracion1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            configuracion1.BackColor = Color.FromArgb(49, 66, 82);
            configuracion1.Dock = DockStyle.Fill;
            configuracion1.ForeColor = SystemColors.ButtonHighlight;
            configuracion1.Location = new Point(0, 0);
            configuracion1.Name = "configuracion1";
            configuracion1.Size = new Size(1295, 727);
            configuracion1.TabIndex = 2;
            // 
            // compras1
            // 
            compras1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            compras1.BackColor = Color.FromArgb(49, 66, 82);
            compras1.Dock = DockStyle.Fill;
            compras1.ForeColor = SystemColors.ButtonHighlight;
            compras1.Location = new Point(0, 0);
            compras1.Name = "compras1";
            compras1.Size = new Size(1295, 727);
            compras1.TabIndex = 1;
            // 
            // clientes1
            // 
            clientes1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clientes1.BackColor = Color.FromArgb(49, 66, 82);
            clientes1.Dock = DockStyle.Fill;
            clientes1.Location = new Point(0, 0);
            clientes1.Name = "clientes1";
            clientes1.Size = new Size(1295, 727);
            clientes1.TabIndex = 0;
            // 
            // panelFooter
            // 
            panelFooter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFooter.BackColor = Color.FromArgb(26, 32, 40);
            panelFooter.Controls.Add(txtDatetime);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.ForeColor = SystemColors.ButtonHighlight;
            panelFooter.Location = new Point(0, 773);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1438, 34);
            panelFooter.TabIndex = 3;
            // 
            // txtDatetime
            // 
            txtDatetime.AutoSize = true;
            txtDatetime.Dock = DockStyle.Right;
            txtDatetime.Font = new Font("Segoe UI Light", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDatetime.Location = new Point(1241, 0);
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
            BackColor = Color.FromArgb(26, 32, 40);
            ClientSize = new Size(1438, 807);
            Controls.Add(panelHeader);
            Controls.Add(panelNavbar);
            Controls.Add(panelFooter);
            Controls.Add(panelMain);
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
        private Reportes reportes1;
        private Productos productos1;
        private Inventario inventario1;
        private Facturas facturas1;
        private Creditos creditos1;
        private Corte corte1;
        private Configuracion configuracion1;
        private Compras compras1;
        private Clientes clientes1;
        private Panel panelFooter;
        private Label txtDatetime;
        private System.Windows.Forms.Timer timer1;
    }    
}