﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiblioTechWeb.UI.Reportes
{
    public partial class ReportePrestamos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null && PreviousPage.Lista != null)
            {
                if (!Page.IsPostBack)
                {
                    ReportViewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
                    ReportViewer.Reset();
                    ReportViewer.LocalReport.ReportPath = Server.MapPath(@"~/UI/Reportes/ReportePrestamos.rdlc");
                    ReportViewer.LocalReport.DataSources.Clear();
                    ReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("PrestamosDataSet", PreviousPage.Lista));
                    ReportViewer.LocalReport.Refresh();
                }
            }
        }
    }
}