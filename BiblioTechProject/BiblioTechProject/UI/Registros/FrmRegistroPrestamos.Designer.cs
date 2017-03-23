namespace BiblioTechProject.UI.Registros
{
    partial class FrmRegistroPrestamos
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
            System.Windows.Forms.Label prestamoIdLabel;
            System.Windows.Forms.Label fechaPrestamoLabel;
            System.Windows.Forms.Label fechaEntregarAntesLabel;
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label estadoLabel;
            this.prestamoIdTextBox = new System.Windows.Forms.TextBox();
            this.fechaPrestamoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaEntregarAntesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clienteIdTextBox = new System.Windows.Forms.TextBox();
            this.librosGroupBox = new System.Windows.Forms.GroupBox();
            this.libroEstadoLabel = new System.Windows.Forms.Label();
            this.libroEstadoTextBox = new System.Windows.Forms.TextBox();
            this.libroEditorialLabel = new System.Windows.Forms.Label();
            this.libroEdicionLabel = new System.Windows.Forms.Label();
            this.libroTituloLabel = new System.Windows.Forms.Label();
            this.libroIdLabel = new System.Windows.Forms.Label();
            this.buscarLibroButton = new System.Windows.Forms.Button();
            this.libroEditorialTextBox = new System.Windows.Forms.TextBox();
            this.libroEdicionTextBox = new System.Windows.Forms.TextBox();
            this.anadirLibroButton = new System.Windows.Forms.Button();
            this.libroTituloTextBox = new System.Windows.Forms.TextBox();
            this.libroIdTextBox = new System.Windows.Forms.TextBox();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.buscarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.nuevoButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.RegistroUsuariosStatusStrip = new System.Windows.Forms.StatusStrip();
            this.guardadoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ErrorToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.noEncontradoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.eliminadoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buscarClienteButton = new System.Windows.Forms.Button();
            this.clienteNombreTextBox = new System.Windows.Forms.TextBox();
            this.fechasErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.clienteErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.libroErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.fechaLibrosEntregadosDateTimePicker = new System.Windows.Forms.DateTimePicker();
            prestamoIdLabel = new System.Windows.Forms.Label();
            fechaPrestamoLabel = new System.Windows.Forms.Label();
            fechaEntregarAntesLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            this.librosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            this.RegistroUsuariosStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechasErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // prestamoIdLabel
            // 
            prestamoIdLabel.AutoSize = true;
            prestamoIdLabel.Location = new System.Drawing.Point(129, 41);
            prestamoIdLabel.Name = "prestamoIdLabel";
            prestamoIdLabel.Size = new System.Drawing.Size(66, 13);
            prestamoIdLabel.TabIndex = 1;
            prestamoIdLabel.Text = "Prestamo Id:";
            // 
            // fechaPrestamoLabel
            // 
            fechaPrestamoLabel.AutoSize = true;
            fechaPrestamoLabel.Location = new System.Drawing.Point(129, 68);
            fechaPrestamoLabel.Name = "fechaPrestamoLabel";
            fechaPrestamoLabel.Size = new System.Drawing.Size(86, 13);
            fechaPrestamoLabel.TabIndex = 3;
            fechaPrestamoLabel.Text = "Fecha prestamo:";
            // 
            // fechaEntregarAntesLabel
            // 
            fechaEntregarAntesLabel.AutoSize = true;
            fechaEntregarAntesLabel.Location = new System.Drawing.Point(129, 94);
            fechaEntregarAntesLabel.Name = "fechaEntregarAntesLabel";
            fechaEntregarAntesLabel.Size = new System.Drawing.Size(120, 13);
            fechaEntregarAntesLabel.TabIndex = 5;
            fechaEntregarAntesLabel.Text = "Fecha a entregar antes:";
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Location = new System.Drawing.Point(129, 119);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(42, 13);
            clienteIdLabel.TabIndex = 7;
            clienteIdLabel.Text = "Cliente:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(129, 146);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(89, 13);
            estadoLabel.TabIndex = 34;
            estadoLabel.Text = "Estado prestamo:";
            // 
            // prestamoIdTextBox
            // 
            this.prestamoIdTextBox.Location = new System.Drawing.Point(258, 38);
            this.prestamoIdTextBox.Name = "prestamoIdTextBox";
            this.prestamoIdTextBox.Size = new System.Drawing.Size(66, 20);
            this.prestamoIdTextBox.TabIndex = 2;
            this.prestamoIdTextBox.TextChanged += new System.EventHandler(this.prestamoIdTextBox_TextChanged);
            this.prestamoIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prestamoIdTextBox_KeyPress);
            // 
            // fechaPrestamoDateTimePicker
            // 
            this.fechaPrestamoDateTimePicker.CustomFormat = "dd/MM/yyyy   hh:mm";
            this.fechaPrestamoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaPrestamoDateTimePicker.Location = new System.Drawing.Point(258, 64);
            this.fechaPrestamoDateTimePicker.Name = "fechaPrestamoDateTimePicker";
            this.fechaPrestamoDateTimePicker.Size = new System.Drawing.Size(147, 20);
            this.fechaPrestamoDateTimePicker.TabIndex = 4;
            this.fechaPrestamoDateTimePicker.ValueChanged += new System.EventHandler(this.fechaPrestamoDateTimePicker_ValueChanged);
            // 
            // fechaEntregarAntesDateTimePicker
            // 
            this.fechaEntregarAntesDateTimePicker.CustomFormat = "dd/MM/yyyy   hh:mm";
            this.fechaEntregarAntesDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaEntregarAntesDateTimePicker.Location = new System.Drawing.Point(258, 90);
            this.fechaEntregarAntesDateTimePicker.Name = "fechaEntregarAntesDateTimePicker";
            this.fechaEntregarAntesDateTimePicker.Size = new System.Drawing.Size(147, 20);
            this.fechaEntregarAntesDateTimePicker.TabIndex = 6;
            this.fechaEntregarAntesDateTimePicker.ValueChanged += new System.EventHandler(this.fechaEntregarAntesDateTimePicker_ValueChanged);
            // 
            // clienteIdTextBox
            // 
            this.clienteIdTextBox.Location = new System.Drawing.Point(258, 116);
            this.clienteIdTextBox.Name = "clienteIdTextBox";
            this.clienteIdTextBox.Size = new System.Drawing.Size(66, 20);
            this.clienteIdTextBox.TabIndex = 8;
            this.clienteIdTextBox.TextChanged += new System.EventHandler(this.clienteIdTextBox_TextChanged);
            this.clienteIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clienteIdTextBox_KeyPress);
            // 
            // librosGroupBox
            // 
            this.librosGroupBox.Controls.Add(this.libroEstadoLabel);
            this.librosGroupBox.Controls.Add(this.libroEstadoTextBox);
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
            this.librosGroupBox.Location = new System.Drawing.Point(43, 168);
            this.librosGroupBox.Name = "librosGroupBox";
            this.librosGroupBox.Size = new System.Drawing.Size(604, 219);
            this.librosGroupBox.TabIndex = 22;
            this.librosGroupBox.TabStop = false;
            this.librosGroupBox.Text = "Libros del autor";
            this.librosGroupBox.Enter += new System.EventHandler(this.librosGroupBox_Enter);
            // 
            // libroEstadoLabel
            // 
            this.libroEstadoLabel.AutoSize = true;
            this.libroEstadoLabel.Location = new System.Drawing.Point(423, 21);
            this.libroEstadoLabel.Name = "libroEstadoLabel";
            this.libroEstadoLabel.Size = new System.Drawing.Size(40, 13);
            this.libroEstadoLabel.TabIndex = 32;
            this.libroEstadoLabel.Text = "Estado";
            // 
            // libroEstadoTextBox
            // 
            this.libroEstadoTextBox.Location = new System.Drawing.Point(420, 37);
            this.libroEstadoTextBox.Name = "libroEstadoTextBox";
            this.libroEstadoTextBox.ReadOnly = true;
            this.libroEstadoTextBox.Size = new System.Drawing.Size(97, 20);
            this.libroEstadoTextBox.TabIndex = 31;
            // 
            // libroEditorialLabel
            // 
            this.libroEditorialLabel.AutoSize = true;
            this.libroEditorialLabel.Location = new System.Drawing.Point(348, 21);
            this.libroEditorialLabel.Name = "libroEditorialLabel";
            this.libroEditorialLabel.Size = new System.Drawing.Size(44, 13);
            this.libroEditorialLabel.TabIndex = 30;
            this.libroEditorialLabel.Text = "Editorial";
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
            this.buscarLibroButton.UseVisualStyleBackColor = true;
            this.buscarLibroButton.Click += new System.EventHandler(this.buscarLibroButton_Click);
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
            this.anadirLibroButton.Location = new System.Drawing.Point(523, 32);
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
            this.librosDataGridView.Size = new System.Drawing.Size(592, 136);
            this.librosDataGridView.TabIndex = 0;
            // 
            // buscarButton
            // 
            this.buscarButton.Image = global::BiblioTechProject.Properties.Resources.ic_search_black_24dp_1x1;
            this.buscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarButton.Location = new System.Drawing.Point(330, 33);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 28);
            this.buscarButton.TabIndex = 26;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.Image = global::BiblioTechProject.Properties.Resources.ic_delete_black_24dp_1x;
            this.eliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarButton.Location = new System.Drawing.Point(370, 405);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 28);
            this.eliminarButton.TabIndex = 25;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // nuevoButton
            // 
            this.nuevoButton.Image = global::BiblioTechProject.Properties.Resources.ic_note_add_black_24dp_1x;
            this.nuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevoButton.Location = new System.Drawing.Point(186, 405);
            this.nuevoButton.Name = "nuevoButton";
            this.nuevoButton.Size = new System.Drawing.Size(75, 28);
            this.nuevoButton.TabIndex = 24;
            this.nuevoButton.Text = "Nuevo";
            this.nuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevoButton.UseVisualStyleBackColor = true;
            this.nuevoButton.Click += new System.EventHandler(this.nuevoButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.Image = global::BiblioTechProject.Properties.Resources.ic_save_black_24dp_1x;
            this.guardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardarButton.Location = new System.Drawing.Point(278, 405);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 28);
            this.guardarButton.TabIndex = 23;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // RegistroUsuariosStatusStrip
            // 
            this.RegistroUsuariosStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardadoToolStripStatusLabel,
            this.ErrorToolStripStatusLabel,
            this.noEncontradoToolStripStatusLabel,
            this.eliminadoToolStripStatusLabel});
            this.RegistroUsuariosStatusStrip.Location = new System.Drawing.Point(0, 452);
            this.RegistroUsuariosStatusStrip.Name = "RegistroUsuariosStatusStrip";
            this.RegistroUsuariosStatusStrip.Size = new System.Drawing.Size(697, 22);
            this.RegistroUsuariosStatusStrip.TabIndex = 27;
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
            // buscarClienteButton
            // 
            this.buscarClienteButton.Image = global::BiblioTechProject.Properties.Resources.ic_search_black_24dp_1x1;
            this.buscarClienteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarClienteButton.Location = new System.Drawing.Point(330, 111);
            this.buscarClienteButton.Name = "buscarClienteButton";
            this.buscarClienteButton.Size = new System.Drawing.Size(32, 28);
            this.buscarClienteButton.TabIndex = 32;
            this.buscarClienteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buscarClienteButton.UseVisualStyleBackColor = true;
            this.buscarClienteButton.Click += new System.EventHandler(this.buscarClienteButton_Click);
            // 
            // clienteNombreTextBox
            // 
            this.clienteNombreTextBox.Location = new System.Drawing.Point(368, 116);
            this.clienteNombreTextBox.Name = "clienteNombreTextBox";
            this.clienteNombreTextBox.ReadOnly = true;
            this.clienteNombreTextBox.Size = new System.Drawing.Size(192, 20);
            this.clienteNombreTextBox.TabIndex = 33;
            // 
            // fechasErrorProvider
            // 
            this.fechasErrorProvider.ContainerControl = this;
            // 
            // clienteErrorProvider
            // 
            this.clienteErrorProvider.ContainerControl = this;
            // 
            // libroErrorProvider
            // 
            this.libroErrorProvider.ContainerControl = this;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Pendiente",
            "Devuelto"});
            this.estadoComboBox.Location = new System.Drawing.Point(258, 142);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(147, 21);
            this.estadoComboBox.TabIndex = 35;
            this.estadoComboBox.SelectedIndexChanged += new System.EventHandler(this.estadoComboBox_SelectedIndexChanged);
            // 
            // fechaLibrosEntregadosDateTimePicker
            // 
            this.fechaLibrosEntregadosDateTimePicker.CustomFormat = "dd/MM/yyyy   hh:mm";
            this.fechaLibrosEntregadosDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaLibrosEntregadosDateTimePicker.Location = new System.Drawing.Point(413, 142);
            this.fechaLibrosEntregadosDateTimePicker.Name = "fechaLibrosEntregadosDateTimePicker";
            this.fechaLibrosEntregadosDateTimePicker.Size = new System.Drawing.Size(147, 20);
            this.fechaLibrosEntregadosDateTimePicker.TabIndex = 36;
            this.fechaLibrosEntregadosDateTimePicker.Visible = false;
            this.fechaLibrosEntregadosDateTimePicker.ValueChanged += new System.EventHandler(this.fechaLibrosEntregadosDateTimePicker_ValueChanged);
            // 
            // FrmRegistroPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 474);
            this.Controls.Add(this.fechaLibrosEntregadosDateTimePicker);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.buscarClienteButton);
            this.Controls.Add(this.clienteNombreTextBox);
            this.Controls.Add(this.librosGroupBox);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.nuevoButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.RegistroUsuariosStatusStrip);
            this.Controls.Add(prestamoIdLabel);
            this.Controls.Add(this.prestamoIdTextBox);
            this.Controls.Add(fechaPrestamoLabel);
            this.Controls.Add(this.fechaPrestamoDateTimePicker);
            this.Controls.Add(fechaEntregarAntesLabel);
            this.Controls.Add(this.fechaEntregarAntesDateTimePicker);
            this.Controls.Add(clienteIdLabel);
            this.Controls.Add(this.clienteIdTextBox);
            this.Name = "FrmRegistroPrestamos";
            this.Text = "BiblioTech - Registro de Prestamos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegistroPrestamos_FormClosed);
            this.Load += new System.EventHandler(this.FrmRegistroPrestamos_Load);
            this.librosGroupBox.ResumeLayout(false);
            this.librosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            this.RegistroUsuariosStatusStrip.ResumeLayout(false);
            this.RegistroUsuariosStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechasErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox prestamoIdTextBox;
        private System.Windows.Forms.DateTimePicker fechaPrestamoDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaEntregarAntesDateTimePicker;
        private System.Windows.Forms.TextBox clienteIdTextBox;
        private System.Windows.Forms.GroupBox librosGroupBox;
        private System.Windows.Forms.Label libroEditorialLabel;
        private System.Windows.Forms.Label libroEdicionLabel;
        private System.Windows.Forms.Label libroTituloLabel;
        private System.Windows.Forms.Label libroIdLabel;
        private System.Windows.Forms.Button buscarLibroButton;
        private System.Windows.Forms.TextBox libroEditorialTextBox;
        private System.Windows.Forms.TextBox libroEdicionTextBox;
        private System.Windows.Forms.Button anadirLibroButton;
        private System.Windows.Forms.TextBox libroTituloTextBox;
        private System.Windows.Forms.TextBox libroIdTextBox;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button nuevoButton;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.StatusStrip RegistroUsuariosStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel guardadoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ErrorToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel noEncontradoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel eliminadoToolStripStatusLabel;
        private System.Windows.Forms.Button buscarClienteButton;
        private System.Windows.Forms.TextBox clienteNombreTextBox;
        private System.Windows.Forms.TextBox libroEstadoTextBox;
        private System.Windows.Forms.Label libroEstadoLabel;
        private System.Windows.Forms.ErrorProvider fechasErrorProvider;
        private System.Windows.Forms.ErrorProvider clienteErrorProvider;
        private System.Windows.Forms.ErrorProvider libroErrorProvider;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.DateTimePicker fechaLibrosEntregadosDateTimePicker;
    }
}