namespace PuntoDeVenta
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            panel1 = new Panel();
            ventasTitle = new Label();
            label1 = new Label();
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            btnReimprimir = new Button();
            btnVentasDevoluciones = new Button();
            panel3 = new Panel();
            btnCobrar = new Button();
            btnAsignarCliente = new Button();
            btnEliminarTicket = new Button();
            btnPendiente = new Button();
            btnCambiar = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(ventasTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1449, 28);
            panel1.TabIndex = 0;
            // 
            // ventasTitle
            // 
            ventasTitle.AutoSize = true;
            ventasTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ventasTitle.ForeColor = SystemColors.ButtonHighlight;
            ventasTitle.Location = new Point(3, 0);
            ventasTitle.Name = "ventasTitle";
            ventasTitle.Size = new Size(153, 25);
            ventasTitle.TabIndex = 0;
            ventasTitle.Text = "VENTA - Ticket 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(7, 14);
            label1.Name = "label1";
            label1.Size = new Size(142, 19);
            label1.TabIndex = 1;
            label1.Text = "Código del producto: ";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(155, 14);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(483, 23);
            txtCodigo.TabIndex = 2;
            // 
            // btnVarios
            // 
            btnVarios.BackColor = SystemColors.ButtonHighlight;
            btnVarios.BackgroundImageLayout = ImageLayout.None;
            btnVarios.FlatAppearance.BorderColor = Color.Silver;
            btnVarios.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnVarios.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnVarios.FlatStyle = FlatStyle.Flat;
            btnVarios.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVarios.Image = (Image)resources.GetObject("btnVarios.Image");
            btnVarios.Location = new Point(4, 58);
            btnVarios.Name = "btnVarios";
            btnVarios.Size = new Size(122, 35);
            btnVarios.TabIndex = 3;
            btnVarios.Text = "(INS) Varios";
            btnVarios.TextAlign = ContentAlignment.MiddleRight;
            btnVarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVarios.UseVisualStyleBackColor = false;
            // 
            // btnComun
            // 
            btnComun.BackColor = SystemColors.ButtonHighlight;
            btnComun.BackgroundImageLayout = ImageLayout.None;
            btnComun.FlatAppearance.BorderColor = Color.Silver;
            btnComun.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnComun.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnComun.FlatStyle = FlatStyle.Flat;
            btnComun.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComun.Image = new Bitmap(Properties.Resources.product_add, 24, 24);
            btnComun.Location = new Point(132, 58);
            btnComun.Name = "btnComun";
            btnComun.Size = new Size(122, 35);
            btnComun.TabIndex = 4;
            btnComun.Text = "(INI) Producto";
            btnComun.TextAlign = ContentAlignment.MiddleRight;
            btnComun.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComun.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ButtonHighlight;
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.FlatAppearance.BorderColor = Color.Silver;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Image = new Bitmap(Properties.Resources.search, 24, 24);
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
            btnEntradas.BackColor = SystemColors.ButtonHighlight;
            btnEntradas.BackgroundImageLayout = ImageLayout.None;
            btnEntradas.FlatAppearance.BorderColor = Color.Silver;
            btnEntradas.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnEntradas.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnEntradas.FlatStyle = FlatStyle.Flat;
            btnEntradas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntradas.Image = new Bitmap(Properties.Resources.cash_in, 24, 24);
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
            btnSalidas.BackColor = SystemColors.ButtonHighlight;
            btnSalidas.BackgroundImageLayout = ImageLayout.None;
            btnSalidas.FlatAppearance.BorderColor = Color.Silver;
            btnSalidas.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnSalidas.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnSalidas.FlatStyle = FlatStyle.Flat;
            btnSalidas.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalidas.Image = new Bitmap(Properties.Resources.cash_out, 24, 24);
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
            btnPorMayor.BackColor = SystemColors.ButtonHighlight;
            btnPorMayor.BackgroundImageLayout = ImageLayout.None;
            btnPorMayor.FlatAppearance.BorderColor = Color.Silver;
            btnPorMayor.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnPorMayor.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnPorMayor.FlatStyle = FlatStyle.Flat;
            btnPorMayor.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPorMayor.Image = new Bitmap(Properties.Resources.category_add, 24, 24);
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
            btnVerificador.BackColor = SystemColors.ButtonHighlight;
            btnVerificador.BackgroundImageLayout = ImageLayout.None;
            btnVerificador.FlatAppearance.BorderColor = Color.Silver;
            btnVerificador.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnVerificador.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnVerificador.FlatStyle = FlatStyle.Flat;
            btnVerificador.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerificador.Image = new Bitmap(Properties.Resources.barcode_read_01, 24, 24);
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
            btnAgregarProducto.BackColor = SystemColors.ButtonHighlight;
            btnAgregarProducto.BackgroundImageLayout = ImageLayout.None;
            btnAgregarProducto.FlatAppearance.BorderColor = Color.Silver;
            btnAgregarProducto.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnAgregarProducto.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarProducto.Image = new Bitmap(Properties.Resources.product_add, 24, 24);
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
            btnEliminarProducto.BackColor = SystemColors.ButtonHighlight;
            btnEliminarProducto.BackgroundImageLayout = ImageLayout.None;
            btnEliminarProducto.FlatAppearance.BorderColor = Color.Silver;
            btnEliminarProducto.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnEliminarProducto.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnEliminarProducto.FlatStyle = FlatStyle.Flat;
            btnEliminarProducto.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarProducto.Image = new Bitmap(Properties.Resources.product_delete, 24, 24);
            btnEliminarProducto.Location = new Point(772, 8);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(122, 35);
            btnEliminarProducto.TabIndex = 11;
            btnEliminarProducto.Text = "(DEL) Borrar";
            btnEliminarProducto.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1449, 395);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1441, 367);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ticket 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1441, 367);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ticket 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnReimprimir);
            panel2.Controls.Add(btnVentasDevoluciones);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 563);
            panel2.Name = "panel2";
            panel2.Size = new Size(1449, 43);
            panel2.TabIndex = 13;
            // 
            // btnReimprimir
            // 
            btnReimprimir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnReimprimir.BackColor = SystemColors.ButtonHighlight;
            btnReimprimir.BackgroundImageLayout = ImageLayout.None;
            btnReimprimir.FlatAppearance.BorderColor = Color.Silver;
            btnReimprimir.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnReimprimir.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnReimprimir.FlatStyle = FlatStyle.Flat;
            btnReimprimir.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReimprimir.Image = new Bitmap(Properties.Resources.print, 24, 24);
            btnReimprimir.Location = new Point(993, 2);
            btnReimprimir.Name = "btnReimprimir";
            btnReimprimir.Size = new Size(223, 36);
            btnReimprimir.TabIndex = 16;
            btnReimprimir.Text = "Reimprimir Último Ticket";
            btnReimprimir.TextAlign = ContentAlignment.MiddleRight;
            btnReimprimir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReimprimir.UseVisualStyleBackColor = false;
            // 
            // btnVentasDevoluciones
            // 
            btnVentasDevoluciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnVentasDevoluciones.BackColor = SystemColors.ButtonHighlight;
            btnVentasDevoluciones.BackgroundImageLayout = ImageLayout.None;
            btnVentasDevoluciones.FlatAppearance.BorderColor = Color.Silver;
            btnVentasDevoluciones.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnVentasDevoluciones.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnVentasDevoluciones.FlatStyle = FlatStyle.Flat;
            btnVentasDevoluciones.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentasDevoluciones.Image = new Bitmap(Properties.Resources.news, 24, 24);
            btnVentasDevoluciones.Location = new Point(1222, 2);
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
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnCobrar);
            panel3.Controls.Add(btnAsignarCliente);
            panel3.Controls.Add(btnEliminarTicket);
            panel3.Controls.Add(btnPendiente);
            panel3.Controls.Add(btnCambiar);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 522);
            panel3.Name = "panel3";
            panel3.Size = new Size(1449, 41);
            panel3.TabIndex = 14;
            // 
            // btnCobrar
            // 
            btnCobrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnCobrar.BackColor = SystemColors.ButtonHighlight;
            btnCobrar.BackgroundImageLayout = ImageLayout.None;
            btnCobrar.FlatAppearance.BorderColor = Color.Silver;
            btnCobrar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnCobrar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnCobrar.FlatStyle = FlatStyle.Flat;
            btnCobrar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCobrar.Image = new Bitmap(Properties.Resources.ticket, 24, 24);
            btnCobrar.Location = new Point(1323, 2);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(122, 34);
            btnCobrar.TabIndex = 25;
            btnCobrar.Text = "(F12) Cobrar";
            btnCobrar.TextAlign = ContentAlignment.MiddleRight;
            btnCobrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCobrar.UseVisualStyleBackColor = false;
            // 
            // btnAsignarCliente
            // 
            btnAsignarCliente.BackColor = SystemColors.ButtonHighlight;
            btnAsignarCliente.BackgroundImageLayout = ImageLayout.None;
            btnAsignarCliente.FlatAppearance.BorderColor = Color.Silver;
            btnAsignarCliente.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnAsignarCliente.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAsignarCliente.FlatStyle = FlatStyle.Flat;
            btnAsignarCliente.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsignarCliente.Image = new Bitmap(Properties.Resources.person_add, 24, 24);
            btnAsignarCliente.Location = new Point(388, 2);
            btnAsignarCliente.Name = "btnAsignarCliente";
            btnAsignarCliente.Size = new Size(122, 35);
            btnAsignarCliente.TabIndex = 24;
            btnAsignarCliente.Text = "Asignar Cliente";
            btnAsignarCliente.TextAlign = ContentAlignment.MiddleRight;
            btnAsignarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAsignarCliente.UseVisualStyleBackColor = false;
            // 
            // btnEliminarTicket
            // 
            btnEliminarTicket.BackColor = SystemColors.ButtonHighlight;
            btnEliminarTicket.BackgroundImageLayout = ImageLayout.None;
            btnEliminarTicket.FlatAppearance.BorderColor = Color.Silver;
            btnEliminarTicket.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnEliminarTicket.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnEliminarTicket.FlatStyle = FlatStyle.Flat;
            btnEliminarTicket.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarTicket.Image = new Bitmap(Properties.Resources.list_block, 24, 24);
            btnEliminarTicket.Location = new Point(260, 2);
            btnEliminarTicket.Name = "btnEliminarTicket";
            btnEliminarTicket.Size = new Size(122, 35);
            btnEliminarTicket.TabIndex = 23;
            btnEliminarTicket.Text = "Eliminar Ticket";
            btnEliminarTicket.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarTicket.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarTicket.UseVisualStyleBackColor = false;
            // 
            // btnPendiente
            // 
            btnPendiente.BackColor = SystemColors.ButtonHighlight;
            btnPendiente.BackgroundImageLayout = ImageLayout.None;
            btnPendiente.FlatAppearance.BorderColor = Color.Silver;
            btnPendiente.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnPendiente.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnPendiente.FlatStyle = FlatStyle.Flat;
            btnPendiente.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPendiente.Image = new Bitmap(Properties.Resources.list_add, 24, 24);
            btnPendiente.Location = new Point(132, 2);
            btnPendiente.Name = "btnPendiente";
            btnPendiente.Size = new Size(122, 35);
            btnPendiente.TabIndex = 22;
            btnPendiente.Text = "(F6) Pendiente";
            btnPendiente.TextAlign = ContentAlignment.MiddleRight;
            btnPendiente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPendiente.UseVisualStyleBackColor = false;
            // 
            // btnCambiar
            // 
            btnCambiar.BackColor = SystemColors.ButtonHighlight;
            btnCambiar.BackgroundImageLayout = ImageLayout.None;
            btnCambiar.FlatAppearance.BorderColor = Color.Silver;
            btnCambiar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnCambiar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnCambiar.FlatStyle = FlatStyle.Flat;
            btnCambiar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCambiar.Image = new Bitmap(Properties.Resources.refresh, 24, 24);
            btnCambiar.Location = new Point(4, 2);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(122, 35);
            btnCambiar.TabIndex = 12;
            btnCambiar.Text = "(F5) Cambiar";
            btnCambiar.TextAlign = ContentAlignment.MiddleRight;
            btnCambiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCambiar.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtCodigo);
            panel4.Controls.Add(label1);
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
            panel4.Location = new Point(0, 28);
            panel4.Name = "panel4";
            panel4.Size = new Size(1449, 99);
            panel4.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.Controls.Add(tabControl1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 127);
            panel5.Name = "panel5";
            panel5.Size = new Size(1449, 395);
            panel5.TabIndex = 15;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Ventas";
            Size = new Size(1449, 606);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
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
        private Label label1;
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
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
        public Button btnPendiente;
        public Button btnCobrar;
        public Button btnReimprimir;
        public Button btnVentasDevoluciones;
    }
}
