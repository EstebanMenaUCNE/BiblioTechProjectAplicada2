namespace BiblioTechProject.UI.Consultas
{
    partial class FrmConsultaLibros
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
            this.autoresDataGridView = new System.Windows.Forms.DataGridView();
            this.filtrarTextBox = new System.Windows.Forms.TextBox();
            this.filtrarLabel = new System.Windows.Forms.Label();
            this.filtrarComboBox = new System.Windows.Forms.ComboBox();
            this.estadosComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filtrarButton
            // 
            this.filtrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtrarButton.Image = global::BiblioTechProject.Properties.Resources.ic_search_black_24dp_1x;
            this.filtrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filtrarButton.Location = new System.Drawing.Point(512, 34);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(75, 28);
            this.filtrarButton.TabIndex = 19;
            this.filtrarButton.Text = "Filtrar   ";
            this.filtrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filtrarButton.UseVisualStyleBackColor = true;
            this.filtrarButton.Click += new System.EventHandler(this.filtrarButton_Click);
            // 
            // autoresDataGridView
            // 
            this.autoresDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoresDataGridView.Location = new System.Drawing.Point(41, 76);
            this.autoresDataGridView.Name = "autoresDataGridView";
            this.autoresDataGridView.Size = new System.Drawing.Size(546, 150);
            this.autoresDataGridView.TabIndex = 18;
            // 
            // filtrarTextBox
            // 
            this.filtrarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtrarTextBox.Location = new System.Drawing.Point(221, 39);
            this.filtrarTextBox.Name = "filtrarTextBox";
            this.filtrarTextBox.Size = new System.Drawing.Size(285, 20);
            this.filtrarTextBox.TabIndex = 17;
            this.filtrarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filtrarTextBox_KeyPress);
            // 
            // filtrarLabel
            // 
            this.filtrarLabel.AutoSize = true;
            this.filtrarLabel.Location = new System.Drawing.Point(38, 42);
            this.filtrarLabel.Name = "filtrarLabel";
            this.filtrarLabel.Size = new System.Drawing.Size(50, 13);
            this.filtrarLabel.TabIndex = 16;
            this.filtrarLabel.Text = "Filtrar por";
            // 
            // filtrarComboBox
            // 
            this.filtrarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrarComboBox.FormattingEnabled = true;
            this.filtrarComboBox.Items.AddRange(new object[] {
            "Todo",
            "Id",
            "Título",
            "Estado",
            "Editorial",
            "Autor"});
            this.filtrarComboBox.Location = new System.Drawing.Point(94, 39);
            this.filtrarComboBox.Name = "filtrarComboBox";
            this.filtrarComboBox.Size = new System.Drawing.Size(121, 21);
            this.filtrarComboBox.TabIndex = 15;
            this.filtrarComboBox.SelectedIndexChanged += new System.EventHandler(this.filtrarComboBox_SelectedIndexChanged);
            // 
            // estadosComboBox
            // 
            this.estadosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadosComboBox.FormattingEnabled = true;
            this.estadosComboBox.Items.AddRange(new object[] {
            "Disponible",
            "Prestado",
            "Reparación",
            "Desaparecido",
            "En mal estado"});
            this.estadosComboBox.Location = new System.Drawing.Point(221, 39);
            this.estadosComboBox.Name = "estadosComboBox";
            this.estadosComboBox.Size = new System.Drawing.Size(285, 21);
            this.estadosComboBox.TabIndex = 20;
            this.estadosComboBox.Visible = false;
            // 
            // FrmConsultaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 261);
            this.Controls.Add(this.estadosComboBox);
            this.Controls.Add(this.filtrarButton);
            this.Controls.Add(this.autoresDataGridView);
            this.Controls.Add(this.filtrarTextBox);
            this.Controls.Add(this.filtrarLabel);
            this.Controls.Add(this.filtrarComboBox);
            this.Name = "FrmConsultaLibros";
            this.Text = "BiblioTech - Consulta de Libros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConsultaLibros_FormClosed);
            this.Load += new System.EventHandler(this.FrmConsultaLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.DataGridView autoresDataGridView;
        private System.Windows.Forms.TextBox filtrarTextBox;
        private System.Windows.Forms.Label filtrarLabel;
        private System.Windows.Forms.ComboBox filtrarComboBox;
        private System.Windows.Forms.ComboBox estadosComboBox;
    }
}