﻿<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Base.Master" AutoEventWireup="true" CodeBehind="ConsultaUsuarios.aspx.cs" Inherits="BiblioTechWeb.UI.ConsultaUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <header class="text-center">
        <h1 class="display-1 d-none d-sm-block">BiblioTech</h1>
        <h1 class="display-4 d-sm-none">BiblioTech</h1>
    </header>
    <!--header-->
    <div class="page-header text-center">
        <h1>Consulta de usuarios</h1>
    </div>

    <div class="col-xs-12 col-sm-4 d-inline-block">
        <asp:DropDownList CssClass="form-control" ID="FiltrarDropDownList" runat="server">
            <asp:ListItem>Sin filtro</asp:ListItem>
            <asp:ListItem>ID</asp:ListItem>
            <asp:ListItem>Nombre</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="col-xs-12 col-sm-7 d-inline-block">
        <div class="form-group">
            <asp:TextBox CssClass="form-control" ID="FiltrarTextBox" runat="server" autocomplete="off"></asp:TextBox>
        </div>
    </div>

    <div class="col">
        <div class="form-group">
            <asp:CheckBox ID="FiltrarFechaCheckBox" runat="server" />
            <label for="FiltrarFechaCheckBox">Fitrar por fecha</label>
        </div>
    </div>

    <asp:Panel ID="FechasPanel" runat="server">
        <div class="col-xs-12 col-sm-5 d-inline-block">
            <div class="form-group">
                <label for="FechaDesdeTextBox">Desde</label>
                <asp:TextBox type="date" CssClass="form-control" ID="FechaDesdeTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
        </div>

        <div class="col-xs-12 col-sm-5 d-inline-block">
            <div class="form-group">
                <label for="FechaHastaTextBox">Hasta</label>
                <asp:TextBox type="date" CssClass="form-control" ID="FechaHastaTextBox" runat="server" autocomplete="off"></asp:TextBox>
            </div>
        </div>
    </asp:Panel>

    <div class="float-left">
        <asp:Button CssClass="btn btn-primary" ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
    </div>
    <div class="float-right">
        <a class="btn btn-success" href="../Reportes/ReporteUsuarios.aspx" id="ImprimirButton">Imprimir</a>
    </div>
    <br />
    <br />

    <!--Inputs de manipulación-->
    <asp:TextBox CssClass="d-none" ID="FilaTextBox" runat="server"></asp:TextBox>


    <!--Modal de confirmación eliminar-->
    <div class="modal" id="ModalConfirmacionEliminar">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header bg-danger">
                    <h5 class="modal-title">¡Advertencia!</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <p>¿Seguro que desea eliminar este usuario?</p>
                </div>
                <div class="modal-footer">
                    <asp:Button CssClass="btn btn-danger" ID="EliminarButton" runat="server" Text="Eliminar" OnClick="EliminarButton_Click" />
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                </div>
            </div>
        </div>
    </div>

    <!--Modal de confirmación modificar-->
    <div class="modal" id="ModalConfirmacionModificar">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header bg-warning">
                    <h5 class="modal-title">¡Advertencia!</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <p>¿Seguro que desea ir al registro de usuarios para modificar este usuario?</p>
                </div>
                <div class="modal-footer">
                    <asp:Button CssClass="btn btn-warning" ID="ModificarButton" runat="server" Text="Continuar" OnClick="ModificarButton_Click" />
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                </div>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-12">
            <!--Tabla de consultas-->
            <table class="table table-hover table-responsive">
                <!--Encabezados de la tabla-->
                <tr>
                    <th class="bg-info">Usuario ID</th>
                    <th class="bg-info">Nombre</th>
                    <th class="bg-info">Nombre de usuario</th>
                    <th class="bg-info">Cargo</th>
                    <th class="bg-info">Fecha de creación</th>
                    <th class="bg-info"></th>
                    <th class="bg-info"></th>
                </tr>

                <!--Resultado de la consulta-->
                <tbody id="listaF">
                    <% foreach (var usuario in Lista) %>
                    <% { Response.Write("<tr class='fila'> <td>" + usuario.UsuarioId + "</td> <td>" + usuario.Nombre + "</td> <td>" + usuario.NombreUsuario + "</td> <td>" + usuario.Cargo + "</td> <td>" + usuario.FechaCreacion.ToString().Substring(0, 10) + "</td> <td> <button class='btn-modificar btn btn-sm btn-warning' data-toggle='modal' data-target='#ModalConfirmacionModificar'>Modificar</button> </td> <td>  <button class='btn-eliminar btn btn-sm btn-danger' data-toggle='modal' data-target='#ModalConfirmacionEliminar'>Eliminar</button> </td> </tr>"); } %>
                </tbody>

                <tr>
                    <th class="bg-dark"></th>
                    <th class="bg-dark"></th>
                    <th class="bg-dark"></th>
                    <th class="bg-dark"></th>
                    <th class="bg-dark"></th>
                    <th class="bg-dark"></th>
                    <th class="bg-dark"></th>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>