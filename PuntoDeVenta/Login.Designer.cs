namespace PuntoDeVenta
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            labelUser = new Label();
            labelPassword = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(246, 194);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(309, 23);
            txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(246, 261);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(309, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ButtonHighlight;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.FlatAppearance.BorderColor = Color.Silver;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(246, 324);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(142, 39);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Acceder";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonHighlight;
            btnExit.BackgroundImageLayout = ImageLayout.None;
            btnExit.FlatAppearance.BorderColor = Color.Silver;
            btnExit.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btnExit.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(413, 324);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(142, 39);
            btnExit.TabIndex = 3;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUser.ForeColor = Color.White;
            labelUser.Location = new Point(246, 170);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(69, 21);
            labelUser.TabIndex = 4;
            labelUser.Text = "Usuario:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(246, 237);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(96, 21);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo_bedaqui;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.logo_bedaqui1;
            pictureBox1.Location = new Point(334, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(labelPassword);
            Controls.Add(labelUser);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            ShowIcon = false;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private Label labelUser;
        private Label labelPassword;
        private PictureBox pictureBox1;
    }
}
