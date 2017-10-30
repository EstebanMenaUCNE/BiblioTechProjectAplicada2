<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Base.Master" AutoEventWireup="true" CodeBehind="RegistroClientes.aspx.cs" Inherits="BiblioTechWeb.UI.RegistroClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Registro de clientes - BiblioTech</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%@ PreviousPageType VirtualPath="~/UI/ConsultaClientes.aspx" %>

    <header class="text-center">
        <h1 class="display-1 d-none d-sm-block">BiblioTech</h1>
        <h1 class="display-4 d-sm-none">BiblioTech</h1>
    </header>

    <div class="row">
        <div class="col-xs-12 col-sm-2 col-md-3 col-lg-3"></div>
        <div class="col-xs-12 col-sm-8 col-md-6 col-lg-6">
            <!--header-->
            <div class="page-header text-center">
                <h1>Registro de clientes</h1>
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

            <!--Formulario de registro de usuarios-->
            <div class="text-center">
                <h4>
                    <asp:Label CssClass="text-center" ID="NuevoOModificandoLabel" runat="server" Text="Nuevo cliente"></asp:Label>
                </h4>
            </div>

            <div class="float-right">
                <asp:Button CssClass="btn btn-warning" ID="LimpiarButton" runat="server" Text="Nuevo" OnClick="LimpiarButton_Click" />
            </div>
            <br />

            <div class="form-group d-none">
                <label for="ClienteIdTextBox">Cliente ID</label>
                <asp:TextBox CssClass="form-control" ID="ClienteIdTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="NombreTextBox">Nombre</label>
                <asp:TextBox CssClass="form-control" ID="NombreTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="CedulaTextBox">Cédula</label>
                <asp:TextBox CssClass="form-control" ID="CedulaTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="SexoDropDownList">Sexo</label>
                <asp:DropDownList CssClass="form-control" ID="SexoDropDownList" runat="server">
                    <asp:ListItem>Masculino</asp:ListItem>
                    <asp:ListItem>Femenino</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="TelefonoTextBox">Teléfono</label>
                <asp:TextBox CssClass="form-control" ID="TelefonoTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="DireccionTextBox">Dirección</label>
                <asp:TextBox CssClass="form-control" ID="DireccionTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="FechaNacimientoTextBox">Fecha de nacimiento</label>
                <asp:TextBox type="date" CssClass="form-control" ID="FechaNacimientoTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="EmailTextBox">Email</label>
                <asp:TextBox type="email" CssClass="form-control" ID="EmailTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>

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
