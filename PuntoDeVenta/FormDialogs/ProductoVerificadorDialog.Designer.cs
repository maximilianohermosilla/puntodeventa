namespace PuntoDeVenta.FormDialogs
{
    partial class ProductoVerificadorDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoVerificadorDialog));
            labelProducto = new Label();
            txtEtiqueta = new TextBox();
            btnCancelar = new Button();
            labelPrecioProducto = new Label();
            labelNombreProducto = new Label();
            panel1 = new Panel();
            btnBuscar = new Button();
            panel1.SuspendLayout();
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
            txtEtiqueta.KeyUp += txtEtiqueta_KeyPress;
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
            // labelPrecioProducto
            // 
            resources.ApplyResources(labelPrecioProducto, "labelPrecioProducto");
            labelPrecioProducto.ForeColor = SystemColors.ActiveCaptionText;
            labelPrecioProducto.Name = "labelPrecioProducto";
            // 
            // labelNombreProducto
            // 
            resources.ApplyResources(labelNombreProducto, "labelNombreProducto");
            labelNombreProducto.ForeColor = SystemColors.ActiveCaptionText;
            labelNombreProducto.Name = "labelNombreProducto";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(labelNombreProducto);
            panel1.Controls.Add(labelPrecioProducto);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
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
            // ProductoVerificadorDialog
            // 
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            Controls.Add(btnBuscar);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(txtEtiqueta);
            Controls.Add(labelProducto);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "ProductoVerificadorDialog";
            KeyDown += ProductoVerificadorDialog_KeyDown;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelProducto;
        public TextBox txtEtiqueta;
        public Button btnAceptar;
        public Button btnCancelar;
        public Label labelPrecioProducto;
        public Label labelNombreProducto;
        private Panel panel1;
        public Button btnBuscar;
    }
}