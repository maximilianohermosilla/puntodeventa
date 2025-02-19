using PuntoDeVenta.Properties;

namespace PuntoDeVenta.UserControls.CommonControls
{
    partial class EtiquetaControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EtiquetaControl));
            labelProducto = new Label();
            txtEtiqueta = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // labelProducto
            // 
            labelProducto.AutoSize = true;
            labelProducto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProducto.Location = new Point(226, 42);
            labelProducto.Name = "labelProducto";
            labelProducto.Size = new Size(120, 32);
            labelProducto.TabIndex = 0;
            labelProducto.Text = "Producto";
            // 
            // txtEtiqueta
            // 
            txtEtiqueta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEtiqueta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEtiqueta.Location = new Point(148, 100);
            txtEtiqueta.Name = "txtEtiqueta";
            txtEtiqueta.Size = new Size(274, 25);
            txtEtiqueta.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.ButtonHighlight;
            btnAceptar.BackgroundImageLayout = ImageLayout.None;
            btnAceptar.FlatAppearance.BorderColor = Color.Black;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.Image = (Image)resources.GetObject("btnAceptar.Image");
            btnAceptar.Location = new Point(210, 149);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(136, 35);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Guardar Producto";
            btnAceptar.TextAlign = ContentAlignment.MiddleRight;
            btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // EtiquetaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAceptar);
            Controls.Add(txtEtiqueta);
            Controls.Add(labelProducto);
            Name = "EtiquetaControl";
            Size = new Size(553, 253);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProducto;
        private TextBox txtEtiqueta;
        private Button btnAceptar;
    }
}
