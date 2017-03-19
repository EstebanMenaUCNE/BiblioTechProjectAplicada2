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
            this.buscarLibroButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.librosGroupBox = new System.Windows.Forms.GroupBox();
            this.libroEditorialLabel = new System.Windows.Forms.Label();
            this.libroEdicionLabel = new System.Windows.Forms.Label();
            this.libroTituloLabel = new System.Windows.Forms.Label();
            this.libroIdLabel = new System.Windows.Forms.Label();
            this.libroEditorialTextBox = new System.Windows.Forms.TextBox();
            this.libroEdicionTextBox = new System.Windows.Forms.TextBox();
            this.anadirLibroButton = new System.Windows.Forms.Button();
            this.libroTituloTextBox = new System.Windows.Forms.TextBox();
            this.libroIdTextBox = new System.Windows.Forms.TextBox();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.libroErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.eliminarButton = new System.Windows.Forms.Button();
            this.nuevoButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            autorIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            this.RegistroUsuariosStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nombreErrorProvider)).BeginInit();
            this.librosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // autorIdLabel
            // 
            autorIdLabel.AutoSize = true;
            autorIdLabel.Location = new System.Drawing.Point(146, 41);
            autorIdLabel.Name = "autorIdLabel";
            autorIdLabel.Size = new System.Drawing.Size(47, 13);
            autorIdLabel.TabIndex = 1;
            autorIdLabel.Text = "Autor Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(146, 67);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // autorIdTextBox
            // 
            this.autorIdTextBox.Location = new System.Drawing.Point(210, 38);
            this.autorIdTextBox.Name = "autorIdTextBox";
            this.autorIdTextBox.Size = new System.Drawing.Size(68, 20);
            this.autorIdTextBox.TabIndex = 0;
            this.autorIdTextBox.TextChanged += new System.EventHandler(this.autorIdTextBox_TextChanged);
            this.autorIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.autorIdTextBox_KeyPress);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(210, 64);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(208, 20);
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
            this.RegistroUsuariosStatusStrip.Location = new System.Drawing.Point(0, 386);
            this.RegistroUsuariosStatusStrip.Name = "RegistroUsuariosStatusStrip";
            this.RegistroUsuariosStatusStrip.Size = new System.Drawing.Size(571, 22);
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
            // buscarLibroButton
            // 
            this.buscarLibroButton.Image = global::BiblioTechProject.Properties.Resources.ic_search_black_24dp_1x1;
            this.buscarLibroButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarLibroButton.Location = new System.Drawing.Point(61, 32);
            this.buscarLibroButton.Name = "buscarLibroButton";
            this.buscarLibroButton.Size = new System.Drawing.Size(32, 28);
            this.buscarLibroButton.TabIndex = 1;
            this.buscarLibroButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonesToolTip.SetToolTip(this.buscarLibroButton, "Buscar");
            this.buscarLibroButton.UseVisualStyleBackColor = true;
            this.buscarLibroButton.Click += new System.EventHandler(this.buscarLibroButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Image = global::BiblioTechProject.Properties.Resources.ic_search_black_24dp_1x1;
            this.buscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarButton.Location = new System.Drawing.Point(290, 33);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 28);
            this.buscarButton.TabIndex = 6;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonesToolTip.SetToolTip(this.buscarButton, "Buscar");
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // librosGroupBox
            // 
            this.librosGroupBox.Controls.Add(this.libroEditorialLabel);
            this.librosGroupBox.Controls.Add(this.libroEdicionLabel);
            this.librosGroupBox.Controls.Add(this.libroTituloLabel);
            this.librosGroupBox.Controls.Add(this.libroIdLabel);
            this.librosGroupBox.Controls.Add(this.buscarLibroButton);
            this.librosGroupBox.Controls.Add(this.libroEditorialTextBox);
            this.librosGroupBox.Controls.Add(this.libroEdicionTextBox);
            this.librosGroupBox.Controls.Add(this.anadirLibroButton);
            this.librosGroupBox.Controls.Add(this.libroTituloTextBox);
            this.librosGroupBox.Controls.Add(this.libroIdTextBox);
            this.librosGroupBox.Controls.Add(this.librosDataGridView);
            this.librosGroupBox.Location = new System.Drawing.Point(31, 102);
            this.librosGroupBox.Name = "librosGroupBox";
            this.librosGroupBox.Size = new System.Drawing.Size(501, 219);
            this.librosGroupBox.TabIndex = 2;
            this.librosGroupBox.TabStop = false;
            this.librosGroupBox.Text = "Libros del autor";
            // 
            // libroEditorialLabel
            // 
            this.libroEditorialLabel.AutoSize = true;
            this.libroEditorialLabel.Location = new System.Drawing.Point(348, 20);
            this.libroEditorialLabel.Name = "libroEditorialLabel";
            this.libroEditorialLabel.Size = new System.Drawing.Size(44, 13);
            this.libroEditorialLabel.TabIndex = 30;
            this.libroEditorialLabel.Text = "Editorial";
            this.libroEditorialLabel.Click += new System.EventHandler(this.libroEditorialLabel_Click);
            // 
            // libroEdicionLabel
            // 
            this.libroEdicionLabel.AutoSize = true;
            this.libroEdicionLabel.Location = new System.Drawing.Point(290, 21);
            this.libroEdicionLabel.Name = "libroEdicionLabel";
            this.libroEdicionLabel.Size = new System.Drawing.Size(42, 13);
            this.libroEdicionLabel.TabIndex = 29;
            this.libroEdicionLabel.Text = "Edición";
            // 
            // libroTituloLabel
            // 
            this.libroTituloLabel.AutoSize = true;
            this.libroTituloLabel.Location = new System.Drawing.Point(120, 21);
            this.libroTituloLabel.Name = "libroTituloLabel";
            this.libroTituloLabel.Size = new System.Drawing.Size(35, 13);
            this.libroTituloLabel.TabIndex = 28;
            this.libroTituloLabel.Text = "Título";
            // 
            // libroIdLabel
            // 
            this.libroIdLabel.AutoSize = true;
            this.libroIdLabel.Location = new System.Drawing.Point(9, 21);
            this.libroIdLabel.Name = "libroIdLabel";
            this.libroIdLabel.Size = new System.Drawing.Size(42, 13);
            this.libroIdLabel.TabIndex = 27;
            this.libroIdLabel.Text = "Libro Id";
            this.libroIdLabel.Click += new System.EventHandler(this.libroIdLabel_Click);
            // 
            // libroEditorialTextBox
            // 
            this.libroEditorialTextBox.Location = new System.Drawing.Point(345, 37);
            this.libroEditorialTextBox.Name = "libroEditorialTextBox";
            this.libroEditorialTextBox.ReadOnly = true;
            this.libroEditorialTextBox.Size = new System.Drawing.Size(69, 20);
            this.libroEditorialTextBox.TabIndex = 25;
            // 
            // libroEdicionTextBox
            // 
            this.libroEdicionTextBox.Location = new System.Drawing.Point(287, 37);
            this.libroEdicionTextBox.Name = "libroEdicionTextBox";
            this.libroEdicionTextBox.ReadOnly = true;
            this.libroEdicionTextBox.Size = new System.Drawing.Size(52, 20);
            this.libroEdicionTextBox.TabIndex = 24;
            // 
            // anadirLibroButton
            // 
            this.anadirLibroButton.Image = global::BiblioTechProject.Properties.Resources.ic_add_circle_black_24dp_1x;
            this.anadirLibroButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anadirLibroButton.Location = new System.Drawing.Point(420, 32);
            this.anadirLibroButton.Name = "anadirLibroButton";
            this.anadirLibroButton.Size = new System.Drawing.Size(75, 28);
            this.anadirLibroButton.TabIndex = 2;
            this.anadirLibroButton.Text = "Añadir  ";
            this.anadirLibroButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.anadirLibroButton.UseVisualStyleBackColor = true;
            this.anadirLibroButton.Click += new System.EventHandler(this.anadirLibroButton_Click);
            // 
            // libroTituloTextBox
            // 
            this.libroTituloTextBox.Location = new System.Drawing.Point(99, 37);
            this.libroTituloTextBox.Name = "libroTituloTextBox";
            this.libroTituloTextBox.ReadOnly = true;
            this.libroTituloTextBox.Size = new System.Drawing.Size(182, 20);
            this.libroTituloTextBox.TabIndex = 2;
            // 
            // libroIdTextBox
            // 
            this.libroIdTextBox.Location = new System.Drawing.Point(6, 37);
            this.libroIdTextBox.Name = "libroIdTextBox";
            this.libroIdTextBox.Size = new System.Drawing.Size(50, 20);
            this.libroIdTextBox.TabIndex = 0;
            this.libroIdTextBox.TextChanged += new System.EventHandler(this.libroIdTextBox_TextChanged);
            this.libroIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.libroIdTextBox_KeyPress);
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Location = new System.Drawing.Point(6, 66);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.Size = new System.Drawing.Size(489, 136);
            this.librosDataGridView.TabIndex = 0;
            // 
            // libroErrorProvider
            // 
            this.libroErrorProvider.ContainerControl = this;
            // 
            // eliminarButton
            // 
            this.eliminarButton.Image = global::BiblioTechProject.Properties.Resources.ic_delete_black_24dp_1x;
            this.eliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarButton.Location = new System.Drawing.Point(329, 337);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 28);
            this.eliminarButton.TabIndex = 5;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // nuevoButton
            // 
            this.nuevoButton.Image = global::BiblioTechProject.Properties.Resources.ic_note_add_black_24dp_1x;
            this.nuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevoButton.Location = new System.Drawing.Point(145, 337);
            this.nuevoButton.Name = "nuevoButton";
            this.nuevoButton.Size = new System.Drawing.Size(75, 28);
            this.nuevoButton.TabIndex = 4;
            this.nuevoButton.Text = "Nuevo";
            this.nuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevoButton.UseVisualStyleBackColor = true;
            this.nuevoButton.Click += new System.EventHandler(this.nuevoButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.Image = global::BiblioTechProject.Properties.Resources.ic_save_black_24dp_1x;
            this.guardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardarButton.Location = new System.Drawing.Point(237, 337);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 28);
            this.guardarButton.TabIndex = 3;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // FrmRegistroAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 408);
            this.Controls.Add(this.librosGroupBox);
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
            this.librosGroupBox.ResumeLayout(false);
            this.librosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroErrorProvider)).EndInit();
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
        private System.Windows.Forms.GroupBox librosGroupBox;
        private System.Windows.Forms.Button anadirLibroButton;
        private System.Windows.Forms.TextBox libroTituloTextBox;
        private System.Windows.Forms.TextBox libroIdTextBox;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.TextBox libroEdicionTextBox;
        private System.Windows.Forms.Button buscarLibroButton;
        private System.Windows.Forms.TextBox libroEditorialTextBox;
        private System.Windows.Forms.Label libroEditorialLabel;
        private System.Windows.Forms.Label libroEdicionLabel;
        private System.Windows.Forms.Label libroTituloLabel;
        private System.Windows.Forms.Label libroIdLabel;
        private System.Windows.Forms.ErrorProvider libroErrorProvider;
    }
}