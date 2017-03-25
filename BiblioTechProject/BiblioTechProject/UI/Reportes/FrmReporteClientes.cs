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
    public partial class FrmReporteClientes : Form
    {
        private static FrmReporteClientes formulario = null;

        private FrmReporteClientes()
        {
            InitializeComponent();
        }

        public static FrmReporteClientes GetInstance()
        {
            if (formulario == null)
            {
                formulario = new FrmReporteClientes();
            }
            return formulario;
        }

        private void FrmReporteClientes_Load(object sender, EventArgs e)
        {
            this.clientesReportViewer.Reset();
            this.clientesReportViewer.ProcessingMode = ProcessingMode.Local;
            this.clientesReportViewer.LocalReport.ReportPath = @"C:\Users\Equipo\Desktop\Programacion Aplicada 1\BiblioTechProjectAplicada1\BiblioTechProject\BiblioTechProject\UI\Reportes\ClientesReport.rdlc";

            ReportDataSource source = new ReportDataSource("ClientesDataSet", Consultas.FrmConsultaClientes.GetInstance().Lista);
            this.clientesReportViewer.LocalReport.DataSources.Add(source);
            this.clientesReportViewer.RefreshReport();
        }

        private void FrmReporteClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario = null;
        }
    }
}
