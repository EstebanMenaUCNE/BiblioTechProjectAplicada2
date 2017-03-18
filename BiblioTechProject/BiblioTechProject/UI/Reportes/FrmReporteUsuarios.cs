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
    public partial class FrmReporteUsuarios : Form
    {
        public FrmReporteUsuarios()
        {
            InitializeComponent();
        }

        private void FrmReporteUsuarios_Load(object sender, EventArgs e)
        {            
            this.usuariosReportViewer.Reset();
            this.usuariosReportViewer.ProcessingMode = ProcessingMode.Local;
            this.usuariosReportViewer.LocalReport.ReportPath = @"C:\Users\Equipo\Desktop\Programacion Aplicada 1\BiblioTechProjectAplicada1\BiblioTechProject\BiblioTechProject\UI\Reportes\UsuariosReport.rdlc";

            ReportDataSource source = new ReportDataSource("DataSet", BLL.UsuarioBLL.GetList(U => U.UsuarioId > 0));
            this.usuariosReportViewer.LocalReport.DataSources.Add(source);
            this.usuariosReportViewer.RefreshReport();
        }
    }
}
