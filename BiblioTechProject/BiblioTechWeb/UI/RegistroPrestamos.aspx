<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Base.Master" AutoEventWireup="true" CodeBehind="RegistroPrestamos.aspx.cs" Inherits="BiblioTechWeb.UI.RegistroPrestamos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Registro de préstamos - BiblioTech</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%@ PreviousPageType VirtualPath="~/UI/ConsultaPrestamos.aspx" %>

    <header class="text-center">
        <h1 class="display-1 d-none d-sm-block">BiblioTech</h1>
        <h1 class="display-4 d-sm-none">BiblioTech</h1>
    </header>

    <div class="row">
        <div class="col-xs-12 col-sm-2 col-md-3 col-lg-3"></div>
        <div class="col-xs-12 col-sm-8 col-md-6 col-lg-6">
            <!--header-->
            <div class="page-header text-center">
                <h1>Registro de préstamos</h1>
            </div>

            <!--Alertas-->
            <div class="col-xs-12">
                <asp:Panel ID="AlertaGuardadoExito" class="alert alert-success text-center" role="alert" runat="server">
                    <asp:Label ID="MensajeAlertaGuardadoExito" runat="server">¡Guardado con éxito!</asp:Label>
                </asp:Panel>
                <asp:Panel ID="AlertaError" class="alert alert-danger text-center" role="alert" runat="server">
                    <asp:Label ID="MensajeAlertaError" runat="server">¡Algo salió mal!</asp:Label>
                </asp:Panel>
                <asp:Panel ID="AlertaValidar" class="alert alert-info text-center" role="alert" runat="server">
                    <asp:Label ID="MensajeAlertaValidar" runat="server">Por favor llene todos los campos correctamente...</asp:Label>
                </asp:Panel>
            </div>

            <!--Formulario de registro de prestamos-->
            <div class="text-center">
                <h4>
                    <asp:Label CssClass="text-center" ID="NuevoOModificandoLabel" runat="server" Text="Nuevo préstamo"></asp:Label>
                </h4>
            </div>

            <div class="float-right">
                <asp:Button CssClass="btn btn-warning" ID="LimpiarButton" runat="server" Text="Nuevo" OnClick="LimpiarButton_Click" />
            </div>
            <br />

            <div class="form-group d-none">
                <label for="LibroIdTextBox">Préstamo ID</label>
                <asp:TextBox CssClass="form-control" ID="PrestamoIdTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="FechaPrestamoTextBox">Fecha préstamo</label>
                <asp:TextBox type="date" CssClass="form-control" ID="FechaPrestamoTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="FechaEntregarAntesTextBox">Fecha a entregar antes</label>
                <asp:TextBox type="date" CssClass="form-control" ID="FechaEntregarAntesTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="ClienteDropDownList">Cliente</label>
                <asp:DropDownList CssClass="form-control" ID="ClienteDropDownList" runat="server">
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="EstadoDropDownList">Estado</label>
                <asp:DropDownList CssClass="form-control" ID="EstadoDropDownList" runat="server">
                    <asp:ListItem>Pendiente</asp:ListItem>
                    <asp:ListItem>Devuelto</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group" id="form_group_fecha_devuelto">
                <label for="FechaLibrosEntregadosTextBox">Devuelto en fecha</label>
                <asp:TextBox type="date" CssClass="form-control" ID="FechaLibrosEntregadosTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            

            <%-- Detalle --%>
            <label>Libro a agregar</label>
            <div class="form-row">
                <div class="form-group col-lg-9 col-xl-10">
                    <asp:DropDownList CssClass="form-control" ID="LibrosDropDownList" runat="server">
                    </asp:DropDownList>
                </div>
                <div class="form-group col-lg-3 col-xl-2">
                    <asp:Button CssClass="float-right btn btn-success" ID="AgregarButton" runat="server" Text="Agregar" OnClick="AgregarButton_Click" />
                </div>
            </div>
            <asp:GridView ID="LibrosGridView" runat="server" CssClass="table table-hover table-responsive">
                <HeaderStyle CssClass="bg-info" />
            </asp:GridView>
            <asp:Button CssClass="float-right btn btn-danger btn-sm" ID="EliminarLibrosButton" runat="server" Text="Eliminar libros" OnClick="EliminarLibrosButton_Click"/>

            <br />
            <br />
            <div class="text-center">
                <asp:Button CssClass="btn btn-primary btn-lg" ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
                <br />
            </div>
        </div>
        <!--Fin col-->

    </div>
    <!--Fin row-->
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
