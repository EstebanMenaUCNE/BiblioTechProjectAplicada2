namespace BiblioTechProject.UI.Registros
{
    partial class FrmRegistroLibros
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
            System.Windows.Forms.Label libroIdLabel1;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label edicionLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label editorialIdLabel;
            this.librosGroupBox = new System.Windows.Forms.GroupBox();
            this.autorNombreLabel = new System.Windows.Forms.Label();
            this.autorIdLabel = new System.Windows.Forms.Label();
            this.buscarAutorButton = new System.Windows.Forms.Button();
            this.anadirAutorButton = new System.Windows.Forms.Button();
            this.autorNombreTextBox = new System.Windows.Forms.TextBox();
            this.autorIdTextBox = new System.Windows.Forms.TextBox();
            this.autoresDataGridView = new System.Windows.Forms.DataGridView();
            this.buscarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.nuevoButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.libroIdTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.edicionTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.buscarEditorialButton = new System.Windows.Forms.Button();
            this.editorialNombreTextBox = new System.Windows.Forms.TextBox();
            this.editorialIdTextBox = new System.Windows.Forms.TextBox();
            this.RegistroUsuariosStatusStrip = new System.Windows.Forms.StatusStrip();
            this.guardadoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ErrorToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.noEncontradoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.eliminadoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tituloErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.edicionErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.editorialErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.autorErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            libroIdLabel1 = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            edicionLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            editorialIdLabel = new System.Windows.Forms.Label();
            this.librosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataGridView)).BeginInit();
            this.RegistroUsuariosStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edicionErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // libroIdLabel1
            // 
            libroIdLabel1.AutoSize = true;
            libroIdLabel1.Location = new System.Drawing.Point(93, 39);
            libroIdLabel1.Name = "libroIdLabel1";
            libroIdLabel1.Size = new System.Drawing.Size(45, 13);
            libroIdLabel1.TabIndex = 28;
            libroIdLabel1.Text = "Libro Id:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(93, 65);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(38, 13);
            tituloLabel.TabIndex = 30;
            tituloLabel.Text = "Título:";
            // 
            // edicionLabel
            // 
            edicionLabel.AutoSize = true;
            edicionLabel.Location = new System.Drawing.Point(93, 91);
            edicionLabel.Name = "edicionLabel";
            edicionLabel.Size = new System.Drawing.Size(45, 13);
            edicionLabel.TabIndex = 32;
            edicionLabel.Text = "Edición:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(93, 117);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 34;
            estadoLabel.Text = "Estado:";
            // 
            // editorialIdLabel
            // 
            editorialIdLabel.AutoSize = true;
            editorialIdLabel.Location = new System.Drawing.Point(93, 144);
            editorialIdLabel.Name = "editorialIdLabel";
            editorialIdLabel.Size = new System.Drawing.Size(47, 13);
            editorialIdLabel.TabIndex = 36;
            editorialIdLabel.Text = "Editorial:";
            editorialIdLabel.Click += new System.EventHandler(this.editorialIdLabel_Click);
            // 
            // librosGroupBox
            // 
            this.librosGroupBox.Controls.Add(this.autorNombreLabel);
            this.librosGroupBox.Controls.Add(this.autorIdLabel);
            this.librosGroupBox.Controls.Add(this.buscarAutorButton);
            this.librosGroupBox.Controls.Add(this.anadirAutorButton);
            this.librosGroupBox.Controls.Add(this.autorNombreTextBox);
            this.librosGroupBox.Controls.Add(this.autorIdTextBox);
            this.librosGroupBox.Controls.Add(this.autoresDataGridView);
            this.librosGroupBox.Location = new System.Drawing.Point(36, 174);
            this.librosGroupBox.Name = "librosGroupBox";
            this.librosGroupBox.Size = new System.Drawing.Size(501, 219);
            this.librosGroupBox.TabIndex = 6;
            this.librosGroupBox.TabStop = false;
            this.librosGroupBox.Text = "Libros del autor";
            // 
            // autorNombreLabel
            // 
            this.autorNombreLabel.AutoSize = true;
            this.autorNombreLabel.Location = new System.Drawing.Point(120, 21);
            this.autorNombreLabel.Name = "autorNombreLabel";
            this.autorNombreLabel.Size = new System.Drawing.Size(44, 13);
            this.autorNombreLabel.TabIndex = 28;
            this.autorNombreLabel.Text = "Nombre";
            this.autorNombreLabel.Click += new System.EventHandler(this.autorNombreLabel_Click);
            // 
            // autorIdLabel
            // 
            this.autorIdLabel.AutoSize = true;
            this.autorIdLabel.Location = new System.Drawing.Point(9, 21);
            this.autorIdLabel.Name = "autorIdLabel";
            this.autorIdLabel.Size = new System.Drawing.Size(44, 13);
            this.autorIdLabel.TabIndex = 27;
            this.autorIdLabel.Text = "Autor Id";
            this.autorIdLabel.Click += new System.EventHandler(this.autorIdLabel_Click);
            // 
            // buscarAutorButton
            // 
            this.buscarAutorButton.Image = global::BiblioTechProject.Properties.Resources.ic_search_black_24dp_1x1;
            this.buscarAutorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarAutorButton.Location = new System.Drawing.Point(61, 32);
            this.buscarAutorButton.Name = "buscarAutorButton";
            this.buscarAutorButton.Size = new System.Drawing.Size(32, 28);
            this.buscarAutorButton.TabIndex = 1;
            this.buscarAutorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarAutorButton.UseVisualStyleBackColor = true;
            this.buscarAutorButton.Click += new System.EventHandler(this.buscarAutorButton_Click);
            // 
            // anadirAutorButton
            // 
            this.anadirAutorButton.Image = global::BiblioTechProject.Properties.Resources.ic_add_circle_black_24dp_1x;
            this.anadirAutorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anadirAutorButton.Location = new System.Drawing.Point(420, 32);
            this.anadirAutorButton.Name = "anadirAutorButton";
            this.anadirAutorButton.Size = new System.Drawing.Size(75, 28);
            this.anadirAutorButton.TabIndex = 2;
            this.anadirAutorButton.Text = "Añadir  ";
            this.anadirAutorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.anadirAutorButton.UseVisualStyleBackColor = true;
            this.anadirAutorButton.Click += new System.EventHandler(this.anadirAutorButton_Click);
            // 
            // autorNombreTextBox
            // 
            this.autorNombreTextBox.Location = new System.Drawing.Point(99, 37);
            this.autorNombreTextBox.Name = "autorNombreTextBox";
            this.autorNombreTextBox.ReadOnly = true;
            this.autorNombreTextBox.Size = new System.Drawing.Size(315, 20);
            this.autorNombreTextBox.TabIndex = 2;
            this.autorNombreTextBox.TextChanged += new System.EventHandler(this.libroTituloTextBox_TextChanged);
            // 
            // autorIdTextBox
            // 
            this.autorIdTextBox.Location = new System.Drawing.Point(6, 37);
            this.autorIdTextBox.Name = "autorIdTextBox";
            this.autorIdTextBox.Size = new System.Drawing.Size(50, 20);
            this.autorIdTextBox.TabIndex = 0;
            this.autorIdTextBox.TextChanged += new System.EventHandler(this.libroIdTextBox_TextChanged);
            this.autorIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.autorIdTextBox_KeyPress);
            // 
            // autoresDataGridView
            // 
            this.autoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoresDataGridView.Location = new System.Drawing.Point(6, 66);
            this.autoresDataGridView.Name = "autoresDataGridView";
            this.autoresDataGridView.Size = new System.Drawing.Size(489, 136);
            this.autoresDataGridView.TabIndex = 0;
            // 
            // buscarButton
            // 
            this.buscarButton.Image = global::BiblioTechProject.Properties.Resources.ic_search_black_24dp_1x1;
            this.buscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarButton.Location = new System.Drawing.Point(230, 31);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 28);
            this.buscarButton.TabIndex = 10;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Image = global::BiblioTechProject.Properties.Resources.ic_delete_black_24dp_1x;
            this.eliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarButton.Location = new System.Drawing.Point(342, 415);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 28);
            this.eliminarButton.TabIndex = 9;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // nuevoButton
            // 
            this.nuevoButton.Image = global::BiblioTechProject.Properties.Resources.ic_note_add_black_24dp_1x;
            this.nuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevoButton.Location = new System.Drawing.Point(158, 415);
            this.nuevoButton.Name = "nuevoButton";
            this.nuevoButton.Size = new System.Drawing.Size(75, 28);
            this.nuevoButton.TabIndex = 8;
            this.nuevoButton.Text = "Nuevo";
            this.nuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevoButton.UseVisualStyleBackColor = true;
            this.nuevoButton.Click += new System.EventHandler(this.nuevoButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.Image = global::BiblioTechProject.Properties.Resources.ic_save_black_24dp_1x;
            this.guardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardarButton.Location = new System.Drawing.Point(250, 415);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 28);
            this.guardarButton.TabIndex = 7;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // libroIdTextBox
            // 
            this.libroIdTextBox.Location = new System.Drawing.Point(158, 36);
            this.libroIdTextBox.Name = "libroIdTextBox";
            this.libroIdTextBox.Size = new System.Drawing.Size(66, 20);
            this.libroIdTextBox.TabIndex = 0;
            this.libroIdTextBox.TextChanged += new System.EventHandler(this.libroIdTextBox_TextChanged_1);
            this.libroIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.libroIdTextBox_KeyPress);
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Location = new System.Drawing.Point(158, 62);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(292, 20);
            this.tituloTextBox.TabIndex = 1;
            this.tituloTextBox.TextChanged += new System.EventHandler(this.tituloTextBox_TextChanged);
            // 
            // edicionTextBox
            // 
            this.edicionTextBox.Location = new System.Drawing.Point(158, 88);
            this.edicionTextBox.Name = "edicionTextBox";
            this.edicionTextBox.Size = new System.Drawing.Size(292, 20);
            this.edicionTextBox.TabIndex = 2;
            this.edicionTextBox.TextChanged += new System.EventHandler(this.edicionTextBox_TextChanged);
            this.edicionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edicionTextBox_KeyPress);
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Disponible",
            "Prestado",
            "Reparación",
            "Desaparecido",
            "En mal estado"});
            this.estadoComboBox.Location = new System.Drawing.Point(158, 114);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(292, 21);
            this.estadoComboBox.TabIndex = 3;
            this.estadoComboBox.SelectedIndexChanged += new System.EventHandler(this.estadoComboBox_SelectedIndexChanged);
            // 
            // buscarEditorialButton
            // 
            this.buscarEditorialButton.Image = global::BiblioTechProject.Properties.Resources.ic_search_black_24dp_1x1;
            this.buscarEditorialButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarEditorialButton.Location = new System.Drawing.Point(230, 136);
            this.buscarEditorialButton.Name = "buscarEditorialButton";
            this.buscarEditorialButton.Size = new System.Drawing.Size(32, 28);
            this.buscarEditorialButton.TabIndex = 5;
            this.buscarEditorialButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarEditorialButton.UseVisualStyleBackColor = true;
            this.buscarEditorialButton.Click += new System.EventHandler(this.buscarEditorialButton_Click);
            // 
            // editorialNombreTextBox
            // 
            this.editorialNombreTextBox.Location = new System.Drawing.Point(268, 141);
            this.editorialNombreTextBox.Name = "editorialNombreTextBox";
            this.editorialNombreTextBox.ReadOnly = true;
            this.editorialNombreTextBox.Size = new System.Drawing.Size(182, 20);
            this.editorialNombreTextBox.TabIndex = 30;
            // 
            // editorialIdTextBox
            // 
            this.editorialIdTextBox.Location = new System.Drawing.Point(158, 141);
            this.editorialIdTextBox.Name = "editorialIdTextBox";
            this.editorialIdTextBox.Size = new System.Drawing.Size(66, 20);
            this.editorialIdTextBox.TabIndex = 4;
            this.editorialIdTextBox.TextChanged += new System.EventHandler(this.editorialIdTextBox_TextChanged);
            this.editorialIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editorialIdTextBox_KeyPress);
            // 
            // RegistroUsuariosStatusStrip
            // 
            this.RegistroUsuariosStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardadoToolStripStatusLabel,
            this.ErrorToolStripStatusLabel,
            this.noEncontradoToolStripStatusLabel,
            this.eliminadoToolStripStatusLabel});
            this.RegistroUsuariosStatusStrip.Location = new System.Drawing.Point(0, 466);
            this.RegistroUsuariosStatusStrip.Name = "RegistroUsuariosStatusStrip";
            this.RegistroUsuariosStatusStrip.Size = new System.Drawing.Size(570, 22);
            this.RegistroUsuariosStatusStrip.TabIndex = 37;
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
            // tituloErrorProvider
            // 
            this.tituloErrorProvider.ContainerControl = this;
            // 
            // edicionErrorProvider
            // 
            this.edicionErrorProvider.ContainerControl = this;
            // 
            // editorialErrorProvider
            // 
            this.editorialErrorProvider.ContainerControl = this;
            // 
            // autorErrorProvider
            // 
            this.autorErrorProvider.ContainerControl = this;
            // 
            // FrmRegistroLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 488);
            this.Controls.Add(this.RegistroUsuariosStatusStrip);
            this.Controls.Add(libroIdLabel1);
            this.Controls.Add(this.libroIdTextBox);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(edicionLabel);
            this.Controls.Add(this.edicionTextBox);
            this.Controls.Add(this.buscarEditorialButton);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(this.editorialNombreTextBox);
            this.Controls.Add(editorialIdLabel);
            this.Controls.Add(this.librosGroupBox);
            this.Controls.Add(this.editorialIdTextBox);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.nuevoButton);
            this.Controls.Add(this.guardarButton);
            this.Name = "FrmRegistroLibros";
            this.Text = "BiblioTech - Registro de Libros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegistroLibros_FormClosed);
            this.Load += new System.EventHandler(this.FrmRegistroLibros_Load);
            this.librosGroupBox.ResumeLayout(false);
            this.librosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataGridView)).EndInit();
            this.RegistroUsuariosStatusStrip.ResumeLayout(false);
            this.RegistroUsuariosStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edicionErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox librosGroupBox;
        private System.Windows.Forms.Label autorNombreLabel;
        private System.Windows.Forms.Label autorIdLabel;
        private System.Windows.Forms.Button buscarAutorButton;
        private System.Windows.Forms.Button anadirAutorButton;
        private System.Windows.Forms.TextBox autorNombreTextBox;
        private System.Windows.Forms.TextBox autorIdTextBox;
        private System.Windows.Forms.DataGridView autoresDataGridView;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button nuevoButton;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.TextBox libroIdTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox edicionTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.Button buscarEditorialButton;
        private System.Windows.Forms.TextBox editorialNombreTextBox;
        private System.Windows.Forms.TextBox editorialIdTextBox;
        private System.Windows.Forms.StatusStrip RegistroUsuariosStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel guardadoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ErrorToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel noEncontradoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel eliminadoToolStripStatusLabel;
        private System.Windows.Forms.ErrorProvider tituloErrorProvider;
        private System.Windows.Forms.ErrorProvider edicionErrorProvider;
        private System.Windows.Forms.ErrorProvider editorialErrorProvider;
        private System.Windows.Forms.ErrorProvider autorErrorProvider;
    }
}