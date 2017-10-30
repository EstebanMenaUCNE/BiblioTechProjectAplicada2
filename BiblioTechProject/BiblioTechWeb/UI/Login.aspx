<%@ Page Title="Inicio de sesión" Language="C#" MasterPageFile="~/UI/Base.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BiblioTechWeb.UI.LoginN" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Inicio de sesión - BiblioTech</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <header class="text-center">
        <h1 class="display-1 d-none d-sm-block">BiblioTech</h1>
        <h1 class="display-4 d-sm-none">BiblioTech</h1>
    </header>

    <div class="row">
        <div class="col-xs-12 col-sm-2 col-md-4 col-lg-4"></div>
        <div class="col-xs-12 col-sm-8 col-md-4 col-lg-4">
            <!--header-->
            <div class="page-header text-center">
                <h1 id="H1Inicio">Inicio de sesión</h1>
            </div>
            <br />

            <%--Formulario de inicio de sesión--%>
            <div class="form-group">
                <label for="UsuarioTextBox">Usuario</label>
                <asp:TextBox class="form-control" ID="UsuarioTextBox" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="ContrasenaTextBox">Contraseña</label>
                <asp:TextBox type="password" class="form-control" ID="ContrasenaTextBox" runat="server"></asp:TextBox>
            </div>

            <br />
            <div class="text-center">
                <asp:Button CssClass="btn-notificacion btn btn-primary btn-lg" ID="LoginButton" runat="server" Text="Iniciar sesión" OnClick="LoginButton_Click" />
                <br />
            </div>
        </div>
        <!--Fin col-->
        <div class="col-xs-12 col-sm-2 col-md-4 col-lg-4"></div>

    </div>
    <!--Fin row-->

    <br />
    <br />
    <br />

</asp:Content>
