<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Base.Master" AutoEventWireup="true" CodeBehind="RegistroUsuarios.aspx.cs" Inherits="BiblioTechWeb.UI.Registros.MRegistroUsuarios" %>

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
                <h1>Registro de usuarios</h1>
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
                    <asp:Label ID="YaExisteAlertaValidar" runat="server">¡El nombre de usuario del usuario ya existe!</asp:Label>
                </asp:Panel>
            </div>

            <!--Formulario de registro de usuarios-->
            <div class="text-center">
                <h4>
                    <asp:Label CssClass="text-center" ID="NuevoOModificandoLabel" runat="server" Text="Nuevo usuario"></asp:Label></h4>
            </div>

            <div class="float-right">
                <asp:Button CssClass="btn btn-warning" ID="LimpiarButton" runat="server" Text="Nuevo" OnClick="LimpiarButton_Click" />
            </div>
            <br />

            <div class="form-group d-none">
                <label for="UsuarioIdTextBox">Usuario ID</label>
                <asp:TextBox CssClass="form-control" ID="UsuarioIdTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="NombreTextBox">Nombre</label>
                <asp:TextBox CssClass="form-control" ID="NombreTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="NombreUsuarioTextBox">Nombre de usuario</label>
                <asp:TextBox CssClass="form-control" ID="NombreUsuarioTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="ContrasenaTextBox">Contraseña</label>
                <asp:TextBox CssClass="form-control" ID="ContrasenaTextBox" runat="server" type="password" autocomplete="off"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="ConfirmarContrasenaTextBox">Confirmar contraseña</label>
                <asp:TextBox CssClass="form-control" ID="ConfirmarContrasenaTextBox" runat="server" type="password" autocomplete="off"></asp:TextBox>
            </div>

            <!--div class="form-group">
                <label for="select_cargo">
                Cargo</label>
                <select id="select_cargo" class="form-control" name="D1">
                    <option>Bibliotecario</option>
                    <option>Administrador</option>
                </select>
            </!--div-->

            <div class="form-group">
                <label for="CargoDropDownList">Confirmar contraseña</label>
                <asp:DropDownList CssClass="form-control" ID="CargoDropDownList" runat="server">
                    <asp:ListItem>Bibliotecario</asp:ListItem>
                    <asp:ListItem>Administrador</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label for="FechaCreacionTextBox">Fecha de creación</label>
                <asp:TextBox type="date" CssClass="form-control" ID="FechaCreacionTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>

            <!--div class="form-group">
                <div class="input-group">
                    <span class="input-group-addon">Usuario</span>
                    <input type="text" class="form-control" id="usuario" autocomplete="off" name="usaurio" placeholder=".">
                </div>
            </div-->

            <!--TexBoxes para controlar página-->
            <!--TextBox para manipular alertas-->

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

</asp:Content>
