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
            this.SalirButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.contrasenaErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrasenaErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioErrorProvider
            // 
            this.usuarioErrorProvider.ContainerControl = this;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(106, 71);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(124, 20);
            this.usuarioTextBox.TabIndex = 0;
            this.usuarioTextBox.TextChanged += new System.EventHandler(this.usuarioTextBox_TextChanged);
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Location = new System.Drawing.Point(42, 74);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(43, 13);
            this.usuarioLabel.TabIndex = 4;
            this.usuarioLabel.Text = "Usuario";
            // 
            // contrasenaLabel
            // 
            this.contrasenaLabel.AutoSize = true;
            this.contrasenaLabel.Location = new System.Drawing.Point(42, 100);
            this.contrasenaLabel.Name = "contrasenaLabel";
            this.contrasenaLabel.Size = new System.Drawing.Size(61, 13);
            this.contrasenaLabel.TabIndex = 5;
            this.contrasenaLabel.Text = "Contraseña";
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.Location = new System.Drawing.Point(106, 97);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.Size = new System.Drawing.Size(124, 20);
            this.contrasenaTextBox.TabIndex = 1;
            this.contrasenaTextBox.TextChanged += new System.EventHandler(this.contrasenaTextBox_TextChanged);
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(155, 154);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 23);
            this.SalirButton.TabIndex = 3;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click_1);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(45, 154);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // contrasenaErrorProvider
            // 
            this.contrasenaErrorProvider.ContainerControl = this;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}