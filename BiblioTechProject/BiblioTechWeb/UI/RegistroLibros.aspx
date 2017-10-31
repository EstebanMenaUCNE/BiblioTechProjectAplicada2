<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Base.Master" AutoEventWireup="true" CodeBehind="RegistroLibros.aspx.cs" Inherits="BiblioTechWeb.UI.RegistroLibros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Registro de libros - BiblioTech</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%@ PreviousPageType VirtualPath="~/UI/ConsultaLibros.aspx" %>

    <header class="text-center">
        <h1 class="display-1 d-none d-sm-block">BiblioTech</h1>
        <h1 class="display-4 d-sm-none">BiblioTech</h1>
    </header>

    <div class="row">
        <div class="col-xs-12 col-sm-2 col-md-3 col-lg-3"></div>
        <div class="col-xs-12 col-sm-8 col-md-6 col-lg-6">
            <!--header-->
            <div class="page-header text-center">
                <h1>Registro de libros</h1>
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
                    <asp:Label CssClass="text-center" ID="NuevoOModificandoLabel" runat="server" Text="Nuevo libro"></asp:Label>
                </h4>
            </div>

            <div class="float-right">
                <asp:Button CssClass="btn btn-warning" ID="LimpiarButton" runat="server" Text="Nuevo" OnClick="LimpiarButton_Click" />
            </div>
            <br />

            <div class="form-group d-none">
                <label for="LibroIdTextBox">Cliente ID</label>
                <asp:TextBox CssClass="form-control" ID="LibroIdTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="TituloTextBox">Título</label>
                <asp:TextBox CssClass="form-control" ID="TituloTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="EdicionTextBox">Edición</label>
                <asp:TextBox type="number" CssClass="form-control" ID="EdicionTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="EstadoDropDownList">Estado</label>
                <asp:DropDownList CssClass="form-control" ID="EstadoDropDownList" runat="server">
                    <asp:ListItem>Disponible</asp:ListItem>
                    <asp:ListItem>Prestado</asp:ListItem>
                    <asp:ListItem>Reparación</asp:ListItem>
                    <asp:ListItem>Desaparecido</asp:ListItem>
                    <asp:ListItem>En mal estado</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="EditorialDropDownList">Editorial</label>
                <asp:DropDownList CssClass="form-control" ID="EditorialDropDownList" runat="server">
                </asp:DropDownList>
            </div>

            <%-- Detalle --%>
            <label>Autor a agregar</label>
            <div class="form-row">
                <div class="form-group col-lg-9 col-xl-10">
                    <asp:DropDownList CssClass="form-control" ID="AutoresDropDownList" runat="server">
                    </asp:DropDownList>
                </div>
                <div class="form-group col-lg-3 col-xl-2">
                    <asp:Button CssClass="float-right btn btn-success" ID="AgregarButton" runat="server" Text="Agregar" OnClick="AgregarButton_Click" />
                </div>
            </div>
            <asp:GridView ID="AutoresGridView" runat="server" CssClass="table table-hover table-responsive">
                <HeaderStyle CssClass="bg-info" />
            </asp:GridView>
            <asp:Button CssClass="float-right btn btn-danger btn-sm" ID="EliminarAutoresButton" runat="server" Text="Eliminar autores" OnClick="EliminarAutoresButton_Click"/>

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
