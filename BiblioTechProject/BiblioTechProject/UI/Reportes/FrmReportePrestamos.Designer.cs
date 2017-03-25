namespace BiblioTechProject.UI.Reportes
{
    partial class FrmReportePrestamos
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
            this.prestamosReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // prestamosReportViewer
            // 
            this.prestamosReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prestamosReportViewer.Location = new System.Drawing.Point(0, 0);
            this.prestamosReportViewer.Name = "prestamosReportViewer";
            this.prestamosReportViewer.Size = new System.Drawing.Size(819, 366);
            this.prestamosReportViewer.TabIndex = 0;
            // 
            // FrmReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 366);
            this.Controls.Add(this.prestamosReportViewer);
            this.Name = "FrmReportePrestamos";
            this.Text = "BiblioTech - Reporte de Prestamos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmReportePrestamos_FormClosed);
            this.Load += new System.EventHandler(this.FrmReportePrestamos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer prestamosReportViewer;
    }
}