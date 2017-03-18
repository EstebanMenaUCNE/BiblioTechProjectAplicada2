namespace BiblioTechProject.UI
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            this.usuarioErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.contrasenaLabel = new System.Windows.Forms.Label();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.contrasenaErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contrasenaPictureBox = new System.Windows.Forms.PictureBox();
            this.usuarioPictureBox = new System.Windows.Forms.PictureBox();
            this.SalirButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrasenaErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrasenaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioErrorProvider
            // 
            this.usuarioErrorProvider.ContainerControl = this;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(117, 71);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(113, 20);
            this.usuarioTextBox.TabIndex = 0;
            this.usuarioTextBox.TextChanged += new System.EventHandler(this.usuarioTextBox_TextChanged);
            this.usuarioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usuarioTextBox_KeyPress);
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usuarioLabel.Location = new System.Drawing.Point(53, 74);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(43, 13);
            this.usuarioLabel.TabIndex = 4;
            this.usuarioLabel.Text = "Usuario";
            // 
            // contrasenaLabel
            // 
            this.contrasenaLabel.AutoSize = true;
            this.contrasenaLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contrasenaLabel.Location = new System.Drawing.Point(53, 100);
            this.contrasenaLabel.Name = "contrasenaLabel";
            this.contrasenaLabel.Size = new System.Drawing.Size(61, 13);
            this.contrasenaLabel.TabIndex = 5;
            this.contrasenaLabel.Text = "Contraseña";
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.Location = new System.Drawing.Point(117, 97);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.PasswordChar = '☻';
            this.contrasenaTextBox.Size = new System.Drawing.Size(113, 20);
            this.contrasenaTextBox.TabIndex = 1;
            this.contrasenaTextBox.TextChanged += new System.EventHandler(this.contrasenaTextBox_TextChanged);
            this.contrasenaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contrasenaTextBox_KeyPress);
            // 
            // contrasenaErrorProvider
            // 
            this.contrasenaErrorProvider.ContainerControl = this;
            // 
            // contrasenaPictureBox
            // 
            this.contrasenaPictureBox.Image = global::BiblioTechProject.Properties.Resources.ic_lock_black_24dp_1x;
            this.contrasenaPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contrasenaPictureBox.Location = new System.Drawing.Point(27, 92);
            this.contrasenaPictureBox.Name = "contrasenaPictureBox";
            this.contrasenaPictureBox.Size = new System.Drawing.Size(25, 25);
            this.contrasenaPictureBox.TabIndex = 7;
            this.contrasenaPictureBox.TabStop = false;
            // 
            // usuarioPictureBox
            // 
            this.usuarioPictureBox.Image = global::BiblioTechProject.Properties.Resources.ic_account_circle_black_24dp_1x;
            this.usuarioPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usuarioPictureBox.Location = new System.Drawing.Point(27, 66);
            this.usuarioPictureBox.Name = "usuarioPictureBox";
            this.usuarioPictureBox.Size = new System.Drawing.Size(25, 25);
            this.usuarioPictureBox.TabIndex = 6;
            this.usuarioPictureBox.TabStop = false;
            // 
            // SalirButton
            // 
            this.SalirButton.Image = global::BiblioTechProject.Properties.Resources.ic_exit_to_app_black_24dp_1x;
            this.SalirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalirButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SalirButton.Location = new System.Drawing.Point(155, 154);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 28);
            this.SalirButton.TabIndex = 3;
            this.SalirButton.Text = "Salir    ";
            this.SalirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click_1);
            // 
            // loginButton
            // 
            this.loginButton.Image = global::BiblioTechProject.Properties.Resources.ic_fingerprint_black_24dp_1x;
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginButton.Location = new System.Drawing.Point(45, 154);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 28);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login   ";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.contrasenaPictureBox);
            this.Controls.Add(this.usuarioPictureBox);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.contrasenaLabel);
            this.Controls.Add(this.contrasenaTextBox);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.loginButton);
            this.Name = "FrmLogin";
            this.Text = "BiblioTech - Inicio de sesión";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrasenaErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrasenaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider usuarioErrorProvider;
        private System.Windows.Forms.Label contrasenaLabel;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ErrorProvider contrasenaErrorProvider;
        private System.Windows.Forms.PictureBox usuarioPictureBox;
        private System.Windows.Forms.PictureBox contrasenaPictureBox;
    }
}