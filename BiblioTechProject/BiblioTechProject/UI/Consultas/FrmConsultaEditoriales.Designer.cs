namespace BiblioTechProject.UI.Consultas
{
    partial class FrmConsultaEditoriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaEditoriales));
            this.filtrarButton = new System.Windows.Forms.Button();
            this.editorialesDataGridView = new System.Windows.Forms.DataGridView();
            this.filtrarTextBox = new System.Windows.Forms.TextBox();
            this.filtrarLabel = new System.Windows.Forms.Label();
            this.filtrarComboBox = new System.Windows.Forms.ComboBox();
            this.imprimirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editorialesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filtrarButton
            // 
            this.filtrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtrarButton.Image = global::BiblioTechProject.Properties.Resources.ic_search_black_24dp_1x;
            this.filtrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filtrarButton.Location = new System.Drawing.Point(427, 34);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(75, 28);
            this.filtrarButton.TabIndex = 9;
            this.filtrarButton.Text = "Filtrar   ";
            this.filtrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filtrarButton.UseVisualStyleBackColor = true;
            this.filtrarButton.Click += new System.EventHandler(this.filtrarButton_Click);
            // 
            // editorialesDataGridView
            // 
            this.editorialesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorialesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editorialesDataGridView.Location = new System.Drawing.Point(37, 76);
            this.editorialesDataGridView.Name = "editorialesDataGridView";
            this.editorialesDataGridView.Size = new System.Drawing.Size(546, 150);
            this.editorialesDataGridView.TabIndex = 8;
            // 
            // filtrarTextBox
            // 
            this.filtrarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtrarTextBox.Location = new System.Drawing.Point(217, 39);
            this.filtrarTextBox.Name = "filtrarTextBox";
            this.filtrarTextBox.Size = new System.Drawing.Size(204, 20);
            this.filtrarTextBox.TabIndex = 7;
            this.filtrarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filtrarTextBox_KeyPress);
            // 
            // filtrarLabel
            // 
            this.filtrarLabel.AutoSize = true;
            this.filtrarLabel.Location = new System.Drawing.Point(34, 42);
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
            "Nombre"});
            this.filtrarComboBox.Location = new System.Drawing.Point(90, 39);
            this.filtrarComboBox.Name = "filtrarComboBox";
            this.filtrarComboBox.Size = new System.Drawing.Size(121, 21);
            this.filtrarComboBox.TabIndex = 5;
            this.filtrarComboBox.SelectedIndexChanged += new System.EventHandler(this.filtrarComboBox_SelectedIndexChanged);
            // 
            // imprimirButton
            // 
            this.imprimirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imprimirButton.Image = global::BiblioTechProject.Properties.Resources.ic_print_black_24dp_1x;
            this.imprimirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imprimirButton.Location = new System.Drawing.Point(508, 34);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(75, 28);
            this.imprimirButton.TabIndex = 10;
            this.imprimirButton.Text = "Imprimir";
            this.imprimirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imprimirButton.UseVisualStyleBackColor = true;
            this.imprimirButton.Click += new System.EventHandler(this.imprimirButton_Click);
            // 
            // FrmConsultaEditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 261);
            this.Controls.Add(this.imprimirButton);
            this.Controls.Add(this.filtrarButton);
            this.Controls.Add(this.editorialesDataGridView);
            this.Controls.Add(this.filtrarTextBox);
            this.Controls.Add(this.filtrarLabel);
            this.Controls.Add(this.filtrarComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaEditoriales";
            this.Text = "BilblioTech - Consulta de Editoriales";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConsultaEditoriales_FormClosed);
            this.Load += new System.EventHandler(this.FrmConsultaEditoriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editorialesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.DataGridView editorialesDataGridView;
        private System.Windows.Forms.TextBox filtrarTextBox;
        private System.Windows.Forms.Label filtrarLabel;
        private System.Windows.Forms.ComboBox filtrarComboBox;
        private System.Windows.Forms.Button imprimirButton;
    }
}