namespace BiblioTechProject.UI.Registros
{
    partial class FrmRegistroUsuarios
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
            System.Windows.Forms.Label usuarioIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nombreUsuarioLabel;
            System.Windows.Forms.Label contrasenaLabel;
            System.Windows.Forms.Label cargoLabel;
            System.Windows.Forms.Label confimarContrasenaLabel;
            this.usuarioIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nombreUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.cargoComboBox = new System.Windows.Forms.ComboBox();
            this.nombreErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.usuarioErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contrasenaErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.confirmarContrasenaTextBox = new System.Windows.Forms.TextBox();
            this.confirmarContrasenaErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RegistroUsuariosStatusStrip = new System.Windows.Forms.StatusStrip();
            this.guardadoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ErrorToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.noEncontradoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.eliminadoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.nuevoButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.botonesToolTip = new System.Windows.Forms.ToolTip(this.components);
            usuarioIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nombreUsuarioLabel = new System.Windows.Forms.Label();
            contrasenaLabel = new System.Windows.Forms.Label();
            cargoLabel = new System.Windows.Forms.Label();
            confimarContrasenaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nombreErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrasenaErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmarContrasenaErrorProvider)).BeginInit();
            this.RegistroUsuariosStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuarioIdLabel
            // 
            usuarioIdLabel.AutoSize = true;
            usuarioIdLabel.Location = new System.Drawing.Point(30, 41);
            usuarioIdLabel.Name = "usuarioIdLabel";
            usuarioIdLabel.Size = new System.Drawing.Size(58, 13);
            usuarioIdLabel.TabIndex = 1;
            usuarioIdLabel.Text = "Usuario Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(30, 67);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.Location = new System.Drawing.Point(30, 93);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new System.Drawing.Size(99, 13);
            nombreUsuarioLabel.TabIndex = 5;
            nombreUsuarioLabel.Text = "Nombre de usuario:";
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Location = new System.Drawing.Point(30, 119);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new System.Drawing.Size(64, 13);
            contrasenaLabel.TabIndex = 7;
            contrasenaLabel.Text = "Contraseña:";
            // 
            // cargoLabel
            // 
            cargoLabel.AutoSize = true;
            cargoLabel.Location = new System.Drawing.Point(30, 171);
            cargoLabel.Name = "cargoLabel";
            cargoLabel.Size = new System.Drawing.Size(38, 13);
            cargoLabel.TabIndex = 9;
            cargoLabel.Text = "Cargo:";
            // 
            // confimarContrasenaLabel
            // 
            confimarContrasenaLabel.AutoSize = true;
            confimarContrasenaLabel.Location = new System.Drawing.Point(30, 145);
            confimarContrasenaLabel.Name = "confimarContrasenaLabel";
            confimarContrasenaLabel.Size = new System.Drawing.Size(110, 13);
            confimarContrasenaLabel.TabIndex = 15;
            confimarContrasenaLabel.Text = "Confirmar contraseña:";
            // 
            // usuarioIdTextBox
            // 
            this.usuarioIdTextBox.Location = new System.Drawing.Point(144, 38);
            this.usuarioIdTextBox.Name = "usuarioIdTextBox";
            this.usuarioIdTextBox.Size = new System.Drawing.Size(67, 20);
            this.usuarioIdTextBox.TabIndex = 0;
            this.usuarioIdTextBox.TextChanged += new System.EventHandler(this.usuarioIdTextBox_TextChanged);
            this.usuarioIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usuarioIdTextBox_KeyPress);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(144, 64);
            this.nombreTextBox.MaxLength = 100;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(148, 20);
            this.nombreTextBox.TabIndex = 1;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // nombreUsuarioTextBox
            // 
            this.nombreUsuarioTextBox.Location = new System.Drawing.Point(144, 90);
            this.nombreUsuarioTextBox.MaxLength = 50;
            this.nombreUsuarioTextBox.Name = "nombreUsuarioTextBox";
            this.nombreUsuarioTextBox.Size = new System.Drawing.Size(148, 20);
            this.nombreUsuarioTextBox.TabIndex = 2;
            this.nombreUsuarioTextBox.TextChanged += new System.EventHandler(this.nombreUsuarioTextBox_TextChanged);
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.Location = new System.Drawing.Point(144, 116);
            this.contrasenaTextBox.MaxLength = 20;
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.PasswordChar = '☻';
            this.contrasenaTextBox.Size = new System.Drawing.Size(148, 20);
            this.contrasenaTextBox.TabIndex = 3;
            this.contrasenaTextBox.TextChanged += new System.EventHandler(this.contrasenaTextBox_TextChanged);
            // 
            // cargoComboBox
            // 
            this.cargoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargoComboBox.FormattingEnabled = true;
            this.cargoComboBox.Items.AddRange(new object[] {
            "Bibliotecario",
            "Administrador",
            "Consultor"});
            this.cargoComboBox.Location = new System.Drawing.Point(144, 168);
            this.cargoComboBox.Name = "cargoComboBox";
            this.cargoComboBox.Size = new System.Drawing.Size(148, 21);
            this.cargoComboBox.TabIndex = 5;
            this.cargoComboBox.SelectedIndexChanged += new System.EventHandler(this.cargoComboBox_SelectedIndexChanged);
            // 
            // nombreErrorProvider
            // 
            this.nombreErrorProvider.ContainerControl = this;
            // 
            // usuarioErrorProvider
            // 
            this.usuarioErrorProvider.ContainerControl = this;
            // 
            // contrasenaErrorProvider
            // 
            this.contrasenaErrorProvider.ContainerControl = this;
            // 
            // confirmarContrasenaTextBox
            // 
            this.confirmarContrasenaTextBox.Location = new System.Drawing.Point(144, 142);
            this.confirmarContrasenaTextBox.MaxLength = 20;
            this.confirmarContrasenaTextBox.Name = "confirmarContrasenaTextBox";
            this.confirmarContrasenaTextBox.PasswordChar = '☻';
            this.confirmarContrasenaTextBox.Size = new System.Drawing.Size(148, 20);
            this.confirmarContrasenaTextBox.TabIndex = 4;
            this.confirmarContrasenaTextBox.TextChanged += new System.EventHandler(this.confirmarContrasenaTextBox_TextChanged);
            // 
            // confirmarContrasenaErrorProvider
            // 
            this.confirmarContrasenaErrorProvider.ContainerControl = this;
            // 
            // RegistroUsuariosStatusStrip
            // 
            this.RegistroUsuariosStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardadoToolStripStatusLabel,
            this.ErrorToolStripStatusLabel,
            this.noEncontradoToolStripStatusLabel,
            this.eliminadoToolStripStatusLabel});
            this.RegistroUsuariosStatusStrip.Location = new System.Drawing.Point(0, 270);
            this.RegistroUsuariosStatusStrip.Name = "RegistroUsuariosStatusStrip";
            this.RegistroUsuariosStatusStrip.Size = new System.Drawing.Size(331, 22);
            this.RegistroUsuariosStatusStrip.TabIndex = 16;
            this.RegistroUsuariosStatusStrip.Text = "statusStrip1";
            this.RegistroUsuariosStatusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.RegistroUsuariosStatusStrip_ItemClicked);
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
            // eliminarButton
            // 
            this.eliminarButton.Image = global::BiblioTechProject.Properties.Resources.ic_delete_black_24dp_1x;
            this.eliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarButton.Location = new System.Drawing.Point(217, 210);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 28);
            this.eliminarButton.TabIndex = 8;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Image = global::BiblioTechProject.Properties.Resources.ic_search_black_24dp_1x1;
            this.buscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarButton.Location = new System.Drawing.Point(217, 33);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 28);
            this.buscarButton.TabIndex = 9;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonesToolTip.SetToolTip(this.buscarButton, "Buscar");
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // nuevoButton
            // 
            this.nuevoButton.Image = global::BiblioTechProject.Properties.Resources.ic_note_add_black_24dp_1x;
            this.nuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevoButton.Location = new System.Drawing.Point(33, 210);
            this.nuevoButton.Name = "nuevoButton";
            this.nuevoButton.Size = new System.Drawing.Size(75, 28);
            this.nuevoButton.TabIndex = 7;
            this.nuevoButton.Text = "Nuevo";
            this.nuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevoButton.UseVisualStyleBackColor = true;
            this.nuevoButton.Click += new System.EventHandler(this.nuevoButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.Image = global::BiblioTechProject.Properties.Resources.ic_save_black_24dp_1x;
            this.guardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardarButton.Location = new System.Drawing.Point(125, 210);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 28);
            this.guardarButton.TabIndex = 6;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // FrmRegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 292);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.RegistroUsuariosStatusStrip);
            this.Controls.Add(confimarContrasenaLabel);
            this.Controls.Add(this.confirmarContrasenaTextBox);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.nuevoButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(usuarioIdLabel);
            this.Controls.Add(this.usuarioIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(nombreUsuarioLabel);
            this.Controls.Add(this.nombreUsuarioTextBox);
            this.Controls.Add(contrasenaLabel);
            this.Controls.Add(this.contrasenaTextBox);
            this.Controls.Add(cargoLabel);
            this.Controls.Add(this.cargoComboBox);
            this.Name = "FrmRegistroUsuarios";
            this.Text = "BiblioTech - Registro de Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegistroUsuarios_FormClosed);
            this.Load += new System.EventHandler(this.FrmRegistroUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nombreErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrasenaErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmarContrasenaErrorProvider)).EndInit();
            this.RegistroUsuariosStatusStrip.ResumeLayout(false);
            this.RegistroUsuariosStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox nombreUsuarioTextBox;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.ComboBox cargoComboBox;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button nuevoButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.ErrorProvider nombreErrorProvider;
        private System.Windows.Forms.ErrorProvider usuarioErrorProvider;
        private System.Windows.Forms.ErrorProvider contrasenaErrorProvider;
        private System.Windows.Forms.TextBox confirmarContrasenaTextBox;
        private System.Windows.Forms.ErrorProvider confirmarContrasenaErrorProvider;
        private System.Windows.Forms.StatusStrip RegistroUsuariosStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel guardadoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ErrorToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel noEncontradoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel eliminadoToolStripStatusLabel;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.ToolTip botonesToolTip;
    }
}