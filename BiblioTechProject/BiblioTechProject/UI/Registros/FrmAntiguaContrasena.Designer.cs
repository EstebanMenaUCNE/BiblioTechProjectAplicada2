namespace BiblioTechProject.UI.Registros
{
    partial class FrmAntiguaContrasena
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
            System.Windows.Forms.Button cancelarButton;
            System.Windows.Forms.Label contrasenaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAntiguaContrasena));
            this.aceptarButton = new System.Windows.Forms.Button();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            cancelarButton = new System.Windows.Forms.Button();
            contrasenaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new System.Drawing.Point(164, 74);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new System.Drawing.Size(75, 28);
            cancelarButton.TabIndex = 1;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Location = new System.Drawing.Point(18, 32);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new System.Drawing.Size(103, 13);
            contrasenaLabel.TabIndex = 18;
            contrasenaLabel.Text = "Antigua Contraseña:";
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(54, 74);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(75, 28);
            this.aceptarButton.TabIndex = 0;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.Location = new System.Drawing.Point(127, 29);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.PasswordChar = '☻';
            this.contrasenaTextBox.Size = new System.Drawing.Size(135, 20);
            this.contrasenaTextBox.TabIndex = 16;
            // 
            // FrmAntiguaContrasena
            // 
            this.AcceptButton = this.aceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 125);
            this.ControlBox = false;
            this.Controls.Add(contrasenaLabel);
            this.Controls.Add(this.contrasenaTextBox);
            this.Controls.Add(cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAntiguaContrasena";
            this.Text = "Confirmar Antigua Contraseña";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAntiguaContrasena_FormClosed);
            this.Load += new System.EventHandler(this.FrmAntiguaContrasena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.TextBox contrasenaTextBox;
    }
}