namespace BiblioTechProject.UI.Reportes
{
    partial class FrmReporteLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteLibros));
            this.librosReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // librosReportViewer
            // 
            this.librosReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.librosReportViewer.Location = new System.Drawing.Point(0, 0);
            this.librosReportViewer.Name = "librosReportViewer";
            this.librosReportViewer.Size = new System.Drawing.Size(828, 366);
            this.librosReportViewer.TabIndex = 0;
            // 
            // FrmReporteLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 366);
            this.Controls.Add(this.librosReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteLibros";
            this.Text = "BiblioTec - Reporte de Libros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmReporteLibros_FormClosed);
            this.Load += new System.EventHandler(this.FrmReporteLibros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer librosReportViewer;
    }
}