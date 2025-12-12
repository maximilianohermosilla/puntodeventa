namespace PuntoDeVenta.FormDialogs
{
    partial class ProductoBusquedaCategoriaDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoBusquedaCategoriaDialog));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnCancelar = new Button();
            dvBusqueda = new DataGridView();
            labelNotFound = new Label();
            txtCantidad = new NumericUpDown();
            labelCantidad = new Label();
            labelCategoria = new Label();
            comboCategoria = new ComboBox();
            btnAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)dvBusqueda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(0, 80, 200);
            resources.ApplyResources(btnCancelar, "btnCancelar");
            btnCancelar.FlatAppearance.BorderColor = Color.Black;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dvBusqueda
            // 
            resources.ApplyResources(dvBusqueda, "dvBusqueda");
            dvBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvBusqueda.BackgroundColor = Color.FromArgb(49, 66, 82);
            dvBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dvBusqueda.DefaultCellStyle = dataGridViewCellStyle1;
            dvBusqueda.Name = "dvBusqueda";
            dvBusqueda.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dvBusqueda.CellClick += dvBusqueda_CellClick;
            dvBusqueda.CellDoubleClick += dvBusqueda_CellDoubleClick;
            // 
            // labelNotFound
            // 
            resources.ApplyResources(labelNotFound, "labelNotFound");
            labelNotFound.Name = "labelNotFound";
            // 
            // txtCantidad
            // 
            resources.ApplyResources(txtCantidad, "txtCantidad");
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelCantidad
            // 
            resources.ApplyResources(labelCantidad, "labelCantidad");
            labelCantidad.Name = "labelCantidad";
            // 
            // labelCategoria
            // 
            resources.ApplyResources(labelCategoria, "labelCategoria");
            labelCategoria.Name = "labelCategoria";
            // 
            // comboCategoria
            // 
            comboCategoria.FormattingEnabled = true;
            resources.ApplyResources(comboCategoria, "comboCategoria");
            comboCategoria.Name = "comboCategoria";
            comboCategoria.SelectedIndexChanged += comboCategoria_SelectedIndexChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(0, 80, 200);
            resources.ApplyResources(btnAceptar, "btnAceptar");
            btnAceptar.FlatAppearance.BorderColor = Color.Black;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAceptar.ForeColor = SystemColors.ButtonHighlight;
            btnAceptar.Image = Properties.Resources.check_button;
            btnAceptar.Name = "btnAceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // ProductoBusquedaCategoriaDialog
            // 
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            Controls.Add(btnAceptar);
            Controls.Add(comboCategoria);
            Controls.Add(labelCategoria);
            Controls.Add(txtCantidad);
            Controls.Add(labelCantidad);
            Controls.Add(labelNotFound);
            Controls.Add(dvBusqueda);
            Controls.Add(btnCancelar);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "ProductoBusquedaCategoriaDialog";
            KeyDown += ProductoBusquedaCategoriaDialog_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dvBusqueda).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btnCancelar;
        private DataGridView dvBusqueda;
        private Label labelNotFound;
        public NumericUpDown txtCantidad;
        public Label labelCantidad;
        public Label labelCategoria;
        private ComboBox comboCategoria;
        public Button btnAceptar;
    }
}