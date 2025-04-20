namespace PuntoDeVenta
{
    partial class ToastForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToastForm));
            panelToastBorder = new Panel();
            pictureToastIcon = new PictureBox();
            labelToastTitle = new Label();
            labelToastMessage = new Label();
            timerToast = new System.Windows.Forms.Timer(components);
            toastHide = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureToastIcon).BeginInit();
            SuspendLayout();
            // 
            // panelToastBorder
            // 
            panelToastBorder.BackColor = Color.FromArgb(57, 155, 53);
            panelToastBorder.Location = new Point(-6, -6);
            panelToastBorder.Name = "panelToastBorder";
            panelToastBorder.Size = new Size(18, 72);
            panelToastBorder.TabIndex = 0;
            // 
            // pictureToastIcon
            // 
            pictureToastIcon.Image = Properties.Resources.check_ok;
            pictureToastIcon.Location = new Point(18, 12);
            pictureToastIcon.Name = "pictureToastIcon";
            pictureToastIcon.Size = new Size(28, 30);
            pictureToastIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureToastIcon.TabIndex = 1;
            pictureToastIcon.TabStop = false;
            // 
            // labelToastTitle
            // 
            labelToastTitle.AutoSize = true;
            labelToastTitle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelToastTitle.ForeColor = SystemColors.ButtonHighlight;
            labelToastTitle.Location = new Point(52, 9);
            labelToastTitle.Name = "labelToastTitle";
            labelToastTitle.Size = new Size(33, 17);
            labelToastTitle.TabIndex = 2;
            labelToastTitle.Text = "Title";
            // 
            // labelToastMessage
            // 
            labelToastMessage.AutoSize = true;
            labelToastMessage.Font = new Font("Segoe UI", 8F);
            labelToastMessage.ForeColor = SystemColors.ButtonHighlight;
            labelToastMessage.Location = new Point(52, 29);
            labelToastMessage.Name = "labelToastMessage";
            labelToastMessage.Size = new Size(52, 13);
            labelToastMessage.TabIndex = 3;
            labelToastMessage.Text = "Message";
            // 
            // timerToast
            // 
            timerToast.Enabled = true;
            timerToast.Interval = 10;
            timerToast.Tick += timerToast_Tick;
            // 
            // toastHide
            // 
            toastHide.Interval = 10;
            toastHide.Tick += toastHide_Tick;
            // 
            // ToastForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(89, 106, 122);
            ClientSize = new Size(383, 59);
            Controls.Add(labelToastMessage);
            Controls.Add(labelToastTitle);
            Controls.Add(pictureToastIcon);
            Controls.Add(panelToastBorder);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ToastForm";
            Text = "Notificación";
            Load += ToastForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureToastIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelToastBorder;
        private PictureBox pictureToastIcon;
        private Label labelToastTitle;
        private Label labelToastMessage;
        private System.Windows.Forms.Timer timerToast;
        private System.Windows.Forms.Timer toastHide;
    }
}