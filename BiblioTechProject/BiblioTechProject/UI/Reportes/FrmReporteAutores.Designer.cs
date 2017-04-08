namespace BiblioTechProject.UI.Reportes
{
    partial class FrmReporteAutores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteAutores));
            this.autoresReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // autoresReportViewer
            // 
            this.autoresReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoresReportViewer.Location = new System.Drawing.Point(0, 0);
            this.autoresReportViewer.Name = "autoresReportViewer";
            this.autoresReportViewer.Size = new System.Drawing.Size(822, 361);
            this.autoresReportViewer.TabIndex = 0;
            // 
            // FrmReporteAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 361);
            this.Controls.Add(this.autoresReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteAutores";
            this.Text = "BiblioTech - Reporte de Autores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmReporteAutores_FormClosed);
            this.Load += new System.EventHandler(this.FrmReporteAutores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer autoresReportViewer;
    }
}