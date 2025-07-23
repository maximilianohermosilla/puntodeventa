using PuntoDeVenta.Application.DTO;
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
        protected override async void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

            if(turnoActual != null)
            {
                if (DialogResult.Yes == MessageBox.Show(@$"¿Desea finalizar el turno iniciado {turnoActual!.FechaInicio.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    await FinalizarTurno();
                }
            }
            
            System.Windows.Forms.Application.Exit();
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
            panelNavbar = new Panel();
            pictureBox2 = new PictureBox();
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
            panelFooter = new Panel();
            txtDatetime = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            timer1 = new System.Windows.Forms.Timer(components);
            panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BackColor = Color.FromArgb(26, 32, 40);
            panelNavbar.Controls.Add(pictureBox2);
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
            panelNavbar.Dock = DockStyle.Left;
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(137, 807);
            panelNavbar.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_bedaqui;
            pictureBox2.Location = new Point(4, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(0, 80, 200);
            btnReportes.BackgroundImageLayout = ImageLayout.None;
            btnReportes.FlatAppearance.BorderColor = Color.Silver;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = SystemColors.ButtonHighlight;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.Location = new Point(4, 531);
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
            btnCorte.FlatAppearance.BorderSize = 0;
            btnCorte.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnCorte.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCorte.FlatStyle = FlatStyle.Flat;
            btnCorte.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCorte.ForeColor = SystemColors.ButtonHighlight;
            btnCorte.Image = (Image)resources.GetObject("btnCorte.Image");
            btnCorte.Location = new Point(4, 480);
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
            btnFacturas.FlatAppearance.BorderSize = 0;
            btnFacturas.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnFacturas.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnFacturas.FlatStyle = FlatStyle.Flat;
            btnFacturas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFacturas.ForeColor = SystemColors.ButtonHighlight;
            btnFacturas.Image = (Image)resources.GetObject("btnFacturas.Image");
            btnFacturas.Location = new Point(4, 429);
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
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnCompras.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompras.ForeColor = SystemColors.ButtonHighlight;
            btnCompras.Image = (Image)resources.GetObject("btnCompras.Image");
            btnCompras.Location = new Point(4, 378);
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
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnInventario.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = SystemColors.ButtonHighlight;
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.Location = new Point(4, 174);
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
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = SystemColors.ButtonHighlight;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.Location = new Point(4, 225);
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
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = SystemColors.ButtonHighlight;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.Location = new Point(4, 327);
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
            btnCreditos.FlatAppearance.BorderSize = 0;
            btnCreditos.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnCreditos.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCreditos.FlatStyle = FlatStyle.Flat;
            btnCreditos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreditos.ForeColor = SystemColors.ButtonHighlight;
            btnCreditos.Image = (Image)resources.GetObject("btnCreditos.Image");
            btnCreditos.Location = new Point(4, 276);
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
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = SystemColors.ButtonHighlight;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.Location = new Point(4, 123);
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
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnConfiguracion.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfiguracion.ForeColor = SystemColors.ButtonHighlight;
            btnConfiguracion.Image = (Image)resources.GetObject("btnConfiguracion.Image");
            btnConfiguracion.Location = new Point(4, 582);
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
            panelMain.ForeColor = SystemColors.ButtonHighlight;
            panelMain.Location = new Point(138, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1300, 771);
            panelMain.TabIndex = 2;
            // 
            // panelFooter
            // 
            panelFooter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFooter.BackColor = Color.FromArgb(16, 22, 30);
            panelFooter.Controls.Add(txtDatetime);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.ForeColor = SystemColors.ButtonHighlight;
            panelFooter.Location = new Point(137, 773);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1301, 34);
            panelFooter.TabIndex = 3;
            // 
            // txtDatetime
            // 
            txtDatetime.AutoSize = true;
            txtDatetime.Dock = DockStyle.Right;
            txtDatetime.Font = new Font("Segoe UI Light", 14F, FontStyle.Bold);
            txtDatetime.Location = new Point(1124, 0);
            txtDatetime.Margin = new Padding(3, 3, 3, 0);
            txtDatetime.Name = "txtDatetime";
            txtDatetime.Size = new Size(177, 25);
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
            Controls.Add(panelFooter);
            Controls.Add(panelNavbar);
            Controls.Add(panelMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "PuntoDeVenta - Bedaqui";
            WindowState = FormWindowState.Maximized;
            panelNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelNavbar;
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
        private VentasControl ventas1;
        private ReportesControl reportes1;
        private ProductosControl productos1;
        private InventarioControl inventario1;
        private FacturasControl facturas1;
        private CreditosControl creditos1;
        private CorteControl corte1;
        private ConfiguracionControl configuracion1;
        private ComprasControl compras1;
        private ClientesControl clientes1;
        private Panel panelFooter;
        private Label txtDatetime;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;

        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        public void InitializeUserControls()
        {
            var clientesUserControl = new PuntoDeVenta.UserControls.ClientesControl();

            panelMain.Controls.Add(clientesUserControl);
        }
    }    
}