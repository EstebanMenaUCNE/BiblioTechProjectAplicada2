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
            this.nombreErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.botonesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buscarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.nuevoButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
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
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(28, 94);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // autorIdTextBox
            // 
            this.autorIdTextBox.Location = new System.Drawing.Point(92, 65);
            this.autorIdTextBox.Name = "autorIdTextBox";
            this.autorIdTextBox.Size = new System.Drawing.Size(97, 20);
            this.autorIdTextBox.TabIndex = 0;
            this.autorIdTextBox.TextChanged += new System.EventHandler(this.autorIdTextBox_TextChanged);
            this.autorIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.autorIdTextBox_KeyPress);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(92, 91);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(178, 20);
            this.nombreTextBox.TabIndex = 1;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
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
            // nombreErrorProvider
            // 
            this.nombreErrorProvider.ContainerControl = this;
            // 
            // buscarButton
            // 
            this.buscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarButton.Image = global::BiblioTechProject.Properties.Resources.ic_search_black_24dp_1x1;
            this.buscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarButton.Location = new System.Drawing.Point(195, 60);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 28);
            this.buscarButton.TabIndex = 5;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonesToolTip.SetToolTip(this.buscarButton, "Buscar");
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Image = global::BiblioTechProject.Properties.Resources.ic_delete_black_24dp_1x;
            this.eliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarButton.Location = new System.Drawing.Point(205, 148);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 28);
            this.eliminarButton.TabIndex = 4;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // nuevoButton
            // 
            this.nuevoButton.Image = global::BiblioTechProject.Properties.Resources.ic_note_add_black_24dp_1x;
            this.nuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevoButton.Location = new System.Drawing.Point(21, 148);
            this.nuevoButton.Name = "nuevoButton";
            this.nuevoButton.Size = new System.Drawing.Size(75, 28);
            this.nuevoButton.TabIndex = 3;
            this.nuevoButton.Text = "Nuevo";
            this.nuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevoButton.UseVisualStyleBackColor = true;
            this.nuevoButton.Click += new System.EventHandler(this.nuevoButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.Image = global::BiblioTechProject.Properties.Resources.ic_save_black_24dp_1x;
            this.guardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardarButton.Location = new System.Drawing.Point(113, 148);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 28);
            this.guardarButton.TabIndex = 2;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // FrmRegistroAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 261);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.nuevoButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.RegistroUsuariosStatusStrip);
            this.Controls.Add(autorIdLabel);
            this.Controls.Add(this.autorIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "FrmRegistroAutores";
            this.Text = "BiblioTech - Registro de Autores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegistroAutores_FormClosed);
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
        private System.Windows.Forms.ErrorProvider nombreErrorProvider;
        private System.Windows.Forms.ToolTip botonesToolTip;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button nuevoButton;
        private System.Windows.Forms.Button guardarButton;
    }
}