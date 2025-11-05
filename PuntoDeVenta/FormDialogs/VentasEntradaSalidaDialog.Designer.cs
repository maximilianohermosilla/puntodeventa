namespace PuntoDeVenta.FormDialogs
{
    partial class VentasEntradaSalidaDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasEntradaSalidaDialog));
            txtDescripcion = new TextBox();
            txtCantidad = new NumericUpDown();
            labelCantidad = new Label();
            labelDescripcion = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            comboFormaPago = new ComboBox();
            labelFormaPago = new Label();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            resources.ApplyResources(txtDescripcion, "txtDescripcion");
            txtDescripcion.Name = "txtDescripcion";
            // 
            // txtCantidad
            // 
            resources.ApplyResources(txtCantidad, "txtCantidad");
            txtCantidad.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            txtCantidad.Name = "txtCantidad";
            // 
            // labelCantidad
            // 
            resources.ApplyResources(labelCantidad, "labelCantidad");
            labelCantidad.Name = "labelCantidad";
            // 
            // labelDescripcion
            // 
            resources.ApplyResources(labelDescripcion, "labelDescripcion");
            labelDescripcion.Name = "labelDescripcion";
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
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(0, 80, 200);
            resources.ApplyResources(btnAceptar, "btnAceptar");
            btnAceptar.FlatAppearance.BorderColor = Color.Black;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnAceptar.ForeColor = SystemColors.ButtonHighlight;
            btnAceptar.Name = "btnAceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // comboFormaPago
            // 
            comboFormaPago.FormattingEnabled = true;
            resources.ApplyResources(comboFormaPago, "comboFormaPago");
            comboFormaPago.Name = "comboFormaPago";
            // 
            // labelFormaPago
            // 
            resources.ApplyResources(labelFormaPago, "labelFormaPago");
            labelFormaPago.Name = "labelFormaPago";
            // 
            // VentasEntradaSalidaDialog
            // 
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            Controls.Add(labelFormaPago);
            Controls.Add(comboFormaPago);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(labelDescripcion);
            Controls.Add(txtCantidad);
            Controls.Add(labelCantidad);
            Controls.Add(txtDescripcion);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "VentasEntradaSalidaDialog";
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox txtDescripcion;
        public NumericUpDown txtCantidad;
        public Label labelCantidad;
        public Label labelDescripcion;
        public Button btnCancelar;
        public Button btnAceptar;
        public ComboBox comboFormaPago;
        public Label labelFormaPago;
    }
}