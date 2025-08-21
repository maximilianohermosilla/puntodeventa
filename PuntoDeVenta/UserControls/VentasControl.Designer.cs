namespace PuntoDeVenta.UserControls
{
    partial class VentasControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasControl));
            panel1 = new Panel();
            ventasTitle = new Label();
            labelCodigo = new Label();
            txtCodigo = new TextBox();
            btnVarios = new Button();
            btnComun = new Button();
            btnBuscar = new Button();
            btnEntradas = new Button();
            btnSalidas = new Button();
            btnPorMayor = new Button();
            btnVerificador = new Button();
            btnAgregarProducto = new Button();
            btnEliminarProducto = new Button();
            tabControlTickets = new TabControl();
            panel2 = new Panel();
            btnReimprimir = new Button();
            btnCobrar = new Button();
            btnVentasDevoluciones = new Button();
            panel3 = new Panel();
            labelTotal = new Label();
            btnAsignarCliente = new Button();
            btnEliminarTicket = new Button();
            btnNuevoTicket = new Button();
            btnCambiar = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.SeaGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ventasTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1447, 28);
            panel1.TabIndex = 0;
            // 
            // ventasTitle
            // 
            ventasTitle.AutoSize = true;
            ventasTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ventasTitle.ForeColor = SystemColors.ButtonHighlight;
            ventasTitle.Location = new Point(3, 0);
            ventasTitle.Name = "ventasTitle";
            ventasTitle.Size = new Size(81, 25);
            ventasTitle.TabIndex = 0;
            ventasTitle.Text = "VENTAS";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Segoe UI", 10F);
            labelCodigo.Location = new Point(7, 14);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(142, 19);
            labelCodigo.TabIndex = 1;
            labelCodigo.Text = "Código del producto: ";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(155, 14);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(483, 23);
            txtCodigo.TabIndex = 2;
            txtCodigo.KeyUp += txtCodigo_KeyPress;
            // 
            // btnVarios
            // 
            btnVarios.BackColor = Color.FromArgb(0, 80, 200);
            btnVarios.BackgroundImageLayout = ImageLayout.None;
            btnVarios.FlatAppearance.BorderColor = Color.Silver;
            btnVarios.FlatAppearance.BorderSize = 0;
            btnVarios.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnVarios.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnVarios.FlatStyle = FlatStyle.Flat;
            btnVarios.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVarios.ForeColor = SystemColors.ButtonHighlight;
            btnVarios.Image = (Image)resources.GetObject("btnVarios.Image");
            btnVarios.Location = new Point(4, 58);
            btnVarios.Name = "btnVarios";
            btnVarios.Size = new Size(122, 35);
            btnVarios.TabIndex = 3;
            btnVarios.Text = "Varios";
            btnVarios.TextAlign = ContentAlignment.MiddleRight;
            btnVarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVarios.UseVisualStyleBackColor = false;
            btnVarios.Click += btnVarios_Click;
            // 
            // btnComun
            // 
            btnComun.BackColor = Color.FromArgb(0, 80, 200);
            btnComun.BackgroundImageLayout = ImageLayout.None;
            btnComun.FlatAppearance.BorderColor = Color.Silver;
            btnComun.FlatAppearance.BorderSize = 0;
            btnComun.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnComun.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnComun.FlatStyle = FlatStyle.Flat;
            btnComun.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComun.ForeColor = SystemColors.ButtonHighlight;
            btnComun.Image = (Image)resources.GetObject("btnComun.Image");
            btnComun.Location = new Point(132, 58);
            btnComun.Name = "btnComun";
            btnComun.Size = new Size(122, 35);
            btnComun.TabIndex = 4;
            btnComun.Text = "Prod. Común";
            btnComun.TextAlign = ContentAlignment.MiddleRight;
            btnComun.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComun.UseVisualStyleBackColor = false;
            btnComun.Click += btnComun_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 80, 200);
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.FlatAppearance.BorderColor = Color.Silver;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(260, 58);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(122, 35);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "(F10) Buscar";
            btnBuscar.TextAlign = ContentAlignment.MiddleRight;
            btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEntradas
            // 
            btnEntradas.BackColor = Color.FromArgb(0, 80, 200);
            btnEntradas.BackgroundImageLayout = ImageLayout.None;
            btnEntradas.FlatAppearance.BorderColor = Color.Silver;
            btnEntradas.FlatAppearance.BorderSize = 0;
            btnEntradas.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnEntradas.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnEntradas.FlatStyle = FlatStyle.Flat;
            btnEntradas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntradas.ForeColor = SystemColors.ButtonHighlight;
            btnEntradas.Image = (Image)resources.GetObject("btnEntradas.Image");
            btnEntradas.Location = new Point(388, 58);
            btnEntradas.Name = "btnEntradas";
            btnEntradas.Size = new Size(122, 35);
            btnEntradas.TabIndex = 6;
            btnEntradas.Text = "(F7) Entradas";
            btnEntradas.TextAlign = ContentAlignment.MiddleRight;
            btnEntradas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEntradas.UseVisualStyleBackColor = false;
            // 
            // btnSalidas
            // 
            btnSalidas.BackColor = Color.FromArgb(0, 80, 200);
            btnSalidas.BackgroundImageLayout = ImageLayout.None;
            btnSalidas.FlatAppearance.BorderColor = Color.Silver;
            btnSalidas.FlatAppearance.BorderSize = 0;
            btnSalidas.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnSalidas.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnSalidas.FlatStyle = FlatStyle.Flat;
            btnSalidas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalidas.ForeColor = SystemColors.ButtonHighlight;
            btnSalidas.Image = (Image)resources.GetObject("btnSalidas.Image");
            btnSalidas.Location = new Point(516, 58);
            btnSalidas.Name = "btnSalidas";
            btnSalidas.Size = new Size(122, 35);
            btnSalidas.TabIndex = 7;
            btnSalidas.Text = "(F8) Salidas";
            btnSalidas.TextAlign = ContentAlignment.MiddleRight;
            btnSalidas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalidas.UseVisualStyleBackColor = false;
            // 
            // btnPorMayor
            // 
            btnPorMayor.BackColor = Color.FromArgb(0, 80, 200);
            btnPorMayor.BackgroundImageLayout = ImageLayout.None;
            btnPorMayor.FlatAppearance.BorderColor = Color.Silver;
            btnPorMayor.FlatAppearance.BorderSize = 0;
            btnPorMayor.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnPorMayor.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnPorMayor.FlatStyle = FlatStyle.Flat;
            btnPorMayor.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPorMayor.ForeColor = SystemColors.ButtonHighlight;
            btnPorMayor.Image = (Image)resources.GetObject("btnPorMayor.Image");
            btnPorMayor.Location = new Point(644, 58);
            btnPorMayor.Name = "btnPorMayor";
            btnPorMayor.Size = new Size(122, 35);
            btnPorMayor.TabIndex = 8;
            btnPorMayor.Text = "(F11) Por Mayor";
            btnPorMayor.TextAlign = ContentAlignment.MiddleRight;
            btnPorMayor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPorMayor.UseVisualStyleBackColor = false;
            // 
            // btnVerificador
            // 
            btnVerificador.BackColor = Color.FromArgb(0, 80, 200);
            btnVerificador.BackgroundImageLayout = ImageLayout.None;
            btnVerificador.FlatAppearance.BorderColor = Color.Silver;
            btnVerificador.FlatAppearance.BorderSize = 0;
            btnVerificador.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnVerificador.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnVerificador.FlatStyle = FlatStyle.Flat;
            btnVerificador.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerificador.ForeColor = SystemColors.ButtonHighlight;
            btnVerificador.Image = (Image)resources.GetObject("btnVerificador.Image");
            btnVerificador.Location = new Point(772, 58);
            btnVerificador.Name = "btnVerificador";
            btnVerificador.Size = new Size(122, 35);
            btnVerificador.TabIndex = 9;
            btnVerificador.Text = "(F9) Verificador";
            btnVerificador.TextAlign = ContentAlignment.MiddleRight;
            btnVerificador.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVerificador.UseVisualStyleBackColor = false;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(0, 80, 200);
            btnAgregarProducto.BackgroundImageLayout = ImageLayout.None;
            btnAgregarProducto.FlatAppearance.BorderColor = Color.Silver;
            btnAgregarProducto.FlatAppearance.BorderSize = 0;
            btnAgregarProducto.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnAgregarProducto.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarProducto.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarProducto.Image = (Image)resources.GetObject("btnAgregarProducto.Image");
            btnAgregarProducto.Location = new Point(644, 8);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(122, 35);
            btnAgregarProducto.TabIndex = 10;
            btnAgregarProducto.Text = "(ENTER) Añadir";
            btnAgregarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.FromArgb(0, 80, 200);
            btnEliminarProducto.BackgroundImageLayout = ImageLayout.None;
            btnEliminarProducto.FlatAppearance.BorderColor = Color.Silver;
            btnEliminarProducto.FlatAppearance.BorderSize = 0;
            btnEliminarProducto.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnEliminarProducto.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnEliminarProducto.FlatStyle = FlatStyle.Flat;
            btnEliminarProducto.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarProducto.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarProducto.Image = (Image)resources.GetObject("btnEliminarProducto.Image");
            btnEliminarProducto.Location = new Point(772, 8);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(122, 35);
            btnEliminarProducto.TabIndex = 11;
            btnEliminarProducto.Text = "(DEL) Borrar";
            btnEliminarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // tabControlTickets
            // 
            tabControlTickets.Dock = DockStyle.Fill;
            tabControlTickets.Location = new Point(0, 0);
            tabControlTickets.Name = "tabControlTickets";
            tabControlTickets.SelectedIndex = 0;
            tabControlTickets.Size = new Size(1445, 391);
            tabControlTickets.TabIndex = 12;
            tabControlTickets.SelectedIndexChanged += tabControlTickets_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.FromArgb(49, 66, 82);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnReimprimir);
            panel2.Controls.Add(btnCobrar);
            panel2.Controls.Add(btnVentasDevoluciones);
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = SystemColors.ButtonHighlight;
            panel2.Location = new Point(0, 561);
            panel2.Name = "panel2";
            panel2.Size = new Size(1447, 43);
            panel2.TabIndex = 13;
            // 
            // btnReimprimir
            // 
            btnReimprimir.BackColor = Color.FromArgb(0, 80, 200);
            btnReimprimir.BackgroundImageLayout = ImageLayout.None;
            btnReimprimir.FlatAppearance.BorderColor = Color.Silver;
            btnReimprimir.FlatAppearance.BorderSize = 0;
            btnReimprimir.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnReimprimir.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnReimprimir.FlatStyle = FlatStyle.Flat;
            btnReimprimir.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReimprimir.ForeColor = SystemColors.ButtonHighlight;
            btnReimprimir.Image = (Image)resources.GetObject("btnReimprimir.Image");
            btnReimprimir.Location = new Point(3, 3);
            btnReimprimir.Name = "btnReimprimir";
            btnReimprimir.Size = new Size(223, 36);
            btnReimprimir.TabIndex = 16;
            btnReimprimir.Text = "Reimprimir Último Ticket";
            btnReimprimir.TextAlign = ContentAlignment.MiddleRight;
            btnReimprimir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReimprimir.UseVisualStyleBackColor = false;
            // 
            // btnCobrar
            // 
            btnCobrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCobrar.BackColor = Color.FromArgb(0, 80, 200);
            btnCobrar.BackgroundImageLayout = ImageLayout.None;
            btnCobrar.FlatAppearance.BorderColor = Color.Silver;
            btnCobrar.FlatAppearance.BorderSize = 0;
            btnCobrar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnCobrar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCobrar.FlatStyle = FlatStyle.Flat;
            btnCobrar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCobrar.ForeColor = SystemColors.ButtonHighlight;
            btnCobrar.Image = (Image)resources.GetObject("btnCobrar.Image");
            btnCobrar.Location = new Point(1282, 3);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(160, 34);
            btnCobrar.TabIndex = 25;
            btnCobrar.Text = "(F12) Cobrar";
            btnCobrar.TextAlign = ContentAlignment.MiddleRight;
            btnCobrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCobrar.UseVisualStyleBackColor = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // btnVentasDevoluciones
            // 
            btnVentasDevoluciones.BackColor = Color.FromArgb(0, 80, 200);
            btnVentasDevoluciones.BackgroundImageLayout = ImageLayout.None;
            btnVentasDevoluciones.FlatAppearance.BorderColor = Color.Silver;
            btnVentasDevoluciones.FlatAppearance.BorderSize = 0;
            btnVentasDevoluciones.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnVentasDevoluciones.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnVentasDevoluciones.FlatStyle = FlatStyle.Flat;
            btnVentasDevoluciones.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentasDevoluciones.ForeColor = SystemColors.ButtonHighlight;
            btnVentasDevoluciones.Image = (Image)resources.GetObject("btnVentasDevoluciones.Image");
            btnVentasDevoluciones.Location = new Point(232, 3);
            btnVentasDevoluciones.Name = "btnVentasDevoluciones";
            btnVentasDevoluciones.Size = new Size(222, 36);
            btnVentasDevoluciones.TabIndex = 15;
            btnVentasDevoluciones.Text = "Ventas del día y Devoluciones";
            btnVentasDevoluciones.TextAlign = ContentAlignment.MiddleRight;
            btnVentasDevoluciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVentasDevoluciones.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = Color.FromArgb(49, 66, 82);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(labelTotal);
            panel3.Controls.Add(btnAsignarCliente);
            panel3.Controls.Add(btnEliminarTicket);
            panel3.Controls.Add(btnNuevoTicket);
            panel3.Controls.Add(btnCambiar);
            panel3.Dock = DockStyle.Bottom;
            panel3.ForeColor = SystemColors.ButtonHighlight;
            panel3.Location = new Point(0, 520);
            panel3.Name = "panel3";
            panel3.Size = new Size(1447, 41);
            panel3.TabIndex = 14;
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelTotal.BackColor = Color.White;
            labelTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.ForeColor = SystemColors.ActiveCaptionText;
            labelTotal.Location = new Point(1282, 3);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(160, 34);
            labelTotal.TabIndex = 12;
            labelTotal.Text = "$ 0.00";
            labelTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAsignarCliente
            // 
            btnAsignarCliente.BackColor = Color.FromArgb(0, 80, 200);
            btnAsignarCliente.BackgroundImageLayout = ImageLayout.None;
            btnAsignarCliente.FlatAppearance.BorderColor = Color.Silver;
            btnAsignarCliente.FlatAppearance.BorderSize = 0;
            btnAsignarCliente.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnAsignarCliente.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnAsignarCliente.FlatStyle = FlatStyle.Flat;
            btnAsignarCliente.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsignarCliente.ForeColor = SystemColors.ButtonHighlight;
            btnAsignarCliente.Image = (Image)resources.GetObject("btnAsignarCliente.Image");
            btnAsignarCliente.Location = new Point(396, 2);
            btnAsignarCliente.Name = "btnAsignarCliente";
            btnAsignarCliente.Size = new Size(122, 35);
            btnAsignarCliente.TabIndex = 24;
            btnAsignarCliente.Text = "Asignar Cliente";
            btnAsignarCliente.TextAlign = ContentAlignment.MiddleRight;
            btnAsignarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAsignarCliente.UseVisualStyleBackColor = false;
            btnAsignarCliente.Click += btnAsignarCliente_Click;
            // 
            // btnEliminarTicket
            // 
            btnEliminarTicket.BackColor = Color.FromArgb(0, 80, 200);
            btnEliminarTicket.BackgroundImageLayout = ImageLayout.None;
            btnEliminarTicket.FlatAppearance.BorderColor = Color.Silver;
            btnEliminarTicket.FlatAppearance.BorderSize = 0;
            btnEliminarTicket.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnEliminarTicket.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnEliminarTicket.FlatStyle = FlatStyle.Flat;
            btnEliminarTicket.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarTicket.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarTicket.Image = (Image)resources.GetObject("btnEliminarTicket.Image");
            btnEliminarTicket.Location = new Point(268, 2);
            btnEliminarTicket.Name = "btnEliminarTicket";
            btnEliminarTicket.Size = new Size(122, 35);
            btnEliminarTicket.TabIndex = 23;
            btnEliminarTicket.Text = "Eliminar Ticket";
            btnEliminarTicket.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarTicket.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarTicket.UseVisualStyleBackColor = false;
            btnEliminarTicket.Click += btnEliminarTicket_Click;
            // 
            // btnNuevoTicket
            // 
            btnNuevoTicket.BackColor = Color.FromArgb(0, 80, 200);
            btnNuevoTicket.BackgroundImageLayout = ImageLayout.None;
            btnNuevoTicket.FlatAppearance.BorderColor = Color.Silver;
            btnNuevoTicket.FlatAppearance.BorderSize = 0;
            btnNuevoTicket.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnNuevoTicket.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnNuevoTicket.FlatStyle = FlatStyle.Flat;
            btnNuevoTicket.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoTicket.ForeColor = SystemColors.ButtonHighlight;
            btnNuevoTicket.Image = (Image)resources.GetObject("btnNuevoTicket.Image");
            btnNuevoTicket.Location = new Point(132, 2);
            btnNuevoTicket.Name = "btnNuevoTicket";
            btnNuevoTicket.Size = new Size(130, 35);
            btnNuevoTicket.TabIndex = 22;
            btnNuevoTicket.Text = "Nuevo Ticket";
            btnNuevoTicket.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoTicket.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevoTicket.UseVisualStyleBackColor = false;
            btnNuevoTicket.Click += btnPendiente_Click;
            // 
            // btnCambiar
            // 
            btnCambiar.BackColor = Color.FromArgb(0, 80, 200);
            btnCambiar.BackgroundImageLayout = ImageLayout.None;
            btnCambiar.FlatAppearance.BorderColor = Color.Silver;
            btnCambiar.FlatAppearance.BorderSize = 0;
            btnCambiar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnCambiar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnCambiar.FlatStyle = FlatStyle.Flat;
            btnCambiar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCambiar.ForeColor = SystemColors.ButtonHighlight;
            btnCambiar.Image = (Image)resources.GetObject("btnCambiar.Image");
            btnCambiar.Location = new Point(3, 3);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(122, 35);
            btnCambiar.TabIndex = 12;
            btnCambiar.Text = "(F5) Cambiar";
            btnCambiar.TextAlign = ContentAlignment.MiddleRight;
            btnCambiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCambiar.UseVisualStyleBackColor = false;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // panel4
            // 
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BackColor = Color.FromArgb(26, 32, 40);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtCodigo);
            panel4.Controls.Add(labelCodigo);
            panel4.Controls.Add(btnVarios);
            panel4.Controls.Add(btnComun);
            panel4.Controls.Add(btnEliminarProducto);
            panel4.Controls.Add(btnBuscar);
            panel4.Controls.Add(btnAgregarProducto);
            panel4.Controls.Add(btnEntradas);
            panel4.Controls.Add(btnVerificador);
            panel4.Controls.Add(btnSalidas);
            panel4.Controls.Add(btnPorMayor);
            panel4.Dock = DockStyle.Top;
            panel4.ForeColor = SystemColors.ButtonHighlight;
            panel4.Location = new Point(0, 28);
            panel4.Name = "panel4";
            panel4.Size = new Size(1447, 99);
            panel4.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(tabControlTickets);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 127);
            panel5.Name = "panel5";
            panel5.Size = new Size(1447, 393);
            panel5.TabIndex = 15;
            // 
            // VentasControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "VentasControl";
            Size = new Size(1447, 604);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label ventasTitle;
        private Label labelCodigo;
        private TextBox txtCodigo;
        public Button btnVarios;
        public Button btnComun;
        public Button btnBuscar;
        public Button btnEntradas;
        public Button btnSalidas;
        public Button btnPorMayor;
        public Button btnVerificador;
        public Button btnAgregarProducto;
        public Button btnEliminarProducto;
        private TabControl tabControlTickets;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        public Button button14;
        public Button btnEliminarTicket;
        public Button btnTicketPendiente;
        public Button btnCambiarTicket;
        public Button btnCambiar;
        public Button btnAsignarCliente;
        public Button btnNuevoTicket;
        public Button btnCobrar;
        public Button btnReimprimir;
        public Button btnVentasDevoluciones;
        private Label labelTotal;
    }
}
