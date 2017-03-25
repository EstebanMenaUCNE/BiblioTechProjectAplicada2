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
    public partial class FrmReporteEditoriales : Form
    {
        private static FrmReporteEditoriales formulario = null;

        private FrmReporteEditoriales()
        {
            InitializeComponent();
        }

        public static FrmReporteEditoriales GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmReporteEditoriales();
            }
            return formulario;
        }

        private void FrmReporteEditoriales_Load(object sender, EventArgs e)
        {
            this.editorialesReportViewer.Reset();
            this.editorialesReportViewer.ProcessingMode = ProcessingMode.Local;
            this.editorialesReportViewer.LocalReport.ReportPath = @"C:\Users\Equipo\Desktop\Programacion Aplicada 1\BiblioTechProjectAplicada1\BiblioTechProject\BiblioTechProject\UI\Reportes\EditorialesReport.rdlc";

            ReportDataSource source = new ReportDataSource("EditorialesDataSet", Consultas.FrmConsultaEditoriales.GetInstance().Lista);
            this.editorialesReportViewer.LocalReport.DataSources.Add(source);
            this.editorialesReportViewer.RefreshReport();
        }

        private void FrmReporteEditoriales_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
