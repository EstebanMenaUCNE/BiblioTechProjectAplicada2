using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BiblioTechProject.UI.Reportes
{
    public partial class FrmReporteLibros : Form
    {
        private static FrmReporteLibros formulario = null;

        private FrmReporteLibros()
        {
            InitializeComponent();
        }

        public static FrmReporteLibros GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmReporteLibros();
            }
            return formulario;
        }

        private void FrmReporteLibros_Load(object sender, EventArgs e)
        {
            this.librosReportViewer.Reset();
            this.librosReportViewer.ProcessingMode = ProcessingMode.Local;
            this.librosReportViewer.LocalReport.ReportPath = @"C:\Users\Equipo\Desktop\Programacion Aplicada 1\BiblioTechProjectAplicada1\BiblioTechProject\BiblioTechProject\UI\Reportes\LibrosReport.rdlc";

            ReportDataSource source = new ReportDataSource("LibrosDataSet", Consultas.FrmConsultaLibros.GetInstance().Lista);
            this.librosReportViewer.LocalReport.DataSources.Add(source);
            this.librosReportViewer.RefreshReport();
        }

        private void FrmReporteLibros_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
