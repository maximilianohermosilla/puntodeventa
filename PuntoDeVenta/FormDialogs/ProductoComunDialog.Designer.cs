namespace PuntoDeVenta.FormDialogs
{
    partial class ProductoComunDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoComunDialog));
            labelDescripcion = new Label();
            txtDescripcion = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            labelCantidad = new Label();
            labelPrecio = new Label();
            labelOperator = new Label();
            SuspendLayout();
            // 
            // labelDescripcion
            // 
            resources.ApplyResources(labelDescripcion, "labelDescripcion");
            labelDescripcion.Name = "labelDescripcion";
            // 
            // txtDescripcion
            // 
            resources.ApplyResources(txtDescripcion, "txtDescripcion");
            txtDescripcion.Name = "txtDescripcion";
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
            // txtCantidad
            // 
            resources.ApplyResources(txtCantidad, "txtCantidad");
            txtCantidad.Name = "txtCantidad";
            // 
            // txtPrecio
            // 
            resources.ApplyResources(txtPrecio, "txtPrecio");
            txtPrecio.Name = "txtPrecio";
            // 
            // labelCantidad
            // 
            resources.ApplyResources(labelCantidad, "labelCantidad");
            labelCantidad.Name = "labelCantidad";
            // 
            // labelPrecio
            // 
            resources.ApplyResources(labelPrecio, "labelPrecio");
            labelPrecio.Name = "labelPrecio";
            // 
            // labelOperator
            // 
            resources.ApplyResources(labelOperator, "labelOperator");
            labelOperator.Name = "labelOperator";
            // 
            // ProductoComunDialog
            // 
            txtDescripcion.TabIndex = 0;
            txtCantidad.TabIndex = 1;
            txtPrecio.TabIndex = 2;
            btnAceptar.TabIndex = 3;
            btnCancelar.TabIndex = 4;

            AcceptButton = btnAceptar;
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            Controls.Add(labelOperator);
            Controls.Add(labelPrecio);
            Controls.Add(labelCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDescripcion);
            Controls.Add(labelDescripcion);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProductoComunDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelDescripcion;
        public TextBox txtDescripcion;
        public Button btnAceptar;
        public Button btnCancelar;
        public TextBox txtCantidad;
        public TextBox txtPrecio;
        public Label labelCantidad;
        public Label labelPrecio;
        public Label labelOperator;
    }
}