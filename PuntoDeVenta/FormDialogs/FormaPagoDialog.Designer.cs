namespace PuntoDeVenta.FormDialogs
{
    partial class FormaPagoDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPagoDialog));
            btnEfectivo = new Button();
            btnMercadoPago = new Button();
            SuspendLayout();
            // 
            // btnEfectivo
            // 
            btnEfectivo.BackColor = Color.FromArgb(0, 80, 200);
            btnEfectivo.BackgroundImage = Properties.Resources.payment_cash;
            resources.ApplyResources(btnEfectivo, "btnEfectivo");
            btnEfectivo.FlatAppearance.BorderColor = Color.Black;
            btnEfectivo.FlatAppearance.BorderSize = 0;
            btnEfectivo.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnEfectivo.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnEfectivo.ForeColor = SystemColors.ButtonHighlight;
            btnEfectivo.Name = "btnEfectivo";
            btnEfectivo.UseVisualStyleBackColor = false;
            btnEfectivo.Click += btnEfectivo_Click;
            // 
            // btnMercadoPago
            // 
            btnMercadoPago.BackColor = Color.FromArgb(0, 80, 200);
            btnMercadoPago.BackgroundImage = Properties.Resources.payment_mercadopago;
            resources.ApplyResources(btnMercadoPago, "btnMercadoPago");
            btnMercadoPago.FlatAppearance.BorderColor = Color.Black;
            btnMercadoPago.FlatAppearance.BorderSize = 0;
            btnMercadoPago.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnMercadoPago.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnMercadoPago.ForeColor = SystemColors.ButtonHighlight;
            btnMercadoPago.Name = "btnMercadoPago";
            btnMercadoPago.UseVisualStyleBackColor = false;
            btnMercadoPago.Click += btnMercadoPago_Click;
            // 
            // FormaPagoDialog
            // 
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 32, 40);
            Controls.Add(btnMercadoPago);
            Controls.Add(btnEfectivo);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormaPagoDialog";
            ResumeLayout(false);
        }

        #endregion

        public Button btnEfectivo;
        public Button btnMercadoPago;
    }
}