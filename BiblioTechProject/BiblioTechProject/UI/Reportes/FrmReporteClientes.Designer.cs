namespace BiblioTechProject.UI.Reportes
{
    partial class FrmReporteClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteClientes));
            this.SuspendLayout();
            // 
            // clientesReportViewer
            // 
            // 
            // FrmReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 364);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteClientes";
            this.Text = "BiblioTech - Reporte de Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmReporteClientes_FormClosed);
            this.Load += new System.EventHandler(this.FrmReporteClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        
    }
}