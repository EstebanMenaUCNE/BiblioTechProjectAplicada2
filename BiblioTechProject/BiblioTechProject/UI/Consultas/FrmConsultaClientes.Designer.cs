namespace BiblioTechProject.UI.Consultas
{
    partial class FrmConsultaClientes
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
            this.filtrarButton = new System.Windows.Forms.Button();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.filtrarLabel = new System.Windows.Forms.Label();
            this.filtrarComboBox = new System.Windows.Forms.ComboBox();
            this.filtrarMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.desdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.desdeLabel = new System.Windows.Forms.Label();
            this.hastaLabel = new System.Windows.Forms.Label();
            this.filtrarFechasCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filtrarButton
            // 
            this.filtrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtrarButton.Location = new System.Drawing.Point(784, 34);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(75, 23);
            this.filtrarButton.TabIndex = 9;
            this.filtrarButton.Text = "Filtrar";
            this.filtrarButton.UseVisualStyleBackColor = true;
            this.filtrarButton.Click += new System.EventHandler(this.filtrarButton_Click);
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Location = new System.Drawing.Point(34, 90);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.Size = new System.Drawing.Size(825, 187);
            this.clientesDataGridView.TabIndex = 8;
            // 
            // filtrarLabel
            // 
            this.filtrarLabel.AutoSize = true;
            this.filtrarLabel.Location = new System.Drawing.Point(31, 39);
            this.filtrarLabel.Name = "filtrarLabel";
            this.filtrarLabel.Size = new System.Drawing.Size(50, 13);
            this.filtrarLabel.TabIndex = 6;
            this.filtrarLabel.Text = "Filtrar por";
            // 
            // filtrarComboBox
            // 
            this.filtrarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrarComboBox.FormattingEnabled = true;
            this.filtrarComboBox.Items.AddRange(new object[] {
            "Todo",
            "Id",
            "Nombre",
            "Cédula",
            "Teléfono",
            "Email"});
            this.filtrarComboBox.Location = new System.Drawing.Point(87, 36);
            this.filtrarComboBox.Name = "filtrarComboBox";
            this.filtrarComboBox.Size = new System.Drawing.Size(121, 21);
            this.filtrarComboBox.TabIndex = 5;
            this.filtrarComboBox.SelectedIndexChanged += new System.EventHandler(this.filtrarComboBox_SelectedIndexChanged);
            // 
            // filtrarMaskedTextBox
            // 
            this.filtrarMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtrarMaskedTextBox.Location = new System.Drawing.Point(214, 36);
            this.filtrarMaskedTextBox.Name = "filtrarMaskedTextBox";
            this.filtrarMaskedTextBox.Size = new System.Drawing.Size(564, 20);
            this.filtrarMaskedTextBox.TabIndex = 10;
            // 
            // desdeDateTimePicker
            // 
            this.desdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.desdeDateTimePicker.Location = new System.Drawing.Point(255, 65);
            this.desdeDateTimePicker.Name = "desdeDateTimePicker";
            this.desdeDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.desdeDateTimePicker.TabIndex = 11;
            // 
            // hastaDateTimePicker
            // 
            this.hastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hastaDateTimePicker.Location = new System.Drawing.Point(422, 65);
            this.hastaDateTimePicker.Name = "hastaDateTimePicker";
            this.hastaDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.hastaDateTimePicker.TabIndex = 12;
            // 
            // desdeLabel
            // 
            this.desdeLabel.AutoSize = true;
            this.desdeLabel.Location = new System.Drawing.Point(211, 68);
            this.desdeLabel.Name = "desdeLabel";
            this.desdeLabel.Size = new System.Drawing.Size(38, 13);
            this.desdeLabel.TabIndex = 13;
            this.desdeLabel.Text = "Desde";
            // 
            // hastaLabel
            // 
            this.hastaLabel.AutoSize = true;
            this.hastaLabel.Location = new System.Drawing.Point(381, 68);
            this.hastaLabel.Name = "hastaLabel";
            this.hastaLabel.Size = new System.Drawing.Size(35, 13);
            this.hastaLabel.TabIndex = 14;
            this.hastaLabel.Text = "Hasta";
            // 
            // filtrarFechasCheckBox
            // 
            this.filtrarFechasCheckBox.AutoSize = true;
            this.filtrarFechasCheckBox.Location = new System.Drawing.Point(34, 67);
            this.filtrarFechasCheckBox.Name = "filtrarFechasCheckBox";
            this.filtrarFechasCheckBox.Size = new System.Drawing.Size(173, 17);
            this.filtrarFechasCheckBox.TabIndex = 15;
            this.filtrarFechasCheckBox.Text = "Filtrar por fechas de nacimiento";
            this.filtrarFechasCheckBox.UseVisualStyleBackColor = true;
            this.filtrarFechasCheckBox.CheckedChanged += new System.EventHandler(this.filtrarFechasCheckBox_CheckedChanged);
            // 
            // FrmConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 317);
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
            this.Name = "FrmConsultaClientes";
            this.Text = "BiblioTech - Consulta de Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConsultaClientes_FormClosed);
            this.Load += new System.EventHandler(this.FrmConsultaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.Label filtrarLabel;
        private System.Windows.Forms.ComboBox filtrarComboBox;
        private System.Windows.Forms.MaskedTextBox filtrarMaskedTextBox;
        private System.Windows.Forms.DateTimePicker desdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker hastaDateTimePicker;
        private System.Windows.Forms.Label desdeLabel;
        private System.Windows.Forms.Label hastaLabel;
        private System.Windows.Forms.CheckBox filtrarFechasCheckBox;
    }
}