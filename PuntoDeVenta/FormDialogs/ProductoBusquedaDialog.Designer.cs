namespace PuntoDeVenta.FormDialogs
{
    partial class ProductoBusquedaDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoBusquedaDialog));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtDescripcion = new TextBox();
            btnCancelar = new Button();
            btnBuscar = new Button();
            dvBusqueda = new DataGridView();
            labelNotFound = new Label();
            txtCantidad = new NumericUpDown();
            labelCantidad = new Label();
            ((System.ComponentModel.ISupportInitialize)dvBusqueda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            resources.ApplyResources(txtDescripcion, "txtDescripcion");
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.KeyUp += txtEtiqueta_KeyPress;
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
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 80, 200);
            resources.ApplyResources(btnBuscar, "btnBuscar");
            btnBuscar.FlatAppearance.BorderColor = Color.Silver;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.Navy;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.Teal;
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Name = "btnBuscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
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
            // ProductoBusquedaDialog
            // 
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            Controls.Add(txtCantidad);
            Controls.Add(labelCantidad);
            Controls.Add(labelNotFound);
            Controls.Add(dvBusqueda);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(txtDescripcion);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "ProductoBusquedaDialog";
            KeyDown += ProductoBusquedaDialog_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dvBusqueda).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox txtDescripcion;
        public Button btnAceptar;
        public Button btnCancelar;
        public Button btnBuscar;
        private DataGridView dvBusqueda;
        private Label labelNotFound;
        public NumericUpDown txtCantidad;
        public Label labelCantidad;
    }
}