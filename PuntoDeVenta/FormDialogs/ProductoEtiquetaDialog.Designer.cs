namespace PuntoDeVenta
{
    partial class ProductoEtiquetaDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoEtiquetaDialog));
            labelProducto = new Label();
            txtEtiqueta = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // labelProducto
            // 
            resources.ApplyResources(labelProducto, "labelProducto");
            labelProducto.Name = "labelProducto";
            // 
            // txtEtiqueta
            // 
            resources.ApplyResources(txtEtiqueta, "txtEtiqueta");
            txtEtiqueta.Name = "txtEtiqueta";
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
            // ProductoEtiquetaDialog
            // 
            AcceptButton = btnAceptar;
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtEtiqueta);
            Controls.Add(labelProducto);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ProductoEtiquetaDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelProducto;
        public TextBox txtEtiqueta;
        public Button btnAceptar;
        public Button btnCancelar;
    }
}