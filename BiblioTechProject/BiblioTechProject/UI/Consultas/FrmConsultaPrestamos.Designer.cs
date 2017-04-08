namespace BiblioTechProject.UI.Consultas
{
    partial class FrmConsultaPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaPrestamos));
            this.filtrarFechasCheckBox = new System.Windows.Forms.CheckBox();
            this.hastaLabel = new System.Windows.Forms.Label();
            this.desdeLabel = new System.Windows.Forms.Label();
            this.hastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.desdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.filtrarMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.filtrarButton = new System.Windows.Forms.Button();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.filtrarLabel = new System.Windows.Forms.Label();
            this.filtrarComboBox = new System.Windows.Forms.ComboBox();
            this.imprimirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filtrarFechasCheckBox
            // 
            this.filtrarFechasCheckBox.AutoSize = true;
            this.filtrarFechasCheckBox.Location = new System.Drawing.Point(37, 70);
            this.filtrarFechasCheckBox.Name = "filtrarFechasCheckBox";
            this.filtrarFechasCheckBox.Size = new System.Drawing.Size(141, 17);
            this.filtrarFechasCheckBox.TabIndex = 25;
            this.filtrarFechasCheckBox.Text = "Filtrar por fechas y horas";
            this.filtrarFechasCheckBox.UseVisualStyleBackColor = true;
            this.filtrarFechasCheckBox.CheckedChanged += new System.EventHandler(this.filtrarFechasCheckBox_CheckedChanged);
            // 
            // hastaLabel
            // 
            this.hastaLabel.AutoSize = true;
            this.hastaLabel.Location = new System.Drawing.Point(424, 71);
            this.hastaLabel.Name = "hastaLabel";
            this.hastaLabel.Size = new System.Drawing.Size(35, 13);
            this.hastaLabel.TabIndex = 24;
            this.hastaLabel.Text = "Hasta";
            // 
            // desdeLabel
            // 
            this.desdeLabel.AutoSize = true;
            this.desdeLabel.Location = new System.Drawing.Point(214, 71);
            this.desdeLabel.Name = "desdeLabel";
            this.desdeLabel.Size = new System.Drawing.Size(38, 13);
            this.desdeLabel.TabIndex = 23;
            this.desdeLabel.Text = "Desde";
            // 
            // hastaDateTimePicker
            // 
            this.hastaDateTimePicker.CustomFormat = "dd/MM/yyyy   hh:mm tt";
            this.hastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hastaDateTimePicker.Location = new System.Drawing.Point(466, 68);
            this.hastaDateTimePicker.Name = "hastaDateTimePicker";
            this.hastaDateTimePicker.Size = new System.Drawing.Size(158, 20);
            this.hastaDateTimePicker.TabIndex = 22;
            this.hastaDateTimePicker.ValueChanged += new System.EventHandler(this.hastaDateTimePicker_ValueChanged);
            // 
            // desdeDateTimePicker
            // 
            this.desdeDateTimePicker.CustomFormat = "dd/MM/yyyy   hh:mm tt";
            this.desdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.desdeDateTimePicker.Location = new System.Drawing.Point(258, 68);
            this.desdeDateTimePicker.Name = "desdeDateTimePicker";
            this.desdeDateTimePicker.Size = new System.Drawing.Size(158, 20);
            this.desdeDateTimePicker.TabIndex = 21;
            // 
            // filtrarMaskedTextBox
            // 
            this.filtrarMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtrarMaskedTextBox.Location = new System.Drawing.Point(217, 39);
            this.filtrarMaskedTextBox.Name = "filtrarMaskedTextBox";
            this.filtrarMaskedTextBox.Size = new System.Drawing.Size(483, 20);
            this.filtrarMaskedTextBox.TabIndex = 20;
            this.filtrarMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filtrarMaskedTextBox_KeyPress);
            // 
            // filtrarButton
            // 
            this.filtrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtrarButton.Image = global::BiblioTechProject.Properties.Resources.ic_search_black_24dp_1x;
            this.filtrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filtrarButton.Location = new System.Drawing.Point(706, 34);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(75, 28);
            this.filtrarButton.TabIndex = 19;
            this.filtrarButton.Text = "Filtrar   ";
            this.filtrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filtrarButton.UseVisualStyleBackColor = true;
            this.filtrarButton.Click += new System.EventHandler(this.filtrarButton_Click);
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Location = new System.Drawing.Point(37, 93);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.Size = new System.Drawing.Size(825, 187);
            this.clientesDataGridView.TabIndex = 18;
            // 
            // filtrarLabel
            // 
            this.filtrarLabel.AutoSize = true;
            this.filtrarLabel.Location = new System.Drawing.Point(34, 42);
            this.filtrarLabel.Name = "filtrarLabel";
            this.filtrarLabel.Size = new System.Drawing.Size(50, 13);
            this.filtrarLabel.TabIndex = 17;
            this.filtrarLabel.Text = "Filtrar por";
            // 
            // filtrarComboBox
            // 
            this.filtrarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrarComboBox.FormattingEnabled = true;
            this.filtrarComboBox.Items.AddRange(new object[] {
            "Todo",
            "Id",
            "Cliente (Id)",
            "Cliente (Nombre)",
            "Pendientes",
            "Devueltos",
            "Retrasados"});
            this.filtrarComboBox.Location = new System.Drawing.Point(90, 39);
            this.filtrarComboBox.Name = "filtrarComboBox";
            this.filtrarComboBox.Size = new System.Drawing.Size(121, 21);
            this.filtrarComboBox.TabIndex = 16;
            this.filtrarComboBox.SelectedIndexChanged += new System.EventHandler(this.filtrarComboBox_SelectedIndexChanged);
            // 
            // imprimirButton
            // 
            this.imprimirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imprimirButton.Image = global::BiblioTechProject.Properties.Resources.ic_print_black_24dp_1x;
            this.imprimirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imprimirButton.Location = new System.Drawing.Point(787, 34);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(75, 28);
            this.imprimirButton.TabIndex = 26;
            this.imprimirButton.Text = "Imprimir";
            this.imprimirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imprimirButton.UseVisualStyleBackColor = true;
            this.imprimirButton.Click += new System.EventHandler(this.imprimirButton_Click);
            // 
            // FrmConsultaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 315);
            this.Controls.Add(this.imprimirButton);
            this.Controls.Add(this.filtrarFechasCheckBox);
            this.Controls.Add(this.hastaLabel);
            this.Controls.Add(this.desdeLabel);
            this.Controls.Add(this.hastaDateTimePicker);
            this.Controls.Add(this.desdeDateTimePicker);
            this.Controls.Add(this.filtrarMaskedTextBox);
            this.Controls.Add(this.filtrarButton);
            this.Controls.Add(this.clientesDataGridView);
            this.Controls.Add(this.filtrarLabel);
            this.Controls.Add(this.filtrarComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaPrestamos";
            this.Text = "BiblioTech - Consulta de Prestamos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConsultaPrestamos_FormClosed);
            this.Load += new System.EventHandler(this.FrmConsultaPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox filtrarFechasCheckBox;
        private System.Windows.Forms.Label hastaLabel;
        private System.Windows.Forms.Label desdeLabel;
        private System.Windows.Forms.DateTimePicker hastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker desdeDateTimePicker;
        private System.Windows.Forms.MaskedTextBox filtrarMaskedTextBox;
        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.Label filtrarLabel;
        private System.Windows.Forms.ComboBox filtrarComboBox;
        private System.Windows.Forms.Button imprimirButton;
    }
}