<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Base.Master" AutoEventWireup="true" CodeBehind="RegistroAutores.aspx.cs" Inherits="BiblioTechWeb.UI.RegistroAutores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header class="text-center">
        <h1 class="display-1 d-none d-sm-block">BiblioTech</h1>
        <h1 class="display-4 d-sm-none">BiblioTech</h1>
    </header>

    <div class="row">
        <div class="col-xs-12 col-sm-2 col-md-3 col-lg-3"></div>
        <div class="col-xs-12 col-sm-8 col-md-6 col-lg-6">
            <!--header-->
            <div class="page-header text-center">
                <h1>Registro de autores</h1>
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
                    <asp:Label CssClass="text-center" ID="NuevoOModificandoLabel" runat="server" Text="Nuevo autor"></asp:Label></h4>
            </div>

            <div class="float-right">
                <asp:Button CssClass="btn btn-warning" ID="LimpiarButton" runat="server" Text="Nuevo" OnClick="LimpiarButton_Click" />
            </div>
            <br />

            <div class="form-group d-none">
                <label for="AutorIdTextBox">Autor ID</label>
                <asp:TextBox CssClass="form-control" ID="AutorIdTextBox" runat="server" autocomplete="off" OnTextChanged="AutorIdTextBox_TextChanged"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="NombreTextBox">Nombre</label>
                <asp:TextBox CssClass="form-control" ID="NombreTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>

            <br />
            <div class="text-center">
                <asp:Button CssClass="btn btn-primary btn-lg" ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
                <br />
            </div>
        </div> <!--Fin col-->

    </div> <!--Fin row-->
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

</asp:Content>
