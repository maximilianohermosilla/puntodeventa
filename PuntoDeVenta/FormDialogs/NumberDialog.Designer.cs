namespace PuntoDeVenta.FormDialogs
{
    partial class NumberDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberDialog));
            labelHeader = new Label();
            txtNumber = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // labelHeader
            // 
            resources.ApplyResources(labelHeader, "labelHeader");
            labelHeader.Name = "labelHeader";
            labelHeader.Tag = "";
            // 
            // txtNumber
            // 
            resources.ApplyResources(txtNumber, "txtNumber");
            txtNumber.Name = "txtNumber";
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
            // NumberDialog
            // 
            AcceptButton = btnAceptar;
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNumber);
            Controls.Add(labelHeader);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NumberDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelHeader;
        public TextBox txtNumber;
        public Button btnAceptar;
        public Button btnCancelar;
    }
}