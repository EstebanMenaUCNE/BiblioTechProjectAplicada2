namespace BiblioTechProject.UI.Registros
{
    partial class FrmRegistroAutores
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
            System.Windows.Forms.Label autorIdLabel;
            System.Windows.Forms.Label nombreLabel;
            this.autorIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.RegistroUsuariosStatusStrip = new System.Windows.Forms.StatusStrip();
            this.guardadoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ErrorToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.noEncontradoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.eliminadoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buscarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.nuevoButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.nombreErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            autorIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            this.RegistroUsuariosStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nombreErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // autorIdLabel
            // 
            autorIdLabel.AutoSize = true;
            autorIdLabel.Location = new System.Drawing.Point(28, 68);
            autorIdLabel.Name = "autorIdLabel";
            autorIdLabel.Size = new System.Drawing.Size(47, 13);
            autorIdLabel.TabIndex = 1;
            autorIdLabel.Text = "Autor Id:";
            // 
            // autorIdTextBox
            // 
            this.autorIdTextBox.Location = new System.Drawing.Point(92, 65);
            this.autorIdTextBox.Name = "autorIdTextBox";
            this.autorIdTextBox.Size = new System.Drawing.Size(97, 20);
            this.autorIdTextBox.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(28, 94);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(92, 91);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(178, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // RegistroUsuariosStatusStrip
            // 
            this.RegistroUsuariosStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardadoToolStripStatusLabel,
            this.ErrorToolStripStatusLabel,
            this.noEncontradoToolStripStatusLabel,
            this.eliminadoToolStripStatusLabel});
            this.RegistroUsuariosStatusStrip.Location = new System.Drawing.Point(0, 239);
            this.RegistroUsuariosStatusStrip.Name = "RegistroUsuariosStatusStrip";
            this.RegistroUsuariosStatusStrip.Size = new System.Drawing.Size(301, 22);
            this.RegistroUsuariosStatusStrip.TabIndex = 21;
            this.RegistroUsuariosStatusStrip.Text = "statusStrip1";
            // 
            // guardadoToolStripStatusLabel
            // 
            this.guardadoToolStripStatusLabel.Name = "guardadoToolStripStatusLabel";
            this.guardadoToolStripStatusLabel.Size = new System.Drawing.Size(113, 17);
            this.guardadoToolStripStatusLabel.Text = "Guardado con éxito!";
            this.guardadoToolStripStatusLabel.Visible = false;
            // 
            // ErrorToolStripStatusLabel
            // 
            this.ErrorToolStripStatusLabel.Name = "ErrorToolStripStatusLabel";
            this.ErrorToolStripStatusLabel.Size = new System.Drawing.Size(91, 17);
            this.ErrorToolStripStatusLabel.Text = "Algo salió mal...";
            this.ErrorToolStripStatusLabel.Visible = false;
            // 
            // noEncontradoToolStripStatusLabel
            // 
            this.noEncontradoToolStripStatusLabel.Name = "noEncontradoToolStripStatusLabel";
            this.noEncontradoToolStripStatusLabel.Size = new System.Drawing.Size(96, 17);
            this.noEncontradoToolStripStatusLabel.Text = "No encontrado...";
            this.noEncontradoToolStripStatusLabel.Visible = false;
            // 
            // eliminadoToolStripStatusLabel
            // 
            this.eliminadoToolStripStatusLabel.Name = "eliminadoToolStripStatusLabel";
            this.eliminadoToolStripStatusLabel.Size = new System.Drawing.Size(114, 17);
            this.eliminadoToolStripStatusLabel.Text = "Eliminado con éxito!";
            this.eliminadoToolStripStatusLabel.Visible = false;
            // 
            // buscarButton
            // 
            this.buscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarButton.Location = new System.Drawing.Point(195, 63);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 20;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(205, 169);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarButton.TabIndex = 18;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            // 
            // nuevoButton
            // 
            this.nuevoButton.Location = new System.Drawing.Point(21, 169);
            this.nuevoButton.Name = "nuevoButton";
            this.nuevoButton.Size = new System.Drawing.Size(75, 23);
            this.nuevoButton.TabIndex = 19;
            this.nuevoButton.Text = "Nuevo";
            this.nuevoButton.UseVisualStyleBackColor = true;
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(114, 169);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 23);
            this.guardarButton.TabIndex = 17;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            // 
            // nombreErrorProvider
            // 
            this.nombreErrorProvider.ContainerControl = this;
            // 
            // FrmRegistroAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 261);
            this.Controls.Add(this.RegistroUsuariosStatusStrip);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.nuevoButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(autorIdLabel);
            this.Controls.Add(this.autorIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "FrmRegistroAutores";
            this.Text = "BiblioTech - Registro de Autores";
            this.Load += new System.EventHandler(this.FrmRegistroAutores_Load);
            this.RegistroUsuariosStatusStrip.ResumeLayout(false);
            this.RegistroUsuariosStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nombreErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox autorIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.StatusStrip RegistroUsuariosStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel guardadoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ErrorToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel noEncontradoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel eliminadoToolStripStatusLabel;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button nuevoButton;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.ErrorProvider nombreErrorProvider;
    }
}