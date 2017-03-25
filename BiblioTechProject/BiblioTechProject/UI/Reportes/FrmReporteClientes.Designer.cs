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
            this.clientesReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // clientesReportViewer
            // 
            this.clientesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientesReportViewer.Location = new System.Drawing.Point(0, 0);
            this.clientesReportViewer.Name = "clientesReportViewer";
            this.clientesReportViewer.Size = new System.Drawing.Size(826, 364);
            this.clientesReportViewer.TabIndex = 0;
            // 
            // FrmReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 364);
            this.Controls.Add(this.clientesReportViewer);
            this.Name = "FrmReporteClientes";
            this.Text = "BiblioTech - Reporte de Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmReporteClientes_FormClosed);
            this.Load += new System.EventHandler(this.FrmReporteClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer clientesReportViewer;
    }
}