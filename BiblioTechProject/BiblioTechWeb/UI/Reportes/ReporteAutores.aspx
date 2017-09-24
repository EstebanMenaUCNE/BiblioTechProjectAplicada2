<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReporteAutores.aspx.cs" Inherits="BiblioTechWeb.UI.Reportes.ReporteAutores" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=14.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <meta lang="es-ES"/>
    <title>Reporte de autores</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
</head>
<body style="height: 751px">
    <form id="formulario" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer" runat="server" ProcessingMode="Local" Height="715px" Width="967px" style="margin-right: 57px">
            <ServerReport ReportPath="" ReportServerUrl="" />
        </rsweb:ReportViewer>

    </form>
</body>
</html>
